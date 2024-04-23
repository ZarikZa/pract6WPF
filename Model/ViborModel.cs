using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace pract6Kalendar.Model
{
    internal class ViborModel
    {
        public string name;
        public string pathKartinki;
        public bool selected;

        public ViborModel(string name, string pathKartinki, bool selected)
        {
            this.name=name;
            this.pathKartinki=pathKartinki;
            this.selected=selected;
        }
    }
}
