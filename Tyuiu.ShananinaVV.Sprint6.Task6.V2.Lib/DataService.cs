using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using tyuiu.cources.programming.interfaces.Sprint6;


namespace Tyuiu.ShananinaVV.Sprint6.Task6.V2.Lib
{
    public class DataService : ISprint6Task6V2
    {
        public string CollectTextFromFile(string path)
        {
            string result = "";
            result = result.Trim();
            using (StreamReader reader = new StreamReader(path))
            {
                string lines;
                while ((lines = reader.ReadLine()) != null)
                {
                    string[] words = lines.Split(' ');
                    if (words.Length > 1)
                    {
                        result += words[1] + " ";
                    }
                    else
                    {
                        // 
                    }
                }
            }
            return result.Trim();
        }
    }
}  

