namespace curly.Api.Controllers.V1.Request
{
    public class ProjectDeleteResponse
    {
        public long DeleteRecords { get;}

        public ProjectDeleteResponse(long deleteRecords)
        {
            DeleteRecords = deleteRecords;
        }
    }
}