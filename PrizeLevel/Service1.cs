﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace PrizeLevel
{
    public partial class Service1 : ServiceBase
    {
        private static Timer _timer;
        const double TIMEOUT = 10800000;
        public Service1()
        {
            InitializeComponent();
        }

        public void OnDebug()
        {
            DateTime StartDate;
            DateTime EndDate;

            string fDate = "01/01/2021";
            string tDate = "12/30/2021";

            StartDate = DateTime.Parse(fDate);
            EndDate = DateTime.Parse(tDate);
            //debug
            //Action.SelectionToPrizeLevel_Game645("20210101");
            //Action.SelectionToPrizeLevel_Game655("20210603");
            Action.SelectionToPrizeLevel_Game3DPro("20211209");
            //Action.SelectionToPrizeLevel_GameKeno("20211214");
            //Action.SelectionToPrizeLevel_Game3D("20211208");

            //Action.DuplicateBingo(StartDate,EndDate);
        }

        protected override void OnStart(string[] args)
        {
            base.OnStart(args);
            _timer = new Timer(); //This will set the default interval
            _timer.AutoReset = false;
            _timer.Elapsed += OnTimer;
            _timer.Start();
        }

        private void OnTimer(object sender, ElapsedEventArgs args)
        {
            try
            {
               
            }
            catch (Exception e)
            {
                
            }
            _timer.Stop();
            _timer.Interval = TIMEOUT; //Service time
            _timer.Start();
        }

        protected override void OnStop()
        {
        }
    }
}
