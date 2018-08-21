using System;
using System.Collections.Generic;

namespace Class_Udvoitel
{
    class Udvoitel
    {
        /// <summary>
        /// Число пользователя
        /// </summary>
        int current=1;
        /// <summary>
        /// Колличество шагов
        /// </summary>
        int count = 0;
        /// <summary>
        /// Число задачи
        /// </summary>
        public int Finish { get; private set; }

        /// <summary>
        /// Стэк для сохранения результатов
        /// </summary>
        Stack<int> history = new Stack<int>();

        public int Current
        {
            get { return current; }
        }

        public int Count
        {
            get { return count; }
        }

        /// <summary>
        /// Метод вычесления минимального колличества шагов
        /// </summary>
        public int Steps
        {
            get
            {
                int f = Finish;
                int i = 0;
                while (f != 1)
                {
                    f = f % 2 == 0 ? f / 2 : f - 1;
                    i++;
                }
                return i;
            }

        }


        public Udvoitel(int min, int max)
        {
            Finish = new Random().Next(min, max + 1);
        }

        public Udvoitel()
        {
            Finish = new Random().Next(10, 101);
        }

        public Udvoitel(int finish)
        {
            this.Finish = finish;
        }

        /// <summary>
        /// Метод добаления +1
        /// </summary>
        /// <returns>Результат +1</returns>
        public int Plus()
        {
            history.Push(current);
            current++;
            count++;
            return current;
        }

        /// <summary>
        /// Метод умножения на 2
        /// </summary>
        /// <returns>Результат *2</returns>
        public int Multi()
        {
            history.Push(current);
            current *= 2;
            count++;
            return current;
        }

        /// <summary>
        /// Начать игру заново
        /// </summary>
        public void Reset()
        {
            current = 1;
            history.Clear();
            count = 0;
        }

        /// <summary>
        /// Возврат последнего значения и минус счетчика
        /// </summary>
        /// <returns></returns>
        public int Back()
        {
            if (history.Count != 0)
            {
                count--;
                return current = history.Pop();               
            }
            else return 1;
        }

        /// <summary>
        /// Перегруженный метод ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return current.ToString();
        }
    }
}
