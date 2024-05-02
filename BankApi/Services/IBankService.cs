using BankApi.DTO;

namespace BankApi.Services
{
    public interface IBankService
    {
        List<Models.Bank> GetAllBanks();
        Models.Bank GetBankById(int id);
        Models.Bank AddBank(PostBankDto bank);
        Models.Bank UpdateBank(UpdateBankDto bankData, int id);
        void DeleteBank(int id);
    }
}
