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
    public partial class Form13 : Form
    {

        Thread th;
        Random rnd = new Random();
        int count = 0;
        bool f1, f2, f3, f4 = false;
        bool show;

        public Form13()
        {
            InitializeComponent();
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            int r1 = rnd.Next(0, 101);
            progressBar1.Value = r1;
            int r2 = rnd.Next(0, 101);
            progressBar2.Value = r2;
            label9.Text = "Η ταϊστρα βρίσκεται στο " + r1 + "%";
            label10.Text = "Η ποτίστρα βρίσκεται στο " + r2 + "%";
            if (r1 < 20)
            {
                MessageBox.Show("Πρέπει να γεμίσεις την ταΐστρα του κατοικιδίου!", "Info", 0, MessageBoxIcon.Information);
            }
            if (r2 < 20)
            {
                MessageBox.Show("Πρέπει να γεμίσεις την ποτίστρα του κατοικιδίου!", "Info", 0, MessageBoxIcon.Information);
            }
            if (r1 == 100)
            {
                label9.Text = "Η ταΐστρα είναι γεμάτη";
            }
            if (r2 == 100)
            {
                label10.Text = "Η ποτίστρα είναι γεμάτη";
            }
        }

        private void openNewForm()
        {
            Application.Run(new Form3());
        }

        private void openNewForm1()
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

        private void εμφάνισηΥποδείξεωνToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            show = true;
        }

        private void εξαφάνισηΥποδείξεωνToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
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
            Help.ShowHelp(this, "ApplicationHelp.chm", HelpNavigator.TopicId, "50");
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
            progressBar1.Value = 100;
            label9.Text = "Η ταΐστρα είναι γεμάτη";
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

        private void button2_Click(object sender, EventArgs e)
        {
            progressBar2.Value = 100;
            label10.Text = "Η ποτίστρα είναι γεμάτη";
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

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            groupBox1.Enabled = true;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            label4.Visible = true;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            if (!show)
            {
                label4.Visible = false;
            }
        }

        private void progressBar1_MouseHover(object sender, EventArgs e)
        {
            label7.Visible = true;
        }

        private void progressBar1_MouseLeave(object sender, EventArgs e)
        {
            if (!show)
            {
                label7.Visible = false;
            }
        }

        private void progressBar2_MouseHover(object sender, EventArgs e)
        {
            label8.Visible = true;
        }

        private void progressBar2_MouseLeave(object sender, EventArgs e)
        {
            if (!show)
            {
                label8.Visible = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.MaskCompleted)
            {                
                string[] timedetails = maskedTextBox1.Text.Split(':');
                int hours = Int32.Parse(timedetails[0].Trim());
                int minutes = Int32.Parse(timedetails[1].Trim());
                if (hours < 24 && minutes < 60)
                {
                    count++;
                    if (count == 1)
                    {
                        label12.Text = maskedTextBox1.Text;
                        f1 = true;
                    }
                    else if (count == 2)
                    {
                        if (f1)
                        {
                            label13.Text = maskedTextBox1.Text;
                            f2 = true;
                        }
                        else
                        {
                            label12.Text = maskedTextBox1.Text;
                            f1 = true;
                        }
                    }
                    else if (count == 3)
                    {
                        if (f1 & f2)
                        {
                            label14.Text = maskedTextBox1.Text;
                            f3 = true;
                        }
                        else if (!f1)
                        {
                            label12.Text = maskedTextBox1.Text;
                            f1 = true;
                        }
                        else
                        {
                            label13.Text = maskedTextBox1.Text;
                            f2 = true;
                        }
                    }
                    else if (count == 4)
                    {
                        if (f1 & f2 & f3)
                        {
                            label15.Text = maskedTextBox1.Text;
                            f4 = true;
                        }
                        else if (!f1)
                        {
                            label12.Text = maskedTextBox1.Text;
                            f1 = true;
                        }
                        else if (!f2)
                        {
                            label13.Text = maskedTextBox1.Text;
                            f2 = true;
                        }
                        else
                        {
                            label14.Text = maskedTextBox1.Text;
                            f3 = true;
                        }
                    }
                    else
                    {
                        if (f1 & f2 & f3 & f4)
                        {
                            MessageBox.Show("Συμπληρώσατε τον μέγιστο αρισθμό προσθηκών!!!", "Info", 0, MessageBoxIcon.Information);
                        }
                        else if (!f1)
                        {
                            label12.Text = maskedTextBox1.Text;
                            f1 = true;
                        }
                        else if (!f2)
                        {
                            label13.Text = maskedTextBox1.Text;
                            f2 = true;
                        }
                        else if (!f3)
                        {
                            label14.Text = maskedTextBox1.Text;
                            f3 = true;
                        }
                        else
                        {
                            label15.Text = maskedTextBox1.Text;
                            f4 = true;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Invalid input!!!", "Warning", 0, MessageBoxIcon.Warning);
                }
                maskedTextBox1.Text = "_";
            }
            else
            {
                MessageBox.Show("Παρακαλώ,συμπληρώστε το πεδίο!!!", "Warning", 0, MessageBoxIcon.Warning);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label12.Text = "- - : - -";
            count--;
            f1 = false;
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            label17.Visible = true;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            label17.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label13.Text = "- - : - -";
            count--;
            f2 = false;
        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
            label18.Visible = true;
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            label18.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label14.Text = "- - : - -";
            count--;
            f3 = false;
        }

        private void button7_MouseHover(object sender, EventArgs e)
        {
            label19.Visible = true;
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            label19.Visible = false;
        }       

        private void button8_Click(object sender, EventArgs e)
        {
            label15.Text = "- - : - -";
            count--;
            f4 = false;
        }
        private void button8_MouseHover(object sender, EventArgs e)
        {
            label20.Visible = true;
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            label20.Visible = false;
        }
    }
}