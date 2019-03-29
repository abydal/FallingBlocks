using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FallingBlocks {
    partial class Brick {
        public int points = 0;
        public int[, ] shape;
        public int[, ] nextShape;
        public bool first = true;
        public bool end = false;
        Random r = new Random ();
        public int fargeVar;
        int wall = 0; //teller roteringer som er utført langs veggen 

        public int[, ] brett; //tabell over brettet [10,20]

        int brickx, bricky;

        public Brick (int[, ] b) {
            brett = b;
            Reset ();
        }

        public Brick () { }

        public void Undraw () {
            for (int y = 0; y < 4; y++) {
                for (int x = 0; x < 4; x++) {
                    if (brickx + x < 10 && bricky + y < 20 && brickx + x > -1 && bricky + y > -1) {
                        if (shape[y, x] > 0)
                            brett[brickx + x, bricky + y] = 0; //blokka blir tegnet over av bakgrunnsfarge
                    }
                }
            }
        }

        public void Draw () {
            for (int y = 0; y < 4; y++) {
                for (int x = 0; x < 4; x++) {
                    if (brickx + x < 10 && bricky + y < 20 && brickx + x > -1 && bricky + y > -1) {
                        if (shape[y, x] != 0)
                            brett[brickx + x, bricky + y] = shape[y, x]; //blokka tegnes
                    }
                }
            }
        }

        public bool CanMoveDown (int addy) {
            int temp;

            if (bricky + BrickSize (Direction.Y, shape) == 19)
                return false;

            for (int y = 0; y < 4; y++) {
                for (int x = 0; x < 4; x++) {
                    if (bricky + y + addy < 20) {
                        temp = x;

                        while (x + brickx > 9)
                            x--;

                        while (x + brickx < 0)
                            x++;

                        if (shape[y, x] != 0 && brett[brickx + x, bricky + y + addy] != 0)
                            return false;

                        x = temp;
                    }
                }
            }

            return true;
        }

        public bool CanMoveLeft (int addx, int[, ] b) {
            int temp;

            if (brickx == -3)
                return false;

            if (BrickSize (Direction.X_Inverted, b) == 0 && brickx == 0)
                return false;

            if (BrickSize (Direction.X_Inverted, b) == 1 && brickx == -1)
                return false;

            if (BrickSize (Direction.X_Inverted, b) == 3 && brickx == -2)
                return false;

            for (int y = 0; y < 4; y++) {
                for (int x = 0; x < 4; x++) {
                    if (brickx + x - addx < 10 && bricky + y < 20) {
                        temp = x;

                        while (x + brickx - addx > 9)
                            x--;

                        while (x + brickx - addx < 0)
                            x++;

                        if (bricky == -1 && y == 0)
                            y++;

                        if (b[y, x] != 0 && brett[brickx + x - addx, bricky + y] != 0) //tester etter klosser på venstre side
                            return false;

                        x = temp;
                    }
                }
            }

            return true;

        }

        public bool CanMoveRight (int addx, int[, ] b) {
            int temp;

            if (brickx + BrickSize (Direction.X, b) >= 9)
                return false;

            for (int y = 0; y < 4; y++) {
                for (int x = 0; x < 4; x++) {
                    if (brickx + x + addx < 10 && bricky + y < 20) {
                        temp = x;

                        while (x + brickx + addx > 9)
                            x--;

                        while (x + brickx + addx < 0)
                            x++;

                        if (bricky == -1 && y == 0)
                            y++;

                        if (b[y, x] != 0 && brett[brickx + x + addx, bricky + y] != 0)
                            return false;

                        x = temp;
                    }

                }
            }
            return true;
        }

        public void MoveDown () {
            Undraw ();

            if (CanMoveDown (1)) {
                bricky++;
                Draw ();
            } else {
                Draw ();
                Reset ();
            }
        }

        public void MoveLeft () {
            wall = 0;
            Undraw ();

            if (CanMoveLeft (1, shape)) {
                brickx--;
                Draw ();
            } else {
                Draw ();
            }
        }

        public void MoveRight () {
            wall = 0;
            Undraw ();

            if (CanMoveRight (1, shape)) {
                brickx++;
                Draw ();
            } else {
                Draw ();
            }
        }

        public void Reset () {
            fargeVar = r.Next (1, 5);
            bricky = -1;
            brickx = 3;
            shape = nextShape;

            if (first == true) {
                switch (r.Next (1, 8)) {
                    case 1:
                        shape = Shapes.hook;
                        break;
                    case 2:
                        shape = Shapes.lbar;
                        break;
                    case 3:
                        shape = Shapes.bar;
                        break;
                    case 4:
                        shape = Shapes.square;
                        break;
                    case 5:
                        shape = Shapes.pyramid;
                        break;
                    case 6:
                        shape = Shapes.hookInv;
                        break;
                    case 7:
                        shape = Shapes.lbarInv;
                        break;
                }
                for (int x = 0; x < 4; x++) {
                    for (int y = 0; y < 4; y++) {
                        shape[x, y] = shape[x, y] * fargeVar;
                    }
                }
                first = false;
            }

            switch (r.Next (1, 8)) {
                case 1:
                    nextShape = Shapes.hook;
                    break;
                case 2:
                    nextShape = Shapes.lbar;
                    break;
                case 3:
                    nextShape = Shapes.bar;
                    break;
                case 4:
                    nextShape = Shapes.square;
                    break;
                case 5:
                    nextShape = Shapes.pyramid;
                    break;
                case 6:
                    nextShape = Shapes.hookInv;
                    break;
                case 7:
                    nextShape = Shapes.lbarInv;
                    break;
            }
            for (int x = 0; x < 4; x++) {
                for (int y = 0; y < 4; y++) {
                    if (nextShape[x, y] < 2)
                        nextShape[x, y] = nextShape[x, y] * fargeVar;
                }
            }
            points += Points (brett);

            for (int x = 0; x < 10; x++) {
                if (brett[x, 0] != 0)
                    end = true;
            }
        }
        int BrickSize (Direction direction, int[, ] t) {
            int result = 0;
            switch (direction) {
                case Direction.X:
                    for (int x = 0; x < 4; x++) {
                        for (int y = 0; y < 4; y++) {
                            if (t[y, x] != 0 && result < x)
                                result = x;
                        }
                    }
                    break;

                case Direction.Y:
                    for (int x = 0; x < 4; x++) {
                        for (int y = 0; y < 4; y++) {
                            if (t[y, x] != 0 && result < y)
                                result = y;
                        }
                    }
                    break;

                case Direction.X_Inverted:
                    result = 3;
                    for (int x = 3; x > -1; x--) {
                        for (int y = 3; y > -1; y--) {
                            if (t[y, x] != 0 && result > x)
                                result = x;
                        }
                    }
                    break;
            }
            return result;
        }

        public int Points (int[, ] b) {
            int score = 0;
            int rowPoints = 0;

            for (int y = 0; y < 20; y++) {
                rowPoints = 0;
                for (int x = 0; x < 10; x++) {
                    if (b[x, y] != 0)
                        rowPoints++;

                    if (rowPoints == 10) {
                        score++;
                        for (int t = y; y > 0; y--) {
                            for (int i = 0; i < 10; i++) {
                                b[i, y] = b[i, y - 1];
                            }
                        }
                    }
                }
            }
            return score;
        }

        public int[, ] Rotate (int[, ] b) {
            int[, ] temp = new int[4, 4];
            for (int i = 0; i < 4; i++) {
                temp[3, i] = b[i, 0];
                temp[0, i] = b[i, 3];
                temp[i, 3] = b[3, 3 - i];
                temp[i, 0] = b[0, 3 - i];

            }
            temp[1, 1] = b[1, 2];
            temp[1, 2] = b[2, 2];
            temp[2, 1] = b[1, 1];
            temp[2, 2] = b[2, 1];

            Undraw ();

            for (int y = 0; y < 4; y++) {
                for (int x = 0; x < 4; x++) {
                    if (wall == -1)
                        brickx++;

                    if (wall == 1)
                        brickx--;

                    wall = 0;

                    if (brickx + x > -1 && brickx + x < 10) {
                        if (bricky + y > 19)
                            return b;

                        if (temp[y, x] != 0 && brett[brickx + x, bricky + y] != 0)
                            return b;
                    } else if (CanMoveRight (1, temp) == true && BrickSize (Direction.X_Inverted, temp) == 0) {
                        if (temp[x, y] != 0 && brett[brickx + 1 + x, bricky + y] != 0)
                            return b;

                        brickx++;
                        wall++;
                        return temp;
                    } else if (CanMoveLeft (1, temp) == true && BrickSize (Direction.X, temp) == 3) {
                        if (temp[x, y] != 0 && brett[brickx - 1 + x, bricky + y] != 0)
                            return b;

                        brickx--;
                        wall--;
                        return temp;
                    }
                }
            }
            return temp;
        }
    }
}