using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

public class RemoveExamplesFilter : ISchemaFilter
{
    public void Apply(OpenApiSchema schema, SchemaFilterContext context)
    {
        // Elimina completamente la sección de ejemplo
        schema.Example = null;

        // Opcionalmente, también puedes eliminar ejemplos de propiedades individuales
        if (schema.Properties != null)
        {
            foreach (var property in schema.Properties)
            {
                property.Value.Example = null;
            }
        }
    }
}
