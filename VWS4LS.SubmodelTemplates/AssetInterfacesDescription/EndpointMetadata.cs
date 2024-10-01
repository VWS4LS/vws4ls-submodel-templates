using AasCore.Aas3_0;

namespace VWS4LS.SubmodelTemplates.AssetInterfacesDescription;

public class EndpointMetadata
{
    public static readonly ConceptDescription CD_Base = new("https://www.w3.org/2019/wot/td#baseURI")
    {
        IdShort = "base",
        Description = [new LangStringTextType("en", "Defines asset connection entry point. Each protocol specifies a base pattern.")],
    };

    public static readonly ConceptDescription CD_ContentType = new("https://www.w3.org/2019/wot/hypermedia#forContentType")
    {
        IdShort = "contentType",
        Description = [new LangStringTextType("en", "Defines content type based on a media type (e.g., text/plain) and potential character decoding/encoding type (e.g., charset=utf-8) for the media type (see RFC2046) of the whole interface.")],
    };

    public static readonly ConceptDescription CD_Security = new("https://www.w3.org/2019/wot/td#hasSecurityConfiguration")
    {
        IdShort = "security",
        Description = [new LangStringTextType("en", "Selects one or more of the security scheme(s) that can be applied at runtime from the collection of security schemes defines in securityDefinitions.")],
    };

    public static readonly List<ConceptDescription> ConceptDescriptions = new(SecurityDefinitions.ConceptDescriptions)
    {
        CD_Base,
        CD_ContentType,
        CD_Security,
    };

    public SubmodelElementCollection SubmodelElementCollection { get; }

    public EndpointMetadata()
    {
        Base = new Property(DataTypeDefXsd.String)
        {
            IdShort = CD_Base.IdShort,
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, CD_Base.Id)]),
        };

        ContentType = new Property(DataTypeDefXsd.String)
        {
            IdShort = CD_ContentType.IdShort,
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, CD_ContentType.Id)]),
        };

        SecurityDefinitions = new SecurityDefinitions();

        Security = new SubmodelElementList(AasSubmodelElements.ReferenceElement)
        {
            IdShort = CD_Security.IdShort,
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, CD_Security.Id)]),
            Value = [],
        };

        SubmodelElementCollection = new SubmodelElementCollection()
        {
            IdShort = "EndpointMetadata",
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, "https://admin-shell.io/idta/AssetInterfacesDescription/1/0/EndpointMetadata")]),
            Description =
            [
                new LangStringTextType("en", "This SubmodelElementCollection holds information about asset’s entry point, security and data format serialization."),
            ],
            Value =
            [
                Base,
                ContentType,
                SecurityDefinitions.SubmodelElementCollection,
                Security,
            ],
        };
    }

    public Property Base { get; }

    public Property ContentType { get; }

    public SecurityDefinitions SecurityDefinitions { get; }

    public SubmodelElementList Security { get; }
}
