using System.Collections.Generic;
using System.Threading.Tasks;
using ModulBank.Models.Responses;
using ModulBank.Models;
using Refit;

// ReSharper disable once CheckNamespace
namespace ModulBank
{
    internal interface IModulBankApi
    {
        [Post("/bill")]
        [Headers("Authorization: Bearer")]
        Task<CreateBillResponse> CreateBill([Body(BodySerializationMethod.UrlEncoded)] Dictionary<string, string> parameters);
        
        [Get("/bill")]
        [Headers("Authorization: Bearer")]
        Task<CreateBillResponse> GetBill(
            [AliasAs("id")] string id, 
            [AliasAs("merchant")] string merchant,
            [AliasAs("unix_timestamp")] string timestamp, 
            [AliasAs("signature")] string signature
            );
    }
}