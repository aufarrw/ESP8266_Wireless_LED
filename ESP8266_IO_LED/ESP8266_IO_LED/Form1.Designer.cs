namespace ESP8266_Potensio
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.tbIP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbLed2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbLed1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnON1 = new System.Windows.Forms.Button();
            this.btnOFF1 = new System.Windows.Forms.Button();
            this.btnOFF2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnON2 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbPort);
            this.groupBox2.Controls.Add(this.tbIP);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnOpen);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 160);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "COM PORT SETTING";
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(105, 70);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(116, 20);
            this.tbPort.TabIndex = 16;
            this.tbPort.Text = "56";
            // 
            // tbIP
            // 
            this.tbIP.Location = new System.Drawing.Point(105, 40);
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(116, 20);
            this.tbIP.TabIndex = 7;
            this.tbIP.Text = "192.168.18.77";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Port :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "IP Address :";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(162, 112);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 12;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbLed2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbLed1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 178);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 81);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Received";
            // 
            // tbLed2
            // 
            this.tbLed2.Location = new System.Drawing.Point(95, 45);
            this.tbLed2.Name = "tbLed2";
            this.tbLed2.ReadOnly = true;
            this.tbLed2.Size = new System.Drawing.Size(116, 20);
            this.tbLed2.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "LED 2 :";
            // 
            // tbLed1
            // 
            this.tbLed1.Location = new System.Drawing.Point(95, 19);
            this.tbLed1.Multiline = true;
            this.tbLed1.Name = "tbLed1";
            this.tbLed1.ReadOnly = true;
            this.tbLed1.Size = new System.Drawing.Size(116, 20);
            this.tbLed1.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "LED 1 :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.btnON1);
            this.groupBox3.Controls.Add(this.btnOFF1);
            this.groupBox3.Controls.Add(this.btnOFF2);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btnON2);
            this.groupBox3.Location = new System.Drawing.Point(261, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(181, 247);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lampu";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(67, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Lampu 2";
            // 
            // btnON1
            // 
            this.btnON1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnON1.Location = new System.Drawing.Point(55, 38);
            this.btnON1.Name = "btnON1";
            this.btnON1.Size = new System.Drawing.Size(75, 23);
            this.btnON1.TabIndex = 0;
            this.btnON1.Text = "ON";
            this.btnON1.UseVisualStyleBackColor = true;
            this.btnON1.Click += new System.EventHandler(this.btnON1_Click);
            // 
            // btnOFF1
            // 
            this.btnOFF1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOFF1.Location = new System.Drawing.Point(55, 84);
            this.btnOFF1.Name = "btnOFF1";
            this.btnOFF1.Size = new System.Drawing.Size(75, 23);
            this.btnOFF1.TabIndex = 1;
            this.btnOFF1.Text = "OFF";
            this.btnOFF1.UseVisualStyleBackColor = true;
            this.btnOFF1.Click += new System.EventHandler(this.btnOFF1_Click);
            // 
            // btnOFF2
            // 
            this.btnOFF2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOFF2.Location = new System.Drawing.Point(55, 207);
            this.btnOFF2.Name = "btnOFF2";
            this.btnOFF2.Size = new System.Drawing.Size(75, 23);
            this.btnOFF2.TabIndex = 3;
            this.btnOFF2.Text = "OFF";
            this.btnOFF2.UseVisualStyleBackColor = true;
            this.btnOFF2.Click += new System.EventHandler(this.btnOFF2_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Lampu 1";
            // 
            // btnON2
            // 
            this.btnON2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnON2.Location = new System.Drawing.Point(55, 161);
            this.btnON2.Name = "btnON2";
            this.btnON2.Size = new System.Drawing.Size(75, 23);
            this.btnON2.TabIndex = 2;
            this.btnON2.Text = "ON";
            this.btnON2.UseVisualStyleBackColor = true;
            this.btnON2.Click += new System.EventHandler(this.btnON2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 268);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.TextBox tbIP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbLed2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbLed1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnON1;
        private System.Windows.Forms.Button btnOFF1;
        private System.Windows.Forms.Button btnOFF2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnON2;
    }
}

