using System;
using System.Collections.Generic;

namespace CashMachine_Lib
{
    public class CashMachine
    {
        public Dictionary<int, int> banknotes = new Dictionary<int, int> //Nominal of banknotes
        {
            { 10, 0 }, { 50, 0 }, { 100, 0 }, { 200, 0 }, { 500, 0 }, { 1000, 0 }, { 2000, 0 }, { 5000, 0 }
        };
        private int[] arrayBanknotes = new int[] { 10, 50, 100, 200, 500, 1000, 2000, 5000 };

        public delegate void ShowMessage(string message);
        public event ShowMessage Notify;

        private int _maxCountBanknote = 100; //Maximum quantity of banknotes in cash machine
        private int _countBanknotes = 0; //Quantity of banknotes in cash machine
        private int _balance = 0; //Balance in cash machine

        public int GetMoney(Account account, int countMoney, int nominal) //Getting money from account
        {
            if (countMoney > account.GetBalance())
            {
                Notify?.Invoke("Недостаточно средств на счёте!");

                return account.GetBalance();
            }

            if (countMoney % 10 != 0) //If nominal value isn't can be exist in cash machine
            {
                Notify?.Invoke("К сожалению, в банкомате нет купюр с таким номиналом. Пожалуйста, введите другую сумму!");

                return account.GetBalance();
            }

            int gettingBalance = 0; //For counting money which was get from cash machine

            Notify?.Invoke("ВЫДАЧА НАЛИЧНЫХ\r\n");

            gettingBalance = GetBanknotes(gettingBalance, countMoney, nominal);

            if (IsCanGetting(gettingBalance, countMoney))
            {
                account.SetBalance(-gettingBalance);

                return account.GetBalance();
            }

            Notify?.Invoke(null);
            Notify?.Invoke("Невозможно выдать такую сумму! В банкомате недостаточно банкнот!");

            return account.GetBalance();
        }

        private int GetBanknotes(int gettingBalance, int countMoney, int nominal)
        {
            while (gettingBalance < countMoney)
            {
                if (banknotes[nominal] > 0 && gettingBalance + nominal < countMoney) //If entered banknote can be issuing
                {
                    banknotes[nominal]--;
                    _countBanknotes--;
                    _balance -= nominal;
                    gettingBalance += nominal;
                    //account.SetBalance(-nominal);
                    Notify?.Invoke($"{nominal}");
                }
                else //Else - serching banknote which can be issuing
                {
                    gettingBalance = GetDifferentBanknotes(gettingBalance, countMoney);

                    if (!IsCanGetting(gettingBalance, countMoney)) //If cash machine isn't have needed banknotes
                        break;
                }
            }

            return gettingBalance;
        }

        private bool IsCanGetting(int gettingBalance, int countMoney)
        {
            if (gettingBalance == 0 || _countBanknotes == 0 ||
                gettingBalance > countMoney || gettingBalance < countMoney)
                return false;
            else
                return true;
        }

        private int GetDifferentBanknotes(int balance, int countMoney)
        {
            int autoNominal; //Selected nominal value fron cash machine

            for (int i = banknotes.Count - 1; i >= 0; i--)
            {
                if (balance == countMoney) //If amount fully issued
                    break;

                autoNominal = arrayBanknotes[i]; //Banknote which can be issuing

                //While cash machine can be to issue this banknote
                while (autoNominal + balance <= countMoney && banknotes[autoNominal] > 0)
                {
                    balance += autoNominal;
                    banknotes[autoNominal]--;
                    _countBanknotes--;
                    _balance -= autoNominal;
                    //  account.SetBalance(-autoNominal);
                    Notify?.Invoke($"{autoNominal}");
                }
            }

            return balance;
        }

        public void PutMoney(Account account, List<int> money) //Putting money in account
        {
            int index = 0;
            int sum = 0; //Amount of putting money

            while (index < money.Count)
            {
                banknotes[money[index]]++;
                _countBanknotes++;
                _balance += money[index];

                account.SetBalance(money[index]);

                index++;
            }

            foreach (int nominal in money) //Counting how much money was putting in account
                sum += nominal;

            Notify?.Invoke($"Внесено наличных:\r\n{sum}");
        }

        public void ShowStatus(Account account) //Shoing status about cash machine and account
        {
            Notify?.Invoke($"БАНКОМАТ:\r\nКоличество купюр: {_countBanknotes}\r\nСчёт: {_balance}\r\n\r\n" +
                           $"БАНКОВСКИЙ СЧЁТ:\r\nБаланс: {account.GetBalance()}");
        }

        public void FillCashMashine(List<int> banknote) //Filling cash machine
        {
            if (_countBanknotes > _maxCountBanknote) //If the banknote can't fit in cash machine 
            {
                Notify?.Invoke("Банкомат полон!");
                return;
            }

            Fill(banknote);
            Notify?.Invoke("Банкомат пополнен!");
        }

        private void Fill(List<int> banknote)
        {
            int index = 0;
            while (index < banknote.Count)
            {
                banknotes[banknote[index]]++;
                _countBanknotes++;
                _balance += banknote[index];

                index++;
            }
        }
    }
}
