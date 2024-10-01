using AasCore.Aas3_0;

namespace VWS4LS.SubmodelTemplates.AssetInterfacesDescription;

public class NoSecurityScheme : SecurityScheme
{
    public static readonly List<ConceptDescription> ConceptDescriptions = SecurityScheme.ConceptDescriptions;

    public override SubmodelElementCollection SubmodelElementCollection { get; }

    public NoSecurityScheme() : base(SecuritySchemeType.NoSecurity)
    {
        SubmodelElementCollection = new SubmodelElementCollection()
        {
            IdShort = "nosec_sc",
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, "https://www.w3.org/2019/wot/security#NoSecurityScheme")]),
            Description =
            [
                new LangStringTextType("en", "This SubmodelElementCollection holds the information about the no security mechanism used to access the asset."),
            ],
            Value =
            [
                Scheme,
                Proxy,
            ],
        };
    }
}
