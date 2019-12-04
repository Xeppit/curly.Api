namespace curly.Api.Controllers.V1.Responses
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