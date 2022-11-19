using System;

namespace TelCo.ColorCoder
{
    public partial class TelecomColor
    {

       
        public static void GenerateColorCodeManual()
        {
            // The function supports only 1 based index. Pair numbers valid are from 1 to 25
            int minorSize = colorMapMinor.Length;
            int majorSize = colorMapMajor.Length;
            for(int pair_number = 1; pair_number <= minorSize * majorSize; pair_number++)
            {
                pair = Get_ColorfromColorLogic(pair_number, minorSize);

                var print_colorcode = (pair_number) + "    " + pair.majorColor.Name + "      " + pair.minorColor.Name;
                Console.WriteLine(print_colorcode);
            }

        }
    }
}
