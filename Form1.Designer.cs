namespace AdditionPracticeV2
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
            this.components = new System.ComponentModel.Container();
            this.singleDigitBtn = new System.Windows.Forms.Button();
            this.doubleDigitBtn = new System.Windows.Forms.Button();
            this.tripleDigitBtn = new System.Windows.Forms.Button();
            this.dontWantMathBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.noBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // singleDigitBtn
            // 
            this.singleDigitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.singleDigitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.singleDigitBtn.Location = new System.Drawing.Point(38, 125);
            this.singleDigitBtn.Name = "singleDigitBtn";
            this.singleDigitBtn.Size = new System.Drawing.Size(224, 44);
            this.singleDigitBtn.TabIndex = 0;
            this.singleDigitBtn.Text = "single digit addition";
            this.singleDigitBtn.UseVisualStyleBackColor = true;
            this.singleDigitBtn.Click += new System.EventHandler(this.singleDigitBtn_Click);
            // 
            // doubleDigitBtn
            // 
            this.doubleDigitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.doubleDigitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doubleDigitBtn.Location = new System.Drawing.Point(38, 213);
            this.doubleDigitBtn.Name = "doubleDigitBtn";
            this.doubleDigitBtn.Size = new System.Drawing.Size(224, 44);
            this.doubleDigitBtn.TabIndex = 1;
            this.doubleDigitBtn.Text = "double digit addition";
            this.doubleDigitBtn.UseVisualStyleBackColor = true;
            this.doubleDigitBtn.Click += new System.EventHandler(this.doubleDigitBtn_Click);
            // 
            // tripleDigitBtn
            // 
            this.tripleDigitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tripleDigitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tripleDigitBtn.Location = new System.Drawing.Point(357, 125);
            this.tripleDigitBtn.Name = "tripleDigitBtn";
            this.tripleDigitBtn.Size = new System.Drawing.Size(224, 44);
            this.tripleDigitBtn.TabIndex = 2;
            this.tripleDigitBtn.Text = "triple digit addition";
            this.tripleDigitBtn.UseVisualStyleBackColor = true;
            this.tripleDigitBtn.Click += new System.EventHandler(this.tripleDigitBtn_Click);
            // 
            // dontWantMathBtn
            // 
            this.dontWantMathBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dontWantMathBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dontWantMathBtn.Location = new System.Drawing.Point(357, 213);
            this.dontWantMathBtn.Name = "dontWantMathBtn";
            this.dontWantMathBtn.Size = new System.Drawing.Size(224, 44);
            this.dontWantMathBtn.TabIndex = 3;
            this.dontWantMathBtn.Text = "i don\'t want to do math";
            this.dontWantMathBtn.UseVisualStyleBackColor = true;
            this.dontWantMathBtn.Click += new System.EventHandler(this.dontWantMathBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "select an option below";
            // 
            // noBtn
            // 
            this.noBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.noBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noBtn.Location = new System.Drawing.Point(470, 9);
            this.noBtn.Name = "noBtn";
            this.noBtn.Size = new System.Drawing.Size(111, 43);
            this.noBtn.TabIndex = 5;
            this.noBtn.Text = "no.";
            this.noBtn.UseVisualStyleBackColor = true;
            this.noBtn.Click += new System.EventHandler(this.noBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(621, 293);
            this.Controls.Add(this.noBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dontWantMathBtn);
            this.Controls.Add(this.tripleDigitBtn);
            this.Controls.Add(this.doubleDigitBtn);
            this.Controls.Add(this.singleDigitBtn);
            this.Name = "Form1";
            this.Text = "main menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button singleDigitBtn;
        private System.Windows.Forms.Button doubleDigitBtn;
        private System.Windows.Forms.Button tripleDigitBtn;
        private System.Windows.Forms.Button dontWantMathBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button noBtn;
        private System.Windows.Forms.Timer timer1;
    }
}

