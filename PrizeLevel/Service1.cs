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
            //debug
            Action.SelectionToPrizeLevel();
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