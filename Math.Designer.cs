namespace AdditionPracticeV2
{
    partial class Math
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
            this.typeOfAdditionTB = new System.Windows.Forms.TextBox();
            this.problemTB = new System.Windows.Forms.TextBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.resultTB = new System.Windows.Forms.TextBox();
            this.correctAnswersLbl = new System.Windows.Forms.Label();
            this.inputTB = new System.Windows.Forms.TextBox();
            this.correctAnswersTB = new System.Windows.Forms.TextBox();
            this.switchBtn1 = new System.Windows.Forms.Button();
            this.switchBtn2 = new System.Windows.Forms.Button();
            this.switchBtn3 = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // typeOfAdditionTB
            // 
            this.typeOfAdditionTB.BackColor = System.Drawing.Color.White;
            this.typeOfAdditionTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.typeOfAdditionTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeOfAdditionTB.Location = new System.Drawing.Point(85, 46);
            this.typeOfAdditionTB.Name = "typeOfAdditionTB";
            this.typeOfAdditionTB.ReadOnly = true;
            this.typeOfAdditionTB.Size = new System.Drawing.Size(419, 34);
            this.typeOfAdditionTB.TabIndex = 0;
            this.typeOfAdditionTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // problemTB
            // 
            this.problemTB.BackColor = System.Drawing.Color.White;
            this.problemTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.problemTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.problemTB.Location = new System.Drawing.Point(85, 124);
            this.problemTB.Name = "problemTB";
            this.problemTB.ReadOnly = true;
            this.problemTB.Size = new System.Drawing.Size(202, 34);
            this.problemTB.TabIndex = 1;
            this.problemTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // submitBtn
            // 
            this.submitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.submitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.Location = new System.Drawing.Point(433, 124);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(82, 40);
            this.submitBtn.TabIndex = 2;
            this.submitBtn.Text = "submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.nextBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextBtn.Location = new System.Drawing.Point(433, 199);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(82, 40);
            this.nextBtn.TabIndex = 3;
            this.nextBtn.Text = "next";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Visible = false;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // resultTB
            // 
            this.resultTB.BackColor = System.Drawing.Color.White;
            this.resultTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultTB.Location = new System.Drawing.Point(85, 199);
            this.resultTB.Name = "resultTB";
            this.resultTB.ReadOnly = true;
            this.resultTB.Size = new System.Drawing.Size(278, 34);
            this.resultTB.TabIndex = 4;
            this.resultTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // correctAnswersLbl
            // 
            this.correctAnswersLbl.AutoSize = true;
            this.correctAnswersLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correctAnswersLbl.Location = new System.Drawing.Point(85, 264);
            this.correctAnswersLbl.Name = "correctAnswersLbl";
            this.correctAnswersLbl.Size = new System.Drawing.Size(155, 25);
            this.correctAnswersLbl.TabIndex = 5;
            this.correctAnswersLbl.Text = "correct answers:";
            this.correctAnswersLbl.Visible = false;
            // 
            // inputTB
            // 
            this.inputTB.BackColor = System.Drawing.Color.White;
            this.inputTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTB.Location = new System.Drawing.Point(329, 124);
            this.inputTB.Name = "inputTB";
            this.inputTB.Size = new System.Drawing.Size(74, 34);
            this.inputTB.TabIndex = 0;
            this.inputTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inputTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputTB_KeyDown);
            // 
            // correctAnswersTB
            // 
            this.correctAnswersTB.BackColor = System.Drawing.Color.White;
            this.correctAnswersTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.correctAnswersTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correctAnswersTB.Location = new System.Drawing.Point(256, 259);
            this.correctAnswersTB.Name = "correctAnswersTB";
            this.correctAnswersTB.ReadOnly = true;
            this.correctAnswersTB.Size = new System.Drawing.Size(59, 34);
            this.correctAnswersTB.TabIndex = 7;
            this.correctAnswersTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.correctAnswersTB.Visible = false;
            // 
            // switchBtn1
            // 
            this.switchBtn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switchBtn1.Location = new System.Drawing.Point(85, 339);
            this.switchBtn1.Name = "switchBtn1";
            this.switchBtn1.Size = new System.Drawing.Size(121, 40);
            this.switchBtn1.TabIndex = 8;
            this.switchBtn1.Text = "single";
            this.switchBtn1.UseVisualStyleBackColor = true;
            this.switchBtn1.Click += new System.EventHandler(this.switchBtn1_Click);
            // 
            // switchBtn2
            // 
            this.switchBtn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switchBtn2.Location = new System.Drawing.Point(242, 339);
            this.switchBtn2.Name = "switchBtn2";
            this.switchBtn2.Size = new System.Drawing.Size(121, 40);
            this.switchBtn2.TabIndex = 9;
            this.switchBtn2.Text = "double";
            this.switchBtn2.UseVisualStyleBackColor = true;
            this.switchBtn2.Click += new System.EventHandler(this.switchBtn2_Click);
            // 
            // switchBtn3
            // 
            this.switchBtn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switchBtn3.Location = new System.Drawing.Point(394, 339);
            this.switchBtn3.Name = "switchBtn3";
            this.switchBtn3.Size = new System.Drawing.Size(121, 40);
            this.switchBtn3.TabIndex = 10;
            this.switchBtn3.Text = "triple";
            this.switchBtn3.UseVisualStyleBackColor = true;
            this.switchBtn3.Click += new System.EventHandler(this.switchBtn3_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.Location = new System.Drawing.Point(242, 397);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(121, 40);
            this.closeBtn.TabIndex = 11;
            this.closeBtn.Text = "close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // Math
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 456);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.switchBtn3);
            this.Controls.Add(this.switchBtn2);
            this.Controls.Add(this.switchBtn1);
            this.Controls.Add(this.correctAnswersTB);
            this.Controls.Add(this.inputTB);
            this.Controls.Add(this.correctAnswersLbl);
            this.Controls.Add(this.resultTB);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.problemTB);
            this.Controls.Add(this.typeOfAdditionTB);
            this.Name = "Math";
            this.Text = "Math";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox typeOfAdditionTB;
        private System.Windows.Forms.TextBox problemTB;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.TextBox resultTB;
        private System.Windows.Forms.Label correctAnswersLbl;
        private System.Windows.Forms.TextBox inputTB;
        private System.Windows.Forms.TextBox correctAnswersTB;
        private System.Windows.Forms.Button switchBtn1;
        private System.Windows.Forms.Button switchBtn2;
        private System.Windows.Forms.Button switchBtn3;
        private System.Windows.Forms.Button closeBtn;
    }
}