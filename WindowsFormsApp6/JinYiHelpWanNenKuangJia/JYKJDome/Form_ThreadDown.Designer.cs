namespace JYKJDome
{
    partial class Form_ThreadDown
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
            this.but_start = new System.Windows.Forms.Button();
            this.pro_down = new System.Windows.Forms.ProgressBar();
            this.but_stop = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // but_start
            // 
            this.but_start.Location = new System.Drawing.Point(285, 92);
            this.but_start.Name = "but_start";
            this.but_start.Size = new System.Drawing.Size(75, 23);
            this.but_start.TabIndex = 0;
            this.but_start.Text = "开始下载";
            this.but_start.UseVisualStyleBackColor = true;
            this.but_start.Click += new System.EventHandler(this.button1_Click);
            // 
            // pro_down
            // 
            this.pro_down.Location = new System.Drawing.Point(39, 127);
            this.pro_down.Name = "pro_down";
            this.pro_down.Size = new System.Drawing.Size(225, 23);
            this.pro_down.TabIndex = 1;
            // 
            // but_stop
            // 
            this.but_stop.Location = new System.Drawing.Point(285, 137);
            this.but_stop.Name = "but_stop";
            this.but_stop.Size = new System.Drawing.Size(75, 23);
            this.but_stop.TabIndex = 2;
            this.but_stop.Text = "暂停";
            this.but_stop.UseVisualStyleBackColor = true;
            this.but_stop.Click += new System.EventHandler(this.but_stop_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(285, 185);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "继续";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form_ThreadDown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 286);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.but_stop);
            this.Controls.Add(this.pro_down);
            this.Controls.Add(this.but_start);
            this.Name = "Form_ThreadDown";
            this.Text = "多线程下载文件";
            this.Load += new System.EventHandler(this.Form_ThreadDown_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button but_start;
        private System.Windows.Forms.ProgressBar pro_down;
        private System.Windows.Forms.Button but_stop;
        private System.Windows.Forms.Button button3;
    }
}