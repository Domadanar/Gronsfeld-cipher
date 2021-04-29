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
    abstract class GronsfeldBase : Form1
    {
        protected int Key;

        protected static string СreateFullKey(string key, string inputText)
        {
            while (key.Length < inputText.Length)
            {
                key += key;
            }
            if (key.Length > inputText.Length)
            {
                key = key.Substring(0, key.Length - (key.Length - inputText.Length));
            }
            return key;
        }
        public void DrawAlphabetWithNumerate(ref Graphics MyGraphics)
        {
            int SpaceWidth = 15;
            int Counter = 0;
            for (int i = 0; i <= 33; i++)
            {
                MyGraphics.DrawString(Counter.ToString(), new Font(textBox1.Font.FontFamily, 14F), new SolidBrush(Color.Black), new PointF((SpaceWidth + 14) * i, 10));
                MyGraphics.DrawString(UkrainianAlphabet.AlphaBet[i].ToString(), new Font(textBox1.Font.FontFamily, 14F), new SolidBrush(Color.Black), new PointF((SpaceWidth + 14) * i, 30));
                Counter++;
            }
            int j = 0;
            for (int i = 34; i < UkrainianAlphabet.AlphaBet.Length; i++)
            {
                MyGraphics.DrawString(Counter.ToString(), new Font(textBox1.Font.FontFamily, 14F), new SolidBrush(Color.Black), new PointF((SpaceWidth + 14) * j, 50));
                MyGraphics.DrawString(UkrainianAlphabet.AlphaBet[i].ToString(), new Font(textBox1.Font.FontFamily, 14F), new SolidBrush(Color.Black), new PointF((SpaceWidth + 14) * j, 70));
                j++;
                Counter++;
            }


        }
        protected static int CalculationOffset(int iputOffset)
        {
            if (iputOffset >= UkrainianAlphabet.AlphaBet.Length)
            {
                while (iputOffset >= UkrainianAlphabet.AlphaBet.Length)
                {
                    iputOffset = iputOffset - UkrainianAlphabet.AlphaBet.Length;
                }
            }
            else if (iputOffset < 0)
            {
                while (iputOffset < 0)
                {
                    iputOffset = iputOffset + UkrainianAlphabet.AlphaBet.Length;
                }
            }
            return iputOffset;

        }
        public abstract void Draw(ref Graphics MyGraphics);
    }
}
