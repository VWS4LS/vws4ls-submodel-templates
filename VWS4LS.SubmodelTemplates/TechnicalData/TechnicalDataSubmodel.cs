using AasCore.Aas3_0;

namespace VWS4LS.SubmodelTemplates.TechnicalData;

public class TechnicalDataSubmodel
{
    public static readonly ConceptDescription GeneralInformationConceptDescription = new("https://admin-shell.io/ZVEI/TechnicalData/GeneralInformation/1/1")
    {
        IdShort = "GeneralInformation",
        Description = [
            new LangStringTextType("en", "General information, for example ordering and manufacturer information."),
        ],
    };

    /*public static readonly ConceptDescription ProductClassificationsConceptDescription = new("https://admin-shell.io/ZVEI/TechnicalData/ProductClassifications/1/1")
    {
        IdShort = "ProductClassifications",
        Description = [
            new LangStringTextType("en", "Product classifications by association of product classes with common classification systems."),
        ],
    };*/

    public static readonly ConceptDescription TechnicalPropertiesConceptDescription = new("https://admin-shell.io/ZVEI/TechnicalData/TechnicalProperties/1/1")
    {
        IdShort = "TechnicalProperties",
        Description = [
            new LangStringTextType("en", "Technical and product properties. Individual characteristics that describe the product and its technical properties."),
        ],
    };

    /*public static readonly ConceptDescription FurtherInformationConceptDescription = new("https://admin-shell.io/ZVEI/TechnicalData/FurtherInformation/1/1")
    {
        IdShort = "FurtherInformation",
        Description = [
            new LangStringTextType("en", "Further information on the product, the validity of the information provided and this data record."),
        ],
    };*/

    public static readonly ConceptDescription SemanticIdNotAvailableConceptDescription = new("https://admin-shell.io/SemanticIdNotAvailable/1/1")
    {
        IdShort = "SemanticIdNotAvailable",
        Description = [
            new LangStringTextType("en", "Represents a SubmodelElement that is not described using a common classification system, a consortium specification, an open community standard, a published manufacturer specification or such."),
        ],
    };

    public static readonly List<ConceptDescription> ConceptDescriptions = new(GeneralInformation.ConceptDescriptions)
    {
        GeneralInformationConceptDescription,
        //ProductClassificationsConceptDescription,
        TechnicalPropertiesConceptDescription,
        //FurtherInformationConceptDescription,
        SemanticIdNotAvailableConceptDescription,
    };

    public Submodel Submodel { get; }

    public TechnicalDataSubmodel(string id)
    {
        GeneralInformation = new GeneralInformation();

        Submodel = new(id)
        {
            IdShort = "TechnicalData",
            Kind = ModellingKind.Instance,
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.Submodel, "https://admin-shell.io/ZVEI/TechnicalData/Submodel/1/2")]),
            Administration = new AdministrativeInformation()
            {
                Version = "1",
                Revision = "2",
            },
            Description =
            [
                new LangStringTextType("en", "Submodel containing technical data of the asset and associated product classificatons."),
            ],
            SubmodelElements = [
                GeneralInformation.SubmodelElementCollection,
                //ProductClassifications,
                TechnicalProperties,
                //FurtherInformation,
            ],
        };
    }

    public GeneralInformation GeneralInformation { get; }

    /*public SubmodelElementCollection ProductClassifications { get; } = new()
    {
        SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, ProductClassificationsConceptDescription.Id)]),
        IdShort = ProductClassificationsConceptDescription.IdShort,
        Value = [],
    };*/

    public SubmodelElementCollection TechnicalProperties { get; } = new()
    {
        SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, TechnicalPropertiesConceptDescription.Id)]),
        IdShort = TechnicalPropertiesConceptDescription.IdShort,
        Value = [],
    };

    /*public SubmodelElementCollection FurtherInformation { get; } = new()
    {
        SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, FurtherInformationConceptDescription.Id)]),
        IdShort = FurtherInformationConceptDescription.IdShort,
        Value = [],
    };*/
}
