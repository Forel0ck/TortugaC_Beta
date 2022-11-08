using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TortugaC_Panchenko_Sheremetiev.BD;

namespace TortugaC_Panchenko_Sheremetiev.Classes
{
    class ClassEntities
    {
        public static TortugaCEntities3 context { get; set; } = new TortugaCEntities3();
    }
}
