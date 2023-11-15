using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;
using Tyuiu.KultyshevaEA.Sprint5.Task0.V30.Lib;

namespace Tyuiu.KultyshevaEA.Sprint5.Task0.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\Пользователь\source\repos\Tyuiu.KultyshevaEA.Sprint5\Tyuiu.KultyshevaEA.Sprint5.Task0.V30\bin\Debug\OutPutFileTask0.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
