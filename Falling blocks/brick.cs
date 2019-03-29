using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Falling_blocks {
    class brick {
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

        int[, ] square = { { 0, 0, 0, 0 }, { 0, 1, 1, 0 }, { 0, 1, 1, 0 }, { 0, 0, 0, 0 } };
        int[, ] hook = { { 0, 1, 0, 0 }, { 0, 1, 1, 0 }, { 0, 0, 1, 0 }, { 0, 0, 0, 0 } };
        int[, ] pyramid = { { 0, 1, 0, 0 }, { 0, 1, 1, 0 }, { 0, 1, 0, 0 }, { 0, 0, 0, 0 } };
        int[, ] bar = { { 0, 0, 0, 0 }, { 1, 1, 1, 1 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 } };
        int[, ] lbar = { { 0, 1, 0, 0 }, { 0, 1, 0, 0 }, { 0, 1, 1, 0 }, { 0, 0, 0, 0 } };
        int[, ] lbarInv = { { 0, 0, 1, 0 }, { 0, 0, 1, 0 }, { 0, 1, 1, 0 }, { 0, 0, 0, 0 } };
        int[, ] hookInv = { { 0, 0, 1, 0 }, { 0, 1, 1, 0 }, { 0, 1, 0, 0 }, { 0, 0, 0, 0 } };

        public brick (int[, ] b) {
            brett = b;
            reset ();
        }

        public brick () { }

        public void undrawMe () {
            for (int y = 0; y < 4; y++) {
                for (int x = 0; x < 4; x++) {
                    if (brickx + x < 10 && bricky + y < 20 && brickx + x > -1 && bricky + y > -1) {
                        if (shape[y, x] > 0)
                            brett[brickx + x, bricky + y] = 0; //blokka blir tegnet over av bakgrunnsfarge
                    }
                }
            }
        }

        public void drawMe () {
            for (int y = 0; y < 4; y++) {
                for (int x = 0; x < 4; x++) {
                    if (brickx + x < 10 && bricky + y < 20 && brickx + x > -1 && bricky + y > -1) {
                        if (shape[y, x] != 0)
                            brett[brickx + x, bricky + y] = shape[y, x]; //blokka tegnes
                    }
                }
            }
        }

        public bool canMoveDown (int addy) {
            int temp;

            if (bricky + brickSize ("y", shape) == 19)
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

        public bool canMoveLeft (int addx, int[, ] b) {
            int temp;

            if (brickx == -3)
                return false;

            if (brickSize ("-x", b) == 0 && brickx == 0)
                return false;

            if (brickSize ("-x", b) == 1 && brickx == -1)
                return false;

            if (brickSize ("-x", b) == 3 && brickx == -2)
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

        public bool canMoveRight (int addx, int[, ] b) {
            int temp;

            if (brickx + brickSize ("x", b) >= 9)
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

        public void moveDown () {
            undrawMe ();

            if (canMoveDown (1)) {
                bricky++;
                drawMe ();
            } else {
                drawMe ();
                reset ();
            }
        }

        public void moveLeft () {
            wall = 0;
            undrawMe ();

            if (canMoveLeft (1, shape)) {
                brickx--;
                drawMe ();
            } else {
                drawMe ();
            }
        }

        public void moveRight () {
            wall = 0;
            undrawMe ();

            if (canMoveRight (1, shape)) {
                brickx++;
                drawMe ();
            } else {
                drawMe ();
            }
        }

        public void reset () {
            fargeVar = r.Next (1, 5);
            bricky = -1;
            brickx = 3;
            shape = nextShape;

            if (first == true) {
                switch (r.Next (1, 8)) {
                    case 1:
                        shape = hook;
                        first = false;
                        break;
                    case 2:
                        shape = lbar;
                        first = false;
                        break;
                    case 3:
                        shape = bar;
                        first = false;
                        break;
                    case 4:
                        shape = square;
                        first = false;
                        break;
                    case 5:
                        shape = pyramid;
                        first = false;
                        break;
                    case 6:
                        shape = hookInv;
                        first = false;
                        break;
                    case 7:
                        shape = lbarInv;
                        first = false;
                        break;
                }
                for (int x = 0; x < 4; x++) {
                    for (int y = 0; y < 4; y++) {
                        shape[x, y] = shape[x, y] * fargeVar;
                    }
                }
            }

            switch (r.Next (1, 8)) {
                case 1:
                    nextShape = hook;
                    break;
                case 2:
                    nextShape = lbar;
                    break;
                case 3:
                    nextShape = bar;
                    break;
                case 4:
                    nextShape = square;
                    break;
                case 5:
                    nextShape = pyramid;
                    break;
                case 6:
                    nextShape = hookInv;
                    break;
                case 7:
                    nextShape = lbarInv;
                    break;
            }
            for (int x = 0; x < 4; x++) {
                for (int y = 0; y < 4; y++) {
                    if (nextShape[x, y] < 2)
                        nextShape[x, y] = nextShape[x, y] * fargeVar;
                }
            }
            points += poeng (brett);

            for (int x = 0; x < 10; x++) {
                if (brett[x, 0] != 0)
                    end = true;
            }
        }

        public int brickSize (string s, int[, ] t) {
            int result = 0;
            switch (s) {
                case "x":
                    for (int x = 0; x < 4; x++) {
                        for (int y = 0; y < 4; y++) {
                            if (t[y, x] != 0 && result < x)
                                result = x;
                        }
                    }
                    break;

                case "y":
                    for (int x = 0; x < 4; x++) {
                        for (int y = 0; y < 4; y++) {
                            if (t[y, x] != 0 && result < y)
                                result = y;
                        }
                    }
                    break;

                case "-x":
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

        public int poeng (int[, ] b) {
            int score = 0;
            int radPoeng = 0;

            for (int y = 0; y < 20; y++) {
                radPoeng = 0;
                for (int x = 0; x < 10; x++) {
                    if (b[x, y] != 0)
                        radPoeng++;

                    if (radPoeng == 10) {
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

        public int[, ] rotate (int[, ] b) {
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

            undrawMe ();

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
                    } else if (canMoveRight (1, temp) == true && brickSize ("-x", temp) == 0) {
                        if (temp[x, y] != 0 && brett[brickx + 1 + x, bricky + y] != 0)
                            return b;

                        brickx++;
                        wall++;
                        return temp;
                    } else if (canMoveLeft (1, temp) == true && brickSize ("x", temp) == 3) {
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