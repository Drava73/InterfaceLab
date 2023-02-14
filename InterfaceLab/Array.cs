using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLab
{
    public class Array : IOutput,IMath,ISort
    {
        private int size;
        private int[] mass;
        public int Size {
            get { return size; }

            set {
                if (size < 0) { Console.Write("Error(size<0)"); }
                else { mass = new int[size]; };
            }
        }
        public void CreateArray() {
            Console.Write("Input size array:");
            size = Convert.ToInt32(Console.ReadLine());
            mass = new int[size];
            Console.Write("\n1 - random numbers\n2 - your numbers:");
            int vool = Convert.ToInt32(Console.ReadLine());
            switch (vool)
            {
                case 1:
                    Random r = new Random();
                    for (int i = 0; i < size; i++)
                    {
                        mass[i] = r.Next(0, 50);
                    }
                    break;
                case 2:
                    for (int i = 0; i < size; i++)
                    {
                        Console.Write($"\nВведите {i + 1} число:");
                        mass[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    break;
                default:
                    Console.Write("Error");
                    break;
            }

        }
        public Array() {
            mass = new int[0];
        }
        public void Show() {
            Console.Write("\nArray:");
            for (int i = 0; i < size; i++)
            {
                Console.Write("{0,4}", mass[i]);
            }
        }
        public void Show(string info) {
            Show();
            for (int i = 0; i < info.Length; i++) {
                Console.Write(info[i]);
            }
        
        }
        public int Max() {
            int max = 0;
            for(int i = 0; i < mass.Length; i++){
                if (max > mass[i])
                {
                    max = mass[i];
                }
            }
            return max;
        }
        public int Min() {
            int min = 50;
            for (int i = 0; i < mass.Length; i++)
            {
                if (min < mass[i])
                {
                    min = mass[i];
                }
            }
            return min;
        }
        public float Avg() {
            int sredarf=0;
            for (int i = 0; i < mass.Length; i++)
            {
                sredarf += mass[i];
            }
            return sredarf/mass.Length;
        }
        public bool Search(int valueToSearch)
        {
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] == valueToSearch) return true;
            }
            return false;
        }
        public void SortAsc()
        {
            if (size <= 1) return;
            int index = 0;
            while (index < mass.Length)
            {
                if (index == 0)
                    index++;
                if (mass[index] <= mass[index - 1])
                    index++;
                else
                {
                    (mass[index], mass[index - 1]) = (mass[index - 1], mass[index]);
                    index--;
                }
            }
        }

        public void SortDesc()
        {
            if (size <= 1) return;
            int index = 0;
            while (index < mass.Length)
            {
                if (index == 0)
                    index++;
                if (mass[index] >= mass[index - 1])
                    index++;
                else
                {
                    (mass[index], mass[index - 1]) = (mass[index - 1], mass[index]);
                    index--;
                }
            }
        }

        public void SortByParam(bool isAsc)
        {
            if (isAsc == true)
            {
                SortAsc();
            }
            else SortDesc();
        }
    }
}
