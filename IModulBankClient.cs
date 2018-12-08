using System.Threading.Tasks;
using ModulBank.Models;

namespace ModulBank
{
    public interface IModulBankClient
    {
        Task<Bill> CreateBill(BillPayload payload);

        Task<Bill> GetBill(BillPayload payload);
    }
}