using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FallingBlocks {
    public partial class Form2 : Form {
        int po;

        public Form2 (int points) {
            po = points;
            InitializeComponent ();
        }

        private void button1_Click (object sender, EventArgs e) {
            int[] poeng = new int[11];
            string[] navn = new string[11];

            System.IO.StreamReader r = new System.IO.StreamReader ("Highscore.txt");

            string[] h = new string[10];

            for (int i = 0; i < 10; i++)
                h[i] = r.ReadLine ();

            for (int i = 0; i < 10; i++) {
                string t = h[i];
                if (!string.IsNullOrEmpty (t) && t != "0") {
                    poeng[i] = int.Parse (t.Substring (t.LastIndexOf (" ") + 1));
                    navn[i] = t.Substring (0, t.LastIndexOf (" "));
                }
            }
            r.Close ();
            System.IO.StreamWriter w = new System.IO.StreamWriter ("Highscore.txt");

            poeng[10] = po;
            navn[10] = textBox_name.Text;
            bubbleSort (poeng, navn);
            for (int i = 0; i < 11; i++)
                w.WriteLine (navn[i] + " " + poeng[i].ToString ());

            w.Close ();
            this.Close ();

        }

        private void bubbleSort (int[] b, string[] c) {
            int temp;
            string temps;
            int i = b.Length - 1;

            while (i > 0) {
                if (b[i] > b[i - 1]) {
                    temp = b[i - 1];
                    b[i - 1] = b[i];
                    b[i] = temp;

                    temps = c[i - 1];
                    c[i - 1] = c[i];
                    c[i] = temps;
                }
                i--;

            }

        }
    }
}