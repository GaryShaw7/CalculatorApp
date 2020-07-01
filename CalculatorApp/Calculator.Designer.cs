namespace CalculatorApp
{
    partial class frmScreen1
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblValue1 = new System.Windows.Forms.Label();
            this.lblValue2 = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.Operators = new System.Windows.Forms.ListBox();
            this.rdoAdd = new System.Windows.Forms.RadioButton();
            this.rdoSubtract = new System.Windows.Forms.RadioButton();
            this.rdoMultiply = new System.Windows.Forms.RadioButton();
            this.rdoDivide = new System.Windows.Forms.RadioButton();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(650, 409);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(138, 44);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(324, 293);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(138, 44);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // lblValue1
            // 
            this.lblValue1.AutoSize = true;
            this.lblValue1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValue1.Location = new System.Drawing.Point(83, 74);
            this.lblValue1.Name = "lblValue1";
            this.lblValue1.Size = new System.Drawing.Size(119, 32);
            this.lblValue1.TabIndex = 2;
            this.lblValue1.Text = "Value 1";
            // 
            // lblValue2
            // 
            this.lblValue2.AutoSize = true;
            this.lblValue2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValue2.Location = new System.Drawing.Point(83, 141);
            this.lblValue2.Name = "lblValue2";
            this.lblValue2.Size = new System.Drawing.Size(127, 32);
            this.lblValue2.TabIndex = 3;
            this.lblValue2.Text = "Value 2 ";
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.Location = new System.Drawing.Point(83, 210);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(115, 32);
            this.lblAnswer.TabIndex = 4;
            this.lblAnswer.Text = "Answer";
            // 
            // txtNum1
            // 
            this.txtNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum1.Location = new System.Drawing.Point(324, 74);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(184, 38);
            this.txtNum1.TabIndex = 5;
            // 
            // txtNum2
            // 
            this.txtNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum2.Location = new System.Drawing.Point(324, 146);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(184, 38);
            this.txtNum2.TabIndex = 6;
            // 
            // Operators
            // 
            this.Operators.BackColor = System.Drawing.SystemColors.Menu;
            this.Operators.FormattingEnabled = true;
            this.Operators.ItemHeight = 16;
            this.Operators.Location = new System.Drawing.Point(89, 280);
            this.Operators.Name = "Operators";
            this.Operators.Size = new System.Drawing.Size(178, 180);
            this.Operators.TabIndex = 8;
            // 
            // rdoAdd
            // 
            this.rdoAdd.AutoSize = true;
            this.rdoAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoAdd.Location = new System.Drawing.Point(100, 316);
            this.rdoAdd.Name = "rdoAdd";
            this.rdoAdd.Size = new System.Drawing.Size(69, 29);
            this.rdoAdd.TabIndex = 9;
            this.rdoAdd.TabStop = true;
            this.rdoAdd.Text = "Add";
            this.rdoAdd.UseVisualStyleBackColor = true;
            // 
            // rdoSubtract
            // 
            this.rdoSubtract.AutoSize = true;
            this.rdoSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSubtract.Location = new System.Drawing.Point(100, 352);
            this.rdoSubtract.Name = "rdoSubtract";
            this.rdoSubtract.Size = new System.Drawing.Size(106, 29);
            this.rdoSubtract.TabIndex = 10;
            this.rdoSubtract.TabStop = true;
            this.rdoSubtract.Text = "Subtract";
            this.rdoSubtract.UseVisualStyleBackColor = true;
            // 
            // rdoMultiply
            // 
            this.rdoMultiply.AutoSize = true;
            this.rdoMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoMultiply.Location = new System.Drawing.Point(100, 388);
            this.rdoMultiply.Name = "rdoMultiply";
            this.rdoMultiply.Size = new System.Drawing.Size(99, 29);
            this.rdoMultiply.TabIndex = 11;
            this.rdoMultiply.TabStop = true;
            this.rdoMultiply.Text = "Multiply";
            this.rdoMultiply.UseVisualStyleBackColor = true;
            // 
            // rdoDivide
            // 
            this.rdoDivide.AutoSize = true;
            this.rdoDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoDivide.Location = new System.Drawing.Point(100, 424);
            this.rdoDivide.Name = "rdoDivide";
            this.rdoDivide.Size = new System.Drawing.Size(87, 29);
            this.rdoDivide.TabIndex = 12;
            this.rdoDivide.TabStop = true;
            this.rdoDivide.Text = "Divide";
            this.rdoDivide.UseVisualStyleBackColor = true;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(334, 224);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 32);
            this.lblResult.TabIndex = 13;
            // 
            // frmScreen1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 511);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.rdoDivide);
            this.Controls.Add(this.rdoMultiply);
            this.Controls.Add(this.rdoSubtract);
            this.Controls.Add(this.rdoAdd);
            this.Controls.Add(this.Operators);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblValue2);
            this.Controls.Add(this.lblValue1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnExit);
            this.Name = "frmScreen1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Calculator screen 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblValue1;
        private System.Windows.Forms.Label lblValue2;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.ListBox Operators;
        private System.Windows.Forms.RadioButton rdoAdd;
        private System.Windows.Forms.RadioButton rdoSubtract;
        private System.Windows.Forms.RadioButton rdoMultiply;
        private System.Windows.Forms.RadioButton rdoDivide;
        private System.Windows.Forms.Label lblResult;
    }
}

