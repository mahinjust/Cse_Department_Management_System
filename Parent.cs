using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cse_Department.Parent
{
    public partial class Parent : Form
    {
        public Parent()
        {
            InitializeComponent();
        }
        public string lbl;
        private void Parent_Load(object sender, EventArgs e)
        {
            lblheading.Text = lbl;
            if(lblheading.Text == "Add Information Here!")
            {
                btnadd.Text = "Add";
            }
            else if(lblheading.Text == "Update Information Here!")
            {
                btnadd.Text = "Update";
            }
        }
        byte[] Filename;

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
    }
}
