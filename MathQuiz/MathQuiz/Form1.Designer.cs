namespace MathQuiz
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
            this.cbLevel = new System.Windows.Forms.ComboBox();
            this.txtOperand1 = new System.Windows.Forms.TextBox();
            this.txtOperant2 = new System.Windows.Forms.TextBox();
            this.txtOperator = new System.Windows.Forms.TextBox();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.Next = new System.Windows.Forms.Button();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.txtCorrectAnswer = new System.Windows.Forms.TextBox();
            this.lblSummary = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbLevel
            // 
            this.cbLevel.FormattingEnabled = true;
            this.cbLevel.Location = new System.Drawing.Point(168, 49);
            this.cbLevel.Name = "cbLevel";
            this.cbLevel.Size = new System.Drawing.Size(135, 24);
            this.cbLevel.TabIndex = 0;
            this.cbLevel.SelectedIndexChanged += new System.EventHandler(this.cbLevel_SelectedIndexChanged);
            // 
            // txtOperand1
            // 
            this.txtOperand1.Location = new System.Drawing.Point(168, 113);
            this.txtOperand1.Name = "txtOperand1";
            this.txtOperand1.ReadOnly = true;
            this.txtOperand1.Size = new System.Drawing.Size(135, 22);
            this.txtOperand1.TabIndex = 1;
            // 
            // txtOperant2
            // 
            this.txtOperant2.Location = new System.Drawing.Point(168, 199);
            this.txtOperant2.Name = "txtOperant2";
            this.txtOperant2.ReadOnly = true;
            this.txtOperant2.Size = new System.Drawing.Size(135, 22);
            this.txtOperant2.TabIndex = 2;
            // 
            // txtOperator
            // 
            this.txtOperator.Location = new System.Drawing.Point(168, 155);
            this.txtOperator.Name = "txtOperator";
            this.txtOperator.ReadOnly = true;
            this.txtOperator.Size = new System.Drawing.Size(40, 22);
            this.txtOperator.TabIndex = 3;
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(168, 247);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(135, 22);
            this.txtAnswer.TabIndex = 4;
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(362, 246);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(89, 23);
            this.Next.TabIndex = 5;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(87, 252);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(62, 17);
            this.lblAnswer.TabIndex = 6;
            this.lblAnswer.Text = "Answer :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Difficult Level:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Operand:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Operator:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Operand:";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(362, 51);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(100, 22);
            this.id.TabIndex = 11;
            this.id.Visible = false;
            // 
            // txtCorrectAnswer
            // 
            this.txtCorrectAnswer.Location = new System.Drawing.Point(362, 91);
            this.txtCorrectAnswer.Name = "txtCorrectAnswer";
            this.txtCorrectAnswer.Size = new System.Drawing.Size(100, 22);
            this.txtCorrectAnswer.TabIndex = 12;
            this.txtCorrectAnswer.Visible = false;
            // 
            // lblSummary
            // 
            this.lblSummary.AutoSize = true;
            this.lblSummary.Location = new System.Drawing.Point(149, 291);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(0, 17);
            this.lblSummary.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 415);
            this.Controls.Add(this.lblSummary);
            this.Controls.Add(this.txtCorrectAnswer);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.txtOperator);
            this.Controls.Add(this.txtOperant2);
            this.Controls.Add(this.txtOperand1);
            this.Controls.Add(this.cbLevel);
            this.Name = "Form1";
            this.Text = "MathQuiz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbLevel;
        private System.Windows.Forms.TextBox txtOperand1;
        private System.Windows.Forms.TextBox txtOperant2;
        private System.Windows.Forms.TextBox txtOperator;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox txtCorrectAnswer;
        private System.Windows.Forms.Label lblSummary;
    }
}

