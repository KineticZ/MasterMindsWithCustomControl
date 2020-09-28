namespace MasterMinds
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guessButton = new System.Windows.Forms.Button();
            this.colorSelector3 = new MasterMinds.Controls.ColorSelector();
            this.colorSelector2 = new MasterMinds.Controls.ColorSelector();
            this.colorSelector1 = new MasterMinds.Controls.ColorSelector();
            this.SuspendLayout();
            // 
            // guessButton
            // 
            this.guessButton.Location = new System.Drawing.Point(400, 7);
            this.guessButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guessButton.Name = "guessButton";
            this.guessButton.Size = new System.Drawing.Size(168, 183);
            this.guessButton.TabIndex = 3;
            this.guessButton.Text = "Guess";
            this.guessButton.UseVisualStyleBackColor = true;
            this.guessButton.Click += new System.EventHandler(this.guessButton_Click);
            // 
            // colorSelector3
            // 
            this.colorSelector3.Colors = new System.Drawing.Color[0];
            this.colorSelector3.Location = new System.Drawing.Point(270, 8);
            this.colorSelector3.Name = "colorSelector3";
            this.colorSelector3.Size = new System.Drawing.Size(126, 183);
            this.colorSelector3.TabIndex = 2;
            this.colorSelector3.TextForTextBox = "Select Color";
            this.colorSelector3.ColorSelected += new System.EventHandler(this.colorSelector_ColorSelected);
            // 
            // colorSelector2
            // 
            this.colorSelector2.Colors = new System.Drawing.Color[0];
            this.colorSelector2.Location = new System.Drawing.Point(138, 8);
            this.colorSelector2.Name = "colorSelector2";
            this.colorSelector2.Size = new System.Drawing.Size(126, 183);
            this.colorSelector2.TabIndex = 1;
            this.colorSelector2.TextForTextBox = "Select Color";
            this.colorSelector2.ColorSelected += new System.EventHandler(this.colorSelector_ColorSelected);
            // 
            // colorSelector1
            // 
            this.colorSelector1.Colors = new System.Drawing.Color[0];
            this.colorSelector1.Location = new System.Drawing.Point(6, 7);
            this.colorSelector1.Name = "colorSelector1";
            this.colorSelector1.Size = new System.Drawing.Size(126, 183);
            this.colorSelector1.TabIndex = 0;
            this.colorSelector1.TextForTextBox = "Select Color";
            this.colorSelector1.ColorSelected += new System.EventHandler(this.colorSelector_ColorSelected);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 322);
            this.Controls.Add(this.guessButton);
            this.Controls.Add(this.colorSelector3);
            this.Controls.Add(this.colorSelector2);
            this.Controls.Add(this.colorSelector1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ColorSelector colorSelector1;
        private Controls.ColorSelector colorSelector2;
        private Controls.ColorSelector colorSelector3;
        private System.Windows.Forms.Button guessButton;
    }
}

