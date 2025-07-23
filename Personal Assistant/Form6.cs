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
    public partial class Form6 : Form
    {
        Thread th;

        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label10.Text = Form5.SetValueForText1;
            label11.Text = Form5.SetValueForText2;
            label12.Text = Form5.SetValueForText3;
            label13.Text = Form5.SetValueForText4;
            label14.Text = Form5.SetValueForText5;
            label15.Text = Form5.SetValueForText6;
            label16.Text = Form5.SetValueForText7;
            label17.Text = Form5.SetValueForText8;
        }

        private void openNewForm(object obj)
        {
            Application.Run(new Form3());
        }

        private void openNewForm1(object obj)
        {
            Application.Run(new Form4());
        }

        private void openNewForm2(object obj)
        {
            Application.Run(new Form1());
        }

        private void κεντρικήToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openNewForm);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
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
            Help.ShowHelp(this, "ApplicationHelp.chm", HelpNavigator.TopicId, "45");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openNewForm1);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}
