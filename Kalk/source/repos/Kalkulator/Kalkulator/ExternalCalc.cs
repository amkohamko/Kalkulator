using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{

    class ExternalCalc
    {
        const int NOP = -1;   //No operation seleccteds
        public int MINUS = 0;
        public int PLUS = 1;
        public int MAHL = 2;
        public int DIVE = 3;


        public string strValue1 = "";
        public string strValue2 = "";
        public int iOperator = NOP;


        
            

        public double getExternalCalc()
        {
            return 0.0;
        }
        public void SetValue(string strV)
        {
            if (iOperator == NOP)
                strValue1 = strV;
            else
                strValue2 = strV;

            if (strValue1 == ",") strValue1 = "0";

            if (strValue2 == ",") strValue2 = "0";

            if (strValue2 == "") strValue2 = strValue1;

            if (strValue1 == "") strValue1 = strValue2;

            

        }
        public void SetOp(int iOp)
        {
            iOperator = iOp;

        }

        public string Calc()
        {
           

            if (iOperator == PLUS)
                strValue1 = (Convert.ToDouble(strValue1) + Convert.ToDouble(strValue2)).ToString();
            else if (iOperator == MINUS)
                strValue1 = (Convert.ToDouble(strValue1) - Convert.ToDouble(strValue2)).ToString();
            else if(iOperator == MAHL)
                strValue1 = (Convert.ToDouble(strValue1) * Convert.ToDouble(strValue2)).ToString();
            else if (iOperator == DIVE)
                strValue1 = (Convert.ToDouble(strValue1) / Convert.ToDouble(strValue2)).ToString();
            else strValue1 = "";

            iOperator = NOP;
           
            return strValue1;
        }

    }

}
