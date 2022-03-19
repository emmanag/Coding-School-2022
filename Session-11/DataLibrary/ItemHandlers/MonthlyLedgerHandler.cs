﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.ItemHandlers
{
    public class MonthlyLedgerHandler
    {
        public MonthlyLedgerHandler()
        {

        }

        //public decimal GetMonthlyIncome(MonthsEnum month, string year, CarService carService)
        //{
        //    return carService.Transactions.FindAll(t => t.Date.Month == month && t.Date.Year == month)
        //}

        public decimal GetMonthlyExpenses(CarService carService)
        {
            decimal managersSalaries = carService.Managers.Sum(m => m.SallaryPerMonth);
            decimal engineersSalaries = carService.Engineers.Sum(m => m.SallaryPerMonth);
            
            return managersSalaries + engineersSalaries;
        }
    }
}
