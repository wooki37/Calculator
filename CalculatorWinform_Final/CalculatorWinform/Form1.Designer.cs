namespace CalculatorWinform
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMC = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnPlusMinus = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnTimes = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnSqr = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnRecip = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.btnMS = new System.Windows.Forms.Button();
            this.btnMMinus = new System.Windows.Forms.Button();
            this.btnMPlus = new System.Windows.Forms.Button();
            this.btnMR = new System.Windows.Forms.Button();
            this.txtExp = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnMC
            // 
            this.btnMC.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMC.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMC.FlatAppearance.BorderSize = 0;
            this.btnMC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMC.Location = new System.Drawing.Point(45, 135);
            this.btnMC.Name = "btnMC";
            this.btnMC.Size = new System.Drawing.Size(97, 44);
            this.btnMC.TabIndex = 1;
            this.btnMC.Text = "MC";
            this.btnMC.UseVisualStyleBackColor = false;
            this.btnMC.Click += new System.EventHandler(this.btnMC_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.White;
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("굴림", 14F);
            this.btn1.Location = new System.Drawing.Point(45, 484);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(117, 68);
            this.btn1.TabIndex = 23;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.White;
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("굴림", 14F);
            this.btn2.Location = new System.Drawing.Point(178, 484);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(117, 68);
            this.btn2.TabIndex = 24;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.White;
            this.btn3.FlatAppearance.BorderSize = 0;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("굴림", 14F);
            this.btn3.Location = new System.Drawing.Point(311, 484);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(117, 68);
            this.btn3.TabIndex = 25;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.White;
            this.btn6.FlatAppearance.BorderSize = 0;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("굴림", 14F);
            this.btn6.Location = new System.Drawing.Point(311, 407);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(117, 68);
            this.btn6.TabIndex = 28;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.White;
            this.btn5.FlatAppearance.BorderSize = 0;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("굴림", 14F);
            this.btn5.Location = new System.Drawing.Point(178, 407);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(117, 68);
            this.btn5.TabIndex = 27;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.White;
            this.btn4.FlatAppearance.BorderSize = 0;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("굴림", 14F);
            this.btn4.Location = new System.Drawing.Point(45, 407);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(117, 68);
            this.btn4.TabIndex = 26;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.White;
            this.btn9.FlatAppearance.BorderSize = 0;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("굴림", 14F);
            this.btn9.Location = new System.Drawing.Point(311, 333);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(117, 68);
            this.btn9.TabIndex = 31;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.White;
            this.btn8.FlatAppearance.BorderSize = 0;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("굴림", 14F);
            this.btn8.Location = new System.Drawing.Point(178, 333);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(117, 68);
            this.btn8.TabIndex = 30;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.White;
            this.btn7.FlatAppearance.BorderSize = 0;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("굴림", 14F);
            this.btn7.Location = new System.Drawing.Point(45, 333);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(117, 68);
            this.btn7.TabIndex = 29;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnDot
            // 
            this.btnDot.BackColor = System.Drawing.Color.White;
            this.btnDot.FlatAppearance.BorderSize = 0;
            this.btnDot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDot.Font = new System.Drawing.Font("굴림", 14F);
            this.btnDot.Location = new System.Drawing.Point(311, 558);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(117, 68);
            this.btnDot.TabIndex = 34;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = false;
            this.btnDot.Click += new System.EventHandler(this.btnDot_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.White;
            this.btn0.FlatAppearance.BorderSize = 0;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Font = new System.Drawing.Font("굴림", 14F);
            this.btn0.Location = new System.Drawing.Point(178, 558);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(117, 68);
            this.btn0.TabIndex = 33;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnPlusMinus
            // 
            this.btnPlusMinus.BackColor = System.Drawing.Color.White;
            this.btnPlusMinus.FlatAppearance.BorderSize = 0;
            this.btnPlusMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlusMinus.Font = new System.Drawing.Font("굴림", 14F);
            this.btnPlusMinus.Location = new System.Drawing.Point(45, 558);
            this.btnPlusMinus.Name = "btnPlusMinus";
            this.btnPlusMinus.Size = new System.Drawing.Size(117, 68);
            this.btnPlusMinus.TabIndex = 32;
            this.btnPlusMinus.Text = "+/-";
            this.btnPlusMinus.UseVisualStyleBackColor = false;
            this.btnPlusMinus.Click += new System.EventHandler(this.btnPlusMinus_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEqual.FlatAppearance.BorderSize = 0;
            this.btnEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEqual.Font = new System.Drawing.Font("굴림", 14F);
            this.btnEqual.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEqual.Location = new System.Drawing.Point(447, 558);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(117, 68);
            this.btnEqual.TabIndex = 38;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = false;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.Gainsboro;
            this.btnPlus.FlatAppearance.BorderSize = 0;
            this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlus.Font = new System.Drawing.Font("굴림", 14F);
            this.btnPlus.Location = new System.Drawing.Point(447, 484);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(117, 68);
            this.btnPlus.TabIndex = 35;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnTimes
            // 
            this.btnTimes.BackColor = System.Drawing.Color.Gainsboro;
            this.btnTimes.FlatAppearance.BorderSize = 0;
            this.btnTimes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimes.Font = new System.Drawing.Font("굴림", 14F);
            this.btnTimes.Location = new System.Drawing.Point(447, 333);
            this.btnTimes.Name = "btnTimes";
            this.btnTimes.Size = new System.Drawing.Size(117, 68);
            this.btnTimes.TabIndex = 39;
            this.btnTimes.Text = "x";
            this.btnTimes.UseVisualStyleBackColor = false;
            this.btnTimes.Click += new System.EventHandler(this.btnTimes_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.Color.Gainsboro;
            this.btnMinus.FlatAppearance.BorderSize = 0;
            this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinus.Font = new System.Drawing.Font("굴림", 14F);
            this.btnMinus.Location = new System.Drawing.Point(447, 407);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(117, 68);
            this.btnMinus.TabIndex = 40;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDivide.FlatAppearance.BorderSize = 0;
            this.btnDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDivide.Font = new System.Drawing.Font("굴림", 14F);
            this.btnDivide.Location = new System.Drawing.Point(447, 259);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(117, 68);
            this.btnDivide.TabIndex = 42;
            this.btnDivide.Text = "÷";
            this.btnDivide.UseVisualStyleBackColor = false;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("굴림", 14F);
            this.btnDelete.Location = new System.Drawing.Point(447, 185);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(117, 68);
            this.btnDelete.TabIndex = 41;
            this.btnDelete.Text = "Del";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSqrt
            // 
            this.btnSqrt.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSqrt.FlatAppearance.BorderSize = 0;
            this.btnSqrt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSqrt.Font = new System.Drawing.Font("굴림", 14F);
            this.btnSqrt.Location = new System.Drawing.Point(311, 259);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(117, 68);
            this.btnSqrt.TabIndex = 44;
            this.btnSqrt.Text = "2√x";
            this.btnSqrt.UseVisualStyleBackColor = false;
            this.btnSqrt.Click += new System.EventHandler(this.btnSqrt_Click);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.Color.Gainsboro;
            this.btnC.FlatAppearance.BorderSize = 0;
            this.btnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnC.Font = new System.Drawing.Font("굴림", 14F);
            this.btnC.Location = new System.Drawing.Point(311, 185);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(117, 68);
            this.btnC.TabIndex = 43;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnSqr
            // 
            this.btnSqr.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSqr.FlatAppearance.BorderSize = 0;
            this.btnSqr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSqr.Font = new System.Drawing.Font("굴림", 14F);
            this.btnSqr.Location = new System.Drawing.Point(178, 259);
            this.btnSqr.Name = "btnSqr";
            this.btnSqr.Size = new System.Drawing.Size(117, 68);
            this.btnSqr.TabIndex = 46;
            this.btnSqr.Text = "x²";
            this.btnSqr.UseVisualStyleBackColor = false;
            this.btnSqr.Click += new System.EventHandler(this.btnSqr_Click);
            // 
            // btnCE
            // 
            this.btnCE.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCE.FlatAppearance.BorderSize = 0;
            this.btnCE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCE.Font = new System.Drawing.Font("굴림", 14F);
            this.btnCE.Location = new System.Drawing.Point(178, 185);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(117, 68);
            this.btnCE.TabIndex = 45;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = false;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnRecip
            // 
            this.btnRecip.BackColor = System.Drawing.Color.Gainsboro;
            this.btnRecip.FlatAppearance.BorderSize = 0;
            this.btnRecip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecip.Font = new System.Drawing.Font("굴림", 14F);
            this.btnRecip.Location = new System.Drawing.Point(45, 259);
            this.btnRecip.Name = "btnRecip";
            this.btnRecip.Size = new System.Drawing.Size(117, 68);
            this.btnRecip.TabIndex = 48;
            this.btnRecip.Text = "1/x";
            this.btnRecip.UseVisualStyleBackColor = false;
            this.btnRecip.Click += new System.EventHandler(this.btnRecip_Click);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.Gainsboro;
            this.button16.FlatAppearance.BorderSize = 0;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Font = new System.Drawing.Font("굴림", 14F);
            this.button16.Location = new System.Drawing.Point(45, 185);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(117, 68);
            this.button16.TabIndex = 47;
            this.button16.Text = "%";
            this.button16.UseVisualStyleBackColor = false;
            // 
            // btnMS
            // 
            this.btnMS.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMS.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMS.FlatAppearance.BorderSize = 0;
            this.btnMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMS.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMS.Location = new System.Drawing.Point(457, 135);
            this.btnMS.Name = "btnMS";
            this.btnMS.Size = new System.Drawing.Size(97, 44);
            this.btnMS.TabIndex = 49;
            this.btnMS.Text = "MS";
            this.btnMS.UseVisualStyleBackColor = false;
            this.btnMS.Click += new System.EventHandler(this.btnMS_Click);
            // 
            // btnMMinus
            // 
            this.btnMMinus.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMMinus.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMMinus.FlatAppearance.BorderSize = 0;
            this.btnMMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMMinus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMMinus.Location = new System.Drawing.Point(354, 135);
            this.btnMMinus.Name = "btnMMinus";
            this.btnMMinus.Size = new System.Drawing.Size(97, 44);
            this.btnMMinus.TabIndex = 50;
            this.btnMMinus.Text = "M-";
            this.btnMMinus.UseVisualStyleBackColor = false;
            this.btnMMinus.Click += new System.EventHandler(this.btnMMinus_Click);
            // 
            // btnMPlus
            // 
            this.btnMPlus.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMPlus.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMPlus.FlatAppearance.BorderSize = 0;
            this.btnMPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMPlus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMPlus.Location = new System.Drawing.Point(251, 135);
            this.btnMPlus.Name = "btnMPlus";
            this.btnMPlus.Size = new System.Drawing.Size(97, 44);
            this.btnMPlus.TabIndex = 51;
            this.btnMPlus.Text = "M+";
            this.btnMPlus.UseVisualStyleBackColor = false;
            this.btnMPlus.Click += new System.EventHandler(this.btnMPlus_Click);
            // 
            // btnMR
            // 
            this.btnMR.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMR.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMR.FlatAppearance.BorderSize = 0;
            this.btnMR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMR.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMR.Location = new System.Drawing.Point(148, 135);
            this.btnMR.Name = "btnMR";
            this.btnMR.Size = new System.Drawing.Size(97, 44);
            this.btnMR.TabIndex = 52;
            this.btnMR.Text = "MR";
            this.btnMR.UseVisualStyleBackColor = false;
            this.btnMR.Click += new System.EventHandler(this.btnMR_Click);
            // 
            // txtExp
            // 
            this.txtExp.BackColor = System.Drawing.SystemColors.Window;
            this.txtExp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtExp.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtExp.Location = new System.Drawing.Point(42, 26);
            this.txtExp.Name = "txtExp";
            this.txtExp.Size = new System.Drawing.Size(522, 34);
            this.txtExp.TabIndex = 54;
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("굴림", 26F);
            this.txtResult.Location = new System.Drawing.Point(40, 55);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(524, 74);
            this.txtResult.TabIndex = 55;
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 649);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtExp);
            this.Controls.Add(this.btnMR);
            this.Controls.Add(this.btnMPlus);
            this.Controls.Add(this.btnMMinus);
            this.Controls.Add(this.btnMS);
            this.Controls.Add(this.btnRecip);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.btnSqr);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnSqrt);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnTimes);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnPlusMinus);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnMC);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnMC;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnPlusMinus;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnTimes;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnSqr;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnRecip;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button btnMS;
        private System.Windows.Forms.Button btnMMinus;
        private System.Windows.Forms.Button btnMPlus;
        private System.Windows.Forms.Button btnMR;
        private System.Windows.Forms.Label txtExp;
        private System.Windows.Forms.TextBox txtResult;
    }
}