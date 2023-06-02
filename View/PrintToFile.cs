using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HemsideGenerator.View
{
    public class PrintToFile : IView
    {
        public void OutPut(string[] data)
        {
            try
            {
                FileInfo fi = new FileInfo("GenereradHemsida" + ".html");
                FileStream fs = fi.Open(FileMode.OpenOrCreate, FileAccess.Write, FileShare.Read);
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    foreach (string text in data)
                    {
                        sw.WriteLine(text);
                    };
                    sw.Close();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
