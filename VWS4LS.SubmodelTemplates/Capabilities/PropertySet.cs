using AasCore.Aas3_0;

namespace VWS4LS.SubmodelTemplates.Capabilities;

public class PropertySet
{
    public static readonly List<ConceptDescription> ConceptDescriptions = new(PropertyContainer.ConceptDescriptions)
    {

    };

    public SubmodelElementCollection SubmodelElementCollection { get; }

    public PropertySet()
    {
        SubmodelElementCollection = new SubmodelElementCollection()
        {
            IdShort = "PropertySet",
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, "hhttps://wiki.eclipse.org/BaSyx_/_Documentation_/_Submodels_/_Capability#PropertySet")]),
            Description =
            [
                new LangStringTextType("en", "Set of properties to describe the implementation-independent capability further."),
            ],
            Value =
            [

            ],
        };
    }

    public void AddPropertyContainer(PropertyContainer propertyContainer)
    {
        SubmodelElementCollection.Value!.Add(propertyContainer.SubmodelElementCollection);
    }
}
