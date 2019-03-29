using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Falling_blocks {
    class main_program {
        public bool running = false;
        List<brick> bricks = new List<brick> ();
        public main_program () {

        }

        public brick getNewBrick () {
            brick s = new brick ();
            bricks.Add (s);
            return (s);
        }
        public void run () {
            brick b = new brick ();
            bricks.Add (b);

            while (running == true) {
                for (int i = 0; i <= bricks.Count; i++) {
                    brick temp = (brick) bricks[i];
                    //temp.drawMe();
                    MessageBox.Show ("test" + bricks.Count);
                }

            }
        }
    }
}