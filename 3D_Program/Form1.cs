using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3D_Program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Image myimagel = new Bitmap(@"" + (string)Application.StartupPath + @"\3d\3d_Left.jpg");
        Image myimager = new Bitmap(@"" + (string)Application.StartupPath + @"\3d\3d_Right.jpg");

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.BackgroundImage == myimagel)
            {
                this.BackgroundImage = myimager;
            }
            else if (this.BackgroundImage == myimager)
            {
                this.BackgroundImage = myimagel;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = myimager;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                if (timer1.Enabled == true)
                {
                    timer1.Enabled = false;
                }
                else if (timer1.Enabled == false)
                {
                    timer1.Enabled = true;
                }
            }
        }
    }
}
