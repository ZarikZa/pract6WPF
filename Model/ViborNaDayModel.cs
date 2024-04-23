using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract6Kalendar.Model
{
    internal class ViborNaDayModel
    {
        public DateTime data;
        List<ViborModel> viborModels;

        public ViborNaDayModel(DateTime date, List<ViborModel> viborModels)
        {
            this.data = date;
            this.viborModels = viborModels;
        }
    }
}
