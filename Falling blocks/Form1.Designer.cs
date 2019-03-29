namespace FallingBlocks {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose ();
            }
            base.Dispose (disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent () {
            this.components = new System.ComponentModel.Container ();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager (typeof (Form1));
            this.pbBrett = new System.Windows.Forms.PictureBox ();
            this.tmrGame = new System.Windows.Forms.Timer (this.components);
            this.labelScore = new System.Windows.Forms.Label ();
            this.label_poeng = new System.Windows.Forms.Label ();
            this.pb2 = new System.Windows.Forms.PictureBox ();
            this.labelNext = new System.Windows.Forms.Label ();
            this.labelPause = new System.Windows.Forms.Label ();
            this.panel1 = new System.Windows.Forms.Panel ();
            this.panel2 = new System.Windows.Forms.Panel ();
            this.buttonHighscore = new System.Windows.Forms.Button ();
            this.buttonNewGame = new System.Windows.Forms.Button ();
            ((System.ComponentModel.ISupportInitialize) (this.pbBrett)).BeginInit ();
            ((System.ComponentModel.ISupportInitialize) (this.pb2)).BeginInit ();
            this.panel1.SuspendLayout ();
            this.panel2.SuspendLayout ();
            this.SuspendLayout ();
            // 
            // pbBrett
            // 
            this.pbBrett.Location = new System.Drawing.Point (16, 16);
            this.pbBrett.Name = "pbBrett";
            this.pbBrett.Size = new System.Drawing.Size (160, 320);
            this.pbBrett.TabIndex = 0;
            this.pbBrett.TabStop = false;
            // 
            // tmrGame
            // 
            this.tmrGame.Interval = 500;
            this.tmrGame.Tick += new System.EventHandler (this.gameTimer_Tick);
            // 
            // label1
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.BackColor = System.Drawing.Color.Transparent;
            this.labelScore.Font = new System.Drawing.Font ("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelScore.ForeColor = System.Drawing.Color.Red;
            this.labelScore.Location = new System.Drawing.Point (3, 8);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size (71, 24);
            this.labelScore.TabIndex = 1;
            this.labelScore.Text = "Score:";
            // 
            // label_poeng
            // 
            this.label_poeng.AutoSize = true;
            this.label_poeng.BackColor = System.Drawing.Color.Transparent;
            this.label_poeng.Font = new System.Drawing.Font ("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label_poeng.ForeColor = System.Drawing.Color.Red;
            this.label_poeng.Location = new System.Drawing.Point (80, 8);
            this.label_poeng.Name = "label_poeng";
            this.label_poeng.Size = new System.Drawing.Size (21, 24);
            this.label_poeng.TabIndex = 2;
            this.label_poeng.Text = "0";
            // 
            // pb2
            // 
            this.pb2.BackColor = System.Drawing.Color.Transparent;
            this.pb2.Location = new System.Drawing.Point (208, 80);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size (64, 64);
            this.pb2.TabIndex = 3;
            this.pb2.TabStop = false;
            // 
            // label2
            // 
            this.labelNext.BackColor = System.Drawing.Color.Black;
            this.labelNext.Font = new System.Drawing.Font ("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelNext.ForeColor = System.Drawing.Color.Red;
            this.labelNext.Location = new System.Drawing.Point (208, 64);
            this.labelNext.Name = "labelNext";
            this.labelNext.Size = new System.Drawing.Size (48, 16);
            this.labelNext.TabIndex = 4;
            this.labelNext.Text = "Next:";
            // 
            // label3
            // 
            this.labelPause.BackColor = System.Drawing.Color.Transparent;
            this.labelPause.Font = new System.Drawing.Font ("Franklin Gothic Medium", 20.43F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelPause.ForeColor = System.Drawing.Color.Red;
            this.labelPause.Location = new System.Drawing.Point (48, 144);
            this.labelPause.Name = "labelPause";
            this.labelPause.Size = new System.Drawing.Size (96, 32);
            this.labelPause.TabIndex = 5;
            this.labelPause.Text = "Pause";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Controls.Add (this.labelScore);
            this.panel1.Controls.Add (this.label_poeng);
            this.panel1.Location = new System.Drawing.Point (208, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size (144, 32);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Controls.Add (this.buttonHighscore);
            this.panel2.Controls.Add (this.buttonNewGame);
            this.panel2.Location = new System.Drawing.Point (208, 176);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size (128, 128);
            this.panel2.TabIndex = 7;
            // 
            // button2
            // 
            this.buttonHighscore.Font = new System.Drawing.Font ("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.buttonHighscore.ForeColor = System.Drawing.Color.Red;
            this.buttonHighscore.Location = new System.Drawing.Point (17, 54);
            this.buttonHighscore.Name = "buttonHighscore";
            this.buttonHighscore.Size = new System.Drawing.Size (84, 23);
            this.buttonHighscore.TabIndex = 1;
            this.buttonHighscore.Text = "Highscore";
            this.buttonHighscore.UseVisualStyleBackColor = true;
            this.buttonHighscore.Click += new System.EventHandler (this.buttonHighscore_Click);
            // 
            // button1
            // 
            this.buttonNewGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonNewGame.Font = new System.Drawing.Font ("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.buttonNewGame.ForeColor = System.Drawing.Color.Red;
            this.buttonNewGame.Location = new System.Drawing.Point (17, 25);
            this.buttonNewGame.Name = "buttonNewGame";
            this.buttonNewGame.Size = new System.Drawing.Size (84, 23);
            this.buttonNewGame.TabIndex = 0;
            this.buttonNewGame.Text = "New Game";
            this.buttonNewGame.UseVisualStyleBackColor = true;
            this.buttonNewGame.Click += new System.EventHandler (this.buttonNewGame_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF (6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = System.Drawing.Image.FromFile ("panel_bakgrunn.bmp");
            this.ClientSize = new System.Drawing.Size (384, 352);
            this.Controls.Add (this.panel2);
            this.Controls.Add (this.panel1);
            this.Controls.Add (this.labelPause);
            this.Controls.Add (this.labelNext);
            this.Controls.Add (this.pb2);
            this.Controls.Add (this.pbBrett);
            //this.Icon = ((System.Drawing.Icon. (resources.GetObject ("$this.Icon")));
            this.Location = new System.Drawing.Point (400, 300);
            this.Name = "Form1";
            this.Text = "Stacking Boxtris";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler (this.Form1_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler (this.Form1_KeyUp);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler (this.Form1_KeyDown);
            this.Load += new System.EventHandler (this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize) (this.pbBrett)).EndInit ();
            ((System.ComponentModel.ISupportInitialize) (this.pb2)).EndInit ();
            this.panel1.ResumeLayout (false);
            this.panel1.PerformLayout ();
            this.panel2.ResumeLayout (false);
            this.ResumeLayout (false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBrett;
        private System.Windows.Forms.Timer tmrGame;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label label_poeng;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.Label labelNext;
        private System.Windows.Forms.Label labelPause;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonHighscore;
        private System.Windows.Forms.Button buttonNewGame;

    }
}