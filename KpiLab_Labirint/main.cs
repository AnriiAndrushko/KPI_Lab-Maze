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
            LabirintType1 test1 = new LabirintType1(10, 10);
            test1.printLabirint();
            Console.WriteLine();
            LabirintType2 test2 = new LabirintType2(10, 10);
            test2.printLabirint();
            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}
