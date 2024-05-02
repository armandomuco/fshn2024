using BankApi.DTO;
using BankApi.Models;

namespace BankApi.Services
{
    public class MySqlBankService : IBankService
    {
        public Models.Bank AddBank(PostBankDto bank)
        {
            throw new NotImplementedException();
        }

        public void DeleteBank(int id)
        {
            throw new NotImplementedException();
        }

        public List<Models.Bank> GetBanks()
        {
            throw new NotImplementedException();
        }

        public Models.Bank GetBankById(int id)
        {
            throw new NotImplementedException();
        }

        public Models.Bank UpdateBank(UpdateBankDto bankData, int id)
        {
            throw new NotImplementedException();
        }

        public List<Bank> GetAllBanks()
        {
            throw new NotImplementedException();
        }
    }
}
