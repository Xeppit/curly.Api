using curly.Api.Models.Interfaces;

namespace curly.Api.Models.Settings
{
    public class FileSystemLocationSettings : IFileSystemLocationSettings
    {
        public string TemplateProjectDirectory { get; set; }
        public string ProjectDirectory { get; set; }
    }
}