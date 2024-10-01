using AasCore.Aas3_0;

namespace VWS4LS.SubmodelTemplates.Capabilities;

public class CapabilityContainer
{
    public static readonly ConceptDescription CD_Capability = new("https://wiki.eclipse.org/BaSyx_/_Documentation_/_Submodels_/_Capability#Capability")
    {
        IdShort = "Capability",
        Description = [new LangStringTextType("en", "Reference to an implementation-independent description, defined in a knowledge base, of the function to achieve a certain effect in the physical or virtual world.")],
    };

    public static readonly ConceptDescription CD_Comment = new("https://wiki.eclipse.org/BaSyx_/_Documentation_/_Submodels_/_Capability#Comment")
    {
        IdShort = "Comment",
        Description = [new LangStringTextType("en", "Human readable description of the capability.")],
    };

    public static readonly List<ConceptDescription> ConceptDescriptions = new(CapabilityRelationships.ConceptDescriptions.Concat(PropertySet.ConceptDescriptions))
    {
        CD_Capability,
        CD_Comment,
    };

    public SubmodelElementCollection SubmodelElementCollection { get; }

    public CapabilityContainer(string idShort)
    {
        Capability = new Capability()
        {
            IdShort = CD_Capability.IdShort,
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, CD_Capability.Id)]),
        };

        Comment = new MultiLanguageProperty()
        {
            IdShort = CD_Comment.IdShort,
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, CD_Comment.Id)]),
        };

        CapabilityRelationships = new CapabilityRelationships();

        PropertySet = new PropertySet();

        SubmodelElementCollection = new SubmodelElementCollection()
        {
            IdShort = idShort,
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, "https://wiki.eclipse.org/BaSyx_/_Documentation_/_Submodels_/_Capability#CapabilityContainer")]),
            Description =
            [
                new LangStringTextType("en", "Container for one specific capability and its relations and attributes."),
            ],
            Value =
            [
                Capability,
                Comment,
                CapabilityRelationships.SubmodelElementCollection,
                PropertySet.SubmodelElementCollection,
            ],
        };
    }

    public Capability Capability { get; }

    public MultiLanguageProperty Comment { get; }

    public CapabilityRelationships CapabilityRelationships { get; }

    public PropertySet PropertySet { get; }
}
