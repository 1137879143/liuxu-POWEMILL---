namespace JYKJDome
{
    partial class Form_Image
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
            this.pic_old = new System.Windows.Forms.PictureBox();
            this.pic_new = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.but_Resize = new System.Windows.Forms.Button();
            this.but_CutImage = new System.Windows.Forms.Button();
            this.but_ZoomAuto = new System.Windows.Forms.Button();
            this.but_CutForCustom = new System.Windows.Forms.Button();
            this.but_CutForSquare = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_old)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_new)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pic_old
            // 
            this.pic_old.Location = new System.Drawing.Point(12, 12);
            this.pic_old.Name = "pic_old";
            this.pic_old.Size = new System.Drawing.Size(90, 90);
            this.pic_old.TabIndex = 0;
            this.pic_old.TabStop = false;
            // 
            // pic_new
            // 
            this.pic_new.Location = new System.Drawing.Point(282, 12);
            this.pic_new.Name = "pic_new";
            this.pic_new.Size = new System.Drawing.Size(120, 120);
            this.pic_new.TabIndex = 1;
            this.pic_new.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.but_Resize);
            this.groupBox1.Controls.Add(this.but_CutImage);
            this.groupBox1.Controls.Add(this.but_ZoomAuto);
            this.groupBox1.Controls.Add(this.but_CutForCustom);
            this.groupBox1.Controls.Add(this.but_CutForSquare);
            this.groupBox1.Location = new System.Drawing.Point(129, 191);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 131);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "功能";
            // 
            // but_Resize
            // 
            this.but_Resize.Location = new System.Drawing.Point(130, 92);
            this.but_Resize.Name = "but_Resize";
            this.but_Resize.Size = new System.Drawing.Size(75, 23);
            this.but_Resize.TabIndex = 7;
            this.but_Resize.Text = "缩放";
            this.but_Resize.UseVisualStyleBackColor = true;
            this.but_Resize.Click += new System.EventHandler(this.but_Resize_Click);
            // 
            // but_CutImage
            // 
            this.but_CutImage.Location = new System.Drawing.Point(17, 92);
            this.but_CutImage.Name = "but_CutImage";
            this.but_CutImage.Size = new System.Drawing.Size(75, 23);
            this.but_CutImage.TabIndex = 6;
            this.but_CutImage.Text = "剪裁图片";
            this.but_CutImage.UseVisualStyleBackColor = true;
            this.but_CutImage.Click += new System.EventHandler(this.but_CutImage_Click);
            // 
            // but_ZoomAuto
            // 
            this.but_ZoomAuto.Location = new System.Drawing.Point(246, 40);
            this.but_ZoomAuto.Name = "but_ZoomAuto";
            this.but_ZoomAuto.Size = new System.Drawing.Size(75, 23);
            this.but_ZoomAuto.TabIndex = 5;
            this.but_ZoomAuto.Text = "等比例缩放";
            this.but_ZoomAuto.UseVisualStyleBackColor = true;
            this.but_ZoomAuto.Click += new System.EventHandler(this.but_ZoomAuto_Click);
            // 
            // but_CutForCustom
            // 
            this.but_CutForCustom.Location = new System.Drawing.Point(130, 36);
            this.but_CutForCustom.Name = "but_CutForCustom";
            this.but_CutForCustom.Size = new System.Drawing.Size(96, 30);
            this.but_CutForCustom.TabIndex = 4;
            this.but_CutForCustom.Text = "自定义剪裁";
            this.but_CutForCustom.UseVisualStyleBackColor = true;
            this.but_CutForCustom.Click += new System.EventHandler(this.but_CutForCustom_Click);
            // 
            // but_CutForSquare
            // 
            this.but_CutForSquare.Location = new System.Drawing.Point(17, 36);
            this.but_CutForSquare.Name = "but_CutForSquare";
            this.but_CutForSquare.Size = new System.Drawing.Size(96, 30);
            this.but_CutForSquare.TabIndex = 3;
            this.but_CutForSquare.Text = "正方形剪裁";
            this.but_CutForSquare.UseVisualStyleBackColor = true;
            this.but_CutForSquare.Click += new System.EventHandler(this.but_CutForSquare_Click);
            // 
            // Form_Image
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 334);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pic_new);
            this.Controls.Add(this.pic_old);
            this.Name = "Form_Image";
            this.Text = "Form_Image";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Image_FormClosing);
            this.Load += new System.EventHandler(this.Form_Image_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_old)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_new)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_old;
        private System.Windows.Forms.PictureBox pic_new;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button but_CutForSquare;
        private System.Windows.Forms.Button but_CutForCustom;
        private System.Windows.Forms.Button but_ZoomAuto;
        private System.Windows.Forms.Button but_Resize;
        private System.Windows.Forms.Button but_CutImage;
    }
}