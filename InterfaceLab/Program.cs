using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Array arr = new Array();
            arr.CreateArray();
            arr.Show("asdfasdfasdf");
/*            arr.Show();
*/            arr.Max();
            Console.ReadLine();
        }
    }
}
