using HemsideGenerator.Model;
using HemsideGenerator.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HemsideGenerator.Controller
{
    public class HemsideGeneratorController
    {
        private readonly IModel model;
        private readonly IView view;

        public HemsideGeneratorController(IModel model, IView view)
        {
            this.model = model;
            this.view = view;
        }
        private string PrintStart()
        {
            return "<!DOCTYPE html>\n<html>\n<body>\n<main>\n";
        }
        private string PrintWelcome(string className, string[] message)
        {
            string welcome = $"<h1> Välkomna {className}! </h1>";

            string welcomeMessage = "";

            foreach (string msg in message)
            {
                welcomeMessage += $"\n<p><b> Meddelande: </b> {msg} </p>";
            }
            return welcomeMessage;
        }
        private string PrintKurser()
        {
            return CourseGenerator(this.model.GetTechniques());
        }
        private string PrintEnd()
        {
            return "</main>\n</body>\n</html>";
        }


        public void PrintPage()
        {
            string[] page = new string[4];

            page[0] = PrintStart();
            page[1] = PrintWelcome("Klass A", this.model.GetMessagesToClass());
            page[2] = PrintKurser();
            page[3] = PrintEnd();

            this.view.OutPut(page);

        }


        private string CourseGenerator(string[] techniques)
        {
            string kurser = "";

            foreach (string technique in techniques)
            {
                string tmp = technique.Trim();
                kurser += "<p>" + tmp[0].ToString().ToUpper() + tmp.Substring(1).ToLower() + "</p>\n";
            }

            return kurser;
        }
    }
}
