using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Method_Resize_and_addition
{
    internal class Program
    {
        static int [] Resize (ref int[] array, int length)
        {
            if(array == null || length<0)
                return null;
            int[] newArray = new int[length];

            for (int i = 0; i < length; i++)
            {
                if (i == array.Length)
                    break;
                newArray[i] = array[i];
            }
            return newArray;
        }


        static void AddFirstElement(ref int[] array, int Element)
        {
            int[] newArray = new int[array.Length + 1];
            newArray[0] = Element;

            for (int i = 0; i < array.Length; i++)
            {
                newArray[i + 1] = array[i];
            }
            array = newArray;
        }


        static void DeleteFirstElement(ref int[] array)
        {
            int[] newArray = new int[array.Length - 1];
            for (int i = 0; i < array.Length - 1; i++)
            {
                newArray[i] = array[i + 1];
            }
            array = newArray;
        }


        static void AddLastElement(ref int[] array, int Element)
        {
            int[] newArray = new int[array.Length + 1];
            
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }
            newArray[array.Length] = Element;

            array = newArray;
        }

        static void DeleteLastElement(ref int[] array)
        {
            int[] newArray = new int[array.Length - 1];
            for (int i = 0; i < array.Length - 1; i++)
            {
                newArray[i] = array[i];
            }
            array = newArray;
        }


        static void AddElementByIndex(ref int[] array, int element, int index)
        {
            int[] newArray = new int[array.Length + 1];

            for (int i = 0; i < index; i++)
            {
                newArray[i] = array[i];
            }

            newArray[index] = element;

            for (int i = index; i < array.Length; i++)
            {
                newArray[i + 1] = array[i];
            }
            
            array = newArray;
        }


        static void DeleteElementByIndex(ref int[] array, int index)
        {
            int[] newArray = new int[array.Length - 1];

            for (int i = 0; i < index; i++)
            {
                newArray[i] = array[i];
            }

            for (int i = index; i < array.Length - 1; i++)
            {
                newArray[i] = array[i + 1];
            }

            array = newArray;
        }


        static int[] FillArray (int [] array)
        {
            Random random = new Random();
            for (int i = 0;i< array.Length;i++)
            {
                array[i] = random.Next(100);
            }
            return array;
        }


        static void OutputArray (int [] array)
        {
            Dekor();
            Console.Write("\nYour array:\t");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + "  |  ");
            }
            Dekor();
        }


        static void Dekor()
        {
            Console.WriteLine();
            for (int i = 0; i < 120; i++)
            {
                Console.Write("-");
            }
        }


        static void Main(string[] args)
        {
            Console.Write("Your array size: ");
            if (!int.TryParse(Console.ReadLine(), out int length) || length < 0)
            {
                Dekor();
                Console.Write("Invalid array length");
                Dekor();
                return;
            }

            int[] myArray = new int [length];

            myArray = FillArray(myArray);
            OutputArray(myArray);

            Console.Write("Lets change array size to 7");
            myArray = Resize(ref myArray, 7);
            if (myArray == null)
            {
                Dekor();
                Console.WriteLine("Array is null");
                Dekor();
                return;
            }
            OutputArray(myArray);
            
            Console.Write("\nLets delete first element of array!");
            DeleteFirstElement(ref myArray);
            OutputArray(myArray);

            Console.Write("\nLets delete last element of array!");
            AddLastElement(ref myArray, 10);
            OutputArray(myArray);

            Console.Write("\nLets delete element with index: ");
            if (!int.TryParse(Console.ReadLine(), out int index) || index < 0 || index >= myArray.Length )
            {
                Dekor();
                Console.WriteLine("Impossible index");
                Dekor();
                return;
            }
            DeleteElementByIndex(ref myArray, index);
            OutputArray(myArray);

            Console.Write("\nLets add first element of array!");
            AddFirstElement(ref myArray , 13);
            OutputArray(myArray);

            Console.Write("\nLets add last element of array!");
            AddLastElement(ref myArray , 99);
            OutputArray(myArray);

            Console.Write("\nLets add element with index: ");
            if (!int.TryParse(Console.ReadLine(), out int index2) || index2 < 0 || index2 >= myArray.Length)
            {
                Dekor();
                Console.WriteLine("Impossible index");
                Dekor();
                return;
            }

            Console.Write("Lets add element with number: ");
            if (!int.TryParse(Console.ReadLine(), out int element))
            {
                Dekor();
                Console.WriteLine("Impossible element");
                Dekor();
                return;
            }

            AddElementByIndex(ref myArray,element ,index2);
            OutputArray(myArray);
        }
    }
}
