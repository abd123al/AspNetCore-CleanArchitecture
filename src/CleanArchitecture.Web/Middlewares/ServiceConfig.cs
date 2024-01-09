namespace CleanArchitecture.Web.Middlewares;

public class ServiceConfig
{
    public string Path { get; set; } = "/listallservices";

    public List<ServiceDescriptor> Services { get; set; } = new List<ServiceDescriptor>();
}
