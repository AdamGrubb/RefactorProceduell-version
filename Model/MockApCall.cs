using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HemsideGenerator.Model
{
    public class MockApCall : IModel
    {
        public string[] GetTechniques()
        {
            return new string[] { "C#", "daTAbaser", "WebbuTVeCkling", "clean Code" };

        }
        public string[] GetMessagesToClass()
        {
            return new string[] { "Glöm inte att övning ger färdighet!", "Öppna boken på sida 257." };

        }
    }
}
