using Swashbuckle.AspNetCore.Swagger;

namespace MigCrud
{
    internal class OpenApiInfo : Info
    {
        public string Title { get; set; }
        public string Version { get; set; }
    }
}