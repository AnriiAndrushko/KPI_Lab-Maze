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
            labirintType1 test = new labirintType1(20, 20);
            test.printLabirint();
            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}
