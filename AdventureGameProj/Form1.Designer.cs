namespace AdventureGameProj
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
            this.option1Button = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.option1Label = new System.Windows.Forms.Label();
            this.option2Label = new System.Windows.Forms.Label();
            this.option2Button = new System.Windows.Forms.Button();
            this.option3Label = new System.Windows.Forms.Label();
            this.option3Button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // option1Button
            // 
            this.option1Button.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.option1Button.Location = new System.Drawing.Point(97, 324);
            this.option1Button.Name = "option1Button";
            this.option1Button.Size = new System.Drawing.Size(58, 51);
            this.option1Button.TabIndex = 0;
            this.option1Button.UseVisualStyleBackColor = true;
            this.option1Button.Click += new System.EventHandler(this.option1Button_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(70, 224);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(372, 74);
            this.outputLabel.TabIndex = 1;
            this.outputLabel.Text = "outputLabel";
            // 
            // option1Label
            // 
            this.option1Label.Location = new System.Drawing.Point(180, 338);
            this.option1Label.Name = "option1Label";
            this.option1Label.Size = new System.Drawing.Size(252, 23);
            this.option1Label.TabIndex = 2;
            this.option1Label.Text = "option1Label";
            this.option1Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // option2Label
            // 
            this.option2Label.Location = new System.Drawing.Point(180, 407);
            this.option2Label.Name = "option2Label";
            this.option2Label.Size = new System.Drawing.Size(252, 23);
            this.option2Label.TabIndex = 4;
            this.option2Label.Text = "option2Label";
            this.option2Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // option2Button
            // 
            this.option2Button.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.option2Button.Location = new System.Drawing.Point(97, 393);
            this.option2Button.Name = "option2Button";
            this.option2Button.Size = new System.Drawing.Size(58, 51);
            this.option2Button.TabIndex = 3;
            this.option2Button.UseVisualStyleBackColor = true;
            this.option2Button.Click += new System.EventHandler(this.option2Button_Click);
            // 
            // option3Label
            // 
            this.option3Label.Location = new System.Drawing.Point(180, 476);
            this.option3Label.Name = "option3Label";
            this.option3Label.Size = new System.Drawing.Size(252, 23);
            this.option3Label.TabIndex = 6;
            this.option3Label.Text = "option3Label";
            this.option3Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // option3Button
            // 
            this.option3Button.Location = new System.Drawing.Point(97, 462);
            this.option3Button.Name = "option3Button";
            this.option3Button.Size = new System.Drawing.Size(58, 51);
            this.option3Button.TabIndex = 5;
            this.option3Button.UseVisualStyleBackColor = true;
            this.option3Button.Click += new System.EventHandler(this.option3Button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(124, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 168);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 541);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.option3Label);
            this.Controls.Add(this.option3Button);
            this.Controls.Add(this.option2Label);
            this.Controls.Add(this.option2Button);
            this.Controls.Add(this.option1Label);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.option1Button);
            this.Name = "Form1";
            this.Text = "Escape the Vampire Mansion";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button option1Button;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label option1Label;
        private System.Windows.Forms.Label option2Label;
        private System.Windows.Forms.Button option2Button;
        private System.Windows.Forms.Label option3Label;
        private System.Windows.Forms.Button option3Button;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

