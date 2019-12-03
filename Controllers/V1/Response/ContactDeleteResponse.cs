namespace curly.Api.Controllers.V1.Request
{
    public class ContactDeleteResponse
    {
        public long DeleteRecords { get;}

        public ContactDeleteResponse(long deleteRecords)
        {
            DeleteRecords = deleteRecords;
        }
    }
}