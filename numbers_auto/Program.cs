using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace numbers_auto
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Введите гос номер авто ");
                string auto = Console.ReadLine();

                if (AUTO.IsTryeNomberAuto(auto))
                {
                    Console.WriteLine("Номер  есть");
                }
                else
                {
                    Console.WriteLine("Номерf  нет ");
                }
            }
        }
    }
}