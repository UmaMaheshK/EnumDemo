using System;

namespace EnumDemo
{
    class Program
    {
        enum WeekDays { SUNDAY, MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY };

        static void Main(string[] args)
        {
            Console.WriteLine();
            EnumExp1();
            Console.WriteLine();
            EnumExp2();
            Console.WriteLine();
            EnumExp3();
            Console.WriteLine();
            EnumExp4();
            Console.WriteLine();
            EnumExp5();
            Console.WriteLine();
            EnumExp6();
            Console.WriteLine();
            EnumExp7();
            Console.WriteLine();
            EnumExp8();
            Console.WriteLine();
            EnumExp9();
            Console.WriteLine();
            EnumExp10();
            Console.WriteLine();
            EnumExp11();
            Console.WriteLine();
            EnumExp12();
            Console.WriteLine();
            EnumExp13();
            Console.WriteLine();
            EnumExp14();
        }

        private static void EnumExp1()
        {
            WeekDays day = WeekDays.MONDAY;

            //Get Day name
            Console.WriteLine("Day name {0}", day);//MONDAY

            //Get Day value of name
            Console.WriteLine("Day value {0}", (int)day);//1
        }

        private static void EnumExp2()
        {
            //Get day value
            int dayValue = (int)WeekDays.WEDNESDAY;
            //Get Day name

            //G or g is Format type used to displaying enum names
            string dayName = string.Format("{0:G}", WeekDays.WEDNESDAY);//WEDNESDAY

            //D or d is Format type used to displaying enum name's value
            string strDayValue = string.Format("{0:D}", WeekDays.WEDNESDAY);//3
            Console.WriteLine("Day value {0}", dayValue);//3
        }

        private static void EnumExp3()
        {
            //Get all enum names
            string[] dayNames = System.Enum.GetNames(typeof(WeekDays));
            Array.ForEach(dayNames, Console.WriteLine);
            /*
                OUTPUT

                SUNDAY
                MONDAY
                TUESDAY
                WEDNESDAY
                THURSDAY
                FRIDAY
                SATURDAY                
            */
        }

        private static void EnumExp4()
        {
            //Get all values of enum
            Console.WriteLine("----Values are ---------");
            int[] values = (int[])System.Enum.GetValues(typeof(WeekDays));
            Array.ForEach(values, Console.WriteLine);
            foreach (int item in System.Enum.GetValues(typeof(WeekDays)))
                Console.WriteLine(item);

            /* OUTPUT 
                0
                1
                2
                3
                4
                5
                6            
            */
        }

        private static void EnumExp5()
        {
            WeekDays days = new WeekDays();//Default Constructor of WeekDays
            Console.WriteLine("Default Constructor:= {0}", days);//MONDAY
        }

        private static void EnumExp6()
        {
            //Convert value to Enum
            WeekDays days = (WeekDays)6;//6 is SATURDAY
            Console.WriteLine("Default Constructor:= {0}", days);//MONDAY
        }

        private static void EnumExp7()
        {
            //Cannot assign null value to Enum
            //WeekDays days = null;
        }

        private static void EnumExp8()
        {
            //Get Enum name from value by using Enum.GetName()
            string dayName = Enum.GetName(typeof(WeekDays), 5);
            Console.WriteLine("Using Enum.GetName(): = {0}", dayName);//FRIDAY

            //Note : value should be UnderlyingType(int) so value should be integer value.
            string dayName1 = Enum.GetName(typeof(WeekDays), 12);//
            Console.WriteLine("Using Enum.GetName(): = {0}", dayName);//NULL
        }

        private static void EnumExp9()
        {
            //Enum.GetUnderlyingType()
            //Default type of Enum is int type
            Console.WriteLine("Default type of WeakDays enum := {0}", Enum.GetUnderlyingType(typeof(WeekDays)));

            //OUTPUT : Sysem.Int32
        }

        //Create new Enum with Byte data type
        enum Color : byte { BLUE = 12, GREEN, RED, YELLOW }
        private static void EnumExp10()
        {
            //Get type of Enum is int type
            Console.WriteLine("Get type of Color enum := {0}", Enum.GetUnderlyingType(typeof(Color)));//System.Byte
        }

        private static void EnumExp11()
        {
            //After changed BLUE value to 12 
            byte[] colorValues = (byte[])Enum.GetValues(typeof(Color));
            Array.ForEach(colorValues, e => { Console.WriteLine(e); });
            /*
                OUTPUT
                12
                13
                14
                15
            */
        }

        private static void EnumExp12()
        {
            Color col = Color.GREEN;
            //using Enum.Format()
            Console.WriteLine("Using Enum.Format() with format type(G) := {0}", Enum.Format(typeof(Color), col, "g"));//FRIDAY
            Console.WriteLine("Using Enum.Format() with format type(G) := {0}", Enum.Format(typeof(Color), col, "G"));//FRIDAY
            Console.WriteLine("Using Enum.Format() with format type(D) := {0}", Enum.Format(typeof(Color), col, "D"));//13
            Console.WriteLine("Using Enum.Format() with format type(d) := {0}", Enum.Format(typeof(Color), col, "d"));//13
        }

