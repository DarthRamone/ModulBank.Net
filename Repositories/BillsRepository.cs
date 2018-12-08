using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using ModulBank.Exceptions;
using ModulBank.Models;
using ModulBank.Utils;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Refit;

namespace ModulBank.Repositories
{
    internal class BillsRepository : BaseRepository
    {
        private readonly string _secretKey;
        
        private readonly IModulBankApi _modulBankApi;
        
        public BillsRepository(HttpClient httpClient, string secretKey)
        {
            _secretKey = secretKey;
            
            _modulBankApi = RestService.For<IModulBankApi>(httpClient, new RefitSettings
            {
                JsonSerializerSettings = new JsonSerializerSettings
                {
                    ContractResolver = new DefaultContractResolver {NamingStrategy = new SnakeCaseNamingStrategy()}
                }
            });
        }
        
        public async Task<Bill> CreateBill(BillPayload payload)
        {   
            var signedDictionary = GetSignedDictionary(payload);

            var response = await _modulBankApi.CreateBill(signedDictionary);
            
            return response.Status == OK
                ? new Bill(response.Bill)
                : throw new ModulBankRequestException("Request failed");

        }

        public async Task<Bill> GetBill(BillPayload payload)
        {
            var signedDictionary = GetSignedDictionary(payload);
          
            var response = await _modulBankApi
                .GetBill(payload.Id, payload.Merchant, signedDictionary["unix_timestamp"], signedDictionary["signature"]);
            
            return response.Status == OK
                ? new Bill(response.Bill)
                : throw new ModulBankRequestException("Request failed");
        }

        private Dictionary<string, string> GetSignedDictionary(BillPayload payload)
        {
            var dict = payload.GetDictionary();
            
            var signature = SignatureHelper.GetSignature(_secretKey, dict);
            dict["signature"] = signature;

            return dict;
        }
    }
}