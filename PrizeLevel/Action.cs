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





        public static void SelectionToPrizeLevel_Game645(string Date)
        {
            string[] Bingo645;
            string[] Selections645;
            int matched = 0;
            int nonprize = 0;
            int prize4 = 0;
            int prize3 = 0;
            int prize2 = 0;
            int prize1 = 0;
            DataTable dtBingo645 = Globals.QueryToDataTable(Query.getBingo645 + "'" + Date + "'");
            DataTable dtSelections645 = Globals.QueryToDataTable(Query.getSelections645 + "'" + Date + "'");
            Globals.WriteLog("Start Mega 645");
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
                            //Globals.WriteLog(dtSelections645.Rows[i]["COMBINATION"].ToString() + " : " + "prize none !");
                            nonprize = nonprize + int.Parse(dtSelections645.Rows[i]["QUANTITY"].ToString());
                            matched = 0;
                            break;
                        case 1:
                            //Globals.WriteLog(dtSelections645.Rows[i]["COMBINATION"].ToString() + " : " + "prize none !");
                            nonprize = nonprize + int.Parse(dtSelections645.Rows[i]["QUANTITY"].ToString());
                            matched = 0;
                            break;
                        case 2:
                            //Globals.WriteLog(dtSelections645.Rows[i]["COMBINATION"].ToString() + " : " + "prize none !");
                            nonprize = nonprize + int.Parse(dtSelections645.Rows[i]["QUANTITY"].ToString());
                            matched = 0;
                            break;
                        case 3:
                            //Globals.WriteLog(dtSelections645.Rows[i]["COMBINATION"].ToString() + " : " + "prize 3 !");
                            prize4 = prize4 + int.Parse(dtSelections645.Rows[i]["QUANTITY"].ToString());
                            matched = 0;
                            break;
                        case 4:
                            //Globals.WriteLog(dtSelections645.Rows[i]["COMBINATION"].ToString() + " : " + "prize 2 !");
                            prize3 = prize3 + int.Parse(dtSelections645.Rows[i]["QUANTITY"].ToString());
                            matched = 0;
                            break;
                        case 5:
                            //Globals.WriteLog(dtSelections645.Rows[i]["COMBINATION"].ToString() + " : " + "prize 1 !");
                            prize2 = prize2 + int.Parse(dtSelections645.Rows[i]["QUANTITY"].ToString());
                            matched = 0;
                            break;
                        case 6:
                            //Globals.WriteLog(dtSelections645.Rows[i]["COMBINATION"].ToString() + " : " + "prize jackpot !");
                            prize1 = prize1 + int.Parse(dtSelections645.Rows[i]["QUANTITY"].ToString());
                            matched = 0;
                            break;
                    }


                }
                Globals.WriteLog("Non prize : " + nonprize.ToString());
                Globals.WriteLog("Prize 1: " + prize1.ToString());
                Globals.WriteLog("Prize 2: " + prize2.ToString());
                Globals.WriteLog("Prize 3: " + prize3.ToString());
                Globals.WriteLog("Prize 4: " + prize4.ToString());
            }

        }

        public static void SelectionToPrizeLevel_Game655(string Date)
        {
            string[] Bingo655;
            string[] Selections655;
            string BonusNumber;
            int matchedBonus = 0;
            int matched = 0;
            int nonprize = 0;
            int prize1 = 0;
            int prize2 = 0;
            int prize3 = 0;
            int prize4 = 0;
            int prize5 = 0;
            DataTable dtBingo655 = Globals.QueryToDataTable(Query.getBingo655 + "'" + Date + "'");

            DataTable dtSelections655 = Globals.QueryToDataTable(Query.getSelections655 + "'" + Date + "'");
            Globals.WriteLog("Start Power 655");
            if (dtBingo655.Rows.Count > 0 && dtSelections655.Rows.Count > 0)
            {

                try
                {
                    BonusNumber = dtBingo655.Rows[0]["BONUS"].ToString();
                    Bingo655 = dtBingo655.Rows[0]["NUMBER"].ToString().Split(' ');
                    for (int i = 0; i < dtSelections655.Rows.Count; i++)
                    {
                        //Selections655 = "02-07-18-20-30-35".Split('-');
                        //Selections655 = "02-04-07-18-35-37".Split('-');
                        //if (Selections655.Contains(BonusNumber))
                        //{
                        //    matchedBonus++;
                        //}
                        Selections655 = dtSelections655.Rows[i]["COMBINATION"].ToString().Split('-');

                        for (int j = 0; j < Selections655.Length; j++)
                        {

                            if (Bingo655.Any(str => str.Contains(Selections655[j])))
                            {
                                matched++;
                                if (matched == 5 && Selections655.Contains(BonusNumber))
                                {
                                    matchedBonus++;
                                }
                            }

                        }


                        if (matched == 0)
                        {
                            //Globals.WriteLog(dtSelections655.Rows[i]["COMBINATION"].ToString() + " : " + "prize none !");
                            nonprize = nonprize + int.Parse(dtSelections655.Rows[i]["QUANTITY"].ToString());
                            matched = 0;
                        }
                        if (matched == 1)
                        {
                            //Globals.WriteLog(dtSelections655.Rows[i]["COMBINATION"].ToString() + " : " + "prize none !");
                            nonprize = nonprize + int.Parse(dtSelections655.Rows[i]["QUANTITY"].ToString());
                            matched = 0;
                        }
                        if (matched == 2)
                        {
                            //Globals.WriteLog(dtSelections655.Rows[i]["COMBINATION"].ToString() + " : " + "prize none !");
                            nonprize = nonprize + int.Parse(dtSelections655.Rows[i]["QUANTITY"].ToString());
                            matched = 0;
                        }
                        if (matched == 3)
                        {
                            //Globals.WriteLog(dtSelections655.Rows[i]["COMBINATION"].ToString() + " : " + "prize 5 !");
                            prize5 = prize5 + int.Parse(dtSelections655.Rows[i]["QUANTITY"].ToString());
                            matched = 0;
                        }
                        if (matched == 4)
                        {
                            //Globals.WriteLog(dtSelections655.Rows[i]["COMBINATION"].ToString() + " : " + "prize 4 !");
                            prize4 = prize4 + int.Parse(dtSelections655.Rows[i]["QUANTITY"].ToString());
                            matched = 0;
                        }
                        if (matched == 5 && matchedBonus == 0)
                        {
                            //Globals.WriteLog(dtSelections655.Rows[i]["COMBINATION"].ToString() + " : " + "prize 3 !");
                            prize3 = prize3 + int.Parse(dtSelections655.Rows[i]["QUANTITY"].ToString());
                            matched = 0;
                        }
                        if (matched == 5 && matchedBonus == 1)
                        {
                            //Globals.WriteLog(dtSelections655.Rows[i]["COMBINATION"].ToString() + " : " + "prize 2 !");
                            prize2 = prize2 + int.Parse(dtSelections655.Rows[i]["QUANTITY"].ToString());
                            matchedBonus = 0;
                            matched = 0;
                        }
                        if (matched == 6)
                        {
                            //Globals.WriteLog(dtSelections655.Rows[i]["COMBINATION"].ToString() + " : " + "prize 1 !");
                            prize1 = prize1 + int.Parse(dtSelections655.Rows[i]["QUANTITY"].ToString());
                            matched = 0;
                        }
                    }
                    Globals.WriteLog("Non prize : " + nonprize.ToString());
                    Globals.WriteLog("Prize 1: " + prize1.ToString());
                    Globals.WriteLog("Prize 2: " + prize2.ToString());
                    Globals.WriteLog("Prize 3: " + prize3.ToString());
                    Globals.WriteLog("Prize 4: " + prize4.ToString());
                    Globals.WriteLog("Prize 5: " + prize5.ToString());
                }
                catch (Exception e)
                {
                    Globals.WriteLog(e.ToString());
                }
            }

        }

        public static void SelectionToPrizeLevel_Game3DPro(string Date)
        {
            string[] Bingo1st;
            string[] Bingo2nd;
            string[] Bingo3rd;
            string[] BingoEnc;
            string[] Selections3DPro;

            int matched1st = 0;
            int matched2nd = 0;
            int matched3rd = 0;
            int matched4th = 0;
            int matched5th = 0;
            int matched6th = 0;
            int matched7th = 0;
            int matched8th = 0;

            int nonprize = 0;
            int prize1st = 0;
            int prize2nd = 0;
            int prize3rd = 0;
            int prize4th = 0;
            int prize5th = 0;
            int prize6th = 0;
            int prize7th = 0;
            int prize8th = 0;
            DataTable dtBingo3DPro = Globals.QueryToDataTable(Query.getBingo3DPro + "'" + Date + "'");
            DataTable dtSelections3DPro = Globals.QueryToDataTable(Query.getSelections3DPro + "'" + Date + "'");
            Globals.WriteLog("Start 3D Pro");
            if (dtBingo3DPro.Rows.Count > 0 && dtSelections3DPro.Rows.Count > 0)
            {

                Bingo1st = dtBingo3DPro.Rows[0]["NUMBER"].ToString().Split(' ');
                Bingo2nd = dtBingo3DPro.Rows[1]["NUMBER"].ToString().Split(' ');
                Bingo3rd = dtBingo3DPro.Rows[2]["NUMBER"].ToString().Split(' ');
                BingoEnc = dtBingo3DPro.Rows[3]["NUMBER"].ToString().Split(' ');
                List<string> lst = new List<string>();
                lst.AddRange(Bingo1st);
                lst.AddRange(Bingo2nd);
                lst.AddRange(Bingo3rd);
                lst.AddRange(BingoEnc);
                lst.ToArray();

                List<string> lst2 = new List<string>();
                lst2.AddRange(Bingo2nd);
                lst2.AddRange(Bingo3rd);
                lst2.AddRange(BingoEnc);
                lst2.ToArray();

                for (int i = 0; i < dtSelections3DPro.Rows.Count; i++)
                {
                    Selections3DPro = dtSelections3DPro.Rows[i]["COMBINATION"].ToString().Split(' ');
                    // Giải đặc biệt
                    if (Array.IndexOf(Bingo1st, Selections3DPro[0].ToString()) == 0 && Array.IndexOf(Bingo1st, Selections3DPro[1].ToString()) == 1)
                    {
                        matched1st++;
                    }
                    // Giải phụ đặc biệt
                    if (Array.IndexOf(Bingo1st, Selections3DPro[0].ToString()) == 1 && Array.IndexOf(Bingo1st, Selections3DPro[1].ToString()) == 0)
                    {
                        matched2nd++;
                    }
                    // Giải Nhất
                    for (int j = 0; j < Selections3DPro.Length; j++)
                    {

                        if (Bingo2nd.Any(str => str.Contains(Selections3DPro[j])) && Selections3DPro[0].ToString() != Selections3DPro[1].ToString())
                        {
                            matched3rd++; // =2
                        }
                    }
                    // Giải nhì
                    for (int j = 0; j < Selections3DPro.Length; j++)
                    {

                        if (Bingo3rd.Any(str => str.Contains(Selections3DPro[j])) && Selections3DPro[0].ToString() != Selections3DPro[1].ToString())
                        {
                            matched4th++; // =2
                        }
                    }
                    // Giải ba
                    for (int j = 0; j < Selections3DPro.Length; j++)
                    {

                        if (BingoEnc.Any(str => str.Contains(Selections3DPro[j])) && Selections3DPro[0].ToString() != Selections3DPro[1].ToString())
                        {
                            matched5th++; // =2
                        }
                    }
                    // Giải tư
                    for (int j = 0; j < Selections3DPro.Length; j++)
                    {
                        if (lst.Any(str => str.Contains(Selections3DPro[j])) && Selections3DPro[0].ToString() != Selections3DPro[1].ToString())
                        {
                            matched6th++; // =2
                        }
                    }
                    // Giải năm
                    if(Bingo1st.Any(str => str.Contains(Selections3DPro[0])) || Bingo1st.Any(str => str.Contains(Selections3DPro[1])))
                    {
                        if((Selections3DPro[0].ToString() != Selections3DPro[1].ToString()))
                            matched7th = 1;
                        if ((Selections3DPro[0].ToString() == Selections3DPro[1].ToString()))
                            matched7th = 2;
                    }
                    //for (int j = 0; j < Selections3DPro.Length; j++)
                    //{

                    //    if (Bingo1st.Any(str => str.Contains(Selections3DPro[j])))
                    //    {
                    //        if((Selections3DPro[0].ToString() != Selections3DPro[1].ToString()))
                    //            matched7th = 1; // =1
                    //        if ((Selections3DPro[0].ToString() == Selections3DPro[1].ToString()))
                    //            matched7th = 2; // =1
                    //    }
                    //}
                    // Giải sáu
                    if (lst2.Any(str => str.Contains(Selections3DPro[0].ToString()) || lst2.Any(str1 => str1.Contains(Selections3DPro[1].ToString()))))
                    {
                        matched8th++; // =1
                    }


                    /////=============
                    if (matched1st < 1 && matched2nd < 1 && matched3rd < 2 && matched4th < 2 && matched5th < 2 && matched6th < 2 && matched7th < 1 && matched8th < 1)
                    {
                        nonprize += int.Parse(dtSelections3DPro.Rows[i]["QUANTITY"].ToString());
                        
                    }

                    if (matched1st == 1)// giải đặc biệt
                    {
                        prize1st += int.Parse(dtSelections3DPro.Rows[i]["QUANTITY"].ToString());
                        prize7th ++;
                        //prize6th += int.Parse(dtSelections3DPro.Rows[i]["QUANTITY"].ToString());
                        //prize7th += int.Parse(dtSelections3DPro.Rows[i]["QUANTITY"].ToString());
                        //prize8th += int.Parse(dtSelections3DPro.Rows[i]["QUANTITY"].ToString());
                        //matched1st = 0;
                        //matched2nd = 0;
                        //matched3rd = 0;
                        //matched4th = 0;
                        //matched5th = 0;
                        //matched6th = 0;
                        //matched7th = 0;
                        //matched8th = 0;
                    }
                    if (matched2nd == 1)// giải phụ đặc biệt
                    {
                        prize2nd += int.Parse(dtSelections3DPro.Rows[i]["QUANTITY"].ToString());
                        //prize6th += int.Parse(dtSelections3DPro.Rows[i]["QUANTITY"].ToString());
                        //prize7th += int.Parse(dtSelections3DPro.Rows[i]["QUANTITY"].ToString());
                        //prize8th += int.Parse(dtSelections3DPro.Rows[i]["QUANTITY"].ToString());
                        //matched1st = 0;
                        //matched2nd = 0;
                        //matched3rd = 0;
                        //matched4th = 0;
                        //matched5th = 0;
                        //matched6th = 0;
                        //matched7th = 0;
                        //matched8th = 0;
                    }
                    if (matched3rd == 2)// giải nhất
                    {
                        prize3rd += int.Parse(dtSelections3DPro.Rows[i]["QUANTITY"].ToString());
                        //prize6th += int.Parse(dtSelections3DPro.Rows[i]["QUANTITY"].ToString());
                        //prize8th += int.Parse(dtSelections3DPro.Rows[i]["QUANTITY"].ToString());
                        //matched1st = 0;
                        //matched2nd = 0;
                        //matched3rd = 0;
                        //matched4th = 0;
                        //matched5th = 0;
                        //matched6th = 0;
                        //matched7th = 0;
                        //matched8th = 0;
                    }
                    if (matched4th == 2)// giải nhì
                    {
                        prize4th += int.Parse(dtSelections3DPro.Rows[i]["QUANTITY"].ToString());
                        //prize6th += int.Parse(dtSelections3DPro.Rows[i]["QUANTITY"].ToString());
                        //prize8th += int.Parse(dtSelections3DPro.Rows[i]["QUANTITY"].ToString());
                        //matched1st = 0;
                        //matched2nd = 0;
                        //matched3rd = 0;
                        //matched4th = 0;
                        //matched5th = 0;
                        //matched6th = 0;
                        //matched7th = 0;
                        //matched8th = 0;
                    }
                    if (matched5th == 2)// giải ba
                    {
                        prize5th += int.Parse(dtSelections3DPro.Rows[i]["QUANTITY"].ToString());
                        //prize6th += int.Parse(dtSelections3DPro.Rows[i]["QUANTITY"].ToString());
                        //prize8th += int.Parse(dtSelections3DPro.Rows[i]["QUANTITY"].ToString());
                        //matched1st = 0;
                        //matched2nd = 0;
                        //matched3rd = 0;
                        //matched4th = 0;
                        //matched5th = 0;
                        //matched6th = 0;
                        //matched7th = 0;
                        //matched8th = 0;
                    }
                    if (matched6th == 2)// giải tư
                    {
                        prize6th += int.Parse(dtSelections3DPro.Rows[i]["QUANTITY"].ToString());
                        //for (int j = 0; j < Selections3DPro.Length; j++)
                        //{
                        //    if (Bingo1st.Any(str => str.Contains(Selections3DPro[j])) && Selections3DPro[0].ToString() != Selections3DPro[1].ToString())
                        //    {
                        //        prize7th += int.Parse(dtSelections3DPro.Rows[i]["QUANTITY"].ToString());
                        //    }
                        //}
                        //matched1st = 0;
                        //matched2nd = 0;
                        //matched3rd = 0;
                        //matched4th = 0;
                        //matched5th = 0;
                        //matched6th = 0;
                        //matched7th = 0;
                        //matched8th = 0;
                    }
                    if (matched7th == 1)// giải năm
                    {
                        prize7th += int.Parse(dtSelections3DPro.Rows[i]["QUANTITY"].ToString());
                        //matched1st = 0;
                        //matched2nd = 0;
                        //matched3rd = 0;
                        //matched4th = 0;
                        //matched5th = 0;
                        //matched6th = 0;
                        //matched7th = 0;
                        //matched8th = 0;
                    }
                    if (matched7th == 2)// giải năm
                    {
                        prize7th += int.Parse(dtSelections3DPro.Rows[i]["QUANTITY"].ToString()) * 2;
                        //matched1st = 0;
                        //matched2nd = 0;
                        //matched3rd = 0;
                        //matched4th = 0;
                        //matched5th = 0;
                        //matched6th = 0;
                        //matched7th = 0;
                        //matched8th = 0;
                    }
                    if (matched8th > 0)// giải sáu
                    {
                        prize8th += int.Parse(dtSelections3DPro.Rows[i]["QUANTITY"].ToString());
                        //matched1st = 0;
                        //matched2nd = 0;
                        //matched3rd = 0;
                        //matched4th = 0;
                        //matched5th = 0;
                        //matched6th = 0;
                        //matched7th = 0;
                        //matched8th = 0;
                    }
                    matched1st = 0;
                    matched2nd = 0;
                    matched3rd = 0;
                    matched4th = 0;
                    matched5th = 0;
                    matched6th = 0;
                    matched7th = 0;
                    matched8th = 0;
                }
                Globals.WriteLog("Non prize : " + nonprize.ToString());
                Globals.WriteLog("Prize 1: " + prize1st.ToString());
                Globals.WriteLog("Prize 2: " + prize2nd.ToString());
                Globals.WriteLog("Prize 3: " + prize3rd.ToString());
                Globals.WriteLog("Prize Encourage: " + prize4th.ToString());
                Globals.WriteLog("Prize 4: " + prize5th.ToString());
                Globals.WriteLog("Prize 5: " + prize6th.ToString());
                Globals.WriteLog("Prize 6: " + prize7th.ToString());
                Globals.WriteLog("Prize 7: " + prize8th.ToString());
            }

        }
    }
}
