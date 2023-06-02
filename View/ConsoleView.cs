using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HemsideGenerator.View
{
    public class ConsoleView : IView
    {
        public void OutPut(string[] data)
        {
            foreach (string text in data)
            {
                Console.WriteLine(text);
            };
        }
    }
}
