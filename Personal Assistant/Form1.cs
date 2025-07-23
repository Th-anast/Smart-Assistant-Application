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
    public partial class Form1 : Form
    {
        bool click = false;
        bool show;
        Thread th;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "matoula" & textBox2.Text == "p19088")
            {
                this.Close();
                th = new Thread(openNewForm);
                th.TrySetApartmentState(ApartmentState.STA);
                th.Start();
            }
            else if (textBox1.Text == "thanasis" & textBox2.Text == "p19009")
            {
                this.Close();
                th = new Thread(openNewForm);
                th.TrySetApartmentState(ApartmentState.STA);
                th.Start();
            }
            else if (textBox1.Text == "" & textBox2.Text == "")
            {
                MessageBox.Show("Παρακαλώ πληκτρολογήστε username και password!", "Warning", 0, MessageBoxIcon.Warning);
            }
            else if (textBox1.Text == "")
            {
                MessageBox.Show("Παρακαλώ πληκτρολογήστε username!", "Warning" , 0 ,MessageBoxIcon.Warning);
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Παρακαλώ πληκτρολογήστε password!", "Warning", 0, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Λανθασμένο username ή password!" + Environment.NewLine + "Παρακαλώ προσπαθήστε ξανά.", "Error" , 0 ,MessageBoxIcon.Error);
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }

        private void openNewForm(object obj)
        {
            Application.Run(new Form3());
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            click = true;
            textBox2.UseSystemPasswordChar = false;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            if (click == true)
            {
                textBox2.UseSystemPasswordChar = true;
            }
            click = false;
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            label5.Visible = true;
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            if (!show)
            {
                label5.Visible = false;
            }
        }

        private void textBox2_MouseHover(object sender, EventArgs e)
        {
            label7.Visible = true;
        }

        private void textBox2_MouseLeave(object sender, EventArgs e)
        {
            if (!show)
            {
                label7.Visible = false;
            }
        }

        private void εμφάνισηΥποδείξεωνToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label5.Visible = true;
            label7.Visible = true;
            show = true;
        }

        private void εξαφάνισηΥποδείξεωνToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label5.Visible = false;
            label7.Visible = false;
            show = false;
        }

        private void βοήθειαToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "ApplicationHelp.chm", HelpNavigator.TopicId, "20");
        }
    }
}
