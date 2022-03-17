using System;

namespace HWork1703
{
    class Program
    {
        static void Main(string[] args)
        {
            #region TASK3

            //    Console.WriteLine("eded daxil et:");
            //    int number = Convert.ToInt32(Console.ReadLine());
            //    int qaliq = 0;
            //    int sum = 0;
            //    int sumOfDigits = SumOfDigits(number, qaliq, sum);
            //    Console.WriteLine($"Reqemlerin cemi:{sumOfDigits}");


            //}
            //static int SumOfDigits(int number, int qaliq, int sum)
            //{
            //    while (number >= 1)
            //    {
            //        qaliq = number % 10;
            //        sum += qaliq;
            //        number /= 10;
            //          return sum;
            //    }
            //    if (sum > 0)
            //    {
            //        Console.WriteLine($"Reqemlerin cemi:{sum}");

            //    }
            //    else
            //        sum = 0;
            //    Console.WriteLine($"Reqemlerin cemi:{sum}");
            //}
            #endregion
            #region TASK4
            //            Console.WriteLine("elementlerin sayini daxil et:");
            //            int counter = Convert.ToInt32(Console.ReadLine());
            //            int[] numbers = new int[counter];
            //            int max =0;
            //            for (int i = 0; i < numbers.Length; i++)
            //            {
            //                Console.WriteLine($"{i + 1}ci  elementi daxil et:");
            //                numbers[i] = Convert.ToInt32(Console.ReadLine());
            //            }
            //            int maxElement = MaxElementInArray(numbers);
            //            Console.WriteLine($"maxelement: {max}");
            //        }

            //        static int MaxElementInArray(int max,int[] numbers)
            //        {   max = numbers[0];
            //            for (int i = 1; i < numbers.Length; i++)
            //            {
            //                if (numbers[i] > max)
            //                {
            //                    max = numbers[i];
            //                    
            //                }
            //                return max;
            //            }
            //                 return 0;
            //        }
            //    }


            #endregion
            #region TASK2
            //static int NearRootOfNumber(int num)
            //{
            //    int a = 0;
            //    for (int i = 0; i * i <= num; i++)
            //    {
            //        a = i;
            //    }
            //    return a;
            //}

            #endregion
            #region TASK5

            static int ChangeToPositive(int[] array, int i)
            {
                //for (i = 0; i < array.Length; i ++)
                //{
                //    if (array[i] < 0)
                //    {
                //        array[i] = array[i] * (-1);

                //    }
                //}
                //return array[i];

                #endregion

            #region TASK1
                static int FindIndex(string word, char letter)
                {
                    for (int i = 0; i < word.Length; i++)
                    {
                        if (word[i] == letter)
                        {
                            return i;
                        }

                    }
                    return -1;

                }
                #endregion
            }
        }
    }
}
                    
            
     