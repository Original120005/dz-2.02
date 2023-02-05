using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_2._02
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Задание 1
int[] array = { 1, -3, 8, 15, -2, 7, 4, -3 };

            //Найти наибольший нечетный элемент
            int maxOdd = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 1 && array[i] > maxOdd)
                {
                    maxOdd = array[i];
                }
            }

            //Циклический сдвиг элементов, стоящих справа три раза
            for (int j = 0; j < 3; j++)
            {
                int temp = array[array.Length - 1];
                for (int i = array.Length - 1; i > 0; i--)
                {
                    if (array[i] == maxOdd)
                    {
                        break;
                    }
                    array[i] = array[i - 1];
                }
                array[0] = temp;
            }


           // Задание 2:
int[] array = { 1, 5, 7, 0, 8, -3, 0 };
            int sum = 0;

            bool firstZero = false;

            foreach (int element in array)
            {
                if (firstZero)
                {
                    if (element == 0)
                    {
                        break;
                    }
                    else
                    {
                        sum += element;
                    }
                }
                else
                {
                    if (element == 0)
                    {
                        firstZero = true;
                    }
                }
            }

            Console.WriteLine(sum);

           // Задание 3:
bool FindSubsetSum(int[] arr, int n, int sum)
            {
                // Если заданная сумма равна нулю
                if (sum == 0)
                    return true;

                // Если длина массива меньше или равна нулю или заданная сумма меньше или равна нулю
                if (n == 0 || sum < 0)
                    return false;

                // Проверка последнего элемента в массиве
                bool include = FindSubsetSum(arr, n - 1, sum - arr[n - 1]);

                // Проверка всего массива
                bool exclude = FindSubsetSum(arr, n - 1, sum);

                // Возвращение true или false
                return include || exclude;
            }
        }
    }
}
