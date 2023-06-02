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
        private string printStart()
        {
            return "<!DOCTYPE html>\n<html>\n<body>\n<main>\n";
        }
        private string printWelcome(string className, string[] message)
        {
            string welcome = $"<h1> Välkomna {className}! </h1>";

            string welcomeMessage = "";

            foreach (string msg in message)
            {
                welcomeMessage += $"\n<p><b> Meddelande: </b> {msg} </p>";
            }
            return welcomeMessage;
        }
        private string printKurser()
        {
            return courseGenerator(this.model.GetTechniques());
        }
        private string printEnd()
        {
            return "</main>\n</body>\n</html>";
        }


        public void printPage()
        {
            string[] page = new string[4];

            page[0] = printStart();
            page[1] = printWelcome("Klass A", this.model.GetMessagesToClass());
            page[2] = printKurser();
            page[3] = printEnd();

            this.view.OutPut(page);

        }


        private string courseGenerator(string[] techniques)
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
