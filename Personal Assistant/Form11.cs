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
    public partial class Form11 : Form
    {
        Thread th;
        bool on = true;
        bool sleep,show;
        String room;

        public Form11(String str = null)
        {
            InitializeComponent();
            room = str;
            pictureBox1.ImageLocation = "images/" + room + "-dark.png";
            this.Text = "Κλιματιστικό: " + room;
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            textBox1.Text = numericUpDown1.Value.ToString() + "°C";
        }

        private void openNewForm(object obj)
        {
            Application.Run(new Form10());
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
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            show = true;
        }

        private void εξαφάνισηΥποδείξεωνToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
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
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                textBox1.Visible = true;
                on = false;
            }
            else
            {
                groupBox1.Enabled = false;
                pictureBox1.ImageLocation = "images/" + room + "-dark.png";
                pictureBox3.ImageLocation = "images/buttonOFf.png";
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                textBox1.Visible = false;
                on = true;
            }
        }

        private void mode_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                pictureBox4.ImageLocation = "images/cool.png";
                if (sleep)
                {
                    numericUpDown1.Minimum = 21;
                    numericUpDown1.Maximum = 24;
                }
            }
            else if (radioButton2.Checked)
            {
                pictureBox4.ImageLocation = "images/heat.png";
                if (sleep)
                {
                    numericUpDown1.Minimum = 25;
                    numericUpDown1.Maximum = 28;
                }                
            }
            else if (radioButton3.Checked)
            {
                pictureBox4.ImageLocation = "images/dry.png";
            }
            else
            {
                pictureBox4.ImageLocation = "images/auto.png";
            }
            pictureBox4.Visible = true;
        }

        private void fanSpeed_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                pictureBox5.ImageLocation = "images/fan_speed-low.png";
            }
            else if (radioButton6.Checked)
            {
                pictureBox5.ImageLocation = "images/fan_speed-medium.png";
            }
            else if (radioButton7.Checked)
            {
                pictureBox5.ImageLocation = "images/fan_speed-high.png";
            }
            else
            {
                pictureBox5.ImageLocation = "images/fan_speed-medium.png";
            }
            pictureBox4.Visible = true;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox1.Text = numericUpDown1.Value.ToString() + "°C";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            radioButton3.Checked = false;
            radioButton3.Enabled = false;
            radioButton4.Checked = false;
            radioButton4.Enabled = false;
            radioButton5.Checked = true;
            groupBox3.Enabled = false;            
            numericUpDown2.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = true;
            button4.Enabled = true;
            sleep = true;
            numericUpDown1.Minimum = 21;
            numericUpDown1.Maximum = 24;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            numericUpDown2.Enabled = true;
            button1.Enabled = false;
            button3.Enabled = true;
            button4.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (sleep)
            {
                if (radioButton1.Checked || radioButton2.Checked)
                {
                    MessageBox.Show("Επιλέξατε το Sleep Mode. Το κλιματιστικό θα κλείσει σε " + numericUpDown2.Value.ToString() + " ώρες!!!", "Sleep Mode", 0, MessageBoxIcon.Information);
                    radioButton3.Enabled = true;
                    radioButton4.Enabled = true;
                    pictureBox6.Visible = true;
                    groupBox3.Enabled = true;
                    numericUpDown1.Minimum = 16;
                    numericUpDown1.Maximum = 30;
                    numericUpDown2.Enabled = false;
                    button2.Enabled = true;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    sleep = false;
                }
                else
                {
                    MessageBox.Show("Παρακαλώ επιλέξτε Cool ή Heat mode!!!", "Warning", 0, MessageBoxIcon.Warning);
                }
                
            }
            else
            {
                MessageBox.Show("Επιλέξατε το Timer Mode. Το κλιματιστικό θα κλείσει σε " + numericUpDown2.Value.ToString() + " ώρες!!!", "Timer Mode", 0, MessageBoxIcon.Information);
                pictureBox7.Visible = true;
                numericUpDown2.Enabled = false;
                button1.Enabled = true;
                button3.Enabled = false;
                button4.Enabled = false;
            }            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (sleep)
            {
                MessageBox.Show("Οι ρυθμίσεις του Sleep Mode ακυρώθηκαν!!!", "Cancel", 0, MessageBoxIcon.Stop);
                radioButton3.Enabled = true;
                radioButton4.Checked = true;
                radioButton4.Enabled = true;
                radioButton8.Checked = true;
                pictureBox6.Visible = false;
                numericUpDown1.Minimum = 16;
                numericUpDown1.Maximum = 30;
                groupBox3.Enabled = true;
                numericUpDown2.Enabled = false;
                button2.Enabled = true;
                button3.Enabled = false;
                button4.Enabled = false;                
            }
            else
            {
                MessageBox.Show("Οι ρυθμίσεις του Timer Mode ακυρώθηκαν!!!", "Cancel", 0, MessageBoxIcon.Stop);
                pictureBox7.Visible = false;
                numericUpDown2.Enabled = false;
                button1.Enabled = true;
                button3.Enabled = false;
                button4.Enabled = false;
            }            
            sleep = false;
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            label4.Visible = true;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            if (!show)
            {
                label4.Visible = false;
            }
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            label5.Visible = true;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            if (!show)
            {
                label5.Visible = false;
            }
        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            label6.Visible = true;
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            if (!show)
            {
                label6.Visible = false;
            }
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            label7.Visible = true;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            if (!show)
            {
                label7.Visible = false;
            }
        }

        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {
            label8.Visible = true;
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            if (!show)
            {
                label8.Visible = false;
            }
        }
    }
}
