namespace lab3
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
            this.mMethodLabel = new System.Windows.Forms.Label();
            this.mEquationLabel = new System.Windows.Forms.Label();
            this.mInputDateLabel = new System.Windows.Forms.Label();
            this.mA = new System.Windows.Forms.Label();
            this.mB = new System.Windows.Forms.Label();
            this.mEps = new System.Windows.Forms.Label();
            this.mKMax = new System.Windows.Forms.Label();
            this.mOutputDateLabel = new System.Windows.Forms.Label();
            this.mX = new System.Windows.Forms.Label();
            this.mCounterLabel = new System.Windows.Forms.Label();
            this.mMethodComboBox = new System.Windows.Forms.ComboBox();
            this.mEquationComboBox = new System.Windows.Forms.ComboBox();
            this.mATextBox = new System.Windows.Forms.TextBox();
            this.mBTextBox = new System.Windows.Forms.TextBox();
            this.mEpsTextBox = new System.Windows.Forms.TextBox();
            this.mKmaxTextBox = new System.Windows.Forms.TextBox();
            this.mXTextBox = new System.Windows.Forms.TextBox();
            this.mCounterTextBox = new System.Windows.Forms.TextBox();
            this.mSolveButton = new System.Windows.Forms.Button();
            this.mClearButton = new System.Windows.Forms.Button();
            this.mFXTextBox = new System.Windows.Forms.TextBox();
            this.mFXLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mMethodLabel
            // 
            this.mMethodLabel.AutoSize = true;
            this.mMethodLabel.Location = new System.Drawing.Point(32, 23);
            this.mMethodLabel.Name = "mMethodLabel";
            this.mMethodLabel.Size = new System.Drawing.Size(80, 13);
            this.mMethodLabel.TabIndex = 0;
            this.mMethodLabel.Text = "Оберіть метод";
            // 
            // mEquationLabel
            // 
            this.mEquationLabel.AutoSize = true;
            this.mEquationLabel.Location = new System.Drawing.Point(32, 106);
            this.mEquationLabel.Name = "mEquationLabel";
            this.mEquationLabel.Size = new System.Drawing.Size(93, 13);
            this.mEquationLabel.TabIndex = 1;
            this.mEquationLabel.Text = "Оберіть рівняння";
            // 
            // mInputDateLabel
            // 
            this.mInputDateLabel.AutoSize = true;
            this.mInputDateLabel.Location = new System.Drawing.Point(267, 23);
            this.mInputDateLabel.Name = "mInputDateLabel";
            this.mInputDateLabel.Size = new System.Drawing.Size(58, 13);
            this.mInputDateLabel.TabIndex = 2;
            this.mInputDateLabel.Text = "Вхідні дані";
            // 
            // mA
            // 
            this.mA.AutoSize = true;
            this.mA.Location = new System.Drawing.Point(202, 51);
            this.mA.Name = "mA";
            this.mA.Size = new System.Drawing.Size(25, 13);
            this.mA.TabIndex = 3;
            this.mA.Text = "a = ";
            // 
            // mB
            // 
            this.mB.AutoSize = true;
            this.mB.Location = new System.Drawing.Point(205, 92);
            this.mB.Name = "mB";
            this.mB.Size = new System.Drawing.Size(22, 13);
            this.mB.TabIndex = 4;
            this.mB.Text = "b =";
            // 
            // mEps
            // 
            this.mEps.AutoSize = true;
            this.mEps.Location = new System.Drawing.Point(194, 126);
            this.mEps.Name = "mEps";
            this.mEps.Size = new System.Drawing.Size(36, 13);
            this.mEps.TabIndex = 5;
            this.mEps.Text = "eps = ";
            // 
            // mKMax
            // 
            this.mKMax.AutoSize = true;
            this.mKMax.Location = new System.Drawing.Point(183, 160);
            this.mKMax.Name = "mKMax";
            this.mKMax.Size = new System.Drawing.Size(44, 13);
            this.mKMax.TabIndex = 6;
            this.mKMax.Text = "kmax = ";
            // 
            // mOutputDateLabel
            // 
            this.mOutputDateLabel.AutoSize = true;
            this.mOutputDateLabel.Location = new System.Drawing.Point(464, 23);
            this.mOutputDateLabel.Name = "mOutputDateLabel";
            this.mOutputDateLabel.Size = new System.Drawing.Size(64, 13);
            this.mOutputDateLabel.TabIndex = 7;
            this.mOutputDateLabel.Text = "Вихідні дані";
            // 
            // mX
            // 
            this.mX.AutoSize = true;
            this.mX.Location = new System.Drawing.Point(415, 51);
            this.mX.Name = "mX";
            this.mX.Size = new System.Drawing.Size(24, 13);
            this.mX.TabIndex = 8;
            this.mX.Text = "x = ";
            // 
            // mCounterLabel
            // 
            this.mCounterLabel.AutoSize = true;
            this.mCounterLabel.Location = new System.Drawing.Point(386, 89);
            this.mCounterLabel.Name = "mCounterLabel";
            this.mCounterLabel.Size = new System.Drawing.Size(53, 13);
            this.mCounterLabel.TabIndex = 9;
            this.mCounterLabel.Text = "Кількість";
            // 
            // mMethodComboBox
            // 
            this.mMethodComboBox.FormattingEnabled = true;
            this.mMethodComboBox.Items.AddRange(new object[] {
            "МПД",
            "Ньютон"});
            this.mMethodComboBox.Location = new System.Drawing.Point(12, 55);
            this.mMethodComboBox.Name = "mMethodComboBox";
            this.mMethodComboBox.Size = new System.Drawing.Size(111, 21);
            this.mMethodComboBox.TabIndex = 10;
            this.mMethodComboBox.SelectedIndexChanged += new System.EventHandler(this.mMethodComboBox_SelectedIndexChanged);
            // 
            // mEquationComboBox
            // 
            this.mEquationComboBox.FormattingEnabled = true;
            this.mEquationComboBox.Items.AddRange(new object[] {
            "x^2 - 4 = 0;",
            "e^(-x) - lg(1 - x^ 2) - 2 = 0;"});
            this.mEquationComboBox.Location = new System.Drawing.Point(15, 140);
            this.mEquationComboBox.Name = "mEquationComboBox";
            this.mEquationComboBox.Size = new System.Drawing.Size(110, 21);
            this.mEquationComboBox.TabIndex = 11;
            // 
            // mATextBox
            // 
            this.mATextBox.Location = new System.Drawing.Point(252, 47);
            this.mATextBox.Name = "mATextBox";
            this.mATextBox.Size = new System.Drawing.Size(100, 20);
            this.mATextBox.TabIndex = 12;
            // 
            // mBTextBox
            // 
            this.mBTextBox.Location = new System.Drawing.Point(252, 89);
            this.mBTextBox.Name = "mBTextBox";
            this.mBTextBox.Size = new System.Drawing.Size(100, 20);
            this.mBTextBox.TabIndex = 13;
            // 
            // mEpsTextBox
            // 
            this.mEpsTextBox.Location = new System.Drawing.Point(252, 123);
            this.mEpsTextBox.Name = "mEpsTextBox";
            this.mEpsTextBox.Size = new System.Drawing.Size(100, 20);
            this.mEpsTextBox.TabIndex = 14;
            // 
            // mKmaxTextBox
            // 
            this.mKmaxTextBox.Location = new System.Drawing.Point(252, 157);
            this.mKmaxTextBox.Name = "mKmaxTextBox";
            this.mKmaxTextBox.Size = new System.Drawing.Size(100, 20);
            this.mKmaxTextBox.TabIndex = 15;
            // 
            // mXTextBox
            // 
            this.mXTextBox.Location = new System.Drawing.Point(445, 48);
            this.mXTextBox.Name = "mXTextBox";
            this.mXTextBox.Size = new System.Drawing.Size(100, 20);
            this.mXTextBox.TabIndex = 16;
            // 
            // mCounterTextBox
            // 
            this.mCounterTextBox.Location = new System.Drawing.Point(445, 85);
            this.mCounterTextBox.Name = "mCounterTextBox";
            this.mCounterTextBox.Size = new System.Drawing.Size(100, 20);
            this.mCounterTextBox.TabIndex = 17;
            // 
            // mSolveButton
            // 
            this.mSolveButton.Location = new System.Drawing.Point(389, 140);
            this.mSolveButton.Name = "mSolveButton";
            this.mSolveButton.Size = new System.Drawing.Size(87, 33);
            this.mSolveButton.TabIndex = 18;
            this.mSolveButton.Text = "Розв\'язати";
            this.mSolveButton.UseVisualStyleBackColor = true;
            this.mSolveButton.Click += new System.EventHandler(this.mSolveButton_Click);
            // 
            // mClearButton
            // 
            this.mClearButton.Location = new System.Drawing.Point(491, 140);
            this.mClearButton.Name = "mClearButton";
            this.mClearButton.Size = new System.Drawing.Size(92, 33);
            this.mClearButton.TabIndex = 19;
            this.mClearButton.Text = "Очистити";
            this.mClearButton.UseVisualStyleBackColor = true;
            this.mClearButton.Click += new System.EventHandler(this.mClearButton_Click);
            // 
            // mFXTextBox
            // 
            this.mFXTextBox.Location = new System.Drawing.Point(445, 114);
            this.mFXTextBox.Name = "mFXTextBox";
            this.mFXTextBox.Size = new System.Drawing.Size(100, 20);
            this.mFXTextBox.TabIndex = 20;
            // 
            // mFXLabel
            // 
            this.mFXLabel.AutoSize = true;
            this.mFXLabel.Location = new System.Drawing.Point(404, 117);
            this.mFXLabel.Name = "mFXLabel";
            this.mFXLabel.Size = new System.Drawing.Size(33, 13);
            this.mFXLabel.TabIndex = 21;
            this.mFXLabel.Text = "f(x) = ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 185);
            this.Controls.Add(this.mFXLabel);
            this.Controls.Add(this.mFXTextBox);
            this.Controls.Add(this.mClearButton);
            this.Controls.Add(this.mSolveButton);
            this.Controls.Add(this.mCounterTextBox);
            this.Controls.Add(this.mXTextBox);
            this.Controls.Add(this.mKmaxTextBox);
            this.Controls.Add(this.mEpsTextBox);
            this.Controls.Add(this.mBTextBox);
            this.Controls.Add(this.mATextBox);
            this.Controls.Add(this.mEquationComboBox);
            this.Controls.Add(this.mMethodComboBox);
            this.Controls.Add(this.mCounterLabel);
            this.Controls.Add(this.mX);
            this.Controls.Add(this.mOutputDateLabel);
            this.Controls.Add(this.mKMax);
            this.Controls.Add(this.mEps);
            this.Controls.Add(this.mB);
            this.Controls.Add(this.mA);
            this.Controls.Add(this.mInputDateLabel);
            this.Controls.Add(this.mEquationLabel);
            this.Controls.Add(this.mMethodLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mMethodLabel;
        private System.Windows.Forms.Label mEquationLabel;
        private System.Windows.Forms.Label mInputDateLabel;
        private System.Windows.Forms.Label mA;
        private System.Windows.Forms.Label mB;
        private System.Windows.Forms.Label mEps;
        private System.Windows.Forms.Label mKMax;
        private System.Windows.Forms.Label mOutputDateLabel;
        private System.Windows.Forms.Label mX;
        private System.Windows.Forms.Label mCounterLabel;
        private System.Windows.Forms.ComboBox mMethodComboBox;
        private System.Windows.Forms.ComboBox mEquationComboBox;
        private System.Windows.Forms.TextBox mATextBox;
        private System.Windows.Forms.TextBox mBTextBox;
        private System.Windows.Forms.TextBox mEpsTextBox;
        private System.Windows.Forms.TextBox mKmaxTextBox;
        private System.Windows.Forms.TextBox mXTextBox;
        private System.Windows.Forms.TextBox mCounterTextBox;
        private System.Windows.Forms.Button mSolveButton;
        private System.Windows.Forms.Button mClearButton;
        private System.Windows.Forms.TextBox mFXTextBox;
        private System.Windows.Forms.Label mFXLabel;
    }
}

