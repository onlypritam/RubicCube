using System;

namespace Rubic3
{
    public class RubicCube
    {
        public RubicCubeSide Front;
        public RubicCubeSide Right;
        public RubicCubeSide Back;
        public RubicCubeSide Left;
        public RubicCubeSide Up;
        public RubicCubeSide Down;

        int[] tmp = new int[3];

        public RubicCube(RubicCubeSide Side1, RubicCubeSide Side2, RubicCubeSide Side3, RubicCubeSide Side4, RubicCubeSide Side5, RubicCubeSide Side6)
        {
            Create(Side1, Side2, Side3, Side4, Side5, Side6);
        }

        public RubicCube(int side1, int side2, int side3, int side4, int side5, int side6)
        {
            RubicCubeSide Side1 = new RubicCubeSide(side1);
            RubicCubeSide Side2 = new RubicCubeSide(side2);
            RubicCubeSide Side3 = new RubicCubeSide(side3);
            RubicCubeSide Side4 = new RubicCubeSide(side4);
            RubicCubeSide Side5 = new RubicCubeSide(side5);
            RubicCubeSide Side6 = new RubicCubeSide(side6);

            Create(Side1, Side2, Side3, Side4, Side5, Side6);
        }

        public RubicCube()
        {
            RubicCubeSide Side1 = new RubicCubeSide(1);
            RubicCubeSide Side2 = new RubicCubeSide(2);
            RubicCubeSide Side3 = new RubicCubeSide(3);
            RubicCubeSide Side4 = new RubicCubeSide(4);
            RubicCubeSide Side5 = new RubicCubeSide(5);
            RubicCubeSide Side6 = new RubicCubeSide(6);

            Create(Side1, Side2, Side3, Side4, Side5, Side6);
        }

        public void Create(RubicCubeSide Side1, RubicCubeSide Side2, RubicCubeSide Side3, RubicCubeSide Side4, RubicCubeSide Side5, RubicCubeSide Side6)
        {
            this.Front = Side1;
            this.Right = Side2;
            this.Back = Side3;
            this.Left = Side4;
            this.Up = Side5;
            this.Down = Side6;
        }

        public enum turn
        {
	        U,
	        UU,
	        D,
	        DD,
	        R,
	        RR,
	        L,
	        LL	
	    };

        public void Turn(turn t)
        {
            if (t == turn.U)
            {
                this.U();
            }
            else if (t == turn.UU)
            {
                this.UU();
            }
		    else if (t == turn.D)
            {
                this.D();
            }
            else if (t == turn.DD)
            {
                this.DD();
            }
	    	else if (t == turn.R)
            {
                this.R();
            }
            else if (t == turn.RR)
            {
                this.RR();
            }
	    	else if (t == turn.L)
            {
                this.L();
            }
            else if (t == turn.LL)
            {
                this.LL();
            }
        }

        private void U()
        {
            this.Up.RotateRight();

            Array.Copy(Front.TopRow,tmp,3);
            Array.Copy(Right.TopRow, Front.TopRow, 3);
            Array.Copy(Back.TopRow, Right.TopRow,3) ;
            Array.Copy(Left.TopRow, Back.TopRow, 3);
            Array.Copy(tmp, Left.TopRow, 3);
        }

        private void UU()
        {
            this.Up.RotateLeft();

            Array.Copy(Front.TopRow, tmp, 3);
            Array.Copy(Left.TopRow, Front.TopRow, 3);
            Array.Copy(Back.TopRow, Left.TopRow, 3);
            Array.Copy(Right.TopRow, Back.TopRow,3);
            Array.Copy(tmp, Right.TopRow, 3);
        }

        private void D()
        {
            this.Down.RotateRight();

            Array.Copy(Front.BottomRow, tmp, 3);
            Array.Copy(Left.BottomRow, Front.BottomRow, 3);
            Array.Copy(Back.BottomRow, Left.BottomRow , 3);
            Array.Copy(Right.BottomRow, Back.BottomRow, 3);
            Array.Copy(tmp, Right.BottomRow, 3);
        }

