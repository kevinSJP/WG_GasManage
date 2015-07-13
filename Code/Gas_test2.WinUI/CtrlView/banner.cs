﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using EAS;
using EAS.Services;
using Gas_test2.BLL;

namespace Gas_test2.WinUI.CtrlView
{
    public partial class banner : UserControl
    {
        private string bName = "null";
        private int bNum = 1;

        public string LabelText
        {
            get
            {
                return this.lab_Name.Text;
            }
            set
            {
                this.lab_Name.Text = value;
                this.bName = value;
            }
        }

        public int UDNum
        {
            get
            {
                return int.Parse(this.NoUD.Value.ToString());
            }
            set
            {
                this.NoUD.Value = value;
                this.bNum = value;
            }
        }
        public banner()
        {
            InitializeComponent();

        }

        public banner(string name, int num)
        {
            this.bName = name;
            this.bNum = num;


        }



        public void NoUD_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (NoUD.Value != 0)
                {
                    string a = this.bName;
                    ServiceContainer.GetService<IGasDAL>().UpdateData("GasometerType", "GasometerNum", bNum.ToString(), "GasometerName", a);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("更新异常" + ex.Message);
                return;
            }
        }

        private void banner_Load(object sender, EventArgs e)
        {

        }
    }
}
