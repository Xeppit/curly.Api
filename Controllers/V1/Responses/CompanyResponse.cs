using curly.Api.Models.Database;

namespace curly.Api.Controllers.V1.Responses
{
    public class CompanyResponse
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public AddressResponse Address { get; set; }
    }
}