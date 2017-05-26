using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labar2
{
    class Controller
    {
        public string Question(string msg) 
        {
            Model model = new Model();
            return "Столько ты  "
                + model.GetAnser(msg);
        }
    }
}
