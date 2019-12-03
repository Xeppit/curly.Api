namespace curly.Api.Controllers.V1.Request
{
    public class CompanyDeleteResponse
    {
        public long DeleteRecords { get;}

        public CompanyDeleteResponse(long deleteRecords)
        {
            DeleteRecords = deleteRecords;
        }
    }
}