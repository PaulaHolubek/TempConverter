using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TempConverter.Business;

namespace TempConverter.Web
{
    public partial class TempConversionForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCtoF_Click(object sender, EventArgs e)
        {
            var TCBLib = new TempCalculator();
            int TempC = Int32.Parse(tbTempC.Text);
            int result = TCBLib.ConvertToF(TempC);
            tbTempF.Text = result.ToString();
        }

        protected void btnFtoC_Click(object sender, EventArgs e)
        {
            var TCBLib = new TempCalculator();
            int TempF = Int32.Parse(tbTempF.Text);
            int result = TCBLib.ConvertToC(TempF);
            tbTempC.Text = result.ToString();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            tbTempC.Text = String.Empty;
            tbTempF.Text = String.Empty;
        }
    }
}