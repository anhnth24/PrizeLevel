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
        public const string getSelections655 = "";

    }
}
