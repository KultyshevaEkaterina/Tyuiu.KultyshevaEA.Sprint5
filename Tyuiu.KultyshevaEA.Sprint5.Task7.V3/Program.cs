using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using Tyuiu.KultyshevaEA.Sprint5.Task7.V3.Lib;

namespace Tyuiu.KultyshevaEA.Sprint5.Task7.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнила: Култышева Е. А. | ИИПб-23-3";


            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Обработка файлов                                                  *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #3                                                              *");
            Console.WriteLine("* Выполнила: Култышева Екатерина Александровна | ИИПб-23-3                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Создать папку вручную С:DataSprint5 и скопировать в неё файл, в котором *");
            Console.WriteLine("* есть набор символьных данных.                                           *");
            Console.WriteLine("* Удалить все русские буквы из файла.                                     *");
            Console.WriteLine("* Полученный результат сохранить в файл OutPutDataFileTask7V3.txt.        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask7V3.txt";
            Console.WriteLine("Данные в: " + path);
            string pathSaveFile = $@"{Directory.GetCurrentDirectory()}\OutPutDataFileTask7V3.txt";


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Итоговые данные находятся в: " + pathSaveFile);
            pathSaveFile = ds.LoadDataAndSave(path);

            Console.ReadKey();
        }
    }
}
