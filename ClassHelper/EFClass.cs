using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _163OnMyNeckFeatOgBurmikFtAnisimov.BD;

namespace _163OnMyNeckFeatOgBurmikFtAnisimov.ClassHelper
{
    public class EFClass
    {
        public static Entities context { get; } = new Entities();

    }
}
