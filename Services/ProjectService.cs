using System.Threading.Tasks;
using MongoDB.Driver;
using System.Linq;
using curly.Api.Models.Database;

namespace curly.Api.Services
{
    public class ProjectService : DataAccessBase<Project>
    {
        protected override IMongoCollection<Project> _mongoCollection { get; }
        private readonly FileSystemService _fileSystemService;

        public ProjectService(CollectionFactory collectionFactory, FileSystemService fileSystemService)
        {
            _mongoCollection = collectionFactory.GetCollection<Project>("Projects");
            _fileSystemService = fileSystemService;
        }

        public override async Task<Project> InsertOrUpdateAsync(Project entity)
        {
            var latestJob = await _mongoCollection.Find(FilterDefinition<Project>.Empty)
                .Limit(1)
                .Sort(Builders<Project>.Sort.Descending(x => x.Number)).ToListAsync();

            if (latestJob.Count > 0)
            {
                entity.Number = latestJob[0].Number + 1;
            }
            
            if(string.IsNullOrEmpty(entity.ProjectDirectoryName))
            {
                entity.ProjectDirectoryName = $"{entity.Number} {entity.Site.Name} {entity.Description}";
            }

            _fileSystemService.CopyProjectTemplate(entity.ProjectDirectoryName);

            return await base.InsertOrUpdateAsync(entity);
        }
    }
}