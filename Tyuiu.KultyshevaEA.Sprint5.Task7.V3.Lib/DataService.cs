using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using System.Text.RegularExpressions;



using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KultyshevaEA.Sprint5.Task7.V3.Lib
{
    public class DataService : ISprint5Task7V3
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = $@"{Directory.GetCurrentDirectory()}\OutPutDataFileTask7V3.txt";

            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(pathSaveFile);
            }

            
            
                
                string text = File.ReadAllText(path);

                
                string pattern = "[А-Яа-я]";
                string result = Regex.Replace(text, pattern, "");

                
                File.WriteAllText(pathSaveFile, result);

            return pathSaveFile;
            
            



        }

    }
}

