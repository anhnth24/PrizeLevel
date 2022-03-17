using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizeLevel.Constants
{
    public static class Query
    {
        public const string getSelections645 = "SELECT COMBINATION,QUANTITY FROM CORE_DCS_645 where CAST('20'|| RIGHT(FILENAME,6) AS DATE) = ";
        public const string getBingo645 = "SELECT TOP 1 NUMBER FROM CORE_DL WHERE LIATYPE =1 AND DRAWDATE = ";

        public const string getBingo655 = "SELECT TOP 1 NUMBER,BONUS FROM CORE_DL WHERE LIATYPE =2 AND DRAWDATE = ";
        public const string getSelections655 = "SELECT COMBINATION,QUANTITY FROM CORE_DCS_655 where CAST('20'|| RIGHT(FILENAME,6) AS DATE) = ";

        public const string getBingo3DPro = "SELECT  NUMBER FROM CORE_DL WHERE LIATYPE =7 AND DRAWDATE =";
        public const string getSelections3DPro = "SELECT COMBINATION,QUANTITY FROM CORE_DCS_3D_PRO where quantity > 0 and CAST('20'|| RIGHT(FILENAME,6) AS DATE) = ";
    }
}
