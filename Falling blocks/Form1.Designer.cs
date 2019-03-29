namespace Falling_blocks {
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
            this.label1 = new System.Windows.Forms.Label ();
            this.label_poeng = new System.Windows.Forms.Label ();
            this.pb2 = new System.Windows.Forms.PictureBox ();
            this.label2 = new System.Windows.Forms.Label ();
            this.label3 = new System.Windows.Forms.Label ();
            this.panel1 = new System.Windows.Forms.Panel ();
            this.panel2 = new System.Windows.Forms.Panel ();
            this.button2 = new System.Windows.Forms.Button ();
            this.button1 = new System.Windows.Forms.Button ();
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
            this.tmrGame.Tick += new System.EventHandler (this.tmrGame_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font ("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point (3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size (71, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Score:";
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
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font ("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point (208, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size (48, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Next:";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font ("Franklin Gothic Medium", 20.43F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point (48, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size (96, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pause";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Controls.Add (this.label1);
            this.panel1.Controls.Add (this.label_poeng);
            this.panel1.Location = new System.Drawing.Point (208, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size (144, 32);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Controls.Add (this.button2);
            this.panel2.Controls.Add (this.button1);
            this.panel2.Location = new System.Drawing.Point (208, 176);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size (128, 128);
            this.panel2.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font ("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point (17, 54);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size (84, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Highscore";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler (this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font ("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point (17, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size (84, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "New Game";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler (this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF (6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = System.Drawing.Image.FromFile ("bakgrunn.bmp");
            this.ClientSize = new System.Drawing.Size (384, 352);
            this.Controls.Add (this.panel2);
            this.Controls.Add (this.panel1);
            this.Controls.Add (this.label3);
            this.Controls.Add (this.label2);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_poeng;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;

    }
}