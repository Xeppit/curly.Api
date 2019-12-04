namespace curly.Api.Controllers.V1.Responses
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