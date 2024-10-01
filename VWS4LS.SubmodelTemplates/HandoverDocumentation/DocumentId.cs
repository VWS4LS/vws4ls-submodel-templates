using AasCore.Aas3_0;

namespace VWS4LS.SubmodelTemplates.HandoverDocumentation;

public class DocumentId
{
    public static ConceptDescription CD_DocumentDomainId = new("0173-1#02-ABH994#001")
    {
        IdShort = "DocumentDomainId",
        Description =
        [
            new LangStringTextType("en", "Identification of the domain in which the given DocumentId is unique. The domain ID can be e.g. the name or acronym of the providing organization."),
        ],
    };

    public static ConceptDescription CD_ValueId = new("0173-1#02-AAO099#002")
    {
        IdShort = "ValueId",
        Description =
        [
            new LangStringTextType("en", "Identification number of the Document within a given domain, e.g. the providing organization."),
        ],
    };

    public static ConceptDescription CD_IsPrimary = new(" 0173-1#02-ABH995#001")
    {
        IdShort = "IsPrimary",
        Description =
        [
            new LangStringTextType("en", "Flag indicating that a DocumentId within a collection of at least two DocumentIds is the ‘primary’ identifier for the document. This is the preferred ID of the document (commonly from the point of view of the owner of the asset)."),
        ],
    };

    public static readonly List<ConceptDescription> ConceptDescriptions =
    [
        CD_DocumentDomainId,
        CD_ValueId,
        CD_IsPrimary,
    ];

    public SubmodelElementCollection SubmodelElementCollection { get; }

    public DocumentId(int index)
    {
        DocumentDomainId = new Property(DataTypeDefXsd.String)
        {
            IdShort = CD_DocumentDomainId.IdShort,
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, CD_DocumentDomainId.Id)]),
        };

        ValueId = new Property(DataTypeDefXsd.String)
        {
            IdShort = CD_ValueId.IdShort,
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, CD_ValueId.Id)]),
        };

        IsPrimary = new Property(DataTypeDefXsd.Boolean)
        {
            IdShort = CD_IsPrimary.IdShort,
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, CD_IsPrimary.Id)]),
        };

        SubmodelElementCollection = new SubmodelElementCollection()
        {
            IdShort = $"{Document.CD_DocumentId.IdShort}{index:D2}",
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, Document.CD_DocumentId.Id)]),
            Value = [DocumentDomainId, ValueId, IsPrimary],
        };
    }

    public Property DocumentDomainId { get; }

    public Property ValueId { get; }

    public Property IsPrimary { get; set; }
}
