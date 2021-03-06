using Gas_Station.EF.Context;
using Gas_Station.EF.Repositories;
using Gas_Station.Model;
using Gas_Station.Shared.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Gas_Station.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LedgerController : ControllerBase
    {
        private readonly IEntityRepo<Ledger> _ledgerRepo;
        private readonly GasStationContext _context;
        private readonly IEntityRepo<Transaction> _transactionRepo;
        private decimal _rent;



        public LedgerController(IEntityRepo<Ledger> ledgerRepo, GasStationContext context, IEntityRepo<Transaction> transactionRepo)
        {
            _ledgerRepo = ledgerRepo;
            _context = context;
            _transactionRepo = transactionRepo;

        }
        
        [HttpGet("{year}/{month}/{rent}")]
        public async Task<LedgerViewModel> Get(int year, int month, decimal rent)
        {
            var ledgerViewModel = new LedgerViewModel()
            {
                Year = year,
                Month = month
            };
            var ledger = new Ledger()
            {
                Year = year,
                Month = month
            };
            SetRentCost(rent);
            ledgerViewModel.Income = await GetIncome(ledger);
            ledgerViewModel.Expenses = await GetTotalExpences(ledger);
            ledgerViewModel.Total = await GetTotal(ledger);
            return ledgerViewModel;
        }
        private void SetRentCost(decimal rent)
        {
            _rent = rent;
        }
        private async Task<decimal> GetIncome(Ledger ledger)
        {
            var helper = await _transactionRepo.GetAllAsync();
            return helper.Where(transaction => transaction.Date.Year == ledger.Year && transaction.Date.Month == ledger.Month).Sum(transaction => transaction.TotalValue);
        }
        private async Task<decimal> GetTotalExpences(Ledger ledger)
        {
            return GetStuffExpences(ledger) + await GetItemExpences(ledger) + _rent;
        }
        private decimal GetStuffExpences(Ledger ledger)
        {
            decimal expences = 0m;
            foreach (var employee in _context.Employees)
            {
                int daysWorked = CalculateWorkingDays(ledger, employee);
                expences += (employee.SallaryPerMonth / DateTime.DaysInMonth(ledger.Year, ledger.Month)) * daysWorked;
            }
            return expences;
        }
        private async Task<decimal> GetItemExpences(Ledger ledger)
        {
            var helper = await _transactionRepo.GetAllAsync();
            var monthlyTrans = helper.Where(transaction => transaction.Date.Year == ledger.Year && transaction.Date.Month == ledger.Month);
            var expences = 0m;
            foreach (var t in monthlyTrans)
            {
                expences += t.TransactionLine.Sum(tl => tl.Item.Cost * tl.Quantity);
            }
            return expences;

        }
        private int CalculateWorkingDays(Ledger ledger, Employee employee)
        {
            DateTime dateTimeBegin = new DateTime(ledger.Year, ledger.Month, 1);
            DateTime dateTimeEnd = new DateTime(ledger.Year, ledger.Month, DateTime.DaysInMonth(ledger.Year, ledger.Month));
            if (!HasWorkedThisMonth(employee, dateTimeBegin, dateTimeEnd))
                return 0;
            if (HasWorkedWholeMonth(employee, dateTimeBegin, dateTimeEnd))
                return DateTime.DaysInMonth(ledger.Year, ledger.Month);
            if (employee.HireDateStart > dateTimeBegin && employee.HireDateEnd >= dateTimeEnd)
            {
                int daysInMonth = DateTime.DaysInMonth(ledger.Year, ledger.Month);
                int startDay = employee.HireDateStart.Day;
                return daysInMonth - startDay;
            }
            if (employee.HireDateStart <= dateTimeBegin && employee.HireDateEnd < dateTimeEnd)
                return employee.HireDateEnd.Day;
            return (employee.HireDateEnd - employee.HireDateStart).Days;
        }
        private bool HasWorkedThisMonth(Employee employee, DateTime begin, DateTime end)
        {
            if (begin > employee.HireDateEnd || end < employee.HireDateStart)
                return false;
            return true;
        }

        private bool HasWorkedWholeMonth(Employee employee, DateTime begin, DateTime end)
        {
            if (employee.HireDateStart <= begin && employee.HireDateEnd >= end)
                return true;
            return false;
        }
        public async Task<decimal> GetTotal(Ledger ledger)
        {
            return await GetIncome(ledger) - await GetTotalExpences(ledger);
        }
    }
}
