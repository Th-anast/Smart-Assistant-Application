using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_Assistant
{
    public partial class Form2 : Form
    {
        bool click = false;
        bool show;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" & textBox2.Text == "")
            {
                MessageBox.Show("Παρακαλώ πληκτρολογήστε username και password!", "Warning", 0, MessageBoxIcon.Warning);
            }
            else if (textBox1.Text == "")
            {
                MessageBox.Show("Παρακαλώ πληκτρολογήστε username!", "Warning", 0, MessageBoxIcon.Warning);
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Παρακαλώ πληκτρολογήστε password!", "Warning", 0, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Η εγγραφή σου ολοκληρώθηκε με επιτυχία!","Success", 0, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            click = true;
            textBox2.UseSystemPasswordChar = false;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            if (click)
            {
                textBox2.UseSystemPasswordChar = true;
            }
            click = false;
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
            Help.ShowHelp(this, "ApplicationHelp.chm", HelpNavigator.TopicId, "30");
        }
    }
}
