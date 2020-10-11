using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cse_Department.Papers
{
    public partial class Add_Paper : Form
    {
        public Add_Paper()
        {
            InitializeComponent();
        }
        public string lbl;

        public byte[] Filename { get; private set; }

        private void Add_Paper_Load(object sender, EventArgs e)
        {
            lblpaper.Text = lbl;
            if (lblpaper.Text == "Add Information Here!")
            {
                btnadd.Text = "Add";
            }
            else if (lblpaper.Text == "Update Information Here!")
            {
                btnadd.Text = "Update";
            }
        }
        byte[] ImageToByteArray(Image img, PictureBox px)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            if (px != null)
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            return ms.ToArray();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            DialogResult result = fileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                pictureBox1.BackgroundImage = Image.FromFile(fileDialog.FileName);
                pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
                Filename = ImageToByteArray(pictureBox1.BackgroundImage, pictureBox1);
            }
        }

        private void lblpaper_Click(object sender, EventArgs e)
        {

        }
    }
}
