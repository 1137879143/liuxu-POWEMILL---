namespace JYKJDome
{
    partial class Form_DM
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lab_hand = new System.Windows.Forms.Label();
            this.lab_xy = new System.Windows.Forms.Label();
            this.txt_hand = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.but_bind = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnScreenshot = new System.Windows.Forms.Button();
            this.btnWord = new System.Windows.Forms.Button();
            this.btnPic = new System.Windows.Forms.Button();
            this.btnType = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lab_hand);
            this.groupBox1.Controls.Add(this.lab_xy);
            this.groupBox1.Controls.Add(this.txt_hand);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.but_bind);
            this.groupBox1.Location = new System.Drawing.Point(12, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 120);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "绑定句柄";
            // 
            // lab_hand
            // 
            this.lab_hand.AutoSize = true;
            this.lab_hand.Location = new System.Drawing.Point(44, 26);
            this.lab_hand.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_hand.Name = "lab_hand";
            this.lab_hand.Size = new System.Drawing.Size(29, 12);
            this.lab_hand.TabIndex = 20;
            this.lab_hand.Text = "0000";
            // 
            // lab_xy
            // 
            this.lab_xy.AutoSize = true;
            this.lab_xy.Dock = System.Windows.Forms.DockStyle.Right;
            this.lab_xy.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lab_xy.Location = new System.Drawing.Point(255, 17);
            this.lab_xy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_xy.Name = "lab_xy";
            this.lab_xy.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lab_xy.Size = new System.Drawing.Size(23, 12);
            this.lab_xy.TabIndex = 19;
            this.lab_xy.Text = "x,y";
            this.lab_xy.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txt_hand
            // 
            this.txt_hand.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_hand.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txt_hand.Location = new System.Drawing.Point(7, 50);
            this.txt_hand.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_hand.Name = "txt_hand";
            this.txt_hand.Size = new System.Drawing.Size(93, 19);
            this.txt_hand.TabIndex = 18;
            this.txt_hand.Text = "Alt+1 快速键入";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 17;
            this.label1.Text = "句柄：";
            // 
            // but_bind
            // 
            this.but_bind.Location = new System.Drawing.Point(115, 40);
            this.but_bind.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.but_bind.Name = "but_bind";
            this.but_bind.Size = new System.Drawing.Size(87, 29);
            this.but_bind.TabIndex = 16;
            this.but_bind.Text = "绑定句柄";
            this.but_bind.UseVisualStyleBackColor = true;
            this.but_bind.Click += new System.EventHandler(this.but_bind_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnHelp);
            this.groupBox2.Controls.Add(this.btnScreenshot);
            this.groupBox2.Controls.Add(this.btnWord);
            this.groupBox2.Controls.Add(this.btnPic);
            this.groupBox2.Controls.Add(this.btnType);
            this.groupBox2.Location = new System.Drawing.Point(11, 172);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Size = new System.Drawing.Size(170, 107);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "功能";
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(102, 66);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(36, 35);
            this.btnHelp.TabIndex = 8;
            this.btnHelp.Text = "功能说明";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnScreenshot
            // 
            this.btnScreenshot.Location = new System.Drawing.Point(48, 59);
            this.btnScreenshot.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnScreenshot.Name = "btnScreenshot";
            this.btnScreenshot.Size = new System.Drawing.Size(36, 35);
            this.btnScreenshot.TabIndex = 7;
            this.btnScreenshot.Text = "截图";
            this.btnScreenshot.UseVisualStyleBackColor = true;
            this.btnScreenshot.Click += new System.EventHandler(this.btnScreenshot_Click);
            // 
            // btnWord
            // 
            this.btnWord.Location = new System.Drawing.Point(7, 59);
            this.btnWord.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnWord.Name = "btnWord";
            this.btnWord.Size = new System.Drawing.Size(36, 35);
            this.btnWord.TabIndex = 6;
            this.btnWord.Text = "找字";
            this.btnWord.UseVisualStyleBackColor = true;
            this.btnWord.Click += new System.EventHandler(this.btnWord_Click);
            // 
            // btnPic
            // 
            this.btnPic.Location = new System.Drawing.Point(48, 19);
            this.btnPic.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPic.Name = "btnPic";
            this.btnPic.Size = new System.Drawing.Size(36, 35);
            this.btnPic.TabIndex = 5;
            this.btnPic.Text = "找图";
            this.btnPic.UseVisualStyleBackColor = true;
            this.btnPic.Click += new System.EventHandler(this.btnPic_Click);
            // 
            // btnType
            // 
            this.btnType.Location = new System.Drawing.Point(7, 19);
            this.btnType.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnType.Name = "btnType";
            this.btnType.Size = new System.Drawing.Size(36, 35);
            this.btnType.TabIndex = 4;
            this.btnType.Text = "打字";
            this.btnType.UseVisualStyleBackColor = true;
            this.btnType.Click += new System.EventHandler(this.btnType_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 261);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 21;
            this.label2.Text = "1234567890";
            // 
            // Form_DM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 353);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_DM";
            this.Text = "测试大馍";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_DM_FormClosing);
            this.Load += new System.EventHandler(this.Form_DM_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lab_hand;
        private System.Windows.Forms.Label lab_xy;
        private System.Windows.Forms.TextBox txt_hand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button but_bind;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnScreenshot;
        private System.Windows.Forms.Button btnWord;
        private System.Windows.Forms.Button btnPic;
        private System.Windows.Forms.Button btnType;
        private System.Windows.Forms.Label label2;
    }
}