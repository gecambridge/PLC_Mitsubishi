using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;

namespace Mitsubishi_PLC_QnUCPU_In_Ethernet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Socket client;
        int SendLen = 0;
        byte[] send_buff = null;
        byte[] receive_buff = null;
        IPAddress ipAddr;
        int port;
        IPEndPoint EndPoint;

        private void Form1_Load(object sender, EventArgs e)
        {
            //btn_connect_Click(sender, e);
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            ipAddr = IPAddress.Parse(tb_ipaddr.Text);
            port = Convert.ToInt16(tb_port.Text);
            EndPoint = new IPEndPoint(ipAddr, port);
            bool sc_result = false;

            if (client == null)
            {
                client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            }

            btn_connect.Enabled = false;
            btn_disconnect.Enabled = false;

            while (!sc_result)
            {
                sc_result = SocketConnect(EndPoint);
            }
        }

        private bool SocketConnect(IPEndPoint EndPoint)
        {
            try
            {
                client.Connect(EndPoint);

                btn_connect.Enabled = false;
                btn_disconnect.Enabled = true;

                tb_constatus.Text = "Connected";

                timer1.Enabled = true;
                timer1.Start();

                return true;
            }
            catch (SocketException ex)
            {
                return false;
            }
            catch (ArgumentNullException ex)
            {
                return false;
            }
            catch (ObjectDisposedException ex)
            {
                return false;
            }
            catch (InvalidOperationException ex)
            {
                return false;
            }    
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            uint DeviceNo;         //선두디바이스
            byte DeviceCode = 0xA8;     //디바이스코드
            ushort DeviceNum = 1;       //디바이스점수
            string read_result = null;  //결과값
            bool sc_result;             //연결상태

            sc_result = SocketConnectCheck();

            while (!sc_result)
            {
                sc_result = SocketConnect(EndPoint);
            }

            //Recoiler Tension
            DeviceNo = 3034;
            read_result = PLC_Read(DeviceNo, DeviceCode, DeviceNum);
            tb_tension.Text = read_result;

            //Counter
            DeviceNo = 3128;
            read_result = PLC_Read(DeviceNo, DeviceCode, DeviceNum);
            tb_counter.Text = read_result;

            //Line Speed
            DeviceNo = 3110;
            read_result = PLC_Read(DeviceNo, DeviceCode, DeviceNum);
            tb_speed.Text = read_result;
        }

        private bool SocketConnectCheck()
        {
            bool blockingState = client.Blocking;
            bool lb_return;

            try
            {
                byte[] tmp = new byte[1];

                client.Blocking = false;
                client.Send(tmp, 0, 0);

                lb_return = true;
            }
            catch
            {
                lb_return = false;
            }
            finally
            {
                client.Blocking = blockingState;
            }

            return lb_return;
        }

        private string PLC_Read(uint DeviceNo, byte DeviceCode, ushort DeviceNum)
        {
            MCProtocol_t send_protocol = new MCProtocol_t();
            string read_result = null;
            receive_buff = new byte[2096];

            //Protocol에 따른 Send 데이터 생성
            send_protocol.SubHeader = 0x0050;
            send_protocol.NetworkNo = 0x00;
            send_protocol.PcNo = 0xFF;
            send_protocol.IoNo = 0x03FF;
            send_protocol.UnitNo = 0x00;
            send_protocol.MonitoringTimer = 0x0010; 
            send_protocol.Command = 0x0401;
            send_protocol.SubCommand = 0x0000;
            send_protocol.DeviceNoCode = DeviceNo;
            send_protocol.DeviceNoCode |= (uint)DeviceCode << 24;
            send_protocol.DevieceNum = DeviceNum;

            send_protocol.DataLength = (ushort)Marshal.SizeOf(send_protocol.MonitoringTimer);
            send_protocol.DataLength += (ushort)Marshal.SizeOf(send_protocol.Command);
            send_protocol.DataLength += (ushort)Marshal.SizeOf(send_protocol.SubCommand);
            send_protocol.DataLength += (ushort)Marshal.SizeOf(send_protocol.DeviceNoCode);
            send_protocol.DataLength += (ushort)Marshal.SizeOf(send_protocol.DevieceNum);

            SendLen = (int)Marshal.SizeOf(send_protocol.SubHeader);
            SendLen += (int)Marshal.SizeOf(send_protocol.NetworkNo);
            SendLen += (int)Marshal.SizeOf(send_protocol.PcNo);
            SendLen += (int)Marshal.SizeOf(send_protocol.IoNo);
            SendLen += (int)Marshal.SizeOf(send_protocol.UnitNo);
            SendLen += (int)Marshal.SizeOf(send_protocol.DataLength);
            SendLen += (int)send_protocol.DataLength;

            //C#엔 포인터가 없기때문에 아래처럼 해야됨
            send_buff = new byte[Marshal.SizeOf(send_protocol)];
            unsafe
            {
                fixed (byte* fixed_buffer = send_buff)
                {
                    Marshal.StructureToPtr(send_protocol, (IntPtr)fixed_buffer, false);
                }
            }
                
            //프로토콜 Send
            try
            {
                client.Send(send_buff, SendLen, SocketFlags.None);
            }
            catch (SocketException ex)
            {
                return "0";
            }

            read_result = RecvPacket(receive_buff);
            
            return read_result;
        }


        private string RecvPacket(byte[] receive_buff)
        {
            try
            {
                string readstr;
                string temp;
                int bytes = client.Receive(receive_buff, receive_buff.Length, 0);
                temp = BitConverter.ToString(receive_buff, 0, bytes);
                readstr = temp.Replace("-", "");

                var buf = new byte[bytes];
                Buffer.BlockCopy(receive_buff, 0, buf, 0, bytes);

                /*여기에서 에러발생. RecvMCProtocol_t에 public byte[] ReadResult; 선언한게 있는데 얘를 빼고 서버쪽또 빼고 테스트하면 잘됨.
                서버에서 오는 데이터
                toSend = new byte[] {
                                0xD0, 0x00, 0x00, 0xFF, 0xFF, 0x03, 0x00, 0x04, 0x00, 0x00, 0x00,
                                // data
                                0x12, 0x00
                 위의 data 부분이 문제가 되고있음. 이런경우는 어떻게 잡아줘야 serialize가 되니?
                 */
                RecvMCProtocol_t protocol = MCSerializer.Deserialize<RecvMCProtocol_t>(buf);

                return readstr;
            }
            catch
            {
                return "0";
            }
        }

        private void btn_disconnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (client != null)
                {

                    timer1.Enabled = false;
                    timer1.Stop();

                    client.Shutdown(SocketShutdown.Both);
                    client.Close();
                    client = null;
                    
                    tb_constatus.Text = "Disconnected";

                    btn_connect.Enabled = true;
                    btn_disconnect.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        private void lb_title_Click(object sender, EventArgs e)
        {

        }

        private void tb_constatus_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
