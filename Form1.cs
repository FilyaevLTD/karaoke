using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ushuaia_Karaoke_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.WindowState = FormWindowState.Maximized;  // разворачивание на весь экран
            InitializeComponent();
            

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.BackColor = checkBox1.Checked ? Color.Lime : Color.FromKnownColor(KnownColor.Control);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.BackColor = checkBox2.Checked ? Color.Lime : Color.FromKnownColor(KnownColor.Control);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            checkBox3.BackColor = checkBox3.Checked ? Color.Lime : Color.FromKnownColor(KnownColor.Control);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            checkBox4.BackColor = checkBox4.Checked ? Color.Lime : Color.FromKnownColor(KnownColor.Control);
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            checkBox5.BackColor = checkBox5.Checked ? Color.Lime : Color.FromKnownColor(KnownColor.Control);
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            checkBox6.BackColor = checkBox6.Checked ? Color.Lime : Color.FromKnownColor(KnownColor.Control);
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            checkBox7.BackColor = checkBox7.Checked ? Color.Lime : Color.FromKnownColor(KnownColor.Control);
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            checkBox8.BackColor = checkBox8.Checked ? Color.Lime : Color.FromKnownColor(KnownColor.Control);
        }
        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            checkBox9.BackColor = checkBox9.Checked ? Color.Lime : Color.FromKnownColor(KnownColor.Control);
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            checkBox10.BackColor = checkBox10.Checked ? Color.Lime : Color.FromKnownColor(KnownColor.Control);
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            checkBox11.BackColor = checkBox11.Checked ? Color.Lime : Color.FromKnownColor(KnownColor.Control);
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            checkBox12.BackColor = checkBox12.Checked ? Color.Lime : Color.FromKnownColor(KnownColor.Control);
        }
        // Кнопка 1  

        private void button1_Click(object sender, EventArgs e)
        {


            string isChecked = "";

            if (checkBox1.Checked) isChecked += " Стол1";
            if (checkBox2.Checked) isChecked += " Стол2";
            if (checkBox3.Checked) isChecked += " Стол3";
            if (checkBox4.Checked) isChecked += " Стол4";
            if (checkBox5.Checked) isChecked += " Стол5";
            if (checkBox6.Checked) isChecked += " Стол6";
            if (checkBox7.Checked) isChecked += " Стол7";
            if (checkBox8.Checked) isChecked += " Стол8";
            if (checkBox9.Checked) isChecked += " Стол9";
            if (checkBox10.Checked) isChecked += " Стол10";
            if (checkBox11.Checked) isChecked += " Стол11";
            if (checkBox12.Checked) isChecked += " Стол12";

            MessageBox.Show(isChecked);

        }




        //  Кнопка 2


        void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            int a;


            // Рандом выбор стола

            Random rand = new Random(); // Объявляется на уровне класса

            CheckBox randomBox = this.Controls
                     .OfType<CheckBox>()
                     .Where(cb => cb.Checked)
                     .OrderBy(cb => rand.Next())
                     .First();

            listBox1.Items.Add(string.Format(randomBox.Name));




            // Брался размер экрана 1920 х 1080  (ноутбук 1546х845) (Pipo 961, 538)
            int length = 1700;
            int wedth = 992;  // Было 855



            if (listBox1.Items.Cast<string>().Contains("checkBox1"))
            {
                button2.Visible = false;
                a = listBox1.Items.IndexOf("checkBox1"); //get the index of "checkBox1"

                //  Загрузка картинки checkBox1  _______________________________________

                this.WindowState = FormWindowState.Maximized;  // разворачивание на весь экран
                Bitmap image1 = (Bitmap)(Ushuaia_Karaoke_1.Properties.Resources.Stol1);
                pictureBox1.Location = new System.Drawing.Point(-2, 0);//left,top
                pictureBox1.Size = new System.Drawing.Size(length, wedth);
                pictureBox1.BorderStyle = BorderStyle.Fixed3D;
                pictureBox1.Image = image1;
                //     listBox1.Items.RemoveAt(a);
            }

            // выбор 2го стола ____________________________________________________________________________________

            if (listBox1.Items.Cast<string>().Contains("checkBox2"))
            {
                button2.Visible = false;
                a = listBox1.Items.IndexOf("checkBox2"); //get the index of "checkBox3"
                //  MessageBox.Show("Выиграл стол №2 !");

                // Загрузка картинки checkBox2

                this.WindowState = FormWindowState.Maximized;  // разворачивание на весь экран
                Bitmap image2 = (Bitmap)(Ushuaia_Karaoke_1.Properties.Resources.Stol2);
                pictureBox1.Location = new System.Drawing.Point(-2, 0);//left,top
                pictureBox1.Size = new System.Drawing.Size(length, wedth);
                pictureBox1.BorderStyle = BorderStyle.Fixed3D;
                pictureBox1.Image = image2;
            }

            // выбор 3го стола __________________________________________________________________________
            if (listBox1.Items.Cast<string>().Contains("checkBox3"))
            {
                button2.Visible = false;
                a = listBox1.Items.IndexOf("checkBox3"); //get the index of "checkBox3"
                //  MessageBox.Show("Выиграл стол №3 !");
                //      this.WindowState = FormWindowState.Maximized;  // разворачивание на весь экран
                Bitmap image2 = (Bitmap)(Ushuaia_Karaoke_1.Properties.Resources.Stol3);
                pictureBox1.Location = new System.Drawing.Point(-2, 0);//left,top
                pictureBox1.Size = new System.Drawing.Size(length, wedth);
                pictureBox1.BorderStyle = BorderStyle.Fixed3D;
                pictureBox1.Image = image2;
            }

            // выбор 4го стола ____________________________________________________________________________________

            if (listBox1.Items.Cast<string>().Contains("checkBox4"))
            {
                button2.Visible = false;
                a = listBox1.Items.IndexOf("checkBox4"); //get the index of "checkBox1"
                //                    MessageBox.Show("Выиграл стол №4 !");

                // Загрузка картинки checkBox4

                this.WindowState = FormWindowState.Maximized;  // разворачивание на весь экран
                Bitmap image4 = (Bitmap)(Ushuaia_Karaoke_1.Properties.Resources.Stol4);
                pictureBox1.Location = new System.Drawing.Point(-2, 0);//left,top
                pictureBox1.Size = new System.Drawing.Size(length, wedth);
                pictureBox1.BorderStyle = BorderStyle.Fixed3D;
                pictureBox1.Image = image4;
            }
            // выбор 5го стола ____________________________________________________________________________________

            if (listBox1.Items.Cast<string>().Contains("checkBox5"))
            {
                button2.Visible = false;
                a = listBox1.Items.IndexOf("checkBox5"); //get the index of "checkBox5"
                //                    MessageBox.Show("Выиграл стол №5 !");
                // Загрузка картинки checkBox5
                this.WindowState = FormWindowState.Maximized;  // разворачивание на весь экран
                Bitmap image5 = (Bitmap)(Ushuaia_Karaoke_1.Properties.Resources.Stol5);
                pictureBox1.Location = new System.Drawing.Point(-2, 0);//left,top
                pictureBox1.Size = new System.Drawing.Size(length, wedth);
                pictureBox1.BorderStyle = BorderStyle.Fixed3D;
                pictureBox1.Image = image5;
            }

            // выбор 6го стола ____________________________________________________________________________________

            if (listBox1.Items.Cast<string>().Contains("checkBox6"))
            {
                button2.Visible = false;
                a = listBox1.Items.IndexOf("checkBox6"); //get the index of "checkBox6"
                //                    MessageBox.Show("Выиграл стол №6 !");
                // Загрузка картинки checkBox6
                this.WindowState = FormWindowState.Maximized;  // разворачивание на весь экран
                Bitmap image6 = (Bitmap)(Ushuaia_Karaoke_1.Properties.Resources.Stol6);
                pictureBox1.Location = new System.Drawing.Point(-2, 0);//left,top
                pictureBox1.Size = new System.Drawing.Size(length, wedth);
                pictureBox1.BorderStyle = BorderStyle.Fixed3D;
                pictureBox1.Image = image6;
            }

            // выбор 7го стола ____________________________________________________________________________________

            if (listBox1.Items.Cast<string>().Contains("checkBox7"))
            {
                button2.Visible = false;
                a = listBox1.Items.IndexOf("checkBox7"); //get the index of "checkBox7"
                //                    MessageBox.Show("Выиграл стол №7 !");
                // Загрузка картинки checkBox5
                this.WindowState = FormWindowState.Maximized;  // разворачивание на весь экран
                Bitmap image7 = (Bitmap)(Ushuaia_Karaoke_1.Properties.Resources.Stol7);
                pictureBox1.Location = new System.Drawing.Point(-2, 0);//left,top
                pictureBox1.Size = new System.Drawing.Size(length, wedth);
                //    pictureBox1.Size = new System.Drawing.Size(961, 538);
                pictureBox1.BorderStyle = BorderStyle.Fixed3D;
                pictureBox1.Image = image7;
            }

            // выбор 8го стола ____________________________________________________________________________________

            if (listBox1.Items.Cast<string>().Contains("checkBox8"))
            {
                button2.Visible = false;
                a = listBox1.Items.IndexOf("checkBox8"); //get the index of "checkBox8"
                //                    MessageBox.Show("Выиграл стол №8 !");
                // Загрузка картинки checkBox5
                this.WindowState = FormWindowState.Maximized;  // разворачивание на весь экран
                Bitmap image8 = (Bitmap)(Ushuaia_Karaoke_1.Properties.Resources.Stol8);
                pictureBox1.Location = new System.Drawing.Point(-2, 0);//left,top
                pictureBox1.Size = new System.Drawing.Size(length, wedth);
                pictureBox1.BorderStyle = BorderStyle.Fixed3D;
                pictureBox1.Image = image8;
            }

            // выбор 9го стола ____________________________________________________________________________________

            if (listBox1.Items.Cast<string>().Contains("checkBox9"))
            {
                button2.Visible = false;
                a = listBox1.Items.IndexOf("checkBox9"); //get the index of "checkBox9"
                //                    MessageBox.Show("Выиграл стол №9 !");
                // Загрузка картинки checkBox9
                //      panel1.BackgroundImage = Properties.Resources.Ресурсы; // Ресурсы - названия нашего файла
                this.WindowState = FormWindowState.Maximized;  // разворачивание на весь экран
                Bitmap image9 = (Bitmap)(Ushuaia_Karaoke_1.Properties.Resources.Stol9);
                pictureBox1.Location = new System.Drawing.Point(-2, 0);//left,top
                pictureBox1.Size = new System.Drawing.Size(length, wedth);
                pictureBox1.BorderStyle = BorderStyle.Fixed3D;
                pictureBox1.Image = image9;
            }

            // выбор 10го стола ____________________________________________________________________________________

            if (listBox1.Items.Cast<string>().Contains("checkBox10"))
            {
                button2.Visible = false;
                a = listBox1.Items.IndexOf("checkBox10"); //get the index of "checkBox10"
                //                    MessageBox.Show("Выиграл стол №10 !");
                // Загрузка картинки checkBox10
                this.WindowState = FormWindowState.Maximized;  // разворачивание на весь экран
                Bitmap image10 = (Bitmap)(Ushuaia_Karaoke_1.Properties.Resources.Stol10);
                pictureBox1.Location = new System.Drawing.Point(-2, 0);//left,top
                pictureBox1.Size = new System.Drawing.Size(length, wedth);
                pictureBox1.BorderStyle = BorderStyle.Fixed3D;
                pictureBox1.Image = image10;
            }

            // выбор 11го стола ____________________________________________________________________________________

            if (listBox1.Items.Cast<string>().Contains("checkBox11"))
            {
                button2.Visible = false;
                a = listBox1.Items.IndexOf("checkBox11"); //get the index of "checkBox11"
                //                    MessageBox.Show("Выиграл стол №11 !");
                // Загрузка картинки checkBox11
                this.WindowState = FormWindowState.Maximized;  // разворачивание на весь экран
                //    Bitmap image11 = new Bitmap("d://image//Stol11.gif"); // Работало но со своего диска
                Bitmap image11 = (Bitmap)(Ushuaia_Karaoke_1.Properties.Resources.Stol11);
                pictureBox1.Location = new System.Drawing.Point(-2, 0);//left,top
                pictureBox1.Size = new System.Drawing.Size(length, wedth);
                pictureBox1.BorderStyle = BorderStyle.Fixed3D;
                pictureBox1.Image = image11;
            }

            // выбор 12го стола ____________________________________________________________________________________

            if (listBox1.Items.Cast<string>().Contains("checkBox12"))
            {
                button2.Visible = false;
                a = listBox1.Items.IndexOf("checkBox12"); //get the index of "checkBox12"
                //                    MessageBox.Show("Выиграл стол №12 !");
                // Загрузка картинки checkBox12
                this.WindowState = FormWindowState.Maximized;  // разворачивание на весь экран
                Bitmap image12 = (Bitmap)(Ushuaia_Karaoke_1.Properties.Resources.Stol12);
                pictureBox1.Location = new System.Drawing.Point(-2, 0);//left,top
                pictureBox1.Size = new System.Drawing.Size(length, wedth);
                pictureBox1.BorderStyle = BorderStyle.Fixed3D;
                pictureBox1.Image = image12;
            }



        }

        //private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        //}

        //private void textBox1_TextChanged(object sender, EventArgs e)
        //{
        //    char length;
        //    string.IsNullOrWhiteSpace(textBox1.Text);
        //    label1.Text = textBox1.Text;
        //    int length = Convert.ToInt32(textBox1.Text);

        //}

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    int length = Convert.ToInt32(textBox1.Text);
        //}

        




    }
}
    





