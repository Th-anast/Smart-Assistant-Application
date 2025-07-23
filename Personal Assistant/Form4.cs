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
    public partial class Form4 : Form
    {
        Thread th;
        bool show;

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
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
            Application.Run(new Form5());
        }

        private void openNewForm3(object obj)
        {
            Application.Run(new Form6());
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
            label2.Visible = true;
            label3.Visible = true;
            show = true;
        }

        private void εξαφάνισηΥποδείξεωνToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            label3.Visible = false;
            show = false;
        }

        private void αποσύνδεσηToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openNewForm1);
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openNewForm2);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openNewForm3);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }        

        private void button1_MouseHover(object sender, EventArgs e)
        {
            label2.Visible = true;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            if (!show)
            {
                label2.Visible = false;
            }
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            label3.Visible = true;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            if (!show)
            {
                label3.Visible = false;
            }
        }        
    }
}
