using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using TempConverter.Business;
using TempConverter.Web;

namespace TempConverter.WS
{
    /// <summary>
    /// Summary description for TempConverterWS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class TempConverterWS : System.Web.Services.WebService
    {

        [WebMethod]
        public int ToCelcius(int TempC)
        {
            var ToC = new TempCalculator();
            return ToC.ConvertToC(TempC);
        }
        [WebMethod]
        public int ToFaranheit(int TempF)
        {
            var ToF = new TempCalculator();
            return ToF.ConvertToF(TempF);
        }
    }
}
