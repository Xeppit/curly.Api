namespace curly.Api.Controllers.V1.Responses
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