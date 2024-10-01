using AasCore.Aas3_0;

namespace VWS4LS.SubmodelTemplates.HandoverDocumentation;

public class Document
{
    public static readonly ConceptDescription CD_DocumentId = new("0173-1#02-ABI501#001/0173-1#01-AHF580#001")
    {
        IdShort = "DocumentId",
        Description =
        [
            new LangStringTextType("en", "This SubmodelElementCollection holds the information for a VDI 2770 DocumentIdDomain entity and the DocumentId property."),
        ],
    };

    public static readonly ConceptDescription CD_DocumentClassification = new("0173-1#02-ABI502#001/0173-1#01-AHF581#001")
    {
        IdShort = "DocumentClassification",
        Description =
        [
            new LangStringTextType("en", "This SubmodelElementCollection holds the information for a VDI 2770 DocumentClassification entity."),
        ],
    };

    public static readonly ConceptDescription CD_DocumentVersion = new("0173-1#02-ABI503#001/0173-1#01-AHF582#001")
    {
        IdShort = "DocumentVersion",
        Description =
        [
            new LangStringTextType("en", "This SubmodelElementCollection holds the information for a VDI2770 DocumentVersion entity."),
        ],
    };

    public static readonly ConceptDescription CD_DocumentEntity = new("0173-1#02-ABI501#001/0173-1#01-AHF580#001*00")
    {
        IdShort = "DocumentEntity",
        Description =
        [
            new LangStringTextType("en", "Identifies entities, which are subject to the Document."),
        ],
    };

    public SubmodelElementCollection SubmodelElementCollection { get; }

    public static readonly List<ConceptDescription> ConceptDescriptions = new(DocumentVersion.ConceptDescriptions.Concat(DocumentId.ConceptDescriptions)
                                                                                                                 .Concat(DocumentClassification.ConceptDescriptions))
    {
        CD_DocumentId,
        CD_DocumentClassification,
        CD_DocumentVersion,
        CD_DocumentEntity,
    };

    public Document(int index)
    {
        SubmodelElementCollection = new SubmodelElementCollection()
        {
            IdShort = $"{HandoverDocumentationSubmodel.CD_Document.IdShort}{index:D2}",
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, HandoverDocumentationSubmodel.CD_Document.Id)]),
            Description =
            [
                new LangStringTextType("en", "Each SMC describes a Document (see IEC 82045-1 and IEC 8245-2), which is associated with the particular Asset Administration Shell."),
            ],
        };
    }

    public void AddDocumentId(DocumentId documentId)
    {
        if (SubmodelElementCollection.Value is null)
        {
            SubmodelElementCollection.Value = [];
        }

        SubmodelElementCollection.Value.Add(documentId.SubmodelElementCollection);
    }

    public void AddDocumentClassification(DocumentClassification documentClassification)
    {
        if (SubmodelElementCollection.Value is null)
        {
            SubmodelElementCollection.Value = [];
        }

        SubmodelElementCollection.Value.Add(documentClassification.SubmodelElementCollection);
    }

    public void AddDocumentVersion(DocumentVersion documentVersion)
    {
        if (SubmodelElementCollection.Value is null)
        {
            SubmodelElementCollection.Value = [];
        }

        SubmodelElementCollection.Value.Add(documentVersion.SubmodelElementCollection);
    }
}
