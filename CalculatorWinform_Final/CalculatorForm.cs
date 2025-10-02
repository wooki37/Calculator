using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CalculatorWinform
{
    public partial class CalculatorForm : Form
    {
        #region Variables
        GlobalKeyboardHook _kbdHook = new GlobalKeyboardHook();

        private string[] _ExpArray = null;
        private Keys _PreviousKey;
        private string _PreviousOperator = string.Empty;

        private bool _PreventEnterKeyClick = false;
        private bool _MemFlag = false;
        private bool _IsOperation = false;

        private decimal _BeforeValue = 0;
        private decimal _CurrentValue = 0;
        private decimal _Memory;

        private OperationStep _OperationStep = OperationStep.NONE;

        #endregion

        #region Constructor
        public CalculatorForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Events

        private void CalculatorForm_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            _kbdHook.hook();
            _kbdHook.KeyDown += _kbdHook_KeyDown;
            _ExpArray = new string[3];
            lblResult.Text = string.Format("{0}", "0");
        }

        private void _kbdHook_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D8 && _PreviousKey == Keys.RShiftKey)
            {
                btnMultiply_Click(btnTimes, null);
                _PreviousKey = Keys.Multiply;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                if (_PreventEnterKeyClick)
                {
                    _PreventEnterKeyClick = false;
                }
                else
                {
                    btnEqual_Click(this, null);
                }
            }
            else
            {
                switch (e.KeyCode)
                {
                    case Keys.Back:
                        btnDelete_Click(sender, e);
                        break;
                    case Keys.Clear:
                        btnC_Click(sender, e);
                        break;
                    case Keys.Escape:
                        btnC_Click(sender, e);
                        break;
                    case Keys.Delete:
                        btnCE_Click(sender, e);
                        break;
                    case Keys.D0:
                        btnNumber_Click(btn0, null);
                        break;
                    case Keys.D1:
                        btnNumber_Click(btn1, null);
                        break;
                    case Keys.D2:
                        btnNumber_Click(btn2, null);
                        break;
                    case Keys.D3:
                        btnNumber_Click(btn3, null);
                        break;
                    case Keys.D4:
                        btnNumber_Click(btn4, null);
                        break;
                    case Keys.D5:
                        btnNumber_Click(btn5, null);
                        break;
                    case Keys.D6:
                        btnNumber_Click(btn6, null);
                        break;
                    case Keys.D7:
                        btnNumber_Click(btn7, null);
                        break;
                    case Keys.D8:
                        btnNumber_Click(btn8, null);
                        break;
                    case Keys.D9:
                        btnNumber_Click(btn9, null);
                        break;
                    case Keys.NumPad0:
                        btnNumber_Click(btn0, null);
                        break;
                    case Keys.NumPad1:
                        btnNumber_Click(btn1, null);
                        break;
                    case Keys.NumPad2:
                        btnNumber_Click(btn2, null);
                        break;
                    case Keys.NumPad3:
                        btnNumber_Click(btn3, null);
                        break;
                    case Keys.NumPad4:
                        btnNumber_Click(btn4, null);
                        break;
                    case Keys.NumPad5:
                        btnNumber_Click(btn5, null);
                        break;
                    case Keys.NumPad6:
                        btnNumber_Click(btn6, null);
                        break;
                    case Keys.NumPad7:
                        btnNumber_Click(btn7, null);
                        break;
                    case Keys.NumPad8:
                        btnNumber_Click(btn8, null);
                        break;
                    case Keys.NumPad9:
                        btnNumber_Click(btn9, null);
                        break;
                    case Keys.Q:
                        btnSqr_Click(btnSqr, null);
                        break;
                    case Keys.R:
                        btnRecip_Click(btnRecip, null);
                        break;
                    case Keys.Multiply:
                        btnMultiply_Click(btnTimes, null);
                        break;
                    case Keys.Add:
                        btnPlus_Click(btnPlus, null);
                        break;
                    case Keys.Subtract:
                        btnSubstract_Click(btnMinus, null);
                        break;
                    case Keys.Divide:
                        btnDivide_Click(btnDivide, null);
                        break;
                    case Keys.OemQuestion:
                        btnDivide_Click(btnDivide, null);
                        break;
                    case Keys.Enter:
                        btnEqual_Click(this, null);
                        break;
                    case Keys.F9:
                        btnPlusMinus_Click(this, null);
                        break;
                    case Keys.Oemplus:
                        btnPlus_Click(btnPlus, null);
                        break;
                    case Keys.OemMinus:
                        btnSubstract_Click(btnMinus, null);
                        break;
                    case Keys.OemPeriod:
                        btnDot_Click(btnDot, null);
                        break;

                    default: break;
                }

                _PreviousKey = e.KeyCode;
            }
        }
        #region Memory
        private void btnMC_Click(object sender, EventArgs e)
        {
            lblResult.Text = "0";
            _Memory = 0;
            btnMR.Enabled = false;
            btnMC.Enabled = false;
        }

        private void btnMR_Click(object sender, EventArgs e)
        {
            lblResult.Text = _Memory.ToString();
            _MemFlag = true;
        }

        private void btnMPlus_Click(object sender, EventArgs e)
        {
            _Memory += decimal.Parse(lblResult.Text);
        }

        private void btnMMinus_Click(object sender, EventArgs e)
        {
            _Memory -= decimal.Parse(lblResult.Text);
        }

        private void btnMS_Click(object sender, EventArgs e)
        {
            _Memory = decimal.Parse(lblResult.Text);
            btnMC.Enabled = true;
            btnMR.Enabled = true;
            _MemFlag = true;
        }

        #endregion

        private void btnCE_Click(object sender, EventArgs e)
        {
            lblResult.Text = string.Format("{0}", "0");
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            lblResult.Text = string.Format("{0}", "0");
            txtExp.Text = string.Empty;
            _BeforeValue = 0;
            _CurrentValue = 0;
            _ExpArray = null;
            _ExpArray = new string[3];
        }
         
        private void btnDelete_Click(object sender, EventArgs e)
        {
            lblResult.Text = lblResult.Text.Remove(lblResult.Text.Length - 1);

            if (lblResult.Text.Length == 0)
            {
                lblResult.Text = string.Format("{0}", "0");
            }
        }

        private void btnRecip_Click(object sender, EventArgs e)
        {
            txtExp.Text = "1/(" + lblResult.Text + ") ";
            lblResult.Text = (1 / Double.Parse(lblResult.Text)).ToString();
            txtExp.Text = string.Empty;
        }

        private void btnSqr_Click(object sender, EventArgs e)
        {
            txtExp.Text = "sqr(" + lblResult.Text + ") ";
            lblResult.Text = (decimal.Parse(lblResult.Text) * decimal.Parse(lblResult.Text)).ToString();
            txtExp.Text = string.Empty;
        }
        private void btnSqrt_Click(object sender, EventArgs e)
        {
            txtExp.Text = "2√x(" + lblResult.Text + ") ";
            lblResult.Text = Math.Sqrt(Double.Parse(lblResult.Text)).ToString();
            txtExp.Text = string.Empty;
        }

        #region Four Basic Operations

        public void btnDivide_Click(object sender, EventArgs e)
        {
            _PreviousOperator = Operations.Divide;
            _OperationStep = OperationStep.EXPRESSION1;
            _BeforeValue = CalculatorOperator.ConvertStringDecimal(lblResult.Text);
            _ExpArray[0] = lblResult.Text;
            _ExpArray[1] = _PreviousOperator;
            DisplayExp(_ExpArray, _OperationStep);
            _OperationStep = OperationStep.EXPRESSION2;

            _IsOperation = true;
        }

        public void btnMultiply_Click(object sender, EventArgs e)
        {
            _PreviousOperator = Operations.Multiply;
            _OperationStep = OperationStep.EXPRESSION1;
            _BeforeValue = CalculatorOperator.ConvertStringDecimal(lblResult.Text);
            _ExpArray[0] = lblResult.Text;
            _ExpArray[1] = _PreviousOperator;
            DisplayExp(_ExpArray, _OperationStep);
            _OperationStep = OperationStep.EXPRESSION2;

            _IsOperation = true;
        }

        public void btnSubstract_Click(object sender, EventArgs e)
        {
            _PreviousOperator = Operations.Substract;
            _OperationStep = OperationStep.EXPRESSION1;
            _BeforeValue = CalculatorOperator.ConvertStringDecimal(lblResult.Text);
            _ExpArray[0] = lblResult.Text;
            _ExpArray[1] = _PreviousOperator;
            DisplayExp(_ExpArray, _OperationStep);
            _OperationStep = OperationStep.EXPRESSION2;

            _IsOperation = true;
        }

        public void btnPlus_Click(object sender, EventArgs e)
        {
            _PreviousOperator = Operations.Plus;
            _OperationStep = OperationStep.EXPRESSION1;
            _BeforeValue = CalculatorOperator.ConvertStringDecimal(lblResult.Text);
            _ExpArray[0] = lblResult.Text;
            _ExpArray[1] = _PreviousOperator;
            DisplayExp(_ExpArray, _OperationStep);
            _OperationStep = OperationStep.EXPRESSION2;

            _IsOperation = true;
        }
        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblResult.Text))
            {
                lblResult.Text = string.Format("{0}", -decimal.Parse(lblResult.Text));
            }
        }
        #endregion

        private void btnNumber_Click(object sender, EventArgs e)
        {
            if (_PreventEnterKeyClick)
            {
                _PreventEnterKeyClick = false;
                return;
            }
            if (lblResult.Text.Length < 21)
            {
                if (_PreviousOperator != null)
                {
                    if (_IsOperation || _MemFlag)
                    {
                        _IsOperation = false;
                        lblResult.Text = string.Empty;
                    }
                }
                lblResult.Text = Digit3Comma(lblResult.Text, (sender as Button).Text);
            }
            else
            {
                if (!lblResult.Text.Contains("."))
                {
                    if (lblResult.Text.Length < 17)
                    {
                        if (_PreviousOperator != null)
                        {
                            if (_IsOperation)
                            {
                                _IsOperation = false;
                                lblResult.Text = string.Empty;
                            }
                            else
                            {
                                _ExpArray[0] = lblResult.Text + (sender as Button).Text;
                            }
                        }
                        lblResult.Text = Digit3Comma(lblResult.Text, (sender as Button).Text);
                    }
                }
            }
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (lblResult.Text.Contains("."))
            {
                return;
            }
            else
            {
                lblResult.Text += ".";
            } 
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblResult.Text == string.Empty)
                {
                    return;
                }

                _PreventEnterKeyClick = true;

                if (_ExpArray != null && _ExpArray.Length > 1)
                {
                    if (_OperationStep != OperationStep.EXPRESSION4)
                    {
                        _ExpArray[2] = lblResult.Text;
                    }
                    _OperationStep = OperationStep.EXPRESSION4;

                    decimal calValue = 0;
                    
                    switch (_ExpArray[1])
                    {
                        case Operations.Divide:
                            if (_ExpArray[2] == "0")
                            {
                                lblResult.Text = string.Format("{0}", "0으로 나눌 수 없습니다");
                                return;
                            }
                            DisplayExp(_ExpArray, _OperationStep);
                            calValue = CalculatorOperator.Divide(decimal.Parse(_ExpArray[0]), decimal.Parse(_ExpArray[2]));
                            break;
                        case Operations.Multiply:
                            DisplayExp(_ExpArray, _OperationStep);
                            calValue = CalculatorOperator.Multiply(decimal.Parse(_ExpArray[0]), decimal.Parse(_ExpArray[2]));
                            break;
                        case Operations.Substract:
                            DisplayExp(_ExpArray, _OperationStep);
                            calValue = CalculatorOperator.Substract(decimal.Parse(_ExpArray[0]), decimal.Parse(_ExpArray[2]));
                            break;
                        case Operations.Plus:
                            DisplayExp(_ExpArray, _OperationStep);
                            calValue = CalculatorOperator.Plus(decimal.Parse(_ExpArray[0]), decimal.Parse(_ExpArray[2]));
                            break;
                    }

                    lblResult.Text = (calValue == 0) ? string.Format("{0:#,##0.###############}", calValue) : (calValue < 1) ? string.Format("{0:#,##0.###############}", calValue) : string.Format("{0:#,###.###############}", calValue);
                    _ExpArray[0] = string.Format("{0}", calValue);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region Methods

        private void DisplayExp(string[] expArray, OperationStep operationStep)
        {
            if (expArray != null)
            {
                switch(operationStep)
                {
                    case OperationStep.EXPRESSION1:
                        txtExp.Text = string.Format("{0} {1} ", expArray[0].Replace(",", ""), expArray[1]);
                        break;
                    case OperationStep.EXPRESSION4:
                        txtExp.Text = string.Format("{0} {1} {2} = ", expArray[0].Replace(",", ""), expArray[1], expArray[2].Replace(",", ""));
                        break;
                }
            }
        }
        private static string Digit3Comma(string currentValue, string addValue)
        {
            decimal dValue = 0;

            if (string.IsNullOrEmpty(currentValue) || currentValue == "0")
            {
                dValue = decimal.Parse(addValue);
                return string.Format("{0:#,##0.###############}", dValue);
            }
            else
            {
                dValue = decimal.Parse(string.Format("{0}{1}", currentValue.Replace(",", ""), addValue));

                if (dValue < 1)
                {
                    return string.Format("{0:#,##0.###############}", dValue);
                }
                else
                {
                    return string.Format("{0:#,###.###############}", dValue);
                }
            }
        }
        #endregion
    }
}