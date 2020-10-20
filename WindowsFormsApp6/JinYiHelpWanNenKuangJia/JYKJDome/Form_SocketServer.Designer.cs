namespace JYKJDome
{
    partial class Form_SocketServer
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
            this.labClientCount = new System.Windows.Forms.Label();
            this.bn_Resume = new System.Windows.Forms.Button();
            this.bn_Stop = new System.Windows.Forms.Button();
            this.bn_Start = new System.Windows.Forms.Button();
            this.lb_ServerInfo = new System.Windows.Forms.ListBox();
            this.but_newClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labClientCount
            // 
            this.labClientCount.AutoSize = true;
            this.labClientCount.Location = new System.Drawing.Point(571, 25);
            this.labClientCount.Name = "labClientCount";
            this.labClientCount.Size = new System.Drawing.Size(11, 12);
            this.labClientCount.TabIndex = 80;
            this.labClientCount.Text = "0";
            // 
            // bn_Resume
            // 
            this.bn_Resume.Location = new System.Drawing.Point(172, 25);
            this.bn_Resume.Name = "bn_Resume";
            this.bn_Resume.Size = new System.Drawing.Size(97, 23);
            this.bn_Resume.TabIndex = 77;
            this.bn_Resume.Text = "SendToAll";
            this.bn_Resume.UseVisualStyleBackColor = true;
            this.bn_Resume.Click += new System.EventHandler(this.bn_Resume_Click);
            // 
            // bn_Stop
            // 
            this.bn_Stop.Location = new System.Drawing.Point(109, 25);
            this.bn_Stop.Name = "bn_Stop";
            this.bn_Stop.Size = new System.Drawing.Size(57, 23);
            this.bn_Stop.TabIndex = 76;
            this.bn_Stop.Text = "停止";
            this.bn_Stop.UseVisualStyleBackColor = true;
            this.bn_Stop.Click += new System.EventHandler(this.bn_Stop_Click);
            // 
            // bn_Start
            // 
            this.bn_Start.Location = new System.Drawing.Point(12, 25);
            this.bn_Start.Name = "bn_Start";
            this.bn_Start.Size = new System.Drawing.Size(86, 23);
            this.bn_Start.TabIndex = 75;
            this.bn_Start.Text = "启动服务器";
            this.bn_Start.UseVisualStyleBackColor = true;
            this.bn_Start.Click += new System.EventHandler(this.bn_Start_Click);
            // 
            // lb_ServerInfo
            // 
            this.lb_ServerInfo.FormattingEnabled = true;
            this.lb_ServerInfo.ItemHeight = 12;
            this.lb_ServerInfo.Location = new System.Drawing.Point(12, 54);
            this.lb_ServerInfo.Name = "lb_ServerInfo";
            this.lb_ServerInfo.Size = new System.Drawing.Size(572, 184);
            this.lb_ServerInfo.TabIndex = 74;
            // 
            // but_newClient
            // 
            this.but_newClient.Location = new System.Drawing.Point(439, 25);
            this.but_newClient.Name = "but_newClient";
            this.but_newClient.Size = new System.Drawing.Size(86, 23);
            this.but_newClient.TabIndex = 81;
            this.but_newClient.Text = "启动客服端";
            this.but_newClient.UseVisualStyleBackColor = true;
            this.but_newClient.Click += new System.EventHandler(this.but_newClient_Click);
            // 
            // Form_SocketServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 278);
            this.Controls.Add(this.but_newClient);
            this.Controls.Add(this.labClientCount);
            this.Controls.Add(this.bn_Resume);
            this.Controls.Add(this.bn_Stop);
            this.Controls.Add(this.bn_Start);
            this.Controls.Add(this.lb_ServerInfo);
            this.Name = "Form_SocketServer";
            this.Text = "Form_SocketServer";
            this.Load += new System.EventHandler(this.Form_SocketServer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labClientCount;
        private System.Windows.Forms.Button bn_Resume;
        private System.Windows.Forms.Button bn_Stop;
        private System.Windows.Forms.Button bn_Start;
        private System.Windows.Forms.ListBox lb_ServerInfo;
        private System.Windows.Forms.Button but_newClient;
    }
}