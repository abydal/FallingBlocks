using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FallingBlocks {
    public partial class Form1 : Form {
        static int[, ] board = new int[10, 20];
        static int[, ] next = new int[4, 4];
        Bitmap bmpBoard = new Bitmap (160, 320, System.Drawing.Imaging.PixelFormat.Format16bppRgb555);
        Bitmap bmpBoard2 = new Bitmap (64, 64, System.Drawing.Imaging.PixelFormat.Format16bppRgb555);
        Bitmap[] colors = new Bitmap[10];
        Bitmap[] grfx = new Bitmap[10];
        int xpos = 10;
        int ypos = 19;
        int speed = 500;
        bool pause = false;

        Brick myBrick = new Brick (board);

        public Form1 () {
            InitializeComponent ();

        }

        private void Form1_Load (object sender, EventArgs e) {

            grfx[0] = (Bitmap) Bitmap.FromFile ("panel_bakgrunn.bmp");
            grfx[1] = (Bitmap) Bitmap.FromFile ("tetrisblokk.bmp");
            grfx[2] = (Bitmap) Bitmap.FromFile ("tetrisblokk_b.bmp");
            grfx[3] = (Bitmap) Bitmap.FromFile ("tetrisblokk_g.bmp");
            grfx[4] = (Bitmap) Bitmap.FromFile ("tetrisblokk_gr.bmp");
            colors[0] = (Bitmap) Bitmap.FromFile ("bakgrunn.bmp");
            colors[1] = (Bitmap) Bitmap.FromFile ("tetrisblokk.bmp");
            colors[2] = (Bitmap) Bitmap.FromFile ("tetrisblokk_b.bmp");
            colors[3] = (Bitmap) Bitmap.FromFile ("tetrisblokk_g.bmp");
            colors[4] = (Bitmap) Bitmap.FromFile ("tetrisblokk_gr.bmp");
            board.Initialize ();
            next.Initialize ();
            labelPause.Hide ();
            myBrick.points = 0;
            panel2.Hide ();

            tmrGame.Enabled = true;
        }

        public void engineRun () {
            if (myBrick.end == true) {
                GameOver ();
            } else {
                myBrick.MoveDown ();
                label_poeng.Text = myBrick.points.ToString ();
                next = myBrick.nextShape;

                if (myBrick.points % 10 == 0)
                    speed = speed - (myBrick.points / 10);
            }
            drawBrett ();
        }

        private void drawBrett () {
            Graphics g = Graphics.FromImage (bmpBoard);
            Graphics v = Graphics.FromImage (bmpBoard2);

            for (int y = 0; y < 20; y++) {
                for (int x = 0; x < 10; x++) {
                    //går over hele brettet og tegner blokker der brett[] er 1
                    //blokkene er 16x16 fillRect's med en farge som tas ut fra fargetabellen
                    //g.FillRectangle(farger[brett[x,y]], x * 16, y * 16, 16, 16);
                    g.DrawImage (colors[board[x, y]], x * 16, y * 16);
                }
            }

            for (int y = 0; y < 4; y++) {
                for (int x = 0; x < 4; x++) {
                    //går over hele brettet og tegner blokker der brett[] er 1
                    //blokkene er 16x16 fillRect's med en farge som tas ut fra fargetabellen
                    //v.FillRectangle(farger[next[x, y]], x * 16, y * 16, 16, 16);
                    v.DrawImage (colors[next[y, x]], x * 16, y * 16);
                }
            }

            pb2.BackgroundImage = null;
            pb2.BackgroundImage = bmpBoard2;
            pbBrett.BackgroundImage = null;
            pbBrett.BackgroundImage = bmpBoard; //bildet/brettet tegnes inn i pictureBox
        }

        private void gameTimer_Tick (object sender, EventArgs e) {
            engineRun ();

        }

        private void Form1_KeyPress (object sender, KeyPressEventArgs e) {

        }

        private void Form1_KeyDown (object sender, KeyEventArgs e) {
            if (myBrick.end == true)
                return;

            switch (e.KeyCode.ToString ()) {
                case "W":
                    myBrick.shape = myBrick.Rotate (myBrick.shape);
                    myBrick.Draw ();
                    break;
                case "A":
                    myBrick.MoveLeft ();
                    break;
                case "D":
                    myBrick.MoveRight ();
                    break;
                case "S":
                    tmrGame.Interval = 10;
                    break;
                case "Up":
                    myBrick.shape = myBrick.Rotate (myBrick.shape);
                    myBrick.Draw ();
                    break;
                case "Left":
                    myBrick.MoveLeft ();
                    break;
                case "Right":
                    myBrick.MoveRight ();
                    break;
                case "Down":
                    tmrGame.Interval = 10;
                    break;
                case "P":
                    if (pause == false) {
                        tmrGame.Stop ();
                        pause = true;
                        labelPause.Show ();
                    } else {
                        tmrGame.Start ();
                        pause = false;
                        labelPause.Hide ();
                    }

                    break;

            }
            //MessageBox.Show(e.KeyCode.ToString());
            drawBrett ();

        }

        private void Form1_KeyUp (object sender, KeyEventArgs e) {
            if (myBrick.end == true)
                return;

            switch (e.KeyCode.ToString ()) {
                case "Down":
                    tmrGame.Interval = speed;
                    break;

            }

        }

        private void GameOver () {
            tmrGame.Interval = 50;

            if (ypos == 0 && xpos == 8) {
                tmrGame.Stop ();
                tmrGame.Interval = 500;
                board.Initialize ();
                myBrick.end = false;
                Form2 f = new Form2 (myBrick.points);
                f.Show ();
                panel2.Show ();
            }

            if (ypos % 2 == 0) {
                if (xpos < 9)
                    xpos++;
                else ypos--;

                board[xpos, ypos] = 1;
            }

            if (ypos % 2 == 1) {
                if (xpos > 0)
                    xpos--;
                else ypos--;

                board[xpos, ypos] = 1;
            }
            drawBrett ();
        }

        private void buttonHighscore_Click (object sender, EventArgs e) {
            HighScores n = new HighScores ();
            n.Show ();
        }

        private void buttonNewGame_Click (object sender, EventArgs e) {
            board = new int[10, 20];
            myBrick = new Brick (board);
            drawBrett ();
            next.Initialize ();
            labelPause.Hide ();
            myBrick.points = 0;
            panel2.Hide ();
            xpos = 10;
            ypos = 19;

            speed = 500;
            tmrGame.Interval = 500;
            tmrGame.Enabled = true;
            this.Focus ();

        }

    }
}