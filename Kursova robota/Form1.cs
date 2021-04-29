using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursova_robota_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                Bitmap MyBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics MyGraphics = Graphics.FromImage(MyBitmap);
                GronsfeldBase Gronsfeld = new Ecruption(textBox1.Text,Convert.ToInt32(textBox2.Text));
                Gronsfeld.DrawAlphabetWithNumerate(ref MyGraphics);
                Gronsfeld.Draw(ref MyGraphics);
                pictureBox1.Image = MyBitmap;
            }
            else
            {
                MessageBox.Show("Введіть текст для шифрування та ключ в форматі числа!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox4.Text != "" && textBox3.Text != "")
            {
                Bitmap MyBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics MyGraphics = Graphics.FromImage(MyBitmap);
                GronsfeldBase Gronsfeld = new Decruption(textBox4.Text, Convert.ToInt32(textBox3.Text));
                Gronsfeld.DrawAlphabetWithNumerate(ref MyGraphics);
                Gronsfeld.Draw(ref MyGraphics);
                pictureBox1.Image = MyBitmap;
            }
            else
            {
                MessageBox.Show("Введіть текст для дешифрування та ключ в форматі числа!");
            }
        } 
    }
}
