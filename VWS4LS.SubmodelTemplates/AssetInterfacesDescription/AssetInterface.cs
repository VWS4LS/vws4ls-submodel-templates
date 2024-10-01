using AasCore.Aas3_0;

namespace VWS4LS.SubmodelTemplates.AssetInterfacesDescription;

public class AssetInterface
{
    public static readonly ConceptDescription CD_Title = new("https://www.w3.org/2019/wot/td#title")
    {
        IdShort = "title",
        Description = [new LangStringTextType("en", "Provides a human-readable title to give a human-readable context of the interface.")],
    };

    public static readonly List<ConceptDescription> ConceptDescriptions = new(EndpointMetadata.ConceptDescriptions)
    {
        CD_Title,
    };

    public SubmodelElementCollection SubmodelElementCollection { get; }

    public AssetInterface(string idShort, AssetInterfaceType type)
    {
        Title = new Property(DataTypeDefXsd.String)
        {
            IdShort = CD_Title.IdShort,
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, CD_Title.Id)]),
        };

        EndpointMetadata = new EndpointMetadata();

        SubmodelElementCollection = new SubmodelElementCollection()
        {
            IdShort = idShort,
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, "https://admin-shell.io/idta/AssetInterfacesDescription/1/0/Interface")]),
            SupplementalSemanticIds = [
                new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, "https://www.w3.org/2019/wot/td")]),
                type switch
                {
                    AssetInterfaceType.Modbus => new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, "http://www.w3.org/2011/modbus")]),
                    AssetInterfaceType.MQTT => new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, "http://www.w3.org/2011/mqtt")]),
                    AssetInterfaceType.HTTP => new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, "http://www.w3.org/2011/http")]),
                    AssetInterfaceType.OPC_UA => new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, "http://www.w3.org/2011/opc-ua")]),
                    _ => throw new ArgumentOutOfRangeException(nameof(type)),
                },
            ],
            Description =
            [
                new LangStringTextType("en", "This SubmodelElementCollection holds the information for EndpointMetadata and InteractionMetadata."),
            ],
            Value =
            [
                Title,
                EndpointMetadata.SubmodelElementCollection,
            ],
        };
    }

    public Property Title { get; }

    public EndpointMetadata EndpointMetadata { get; }
}

public enum AssetInterfaceType
{
    Modbus,
    MQTT,
    HTTP,
    OPC_UA,
}
