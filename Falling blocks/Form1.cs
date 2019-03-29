using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Falling_blocks {
    public partial class Form1 : Form {
        static int[, ] brett = new int[10, 20];
        static int[, ] next = new int[4, 4];
        Bitmap bmpBrett = new Bitmap (160, 320, System.Drawing.Imaging.PixelFormat.Format16bppRgb555);
        Bitmap bmpBrett2 = new Bitmap (64, 64, System.Drawing.Imaging.PixelFormat.Format16bppRgb555);
        Bitmap[] farger = new Bitmap[10];
        Bitmap[] grfx = new Bitmap[10];
        int xpos = 10;
        int ypos = 19;
        int speed = 500;
        bool pause = false;

        brick myBrick = new brick (brett);

        public Form1 () {
            InitializeComponent ();

        }

        private void Form1_Load (object sender, EventArgs e) {

            grfx[0] = (Bitmap) Bitmap.FromFile ("panel_bakgrunn.bmp");
            grfx[1] = (Bitmap) Bitmap.FromFile ("tetrisblokk.bmp");
            grfx[2] = (Bitmap) Bitmap.FromFile ("tetrisblokk_b.bmp");
            grfx[3] = (Bitmap) Bitmap.FromFile ("tetrisblokk_g.bmp");
            grfx[4] = (Bitmap) Bitmap.FromFile ("tetrisblokk_gr.bmp");
            farger[0] = (Bitmap) Bitmap.FromFile ("bakgrunn.bmp");
            farger[1] = (Bitmap) Bitmap.FromFile ("tetrisblokk.bmp");
            farger[2] = (Bitmap) Bitmap.FromFile ("tetrisblokk_b.bmp");
            farger[3] = (Bitmap) Bitmap.FromFile ("tetrisblokk_g.bmp");
            farger[4] = (Bitmap) Bitmap.FromFile ("tetrisblokk_gr.bmp");
            brett.Initialize ();
            next.Initialize ();
            label3.Hide ();
            myBrick.points = 0;
            panel2.Hide ();

            tmrGame.Enabled = true;
        }

        public void engineRun () {
            if (myBrick.end == true) {
                gameOver ();
            } else {
                myBrick.moveDown ();
                label_poeng.Text = myBrick.points.ToString ();
                next = myBrick.nextShape;

                if (myBrick.points % 10 == 0)
                    speed = speed - (myBrick.points / 10);
            }
            drawBrett ();
        }

        private void drawBrett () {
            Graphics g = Graphics.FromImage (bmpBrett);
            Graphics v = Graphics.FromImage (bmpBrett2);

            for (int y = 0; y < 20; y++) {
                for (int x = 0; x < 10; x++) {
                    //går over hele brettet og tegner blokker der brett[] er 1
                    //blokkene er 16x16 fillRect's med en farge som tas ut fra fargetabellen
                    //g.FillRectangle(farger[brett[x,y]], x * 16, y * 16, 16, 16);
                    g.DrawImage (farger[brett[x, y]], x * 16, y * 16);
                }
            }

            for (int y = 0; y < 4; y++) {
                for (int x = 0; x < 4; x++) {
                    //går over hele brettet og tegner blokker der brett[] er 1
                    //blokkene er 16x16 fillRect's med en farge som tas ut fra fargetabellen
                    //v.FillRectangle(farger[next[x, y]], x * 16, y * 16, 16, 16);
                    v.DrawImage (farger[next[y, x]], x * 16, y * 16);
                }
            }

            pb2.BackgroundImage = null;
            pb2.BackgroundImage = bmpBrett2;
            pbBrett.BackgroundImage = null;
            pbBrett.BackgroundImage = bmpBrett; //bildet/brettet tegnes inn i pictureBox
        }

        private void tmrGame_Tick (object sender, EventArgs e) {
            engineRun ();

        }

        private void Form1_KeyPress (object sender, KeyPressEventArgs e) {

        }

        private void Form1_KeyDown (object sender, KeyEventArgs e) {
            if (myBrick.end == true)
                return;

            switch (e.KeyCode.ToString ()) {
                case "W":
                    myBrick.shape = myBrick.rotate (myBrick.shape);
                    myBrick.drawMe ();
                    break;
                case "A":
                    myBrick.moveLeft ();
                    break;
                case "D":
                    myBrick.moveRight ();
                    break;
                case "S":
                    tmrGame.Interval = 10;
                    break;
                case "Up":
                    myBrick.shape = myBrick.rotate (myBrick.shape);
                    myBrick.drawMe ();
                    break;
                case "Left":
                    myBrick.moveLeft ();
                    break;
                case "Right":
                    myBrick.moveRight ();
                    break;
                case "Down":
                    tmrGame.Interval = 10;
                    break;
                case "P":
                    if (pause == false) {
                        tmrGame.Stop ();
                        pause = true;
                        label3.Show ();
                    } else {
                        tmrGame.Start ();
                        pause = false;
                        label3.Hide ();
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

        private void gameOver () {
            tmrGame.Interval = 50;

            if (ypos == 0 && xpos == 8) {
                tmrGame.Stop ();
                tmrGame.Interval = 500;
                brett.Initialize ();
                myBrick.end = false;
                Form2 f = new Form2 (myBrick.points);
                f.Show ();
                panel2.Show ();
            }

            if (ypos % 2 == 0) {
                if (xpos < 9)
                    xpos++;
                else ypos--;

                brett[xpos, ypos] = 1;
            }

            if (ypos % 2 == 1) {
                if (xpos > 0)
                    xpos--;
                else ypos--;

                brett[xpos, ypos] = 1;
            }
            drawBrett ();
        }

        private void button2_Click (object sender, EventArgs e) {
            HighScores n = new HighScores ();
            n.Show ();
        }

        private void button1_Click (object sender, EventArgs e) {
            brett = new int[10, 20];
            myBrick = new brick (brett);
            drawBrett ();
            next.Initialize ();
            label3.Hide ();
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