using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
    public class Help
    {
        public static int ToInt(string x)
        {
            int i;
            bool b = Int32.TryParse(x, out i);
            if (b == true)
                return i;
            else
            {

            }

            return i;
        }
        public static double ToDouble(string x)
        {
            double i;
            bool b = Double.TryParse(x, out i);
            if (b == true)
                return i;
            else
            {

            }
            return i;
        }
        //public static double ContainPoint(string x)
        //{
            //return 5.9;
        //}

    }
}
