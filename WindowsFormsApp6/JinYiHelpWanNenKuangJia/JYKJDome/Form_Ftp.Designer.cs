namespace JYKJDome
{
    partial class Form_Ftp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Ftp));
            this.but_up = new System.Windows.Forms.Button();
            this.pro_up = new System.Windows.Forms.ProgressBar();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.but_down = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // but_up
            // 
            this.but_up.Location = new System.Drawing.Point(246, 63);
            this.but_up.Name = "but_up";
            this.but_up.Size = new System.Drawing.Size(75, 23);
            this.but_up.TabIndex = 0;
            this.but_up.Text = "上传";
            this.but_up.UseVisualStyleBackColor = true;
            this.but_up.Click += new System.EventHandler(this.but_up_Click);
            // 
            // pro_up
            // 
            this.pro_up.Location = new System.Drawing.Point(43, 63);
            this.pro_up.Name = "pro_up";
            this.pro_up.Size = new System.Drawing.Size(172, 23);
            this.pro_up.TabIndex = 1;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // but_down
            // 
            this.but_down.Location = new System.Drawing.Point(246, 119);
            this.but_down.Name = "but_down";
            this.but_down.Size = new System.Drawing.Size(75, 23);
            this.but_down.TabIndex = 2;
            this.but_down.Text = "下载";
            this.but_down.UseVisualStyleBackColor = true;
            this.but_down.Click += new System.EventHandler(this.but_down_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(192, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "获取服务器文件";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_Ftp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 224);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.but_down);
            this.Controls.Add(this.pro_up);
            this.Controls.Add(this.but_up);
            this.Name = "Form_Ftp";
            this.Text = "Ftp测试";
            this.Load += new System.EventHandler(this.Form_Ftp_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button but_up;
        private System.Windows.Forms.ProgressBar pro_up;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button but_down;
        private System.Windows.Forms.Button button1;
    }
}