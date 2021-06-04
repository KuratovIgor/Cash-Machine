using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CashMachine_Lib;

namespace Test_Task_2
{
    public partial class MainForm : Form
    {
        Account newAccount; //Account on the card
        CashMachine bankomat = new CashMachine(); //Cash machine

        public MainForm()
        {
            InitializeComponent();
            bankomat.Notify += ShowMessage;
        }

        //Click button "Вставить карту"
        private void PasteCard_Click(object sender, EventArgs e)
        {
            newAccount = new Account(15000); //Creating a new account
            GetMoney.Visible = true;
            ShowStatus.Visible = true;
            PutMoney.Visible = true;
            PasteCard.Visible = false;
            FillCashMachine.Visible = false;
            Request.Text = "Выберите операцию";
        }

        //Click button "Снять наличные"
        private void GetMoney_Click(object sender, EventArgs e)
        {
            Screen.Text = "";
            GetMoneyForm newForm = new GetMoneyForm(newAccount, bankomat);
            newForm.ShowDialog();
        }

        //Method for showing notifies
        private void ShowMessage(string message)
        {
            if (message == null)
                Screen.Text = "";

            Screen.Text += message + ' ';
        }

        //Click button "Статус"
        private void ShowStatus_Click(object sender, EventArgs e)
        {
            Request.Text = "Состояние";
            Screen.Text = "";
            bankomat.ShowStatus(newAccount); //Showing status about cash machine and account
        }

        //Click button "Внести наличные"
        private void PutMoney_Click(object sender, EventArgs e)
        {
            PutMoneyForm newForm = new PutMoneyForm(bankomat);
            newForm.ShowDialog();
            Continue.Visible = true;
            Screen.Text = "";
            Request.Text = "Внесение наличных";
            bankomat.PutMoney(newAccount, newForm.GetBalance()); //Putting money

            PutMoney.Visible = false;
            ShowStatus.Visible = false;
            GetMoney.Visible = false;
        }

        //Click button "Продолжить"
        private void Continue_Click(object sender, EventArgs e)
        {
            Continue.Visible = false;
            PutMoney.Visible = true;
            ShowStatus.Visible = true;
            GetMoney.Visible = true;
            Screen.Text = "";
            Request.Text = "Выберите операцию";
        }

        //Click button "Пополнить банкомат"
        private void FillCashMachine_Click(object sender, EventArgs e)
        {
            FillCashMachineForm newForm = new FillCashMachineForm(bankomat);
            newForm.ShowDialog();
            PasteCard.Visible = false;
            OK.Visible = true;
            Screen.Text = "";
            bankomat.FillCashMashine(newForm.GetBalance()); //Filling cash machine
        }

        //Click button "Закончить работу"
        private void Finish_Click(object sender, EventArgs e)
        {
            PutMoney.Visible = false;
            ShowStatus.Visible = false;
            GetMoney.Visible = false;
            PasteCard.Visible = true;
            FillCashMachine.Visible = true;
            Screen.Text = "";
            Request.Text = "Вставьте каротчку";
        }

        private void OK_Click(object sender, EventArgs e)
        {
            PasteCard.Visible = true;
            OK.Visible = false;
            Screen.Text = "";
        }
    }
}