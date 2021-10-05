using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleWebApp
{
    public partial class Calculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            var firstValue = double.Parse(txtfirst.Text);
            var SecondValue = double.Parse(txtSecond.Text);
            var Operation = dpList.SelectedValue;
            var result = GetResult(firstValue, SecondValue, Operation);
            ldlDisplay.Text = result.ToString();
        }

        private object GetResult(double firstValue, double secondValue, string operation)
        {
            switch (operation)
            {
                case "+":
                    return firstValue + secondValue;
                case "-":
                    return firstValue - secondValue;
                case "X":
                    return firstValue * secondValue;
                case "/":
                    return firstValue / secondValue;

            }
            return 0;
        }
    }
}