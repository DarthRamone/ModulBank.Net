using ModulBank.Models.Dto;

namespace ModulBank.Models.Responses
{
    internal class CreateBillResponse : Response
    {
        public BillDto Bill { get; set; }
    }
}