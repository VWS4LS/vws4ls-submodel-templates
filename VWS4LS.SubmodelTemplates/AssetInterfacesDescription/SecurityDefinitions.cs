using AasCore.Aas3_0;

namespace VWS4LS.SubmodelTemplates.AssetInterfacesDescription;

public class SecurityDefinitions
{
    public static readonly List<ConceptDescription> ConceptDescriptions = new(SecurityScheme.ConceptDescriptions.Concat(NoSecurityScheme.ConceptDescriptions))
    {

    };

    public SubmodelElementCollection SubmodelElementCollection { get; }

    public SecurityDefinitions()
    {
        SubmodelElementCollection = new SubmodelElementCollection()
        {
            IdShort = "securityDefinitions",
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, "https://www.w3.org/2019/wot/td#definesSecurityScheme")]),
            Description =
            [
                new LangStringTextType("en", "This SubmodelElementCollection holds the information about security mechanism used to access the asset."),
            ],
            Value =
            [

            ],
        };
    }

    public void AddSecurityScheme(SecurityScheme securityScheme)
    {
        SubmodelElementCollection.Value.Add(securityScheme.SubmodelElementCollection);
    }
}
