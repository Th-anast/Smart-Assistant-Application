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
    public partial class Form3 : Form
    {
        Thread th;
        bool show;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
        }
        private void openNewForm(object obj)
        {
            Application.Run(new Form1());
        }

        private void openNewForm1(object obj)
        {
            Application.Run(new Form4());
        }

        private void openNewForm2(object obj)
        {
            Application.Run(new Form7());
        }

        private void openNewForm3(object obj)
        {
            Application.Run(new Form12());
        }

        private void openNewForm4(object obj)
        {
            Application.Run(new Form13());
        }

        private void εμφάνισηΥποδείξεωνToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            show = true;
        }

        private void εξαφάνισηΥποδείξεωνToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            show = false;
        }

        private void αποσύνδεσηToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openNewForm);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void βοήθειαToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "ApplicationHelp.chm", HelpNavigator.TopicId, "40");
        }

        //----ΠΛΑΝΟ ΗΜΕΡΑΣ----
        private void Click1(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openNewForm1);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void MouseHover1(object sender, EventArgs e)
        {
            panel1.BorderStyle = BorderStyle.FixedSingle;
            label7.Visible = true;
        }

        private void MouseLeave1(object sender, EventArgs e)
        {
            panel1.BorderStyle = BorderStyle.None;
            if (!show)
            {
                label7.Visible = false;
            }
        }

        //----ΗΛΕΚΤΡΙΚΕΣ ΣΥΣΚΕΥΕΣ----
        private void Click2(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openNewForm2);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void MouseHover2(object sender, EventArgs e)
        {
            panel2.BorderStyle = BorderStyle.FixedSingle;
            label8.Visible = true;
        }

        private void MouseLeave2(object sender, EventArgs e)
        {
            panel2.BorderStyle = BorderStyle.None;
            if (!show)
            {
                label8.Visible = false;
            }
        }

        //----ΠΑΠΟΥΤΣΟΘΗΚΗ----
        private void Click3(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openNewForm3);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void MouseHover3(object sender, EventArgs e)
        {
            panel3.BorderStyle = BorderStyle.FixedSingle;
            label9.Visible = true;
        }

        private void MouseLeave3(object sender, EventArgs e)
        {
            panel3.BorderStyle = BorderStyle.None;
            if (!show)
            {
                label9.Visible = false;
            }
        }

        //----ΤΑΙΣΤΡΑ----
        private void Click4(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openNewForm4);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void MouseHover4(object sender, EventArgs e)
        {
            panel4.BorderStyle = BorderStyle.FixedSingle;
            label10.Visible = true;
        }

        private void MouseLeave4(object sender, EventArgs e)
        {
            panel4.BorderStyle = BorderStyle.None;
            if (!show)
            {
                label10.Visible = false;
            }
        }        
    }
}
