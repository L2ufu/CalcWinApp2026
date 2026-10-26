namespace calculator_winApp
{
    public partial class frmCalculator : Form
    {
        public frmCalculator()
        {
            InitializeComponent();
        }

        bool newOperation = true;
        double firstValue;
        double secondValue;
        double result = 0.0;
        string operation = "";

        private void allBtnClick(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            if (newOperation)
            {
                lblDsplay.Text = "";
                newOperation = false;
            }
            if (btn.Text == ",")
            {
                var val = lblDsplay.Text.IndexOf(",");
                if (val > 0) 
                return;
            }
            lblDsplay.Text += btn.Text;
            if (btn.Text != ",")
            {
                return;
      
            }

        }

        private void operatorBtnClick(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            firstValue = Convert.ToDouble(lblDsplay.Text);
            operation = btn.Text;
            lblDsplay.Text += btn.Text;
            newOperation = true; 
        }

        private void equalsBtnClick(object sender, EventArgs e)
        {
            
            secondValue = Convert.ToDouble(lblDsplay.Text);
            switch (operation)
            {
                case "+":
                    result = firstValue + secondValue;
                    break;
                case "—":
                    result = firstValue - secondValue;
                    break;
                case "×":
                    result = firstValue * secondValue;
                    break;
                case "/":
                    result = firstValue / secondValue;
                    break;
                case "%":
                    result = firstValue % secondValue;
                    break;
                case "^":
                    result = 1;
                    for (int i = 0; i < secondValue; i++)
                    {
                        result *= firstValue;
                    }
                    break;
            }

            lblDsplay.Text = result.ToString();
            newOperation = true;
        }
        private void acBtnClick(object sender, EventArgs e)
        {
            lblDsplay.Text = "";
            firstValue = 0;
            secondValue = 0;
            result = 0;
            operation = "";
            newOperation = true;
        }

        private void deleteBtnClick(object sender, EventArgs e)
        {
                lblDsplay.Text = lblDsplay.Text.Remove(lblDsplay.Text.Length - 1);
        }
    }

}
