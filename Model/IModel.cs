using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HemsideGenerator.Model
{
    public interface IModel
    {
        string[] GetTechniques();
        string[] GetMessagesToClass ();
    }
}
