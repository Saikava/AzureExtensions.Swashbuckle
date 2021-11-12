using System.Collections.Generic;
using Microsoft.OpenApi.Interfaces;

namespace AzureFunctions.Extensions.Swashbuckle.Settings
{
    public class SwaggerDocument : IOpenApiExtensible
    {
        public string Name { get; set; } = "v1";

        public string Title { get; set; } = "Swashbuckle";

        public string Version { get; set; } = "v1";

        public string Description { get; set; } = "Swagger document by Swashbuckle";

        public IDictionary<string, IOpenApiExtension> Extensions { get; set; } = new Dictionary<string, IOpenApiExtension>();
    }
}