        private void DD()
        {
            this.Down.RotateLeft();

            Array.Copy(Front.BottomRow, tmp, 3);
            Array.Copy(Right.BottomRow, Front.BottomRow, 3);
            Array.Copy(Back.BottomRow, Right.BottomRow, 3);
            Array.Copy(Left.BottomRow, Back.BottomRow, 3);
            Array.Copy(tmp, Left.BottomRow, 3);
        }

        private void L()
        {
            this.Left.RotateRight();

            tmp[0] = Front.TopRow[0];
            tmp[1] = Front.MiddleRow[0];
            tmp[2] = Front.BottomRow[0];

            Front.TopRow[0] = Up.TopRow[0];
            Front.MiddleRow[0] = Up.MiddleRow[0];
            Front.BottomRow[0] = Up.BottomRow[0];

            Up.TopRow[0] = Back.BottomRow[0];
            Up.MiddleRow[0] = Back.MiddleRow[0];
            Up.BottomRow[0] = Back.TopRow[0];

            Back.TopRow[0] = Down.BottomRow[0];
            Back.MiddleRow[0] = Down.MiddleRow[0];
            Back.BottomRow[0] = Down.TopRow[0];

            Down.TopRow[0] = tmp[0];
            Down.MiddleRow[0] = tmp[1];
            Down.BottomRow[0] = tmp[2];
        }

        private void LL()
        {
            this.Left.RotateLeft();

            tmp[0] = Front.TopRow[0];
            tmp[1] = Front.MiddleRow[0];
            tmp[2] = Front.BottomRow[0];

            Front.TopRow[0] = Down.TopRow[0];
            Front.MiddleRow[0] = Down.MiddleRow[0];
            Front.BottomRow[0] = Down.BottomRow[0];

            Down.TopRow[0] = Back.BottomRow[0];
            Down.MiddleRow[0] = Back.MiddleRow[0];
            Down.BottomRow[0] = Back.TopRow[0];

            Back.TopRow[0] = Up.BottomRow[0];
            Back.MiddleRow[0] = Up.MiddleRow[0];
            Back.BottomRow[0] = Up.TopRow[0];

            Up.TopRow[0] = tmp[0];
            Up.MiddleRow[0] = tmp[1];
            Up.BottomRow[0] = tmp[2];
        }

        private void R()
        {
            this.Right.RotateRight();

            tmp[0] = Front.TopRow[2];
            tmp[1] = Front.MiddleRow[2];
            tmp[2] = Front.BottomRow[2];

            Front.TopRow[2] = Down.TopRow[2];
            Front.MiddleRow[2] = Down.MiddleRow[2];
            Front.BottomRow[2] = Down.BottomRow[2];

            Down.TopRow[2] = Back.BottomRow[2];
            Down.MiddleRow[2] = Back.MiddleRow[2];
            Down.BottomRow[2] = Back.TopRow[2];

            Back.TopRow[2] = Up.BottomRow[2];
            Back.MiddleRow[2] = Up.MiddleRow[2];
            Back.BottomRow[2] = Up.TopRow[2];

            Up.TopRow[2] = tmp[0];
            Up.MiddleRow[2] = tmp[1];
            Up.BottomRow[2] = tmp[2];
        }

        private void RR()
        {
            this.Right.RotateLeft();

            tmp[0] = Front.TopRow[2];
            tmp[1] = Front.MiddleRow[2];
            tmp[2] = Front.BottomRow[2];

            Front.TopRow[2] = Up.TopRow[2];
            Front.MiddleRow[2] = Up.MiddleRow[2];
            Front.BottomRow[2] = Up.BottomRow[2];

            Up.TopRow[2] = Back.BottomRow[2];
            Up.MiddleRow[2] = Back.MiddleRow[2];
            Up.BottomRow[2] = Back.TopRow[2];

            Back.TopRow[2] = Down.BottomRow[2];
            Back.MiddleRow[2] = Down.MiddleRow[2];
            Back.BottomRow[2] = Down.TopRow[2];

            Down.TopRow[2] = tmp[0];
            Down.MiddleRow[2] = tmp[1];
            Down.BottomRow[2] = tmp[2];
        }
    }
}
//test for git
