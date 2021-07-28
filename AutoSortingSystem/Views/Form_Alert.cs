﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoSortingSystem.Admin.Properties;

namespace AutoSortingSystem.Admin.Views
{
    public partial class Form_Alert : Form
    {
        public Form_Alert()
        {
            InitializeComponent();
        }

        public enum enmAction
        {
            wait,
            start,
            close
        }

        public enum enmType
        {
            Success,
            Warning,
            Error,
            Info
        }

        private Form_Alert.enmAction action;

        private int x, y;

        private void btClose_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            action = enmAction.close;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch(this.action)
            {
                case enmAction.wait:
                    timer1.Interval = 5000;
                    action = enmAction.close;
                    break;
                case enmAction.start:
                    timer1.Interval = 1;
                    this.Opacity += 0.1;
                    if (this.x < this.Location.X)
                    {
                        this.Left--;
                    }
                    else
                    {
                        if(this.Opacity == 1.0)
                        {
                            action = enmAction.wait;
                        }
                    }
                    break;
                case enmAction.close:
                    timer1.Interval = 1;
                    this.Opacity -= 0.1;
                    this.Left -= 3;
                    if (base.Opacity == 0.0)
                    {
                        base.Close();
                    }
                    break;
            }
        }

        public void showAlert(string msg, enmType type)
        {
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;
            string fname;

            for (int i = 1; i < 10; i++)
            {
                fname = "alert" + i.ToString();
                Form_Alert frm = (Form_Alert)System.Windows.Forms.Application.OpenForms[fname];
                
                if (frm == null)
                {            
                    this.Name = fname;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                    this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i;
                    this.Location = new Point(this.x, this.y);
                    break;
                }
            }
            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;
            
            switch(type)
            {
                case enmType.Success:
                    this.pbType.Image = Resources.success;
                    this.BackColor = Color.SeaGreen;
                    break;
                case enmType.Error:
                    this.pbType.Image = Resources.error;
                    this.BackColor = Color.DarkRed;
                    break;
                case enmType.Info:
                    this.pbType.Image = Resources.info;
                    this.BackColor = Color.RoyalBlue;
                    break;
                case enmType.Warning:
                    this.pbType.Image = Resources.warning;
                    this.BackColor = Color.DarkOrange;
                    break;
            }

            this.lbMessage.Text = msg;
            this.Show();
            this.BringToFront();
            this.action = enmAction.start;
            this.timer1.Interval = 1;
            timer1.Start();
        }
    }
}
