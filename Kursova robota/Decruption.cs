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
    class Decruption : GronsfeldBase
    {
        private string NoDecruptedWord;
        private string DecruptedWord;

        public Decruption(string Word, int Key)
        {
            NoDecruptedWord = Word;
            this.Key = Key;
        }

        public override void Draw(ref Graphics MyGraphics)
        {
            MyGraphics.DrawString("Для того щоб дешифрувати слово потрібно відняти його на відповідний номер ключа,", new Font(textBox1.Font.FontFamily, 14F), new SolidBrush(Color.Black), new PointF(0, 150));
            MyGraphics.DrawString("якщо ключ закінчується він дублюється:", new Font(textBox1.Font.FontFamily, 14F), new SolidBrush(Color.Black), new PointF(0, 170));
            float FontSize = pictureBox1.Width / NoDecruptedWord.Length;
            if (FontSize > 100)
            {
                FontSize = 50;
            }
            string KeyFull = СreateFullKey(Key.ToString(), NoDecruptedWord);
            NoDecruptedWord = NoDecruptedWord.Replace(' ', '_');
            DecruptedWord = Decryption(Key.ToString(), NoDecruptedWord);
            for (int i = 0; i < NoDecruptedWord.Length; i++)
            {
                MyGraphics.DrawString(NoDecruptedWord[i].ToString(), new Font(textBox1.Font.FontFamily, FontSize), new SolidBrush(Color.Black), new PointF(FontSize * i, 170 + FontSize));
                MyGraphics.DrawString(KeyFull[i].ToString(), new Font(textBox1.Font.FontFamily, FontSize / 2), new SolidBrush(Color.Black), new PointF(FontSize * i + FontSize / 2, 170 + FontSize + FontSize * 2));
                MyGraphics.DrawString(DecruptedWord[i].ToString(), new Font(textBox1.Font.FontFamily, FontSize), new SolidBrush(Color.Black), new PointF(FontSize * i, 170 + FontSize * 5));
            }
            char[] KeyinCharArray = Key.ToString().ToCharArray();
        }

        private static string Decryption(string key, string text)
        {
            text = text.ToLower();
            string decipheredText = null;
            string fullKey = СreateFullKey(key, text);
            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < UkrainianAlphabet.AlphaBet.Length; j++)
                {
                    if (text[i] == UkrainianAlphabet.AlphaBet[j])
                    {
                        var offset = j - Convert.ToInt32(fullKey[i]) + 48;

                        offset = CalculationOffset(offset);
                        decipheredText += Convert.ToString(UkrainianAlphabet.AlphaBet[offset]);
                    }
                }

            }
            return decipheredText;
        }
    }
}
