namespace curly.Api.Controllers.V2.Responses.Address
{
    public class AddressDeleteResponse
    {
        public long DeleteRecords { get;}

        public AddressDeleteResponse(long deleteRecords)
        {
            DeleteRecords = deleteRecords;
        }
    }
}