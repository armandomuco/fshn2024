using BankApi.DTO;


namespace BankApi.Services
{
    public class BankService : IBankService
    {
        private AppDbContext _context;
        public BankService(AppDbContext context)
        {
            _context = context;
        }


        public List<Models.Bank> GetAllBanks()
        {
            var allBanks = _context.Banks.ToList();
            return allBanks;
        }

        public Models.Bank AddBank(PostBankDto bank)
        {
            var newBank = new Models.Bank()
            {
                Name = bank.Name,
                City = bank.City,
                Road = bank.Road,
                ATM = bank. ATM,
                Director = bank.Director,
                NumberOfEmployers = bank.NumberOfEmployers
            };

            _context.Banks.Add(newBank);
            _context.SaveChanges();

            return newBank;
        }

        public void DeleteBank(int id)
        {
            var BankDb = _context.Banks
                .FirstOrDefault(n => n.Id == id);

            _ = _context.Banks.Remove(BankDb);
            _context.SaveChanges();
        }



        public Models.Bank GetBankById(int id)
        {
            var newBank = _context.Banks
                .FirstOrDefault(n => n.Id == id);

            return newBank;
        }


        public Models.Bank UpdateBank(UpdateBankDto bankData, int id)
        {
            var bankDb = _context.Banks
                .FirstOrDefault(n => n.Id == id);

            bankDb.City = bankData.City;
            bankDb.Road = bankData.Road;
            bankDb.ATM = bankData.ATM;
            bankDb.Director = bankData.Director;
            bankDb.NumberOfEmployers = bankData.NumberOfEmployers;

            _context.Banks.Update(bankDb);

            _context.SaveChanges();

            return bankDb;
        }
    }
}
