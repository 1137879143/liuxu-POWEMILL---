namespace JYKJDome
{
    partial class Form_test
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.but_GetPic = new System.Windows.Forms.Button();
            this.but_Post = new System.Windows.Forms.Button();
            this.but_Get = new System.Windows.Forms.Button();
            this.pic_img = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_Info = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.but_img = new System.Windows.Forms.Button();
            this.but_Test = new System.Windows.Forms.Button();
            this.but_zip = new System.Windows.Forms.Button();
            this.but_socket = new System.Windows.Forms.Button();
            this.but_thread = new System.Windows.Forms.Button();
            this.but_ftp = new System.Windows.Forms.Button();
            this.but_dm = new System.Windows.Forms.Button();
            this.but_win32 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_img)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.but_GetPic);
            this.groupBox1.Controls.Add(this.but_Post);
            this.groupBox1.Controls.Add(this.but_Get);
            this.groupBox1.Controls.Add(this.pic_img);
            this.groupBox1.Location = new System.Drawing.Point(47, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 130);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "测试区域";
            // 
            // but_GetPic
            // 
            this.but_GetPic.Location = new System.Drawing.Point(223, 74);
            this.but_GetPic.Name = "but_GetPic";
            this.but_GetPic.Size = new System.Drawing.Size(75, 23);
            this.but_GetPic.TabIndex = 15;
            this.but_GetPic.Text = "访问图片";
            this.but_GetPic.UseVisualStyleBackColor = true;
            this.but_GetPic.Click += new System.EventHandler(this.but_GetPic_Click);
            // 
            // but_Post
            // 
            this.but_Post.Location = new System.Drawing.Point(223, 45);
            this.but_Post.Name = "but_Post";
            this.but_Post.Size = new System.Drawing.Size(75, 23);
            this.but_Post.TabIndex = 13;
            this.but_Post.Text = "一键Post";
            this.but_Post.UseVisualStyleBackColor = true;
            this.but_Post.Click += new System.EventHandler(this.but_Post_Click);
            // 
            // but_Get
            // 
            this.but_Get.Location = new System.Drawing.Point(223, 20);
            this.but_Get.Name = "but_Get";
            this.but_Get.Size = new System.Drawing.Size(75, 23);
            this.but_Get.TabIndex = 14;
            this.but_Get.Text = "一键Get";
            this.but_Get.UseVisualStyleBackColor = true;
            this.but_Get.Click += new System.EventHandler(this.but_Get_Click);
            // 
            // pic_img
            // 
            this.pic_img.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_img.Location = new System.Drawing.Point(13, 18);
            this.pic_img.Name = "pic_img";
            this.pic_img.Size = new System.Drawing.Size(193, 106);
            this.pic_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_img.TabIndex = 12;
            this.pic_img.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_Info);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 161);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(653, 304);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "日志";
            // 
            // txt_Info
            // 
            this.txt_Info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Info.Location = new System.Drawing.Point(3, 17);
            this.txt_Info.Multiline = true;
            this.txt_Info.Name = "txt_Info";
            this.txt_Info.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Info.Size = new System.Drawing.Size(647, 284);
            this.txt_Info.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.but_img);
            this.groupBox3.Controls.Add(this.but_Test);
            this.groupBox3.Controls.Add(this.but_zip);
            this.groupBox3.Controls.Add(this.but_socket);
            this.groupBox3.Controls.Add(this.but_thread);
            this.groupBox3.Controls.Add(this.but_ftp);
            this.groupBox3.Controls.Add(this.but_dm);
            this.groupBox3.Controls.Add(this.but_win32);
            this.groupBox3.Location = new System.Drawing.Point(357, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(284, 142);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "其它";
            // 
            // but_img
            // 
            this.but_img.Location = new System.Drawing.Point(13, 100);
            this.but_img.Name = "but_img";
            this.but_img.Size = new System.Drawing.Size(75, 30);
            this.but_img.TabIndex = 17;
            this.but_img.Text = "img";
            this.but_img.UseVisualStyleBackColor = true;
            this.but_img.Click += new System.EventHandler(this.but_img_Click);
            // 
            // but_Test
            // 
            this.but_Test.Location = new System.Drawing.Point(191, 104);
            this.but_Test.Name = "but_Test";
            this.but_Test.Size = new System.Drawing.Size(75, 23);
            this.but_Test.TabIndex = 16;
            this.but_Test.Text = "Test";
            this.but_Test.UseVisualStyleBackColor = true;
            this.but_Test.Click += new System.EventHandler(this.but_Test_Click_1);
            // 
            // but_zip
            // 
            this.but_zip.Location = new System.Drawing.Point(190, 65);
            this.but_zip.Name = "but_zip";
            this.but_zip.Size = new System.Drawing.Size(76, 30);
            this.but_zip.TabIndex = 5;
            this.but_zip.Text = "解压缩";
            this.but_zip.UseVisualStyleBackColor = true;
            this.but_zip.Click += new System.EventHandler(this.but_zip_Click);
            // 
            // but_socket
            // 
            this.but_socket.Location = new System.Drawing.Point(190, 29);
            this.but_socket.Name = "but_socket";
            this.but_socket.Size = new System.Drawing.Size(76, 30);
            this.but_socket.TabIndex = 4;
            this.but_socket.Text = "socket";
            this.but_socket.UseVisualStyleBackColor = true;
            this.but_socket.Click += new System.EventHandler(this.but_socket_Click);
            // 
            // but_thread
            // 
            this.but_thread.Location = new System.Drawing.Point(109, 64);
            this.but_thread.Name = "but_thread";
            this.but_thread.Size = new System.Drawing.Size(75, 30);
            this.but_thread.TabIndex = 3;
            this.but_thread.Text = "多线程下载";
            this.but_thread.UseVisualStyleBackColor = true;
            this.but_thread.Click += new System.EventHandler(this.but_thread_Click);
            // 
            // but_ftp
            // 
            this.but_ftp.Location = new System.Drawing.Point(13, 64);
            this.but_ftp.Name = "but_ftp";
            this.but_ftp.Size = new System.Drawing.Size(75, 30);
            this.but_ftp.TabIndex = 2;
            this.but_ftp.Text = "ftp";
            this.but_ftp.UseVisualStyleBackColor = true;
            this.but_ftp.Click += new System.EventHandler(this.but_ftp_Click);
            // 
            // but_dm
            // 
            this.but_dm.Location = new System.Drawing.Point(109, 28);
            this.but_dm.Name = "but_dm";
            this.but_dm.Size = new System.Drawing.Size(75, 30);
            this.but_dm.TabIndex = 1;
            this.but_dm.Text = "大漠";
            this.but_dm.UseVisualStyleBackColor = true;
            this.but_dm.Click += new System.EventHandler(this.but_dm_Click);
            // 
            // but_win32
            // 
            this.but_win32.Location = new System.Drawing.Point(13, 28);
            this.but_win32.Name = "but_win32";
            this.but_win32.Size = new System.Drawing.Size(75, 30);
            this.but_win32.TabIndex = 0;
            this.but_win32.Text = "win32";
            this.but_win32.UseVisualStyleBackColor = true;
            this.but_win32.Click += new System.EventHandler(this.but_win32_Click);
            // 
            // Form_test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 465);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_test";
            this.Text = "HttpTest";
            this.Load += new System.EventHandler(this.Form_test_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_img)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button but_GetPic;
        private System.Windows.Forms.Button but_Post;
        private System.Windows.Forms.Button but_Get;
        private System.Windows.Forms.PictureBox pic_img;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_Info;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button but_win32;
        private System.Windows.Forms.Button but_dm;
        private System.Windows.Forms.Button but_ftp;
        private System.Windows.Forms.Button but_thread;
        private System.Windows.Forms.Button but_socket;
        private System.Windows.Forms.Button but_zip;
        private System.Windows.Forms.Button but_img;
        private System.Windows.Forms.Button but_Test;
    }
}

