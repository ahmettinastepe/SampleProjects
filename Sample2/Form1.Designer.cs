namespace Sample2
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
            this.BtnOne = new System.Windows.Forms.Button();
            this.BtnTwo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnThree = new System.Windows.Forms.Button();
            this.BtnFour = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnPlay = new System.Windows.Forms.Button();
            this.BtnNewGame = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.LblDue = new System.Windows.Forms.Label();
            this.LblOne = new System.Windows.Forms.Label();
            this.LblTwo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnOne
            // 
            this.BtnOne.Font = new System.Drawing.Font("Poppins Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnOne.Location = new System.Drawing.Point(12, 12);
            this.BtnOne.Name = "BtnOne";
            this.BtnOne.Size = new System.Drawing.Size(70, 70);
            this.BtnOne.TabIndex = 0;
            this.BtnOne.Text = "0";
            this.BtnOne.UseVisualStyleBackColor = true;
            // 
            // BtnTwo
            // 
            this.BtnTwo.Font = new System.Drawing.Font("Poppins Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnTwo.Location = new System.Drawing.Point(12, 122);
            this.BtnTwo.Name = "BtnTwo";
            this.BtnTwo.Size = new System.Drawing.Size(70, 70);
            this.BtnTwo.TabIndex = 0;
            this.BtnTwo.Text = "0";
            this.BtnTwo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(33, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "X";
            // 
            // BtnThree
            // 
            this.BtnThree.Font = new System.Drawing.Font("Poppins Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnThree.Location = new System.Drawing.Point(154, 9);
            this.BtnThree.Name = "BtnThree";
            this.BtnThree.Size = new System.Drawing.Size(70, 70);
            this.BtnThree.TabIndex = 0;
            this.BtnThree.Text = "0";
            this.BtnThree.UseVisualStyleBackColor = true;
            // 
            // BtnFour
            // 
            this.BtnFour.Font = new System.Drawing.Font("Poppins Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnFour.Location = new System.Drawing.Point(154, 122);
            this.BtnFour.Name = "BtnFour";
            this.BtnFour.Size = new System.Drawing.Size(70, 70);
            this.BtnFour.TabIndex = 0;
            this.BtnFour.Text = "0";
            this.BtnFour.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(177, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(106, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 37);
            this.label3.TabIndex = 1;
            this.label3.Text = "<";
            // 
            // BtnPlay
            // 
            this.BtnPlay.Enabled = false;
            this.BtnPlay.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnPlay.Location = new System.Drawing.Point(12, 198);
            this.BtnPlay.Name = "BtnPlay";
            this.BtnPlay.Size = new System.Drawing.Size(100, 30);
            this.BtnPlay.TabIndex = 2;
            this.BtnPlay.Text = "Oyna";
            this.BtnPlay.UseVisualStyleBackColor = true;
            this.BtnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // BtnNewGame
            // 
            this.BtnNewGame.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnNewGame.Location = new System.Drawing.Point(113, 198);
            this.BtnNewGame.Name = "BtnNewGame";
            this.BtnNewGame.Size = new System.Drawing.Size(111, 30);
            this.BtnNewGame.TabIndex = 2;
            this.BtnNewGame.Text = "Yeni Oyun";
            this.BtnNewGame.UseVisualStyleBackColor = true;
            this.BtnNewGame.Click += new System.EventHandler(this.BtnNewGame_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(88, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 37);
            this.label4.TabIndex = 1;
            this.label4.Text = "Hak";
            // 
            // LblDue
            // 
            this.LblDue.AutoSize = true;
            this.LblDue.Font = new System.Drawing.Font("Poppins Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblDue.Location = new System.Drawing.Point(103, 42);
            this.LblDue.Name = "LblDue";
            this.LblDue.Size = new System.Drawing.Size(31, 37);
            this.LblDue.TabIndex = 1;
            this.LblDue.Text = "4";
            // 
            // LblOne
            // 
            this.LblOne.AutoSize = true;
            this.LblOne.Location = new System.Drawing.Point(52, 96);
            this.LblOne.Name = "LblOne";
            this.LblOne.Size = new System.Drawing.Size(25, 13);
            this.LblOne.TabIndex = 3;
            this.LblOne.Text = "(25)";
            this.LblOne.Visible = false;
            // 
            // LblTwo
            // 
            this.LblTwo.AutoSize = true;
            this.LblTwo.Location = new System.Drawing.Point(197, 98);
            this.LblTwo.Name = "LblTwo";
            this.LblTwo.Size = new System.Drawing.Size(25, 13);
            this.LblTwo.TabIndex = 3;
            this.LblTwo.Text = "(25)";
            this.LblTwo.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 237);
            this.Controls.Add(this.LblTwo);
            this.Controls.Add(this.LblOne);
            this.Controls.Add(this.BtnNewGame);
            this.Controls.Add(this.BtnPlay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LblDue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnFour);
            this.Controls.Add(this.BtnTwo);
            this.Controls.Add(this.BtnThree);
            this.Controls.Add(this.BtnOne);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sample 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnOne;
        private System.Windows.Forms.Button BtnTwo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnThree;
        private System.Windows.Forms.Button BtnFour;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnPlay;
        private System.Windows.Forms.Button BtnNewGame;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblDue;
        private System.Windows.Forms.Label LblOne;
        private System.Windows.Forms.Label LblTwo;
    }
}

