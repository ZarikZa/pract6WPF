using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract6Kalendar.Model
{
    internal class ViborNaDayModel
    {
        public List<ViborModel> viborModels; 
        public DateTime data;

        public ViborNaDayModel(DateTime date, List<ViborModel> viborModel)
        {
            this.data = date;
            this.viborModels = viborModel;
        }
    }
}
