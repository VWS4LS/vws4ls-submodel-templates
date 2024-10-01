using AasCore.Aas3_0;

namespace VWS4LS.SubmodelTemplates.AssetInterfacesDescription;

public class AssetInterfacesDescriptionSubmodel
{
    public static readonly List<ConceptDescription> ConceptDescriptions = new(AssetInterface.ConceptDescriptions)
    {

    };

    public Submodel Submodel { get; }

    public AssetInterfacesDescriptionSubmodel(string id, string idShort = "AssetInterfacesDescription")
    {
        Submodel = new Submodel(id)
        {
            IdShort = idShort,
            Kind = ModellingKind.Instance,
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.Submodel, "https://admin-shell.io/idta/AssetInterfacesDescription/1/0/Submodel")]),
            Administration = new AdministrativeInformation()
            {
                Version = "1",
                Revision = "0",
            },
            Description =
            [
                new LangStringTextType("en", "Definition of the Submodel Asset Interfaces Description identified by its semanticId."),
            ],
            SubmodelElements =
            [

            ],
        };
    }

    public void AddInterface(AssetInterface assetInterface)
    {
        Submodel.SubmodelElements.Add(assetInterface.SubmodelElementCollection);
    }
}
