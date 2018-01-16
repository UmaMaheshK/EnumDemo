using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumDemo
{
    class ToString
    {
        enum Colors { Red = 1, Blue = 2, Green = 2 };
        enum Shade { White = 0, Gray = 1, Grey = 1, Black = 2 }
        [Flags] enum Shade1 { White = 0, Gray = 1, Grey = 1, Black = 2 }

        public static void Main()
        {
            EnumToStringExp1();
            EnumToStringExp2();
            EnumToStringExp3();
        }

        private static void EnumToStringExp1()
        {
            Enum myColors = Colors.Red;
            Console.WriteLine("The value of this instance is '{0}'", myColors.ToString());
            /*
                Output.
                The value of this instance is 'Red'.
            */
        }

        private static void EnumToStringExp2()
        {
            string colorName = ((Colors)2).ToString();
            Console.WriteLine("((Colors)2).ToString() : = {0}", colorName);//((Colors)2).ToString() : = Blue
        }

        private static void EnumToStringExp3()
        {
            string shadeName = ((Shade)1).ToString();
            Console.WriteLine("((Shade)1).ToString() : = {0}", shadeName);//((Shade)1).ToString() : = Gray

            Enum shade = (Shade)1;
            Console.WriteLine("((Shade)1).ToString() : = {0:G}", shade);//((Shade)1).ToString() : = Gray
            Console.WriteLine("((Shade)1).ToString() : = {0:D}", shade);//((Shade)1).ToString() : = 1
            Console.WriteLine("((Shade)1).ToString() : = {0:F}", shade);//((Shade)1).ToString() : = Grey

            shadeName = ((Shade1)1).ToString();
            Console.WriteLine("((Shade1)1).ToString() : = {0}", shadeName);//((Shade1)1).ToString() : = Grey

            shade = (Shade1)1;
            Console.WriteLine("((Shade1)1).ToString() : = {0:G}", shade);//((Shade1)1).ToString() : = Grey
            Console.WriteLine("((Shade1)1).ToString() : = {0:D}", shade);//((Shade1)1).ToString() : = 1
            Console.WriteLine("((Shade1)1).ToString() : = {0:F}", shade);//((Shade1)1).ToString() : = Grey

            shade = Shade.Gray | Shade.Grey;
            Console.WriteLine("((Shade)).ToString() : = {0:G}", shade);//((Shade)1).ToString() : = Gray
            Console.WriteLine("((Shade)).ToString() : = {0:D}", shade);//((Shade)1).ToString() : = 1
            Console.WriteLine("((Shade)).ToString() : = {0:F}", shade);//((Shade)1).ToString() : = Grey

            shade = Shade1.Gray | Shade1.Grey;
            Console.WriteLine("((Shade1)).ToString() : = {0:G}", shade.ToString());//((Shade1)1).ToString() : = Grey
            Console.WriteLine("((Shade1)).ToString() : = {0:D}", shade.ToString());//((Shade1)1).ToString() : = 1
            Console.WriteLine("((Shade1)).ToString() : = {0:F}", shade.ToString());//((Shade1)1).ToString() : = Grey

            Console.WriteLine("((Shade1)).ToString() : = {0:G}", shade.ToString());//((Shade1)1).ToString() : = Grey
            Console.WriteLine("((Shade1)).ToString() : = {0:D}", shade.ToString());//((Shade1)1).ToString() : = 1
            Console.WriteLine("((Shade1)).ToString() : = {0:F}", shade.ToString());//((Shade1)1).ToString() : = Grey
        }
    }

}
