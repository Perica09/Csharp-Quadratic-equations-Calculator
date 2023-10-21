namespace Seminarska
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Text1 = new System.Windows.Forms.Label();
            this.X2InputBox = new System.Windows.Forms.TextBox();
            this.XInputBox = new System.Windows.Forms.TextBox();
            this.NoXInputBox = new System.Windows.Forms.TextBox();
            this.X2Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Text2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.X1Answer = new System.Windows.Forms.TextBox();
            this.X2Answer = new System.Windows.Forms.TextBox();
            this.X2ImaginaryAnswer = new System.Windows.Forms.TextBox();
            this.X1ImaginaryAnswer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AnswerBotton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Text1
            // 
            this.Text1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text1.Location = new System.Drawing.Point(41, 18);
            this.Text1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Text1.Name = "Text1";
            this.Text1.Size = new System.Drawing.Size(885, 77);
            this.Text1.TabIndex = 0;
            this.Text1.Text = "Внесете целобројни вредности во интервал (-999, 999) и \r\nпритиснете на копчето РЕ" +
    "ШИ за да биде решена квадратната равенка";
            this.Text1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // X2InputBox
            // 
            this.X2InputBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.X2InputBox.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.X2InputBox.Location = new System.Drawing.Point(48, 112);
            this.X2InputBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.X2InputBox.Name = "X2InputBox";
            this.X2InputBox.Size = new System.Drawing.Size(228, 39);
            this.X2InputBox.TabIndex = 1;
            this.X2InputBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.X2InputBox.TextChanged += new System.EventHandler(this.X2InputBox_TextChanged);
            // 
            // XInputBox
            // 
            this.XInputBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.XInputBox.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XInputBox.Location = new System.Drawing.Point(361, 112);
            this.XInputBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.XInputBox.Name = "XInputBox";
            this.XInputBox.Size = new System.Drawing.Size(228, 39);
            this.XInputBox.TabIndex = 2;
            this.XInputBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.XInputBox.TextChanged += new System.EventHandler(this.XInputBox_TextChanged);
            // 
            // NoXInputBox
            // 
            this.NoXInputBox.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoXInputBox.Location = new System.Drawing.Point(642, 112);
            this.NoXInputBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NoXInputBox.Name = "NoXInputBox";
            this.NoXInputBox.Size = new System.Drawing.Size(228, 39);
            this.NoXInputBox.TabIndex = 3;
            this.NoXInputBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NoXInputBox.TextChanged += new System.EventHandler(this.NoXInputBox_TextChanged);
            // 
            // X2Label
            // 
            this.X2Label.AutoSize = true;
            this.X2Label.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.X2Label.Location = new System.Drawing.Point(283, 116);
            this.X2Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.X2Label.Name = "X2Label";
            this.X2Label.Size = new System.Drawing.Size(64, 32);
            this.X2Label.TabIndex = 4;
            this.X2Label.Text = "X^2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(597, 116);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(877, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "= 0";
            // 
            // Text2
            // 
            this.Text2.AutoSize = true;
            this.Text2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text2.Location = new System.Drawing.Point(48, 188);
            this.Text2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Text2.Name = "Text2";
            this.Text2.Size = new System.Drawing.Size(408, 32);
            this.Text2.TabIndex = 7;
            this.Text2.Text = "Корени/решенија на равенката";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 306);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "X2 =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 246);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "X1 =";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // X1Answer
            // 
            this.X1Answer.Cursor = System.Windows.Forms.Cursors.No;
            this.X1Answer.Enabled = false;
            this.X1Answer.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.X1Answer.Location = new System.Drawing.Point(134, 246);
            this.X1Answer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.X1Answer.Name = "X1Answer";
            this.X1Answer.Size = new System.Drawing.Size(228, 39);
            this.X1Answer.TabIndex = 10;
            this.X1Answer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // X2Answer
            // 
            this.X2Answer.Cursor = System.Windows.Forms.Cursors.No;
            this.X2Answer.Enabled = false;
            this.X2Answer.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.X2Answer.Location = new System.Drawing.Point(134, 306);
            this.X2Answer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.X2Answer.Name = "X2Answer";
            this.X2Answer.Size = new System.Drawing.Size(228, 39);
            this.X2Answer.TabIndex = 11;
            this.X2Answer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // X2ImaginaryAnswer
            // 
            this.X2ImaginaryAnswer.Cursor = System.Windows.Forms.Cursors.No;
            this.X2ImaginaryAnswer.Enabled = false;
            this.X2ImaginaryAnswer.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.X2ImaginaryAnswer.Location = new System.Drawing.Point(428, 306);
            this.X2ImaginaryAnswer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.X2ImaginaryAnswer.Name = "X2ImaginaryAnswer";
            this.X2ImaginaryAnswer.Size = new System.Drawing.Size(228, 39);
            this.X2ImaginaryAnswer.TabIndex = 12;
            this.X2ImaginaryAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // X1ImaginaryAnswer
            // 
            this.X1ImaginaryAnswer.Cursor = System.Windows.Forms.Cursors.No;
            this.X1ImaginaryAnswer.Enabled = false;
            this.X1ImaginaryAnswer.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.X1ImaginaryAnswer.Location = new System.Drawing.Point(428, 246);
            this.X1ImaginaryAnswer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.X1ImaginaryAnswer.Name = "X1ImaginaryAnswer";
            this.X1ImaginaryAnswer.Size = new System.Drawing.Size(228, 39);
            this.X1ImaginaryAnswer.TabIndex = 13;
            this.X1ImaginaryAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.X1ImaginaryAnswer.TextChanged += new System.EventHandler(this.X1ImaginaryAnswer_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(663, 248);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 32);
            this.label5.TabIndex = 14;
            this.label5.Text = "* i";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(663, 309);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 32);
            this.label6.TabIndex = 15;
            this.label6.Text = "* i";
            // 
            // AnswerBotton
            // 
            this.AnswerBotton.BackColor = System.Drawing.Color.LightPink;
            this.AnswerBotton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnswerBotton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.AnswerBotton.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerBotton.ForeColor = System.Drawing.Color.Black;
            this.AnswerBotton.Location = new System.Drawing.Point(779, 237);
            this.AnswerBotton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AnswerBotton.Name = "AnswerBotton";
            this.AnswerBotton.Size = new System.Drawing.Size(190, 56);
            this.AnswerBotton.TabIndex = 16;
            this.AnswerBotton.Text = "РЕШИ";
            this.AnswerBotton.UseVisualStyleBackColor = false;
            this.AnswerBotton.Click += new System.EventHandler(this.button1_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Gray;
            this.deleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.deleteButton.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(779, 306);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(190, 56);
            this.deleteButton.TabIndex = 17;
            this.deleteButton.Text = "ИЗБРИШИ";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.AnswerBotton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.deleteButton;
            this.ClientSize = new System.Drawing.Size(979, 378);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.AnswerBotton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.X1ImaginaryAnswer);
            this.Controls.Add(this.X2ImaginaryAnswer);
            this.Controls.Add(this.X2Answer);
            this.Controls.Add(this.X1Answer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Text2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.X2Label);
            this.Controls.Add(this.NoXInputBox);
            this.Controls.Add(this.XInputBox);
            this.Controls.Add(this.X2InputBox);
            this.Controls.Add(this.Text1);
            this.Cursor = System.Windows.Forms.Cursors.No;
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(997, 425);
            this.MinimumSize = new System.Drawing.Size(997, 425);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Калкулатор за решавање квадратни равенки";
            this.Load += new System.EventHandler(this.Калкулатор_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Text1;
        private System.Windows.Forms.TextBox X2InputBox;
        private System.Windows.Forms.TextBox XInputBox;
        private System.Windows.Forms.TextBox NoXInputBox;
        private System.Windows.Forms.Label X2Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Text2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox X1Answer;
        private System.Windows.Forms.TextBox X2Answer;
        private System.Windows.Forms.TextBox X2ImaginaryAnswer;
        private System.Windows.Forms.TextBox X1ImaginaryAnswer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AnswerBotton;
        private System.Windows.Forms.Button deleteButton;
    }
}

