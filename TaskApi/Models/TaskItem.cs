using System.Security.Cryptography.X509Certificates;

namespace TaskApi.Models;

public class CreateTaskDto
{
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Priority { get; set; } = "Normal";
}