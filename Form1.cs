using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cards4Clarke
{
    public partial class pokerForm : Form
    {
        int jj;
        Boolean b1;
        Boolean b2;
        Boolean b3;
        Boolean b4;
        Boolean b5;
        Boolean b6;
        Boolean b7;

        public pokerForm()
        {
            InitializeComponent();
        }


        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        public int RandomNumber2(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (b1 == true)
            {
                jj = RandomNumber(0, imageList1.Images.Count);
                if (jj != 0)
                {
                    pictureBox7.Image = imageList1.Images[jj - 1];
                    imageList1.Images.RemoveAt(jj - 1);
                }
                else
                {
                    pictureBox7.Image = imageList1.Images[jj];
                    imageList1.Images.RemoveAt(jj);
                }
                b1 = false;
            }
            if (b2 == true)
            {
                jj = RandomNumber(0, imageList1.Images.Count);
                if (jj != 0)
                {
                    pictureBox11.Image = imageList1.Images[jj - 1];
                    imageList1.Images.RemoveAt(jj - 1);
                }
                else
                {
                    pictureBox11.Image = imageList1.Images[jj];
                    imageList1.Images.RemoveAt(jj);
                }
                b2 = false;
            }
            if (b3 == true)
            {
                jj = RandomNumber(0, imageList1.Images.Count);
                if (jj != 0)
                {
                    pictureBox8.Image = imageList1.Images[jj - 1];
                    imageList1.Images.RemoveAt(jj - 1);
                }
                else
                {
                    pictureBox8.Image = imageList1.Images[jj];
                    imageList1.Images.RemoveAt(jj);
                }
                b3 = false;
            }
            if (b4 == true)
            {
                jj = RandomNumber(0, imageList1.Images.Count);
                if (jj != 0)
                {
                    pictureBox10.Image = imageList1.Images[jj - 1];
                    imageList1.Images.RemoveAt(jj - 1);
                }
                else
                {
                    pictureBox10.Image = imageList1.Images[jj];
                    imageList1.Images.RemoveAt(jj);
                }
                b4 = false;
            }
            if (b5 == true)
            {
                jj = RandomNumber(0, imageList1.Images.Count);
                if (jj != 0)
                {
                    pictureBox9.Image = imageList1.Images[jj - 1];
                    imageList1.Images.RemoveAt(jj - 1);
                }
                else
                {
                    pictureBox9.Image = imageList1.Images[jj];
                    imageList1.Images.RemoveAt(jj);
                }
                b5 = false;
            }
            if (b6 == true)
            {
                jj = RandomNumber(0, imageList1.Images.Count);
                if (jj != 0)
                {
                    pictureBox12.Image = imageList1.Images[jj - 1];
                    imageList1.Images.RemoveAt(jj - 1);
                }
                else
                {
                    pictureBox12.Image = imageList1.Images[jj];
                    imageList1.Images.RemoveAt(jj);
                }
                b6 = false;
            }
            if (b7 == true)
            {
                jj = RandomNumber(0, imageList1.Images.Count);
                if (jj != 0)
                {
                    pictureBox13.Image = imageList1.Images[jj - 1];
                    imageList1.Images.RemoveAt(jj - 1);
                }
                else
                {
                    pictureBox13.Image = imageList1.Images[jj];
                    imageList1.Images.RemoveAt(jj);
                }
                b7 = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            jj = RandomNumber(0, imageList1.Images.Count);
            if (jj != 0)
            {
                pictureBox1.Image = imageList1.Images[jj - 1];
                imageList1.Images.RemoveAt(jj - 1);
            }
            else
            {
                pictureBox1.Image = imageList1.Images[jj];
                imageList1.Images.RemoveAt(jj);
            }
            b1 = true;
            button2.Visible = false;
            button3.Visible = true;
        }

        private void pokerForm_Load(object sender, EventArgs e)
        {
            button1.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            jj = RandomNumber(0, imageList1.Images.Count);
            pictureBox2.Image = imageList1.Images[jj];
            pictureBox8.Image = imageList2.Images[jj];
            imageList1.Images.RemoveAt(jj - 1);
            button3.Visible = false;
            button4.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            jj = RandomNumber(0, imageList1.Images.Count);
            pictureBox3.Image = imageList1.Images[jj];
            pictureBox9.Image = imageList2.Images[jj];
            imageList1.Images.RemoveAt(jj - 1);
            button4.Visible = false;
            button5.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            jj = RandomNumber(0, imageList1.Images.Count);
            pictureBox5.Image = imageList1.Images[jj];
            pictureBox11.Image = imageList2.Images[jj];
            imageList1.Images.RemoveAt(jj - 1);
            button6.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            jj = RandomNumber(0, imageList1.Images.Count);
            pictureBox4.Image = imageList1.Images[jj];
            pictureBox10.Image = imageList2.Images[jj];
            imageList1.Images.RemoveAt(jj - 1);
            button5.Visible = false;
            button6.Visible = true;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            jj = RandomNumber(0, imageList1.Images.Count);
            if (jj != 0)
            {
                pictureBox5.Image = imageList1.Images[jj - 1];
                imageList1.Images.RemoveAt(jj - 1);
            }
            else
            {
                pictureBox5.Image = imageList1.Images[jj];
                imageList1.Images.RemoveAt(jj);
            }
            b2 = true;
            button6.Enabled = false;
            button7.Visible = true;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            jj = RandomNumber(0, imageList1.Images.Count);
            if (jj != 0)
            {
                pictureBox4.Image = imageList1.Images[jj - 1];
                imageList1.Images.RemoveAt(jj - 1);
            }
            else
            {
                pictureBox4.Image = imageList1.Images[jj];
                imageList1.Images.RemoveAt(jj);
            }
            b4 = true;
            button5.Visible = false;
            button6.Visible = true;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            jj = RandomNumber(0, imageList1.Images.Count);
            if (jj != 0)
            {
                pictureBox3.Image = imageList1.Images[jj - 1];
                imageList1.Images.RemoveAt(jj - 1);
            }
            else
            {
                pictureBox3.Image = imageList1.Images[jj];
                imageList1.Images.RemoveAt(jj);
            }
            b5 = true;
            button4.Visible = false;
            button5.Visible = true;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            jj = RandomNumber(0, imageList1.Images.Count);
            if (jj != 0)
            {
                pictureBox2.Image = imageList1.Images[jj - 1];
                imageList1.Images.RemoveAt(jj - 1);
            }
            else
            {
                pictureBox2.Image = imageList1.Images[jj];
                imageList1.Images.RemoveAt(jj);
            }
            b3 = true;
            button3.Visible = false;
            button4.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You're not supposed to be here!!");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            jj = RandomNumber(0, imageList1.Images.Count);
            if (jj != 0)
            {
                pictureBox14.Image = imageList1.Images[jj - 1];
                imageList1.Images.RemoveAt(jj - 1);
            }
            else
            {
                pictureBox14.Image = imageList1.Images[jj];
                imageList1.Images.RemoveAt(jj);
            }
            b6 = true;
            button7.Visible = false;
            button8.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            jj = RandomNumber(0, imageList1.Images.Count);
            if (jj != 0)
            {
                pictureBox15.Image = imageList1.Images[jj - 1];
                imageList1.Images.RemoveAt(jj - 1);
            }
            else
            {
                pictureBox15.Image = imageList1.Images[jj];
                imageList1.Images.RemoveAt(jj);
            }
            b7 = true;
            button8.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
