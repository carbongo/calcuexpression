namespace CalcuExpression
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox_Result = new TextBox();
            digit1 = new Button();
            digit2 = new Button();
            digit3 = new Button();
            digit4 = new Button();
            digit5 = new Button();
            digit6 = new Button();
            digit7 = new Button();
            digit8 = new Button();
            digit9 = new Button();
            digit0 = new Button();
            decimalPoint = new Button();
            operationAdd = new Button();
            operationEqual = new Button();
            operationSubtract = new Button();
            operationMultiply = new Button();
            operationDivide = new Button();
            operationClear = new Button();
            operationDefine = new Button();
            variableX = new Button();
            variableY = new Button();
            variableZ = new Button();
            textBox_Definition = new TextBox();
            label1 = new Label();
            label2 = new Label();
            bracketOpen = new Button();
            bracketClose = new Button();
            buttonSin = new Button();
            buttonLn = new Button();
            buttonCos = new Button();
            buttonLog = new Button();
            buttonPercent = new Button();
            buttonFactorial = new Button();
            buttonSqrt = new Button();
            buttonExp = new Button();
            buttonTan = new Button();
            SuspendLayout();
            // 
            // textBox_Result
            // 
            textBox_Result.Location = new Point(13, 29);
            textBox_Result.Name = "textBox_Result";
            textBox_Result.Size = new Size(214, 23);
            textBox_Result.TabIndex = 0;
            textBox_Result.GotFocus += textBox_Result_GotFocus;
            // 
            // digit1
            // 
            digit1.Location = new Point(13, 210);
            digit1.Name = "digit1";
            digit1.Size = new Size(49, 45);
            digit1.TabIndex = 1;
            digit1.Text = "1";
            digit1.UseVisualStyleBackColor = true;
            digit1.Click += button_Click;
            // 
            // digit2
            // 
            digit2.Location = new Point(68, 210);
            digit2.Name = "digit2";
            digit2.Size = new Size(49, 45);
            digit2.TabIndex = 2;
            digit2.Text = "2";
            digit2.UseVisualStyleBackColor = true;
            digit2.Click += button_Click;
            // 
            // digit3
            // 
            digit3.Location = new Point(123, 210);
            digit3.Name = "digit3";
            digit3.Size = new Size(49, 45);
            digit3.TabIndex = 3;
            digit3.Text = "3";
            digit3.UseVisualStyleBackColor = true;
            digit3.Click += button_Click;
            // 
            // digit4
            // 
            digit4.Location = new Point(13, 159);
            digit4.Name = "digit4";
            digit4.Size = new Size(49, 45);
            digit4.TabIndex = 4;
            digit4.Text = "4";
            digit4.UseVisualStyleBackColor = true;
            digit4.Click += button_Click;
            // 
            // digit5
            // 
            digit5.Location = new Point(68, 159);
            digit5.Name = "digit5";
            digit5.Size = new Size(49, 45);
            digit5.TabIndex = 5;
            digit5.Text = "5";
            digit5.UseVisualStyleBackColor = true;
            digit5.Click += button_Click;
            // 
            // digit6
            // 
            digit6.Location = new Point(123, 159);
            digit6.Name = "digit6";
            digit6.Size = new Size(49, 45);
            digit6.TabIndex = 6;
            digit6.Text = "6";
            digit6.UseVisualStyleBackColor = true;
            digit6.Click += button_Click;
            // 
            // digit7
            // 
            digit7.Location = new Point(13, 108);
            digit7.Name = "digit7";
            digit7.Size = new Size(49, 45);
            digit7.TabIndex = 7;
            digit7.Text = "7";
            digit7.UseVisualStyleBackColor = true;
            digit7.Click += button_Click;
            // 
            // digit8
            // 
            digit8.Location = new Point(68, 108);
            digit8.Name = "digit8";
            digit8.Size = new Size(49, 45);
            digit8.TabIndex = 8;
            digit8.Text = "8";
            digit8.UseVisualStyleBackColor = true;
            digit8.Click += button_Click;
            // 
            // digit9
            // 
            digit9.Location = new Point(123, 108);
            digit9.Name = "digit9";
            digit9.Size = new Size(49, 45);
            digit9.TabIndex = 9;
            digit9.Text = "9";
            digit9.UseVisualStyleBackColor = true;
            digit9.Click += button_Click;
            // 
            // digit0
            // 
            digit0.Location = new Point(13, 261);
            digit0.Name = "digit0";
            digit0.Size = new Size(104, 45);
            digit0.TabIndex = 10;
            digit0.Text = "0";
            digit0.UseVisualStyleBackColor = true;
            digit0.Click += button_Click;
            // 
            // decimalPoint
            // 
            decimalPoint.Location = new Point(123, 261);
            decimalPoint.Name = "decimalPoint";
            decimalPoint.Size = new Size(49, 45);
            decimalPoint.TabIndex = 11;
            decimalPoint.Text = ".";
            decimalPoint.UseVisualStyleBackColor = true;
            decimalPoint.Click += button_Click;
            // 
            // operationAdd
            // 
            operationAdd.BackColor = SystemColors.ControlLight;
            operationAdd.Location = new Point(178, 108);
            operationAdd.Name = "operationAdd";
            operationAdd.Size = new Size(49, 96);
            operationAdd.TabIndex = 12;
            operationAdd.Text = "+";
            operationAdd.UseVisualStyleBackColor = false;
            operationAdd.Click += button_Click;
            // 
            // operationEqual
            // 
            operationEqual.BackColor = SystemColors.ControlLight;
            operationEqual.Location = new Point(178, 210);
            operationEqual.Name = "operationEqual";
            operationEqual.Size = new Size(49, 96);
            operationEqual.TabIndex = 13;
            operationEqual.Text = "=";
            operationEqual.UseVisualStyleBackColor = false;
            operationEqual.Click += operationEqual_Click;
            // 
            // operationSubtract
            // 
            operationSubtract.BackColor = SystemColors.ControlLight;
            operationSubtract.Location = new Point(178, 58);
            operationSubtract.Name = "operationSubtract";
            operationSubtract.Size = new Size(49, 45);
            operationSubtract.TabIndex = 14;
            operationSubtract.Text = "-";
            operationSubtract.UseVisualStyleBackColor = false;
            operationSubtract.Click += button_Click;
            // 
            // operationMultiply
            // 
            operationMultiply.BackColor = SystemColors.ControlLight;
            operationMultiply.Location = new Point(123, 58);
            operationMultiply.Name = "operationMultiply";
            operationMultiply.Size = new Size(49, 45);
            operationMultiply.TabIndex = 15;
            operationMultiply.Text = "*";
            operationMultiply.UseVisualStyleBackColor = false;
            operationMultiply.Click += button_Click;
            // 
            // operationDivide
            // 
            operationDivide.BackColor = SystemColors.ControlLight;
            operationDivide.Location = new Point(68, 58);
            operationDivide.Name = "operationDivide";
            operationDivide.Size = new Size(49, 45);
            operationDivide.TabIndex = 16;
            operationDivide.Text = "/";
            operationDivide.UseVisualStyleBackColor = false;
            operationDivide.Click += button_Click;
            // 
            // operationClear
            // 
            operationClear.BackColor = SystemColors.ControlLight;
            operationClear.Location = new Point(13, 58);
            operationClear.Name = "operationClear";
            operationClear.Size = new Size(49, 45);
            operationClear.TabIndex = 17;
            operationClear.Text = "C";
            operationClear.UseVisualStyleBackColor = false;
            operationClear.Click += operationClear_Click;
            // 
            // operationDefine
            // 
            operationDefine.BackColor = SystemColors.ControlLight;
            operationDefine.Location = new Point(398, 58);
            operationDefine.Name = "operationDefine";
            operationDefine.Size = new Size(49, 45);
            operationDefine.TabIndex = 18;
            operationDefine.Text = "Define";
            operationDefine.UseVisualStyleBackColor = false;
            operationDefine.Click += operationDefine_Click;
            // 
            // variableX
            // 
            variableX.BackColor = SystemColors.ControlLight;
            variableX.Location = new Point(233, 58);
            variableX.Name = "variableX";
            variableX.Size = new Size(49, 45);
            variableX.TabIndex = 19;
            variableX.Text = "x";
            variableX.UseVisualStyleBackColor = false;
            variableX.Click += button_Click;
            // 
            // variableY
            // 
            variableY.BackColor = SystemColors.ControlLight;
            variableY.Location = new Point(288, 58);
            variableY.Name = "variableY";
            variableY.Size = new Size(49, 45);
            variableY.TabIndex = 20;
            variableY.Text = "y";
            variableY.UseVisualStyleBackColor = false;
            variableY.Click += button_Click;
            // 
            // variableZ
            // 
            variableZ.BackColor = SystemColors.ControlLight;
            variableZ.Location = new Point(343, 58);
            variableZ.Name = "variableZ";
            variableZ.Size = new Size(49, 45);
            variableZ.TabIndex = 21;
            variableZ.Text = "z";
            variableZ.UseVisualStyleBackColor = false;
            variableZ.Click += button_Click;
            // 
            // textBox_Definition
            // 
            textBox_Definition.Location = new Point(233, 29);
            textBox_Definition.Name = "textBox_Definition";
            textBox_Definition.Size = new Size(214, 23);
            textBox_Definition.TabIndex = 22;
            textBox_Definition.GotFocus += textBox_Definition_GotFocus;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(233, 9);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 23;
            label1.Text = "Define";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 11);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 24;
            label2.Text = "Main input";
            // 
            // bracketOpen
            // 
            bracketOpen.BackColor = SystemColors.ControlLight;
            bracketOpen.Location = new Point(233, 108);
            bracketOpen.Name = "bracketOpen";
            bracketOpen.Size = new Size(49, 45);
            bracketOpen.TabIndex = 25;
            bracketOpen.Text = "(";
            bracketOpen.UseVisualStyleBackColor = false;
            bracketOpen.Click += button_Click;
            // 
            // bracketClose
            // 
            bracketClose.BackColor = SystemColors.ControlLight;
            bracketClose.Location = new Point(288, 108);
            bracketClose.Name = "bracketClose";
            bracketClose.Size = new Size(49, 45);
            bracketClose.TabIndex = 26;
            bracketClose.Text = ")";
            bracketClose.UseVisualStyleBackColor = false;
            bracketClose.Click += button_Click;
            // 
            // buttonSin
            // 
            buttonSin.BackColor = SystemColors.ControlLight;
            buttonSin.Location = new Point(233, 159);
            buttonSin.Name = "buttonSin";
            buttonSin.Size = new Size(49, 45);
            buttonSin.TabIndex = 27;
            buttonSin.Text = "sin";
            buttonSin.UseVisualStyleBackColor = false;
            buttonSin.Click += buttonSin_Click;
            // 
            // buttonLn
            // 
            buttonLn.BackColor = SystemColors.ControlLight;
            buttonLn.Location = new Point(288, 159);
            buttonLn.Name = "buttonLn";
            buttonLn.Size = new Size(49, 45);
            buttonLn.TabIndex = 28;
            buttonLn.Text = "ln";
            buttonLn.UseVisualStyleBackColor = false;
            buttonLn.Click += buttonLn_Click;
            // 
            // buttonCos
            // 
            buttonCos.BackColor = SystemColors.ControlLight;
            buttonCos.Location = new Point(233, 210);
            buttonCos.Name = "buttonCos";
            buttonCos.Size = new Size(49, 45);
            buttonCos.TabIndex = 29;
            buttonCos.Text = "cos";
            buttonCos.UseVisualStyleBackColor = false;
            buttonCos.Click += button_Click;
            // 
            // buttonLog
            // 
            buttonLog.BackColor = SystemColors.ControlLight;
            buttonLog.Location = new Point(288, 210);
            buttonLog.Name = "buttonLog";
            buttonLog.Size = new Size(49, 45);
            buttonLog.TabIndex = 30;
            buttonLog.Text = "log";
            buttonLog.UseVisualStyleBackColor = false;
            buttonLog.Click += buttonLog_Click;
            // 
            // buttonPercent
            // 
            buttonPercent.BackColor = SystemColors.ControlLight;
            buttonPercent.Location = new Point(343, 108);
            buttonPercent.Name = "buttonPercent";
            buttonPercent.Size = new Size(49, 45);
            buttonPercent.TabIndex = 31;
            buttonPercent.Text = "%";
            buttonPercent.UseVisualStyleBackColor = false;
            // 
            // buttonFactorial
            // 
            buttonFactorial.BackColor = SystemColors.ControlLight;
            buttonFactorial.Location = new Point(398, 108);
            buttonFactorial.Name = "buttonFactorial";
            buttonFactorial.Size = new Size(49, 45);
            buttonFactorial.TabIndex = 32;
            buttonFactorial.Text = "x!";
            buttonFactorial.UseVisualStyleBackColor = false;
            buttonFactorial.Click += buttonFactorial_Click;
            // 
            // buttonSqrt
            // 
            buttonSqrt.BackColor = SystemColors.ControlLight;
            buttonSqrt.Location = new Point(343, 159);
            buttonSqrt.Name = "buttonSqrt";
            buttonSqrt.Size = new Size(49, 45);
            buttonSqrt.TabIndex = 33;
            buttonSqrt.Text = "sqrt";
            buttonSqrt.UseVisualStyleBackColor = false;
            buttonSqrt.Click += buttonSqrt_Click;
            // 
            // buttonExp
            // 
            buttonExp.BackColor = SystemColors.ControlLight;
            buttonExp.Location = new Point(398, 159);
            buttonExp.Name = "buttonExp";
            buttonExp.Size = new Size(49, 45);
            buttonExp.TabIndex = 34;
            buttonExp.Text = "exp";
            buttonExp.UseVisualStyleBackColor = false;
            buttonExp.Click += buttonExp_Click;
            // 
            // buttonTan
            // 
            buttonTan.BackColor = SystemColors.ControlLight;
            buttonTan.Location = new Point(233, 261);
            buttonTan.Name = "buttonTan";
            buttonTan.Size = new Size(49, 45);
            buttonTan.TabIndex = 37;
            buttonTan.Text = "tan";
            buttonTan.UseVisualStyleBackColor = false;
            buttonTan.Click += buttonTan_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 320);
            Controls.Add(buttonTan);
            Controls.Add(buttonExp);
            Controls.Add(buttonSqrt);
            Controls.Add(buttonFactorial);
            Controls.Add(buttonPercent);
            Controls.Add(buttonLog);
            Controls.Add(buttonCos);
            Controls.Add(buttonLn);
            Controls.Add(buttonSin);
            Controls.Add(bracketClose);
            Controls.Add(bracketOpen);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(operationDefine);
            Controls.Add(textBox_Definition);
            Controls.Add(variableZ);
            Controls.Add(variableY);
            Controls.Add(operationClear);
            Controls.Add(variableX);
            Controls.Add(operationDivide);
            Controls.Add(operationMultiply);
            Controls.Add(operationSubtract);
            Controls.Add(operationEqual);
            Controls.Add(operationAdd);
            Controls.Add(decimalPoint);
            Controls.Add(digit0);
            Controls.Add(digit9);
            Controls.Add(digit8);
            Controls.Add(digit7);
            Controls.Add(digit6);
            Controls.Add(digit5);
            Controls.Add(digit4);
            Controls.Add(digit3);
            Controls.Add(digit2);
            Controls.Add(digit1);
            Controls.Add(textBox_Result);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "CalcuExpression";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_Result;
        private Button digit1;
        private Button digit2;
        private Button digit3;
        private Button digit4;
        private Button digit5;
        private Button digit6;
        private Button digit7;
        private Button digit8;
        private Button digit9;
        private Button digit0;
        private Button decimalPoint;
        private Button operationAdd;
        private Button operationEqual;
        private Button operationSubtract;
        private Button operationMultiply;
        private Button operationDivide;
        private Button operationClear;
        private Button operationDefine;
        private Button variableX;
        private Button variableY;
        private Button variableZ;
        private TextBox textBox_Definition;
        private Label label1;
        private Label label2;
        private Button bracketOpen;
        private Button bracketClose;
        private Button buttonSin;
        private Button buttonLn;
        private Button buttonCos;
        private Button buttonLog;
        private Button buttonPercent;
        private Button buttonFactorial;
        private Button buttonExp;
        private Button buttonTan;
        private Button buttonSqrt;
    }
}
