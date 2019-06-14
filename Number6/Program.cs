using System;
namespace Number6
{
    class Program
    {
        /// <summary>
        /// Функция для рекурсивного рассчета последовательности
        /// </summary>
        /// <param name="a1"></param>
        /// <param name="a2"></param>
        /// <param name="a3"></param>
        /// <param name="m"></param>
        static void FunctionAN(int a1, int a2, int a3, int m)
        {
            int CurrentN = a1 * a2 + a3;
            if (CurrentN < m)
                FunctionAN(a2, a3, CurrentN, m);
            else
            {
                if (CurrentN == m)
                    Console.WriteLine("An = m");
                else
                    Console.WriteLine(" An>m ");
            }
            Console.WriteLine("a =" + CurrentN);
        }
        static void Main(string[] args)
        {
            Console.Write("Введите а1:");
            int a1 = CheckInput(true, true);
            Console.Write("Введите а2:");
            int a2 = CheckInput(true, true);
            Console.Write("Введите а3:");
            int a3 = CheckInput(true, true);
            Console.Write("Введите M:");
            int m = CheckInput(true, true);
            FunctionAN(a1, a2, a3, m);
            Console.ReadLine();
        }

        /// <summary>
        /// Метод ответственный за контроль ввода целых значений с клавиатуры
        /// </summary>
        /// <param name="OnlyPositive">Проверять на положительные значения</param>
        /// <param name="ExceptZero">Проверять на ноль</param>
        /// <returns></returns>
        public static int CheckInput(bool OnlyPositive = false, bool ExceptZero = false)
        {
            int resultat = 0;
            bool ok = false;
            do
            {
                string InputetString = Console.ReadLine();
                try
                {
                    resultat = Convert.ToInt32(InputetString);
                    ok = true;
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ошибка ввода!!! Необходимо ввести целое число!!!");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Повторите ввод");
                    ok = false;
                }
                if (ok == true)
                {
                    // проверим условия заданные в параметрах метода
                    if (OnlyPositive)
                    {
                        if (resultat < 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Ошибка !!! Необходимо ввести целое положительное значение!!!");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Повторите ввод");
                            ok = false;
                        }
                    }
                    if (ExceptZero)
                    {
                        if (resultat == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Ошибка !!! Значение не должно равняться нулю!!!");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Повторите ввод");
                            ok = false;
                        }
                    }
                }
            } while (ok == false);
            return resultat;
        }
    }
}
