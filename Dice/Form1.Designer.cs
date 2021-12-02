namespace Dice
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UserPrediction = new System.Windows.Forms.TextBox();
            this.PlayerPrediction = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.Label();
            this.Jemala = new System.Windows.Forms.TextBox();
            this.Number_Of_Dice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.win = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UserPrediction
            // 
            this.UserPrediction.Location = new System.Drawing.Point(12, 152);
            this.UserPrediction.Name = "UserPrediction";
            this.UserPrediction.Size = new System.Drawing.Size(80, 23);
            this.UserPrediction.TabIndex = 0;
            // 
            // PlayerPrediction
            // 
            this.PlayerPrediction.AutoSize = true;
            this.PlayerPrediction.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayerPrediction.Location = new System.Drawing.Point(12, 123);
            this.PlayerPrediction.Name = "PlayerPrediction";
            this.PlayerPrediction.Size = new System.Drawing.Size(80, 21);
            this.PlayerPrediction.TabIndex = 1;
            this.PlayerPrediction.Text = "Prediction";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(12, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(776, 257);
            this.button1.TabIndex = 2;
            this.button1.Text = "აქ დააჭირე!!!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Result.ForeColor = System.Drawing.Color.Red;
            this.Result.Location = new System.Drawing.Point(394, 99);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(70, 45);
            this.Result.TabIndex = 3;
            this.Result.Text = "IDK";
            // 
            // Jemala
            // 
            this.Jemala.Location = new System.Drawing.Point(25, 86);
            this.Jemala.Name = "Jemala";
            this.Jemala.Size = new System.Drawing.Size(100, 23);
            this.Jemala.TabIndex = 4;
            // 
            // Number_Of_Dice
            // 
            this.Number_Of_Dice.AutoSize = true;
            this.Number_Of_Dice.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Number_Of_Dice.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Number_Of_Dice.Location = new System.Drawing.Point(1, -3);
            this.Number_Of_Dice.Name = "Number_Of_Dice";
            this.Number_Of_Dice.Size = new System.Drawing.Size(497, 86);
            this.Number_Of_Dice.TabIndex = 6;
            this.Number_Of_Dice.Text = "Number Of Dice";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // win
            // 
            this.win.AutoSize = true;
            this.win.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.win.Location = new System.Drawing.Point(776, 9);
            this.win.Name = "win";
            this.win.Size = new System.Drawing.Size(38, 13);
            this.win.TabIndex = 8;
            this.win.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.win);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Number_Of_Dice);
            this.Controls.Add(this.Jemala);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PlayerPrediction);
            this.Controls.Add(this.UserPrediction);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox UserPrediction;
        private Label PlayerPrediction;
        private Button button1;
        private Label Result;
        private TextBox Jemala;
        private Label Number_Of_Dice;
        private Label label1;
        private Label win;
    }
}