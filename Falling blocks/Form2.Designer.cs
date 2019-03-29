namespace Falling_blocks {
	partial class Form2 {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager (typeof (Form2));
			this.button1 = new System.Windows.Forms.Button ();
			this.label1 = new System.Windows.Forms.Label ();
			this.textBox_name = new System.Windows.Forms.TextBox ();
			this.SuspendLayout ();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point (37, 39);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size (113, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "ok";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler (this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point (10, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size (36, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Navn:";
			// 
			// textBox_name
			// 
			this.textBox_name.Location = new System.Drawing.Point (51, 13);
			this.textBox_name.Name = "textBox_name";
			this.textBox_name.Size = new System.Drawing.Size (138, 20);
			this.textBox_name.TabIndex = 2;
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF (6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size (199, 72);
			this.Controls.Add (this.textBox_name);
			this.Controls.Add (this.label1);
			this.Controls.Add (this.button1);
			//this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Location = new System.Drawing.Point (600, 500);
			this.Name = "Form2";
			this.Text = "Highscore";
			this.ResumeLayout (false);
			this.PerformLayout ();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox_name;
	}
}