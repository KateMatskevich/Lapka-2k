using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; //Для разрешения использования типов в пространстве имен, чтобы не нужно было квалифицировать использование типа в этом пространстве имен
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args) //точка входа приложения
        {

            #region 1 task
            #region 1a task
            int intType = 19;
            double doubleType = 28.5;
            float floatType = 2899;
            char charType = 't';
            string stringType = "text";
            #endregion        
            #region 1b task
            doubleType = intType; // явное приведение
            floatType = charType;
            floatType = intType;
            intType = charType;

            intType = (int)doubleType;
            charType = (char)intType;
            floatType = (float)charType;
            doubleType = (double)floatType;
            stringType = Convert.ToString(floatType);
            #endregion          
            #region 1c task
            object boxing = intType; // для преобразования значимого типа в ссылочный
            int unboxing = (int)boxing; //распоковка из ссылочного в значимый
            #endregion        
            #region 1d task 
            var kate = "My name is Kate"; // неявно типизированная переменная
            // kate = 3; error
            #endregion
            Console.WriteLine("-----------1e task------------");
            #region 1e task
            string NullableVariable = null; // переменная значимого типа не может принимать значение null
            string Nothing = "";
            if (NullableVariable == null)
                Console.WriteLine("Null");
            else
                Console.WriteLine("not null");
            if (Nothing == null)
                Console.WriteLine("Null");
            else
                Console.WriteLine("not null");
            #endregion
            #endregion

            #region 2 task
            #region 2a task
            Console.WriteLine("---------------2a task---------------");
            string first = "this is first string";
            string second = "this is second string";
            Console.WriteLine(first.Equals(second)); //сравнение
            string not = "new";
            string notNew = "new";
            Console.WriteLine(not.Equals(notNew));
            #endregion
            #region 2b task
            Console.WriteLine("--------------2b task--------------");
            string StringVariableOne = "String Number One";
            string StringVariableTwo = "String Number One";
            string StringVariableThi = "String Number One";
            Console.WriteLine(String.Compare(StringVariableOne, StringVariableTwo)); // Сравнение строк
            Console.WriteLine(StringVariableOne.Contains(StringVariableTwo)); // Поиск Подстроки
            Console.WriteLine(StringVariableOne.Substring(4)); // Получение подстроки начиная с символа(4) и до конца строки 
            Console.WriteLine(StringVariableOne.Insert(7, StringVariableThi)); // Вставка начиная с символа(7)
            Console.WriteLine(StringVariableOne.Replace(StringVariableOne, StringVariableTwo)); //Замена строк
            #endregion
            #region 2c task
            Console.WriteLine("--------------2c task-----------");
            string NullableVariabl = null;
            string Nothings = "";
            if (NullableVariabl == null)
                Console.WriteLine("Null");
            else
                Console.WriteLine("not null");
            if (Nothings == null)
                Console.WriteLine("Null");
            else
                Console.WriteLine("not null");

            int? x = 7;
            Console.WriteLine(x);
            #endregion
            #region 2d task
            Console.WriteLine("----------------------2d task---------------------");
            StringBuilder myStringBuilder = new StringBuilder("Just smile!");
            myStringBuilder.Remove(0, 5);//удаляет указанный диапазон символов из данного экземпляра
            Console.WriteLine(myStringBuilder);
            myStringBuilder.Insert(0, "Beautiful "); // вставляет сторку в данный экземпляр
            Console.WriteLine(myStringBuilder);
            myStringBuilder.Insert(15, ", man");
            Console.WriteLine(myStringBuilder);
            #endregion
            #endregion

            #region 3 task
            #region 3a task
            Console.WriteLine("-------------------3a task----------------");
            int myInt1 = 5; // двумерный массив
            int myInt2 = 4;
            int[,] mas = new int[myInt1, myInt2];
            Random rn = new Random();
            for (int i = 0; i < myInt1; i++)
                for (int j = 0; j < myInt2; j++)
                    mas[i, j] = rn.Next(10);
            for (int i = 0; i < myInt1; i++)
            {
                for (int j = 0; j < myInt2; j++)
                    Console.Write(String.Format("{0,3}", mas[i, j]));
                Console.WriteLine();
            }
            #endregion
            #region 3b task
            Console.WriteLine("------------3b task-----------");
            var myAr = new[] {"word","new word","one more word" };
            for (int i = 0; i < myAr.Length; i++)
                Console.WriteLine(myAr[i]);
                Console.WriteLine(myAr.Length);
            myAr[2] = "not a new word";
            for (int i = 0; i < myAr.Length; i++)
                Console.WriteLine(myAr[i]);
            #endregion
            #region 3c task
            Console.WriteLine("------------3c task--------------");
            int[][] myNewArr = new int[3][] { new int[2], new int[3], new int[4] }; //ступенчатый массив
            for (int i = 0; i < myNewArr.Length; i++)
            {
                for (int j = 0; j < myNewArr[i].Length; j++)
                {
                    Console.Write($"myArr[{i}][{j}] = ");
                    myNewArr[i][j] = int.Parse(Console.ReadLine()); 
                }
            }
            for (int i = 0; i < myNewArr.Length; i++)
            {
                Console.WriteLine(string.Join(" ", myNewArr[i]));
            }
            #endregion
            #region 3d task ---
            Console.WriteLine("--------------3d task------------"); // неявно типизированные переменные для хранения массива и строки. 
            var firstArr = new[] 
            {
                new
                {
                    word = "it is word",
                    numbers = new[] {555,666,777}
                }
            };
            for (int i = 0; i < firstArr.Length; i++)
                Console.WriteLine(firstArr[i]);
            #endregion
            #endregion

            #region 4 task
            #region 4a task
            (int, string, char, string, ulong) myFirstTuple = (9, "string", 'k', "OneMoreString", 2211490);
            #endregion
            #region 4b task
            Console.WriteLine("-----------------4b task--------------");
            Console.WriteLine($"{myFirstTuple.Item1} {myFirstTuple.Item2} {myFirstTuple.Item3} {myFirstTuple.Item4} {myFirstTuple.Item5}");
            Console.WriteLine($"{myFirstTuple.Item1} {myFirstTuple.Item3} {myFirstTuple.Item5}");
            #endregion
            #region 4c task
            Console.WriteLine("----------------4c task--------------");
            var yyy = myFirstTuple.Item1;// распаковка кортежа в переменные
            Console.WriteLine(yyy);
            #endregion
            #region 4d task 
            Console.WriteLine("4d task"); //сравнение двух кортежей
            (int, string, char, string, ulong) mySecondTuple = (2, "", 'h', "kgsr", 68523);

            if ((myFirstTuple.Item1 == mySecondTuple.Item1) && (myFirstTuple.Item2 == mySecondTuple.Item2) && (myFirstTuple.Item3 == mySecondTuple.Item3) && (myFirstTuple.Item4 == mySecondTuple.Item4) && (myFirstTuple.Item5 == mySecondTuple.Item5))
                Console.WriteLine("Cortage are equal");
            else
                Console.WriteLine("not equal");
            #endregion
            #endregion

            #region 5 task
            Console.WriteLine("-------------5 task----------");
            int[] arr1 = { 1, 2, 3, 5, 7, 6 };

            dynamic myFunction(Array arr, string str)
            {
                int intMax = 0;
                int intMin = 0;
                int summ = 0;
                foreach (int index in arr)
                {
                    if (intMax < index)
                        intMax = index;
                    if (intMin > index)
                        intMin = index;
                    summ += index;
                }
                return (intMax, intMin, summ, str[0]);
            }
            myFunction(arr1, "i did it");
            Console.WriteLine(myFunction(arr1, "i did it"));
            #endregion
        }
    }
}
