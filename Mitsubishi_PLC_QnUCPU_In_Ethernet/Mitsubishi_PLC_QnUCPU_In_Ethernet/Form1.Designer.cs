namespace Mitsubishi_PLC_QnUCPU_In_Ethernet
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lb_title = new System.Windows.Forms.Label();
            this.btn_disconnect = new System.Windows.Forms.Button();
            this.tb_ipaddr = new System.Windows.Forms.TextBox();
            this.lb_ipaddr = new System.Windows.Forms.Label();
            this.lb_port = new System.Windows.Forms.Label();
            this.tb_port = new System.Windows.Forms.TextBox();
            this.lb_tension = new System.Windows.Forms.Label();
            this.tb_tension = new System.Windows.Forms.TextBox();
            this.lb_counter = new System.Windows.Forms.Label();
            this.tb_counter = new System.Windows.Forms.TextBox();
            this.lb_speed = new System.Windows.Forms.Label();
            this.tb_speed = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_connect = new System.Windows.Forms.Button();
            this.tb_constatus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_title.Location = new System.Drawing.Point(12, 9);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(267, 20);
            this.lb_title.TabIndex = 0;
            this.lb_title.Text = "▣ Q30UDE CPU 인터페이스 프로그램";
            this.lb_title.Click += new System.EventHandler(this.lb_title_Click);
            // 
            // btn_disconnect
            // 
            this.btn_disconnect.Enabled = false;
            this.btn_disconnect.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_disconnect.Location = new System.Drawing.Point(309, 41);
            this.btn_disconnect.Name = "btn_disconnect";
            this.btn_disconnect.Size = new System.Drawing.Size(75, 27);
            this.btn_disconnect.TabIndex = 2;
            this.btn_disconnect.Text = "접속해제";
            this.btn_disconnect.UseVisualStyleBackColor = true;
            this.btn_disconnect.Click += new System.EventHandler(this.btn_disconnect_Click);
            // 
            // tb_ipaddr
            // 
            this.tb_ipaddr.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_ipaddr.Location = new System.Drawing.Point(101, 42);
            this.tb_ipaddr.Name = "tb_ipaddr";
            this.tb_ipaddr.Size = new System.Drawing.Size(114, 25);
            this.tb_ipaddr.TabIndex = 3;
            this.tb_ipaddr.Text = "127.0.0.1";
            this.tb_ipaddr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_ipaddr
            // 
            this.lb_ipaddr.AutoSize = true;
            this.lb_ipaddr.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_ipaddr.Location = new System.Drawing.Point(13, 46);
            this.lb_ipaddr.Name = "lb_ipaddr";
            this.lb_ipaddr.Size = new System.Drawing.Size(76, 17);
            this.lb_ipaddr.TabIndex = 4;
            this.lb_ipaddr.Text = "PLC IP 주소";
            this.lb_ipaddr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_port
            // 
            this.lb_port.AutoSize = true;
            this.lb_port.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_port.Location = new System.Drawing.Point(13, 77);
            this.lb_port.Name = "lb_port";
            this.lb_port.Size = new System.Drawing.Size(86, 17);
            this.lb_port.TabIndex = 6;
            this.lb_port.Text = "PLC 포트번호";
            // 
            // tb_port
            // 
            this.tb_port.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_port.Location = new System.Drawing.Point(101, 73);
            this.tb_port.Name = "tb_port";
            this.tb_port.Size = new System.Drawing.Size(114, 25);
            this.tb_port.TabIndex = 5;
            this.tb_port.Text = "11000";
            this.tb_port.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_tension
            // 
            this.lb_tension.AutoSize = true;
            this.lb_tension.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_tension.Location = new System.Drawing.Point(13, 117);
            this.lb_tension.Name = "lb_tension";
            this.lb_tension.Size = new System.Drawing.Size(107, 17);
            this.lb_tension.TabIndex = 8;
            this.lb_tension.Text = "Recoiler Tension";
            // 
            // tb_tension
            // 
            this.tb_tension.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_tension.Location = new System.Drawing.Point(13, 135);
            this.tb_tension.Name = "tb_tension";
            this.tb_tension.Size = new System.Drawing.Size(114, 25);
            this.tb_tension.TabIndex = 7;
            this.tb_tension.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_counter
            // 
            this.lb_counter.AutoSize = true;
            this.lb_counter.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_counter.Location = new System.Drawing.Point(138, 117);
            this.lb_counter.Name = "lb_counter";
            this.lb_counter.Size = new System.Drawing.Size(56, 17);
            this.lb_counter.TabIndex = 10;
            this.lb_counter.Text = "Counter";
            // 
            // tb_counter
            // 
            this.tb_counter.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_counter.Location = new System.Drawing.Point(138, 135);
            this.tb_counter.Name = "tb_counter";
            this.tb_counter.Size = new System.Drawing.Size(114, 25);
            this.tb_counter.TabIndex = 9;
            this.tb_counter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_speed
            // 
            this.lb_speed.AutoSize = true;
            this.lb_speed.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_speed.Location = new System.Drawing.Point(263, 117);
            this.lb_speed.Name = "lb_speed";
            this.lb_speed.Size = new System.Drawing.Size(74, 17);
            this.lb_speed.TabIndex = 12;
            this.lb_speed.Text = "Line Speed";
            // 
            // tb_speed
            // 
            this.tb_speed.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_speed.Location = new System.Drawing.Point(263, 135);
            this.tb_speed.Name = "tb_speed";
            this.tb_speed.Size = new System.Drawing.Size(114, 25);
            this.tb_speed.TabIndex = 11;
            this.tb_speed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_connect
            // 
            this.btn_connect.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_connect.Location = new System.Drawing.Point(228, 41);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(75, 27);
            this.btn_connect.TabIndex = 1;
            this.btn_connect.Text = "PLC접속";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // tb_constatus
            // 
            this.tb_constatus.Enabled = false;
            this.tb_constatus.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_constatus.Location = new System.Drawing.Point(228, 73);
            this.tb_constatus.Name = "tb_constatus";
            this.tb_constatus.Size = new System.Drawing.Size(155, 25);
            this.tb_constatus.TabIndex = 13;
            this.tb_constatus.Text = "Disconnected";
            this.tb_constatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_constatus.TextChanged += new System.EventHandler(this.tb_constatus_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 172);
            this.Controls.Add(this.tb_constatus);
            this.Controls.Add(this.lb_speed);
            this.Controls.Add(this.tb_speed);
            this.Controls.Add(this.lb_counter);
            this.Controls.Add(this.tb_counter);
            this.Controls.Add(this.lb_tension);
            this.Controls.Add(this.tb_tension);
            this.Controls.Add(this.lb_port);
            this.Controls.Add(this.tb_port);
            this.Controls.Add(this.lb_ipaddr);
            this.Controls.Add(this.tb_ipaddr);
            this.Controls.Add(this.btn_disconnect);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.lb_title);
            this.Name = "Form1";
            this.Text = "Mitsubishi PLC QnUCPU In Ethernet";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.Button btn_disconnect;
        private System.Windows.Forms.TextBox tb_ipaddr;
        private System.Windows.Forms.Label lb_ipaddr;
        private System.Windows.Forms.Label lb_port;
        private System.Windows.Forms.TextBox tb_port;
        private System.Windows.Forms.Label lb_tension;
        private System.Windows.Forms.TextBox tb_tension;
        private System.Windows.Forms.Label lb_counter;
        private System.Windows.Forms.TextBox tb_counter;
        private System.Windows.Forms.Label lb_speed;
        private System.Windows.Forms.TextBox tb_speed;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.TextBox tb_constatus;
    }
}

