
using System;

namespace P324_Loops_Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Array
            //int[] arr = {1,2,5,12,20,33 };

            //int[] arr2 = new int[5];


            //string[] strArr = new string[6];

            //string[] names = {"Chingiz","1","Camal"};

            //Console.WriteLine(names[2].Length);

            //string name = "Xaladelnik";

            //Console.WriteLine(name.Length);

            //Console.WriteLine("Before changing");
            //Console.WriteLine(arr[5]);

            //arr[5] = 260;

            //Console.WriteLine("After changing");
            //Console.WriteLine(arr[5]);

            //int number = default(int);

            //Console.WriteLine(strArr[3]);
            #endregion


            #region Loops
            //byte [] arr = { 5, 12, 23, 45, 65, 47, 92, 123, };
            //for (; ; )
            //{
            //    //arr[i] += 5;
            //    Console.WriteLine(0);
            //}

            //byte total = default(byte);

            //foreach (byte num in arr)
            //{
            //    total += num; // total = total + num
            //    //Console.WriteLine(num);
            //}
            //Console.WriteLine(total);


            //string group = "P324";

            //foreach (char letter in group)
            //{
            //    Console.WriteLine(letter);
            //}

            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int index = 0;
            //int total = 0;
            //while (total<30)
            //{
            //    total += arr[index];
            //    index++;
            //}
            //Console.WriteLine(total);


            //int index = 0;
            //int number = 0;
            //while (number != 7)
            //{
            //    number = arr[index];
            //    if(number == 7)
            //    {
            //        break;
            //    }
            //    index++;
            //}
            //Console.WriteLine(index);

            //for (int i = 0; i < length; i++)
            //{

            //}

            //int selection;
            //do
            //{
            //    Console.WriteLine("1. Operator");
            //    Console.WriteLine("2. Dil secimi");
            //    Console.WriteLine("3. Debet kart");
            //    Console.WriteLine("0. Exit");
            //    Console.WriteLine("Zehmet olmasa bir eded secin");
            //    selection = Convert.ToInt32(Console.ReadLine());

            //} 
            //while (selection != 0 && selection != 2);

            #endregion


            #region Methods
            int[] arr = { 2, 3, 7, 10, 12, 19, 21, 24 };

            int total = 0;

            //foreach (int num in arr)
            //{
            //    if(num % 2 == 0)
            //    {
            //        total += num;
            //    }
            //}


            //foreach (int num in arr)
            //{
            //    if (num % 3 == 0)
            //    {
            //        total += num;
            //    }
            //}


            //foreach (int num in arr)
            //{
            //    if (num % 5 == 0)
            //    {
            //        total += num;
            //    }
            //}



            //foreach (int num in arr)
            //{
            //    if (num % 7 == 0)
            //    {
            //        total += num;
            //    }
            //}
            //Console.WriteLine(total);

            //int num = Add();

            //Console.WriteLine(++num);


            //Console.WriteLine(15 + 5);

            //Sum(1000,"Hasan",'a'); // Console.WriteLine(10+5);

            //string name = Console.ReadLine();
            //string surname= Console.ReadLine();
            //Console.WriteLine(Fullname(name,surname));

            //Console.WriteLine("Divided by 2 \n");
            //sumArr(arr, 2);
            //Console.WriteLine("Divided by 3 \n");
            //sumArr(arr, 3);
            //Console.WriteLine("Divided by 4 ");
            //sumArr(arr, 4);
            //Console.WriteLine("Divided by 5 ");
            //sumArr(new int[]{ 1,5,20,30,90}, 5);

            //int sum = sumArrReturn(arr,10);

            //Console.WriteLine(sum + 20);

            //Console.WriteLine(sumArrReturn(arr,7));

            Sum3(2,3,num4:10);

            Console.WriteLine(Fullname(surname:"Aliyev", name:"Fakhrin"));


            #endregion

        }

        public static int Add()
        {
            int total = 5 + 10;
            return total;
        }

        //public static void Sum(int num1, string word)
        //{

        //    Console.WriteLine(num1 + " " + word);
        //}

        public static string Fullname(string name, string surname)
        {
            return name + " " + surname;
        }


        public static void sumArr(int[] arr,int divide)
        {
            int total = 0;
            foreach (int num in arr)
            {
                if (num % divide == 0)
                {
                    total += num;
                }
            }
            Console.WriteLine(total);
        }

        public static int sumArrReturn(int[] arr, int divide=2)
        {
            int total = 0;
            foreach (int num in arr)
            {
                if (num % divide == 0)
                {
                    total += num;
                }
            }
            return total;
        }

        public static void Sum3(int num1, int num2 , int num3 = 10, int num4 = 9)
        {
            Console.WriteLine(num1+ num2 + num3 + num4);
        }
    }
}
