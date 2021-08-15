using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Afinamento
{
    public partial class Form1 : Form
    {
        Image image;
        Bitmap imageBitmap;
        public Form1()
        {
            InitializeComponent();
        }

        private void p2_Click(object sender, EventArgs e)
        {

        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                image = Image.FromFile(openFileDialog1.FileName);
                p1.Image = image;
                p1.SizeMode = PictureBoxSizeMode.Normal;
            }
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            Bitmap bdest1 = new Bitmap(image);
            Bitmap bdest2 = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Efeito.convert_to_grayDMA(imageBitmap, bdest1);
            bdest2 = Efeito.BlackWhite(bdest1);
            Efeito.ZhangSuen(bdest1, bdest2);
            p2.Image = bdest2;
        }
    }
}
