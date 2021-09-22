using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace KpiLab_Labirint
{
    class MainClass
    {
        static void Main()
        {
            LabirintBase test1 = new LabirintType1(10, 10);
            test1.PrintLabirint();
            Console.WriteLine();
            LabirintBase test2 = new LabirintType2(10, 10);
            test2.PrintLabirint();
            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}
