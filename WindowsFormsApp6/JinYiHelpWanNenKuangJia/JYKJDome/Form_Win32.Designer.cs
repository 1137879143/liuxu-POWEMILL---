namespace JYKJDome
{
    partial class Form_Win32
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
            this.che_min = new System.Windows.Forms.CheckBox();
            this.che_max = new System.Windows.Forms.CheckBox();
            this.che_hyuan = new System.Windows.Forms.CheckBox();
            this.che_close = new System.Windows.Forms.CheckBox();
            this.che_settop = new System.Windows.Forms.CheckBox();
            this.che_activate = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.but_bind = new System.Windows.Forms.Button();
            this.lab_hand = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lab_xy = new System.Windows.Forms.Label();
            this.txt_child = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_biaoshi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.text_father = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_class = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_size = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_posion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_hand = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.but_send = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.but_send);
            this.groupBox1.Controls.Add(this.che_min);
            this.groupBox1.Controls.Add(this.che_max);
            this.groupBox1.Controls.Add(this.che_hyuan);
            this.groupBox1.Controls.Add(this.che_close);
            this.groupBox1.Controls.Add(this.che_settop);
            this.groupBox1.Controls.Add(this.che_activate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.but_bind);
            this.groupBox1.Controls.Add(this.lab_hand);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lab_xy);
            this.groupBox1.Controls.Add(this.txt_child);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txt_title);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txt_biaoshi);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.text_father);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_class);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_size);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_posion);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_hand);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(604, 191);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Win32";
            // 
            // che_min
            // 
            this.che_min.AutoSize = true;
            this.che_min.Location = new System.Drawing.Point(393, 149);
            this.che_min.Name = "che_min";
            this.che_min.Size = new System.Drawing.Size(60, 16);
            this.che_min.TabIndex = 42;
            this.che_min.Text = "最小化";
            this.che_min.UseVisualStyleBackColor = true;
            this.che_min.CheckedChanged += new System.EventHandler(this.che_min_CheckedChanged);
            // 
            // che_max
            // 
            this.che_max.AutoSize = true;
            this.che_max.Location = new System.Drawing.Point(332, 149);
            this.che_max.Name = "che_max";
            this.che_max.Size = new System.Drawing.Size(60, 16);
            this.che_max.TabIndex = 41;
            this.che_max.Text = "最大化";
            this.che_max.UseVisualStyleBackColor = true;
            this.che_max.CheckedChanged += new System.EventHandler(this.che_max_CheckedChanged);
            // 
            // che_hyuan
            // 
            this.che_hyuan.AutoSize = true;
            this.che_hyuan.Location = new System.Drawing.Point(271, 149);
            this.che_hyuan.Name = "che_hyuan";
            this.che_hyuan.Size = new System.Drawing.Size(48, 16);
            this.che_hyuan.TabIndex = 40;
            this.che_hyuan.Text = "还原";
            this.che_hyuan.UseVisualStyleBackColor = true;
            this.che_hyuan.CheckedChanged += new System.EventHandler(this.che_hyuan_CheckedChanged);
            // 
            // che_close
            // 
            this.che_close.AutoSize = true;
            this.che_close.Location = new System.Drawing.Point(210, 149);
            this.che_close.Name = "che_close";
            this.che_close.Size = new System.Drawing.Size(48, 16);
            this.che_close.TabIndex = 39;
            this.che_close.Text = "关闭";
            this.che_close.UseVisualStyleBackColor = true;
            this.che_close.CheckedChanged += new System.EventHandler(this.che_close_CheckedChanged);
            // 
            // che_settop
            // 
            this.che_settop.AutoSize = true;
            this.che_settop.Location = new System.Drawing.Point(149, 149);
            this.che_settop.Name = "che_settop";
            this.che_settop.Size = new System.Drawing.Size(48, 16);
            this.che_settop.TabIndex = 38;
            this.che_settop.Text = "置顶";
            this.che_settop.UseVisualStyleBackColor = true;
            this.che_settop.CheckedChanged += new System.EventHandler(this.che_settop_CheckedChanged);
            // 
            // che_activate
            // 
            this.che_activate.AutoSize = true;
            this.che_activate.Location = new System.Drawing.Point(88, 149);
            this.che_activate.Name = "che_activate";
            this.che_activate.Size = new System.Drawing.Size(48, 16);
            this.che_activate.TabIndex = 37;
            this.che_activate.Text = "激活";
            this.che_activate.UseVisualStyleBackColor = true;
            this.che_activate.CheckedChanged += new System.EventHandler(this.che_activate_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 36;
            this.label4.Text = "窗口属性：";
            // 
            // but_bind
            // 
            this.but_bind.Location = new System.Drawing.Point(420, 108);
            this.but_bind.Name = "but_bind";
            this.but_bind.Size = new System.Drawing.Size(75, 23);
            this.but_bind.TabIndex = 35;
            this.but_bind.Text = "绑定句柄";
            this.but_bind.UseVisualStyleBackColor = true;
            this.but_bind.Click += new System.EventHandler(this.but_bind_Click);
            // 
            // lab_hand
            // 
            this.lab_hand.AutoSize = true;
            this.lab_hand.Location = new System.Drawing.Point(53, 23);
            this.lab_hand.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_hand.Name = "lab_hand";
            this.lab_hand.Size = new System.Drawing.Size(29, 12);
            this.lab_hand.TabIndex = 34;
            this.lab_hand.Text = "0000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 23);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 33;
            this.label5.Text = "句柄：";
            // 
            // lab_xy
            // 
            this.lab_xy.AutoSize = true;
            this.lab_xy.Dock = System.Windows.Forms.DockStyle.Right;
            this.lab_xy.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lab_xy.Location = new System.Drawing.Point(578, 17);
            this.lab_xy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_xy.Name = "lab_xy";
            this.lab_xy.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lab_xy.Size = new System.Drawing.Size(23, 12);
            this.lab_xy.TabIndex = 32;
            this.lab_xy.Text = "x,y";
            this.lab_xy.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txt_child
            // 
            this.txt_child.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_child.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txt_child.Location = new System.Drawing.Point(466, 76);
            this.txt_child.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_child.Name = "txt_child";
            this.txt_child.Size = new System.Drawing.Size(113, 19);
            this.txt_child.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(406, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 29;
            this.label11.Text = "子窗句柄：";
            // 
            // txt_title
            // 
            this.txt_title.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_title.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txt_title.Location = new System.Drawing.Point(466, 45);
            this.txt_title.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(113, 19);
            this.txt_title.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(406, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 27;
            this.label12.Text = "窗口标题：";
            // 
            // txt_biaoshi
            // 
            this.txt_biaoshi.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_biaoshi.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txt_biaoshi.Location = new System.Drawing.Point(276, 109);
            this.txt_biaoshi.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_biaoshi.Name = "txt_biaoshi";
            this.txt_biaoshi.Size = new System.Drawing.Size(113, 19);
            this.txt_biaoshi.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(216, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 23;
            this.label6.Text = "进程标识：";
            // 
            // text_father
            // 
            this.text_father.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.text_father.ForeColor = System.Drawing.SystemColors.Highlight;
            this.text_father.Location = new System.Drawing.Point(276, 78);
            this.text_father.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.text_father.Name = "text_father";
            this.text_father.Size = new System.Drawing.Size(113, 19);
            this.text_father.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(216, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 21;
            this.label7.Text = "父窗句柄：";
            // 
            // txt_class
            // 
            this.txt_class.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_class.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txt_class.Location = new System.Drawing.Point(276, 47);
            this.txt_class.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_class.Name = "txt_class";
            this.txt_class.Size = new System.Drawing.Size(113, 19);
            this.txt_class.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(216, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 19;
            this.label8.Text = "窗口类名：";
            // 
            // txt_size
            // 
            this.txt_size.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_size.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txt_size.Location = new System.Drawing.Point(77, 109);
            this.txt_size.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_size.Name = "txt_size";
            this.txt_size.Size = new System.Drawing.Size(113, 19);
            this.txt_size.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 15;
            this.label3.Text = "窗口大小：";
            // 
            // txt_posion
            // 
            this.txt_posion.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_posion.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txt_posion.Location = new System.Drawing.Point(77, 78);
            this.txt_posion.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_posion.Name = "txt_posion";
            this.txt_posion.Size = new System.Drawing.Size(113, 19);
            this.txt_posion.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "窗口位置：";
            // 
            // txt_hand
            // 
            this.txt_hand.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_hand.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txt_hand.Location = new System.Drawing.Point(77, 47);
            this.txt_hand.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_hand.Name = "txt_hand";
            this.txt_hand.Size = new System.Drawing.Size(113, 19);
            this.txt_hand.TabIndex = 12;
            this.txt_hand.Text = "alt+2快速键入";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "窗口句柄：";
            // 
            // but_send
            // 
            this.but_send.Location = new System.Drawing.Point(480, 149);
            this.but_send.Name = "but_send";
            this.but_send.Size = new System.Drawing.Size(75, 23);
            this.but_send.TabIndex = 43;
            this.but_send.Text = "打字";
            this.but_send.UseVisualStyleBackColor = true;
            this.but_send.Click += new System.EventHandler(this.but_send_Click);
            // 
            // Form_Win32
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 429);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_Win32";
            this.Text = "Form_Win32";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Win32_FormClosing);
            this.Load += new System.EventHandler(this.Form_Win32_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_size;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_posion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_hand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_child;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_biaoshi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox text_father;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_class;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lab_xy;
        private System.Windows.Forms.Button but_bind;
        private System.Windows.Forms.Label lab_hand;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox che_min;
        private System.Windows.Forms.CheckBox che_max;
        private System.Windows.Forms.CheckBox che_hyuan;
        private System.Windows.Forms.CheckBox che_close;
        private System.Windows.Forms.CheckBox che_settop;
        private System.Windows.Forms.CheckBox che_activate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button but_send;
    }
}