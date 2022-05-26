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
            DataTable dtBingo645 = Globals.QueryToDataTable(Query.getBingo645 +   "'" + Date + "'");
            DataTable dtSelections645 = Globals.QueryToDataTable(Query.getSelections645 + "'" + Date + "'");
            Globals.WriteLog("Start Mega 645");
            if (dtBingo645.Rows.Count > 0 && dtSelections645.Rows.Count > 0)
            {
                Globals.WriteLog(Date);
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
            Globals.WriteLog(Date);
            if (dtBingo3DPro.Rows.Count > 0 && dtSelections3DPro.Rows.Count > 0)
            {

                Bingo1st = dtBingo3DPro.Rows[0]["NUMBER"].ToString().Split(' ');
                Bingo2nd = dtBingo3DPro.Rows[1]["NUMBER"].ToString().Split(' ');
                Bingo3rd = dtBingo3DPro.Rows[2]["NUMBER"].ToString().Split(' ');
                BingoEnc = dtBingo3DPro.Rows[3]["NUMBER"].ToString().Split(' ');


                for (int i = 0; i < dtSelections3DPro.Rows.Count; i++)
                {
                    List<string> lst = new List<string>();
                    lst.AddRange(Bingo1st);
                    lst.AddRange(Bingo2nd);
                    lst.AddRange(Bingo3rd);
                    lst.AddRange(BingoEnc);
                    lst.ToList();

                    List<string> lst2 = new List<string>();
                    lst2.AddRange(Bingo2nd);
                    lst2.AddRange(Bingo3rd);
                    lst2.AddRange(BingoEnc);
                    lst2.ToList();
                    Selections3DPro = dtSelections3DPro.Rows[i]["COMBINATION"].ToString().Split(' ');
                    // Giải 1
                    if (Array.IndexOf(Bingo1st, Selections3DPro[0].ToString()) == 0 && Array.IndexOf(Bingo1st, Selections3DPro[1].ToString()) == 1)
                    {
                        matched1st = 1;
                        lst.Remove(Bingo1st[0]);
                        lst.Remove(Bingo1st[1]);
                    }
                    // Giải 2
                    if (Array.IndexOf(Bingo1st, Selections3DPro[0].ToString()) == 1 && Array.IndexOf(Bingo1st, Selections3DPro[1].ToString()) == 0)
                    {
                        matched2nd = 1;
                    }
                    // Giải 3

                    if (Bingo2nd.Any(str => str.Contains(Selections3DPro[0])) && Bingo2nd.Any(str => str.Contains(Selections3DPro[1])) && Selections3DPro[0].ToString() != Selections3DPro[1].ToString())
                    {
                        matched3rd = 1; // =2
                        lst.Remove(Bingo2nd[0]);
                        lst.Remove(Bingo2nd[1]);
                    }

                    // Giải Encou

                    if (Bingo3rd.Any(str => str.Contains(Selections3DPro[0])) && Bingo3rd.Any(str => str.Contains(Selections3DPro[1])) && Selections3DPro[0].ToString() != Selections3DPro[1].ToString())
                    {
                        matched4th = 1; // =2
                        lst.Remove(Bingo3rd[0]);
                        lst.Remove(Bingo3rd[1]);
                    }
                    // Giải 4

                    if (BingoEnc.Any(str => str.Contains(Selections3DPro[0])) && BingoEnc.Any(str => str.Contains(Selections3DPro[1])) && Selections3DPro[0].ToString() != Selections3DPro[1].ToString())
                    {
                        matched5th = 1; // =2
                        lst.Remove(BingoEnc[0]);
                        lst.Remove(BingoEnc[1]);
                    }
                    // Giải 5

                    if (//!Globals.isDuplicate(lst) &&
                            lst.Any(str => str.Contains(Selections3DPro[0])) &&
                            lst.Any(str => str.Contains(Selections3DPro[1])) &&
                            Selections3DPro[0].ToString() != Selections3DPro[1].ToString()
                            )
                    {
                        matched6th = 1; // =2
                        Globals.WriteLog(Selections3DPro[0].ToString() + ' ' + Selections3DPro[1].ToString() + ' ' + dtSelections3DPro.Rows[i]["QUANTITY"].ToString());
                    }

                    // Giải 6
                    if (Bingo1st.Any(str => str.Contains(Selections3DPro[0])) || Bingo1st.Any(str => str.Contains(Selections3DPro[1])))
                    {
                        if ((Selections3DPro[0].ToString() != Selections3DPro[1].ToString()))
                            matched7th = 1;
                        if ((Selections3DPro[0].ToString() == Selections3DPro[1].ToString()))
                            matched7th = 2;
                    }
                    // Giải 7
                    if (lst2.Any(str => str.Contains(Selections3DPro[0].ToString()) || lst2.Any(str1 => str1.Contains(Selections3DPro[1].ToString()))))
                    {
                        matched8th = 1;
                        if (lst2.Any(str => str.Contains(Selections3DPro[0].ToString()) && lst2.Any(str1 => str1.Contains(Selections3DPro[1].ToString()))))
                            //if (Selections3DPro[1].ToString() == Selections3DPro[0].ToString())
                            matched8th = 2;
                    }


                    /////=============/////=============/////=============GET RESULT=============/////=============/////=============/////=============/////
                    if (matched1st < 1 && matched2nd < 1 && matched3rd < 2 && matched4th < 2 && matched5th < 2 && matched6th < 2 && matched7th < 1 && matched8th < 1)
                    {
                        nonprize += int.Parse(dtSelections3DPro.Rows[i]["QUANTITY"].ToString());

                    }
                    // giải 1
                    if (matched1st == 1)
                    {
                        prize1st += int.Parse(dtSelections3DPro.Rows[i]["QUANTITY"].ToString());
                        prize7th++;
                    }
                    // giải 2
                    if (matched2nd == 1)
                    {
                        prize2nd += int.Parse(dtSelections3DPro.Rows[i]["QUANTITY"].ToString());
                    }
                    // giải 3
                    if (matched3rd == 1)
                    {
                        prize3rd += int.Parse(dtSelections3DPro.Rows[i]["QUANTITY"].ToString());
                    }
                    // giải Encou
                    if (matched4th == 1)
                    {
                        prize4th += int.Parse(dtSelections3DPro.Rows[i]["QUANTITY"].ToString());
                    }
                    // giải 4
                    if (matched5th == 1)
                    {
                        prize5th += int.Parse(dtSelections3DPro.Rows[i]["QUANTITY"].ToString());
                    }
                    // giải 5
                    if (matched6th == 1)
                    {
                        prize6th += int.Parse(dtSelections3DPro.Rows[i]["QUANTITY"].ToString());
                    }
                    // giải 6
                    if (matched7th == 1)
                    {
                        prize7th += int.Parse(dtSelections3DPro.Rows[i]["QUANTITY"].ToString());
                    }
                    if (matched7th == 2)
                    {
                        prize7th += int.Parse(dtSelections3DPro.Rows[i]["QUANTITY"].ToString()) * 2;
                    }
                    // giải 7
                    if (matched8th == 1)
                        prize8th += int.Parse(dtSelections3DPro.Rows[i]["QUANTITY"].ToString());
                    if (matched8th == 2)
                        prize8th += int.Parse(dtSelections3DPro.Rows[i]["QUANTITY"].ToString()) + 1;

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
        public static void SelectionToPrizeLevel_GameKeno(string Date)
        {
            string CombinationType;
            // Kết quả quay theo kỳ
            DataTable tbDraw = Globals.QueryToDataTable(Query.getKenoDraw + "'" + Date + "'");
            Globals.WriteLog(Date);
            if (tbDraw.Rows.Count > 0)
            {
                for (int i = 0; i < tbDraw.Rows.Count; i++)
                {
                    int c1_1_20 = 0;

                    int c2_2_20 = 0;

                    int c3_2_20 = 0;
                    int c3_3_20 = 0;

                    int c4_2_20 = 0;
                    int c4_3_20 = 0;
                    int c4_4_20 = 0;

                    int c5_3_20 = 0;
                    int c5_4_20 = 0;
                    int c5_5_20 = 0;

                    int c6_3_20 = 0;
                    int c6_4_20 = 0;
                    int c6_5_20 = 0;
                    int c6_6_20 = 0;

                    int c7_3_20 = 0;
                    int c7_4_20 = 0;
                    int c7_5_20 = 0;
                    int c7_6_20 = 0;
                    int c7_7_20 = 0;

                    int c8_0_20 = 0;
                    int c8_4_20 = 0;
                    int c8_5_20 = 0;
                    int c8_6_20 = 0;
                    int c8_7_20 = 0;
                    int c8_8_20 = 0;

                    int c9_0_20 = 0;
                    int c9_4_20 = 0;
                    int c9_5_20 = 0;
                    int c9_6_20 = 0;
                    int c9_7_20 = 0;
                    int c9_8_20 = 0;
                    int c9_9_20 = 0;

                    int c10_0_20 = 0;
                    int c10_5_20 = 0;
                    int c10_6_20 = 0;
                    int c10_7_20 = 0;
                    int c10_8_20 = 0;
                    int c10_9_20 = 0;
                    int c10_10_20 = 0;

                    int U_11_12 = 0;
                    int U_13 = 0;
                    int EqualUL = 0;
                    int L_11_12 = 0;
                    int L_13 = 0;

                    int E_13_14 = 0;
                    int E_15 = 0;
                    int E_11_12 = 0;
                    int EqualOE = 0;
                    int O_11_12 = 0;
                    int O_13_14 = 0;
                    int O_15 = 0;
                    string DrawId = tbDraw.Rows[i]["DRAWID"].ToString();

                    string[] BingoKeno;
                    string[] SelectionsKeno;

                    DataTable tbBingoKeno = Globals.QueryToDataTable("SELECT TOP 1 NUMBER FROM CORE_DL WHERE  LIATYPE = 5 AND DRAWDATE =" + "'" + Date + "' AND DRAWID = " + "'" + DrawId + "'");
                    DataTable tbSelectionsKeno = Globals.QueryToDataTable("SELECT COMBINATION,QUANTITY FROM CORE_DCS_KENO WHERE CAST('20'|| RIGHT(FILENAME,6) AS DATE) =" + "'" + Date + "' AND CAST(SUBSTRING(FILENAME,24,7) AS VARCHAR(10)) =" + "'" + DrawId + "'");

                    BingoKeno = tbBingoKeno.Rows[0]["NUMBER"].ToString().Split(' ');
                    for (int j = 0; j < tbSelectionsKeno.Rows.Count; j++)//
                    {
                        CombinationType = Globals.CheckTypeKeno(tbSelectionsKeno.Rows[j]["COMBINATION"].ToString());
                        switch (CombinationType)
                        {
                            case "Selected":
                                SelectionsKeno = tbSelectionsKeno.Rows[j]["COMBINATION"].ToString().Split(',');
                                if (SelectionsKeno.Length == 1)
                                {
                                    if (BingoKeno.Any(str => str.Contains(SelectionsKeno[0].PadLeft(2, '0'))))
                                        c1_1_20 += int.Parse(tbSelectionsKeno.Rows[j]["QUANTITY"].ToString());
                                }
                                if (SelectionsKeno.Length == 2)
                                {
                                    int matched = 0;
                                    for (int z = 0; z < 2; z++)
                                    {
                                        if (BingoKeno.Any(str => str.Contains(SelectionsKeno[z].PadLeft(2, '0'))))
                                            matched++;

                                    }
                                    if (matched == 2)
                                        c2_2_20 += int.Parse(tbSelectionsKeno.Rows[j]["QUANTITY"].ToString());

                                }
                                if (SelectionsKeno.Length == 3)
                                {
                                    int matched = 0;
                                    for (int z = 0; z < 3; z++)
                                    {
                                        if (BingoKeno.Any(str => str.Contains(SelectionsKeno[z].PadLeft(2, '0'))))
                                            matched++;

                                    }
                                    if (matched == 2)
                                        c3_2_20 += int.Parse(tbSelectionsKeno.Rows[j]["QUANTITY"].ToString());
                                    if (matched == 3)
                                        c3_3_20 += int.Parse(tbSelectionsKeno.Rows[j]["QUANTITY"].ToString());
                                }
                                if (SelectionsKeno.Length == 4)
                                {
                                    int matched = 0;
                                    for (int z = 0; z < 4; z++)
                                    {
                                        if (BingoKeno.Any(str => str.Contains(SelectionsKeno[z].PadLeft(2, '0'))))
                                            matched++;

                                    }
                                    if (matched == 2)
                                        c4_2_20 += int.Parse(tbSelectionsKeno.Rows[j]["QUANTITY"].ToString());
                                    if (matched == 3)
                                        c4_3_20 += int.Parse(tbSelectionsKeno.Rows[j]["QUANTITY"].ToString());
                                    if (matched == 4)
                                        c4_3_20 += int.Parse(tbSelectionsKeno.Rows[j]["QUANTITY"].ToString());
                                }
                                if (SelectionsKeno.Length == 5)
                                {
                                    int matched = 0;
                                    for (int z = 0; z < 5; z++)
                                    {
                                        if (BingoKeno.Any(str => str.Contains(SelectionsKeno[z].PadLeft(2, '0'))))
                                            matched++;

                                    }
                                    if (matched == 3)
                                        c5_3_20 += int.Parse(tbSelectionsKeno.Rows[j]["QUANTITY"].ToString());
                                    if (matched == 4)
                                        c5_4_20 += int.Parse(tbSelectionsKeno.Rows[j]["QUANTITY"].ToString());
                                    if (matched == 5)
                                        c5_5_20 += int.Parse(tbSelectionsKeno.Rows[j]["QUANTITY"].ToString());
                                }
                                if (SelectionsKeno.Length == 6)
                                {
                                    int matched = 0;
                                    for (int z = 0; z < 6; z++)
                                    {
                                        if (BingoKeno.Any(str => str.Contains(SelectionsKeno[z].PadLeft(2, '0'))))
                                            matched++;

                                    }
                                    if (matched == 3)
                                        c6_3_20 += int.Parse(tbSelectionsKeno.Rows[j]["QUANTITY"].ToString());
                                    if (matched == 4)
                                        c6_4_20 += int.Parse(tbSelectionsKeno.Rows[j]["QUANTITY"].ToString());
                                    if (matched == 5)
                                        c6_5_20 += int.Parse(tbSelectionsKeno.Rows[j]["QUANTITY"].ToString());
                                    if (matched == 6)
                                        c6_6_20 += int.Parse(tbSelectionsKeno.Rows[j]["QUANTITY"].ToString());
                                }
                                if (SelectionsKeno.Length == 7)
                                {
                                    int matched = 0;
                                    for (int z = 0; z < 7; z++)
                                    {
                                        if (BingoKeno.Any(str => str.Contains(SelectionsKeno[z].PadLeft(2, '0'))))
                                            matched++;

                                    }
                                    if (matched == 3)
                                        c7_3_20 += int.Parse(tbSelectionsKeno.Rows[j]["QUANTITY"].ToString());
                                    if (matched == 4)
                                        c7_4_20 += int.Parse(tbSelectionsKeno.Rows[j]["QUANTITY"].ToString());
                                    if (matched == 5)
                                        c7_5_20 += int.Parse(tbSelectionsKeno.Rows[j]["QUANTITY"].ToString());
                                    if (matched == 6)
                                        c7_6_20 += int.Parse(tbSelectionsKeno.Rows[j]["QUANTITY"].ToString());
                                    if (matched == 7)
                                        c7_7_20 += int.Parse(tbSelectionsKeno.Rows[j]["QUANTITY"].ToString());
                                }
                                if (SelectionsKeno.Length == 8)
                                {
                                    int matched = 0;
                                    for (int z = 0; z < 8; z++)
                                    {
                                        if (BingoKeno.Any(str => str.Contains(SelectionsKeno[z].PadLeft(2, '0'))))
                                            matched++;

                                    }
                                    if (matched == 0)
                                        c8_0_20 += int.Parse(tbSelectionsKeno.Rows[j]["QUANTITY"].ToString());
                                    if (matched == 4)
                                        c8_4_20 += int.Parse(tbSelectionsKeno.Rows[j]["QUANTITY"].ToString());
                                    if (matched == 5)
                                        c8_5_20 += int.Parse(tbSelectionsKeno.Rows[j]["QUANTITY"].ToString());
                                    if (matched == 6)
                                        c8_6_20 += int.Parse(tbSelectionsKeno.Rows[j]["QUANTITY"].ToString());
                                    if (matched == 7)
                                        c8_7_20 += int.Parse(tbSelectionsKeno.Rows[j]["QUANTITY"].ToString());
                                    if (matched == 8)
                                        c8_8_20 += int.Parse(tbSelectionsKeno.Rows[j]["QUANTITY"].ToString());
                                }
                                if (SelectionsKeno.Length == 9)
                                {
                                    int matched = 0;
                                    for (int z = 0; z < 9; z++)
                                    {
                                        if (BingoKeno.Any(str => str.Contains(SelectionsKeno[z].PadLeft(2, '0'))))
                                            matched++;

                                    }
                                    if (matched == 0)
                                        c9_0_20 += int.Parse(tbSelectionsKeno.Rows[j]["QUANTITY"].ToString());
                                    if (matched == 4)
                                        c9_4_20 += int.Parse(tbSelectionsKeno.Rows[j]["QUANTITY"].ToString());
                                    if (matched == 5)
                                        c9_5_20 += int.Parse(tbSelectionsKeno.Rows[j]["QUANTITY"].ToString());
                                    if (matched == 6)
                                        c9_6_20 += int.Parse(tbSelectionsKeno.Rows[j]["QUANTITY"].ToString());
                                    if (matched == 7)
                                        c9_7_20 += int.Parse(tbSelectionsKeno.Rows[j]["QUANTITY"].ToString());
                                    if (matched == 8)
                                        c9_8_20 += int.Parse(tbSelectionsKeno.Rows[j]["QUANTITY"].ToString());
                                    if (matched == 9)
                                        c9_9_20 += int.Parse(tbSelectionsKeno.Rows[j]["QUANTITY"].ToString());
                                }
                                if (SelectionsKeno.Length == 10)
                                {
                                    int matched = 0;
                                    for (int z = 0; z < 10; z++)
                                    {
                                        if (BingoKeno.Any(str => str.Contains(SelectionsKeno[z].PadLeft(2, '0'))))
                                            matched++;

                                    }
                                    if (matched == 0)
                                        c10_0_20 += int.Parse(tbSelectionsKeno.Rows[j]["QUANTITY"].ToString());
                                    if (matched == 5)
                                        c10_5_20 += int.Parse(tbSelectionsKeno.Rows[j]["QUANTITY"].ToString());
                                    if (matched == 6)
                                        c10_6_20 += int.Parse(tbSelectionsKeno.Rows[j]["QUANTITY"].ToString());
                                    if (matched == 7)
                                        c10_7_20 += int.Parse(tbSelectionsKeno.Rows[j]["QUANTITY"].ToString());
                                    if (matched == 8)
                                        c10_8_20 += int.Parse(tbSelectionsKeno.Rows[j]["QUANTITY"].ToString());
                                    if (matched == 9)
                                        c10_9_20 += int.Parse(tbSelectionsKeno.Rows[j]["QUANTITY"].ToString());
                                    if (matched == 10)
                                        c10_10_20 += int.Parse(tbSelectionsKeno.Rows[j]["QUANTITY"].ToString());
                                }
                                break;
                            case "Upper":
                                int matchedUpper = 0;
                                for (int z = 0; z < BingoKeno.Length; z++)
                                {
                                    if (int.Parse(BingoKeno[z].ToString()) >= 41)
                                        matchedUpper++;
                                }

                                if (matchedUpper == 11 || matchedUpper == 12)
                                    U_11_12 += int.Parse(tbSelectionsKeno.Rows[j]["QUANTITY"].ToString());
                                if (matchedUpper > 13)
                                    U_13 += int.Parse(tbSelectionsKeno.Rows[j]["QUANTITY"].ToString());
                                break;
                            case "Lower":
                                int matchedLower = 0;
                                for (int z = 0; z < BingoKeno.Length; z++)
                                {
                                    if (int.Parse(BingoKeno[z].ToString()) < 41)
                                        matchedLower++;
                                }
                                if (matchedLower == 11 || matchedLower == 12)
                                    L_11_12 += int.Parse(tbSelectionsKeno.Rows[j]["QUANTITY"].ToString());
                                if (matchedLower > 13)
                                    L_13 += int.Parse(tbSelectionsKeno.Rows[j]["QUANTITY"].ToString());
                                break;
                            case "Equal Upper/Lower":
                                int matchedUL = 0;
                                for (int z = 0; z < BingoKeno.Length; z++)
                                {
                                    if (int.Parse(BingoKeno[z].ToString()) < 41)
                                        matchedUL++;
                                }
                                if (matchedUL == 10)
                                    EqualUL += int.Parse(tbSelectionsKeno.Rows[j]["QUANTITY"].ToString());
                                break;
                            case "Even":
                                int matchedEven = 0;
                                for (int z = 0; z < BingoKeno.Length; z++)
                                {
                                    if (int.Parse(BingoKeno[z].ToString()) % 2 == 0)
                                        matchedEven++;
                                }
                                if (matchedEven == 13 || matchedEven == 14)
                                    E_13_14 += int.Parse(tbSelectionsKeno.Rows[j]["QUANTITY"].ToString());
                                if (matchedEven >= 15)
                                    E_15 += int.Parse(tbSelectionsKeno.Rows[j]["QUANTITY"].ToString());
                                break;
                            case "Odd":
                                int matchedOdd = 0;
                                for (int z = 0; z < BingoKeno.Length; z++)
                                {
                                    if (int.Parse(BingoKeno[z].ToString()) % 2 != 0)
                                        matchedOdd++;
                                }
                                if (matchedOdd == 13 || matchedOdd == 14)
                                    O_13_14 += int.Parse(tbSelectionsKeno.Rows[j]["QUANTITY"].ToString());
                                if (matchedOdd >= 15)
                                    O_15 += int.Parse(tbSelectionsKeno.Rows[j]["QUANTITY"].ToString());
                                break;
                            case "Equal Even/Odd":
                                int matchedEV = 0;
                                for (int z = 0; z < BingoKeno.Length; z++)
                                {
                                    if (int.Parse(BingoKeno[z].ToString()) % 2 == 0)
                                        matchedEV++;
                                }
                                if (matchedEV == 10)
                                    EqualOE += int.Parse(tbSelectionsKeno.Rows[j]["QUANTITY"].ToString());
                                break;
                            case "Even 11-12":
                                int matchedEven1112 = 0;
                                for (int z = 0; z < BingoKeno.Length; z++)
                                {
                                    if (int.Parse(BingoKeno[z].ToString()) % 2 == 0)
                                        matchedEven1112++;
                                }
                                if (matchedEven1112 == 11 || matchedEven1112 == 12)
                                    E_11_12 += int.Parse(tbSelectionsKeno.Rows[j]["QUANTITY"].ToString());
                                break;
                            case "Odd 11-12":
                                int matchedOdd1112 = 0;
                                for (int z = 0; z < BingoKeno.Length; z++)
                                {
                                    if (int.Parse(BingoKeno[z].ToString()) % 2 == 0)
                                        matchedOdd1112++;
                                }
                                if (matchedOdd1112 == 11 || matchedOdd1112 == 12)
                                    O_11_12 += int.Parse(tbSelectionsKeno.Rows[j]["QUANTITY"].ToString());
                                break;
                        }



                    }
                    Globals.WriteLog("1 Spot Level 1 " + c1_1_20);
                    Globals.WriteLog("2 Spot Level 1 " + c2_2_20);

                    Globals.WriteLog("3 Spot Level 1 " + c3_3_20);
                    Globals.WriteLog("3 Spot Level 2 " + c3_2_20);

                    Globals.WriteLog("4 Spot Level 1 " + c4_4_20);
                    Globals.WriteLog("4 Spot Level 2 " + c4_3_20);
                    Globals.WriteLog("4 Spot Level 3 " + c4_2_20);

                    Globals.WriteLog("5 Spot Level 1 " + c5_5_20);
                    Globals.WriteLog("5 Spot Level 2 " + c5_4_20);
                    Globals.WriteLog("5 Spot Level 3 " + c5_3_20);

                    Globals.WriteLog("6 Spot Level 1 " + c6_6_20);
                    Globals.WriteLog("6 Spot Level 2 " + c6_5_20);
                    Globals.WriteLog("6 Spot Level 3 " + c6_4_20);
                    Globals.WriteLog("6 Spot Level 4 " + c6_3_20);

                    Globals.WriteLog("7 Spot Level 1 " + c7_7_20);
                    Globals.WriteLog("7 Spot Level 3 " + c7_5_20);
                    Globals.WriteLog("7 Spot Level 2 " + c7_6_20);
                    Globals.WriteLog("7 Spot Level 4 " + c7_4_20);
                    Globals.WriteLog("7 Spot Level 5 " + c7_3_20);

                    Globals.WriteLog("8 Spot Level 1 " + c8_8_20);
                    Globals.WriteLog("8 Spot Level 2 " + c8_7_20);
                    Globals.WriteLog("8 Spot Level 3 " + c8_6_20);
                    Globals.WriteLog("8 Spot Level 4 " + c8_5_20);
                    Globals.WriteLog("8 Spot Level 5 " + c8_4_20);
                    Globals.WriteLog("8 Spot Level 6 " + c8_0_20);

                    Globals.WriteLog("9 Spot Level 1 " + c9_9_20);
                    Globals.WriteLog("9 Spot Level 2 " + c9_8_20);
                    Globals.WriteLog("9 Spot Level 3 " + c9_7_20);
                    Globals.WriteLog("9 Spot Level 4 " + c9_6_20);
                    Globals.WriteLog("9 Spot Level 5 " + c9_5_20);
                    Globals.WriteLog("9 Spot Level 6 " + c9_4_20);
                    Globals.WriteLog("9 Spot Level 7 " + c9_0_20);

                    Globals.WriteLog("10 Spot Level 1 " + c10_10_20);
                    Globals.WriteLog("10 Spot Level 2 " + c10_9_20);
                    Globals.WriteLog("10 Spot Level 3 " + c10_8_20);
                    Globals.WriteLog("10 Spot Level 4 " + c10_7_20);
                    Globals.WriteLog("10 Spot Level 5 " + c10_6_20);
                    Globals.WriteLog("10 Spot Level 6 " + c10_5_20);
                    Globals.WriteLog("10 Spot Level 7 " + c10_0_20);

                    Globals.WriteLog("Upper level 1 " + U_13);
                    Globals.WriteLog("Upper level 2 " + U_11_12);
                    Globals.WriteLog("Lower level 1 " + L_11_12);
                    Globals.WriteLog("Lower level 2 " + L_13);

                    Globals.WriteLog("Even level 1 " + E_15);
                    Globals.WriteLog("Even level 2 " + E_13_14);
                    Globals.WriteLog("Odd level 1 " + O_15);
                    Globals.WriteLog("Odd level 2 " + O_13_14);

                    Globals.WriteLog("Equal UL " + EqualUL);

                    Globals.WriteLog("Equal EO " + EqualOE);
                    Globals.WriteLog("Even 11-12 " + E_11_12);
                    Globals.WriteLog("Odd 11-12 " + O_11_12);

                }
            }

        }
        public static void SelectionToPrizeLevel_Game3D(string Date)
        {
            string CombinationType;
            string[] Bingo3D1st;
            string[] Bingo3D2nd;
            string[] Bingo3D3rd;
            string[] Bingo3DEnc;
            string Selections3D;
            string[] Selections3D3D;

            int D1st = 0;
            int D2nd = 0;
            int D3rd = 0;
            int DEnc = 0;

            int DD1st = 0;
            int DD2nd = 0;
            int DD3rd = 0;
            int DD4th = 0;
            int DD5th = 0;
            int DD6th = 0;
            int DD7th = 0;

            int DD5thNotDD1st = 0;

            DataTable tbBingo3D = Globals.QueryToDataTable("SELECT NUMBER FROM CORE_DL WHERE IFNULL(NUMBER,'') <> '' AND  LIATYPE = 6 AND DRAWDATE =" + "'" + Date + "' Order by id");
            DataTable tbSelections3D = Globals.QueryToDataTable(Query.getSelections3D + "'" + Date + "'");


            Bingo3D1st = tbBingo3D.Rows[0]["NUMBER"].ToString().Split(' ');
            Bingo3D2nd = tbBingo3D.Rows[1]["NUMBER"].ToString().Split(' ');
            Bingo3D3rd = tbBingo3D.Rows[2]["NUMBER"].ToString().Split(' ');
            Bingo3DEnc = tbBingo3D.Rows[3]["NUMBER"].ToString().Split(' ');

            List<string> lst = new List<string>();
            lst.AddRange(Bingo3D1st);
            lst.AddRange(Bingo3D2nd);
            lst.AddRange(Bingo3D3rd);
            lst.AddRange(Bingo3DEnc);
            lst.ToList();

            List<string> lst2 = new List<string>();
            lst2.AddRange(Bingo3D2nd);
            lst2.AddRange(Bingo3D3rd);
            lst2.AddRange(Bingo3DEnc);
            lst2.ToList();

            Globals.WriteLog(Date);
            Globals.WriteLog("=========================");
            for (int j = 0; j < tbSelections3D.Rows.Count; j++)//
            {
                CombinationType = Globals.CheckType3D(tbSelections3D.Rows[j]["COMBINATION"].ToString());

                switch (CombinationType)
                {
                    case "3D":
                        Selections3D = tbSelections3D.Rows[j]["COMBINATION"].ToString();
                        if (Bingo3D1st.Contains(Selections3D))
                        {
                            D1st += int.Parse(tbSelections3D.Rows[j]["QUANTITY"].ToString());
                        }
                        if (Bingo3D2nd.Contains(Selections3D))
                        {
                            D2nd += int.Parse(tbSelections3D.Rows[j]["QUANTITY"].ToString());
                        }
                        if (Bingo3D3rd.Contains(Selections3D))
                        {
                            D3rd += int.Parse(tbSelections3D.Rows[j]["QUANTITY"].ToString());
                        }
                        if (Bingo3DEnc.Contains(Selections3D))
                        {
                            DEnc += int.Parse(tbSelections3D.Rows[j]["QUANTITY"].ToString());
                        }
                        break;

                    case "3D+3D":
                        Boolean check1st = false;
                        Selections3D3D = tbSelections3D.Rows[j]["COMBINATION"].ToString().Split('+');
                        ////1st
                        if (Bingo3D1st.Any(str => str.Contains(Selections3D3D[0])) && Bingo3D1st.Any(str => str.Contains(Selections3D3D[1])) && Selections3D3D[0] != Selections3D3D[1])
                        {
                            DD1st += int.Parse(tbSelections3D.Rows[j]["QUANTITY"].ToString());
                            check1st = true;
                            //Globals.WriteLog("1st "+tbSelections3D.Rows[j]["COMBINATION"].ToString() + " || " + tbSelections3D.Rows[j]["QUANTITY"].ToString());
                        }
                        ////2nd
                        if (Bingo3D2nd.Any(str => str.Contains(Selections3D3D[0])) && Bingo3D2nd.Any(str => str.Contains(Selections3D3D[1])) && Selections3D3D[0] != Selections3D3D[1])
                        {
                            DD2nd += int.Parse(tbSelections3D.Rows[j]["QUANTITY"].ToString());
                        }
                        ////3rd
                        if (Bingo3D3rd.Any(str => str.Contains(Selections3D3D[0])) && Bingo3D3rd.Any(str => str.Contains(Selections3D3D[1])) && Selections3D3D[0] != Selections3D3D[1])
                        {
                            DD3rd += int.Parse(tbSelections3D.Rows[j]["QUANTITY"].ToString());
                        }
                        ////4th
                        if (Bingo3DEnc.Any(str => str.Contains(Selections3D3D[0])) && Bingo3DEnc.Any(str => str.Contains(Selections3D3D[1])) && Selections3D3D[0] != Selections3D3D[1])
                        {
                            DD4th += int.Parse(tbSelections3D.Rows[j]["QUANTITY"].ToString());
                        }
                        ////5th
                        if (lst.Any(str => str.Contains(Selections3D3D[0])) && lst.Any(str => str.Contains(Selections3D3D[1])) && (Selections3D3D[0] != Selections3D3D[1]))
                        {
                            var duplicateKeys = lst.GroupBy(x => x)
                                                      .Where(g => g.Count() > 1)
                                                      .Select(y => y.Key)
                                                      .ToList();
                            if (duplicateKeys?.Any() == false)
                            {
                                DD5th += int.Parse(tbSelections3D.Rows[j]["QUANTITY"].ToString());
                                Globals.WriteLog(tbSelections3D.Rows[j]["COMBINATION"].ToString() + " || " + tbSelections3D.Rows[j]["QUANTITY"].ToString());
                                if (Bingo3D1st.Any(str => str.Contains(Selections3D3D[0])) || Bingo3D1st.Any(str => str.Contains(Selections3D3D[1])))
                                {
                                    DD5thNotDD1st += int.Parse(tbSelections3D.Rows[j]["QUANTITY"].ToString());

                                }
                            }
                            else
                            {
                                if (Selections3D3D.Any(x => duplicateKeys.Any(y => y == x)) == true)
                                {
                                    DD5th += int.Parse(tbSelections3D.Rows[j]["QUANTITY"].ToString()) * 2;

                                    var intersection = Bingo3D1st.Intersect(duplicateKeys);
                                    if (intersection.Any(str => str.Contains(Selections3D3D[0])) || intersection.Any(str => str.Contains(Selections3D3D[1])))
                                    DD5thNotDD1st += int.Parse(tbSelections3D.Rows[j]["QUANTITY"].ToString());

                                    Globals.WriteLog(tbSelections3D.Rows[j]["COMBINATION"].ToString() + " || " + tbSelections3D.Rows[j]["QUANTITY"].ToString());
                                    if (Bingo3D1st.Any(str => str.Contains(Selections3D3D[0])) || Bingo3D1st.Any(str => str.Contains(Selections3D3D[1])))
                                    {
                                        //var intersection = Bingo3D1st.Intersect(duplicateKeys);
                                        //if (intersection.Any(str => str.Contains(Selections3D3D[0])) || intersection.Any(str => str.Contains(Selections3D3D[1])))
                                            DD5thNotDD1st += int.Parse(tbSelections3D.Rows[j]["QUANTITY"].ToString())*2;
                                        //else
                                           //DD5thNotDD1st += int.Parse(tbSelections3D.Rows[j]["QUANTITY"].ToString());
                                    }


                                }
                                else
                                {
                                    DD5th += int.Parse(tbSelections3D.Rows[j]["QUANTITY"].ToString());
                                    Globals.WriteLog(tbSelections3D.Rows[j]["COMBINATION"].ToString() + " || " + tbSelections3D.Rows[j]["QUANTITY"].ToString());
                                    if (Bingo3D1st.Any(str => str.Contains(Selections3D3D[0])) || Bingo3D1st.Any(str => str.Contains(Selections3D3D[1])))
                                    {
                                        DD5thNotDD1st += int.Parse(tbSelections3D.Rows[j]["QUANTITY"].ToString());
                                    }
                                }
                            }
                            //if (duplicateKeys?.Any() == true)
                            //{

                            //    if (duplicateKeys.Any(str => str.Contains(Selections3D3D[0])) || duplicateKeys.Any(str => str.Contains(Selections3D3D[1])))
                            //    {
                            //        DD5th += int.Parse(tbSelections3D.Rows[j]["QUANTITY"].ToString()) * 2;
                            //        Globals.WriteLog(tbSelections3D.Rows[j]["COMBINATION"].ToString() + " || " + tbSelections3D.Rows[j]["QUANTITY"].ToString() + "|| x 2");
                            //        if ((Bingo3D1st.Any(str => str.Contains(Selections3D3D[0])) || Bingo3D1st.Any(str => str.Contains(Selections3D3D[1]))))
                            //        {
                            //            foreach(var z in duplicateKeys)
                            //            {
                            //                if (Bingo3D1st.Contains(z.ToString()))
                            //                    DD5thNotDD1st += int.Parse(tbSelections3D.Rows[j]["QUANTITY"].ToString());
                            //                //else
                            //                //    DD5thNotDD1st += int.Parse(tbSelections3D.Rows[j]["QUANTITY"].ToString())*2;
                            //            }

                            //            Globals.WriteLog(tbSelections3D.Rows[j]["COMBINATION"].ToString() + " || " + tbSelections3D.Rows[j]["QUANTITY"].ToString() + "|| bỏ");
                            //        }

                            //    }
                            //    else
                            //    {
                            //        DD5th += int.Parse(tbSelections3D.Rows[j]["QUANTITY"].ToString());
                            //        //Globals.WriteLog(tbSelections3D.Rows[j]["COMBINATION"].ToString() + " || " + tbSelections3D.Rows[j]["QUANTITY"].ToString());
                            //        if (Bingo3D1st.Any(str => str.Contains(Selections3D3D[0])) || Bingo3D1st.Any(str => str.Contains(Selections3D3D[1])))
                            //        {
                            //            DD5thNotDD1st += int.Parse(tbSelections3D.Rows[j]["QUANTITY"].ToString());
                            //            //Globals.WriteLog(tbSelections3D.Rows[j]["COMBINATION"].ToString() + " || " + tbSelections3D.Rows[j]["QUANTITY"].ToString() + "|| bỏ");
                            //        }

                            //    }

                            //}



                        }
                        ////6th
                        if (Bingo3D1st.Any(str => str.Contains(Selections3D3D[0])) || Bingo3D1st.Any(str => str.Contains(Selections3D3D[1])))
                        {
                            if (Selections3D3D[0] != Selections3D3D[1])
                                DD6th += int.Parse(tbSelections3D.Rows[j]["QUANTITY"].ToString());
                            else
                                DD6th += int.Parse(tbSelections3D.Rows[j]["QUANTITY"].ToString()) * 2;

                            if (check1st == true)
                                DD6th += int.Parse(tbSelections3D.Rows[j]["QUANTITY"].ToString()); ;

                        }
                        ////7th
                        if (lst2.Any(str => str.Contains(Selections3D3D[0])) || lst2.Any(str => str.Contains(Selections3D3D[1])))
                        {
                            var duplicateKeys = lst2.GroupBy(x => x)
                                                      .Where(g => g.Count() > 1)
                                                      .Select(y => y.Key)
                                                      .ToList();
                            if (Selections3D3D[0] != Selections3D3D[1])
                            {
                                if (duplicateKeys?.Any() == true)
                                {
                                    foreach (var x in duplicateKeys)
                                    {
                                        if (x.Contains(Selections3D3D[0]) || x.Contains(Selections3D3D[1]))
                                            DD7th += int.Parse(tbSelections3D.Rows[j]["QUANTITY"].ToString())*2;
                                        else
                                            DD7th += int.Parse(tbSelections3D.Rows[j]["QUANTITY"].ToString());
                                    }
                                }
                                else
                                    DD7th += int.Parse(tbSelections3D.Rows[j]["QUANTITY"].ToString());

                            }

                            else
                            {
                                if (duplicateKeys?.Any() == true)
                                {
                                    foreach (var x in duplicateKeys)
                                    {
                                        if (x.Contains(Selections3D3D[0]) || x.Contains(Selections3D3D[1]))
                                            DD7th += int.Parse(tbSelections3D.Rows[j]["QUANTITY"].ToString()) * 4;
                                        else
                                            DD7th += int.Parse(tbSelections3D.Rows[j]["QUANTITY"].ToString()) * 2;
                                    }
                                }
                                else
                                    DD7th += int.Parse(tbSelections3D.Rows[j]["QUANTITY"].ToString()) * 2;
                                //Globals.WriteLog(tbSelections3D.Rows[j]["COMBINATION"].ToString() + " || " + tbSelections3D.Rows[j]["QUANTITY"].ToString());
                            }

                        }


                        break;
                }
            }
            //if(DD1st>0)
            //    DD6th++;
            Globals.WriteLog("D1st :" + D1st.ToString());
            Globals.WriteLog("D2nd :" + D2nd.ToString());
            Globals.WriteLog("D3rd :" + D3rd.ToString());
            Globals.WriteLog("DEnc :" + DEnc.ToString());

            Globals.WriteLog("DD1st :" + DD1st.ToString());
            Globals.WriteLog("DD2nd :" + DD2nd.ToString());
            Globals.WriteLog("DD3rd :" + DD3rd.ToString());
            Globals.WriteLog("DD4th :" + DD4th.ToString());
            Globals.WriteLog("DD5th :" + DD5th.ToString());
            Globals.WriteLog("DD6th :" + DD6th.ToString());
            Globals.WriteLog("DD7th :" + (DD7th + DD5th - DD5thNotDD1st).ToString());
        }


        public static void DuplicateBingo(DateTime StartDate, DateTime EndDate)
        {
            foreach (DateTime day in Globals.EachDay(StartDate, EndDate))
            {
                var date = day.ToString("yyyyMMdd");
                DataTable tbBingo3D = Globals.QueryToDataTable("SELECT NUMBER FROM CORE_DL WHERE IFNULL(NUMBER,'') <> '' AND  LIATYPE = 6 AND DRAWDATE =" + "'" + date + "' Order by id");
                string[] Bingo3D1st;
                string[] Bingo3D2nd;
                string[] Bingo3D3rd;
                string[] Bingo3DEnc;

                if (tbBingo3D.Rows.Count > 0)
                {
                    Bingo3D1st = tbBingo3D.Rows[0]["NUMBER"].ToString().Split(' ');
                    Bingo3D2nd = tbBingo3D.Rows[1]["NUMBER"].ToString().Split(' ');
                    Bingo3D3rd = tbBingo3D.Rows[2]["NUMBER"].ToString().Split(' ');
                    Bingo3DEnc = tbBingo3D.Rows[3]["NUMBER"].ToString().Split(' ');
                    List<string> lst = new List<string>();
                    lst.AddRange(Bingo3D1st);
                    lst.AddRange(Bingo3D2nd);
                    lst.AddRange(Bingo3D3rd);
                    lst.AddRange(Bingo3DEnc);
                    lst.ToList();
                    var duplicateKeys = lst.GroupBy(x => x)
                        .Where(group => group.Count() > 1)
                        .Select(group => group.Key);

                    foreach (var s in duplicateKeys)
                        Globals.WriteLog(date + " || " + s.ToString());
                }





            }
        }
    }
}
