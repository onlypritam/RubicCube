using System;
using Rubic3;
using static Rubic3.RubicCube;

namespace RubicCube_Manual_Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            //test6RightAlgs();
            testRubicCube();
        }

        private static void testRubicCube()
        {
            string input;
            RubicCubeSide Side1 = new RubicCubeSide(11, 12, 13, 14, 15, 16, 17, 18, 19);
            RubicCubeSide Side2 = new RubicCubeSide(21, 22, 23, 24, 25, 26, 27, 28, 29);
            RubicCubeSide Side3 = new RubicCubeSide(31, 32, 33, 34, 35, 36, 37, 38, 39);
            RubicCubeSide Side4 = new RubicCubeSide(41, 42, 43, 44, 45, 46, 47, 48, 49);
            RubicCubeSide Side5 = new RubicCubeSide(51, 52, 53, 54, 55, 56, 57, 58, 59);
            RubicCubeSide Side6 = new RubicCubeSide(61, 62, 63, 64, 65, 66, 67, 68, 69);

            RubicCube RC = new RubicCube(Side1, Side2, Side3, Side4, Side5, Side6);
            PrintRubicCube(RC);
            Console.WriteLine("Type U, UU, D, DD, L, LL, R, RR and X to exit: ");
            input = Console.ReadLine();


            while (input != "X")
            {
                if (input == "U")
                {
                    RC.Turn(turn.U);
                }
                else if (input == "UU")
                {
                    RC.Turn(turn.UU);
                }
                else if (input == "D")
                {
                    RC.Turn(turn.D);
                }
                else if (input == "DD")
                {
                    RC.Turn(turn.DD);
                }
                else if (input == "L")
                {
                    RC.Turn(turn.L);
                }
                else if (input == "LL")
                {
                    RC.Turn(turn.LL);
                }
                else if (input == "R")
                {
                    RC.Turn(turn.R);
                }
                else if (input == "RR")
                {
                    RC.Turn(turn.RR);
                }

                PrintRubicCube(RC);
                Console.WriteLine("Type U, UU, D, DD, L, LL, R, RR and X to exit: ");
                input = Console.ReadLine();
            }
        }


        private static void test6RightAlgs()
        {
            string input;
            RubicCubeSide Side1 = new RubicCubeSide(11, 12, 13, 14, 15, 16, 17, 18, 19);
            RubicCubeSide Side2 = new RubicCubeSide(21, 22, 23, 24, 25, 26, 27, 28, 29);
            RubicCubeSide Side3 = new RubicCubeSide(31, 32, 33, 34, 35, 36, 37, 38, 39);
            RubicCubeSide Side4 = new RubicCubeSide(41, 42, 43, 44, 45, 46, 47, 48, 49);
            RubicCubeSide Side5 = new RubicCubeSide(51, 52, 53, 54, 55, 56, 57, 58, 59);
            RubicCubeSide Side6 = new RubicCubeSide(61, 62, 63, 64, 65, 66, 67, 68, 69);

            RubicCube RC = new RubicCube(Side1, Side2, Side3, Side4, Side5, Side6);
            PrintRubicCube(RC);
            Console.WriteLine("Doing 6 Right Algs");
            Console.ReadLine();

            RC.RightAlg();
            RC.RightAlg();
            RC.RightAlg();
            RC.RightAlg();
            RC.RightAlg();
            RC.RightAlg();

            PrintRubicCube(RC);
            Console.ReadLine();
        }


        private static void PrintRubicCube(RubicCube rc)
        {
            ////----------------------UP------------------------------
            Console.Write("        ");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("|" + rc.Up.TopRow[i]);
            }
            Console.WriteLine("|");

            Console.Write("        ");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("|" + rc.Up.MiddleRow[i]);
            }
            Console.WriteLine("|");

            Console.Write("        ");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("|" + rc.Up.BottomRow[i]);
            }
            Console.WriteLine("|");

            //----------------------SIDES-------------------------------
            for (int i = 0; i < 3; i++)
            {
                Console.Write("|" + rc.Left.TopRow[i]);
            }
            Console.Write("| ");

            for (int i = 0; i < 3; i++)
            {
                Console.Write("|" + rc.Front.TopRow[i]);
            }
            Console.Write("| ");

            for (int i = 0; i < 3; i++)
            {
                Console.Write("|" + rc.Right.TopRow[i]);
            }
            Console.Write("| ");

            for (int i = 0; i < 3; i++)
            {
                Console.Write("|" + rc.Back.TopRow[i]);
            }
            Console.WriteLine("|");
            //-------------------------------------------------------------------

            for (int i = 0; i < 3; i++)
            {
                Console.Write("|" + rc.Left.MiddleRow[i]);
            }
            Console.Write("| ");

            for (int i = 0; i < 3; i++)
            {
                Console.Write("|" + rc.Front.MiddleRow[i]);
            }
            Console.Write("| ");

            for (int i = 0; i < 3; i++)
            {
                Console.Write("|" + rc.Right.MiddleRow[i]);
            }
            Console.Write("| ");

            for (int i = 0; i < 3; i++)
            {
                Console.Write("|" + rc.Back.MiddleRow[i]);
            }
            Console.WriteLine("|");
            //--------------------------------------------------------
            for (int i = 0; i < 3; i++)
            {
                Console.Write("|" + rc.Left.BottomRow[i]);
            }
            Console.Write("| ");

            for (int i = 0; i < 3; i++)
            {
                Console.Write("|" + rc.Front.BottomRow[i]);
            }
            Console.Write("| ");

            for (int i = 0; i < 3; i++)
            {
                Console.Write("|" + rc.Right.BottomRow[i]);
            }
            Console.Write("| ");

            for (int i = 0; i < 3; i++)
            {
                Console.Write("|" + rc.Back.BottomRow[i]);
            }
            Console.WriteLine("|");

            //-----------------------DOWN------------------------------
            Console.Write("        ");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("|" + rc.Down.TopRow[i]);
            }
            Console.WriteLine("|");

            Console.Write("        ");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("|" + rc.Down.MiddleRow[i]);
            }
            Console.WriteLine("|");

            Console.Write("        ");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("|" + rc.Down.BottomRow[i]);
            }
            Console.WriteLine("|");
        }

        private void testRubicCubeSide()
        {
            string input;
            RubicCubeSide RCS = new RubicCubeSide(1, 2, 3, 4, 5, 6, 7, 8, 9);
            PrintRubicCubeSide(RCS);
            Console.WriteLine("Type R to rotate right or L to rotate left and X to exit: ");
            input = Console.ReadLine();


            while (input != "X")
            {
                if (input == "R")
                {
                    RCS.RotateRight();
                    PrintRubicCubeSide(RCS);
                }
                else if (input == "L")
                {
                    RCS.RotateLeft();
                    PrintRubicCubeSide(RCS);
                }

                Console.WriteLine("Type R to rotate right or L to rotate left and X to exit: ");
                input = Console.ReadLine();
            }
        }

        private static void PrintRubicCubeSide(RubicCubeSide r)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write("|" + r.TopRow[i]);
            }
            Console.WriteLine("|");

            for (int i = 0; i < 3; i++)
            {
                Console.Write("|" + r.MiddleRow[i]);
            }
            Console.WriteLine("|");

            for (int i = 0; i < 3; i++)
            {
                Console.Write("|" + r.BottomRow[i]);
            }
            Console.WriteLine("|");
        }

    }
}
