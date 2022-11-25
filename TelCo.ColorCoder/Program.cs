using System;
using System.Diagnostics;
using System.Drawing;
using TelCo.ColorCoder;
using static TelCo.ColorCoder.TelecomColor;

namespace TelCo.ColorCoder
{
    /// <summary> /// The 25-pair color code, originally known as even-count color code,is a color code used to identify individual conductors in twisted-pair wiring for telecommunications. This class provides the color coding and  mapping of pair number to color and color to pair number. /// </summary>
    class Program
    {      
        /// <summary>    /// Static constructor required to initialize static variable       /// </summary>   
        static Program()
        {            
            colorMapMajor = new Color[] { Color.White, Color.Red, Color.Black, Color.Yellow, Color.Violet };
            colorMapMinor = new Color[] { Color.Blue, Color.Orange, Color.Green, Color.Brown, Color.SlateGray };
        }      
        /// <summary>  /// Test code for the class /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            TestMethod();
        }
    }
}
