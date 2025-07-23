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
    public partial class Form12 : Form
    {
        Thread th;
        bool on = true;
        bool show;
        String url;
        
        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
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

        private void κεντρικήToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openNewForm);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void εμφάνισηΥποδείξεωνToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            show = true;
        }

        private void εξαφάνισηΥποδείξεωνToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
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
            Help.ShowHelp(this, "ApplicationHelp.chm", HelpNavigator.TopicId, "49");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (on)
            {
                groupBox1.Enabled = true;                
                pictureBox1.ImageLocation = "images/buttonON.png";
                pictureBox3.ImageLocation = "images/ShoeCase-open.png";
                on = false;
            }
            else
            {
                groupBox1.Enabled = false;                
                pictureBox1.ImageLocation = "images/buttonOFf.png";
                pictureBox3.ImageLocation = "images/ShoeCase-close.png";
                on = true;
            }
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
            if (comboBox1.SelectedIndex.Equals(0))
            {
                if (comboBox2.SelectedIndex.Equals(1) || comboBox2.SelectedIndex.Equals(2))
                {
                    System.Diagnostics.Process.Start("https://www.skroutz.gr/s/20643603/Clarks-Edward-Plain-Δερμάτινα-Ανδρικά-Σκαρπίνια-Ταμπά-26139536.html");
                    System.Diagnostics.Process.Start("https://www.skroutz.gr/s/25497908/S-Oliver-Ανδρικά-Σκαρπίνια-Μαύρα-5-13203-35-001.html");
                    System.Diagnostics.Process.Start("https://www.skroutz.gr/s/20351575/Boxer-10068-Δερμάτινα-Ανδρικά-Casual-Παπούτσια-Μαύρα.html");
                }
                else
                {
                    System.Diagnostics.Process.Start("https://www.skroutz.gr/s/27571542/Gant-Prepville-Ανδρικά-Casual-Παπούτσια-Μαύρα-22638666-G69.html");
                    System.Diagnostics.Process.Start("https://www.skroutz.gr/s/27676421/Adidas-Stan-Smith-Unisex-Sneakers-Λευκά-FX5501.html");
                    System.Diagnostics.Process.Start("https://www.skroutz.gr/s/9194494/Adidas-Gazelle-Unisex-Sneakers-Μαύρα-BB5476.html");
                }
            }
            else if(comboBox1.SelectedIndex.Equals(1))
            {
                if (comboBox2.SelectedIndex.Equals(0))
                {
                    System.Diagnostics.Process.Start("https://www.skroutz.gr/s/4256738/Nike-T-lite-XI-616544-101-Ανδρικά-Αθλητικά-Παπούτσια-για-Προπόνηση-Γυμναστήριο-Λευκά.html");
                    System.Diagnostics.Process.Start("https://www.skroutz.gr/s/20361854/Nike-Revolution-5-BQ3204-002-Ανδρικά-Αθλητικά-Παπούτσια-Running-Μαύρα.html");
                    System.Diagnostics.Process.Start("https://www.skroutz.gr/s/30146714/Salomon-Alphacross-3-GTX-414467-Ανδρικά-Αθλητικά-Παπούτσια-Trail-Running-Μπλε-Αδιάβροχα-με-Μεμβράνη-Gore-Tex.html");
                }
                else if (comboBox2.SelectedIndex.Equals(1))
                {
                    System.Diagnostics.Process.Start("https://www.skroutz.gr/s/8429465/Adidas-Copa-Mundial-FG-015110-Χαμηλά-Ποδοσφαιρικά-Παπούτσια-με-Τάπες-Μαύρα.html");
                    System.Diagnostics.Process.Start("https://www.skroutz.gr/s/24385917/Nike-Mercurial-Vapor-13-Academy-MG-AT5269-060-Χαμηλά-Ποδοσφαιρικά-Παπούτσια-με-Τάπες-Μαύρα.html");
                    System.Diagnostics.Process.Start("https://www.skroutz.gr/s/13002315/Adidas-X-17-1-FG-S82288-Χαμηλά-Ποδοσφαιρικά-Παπούτσια-με-Τάπες-Μαύρα.html");
                }
                else
                {
                    System.Diagnostics.Process.Start("https://www.skroutz.gr/s/30502756/Nike-Giannis-Immortality-CZ4099-010-Χαμηλά-Μπασκετικά-Παπούτσια-Μαύρα.html");
                    System.Diagnostics.Process.Start("https://www.skroutz.gr/s/30512970/Jordan-One-Take-II-CW2457-607-Χαμηλά-Μπασκετικά-Παπούτσια-Κόκκινα.html");
                    System.Diagnostics.Process.Start("https://www.skroutz.gr/s/30464919/Under-Armour-Lockdown-5-3023949-102-Ψηλά-Μπασκετικά-Παπούτσια-Λευκά.html");
                }
            }
            else if (comboBox1.SelectedIndex.Equals(2))
            {
                if (comboBox2.SelectedIndex.Equals(0) || comboBox2.SelectedIndex.Equals(1))
                {
                    System.Diagnostics.Process.Start("https://www.skroutz.gr/s/12505604/Timberland-Bradstreet-Δερμάτινα-Κίτρινα-Ανδρικά-Μποτάκια-A1989.html");
                    System.Diagnostics.Process.Start("https://www.skroutz.gr/s/30725207/Robinson-2614-Μαύρα-Ανδρικά-Αρβυλάκια.html");
                    System.Diagnostics.Process.Start("https://www.skroutz.gr/s/32993163/Ugg-Australia-Stenton-Δερμάτινα-Καφέ-Ανδρικά-Αρβυλάκια-1120990-CLTHR.html");
                }
            }
            else
            {
                if (comboBox2.SelectedIndex.Equals(0))
                {
                    System.Diagnostics.Process.Start("https://www.skroutz.gr/s/26382694/Nike-Venture-Runner-Unisex-Sneakers-Γκρι-CK2944-009.html");
                    System.Diagnostics.Process.Start("https://www.skroutz.gr/s/22195349/Nike-SB-Charge-Unisex-Sneakers-Μαύρα-CT3463-001.html");
                    System.Diagnostics.Process.Start("https://www.skroutz.gr/s/30471274/U-S-Polo-Assn-Ανδρικά-Flatforms-Sneakers-Μαύρα-NOBIL003-BLK.html");
                }
            }
            button1.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Text = "";
            comboBox2.Items.Clear();
            label3.Enabled = true;
            comboBox2.Enabled = true;
            pictureBox4.ImageLocation = "";
            pictureBox5.ImageLocation = "";
            pictureBox6.ImageLocation = "";
            groupBox2.Enabled = false;
            groupBox3.Visible = false;
            if (comboBox1.SelectedIndex.Equals(0))
            {             
                comboBox2.Items.Insert(0, "Δουλειά");
                comboBox2.Items.Insert(1, "Γάμος – Βάπτιση");
                comboBox2.Items.Insert(2, "Κηδεία");
                comboBox2.Items.Insert(3, "Επίσκεψη");
            }
            else if (comboBox1.SelectedIndex.Equals(1))
            {
                comboBox2.Items.Insert(0, "Γυμναστήριο");
                comboBox2.Items.Insert(1, "Ποδόσφαιρο");
                comboBox2.Items.Insert(2, "Μπάσκετ");
            }
            else if(comboBox1.SelectedIndex.Equals(2))
            {
                comboBox2.Items.Insert(0, "Αδιάβροχα");
                comboBox2.Items.Insert(1, "Μπότες");
            }
            else
            {
                comboBox2.Items.Insert(0, "Περπάτημα");
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
            button1.Enabled = true;
            if (comboBox1.SelectedIndex.Equals(0))
            {
                if (comboBox2.SelectedIndex.Equals(0))
                {
                    pictureBox4.ImageLocation = "images/shoes/shoes2.png";
                    pictureBox5.ImageLocation = "images/shoes/shoes4.png";
                    pictureBox6.ImageLocation = "images/shoes/shoes5.png";
                }
                else if (comboBox2.SelectedIndex.Equals(1))
                {
                    pictureBox4.ImageLocation = "images/shoes/shoes1.png";
                    pictureBox5.ImageLocation = "images/shoes/shoes2.png";
                    pictureBox6.ImageLocation = "images/shoes/shoes3.png";
                }
                else if (comboBox2.SelectedIndex.Equals(2))
                {
                    pictureBox4.ImageLocation = "images/shoes/shoes2.png";
                    pictureBox5.ImageLocation = "images/shoes/shoes3.png";
                    pictureBox6.ImageLocation = "images/shoes/shoes4.png";
                }
                else
                {
                    pictureBox4.ImageLocation = "images/shoes/shoes1.png";
                    pictureBox5.ImageLocation = "images/shoes/shoes2.png";
                    pictureBox6.ImageLocation = "images/shoes/shoes5.png";
                }
            }
            else if (comboBox1.SelectedIndex.Equals(1))
            {
                if (comboBox2.SelectedIndex.Equals(0))
                {
                    pictureBox4.ImageLocation = "images/shoes/shoes7.png";
                    pictureBox5.ImageLocation = "images/shoes/shoes8.png";
                    pictureBox6.ImageLocation = "images/shoes/shoes9.png";
                }
                else if (comboBox2.SelectedIndex.Equals(1))
                {
                    pictureBox4.ImageLocation = "images/shoes/shoes10.png";
                    pictureBox5.ImageLocation = "images/shoes/shoes11.png";
                    pictureBox6.ImageLocation = "images/shoes/shoes12.png";
                }
                else
                {
                    pictureBox4.ImageLocation = "images/shoes/shoes13.png";
                    pictureBox5.ImageLocation = "images/shoes/shoes14.png";
                    pictureBox6.ImageLocation = "images/shoes/shoes15.png";
                }
            }
            else if (comboBox1.SelectedIndex.Equals(2))
            {
                if (comboBox2.SelectedIndex.Equals(0))
                {
                    pictureBox4.ImageLocation = "images/shoes/shoes19.png";
                    pictureBox5.ImageLocation = "images/shoes/shoes20.png";
                    pictureBox6.ImageLocation = "images/shoes/shoes21.png";
                }
                else
                {
                    pictureBox4.ImageLocation = "images/shoes/shoes16.png";
                    pictureBox5.ImageLocation = "images/shoes/shoes17.png";
                    pictureBox6.ImageLocation = "images/shoes/shoes18.png";
                }
            }
            else
            {
                pictureBox4.ImageLocation = "images/shoes/shoes5.png";
                pictureBox5.ImageLocation = "images/shoes/shoes6.png";
                pictureBox6.ImageLocation = "images/shoes/shoes7.png";
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            DialogResult result;
            var pictureBox = sender as PictureBox;
            if (pictureBox4.Name.Equals(pictureBox.Name))
            {
                result = MessageBox.Show("Επιλέξατε το 1° ζευγάρι." + Environment.NewLine + "Θέλετε να συνεχίσετε;","Are you sure?", MessageBoxButtons.YesNo);
                
            }
            else if (pictureBox5.Name.Equals(pictureBox.Name))
            {
                result = MessageBox.Show("Επιλέξατε το 2° ζευγάρι." + Environment.NewLine + "Θέλετε να συνεχίσετε;", "Are you sure?", MessageBoxButtons.YesNo);
                
            }
            else
            {
                result = MessageBox.Show("Επιλέξατε το 3° ζευγάρι." + Environment.NewLine + "Θέλετε να συνεχίσετε;", "Are you sure?", MessageBoxButtons.YesNo);
                
            }
            if (result == DialogResult.Yes)
            {
                comboBox1.ResetText();
                comboBox2.ResetText();
                comboBox2.Items.Clear();
                comboBox2.Enabled = false;
                label3.Enabled = false;
                url = pictureBox.ImageLocation;
                pictureBox4.ImageLocation = "";
                pictureBox5.ImageLocation = "";
                pictureBox6.ImageLocation = "";
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;                
                timer1.Enabled = true;
            }
        }

        private void pictureBox_MouseHover(object sender, EventArgs e)
        {
            var pictureBox = sender as PictureBox;
            pictureBox.BorderStyle = BorderStyle.FixedSingle;
            if (pictureBox4.Name.Equals(pictureBox.Name))
            {               
                label4.Visible = true;
            }
            else if (pictureBox5.Name.Equals(pictureBox.Name))
            {
                label5.Visible = true;
            }
            else
            {
                label6.Visible = true;
            }
        }

        private void pictureBox_MouseLeave(object sender, EventArgs e)
        {
            var pictureBox = sender as PictureBox;
            pictureBox.BorderStyle = BorderStyle.None;
            if (!show)
            {
                if (pictureBox4.Name.Equals(pictureBox.Name))
                {
                    label4.Visible = false;
                }
                else if (pictureBox5.Name.Equals(pictureBox.Name))
                {
                    label5.Visible = false;
                }
                else
                {
                    label6.Visible = false;
                }
            }            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var pictureBox = sender as PictureBox;
            progressBar1.Visible = true;
            label8.Visible = true;
            if (progressBar1.Value <= progressBar1.Maximum - 10)
            {
                progressBar1.Value += 10;

            }
            if (progressBar1.Value.Equals(100))
            {
                progressBar1.Visible = false;
                label8.Visible = false;
                groupBox3.Visible = true;
                groupBox1.Enabled = true;
                button1.Enabled = false;
                pictureBox8.ImageLocation = url;
                timer1.Enabled = false;
                progressBar1.Value = 0;
                MessageBox.Show("Τα παπούτσια σας είναι έτοιμα και βρίσκονται στην εξώπορτα σας!!!", "Success", 0, MessageBoxIcon.Information);                
            }
        }       
    }
}
