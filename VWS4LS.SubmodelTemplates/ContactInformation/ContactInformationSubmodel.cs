using AasCore.Aas3_0;

namespace VWS4LS.SubmodelTemplates.ContactInformation;

// https://industrialdigitaltwin.org/wp-content/uploads/2022/10/IDTA-02002-1-0_Submodel_ContactInformation.pdf
public class ContactInformationSubmodel
{
    public Submodel Submodel { get; }

    public ContactInformationSubmodel(string id)
    {
        Submodel = new Submodel(id)
        {
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.Submodel, "https://admin-shell.io/zvei/nameplate/1/0/ContactInformations")]),
            Kind = ModellingKind.Instance,
            IdShort = "ContactInformations",
            Administration = new AdministrativeInformation()
            {
                Version = "1",
                Revision = "0",
            },
            Description = new List<ILangStringTextType>()
            {
                new LangStringTextType("en", "The Submodel “ContactInformations” is the collection for various contact information."),
            },
        };
    }

    public static readonly List<IConceptDescription> ConceptDescriptions = new(ContactInfo.ConceptDescriptions);

    public void AddContactInformation(ContactInfo contactInformation)
    {
        if (Submodel.SubmodelElements == null)
        {
            Submodel.SubmodelElements = [];
        }

        Submodel.SubmodelElements.Add(contactInformation.SubmodelElementCollection);
    }
}
