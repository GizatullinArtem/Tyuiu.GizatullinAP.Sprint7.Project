using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;
using Tyuiu.GizatullinAP.Sprint7.Project.V14.Lib;

namespace Tyuiu.GizatullinAP.Sprint7.Project.V14.Test
{
    [TestClass]
    public class DataServiceTest

    {
        DataService ds = new DataService();

        string filePath = @"C:\DataSprint5\GizatullinAP.DataBase.csv";
        public static string[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;
            string[,] arrayValues = new string[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = line_r[c];
                }
            }

            return arrayValues;
        }


    }


}

