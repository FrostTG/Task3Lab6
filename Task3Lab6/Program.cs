using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            string startString = Console.ReadLine(); //пишем текст
            //string[] array = startString.Split(); разделяем текст на символы? и без него работает
            for (int i = 0; i < startString.Length; i++) 
            {
                if (startString[i] == '{')
                {
                    for (int j = i + 1; j < startString.Length; j++)
                    {
                        if (startString[j] == '}')
                        {
                            startString = startString.Substring(0, i) + startString.Substring(j + 1); //извлекает из строки от { до }+1
                            break; //прерывает и повторяет заново с уже исправленным n раз текстом
                        }
                    }
                }
            }
            Console.WriteLine(startString);
            Console.ReadKey();           
        }
    }
}
