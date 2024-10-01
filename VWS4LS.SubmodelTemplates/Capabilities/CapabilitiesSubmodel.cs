using AasCore.Aas3_0;

namespace VWS4LS.SubmodelTemplates.Capabilities;

public class CapabilitiesSubmodel
{
    public static readonly List<ConceptDescription> ConceptDescriptions = new(CapabilitySet.ConceptDescriptions)
    {

    };

    public Submodel Submodel { get; }

    public CapabilitiesSubmodel(string id, string idShort = "Capabilities")
    {
        CapabilitySet = new CapabilitySet("CapabilitySet");

        Submodel = new Submodel(id)
        {
            IdShort = idShort,
            Kind = ModellingKind.Instance,
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, "https://wiki.eclipse.org/BaSyx_/_Documentation_/_Submodels_/_Capability")]),
            Administration = new AdministrativeInformation()
            {
                Version = "1",
                Revision = "0",
            },
            Description =
            [
                new LangStringTextType("en", "Submodel describing the available capabilites, defined in knowledge base, of an asset."),
            ],
            SubmodelElements =
            [
                CapabilitySet.SubmodelElementCollection,
            ],
        };
    }

    public CapabilitySet CapabilitySet { get; }
}
