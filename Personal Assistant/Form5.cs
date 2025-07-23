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
    public partial class Form5 : Form
    {
        Thread th;
        bool i1, i2, i3, i4, i5 = false;
        bool show;
        Random r;
        public static string SetValueForText1 = "";
        public static string SetValueForText2 = "";
        public static string SetValueForText3 = "";
        public static string SetValueForText4 = "";
        public static string SetValueForText5 = "";
        public static string SetValueForText6 = "";
        public static string SetValueForText7 = "";
        public static string SetValueForText8 = "";
        public static string SetValueForText9 = "";
        public static string SetValueForText10 = "";

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            r = new Random();
            String[] list1 = { "Weather1a", "Weather2a", "Weather3a" };
            String[] list2 = { "Weather1b", "Weather2b", "Weather3b" };
            pictureBox1.ImageLocation = "images/" + list1[r.Next(3)] + ".png";
            pictureBox3.ImageLocation = "images/" + list2[r.Next(3)] + ".png";
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
               
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openNewForm1);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (i3)
            {
                MessageBox.Show("Η προσθήκη ολοκληρώθηκε με επιτυχία!" + Environment.NewLine + "Θα παραλάβεις την παραγγελία σου από την καφετέρια Pure που βρίσκεται απένατι από το σημείο που βρίσκεσαι αυτή τη στιγμή.", "Success", 0, MessageBoxIcon.Information);
            }
            else if (i4)
            {
                MessageBox.Show("Η προσθήκη ολοκληρώθηκε με επιτυχία!" + Environment.NewLine + "Μπορείς να αγοράσεις καφέ/ρόφημα από την καφετέρια Pure που βρίσκεται απένατι από το σημείο που βρίσκεσαι αυτή τη στιγμή.", "Success", 0, MessageBoxIcon.Information);
            }
            else if (i5)
            {
                MessageBox.Show("Η προσθήκη ολοκληρώθηκε με επιτυχία!", "Success", 0,MessageBoxIcon.Information);
            }
            SetValueForText1 = comboBox1.Text;
            SetValueForText2 = numericUpDown1.Value.ToString()+':' +numericUpDown2.Value.ToString();
            if (radioButton1.Checked)
            {
                SetValueForText2 += "π.μ.";
            }
            if (radioButton2.Checked)
            {
                SetValueForText2 += "μ.μ.";
            }
            SetValueForText3 = textBox1.Text;
            SetValueForText4 = textBox2.Text;
            SetValueForText5 = comboBox2.Text;
            SetValueForText6 = comboBox3.Text;
            SetValueForText7 = comboBox5.Text;
            SetValueForText8 = comboBox4.Text;
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Πανεπιστήμιο")
            {
                i1 = true;
                i2 = false;
                textBox1.Visible = true;
                textBox2.Visible = true;
                comboBox2.Visible = true;
                comboBox3.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label11.Visible = true;
            }
            else if (comboBox1.Text == "Γυμναστήριο")
            {
                i2 = true;
                i1 = false;
                textBox1.Visible = true;
                textBox2.Visible = true;
                comboBox2.Visible = true;
                comboBox3.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label11.Visible = true;
            }
            else if (comboBox1.Text == "Μάθημα οδήγησης")
            {
                i2 = true;
                i1 = false;
                textBox1.Visible = true;
                textBox2.Visible = true;
                comboBox2.Visible = true;
                comboBox3.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label11.Visible = true;
            }
            else if (comboBox1.Text == "Αγγλικά")
            {
                i2 = true;
                i1 = false;
                textBox1.Visible = true;
                textBox2.Visible = true;
                comboBox2.Visible = true;
                comboBox3.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label11.Visible = true;
            }
            else if (comboBox1.Text == "Γαλλικά")
            {
                i2 = true;
                i1 = false;
                textBox1.Visible = true;
                textBox2.Visible = true;
                comboBox2.Visible = true;
                comboBox3.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label11.Visible = true;
            }
            else if (comboBox1.Text == "Ιταλικά")
            {
                i2 = true;
                i1 = false;
                textBox1.Visible = true;
                textBox2.Visible = true;
                comboBox2.Visible = true;
                comboBox3.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label11.Visible = true;
            }
            else if (comboBox1.Text == "Γερμανικά")
            {
                i2 = true;
                i1 = false;
                textBox1.Visible = true;
                textBox2.Visible = true;
                comboBox2.Visible = true;
                comboBox3.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label11.Visible = true;
            }
            else if (comboBox1.Text == "Ισπανικά")
            {
                i2 = true;
                i1 = false;
                textBox1.Visible = true;
                textBox2.Visible = true;
                comboBox2.Visible = true;
                comboBox3.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label11.Visible = true;
            }
            else if (comboBox1.Text == "Καφετέρια")
            {
                i2 = true;
                i1 = false;
                textBox1.Visible = true;
                textBox2.Visible = true;
                comboBox2.Visible = true;
                comboBox3.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label11.Visible = true;
            }
            else if (comboBox1.Text == "Βόλτα")
            {
                i2 = true;
                i1 = false;
                textBox1.Visible = true;
                textBox2.Visible = true;
                comboBox2.Visible = true;
                comboBox3.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label11.Visible = true;
            }
            else if (comboBox1.Text == "Φαγητό")
            {
                i2 = true;
                i1 = false;
                textBox1.Visible = true;
                textBox2.Visible = true;
                comboBox2.Visible = true;
                comboBox3.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label11.Visible = true;
            }
            else if (comboBox1.Text == "Πάρτυ")
            {
                i2 = true;
                i1 = false;
                textBox1.Visible = true;
                textBox2.Visible = true;
                comboBox2.Visible = true;
                comboBox3.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label11.Visible = true;
            }
            else if (comboBox1.Text == "Ψώνια")
            {
                i2 = true;
                i1 = false;
                textBox1.Visible = true;
                textBox2.Visible = true;
                comboBox2.Visible = true;
                comboBox3.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label11.Visible = true;
            }
            else if (comboBox1.Text == "Σινεμά")
            {
                i2 = true;
                i1 = false;
                textBox1.Visible = true;
                textBox2.Visible = true;
                comboBox2.Visible = true;
                comboBox3.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label11.Visible = true;
            }
            else if (comboBox1.Text == "Θέατρο")
            {
                i2 = true;
                i1 = false;
                textBox1.Visible = true;
                textBox2.Visible = true;
                comboBox2.Visible = true;
                comboBox3.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label11.Visible = true;
            }
            else if (comboBox1.Text == "Δουλειά")
            {
                i2 = true;
                i1 = false;
                textBox1.Visible = true;
                textBox2.Visible = true;
                comboBox2.Visible = true;
                comboBox3.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label11.Visible = true;
            }
            else
            {
                i1 = i2 = false;
                i5 = true;
                textBox1.Visible = false;
                textBox2.Visible = false;
                comboBox2.Visible = false;
                comboBox3.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label11.Visible = false;
            }
        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Με το αυτοκίνητο" & i1)
            {
                pictureBox4.ImageLocation = "images/Map1.png";
                pictureBox4.Visible = true;
            }
            else if (comboBox2.Text == "Με το αυτοκίνητο" & i2)
            {
                pictureBox4.ImageLocation = "images/Map4.png";
                pictureBox4.Visible = true;
            }
            else if ((comboBox2.Text == "Με τον ηλεκτρικό" || comboBox2.Text == "Με το λεωφορείο" || comboBox2.Text == "Με το μετρό" || comboBox2.Text == "Με συνδιασμό") & i1)
            {
                pictureBox4.ImageLocation = "images/Map2.png";
                pictureBox4.Visible = true;
            }
            else if ((comboBox2.Text == "Με τον ηλεκτρικό" || comboBox2.Text == "Με το λεωφορείο" || comboBox2.Text == "Με το μετρό" || comboBox2.Text == "Με συνδιασμό") & i2)
            {
                pictureBox4.ImageLocation = "images/Map5.png";
                pictureBox4.Visible = true;
            }
            else if ((comboBox2.Text == "Με τα πόδια" || comboBox2.Text == "Με το ποδήλατο") & i1)
            {
                pictureBox4.ImageLocation = "images/Map3.png";
                pictureBox4.Visible = true;
            }
            else if ((comboBox2.Text == "Με τα πόδια" || comboBox2.Text == "Με το ποδήλατο") & i2)
            {
                pictureBox4.ImageLocation = "images/Map6.png";
                pictureBox4.Visible = true;
            }
            else
            {
                pictureBox4.Visible = false;
            }
        }

        private void comboBox3_MouseHover(object sender, EventArgs e)
        {
            label13.Visible = true;
        }

        private void comboBox3_MouseLeave(object sender, EventArgs e)
        {
            if (!show)
            {
                label13.Visible = false;
            }
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            label14.Visible = true;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            if (!show)
            {
                label14.Visible = false;
            }
        }
        private void openNewForm3(object obj)
        {
            Application.Run(new Form6());
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openNewForm3);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void εμφάνισηΥποδείξεωνToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label12.Visible = true;
            label13.Visible = true;
            label14.Visible = true;
            show = true;
        }

        private void εξαφάνισηΥποδείξεωνToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            show = false;
        }

        private void βοήθειαToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "ApplicationHelp.chm", HelpNavigator.TopicId, "45");
        }

        private void comboBox5_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox5.Text == "Παραγγελία και παραλαβή από την καφετέρια")
            {
                label8.Visible = true;
                comboBox4.Visible = true;
                i3 = true;
            }
            else
            {
                label8.Visible = false;
                comboBox4.Visible = false;
                i4 = true;
            }
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            label12.Visible = true;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            if (!show)
            {
                label12.Visible = false;
            }
        }

        private void comboBox3_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox3.Text == "Ναι")
            {
                label10.Visible = true;
                comboBox5.Visible = true;
            }
            else
            {
                label10.Visible = false;
                comboBox5.Visible = false;
                label8.Visible = false;
                comboBox4.Visible = false;
                i5 = true;
            }
        }
    }
}
