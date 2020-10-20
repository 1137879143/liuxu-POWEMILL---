using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JinYiHelp.ImageHel;

namespace JYKJDome
{
    public partial class Form_Image : Form
    {
        public Form_Image()
        {
            InitializeComponent();
        }

        private MemoryStream _memory;

        private void but_CutForSquare_Click(object sender, EventArgs e)
        {
            string fileSaveUrl = Application.StartupPath + @"\img\new_square.png";

            int side = 80;
            int  quality = 100;

            var old_img = pic_old.Image;
           
            ImageHelper.CutForSquare(_memory, fileSaveUrl, side, quality);

            pic_new.Image = Image.FromFile(fileSaveUrl);


        }

        private void Form_Image_Load(object sender, EventArgs e)
        {
            string name= Application.StartupPath + @"\img\old.png";

            if (!File.Exists(name))
            {
                MessageBox.Show(name + "测试文件 不存在");
                return;
            }

            byte[] bin = File.ReadAllBytes(name);

            if (bin != null)
            {
                _memory= new MemoryStream(bin);
               
                pic_old.Image = Image.FromStream(_memory);

            }


        }

        private void Form_Image_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_memory != null)
            {
                _memory.Close();
            }
        }

        private void but_CutForCustom_Click(object sender, EventArgs e)
        {
            string fileSaveUrl = Application.StartupPath + @"\img\new_custom.png";
            

            ImageHelper.CutForCustom(_memory,fileSaveUrl,80,60,100);
            pic_new.Image = Image.FromFile(fileSaveUrl);
        }

        private void but_ZoomAuto_Click(object sender, EventArgs e)
        {
            string fileSaveUrl = Application.StartupPath + @"\img\new_zoomAuto.png";
           
            ImageHelper.ZoomAuto(_memory, fileSaveUrl,80,0.8,"精易论坛");
            pic_new.Image = Image.FromFile(fileSaveUrl);
        }

        private void but_CutImage_Click(object sender, EventArgs e)
        {
            string fileSaveUrl = Application.StartupPath + @"\img\new_cut.png";
           
            ImageHelper.CutForCustom(_memory, fileSaveUrl, 70,60,100);
            pic_new.Image = Image.FromFile(fileSaveUrl);
        }

        private void but_Resize_Click(object sender, EventArgs e)
        {

            var old = new Bitmap(pic_old.Image);

            var new_img=ImageHelper.ResizeImage(old,110,110);

            pic_new.Image = Image.FromHbitmap(new_img.GetHbitmap());

            old.Dispose();
            new_img.Dispose();

        }
    }
}
