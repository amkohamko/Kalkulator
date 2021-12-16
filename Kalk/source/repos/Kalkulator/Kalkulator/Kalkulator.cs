using System;
using System.Windows.Forms;

namespace Kalkulator
{
    

    public partial class Kalkulator : Form
    {


        ExternalCalc exc = new ExternalCalc();



        public Kalkulator()
        {
            
            InitializeComponent();

            btnDel.Enabled = false;

            tbAnzeige.Enabled = false;

            btnPlus.Enabled = false;

            btnMinus.Enabled = false;

            btnDiv.Enabled = false;

            btnMulti.Enabled = false;

            Icon = new System.Drawing.Icon("..\\..\\resources\\calculator.ico");
        }
         
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        private void isEqual_Click(object sender, EventArgs e)
        {



            tbAnzeige.Text = exc.Calc ();

        }
        private void tbAnzeige_TextChanged(object sender, EventArgs e)
        {
            btnDel.Enabled = tbAnzeige.TextLength > 0;

            if (tbAnzeige.TextLength > 0) {
                tbAnzeige.Enabled = true;
                btnPlus.Enabled = true;
                btnMinus.Enabled = true;
                btnDiv.Enabled = true;
                btnMulti.Enabled = true;
            }else {
                tbAnzeige.Enabled = false;
                btnPlus.Enabled = false;
                btnMinus.Enabled = false;
                btnDiv.Enabled = false;
                btnMulti.Enabled = false;
            }
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void btnOne_Click(object sender, EventArgs e)  { SetInputValue("1");  }
        private void btnTwo_Click(object sender, EventArgs e)  { SetInputValue("2"); }
        private void SetInputValue(string strV)
        {
            tbAnzeige.Text += strV;
            exc.SetValue(tbAnzeige.Text);
        }

  
        private void btnThree_Click(object sender, EventArgs e){ SetInputValue("3"); }

        private void btnFour_Click(object sender, EventArgs e){ SetInputValue("4"); }

        private void btnFive_Click(object sender, EventArgs e){ SetInputValue("5"); }

        private void btnSix_Click(object sender, EventArgs e){ SetInputValue("6"); }

        private void btnSeven_Click(object sender, EventArgs e){ SetInputValue("7"); }

        private void btnEight_Click(object sender, EventArgs e){ SetInputValue("8"); }

        private void btnNine_Click(object sender, EventArgs e){ SetInputValue("9"); }

        private void btnZero_Click(object sender, EventArgs e){ SetInputValue("0"); }

        private void btnPoint_Click(object sender, EventArgs e){ 

            SetInputValue(",");
            btnPoint.Enabled = false; 

        }



        private void btnPlus_Click(object sender, EventArgs e)
        {
            tbAnzeige.Text = "";
            exc.SetOp(exc.PLUS);

            btnPoint.Enabled = true;

        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            tbAnzeige.Text = "";
            exc.SetOp(exc.MINUS);

            btnPoint.Enabled = true;
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            tbAnzeige.Text = "";
            exc.SetOp(exc.MAHL);

            btnPoint.Enabled = true;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            tbAnzeige.Text = "";
            exc.SetOp(exc.DIVE);

            btnPoint.Enabled = true;
        }
        private void btnDel_Click(object sender, EventArgs e)
        {

            tbAnzeige.Text = tbAnzeige.Text.Remove(tbAnzeige.Text.Length - 1);
            btnDel.Enabled = tbAnzeige.Text.Length > 0;
            exc.SetValue(tbAnzeige.Text);
            btnPoint.Enabled = tbAnzeige.Text.Contains(",") == false;
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }


}
