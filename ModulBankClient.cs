using System;
using System.Net.Http;
using System.Threading.Tasks;
using ModulBank.Models;
using ModulBank.Repositories;

namespace ModulBank
{
    public class ModulBankClient : IModulBankClient
    {
        private const string BASE_URL = "https://pay.modulbank.ru/api/v1";
        
        private readonly BillsRepository _billsRepository;
        
        
        public ModulBankClient(string secretKey)
        {   
            var baseUri = new Uri(BASE_URL);
            var httpClient = new HttpClient(new HttpClientHandler()) {BaseAddress = baseUri};
            
            _billsRepository = new BillsRepository(httpClient, secretKey);
        }

        
        public async Task<Bill> CreateBill(BillPayload payload) => await _billsRepository.CreateBill(payload);

        public async Task<Bill> GetBill(BillPayload payload) => await _billsRepository.GetBill(payload);
    }
}