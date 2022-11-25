using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelCo.ColorCoder
{
 
    public  partial class TelecomColor
    {
         public static ColorPair pair;
         public static ColorPair GetColorFromPairNumber(int pairNumber) 
         {
            pair = FindColorFromPairNumber(pairNumber);
            // return the value
            return pair;
         }
         public static int GetPairNumberFromColor(ColorPair pair)
         {
            int pairnumber = FindPairNumberFromColor(pair);
            return pairnumber;
         }

    }
    public class ColorPair
    {
        internal Color majorColor;
        internal Color minorColor;
        public override string ToString()
        {
            return string.Format("MajorColor:{0}, MinorColor:{1}", majorColor.Name, minorColor.Name);
        }
    }

}




