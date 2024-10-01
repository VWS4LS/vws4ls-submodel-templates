using AasCore.Aas3_0;

namespace VWS4LS.SubmodelTemplates.Capabilities;

public class PropertyContainer
{
    public static readonly ConceptDescription CD_Property = new("https://wiki.eclipse.org/BaSyx_/_Documentation_/_Submodels_/_Capability#Property")
    {
        IdShort = "Property",
        Description = [new LangStringTextType("en", "The specific implementation independent property, describing the capability.")],
    };

    public static readonly ConceptDescription CD_Comment = new("https://wiki.eclipse.org/BaSyx_/_Documentation_/_Submodels_/_Capability#Comment_2")
    {
        IdShort = "Comment",
        Description = [new LangStringTextType("en", "Human readable description of the property.")],
    };

    public static readonly List<ConceptDescription> ConceptDescriptions =
    [
        CD_Property,
        CD_Comment,
    ];

    public SubmodelElementCollection SubmodelElementCollection { get; }

    public PropertyContainer(int index)
    {
        Property = new Property(DataTypeDefXsd.String)
        {
            IdShort = CD_Property.IdShort,
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, CD_Property.Id)]),
        };

        Comment = new MultiLanguageProperty()
        {
            IdShort = CD_Comment.IdShort,
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, CD_Comment.Id)]),
        };

        SubmodelElementCollection = new SubmodelElementCollection()
        {
            IdShort = $"PropertyContainer{index:D2}",
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, "https://wiki.eclipse.org/BaSyx_/_Documentation_/_Submodels_/_Capability#PropertyContainer")]),
            Description =
            [
                new LangStringTextType("en", "Container for one property."),
            ],
            Value =
            [
                Property,
                Comment,
            ],
        };
    }

    public Property Property { get; }

    public MultiLanguageProperty Comment { get; }
}
