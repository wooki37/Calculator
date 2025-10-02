using System;
using System.Windows.Forms;

namespace CalculatorWinform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnMC.Enabled = false;
            btnMR.Enabled = false;
        }

        private char op = '\0';
        private bool opFlag = false;
        private bool memFlag = false;
        private double savedValue;
        private double memory;

        private void btnNumber_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (txtResult.Text == "0" || opFlag == true || memFlag == true)
            {
                txtResult.Text = btn.Text;
                opFlag = false;
                memFlag = false;
            }
            else
                txtResult.Text = txtResult.Text + btn.Text;

            // 3자리마다 콤마 삽입
            double v = Double.Parse(txtResult.Text);
            txtResult.Text = commaProcedure(v, txtResult.Text);
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (txtResult.Text.Contains("."))
                return;
            else
                txtResult.Text += ".";
        }

        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            double v = Double.Parse(txtResult.Text);
            txtResult.Text = (-v).ToString();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            savedValue = Double.Parse(txtResult.Text);
            txtExp.Text = txtResult.Text + " + ";
            op = '+';
            opFlag = true;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            savedValue = Double.Parse(txtResult.Text);
            txtExp.Text = txtResult.Text + " - ";
            op = '-';
            opFlag = true;
        }

        private void btnTimes_Click(object sender, EventArgs e)
        {
            savedValue = Double.Parse(txtResult.Text);
            txtExp.Text = txtResult.Text + " x ";
            op = '*';
            opFlag = true;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            savedValue = Double.Parse(txtResult.Text);
            txtExp.Text = txtResult.Text + " ÷ ";
            op = '/';
            opFlag = true;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            Double x = Double.Parse(txtResult.Text);
            switch (op)
            {
                case '+':
                    txtResult.Text = (savedValue + x).ToString();
                    break;
                case '-':
                    txtResult.Text = (savedValue - x).ToString();
                    break;
                case '*':
                    txtResult.Text = (savedValue * x).ToString();
                    break;
                case '/':
                    txtResult.Text = (savedValue / x).ToString();
                    break;
            }
            // 3자리마다 콤마 삽입
            double v = Double.Parse(txtResult.Text);
            txtResult.Text = commaProcedure(v, txtResult.Text);
            txtExp.Text = "";
        }

        // 제곱근 처리
        private void btnSqrt_Click(object sender, EventArgs e)
        {
            txtExp.Text = "2√x(" + txtResult.Text + ") ";
            txtResult.Text = Math.Sqrt(Double.Parse(txtResult.Text)).ToString();
        }
        // 제곱처리
        private void btnSqr_Click(object sender, EventArgs e)
        {
            txtExp.Text = "x²(" + txtResult.Text + ") ";
            txtResult.Text = (Double.Parse(txtResult.Text) * Double.Parse(txtResult.Text)).ToString();
        }
        // 역수 연산 처리
        private void btnRecip_Click(object sender, EventArgs e)
        {
            txtExp.Text = "1/x(" + txtResult.Text + ") ";
            txtResult.Text = (1 / Double.Parse(txtResult.Text)).ToString();
        }

        // 지금 txtResult에 있는 값을 0으로 바꾸기
        private void btnCE_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
        }

        // 초기화
        private void btnC_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            txtExp.Text = "";
            savedValue = 0;
            op = '\0';
            opFlag = false;
        }
        // 맨 뒤의 한 글자를 지우기
        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text.Remove(txtResult.Text.Length - 1);
            if (txtResult.Text.Length == 0)
                txtResult.Text = "0";
        }

        // Memory Save
        private void btnMS_Click(object sender, EventArgs e)
        {
            memory = Double.Parse(txtResult.Text);
            btnMC.Enabled = true;
            btnMR.Enabled = true;
            memFlag = true;
        }

        // Memory Read
        private void btnMR_Click(object sender, EventArgs e)
        {
            txtResult.Text = memory.ToString();
            memFlag = true;
        }

        // Memory Clear
        private void btnMC_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            memory = 0;
            btnMR.Enabled = false;
            btnMC.Enabled = false;
        }
        // M+
        private void btnMPlus_Click(object sender, EventArgs e)
        {
            memory += Double.Parse(txtResult.Text);
        }

        // M-
        private void btnMMinus_Click(object sender, EventArgs e)
        {
            memory -= Double.Parse(txtResult.Text);
        }

        // 3자리마다 쉼표 삽입
        private static string commaProcedure(double v, string s)
        {
            int pos = 0;
            if (s.Contains("."))
            {
                pos = s.Length - s.IndexOf('.');    // 소수점 아래 자리수 + 1
                if (pos == 1)   // 맨 뒤에 소수점이 있으면 그대로 리턴
                    return s;
                string formatStr = "{0:N" + (pos - 1) + "}";
                s = string.Format(formatStr, v);
            }
            else
                s = string.Format("{0:N0}", v);
            return s;
        }
    }
}