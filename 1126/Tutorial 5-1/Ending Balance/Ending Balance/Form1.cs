﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ending_Balance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            const decimal INTEREST_RATE = 0.005m;//月利率
            decimal balance;//餘額
            int months;//月份

            if(decimal.TryParse(startingBalTextBox.Text,out balance))
            {
                if (int.TryParse(startingBalTextBox.Text, out months)) ;
                {
                    int count = 1;//迴圈計數器
                    while (count <= months) ;
                    {
                        //計算餘額
                        balance = balance + (INTEREST_RATE * balance);
                        count += 1;
                    }
                    //顯示結果
                    endingBalanceLabel.Text = balance.ToString("c");
                }
                else
                {
                    MessageBox.Show("輸入資料格式錯誤")
                }

            }
            else
            {
                MessageBox.Show("輸入【起始餘額】資料格式錯誤")
            }
        }   
            

            

        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清除 TextBoxes 和 endingBalanceLabel 控制項的內容。
            startingBalTextBox.Text = "";
            monthsTextBox.Text = "";
            endingBalanceLabel.Text = "";

            // 重設焦點。
            startingBalTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }
    }
}
