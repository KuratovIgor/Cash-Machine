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
        Account newAccount; //Account on the card
        CashMachine bankomat; //Cash machine
        private int _sumMoney = 0; //Balance for get money

        public GetMoneyForm(Account account, CashMachine machine)
        {
            InitializeComponent();
            newAccount = account;
            bankomat = machine;
        }

        //Click button "10"
        private void Nominal10_Click(object sender, EventArgs e)
        {
            ToIssueMoney(10);
            this.Close();
        }

        //Click button "50"
        private void Nominal50_Click(object sender, EventArgs e)
        {
            ToIssueMoney(50);
            this.Close();
        }

        //Click button "100"
        private void Nominal100_Click(object sender, EventArgs e)
        {
            ToIssueMoney(100); 
            this.Close();
        }

        //Click button "200"
        private void Nominal200_Click(object sender, EventArgs e)
        {
            ToIssueMoney(200);
            this.Close();
        }

        //Click button "500"
        private void Nominal500_Click(object sender, EventArgs e)
        {
            ToIssueMoney(500);
            this.Close();
        }

        //Click button "1000"
        private void Nominal1000_Click(object sender, EventArgs e)
        {
            ToIssueMoney(1000);
            this.Close();
        }

        //Click button "2000"
        private void Nominal2000_Click(object sender, EventArgs e)
        {
            ToIssueMoney(2000);
            this.Close();
        }

        //Click button "5000"
        private void Nominal5000_Click(object sender, EventArgs e)
        {
            ToIssueMoney(5000);
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
                Nominal10.Visible = true;
                Nominal50.Visible = true;
                Nominal100.Visible = true;
                Nominal200.Visible = true;
                Nominal500.Visible = true;
                Nominal1000.Visible = true;
                Nominal2000.Visible = true;
                Nominal5000.Visible = true;
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
            Nominal10.Visible = false;
            Nominal50.Visible = false;
            Nominal100.Visible = false;
            Nominal200.Visible = false;
            Nominal500.Visible = false;
            Nominal1000.Visible = false;
            Nominal2000.Visible = false;
            Nominal5000.Visible = false;
            DifferentSumma.Visible = false;
            Next.Visible = true;
            Request.Text = "Введите сумму";
        }
    }
}
