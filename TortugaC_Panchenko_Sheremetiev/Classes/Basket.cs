using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TortugaC_Panchenko_Sheremetiev.BD;

namespace TortugaC_Panchenko_Sheremetiev.Classes
{
    class Basket
    {
        public static List<Dish> dishes = new List<Dish>();
    }

    public interface MenuInterface 
    {
        void ChangeDishCount(int count);
    }

}
