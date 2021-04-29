using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursova_robota_
{
    class UkrainianAlphabet
    {
        private static char[] UkrainianAlphaBetArray = new char[] { 'а', 'б', 'в', 'г', 'ґ', 'д', 'е', 'є', 'ж', 'з', 'и', 'і', 'ї', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ь', 'ю', 'я', '_' };

        public static char[] AlphaBet
        {
            get
            {
                return UkrainianAlphaBetArray;
            }
        }
    }
}
