using curly.Api.Models.Database;

namespace curly.Api.Controllers.V1.Request
{
    public class CompanyCreateResponse
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }
    }
}