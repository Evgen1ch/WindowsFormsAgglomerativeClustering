using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgglomerativeClustering
{
    public class DataReader
    {
        public static float[,] ReadCsv(string filename)
        {
            int counter = 0;
            
            char[] delims = {' ', ',', '\t', ';'};
            string[] lines = File.ReadAllLines(filename);

            int rows = lines.Length;
            int cols = 0;
            if (lines.Length != 0)
                cols = lines[0].Split(delims, StringSplitOptions.RemoveEmptyEntries).Length;

            if (cols == 0 || rows == 0) 
                return new float[0, 0];

            float[,] result = new float[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                string[] slicedLine = lines[i].Split(delims, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < cols; j++)
                {
                    //bool isNumber = float.TryParse(slicedLine[j], out result[i, j]);
                    //if (!isNumber)
                    //    throw new FormatException($"Cannot convert \"{slicedLine[j]}\" to float");
                    result[i, j] = Convert.ToSingle(slicedLine[j], CultureInfo.InvariantCulture);
                }

                counter++;
            }

            Console.WriteLine($"Successfully read {counter} lines from file");

            

            return result;
        }

        public static List<List<float>> Read(string filename)
        {
            int counter = 0;

            char[] delims = { ' ', ',', '\t', ';' };
            string[] lines = File.ReadAllLines(filename);

            int rows = lines.Length;
            int cols = 0;
            if (lines.Length != 0)
                cols = lines[0].Split(delims, StringSplitOptions.RemoveEmptyEntries).Length;

            if (cols == 0 || rows == 0)
                return new List<List<float>>();

            List<List<float>> result = new List<List<float>>();
            for (int i = 0; i < rows; i++)
            {
                string[] slicedLine = lines[i].Split(delims, StringSplitOptions.RemoveEmptyEntries);
                List<float> newEntry = new List<float>();
                for (int j = 0; j < cols; j++)
                {
                    newEntry.Add(Convert.ToSingle(slicedLine[j], CultureInfo.InvariantCulture));
                }
                result.Add(newEntry);
                counter++;
            }

            Console.WriteLine($"Successfully read {counter} lines from file");
            

            return result;
        }
    }
}
