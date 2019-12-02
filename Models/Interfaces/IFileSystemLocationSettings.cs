namespace curly.Api.Models.Interfaces
{
    public interface IFileSystemLocationSettings
    {
        string TemplateProjectDirectory { get; set; }
        string ProjectDirectory { get; set; }
    }
}