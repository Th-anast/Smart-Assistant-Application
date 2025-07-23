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
    public partial class Form8 : Form
    {
        Thread th;
        bool show;

        public Form8()
        {
            InitializeComponent();
        }

        private void openNewForm(String room)
        {
            Application.Run(new Form9(room));
        }

        private void openNewForm1(object obj)
        {
            Application.Run(new Form7());
        }
        private void openNewForm2(object obj)
        {
            Application.Run(new Form3());
        }
        private void openNewForm3(object obj)
        {
            Application.Run(new Form1());
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
        }

        private void κεντρικήToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openNewForm2);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void εμφάνισηΥποδείξεωνToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            show = true;
        }

        private void εξαφάνισηΥποδείξεωνToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            show = false;
        }

        private void αποσύνδεσηToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openNewForm3);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void βοήθειαToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "ApplicationHelp.chm", HelpNavigator.TopicId, "47");
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openNewForm1);
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

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            pictureBox4.BorderStyle = BorderStyle.FixedSingle;
            label5.Visible = true;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.BorderStyle = BorderStyle.None;
            if (!show)
            {
                label5.Visible = false;
            }
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            pictureBox5.BorderStyle = BorderStyle.FixedSingle;
            label6.Visible = true;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.BorderStyle = BorderStyle.None;
            if (!show)
            {
                label6.Visible = false;
            }
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            pictureBox6.BorderStyle = BorderStyle.FixedSingle;
            label7.Visible = true;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.BorderStyle = BorderStyle.None;
            if (!show)
            {
                label7.Visible = false;
            }
        }

        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {
            pictureBox7.BorderStyle = BorderStyle.FixedSingle;
            label8.Visible = true;
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            pictureBox7.BorderStyle = BorderStyle.None;
            if (!show)
            {
                label8.Visible = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(() => openNewForm("Υπνοδωμάτιο"));
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(() => openNewForm("Σαλόνι"));
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(() => openNewForm("Tραπεζαρία"));
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(() => openNewForm("Κουζίνα"));
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(() => openNewForm("Μπάνιο"));
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(() => openNewForm("Γραφείο"));
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }        
    }
}
