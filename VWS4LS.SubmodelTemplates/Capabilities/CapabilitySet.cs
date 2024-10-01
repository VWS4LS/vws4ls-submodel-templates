using AasCore.Aas3_0;

namespace VWS4LS.SubmodelTemplates.Capabilities;

public class CapabilitySet
{
    public static readonly List<ConceptDescription> ConceptDescriptions = new(CapabilityContainer.ConceptDescriptions)
    {

    };

    public SubmodelElementCollection SubmodelElementCollection { get; }

    public CapabilitySet(string idShort)
    {
        SubmodelElementCollection = new SubmodelElementCollection()
        {
            IdShort = idShort,
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, "https://wiki.eclipse.org/BaSyx_/_Documentation_/_Submodels_/_Capability#CapabilitySet")]),
            Description =
            [
                new LangStringTextType("en", "Basic collection of all available capabilities."),
            ],
            Value =
            [

            ],
        };
    }

    public void AddCapabilityContainer(CapabilityContainer capabilityContainer)
    {
        SubmodelElementCollection.Value.Add(capabilityContainer.SubmodelElementCollection);
    }
}
