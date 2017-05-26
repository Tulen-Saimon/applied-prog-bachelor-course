using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labar2
{
    class data
    {
     
        public static string GetAnser(string question)
        {
            string path = "D:\\point.txt"; 

       
            using (StreamReader sr =
                new StreamReader(path, Encoding.Default))
            {
                string str = null;
                while (true)
                {
                
                    str = sr.ReadLine();
                    if (str != null)
                    {
                        if (str == question)
                            return "есть шанс (но это не точно)";
                    }
                    else
                        return "никогда не получишь";
                }
            }
        }
    }
}
