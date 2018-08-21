using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Ugaday_chislo
{
    class UgadayChislo
    {
        /// <summary>
        /// Число зазагаданное мопьютером
        /// </summary>
        int chislo;
        /// <summary>
        /// Колличество попыток
        /// </summary>
        int count;

        public int Chislo
        {
            get { return chislo; }
        }

        public int Count
        {
            get { return count; }
        }

        public UgadayChislo()
        {
            chislo = new Random().Next(101);
            count = 0;
        }

        /// <summary>
        /// Метод проверки введенного значения и добавления шага
        /// </summary>
        /// <param name="number">Число введенное пользователем</param>
        /// <returns>Равно или ложь</returns>
        public bool IsCorrect(int number)
        {
            ++count;
            return chislo == number;
        }

        /// <summary>
        /// Метод проверки введенного значения
        /// </summary>
        /// <param name="number">Число введенное пользователем</param>
        /// <returns>Больше или ложь</returns>
        public bool IsHigher(int number)
        {
            return number > chislo;
        }
    }
}
