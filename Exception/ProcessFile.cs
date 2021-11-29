﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptionss
{
    class ProcessFile
    {
        public static void Main(string[] args)
        {
            FileStream fs = null;
            try
            {
                fs = new FileStream(@"C:\Users\augusto.almeida\Documents\data.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }finally
            {
                if (fs != null) fs.Close();
            }
        }
    }
}
