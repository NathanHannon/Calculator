using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private decimal _firstNum;
        private decimal _secondNum;
        private decimal _answer;
        private string _symbol;

        private void CalculatorForm_Load(object sender, EventArgs e)
        {
            lblEquations.Text = "";
            txtDisplay.Text = "";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblEquations.Text = "";
            txtDisplay.Text = "";
        }
        private void btnZero_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnZero.Text;
            lblEquations.Text += btnZero.Text;
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnDecimal.Text;
            lblEquations.Text += btnDecimal.Text;
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnOne.Text;
            lblEquations.Text += btnOne.Text;
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnTwo.Text;
            lblEquations.Text += btnTwo.Text;
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnThree.Text;
            lblEquations.Text += btnThree.Text;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnFour.Text;
            lblEquations.Text += btnFour.Text;
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnFive.Text;
            lblEquations.Text += btnFive.Text;
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnSix.Text;
            lblEquations.Text += btnSix.Text;
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnSeven.Text;
            lblEquations.Text += btnSeven.Text;
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnEight.Text;
            lblEquations.Text += btnEight.Text;
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnNine.Text;
            lblEquations.Text += btnNine.Text;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _firstNum = decimal.Parse(txtDisplay.Text);
            lblEquations.Text += btnAdd.Text;
            _symbol = "+";
            txtDisplay.Text = "";
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            _firstNum = decimal.Parse(txtDisplay.Text);
            lblEquations.Text += btnSubtract.Text;
            _symbol = "-";
            txtDisplay.Text = "";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            _firstNum = decimal.Parse(txtDisplay.Text);
            lblEquations.Text += btnMultiply.Text;
            _symbol = "x";
            txtDisplay.Text = "";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            _firstNum = decimal.Parse(txtDisplay.Text);
            _symbol = "÷";
            lblEquations.Text += "/";
            txtDisplay.Text = "";
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            _secondNum = decimal.Parse(txtDisplay.Text);
            lblEquations.Text += btnEquals.Text;
            switch (_symbol)
            {
                case "+":
                    _answer = _firstNum + _secondNum;
                    break;
                case "-":
                    _answer = _firstNum - _secondNum;
                    break;
                case "x":
                    _answer = _firstNum * _secondNum;
                    break;
                case "÷":
                    try
                    {
                        _answer = _firstNum / _secondNum;
                    }
                    catch (DivideByZeroException)
                    {
                        MessageBox.Show("Cannot Divide By Zero!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtDisplay.Text = "";
                        lblEquations.Text = "";
                        throw;
                    }

                    break;
            }

            lblEquations.Text += _answer.ToString();
            txtDisplay.Text = "";
        }
    }
}
