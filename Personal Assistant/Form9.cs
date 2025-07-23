using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_Assistant
{
    public partial class Form9 : Form
    {
        Thread th;
        String room;
        bool on = true;
        bool show;
        Color rgb;

        public Form9(String str= null)
        {
            InitializeComponent();
            room = str;
            pictureBox1.ImageLocation = "images/" + room + "-dark.png";
            this.Text = "Φώς: " + room;
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = "Ένταση Θερμοκράσιας: " + trackBar1.Value.ToString();
        }

        private void openNewForm(object obj)
        {
            Application.Run(new Form8());
        }
        private void openNewForm1(object obj)
        {
            Application.Run(new Form3());
        }
        private void openNewForm2(object obj)
        {
            Application.Run(new Form1());
        }

        private void κεντρικήToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openNewForm1);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void εμφάνισηΥποδείξεωνToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            label5.Visible = true;
            show = true;
        }

        private void εξαφάνισηΥποδείξεωνToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            label5.Visible = false;
            show = false;
        }

        private void αποσύνδεσηToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openNewForm2);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void βοήθειαToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "ApplicationHelp.chm", HelpNavigator.TopicId, "47");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openNewForm);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (on)
            {
                groupBox1.Enabled = true;
                pictureBox1.ImageLocation = "images/" + room + "-light.png";
                pictureBox3.ImageLocation = "images/buttonON.png";
                on = false;
            }
            else
            {
                groupBox1.Enabled = false;
                pictureBox1.ImageLocation = "images/" + room + "-dark.png";
                pictureBox3.ImageLocation = "images/buttonOFf.png";
                on = true;
            }           
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                groupBox1.BackColor = colorDialog1.Color;
                rgb = groupBox1.BackColor;
            }
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            pictureBox4.BorderStyle = BorderStyle.FixedSingle;
            label3.Visible = true;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.BorderStyle = BorderStyle.None;
            if (!show)
            {
                label3.Visible = false;
            }            
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int[] red = { 255, 255, 255, 255, 255, 255, 255, 201, 64 };
            int[] green = { 147, 197, 214, 241, 250, 255, 255, 226, 156 };
            int[] blue = { 41, 143, 170, 224, 244, 251, 255, 255, 255 };
            int i = trackBar1.Value-1;
            groupBox1.BackColor = Color.FromArgb(red[i],green[i],blue[i]);
            label2.Text = "Ένταση Θερμοκράσιας: " + trackBar1.Value.ToString();
            rgb = groupBox1.BackColor;
        }

        public static Color brightness(Color color, int factor)
        {
            int R = (color.R + factor > 255) ? 255 : color.R + factor;
            int G = (color.G + factor > 255) ? 255 : color.G + factor;
            int B = (color.B + factor > 255) ? 255 : color.B + factor;

            return Color.FromArgb(R, G, B);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            groupBox1.BackColor=brightness(rgb, Decimal.ToInt16(numericUpDown1.Value));
        }
    }
}
