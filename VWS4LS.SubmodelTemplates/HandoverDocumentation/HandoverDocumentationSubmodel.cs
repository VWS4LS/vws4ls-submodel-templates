using AasCore.Aas3_0;

namespace VWS4LS.SubmodelTemplates.HandoverDocumentation;

public class HandoverDocumentationSubmodel
{
    public static readonly ConceptDescription CD_Document = new("0173-1#02-ABI500#001/0173-1#01-AHF579#001")
    {
        IdShort = "Document",
        Description =
        [
            new LangStringTextType("en", "Each SMC describes a Document (see IEC 82045-1 and IEC 8245-2), which is associated with the particular Asset Administration Shell."),
        ],
    };

    public static readonly List<ConceptDescription> ConceptDescriptions = new(Document.ConceptDescriptions)
    {
        CD_Document,
    };

    public Submodel Submodel { get; }

    public HandoverDocumentationSubmodel(string id)
    {
        Submodel = new Submodel(id)
        {
            IdShort = "HandoverDocumentation",
            Kind = ModellingKind.Instance,
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.Submodel, "0173-1#01-AHF578#001")]),
            Administration = new AdministrativeInformation()
            {
                Version = "1",
                Revision = "2",
            },
            Description =
            [
                new LangStringTextType("en", "The Submodel defines a set meta data for the handover of documentation from the manufacturer to the operator for industrial equipment."),
            ],
        };
    }

    public void AddDocument(Document document)
    {
        if (Submodel.SubmodelElements == null)
        {
            Submodel.SubmodelElements = [];
        }

        Submodel.SubmodelElements.Add(document.SubmodelElementCollection);
    }
}