        private static void EnumExp13()
        {
            Color col = Color.GREEN | Color.BLUE;
            Console.WriteLine(col);//GREEN
            Console.WriteLine("{0:G} : {0:D}", col);//GREEN : 13
            Console.WriteLine(Enum.IsDefined(typeof(Color), col));//True

            object value = Color.GREEN | Color.BLUE;
            Console.WriteLine(Enum.IsDefined(typeof(Color), value));//True
            value = value.ToString();
            Console.WriteLine("{0:D} : {0}", value, Enum.IsDefined(typeof(Color), value));//True

            //Check value 12 is exists in Color Enum
            byte b = 12;
            Console.WriteLine(Enum.IsDefined(typeof(Color), b));//True
            b = 10;
            Console.WriteLine(Enum.IsDefined(typeof(Color), b));//False

            //Check wheather contriant name is exists or not 
            string name = "BLUE";
            Console.WriteLine(Enum.IsDefined(typeof(Color), name));//True
            name = "blue";
            Console.WriteLine(Enum.IsDefined(typeof(Color), name));//False
        }
        [Flags]
        public enum PetType
        {
            None = 0, Dog = 1, Cat = 2, Rodent = 4, Bird = 8, Reptile = 16, Other = 32
        };

        private static void EnumExp14()
        {
            object value;

            // Call IsDefined with underlying integral value of member.
            value = 1;
            Console.WriteLine("{0}: {1}", value, Enum.IsDefined(typeof(PetType), value));
            // Call IsDefined with invalid underlying integral value.
            value = 64;
            Console.WriteLine("{0}: {1}", value, Enum.IsDefined(typeof(PetType), value));
            // Call IsDefined with string containing member name.
            value = "Rodent";
            Console.WriteLine("{0}: {1}", value, Enum.IsDefined(typeof(PetType), value));
            // Call IsDefined with a variable of type PetType.
            value = PetType.Dog;
            Console.WriteLine("{0}: {1}", value, Enum.IsDefined(typeof(PetType), value));
            value = PetType.Dog | PetType.Cat;
            Console.WriteLine("{0}: {1}", value, Enum.IsDefined(typeof(PetType), value));
            // Call IsDefined with uppercase member name.      
            value = "None";
            Console.WriteLine("{0}: {1}", value, Enum.IsDefined(typeof(PetType), value));
            value = "NONE";
            Console.WriteLine("{0}: {1}", value, Enum.IsDefined(typeof(PetType), value));
            // Call IsDefined with combined value
            value = PetType.Dog | PetType.Bird;
            Console.WriteLine("{0:D}: {1}", value, Enum.IsDefined(typeof(PetType), value));
            value = value.ToString();
            Console.WriteLine("{0:D}: {1}", value, Enum.IsDefined(typeof(PetType), value));

            // The example displays the following output:
            //       1: True
            //       64: False
            //       Rodent: True
            //       Dog: True
            //       Dog, Cat: False
            //       None: True
            //       NONE: False
            //       9: False
            //       Dog, Bird: False
        }
        [Flags] enum Colors { None = 0, Red = 1, Green = 2, Blue = 4 };

        private static void EnumExp15()
        {
            string[] colorStrings = { "0", "2", "8", "blue", "Blue", "Yellow", "Red, Green" };
            foreach (string colorString in colorStrings)
            {
                Colors colorValue;
                if (Enum.TryParse(colorString, true, out colorValue))
                    if (Enum.IsDefined(typeof(Colors), colorValue) | colorValue.ToString().Contains(","))
                        Console.WriteLine("Converted '{0}' to {1}.", colorString, colorValue.ToString());
                    else
                        Console.WriteLine("{0} is not an underlying value of the Colors enumeration.", colorString);
                else
                    Console.WriteLine("{0} is not a member of the Colors enumeration.", colorString);
            }
            // The example displays the following output:
            //       Converted '0' to None.
            //       Converted '2' to Green.
            //       8 is not an underlying value of the Colors enumeration.
            //       Converted 'blue' to Blue.
            //       Converted 'Blue' to Blue.
            //       Yellow is not a member of the Colors enumeration.
            //       Converted 'Red, Green' to Red, Green.

        }
        private static void EnumExp16()
        {
            string[] colorStrings = { "0", "2", "8", "blue", "Blue", "Yellow", "Red, Green" };
            foreach (string colorString in colorStrings)
            {
                Colors colorValue;
                if (Enum.TryParse(colorString, out colorValue))
                    if (Enum.IsDefined(typeof(Colors), colorValue) | colorValue.ToString().Contains(","))
                        Console.WriteLine("Converted '{0}' to {1}.", colorString, colorValue.ToString());
                    else
                        Console.WriteLine("{0} is not an underlying value of the Colors enumeration.", colorString);
                else
                    Console.WriteLine("{0} is not a member of the Colors enumeration.", colorString);
            }
            // The example displays the following output:
            //       Converted '0' to None.
            //       Converted '2' to Green.
            //       8 is not an underlying value of the Colors enumeration.
            //       blue is not a member of the Colors enumeration.
            //       Converted 'Blue' to Blue.
            //       Yellow is not a member of the Colors enumeration.
            //       Converted 'Red, Green' to Red, Green.
        }
    }
}