using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CashMachine_Lib;

namespace Test_Task_2
{
    public partial class GetMoneyForm : Form
    {
        private Account newAccount; //Account on the card
        private CashMachine bankomat; //Cash machine
        private int _sumMoney = 0; //Balance for get money

        public GetMoneyForm(Account account, CashMachine machine)
        {
            InitializeComponent();
            newAccount = account;
            bankomat = machine;
            CreateButtons();
        }

        private void CreateButtons()
        {
            int top = 100;
            int left = 50, firstLeft = 50;
            int index = 0;

            foreach(int key in bankomat.banknotes.Keys)
            {
                Button button = new Button();
                button.Left = left;
                button.Top = top;
                button.Width = 88;
                button.Height = 33;
                button.Text = Convert.ToString(key);
                button.BringToFront();
                button.Name = "Nominal" + key;
                button.Click += Nominal_Click;
                button.Font = new Font(Font.FontFamily, 15);
                this.Controls.Add(button);
                left += button.Width + 20;

                if (index == 5)
                {
                    top += button.Height + 10;
                    left = firstLeft;
                    index = 0;
                }

                index++;
            }
        }

        private void Nominal_Click(object sender, EventArgs eventArgs)
        {
            var button = (Button)sender;

            ToIssueMoney(Convert.ToInt32(button.Text));

            this.Close();
        }

        //Recovering money from cash machine
        private void ToIssueMoney(int nominal)
        {
            if (SumMoney.Text.Length != 0) //If you entered your own amount
                bankomat.GetMoney(newAccount, _sumMoney, nominal); 
            else //If you choosed amount from button
                bankomat.GetMoney(newAccount, nominal, nominal);
        }

        //Click button "Продолжить"
        private void Next_Click(object sender, EventArgs e)
        {
            try
            {
                _sumMoney = Convert.ToInt32(SumMoney.Text); //Getting amount of money from textBox

                SumMoney.Visible = false;
                Next.Visible = false;
                Request.Text = "Выберите номинал купюр";
            }
            catch (Exception)
            {
                MessageBox.Show("Введите число!");
            }
        }

        //Click button "Своя сумма"
        private void DifferentSumma_Click(object sender, EventArgs e)
        {
            SumMoney.Visible = true;
            Next.Visible = true;
            Request.Text = "Введите сумму";
        }
    }
}
