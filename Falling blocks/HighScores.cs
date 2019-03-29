using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace FallingBlocks {
    public partial class HighScores : Form {
        public HighScores () {
            InitializeComponent ();
        }

        private void HighScores_Load (object sender, EventArgs e) {

            if (!File.Exists ("Highscore.txt"))
                File.Create ("Highscore.txt");

            var temp = File.ReadAllLines ("Highscore.txt");

            label1.Text = "1. " + temp[0];
            label2.Text = "2. " + temp[1];
            label3.Text = "3. " + temp[2];
            label4.Text = "4. " + temp[3];
            label5.Text = "5. " + temp[4];
            label6.Text = "6. " + temp[5];
            label7.Text = "7. " + temp[6];
            label8.Text = "8. " + temp[7];
            label9.Text = "9. " + temp[8];
            label10.Text = "10. " + temp[9];

        }
    }
}