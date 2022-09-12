namespace Assignment4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MatrixWriter();
            //ArrayAdder();
            //MathMenu();
            CircleThing();

        }
        private static void ArrayAdder()
        {
            int[,] arrayOne = new int[2, 2];
            Console.WriteLine("Enter Values for first array:");
            Console.WriteLine("Enter value for space 0, 0 ");
            arrayOne[0, 0] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter value for space 0, 1 ");
            arrayOne[0, 1] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter value for space 1, 0 ");
            arrayOne[1, 0] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter value for space 1, 1 ");
            arrayOne[1, 1] = Convert.ToInt32(Console.ReadLine());



            int[,] arrayTwo = new int[2, 2];
            Console.WriteLine("Enter Values for second array:");
            Console.WriteLine("Enter value for space 0, 0 ");
            arrayTwo[0, 0] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter value for space 0, 1 ");
            arrayTwo[0, 1] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter value for space 1, 0 ");
            arrayTwo[1, 0] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter value for space 1, 1 ");
            arrayTwo[1, 1] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Array One:");
            Console.WriteLine($"|{arrayOne[0, 0]}|{arrayOne[0, 1]}|");
            Console.WriteLine($"|{arrayOne[1, 0]}|{arrayOne[1, 1]}|");

            Console.WriteLine("Array Two:");
            Console.WriteLine($"|{arrayTwo[0, 0]}|{arrayTwo[0, 1]}|");
            Console.WriteLine($"|{arrayTwo[1, 0]}|{arrayTwo[1, 1]}|");

            int sum1 = arrayOne[0, 0] + arrayTwo[0, 0];
            int sum2 = arrayOne[0, 1] + arrayTwo[0, 1];
            int sum3 = arrayOne[1, 0] + arrayTwo[1, 0];
            int sum4 = arrayOne[1, 1] + arrayTwo[1, 1];

            Console.WriteLine("Sum of first and second array:");
            int[,] arraySum = new int[2, 2] { { sum1, sum2 }, { sum3, sum4 } };
            Console.WriteLine($"|{arraySum[0, 0]}|{arraySum[0, 1]}|");
            Console.WriteLine($"|{arraySum[1, 0]}|{arraySum[1, 1]}|");

        }



        private static void MatrixWriter()
        {
            int[,] myArray = new int[2, 3];
            Console.WriteLine("Enter value for space 0, 0 ");
            myArray[0, 0] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter value for space 0, 1 ");
            myArray[0, 1] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter value for space 0, 2 ");
            myArray[0, 2] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter value for space 1, 0 ");
            myArray[1, 0] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter value for space 1, 1 ");
            myArray[1, 1] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter value for space 1, 2 ");
            myArray[1, 2] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"|{myArray[0, 0]}|{myArray[0, 1]}|{myArray[0, 2]}|");
            Console.WriteLine($"|{myArray[1, 0]}|{myArray[1, 1]}|{myArray[1, 2]}|");
        }

        private static int AddNums(int x, int y)
        {
            return x + y;
        }
        private static int AddNums(int x, int y, int z)
        {
            return x + y + z;
        }
        private static float ProdNums(float a, float b)
        {
            return a * b;
        }
        private static float ProdNums(float a, float b, float c)
        {
            return a * b * c;
        }

        private static void MathMenu()
        {
            Console.WriteLine("Enter the number of the function you want to perform:");
            Console.WriteLine("1 - Sum x + y");
            Console.WriteLine("2 - Sum x + y + z");
            Console.WriteLine("3 - Product a * b");
            Console.WriteLine("4 - Product a * b * c");
            
            try
            {
                int select = Convert.ToInt32(Console.ReadLine());
                switch (select)
                {
                    case 1:
                        {
                            Console.WriteLine("Enter first addend:");
                            int add1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter second addend:");
                            int add2 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(AddNums(add1, add2));
                            MathMenu();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter first addend:");
                            int add1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter second addend:");
                            int add2 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter third addend:");
                            int add3 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(AddNums(add1, add2, add3));
                            MathMenu();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Enter first factor:");
                            int fac1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter second factor:");
                            int fac2 = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine(ProdNums(fac1, fac2));
                            MathMenu();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Enter first factor:");
                            int fac1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter second factor:");
                            int fac2 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter third factor:");
                            int fac3 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(ProdNums(fac1, fac2, fac3));
                            MathMenu();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Please select a number from the menu");
                            MathMenu();
                            break;
                        }
                }
            }
            catch (FormatException)
            {
                string message = "Please select a number from the table";
                Console.WriteLine(message);
                MathMenu();                
            }
            
        }

        private static void CircleThing()
        {
            Console.WriteLine("Enter First circle radius");
            double radOne = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Second circle radius");
            double radTwo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("The sum of the area of the two circles is:");
            Console.WriteLine(CircleAdd(CircleArea(radOne), CircleArea(radTwo)));
            Console.WriteLine("The difference of the area of the two circles is:");
            Console.WriteLine(CircleSub(CircleArea(radOne), CircleArea(radTwo)));
            CircleThing();


            static double CircleArea(double radius)
            {
                return Math.PI * radius * radius;
            }
            static double CircleAdd(double areaOne, double areaTwo)
            {
                return Math.Round(areaOne + areaTwo, 2);
            }
            static double CircleSub(double areaOne, double areaTwo)
            {
                if (areaOne < areaTwo)
                {
                    return Math.Round(areaTwo - areaOne, 2);
                }
                else
                {
                    return Math.Round(areaOne - areaTwo, 2);
                }
            }



        }
        
    }












}
