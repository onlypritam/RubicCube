using System;

namespace Rubic3
{
    public class RubicCubeSide
    {
        public int[] TopRow = new int[3];
        public int[] MiddleRow = new int[3];
        public int[] BottomRow = new int[3];

        private int[] TopRow_Temp = new int[3];
        private int[] MiddleRow_Temp = new int[3];
        private int[] BottomRow_Temp = new int[3];

        public RubicCubeSide(int fill)
        {
            Fill(fill, fill, fill, fill, fill, fill, fill, fill, fill);
        }

        public RubicCubeSide(int topLeft, int topMiddle, int topRight, int middleLeft, int middleMiddle, int middleRight, int bottomLeft, int bottomMiddle, int buttomRight)
        {
            Fill(topLeft, topMiddle, topRight, middleLeft, middleMiddle, middleRight, bottomLeft, bottomMiddle, buttomRight);
        }

        public void Fill(int topLeft, int topMiddle, int topRight, int middleLeft, int middleMiddle, int middleRight, int bottomLeft, int bottomMiddle, int buttomRight)
        {
            TopRow[0] = topLeft;
            TopRow[1] = topMiddle;
            TopRow[2] = topRight;

            MiddleRow[0] = middleLeft;
            MiddleRow[1] = middleMiddle;
            MiddleRow[2] = middleRight;

            BottomRow[0] = bottomLeft;
            BottomRow[1] = bottomMiddle;
            BottomRow[2] = buttomRight;
        }

        public void RotateRight()
        {
            Array.Copy(TopRow, TopRow_Temp, 3);
            Array.Copy(MiddleRow, MiddleRow_Temp, 3);
            Array.Copy(BottomRow, BottomRow_Temp, 3);

            TopRow[0] = BottomRow_Temp[0];
            TopRow[1] = MiddleRow_Temp[0];
            TopRow[2] = TopRow_Temp[0];

            MiddleRow[0] = BottomRow_Temp[1];
            MiddleRow[1] = MiddleRow_Temp[1];
            MiddleRow[2] = TopRow_Temp[1];

            BottomRow[0] = BottomRow_Temp[2];
            BottomRow[1] = MiddleRow_Temp[2];
            BottomRow[2] = TopRow_Temp[2];
        }


        public void RotateLeft()
        {
            Array.Copy(TopRow, TopRow_Temp, 3);
            Array.Copy(MiddleRow, MiddleRow_Temp, 3);
            Array.Copy(BottomRow, BottomRow_Temp, 3);

            TopRow[0] = TopRow_Temp[2];
            TopRow[1] = MiddleRow_Temp[2];
            TopRow[2] = BottomRow_Temp[2];

            MiddleRow[0] = TopRow_Temp[1];
            MiddleRow[1] = MiddleRow_Temp[1];
            MiddleRow[2] = BottomRow_Temp[1];

            BottomRow[0] = TopRow_Temp[0];
            BottomRow[1] = MiddleRow_Temp[0];
            BottomRow[2] = BottomRow_Temp[0];
        }
    }
}
