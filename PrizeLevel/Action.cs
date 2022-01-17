using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrizeLevel.Constants;

namespace PrizeLevel
{
    public class Action
    {
        //public static string date = DateTime.Now.ToString("yyyyMMdd");

        public static string Date = "20210303";
        public static string[] Bingo645;
        public static string[] Selections645;
        public static void SelectionToPrizeLevel()
        {
            int matched = 0;
            DataTable dtBingo645 = Globals.QueryToDataTable(Query.getBingo645 + "'" + Date + "'");
            DataTable dtSelections645 = Globals.QueryToDataTable(Query.getSelections645 + "'" + Date + "'");
            if (dtBingo645.Rows.Count > 0 && dtSelections645.Rows.Count > 0)
            {
                Bingo645 = dtBingo645.Rows[0]["NUMBER"].ToString().Split(' ');
                for (int i = 0; i < dtSelections645.Rows.Count; i++)
                {
                    Selections645 = dtSelections645.Rows[i]["COMBINATION"].ToString().Split('-');
                    for (int j = 0; j < Selections645.Length; j++)
                    {
                        
                        if (Bingo645.Any(str => str.Contains(Selections645[j])))
                        {
                            matched = matched + 1;
                        }
                    }
                    switch (matched)
                    {
                        case 0:
                            Globals.WriteLog(dtSelections645.Rows[i]["COMBINATION"].ToString() + " : " + "prize none !");
                            matched = 0;
                            break;
                        case 1:
                            Globals.WriteLog(dtSelections645.Rows[i]["COMBINATION"].ToString() + " : " + "prize none !");
                            matched = 0;
                            break;
                        case 2:
                            Globals.WriteLog(dtSelections645.Rows[i]["COMBINATION"].ToString() + " : " + "prize none !");
                            matched = 0;
                            break;
                        case 3:
                            Globals.WriteLog(dtSelections645.Rows[i]["COMBINATION"].ToString() + " : " + "prize 3 !");
                            matched = 0;
                            break;
                        case 4:
                            Globals.WriteLog(dtSelections645.Rows[i]["COMBINATION"].ToString() + " : " + "prize 2 !");
                            matched = 0;
                            break;
                        case 5:
                            Globals.WriteLog(dtSelections645.Rows[i]["COMBINATION"].ToString() + " : " + "prize 1 !");
                            matched = 0;
                            break;
                        case 6:
                            Globals.WriteLog(dtSelections645.Rows[i]["COMBINATION"].ToString() + " : " + "prize jackpot !");
                            matched = 0;
                            break;
                    }


                }
            }

        }
    }
}
