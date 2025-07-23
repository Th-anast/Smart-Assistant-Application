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
    public partial class Form7 : Form
    {
        Thread th;
        bool show;

        public Form7()
        {
            InitializeComponent();
        }
        private void Form7_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
        }

        private void openNewForm(object obj)
        {
            Application.Run(new Form3());
        }

        private void openNewForm1(object obj)
        {
            Application.Run(new Form1());
        }

        private void openNewForm2(object obj)
        {
            Application.Run(new Form8());
        }

        private void openNewForm3(object obj)
        {
            Application.Run(new Form10());
        }

        private void κεντρικήToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openNewForm);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void εμφάνισηΥποδείξεωνToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            label4.Visible = true;
            show = true;
        }

        private void εξαφάνισηΥποδείξεωνToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            label4.Visible = false;
            show = false;
        }

        private void αποσύνδεσηToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openNewForm1);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void βοήθειαToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "ApplicationHelp.chm", HelpNavigator.TopicId, "47");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openNewForm2);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openNewForm);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            label3.Visible = true;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.None;
            if (!show)
            {
                label3.Visible = false;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openNewForm3);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            label4.Visible = true;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BorderStyle = BorderStyle.None;
            if (!show)
            {
                label4.Visible = false;
            }
        }               
    }
}
