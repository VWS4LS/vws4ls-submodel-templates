using AasCore.Aas3_0;

namespace VWS4LS.SubmodelTemplates.HandoverDocumentation;

public class DocumentClassification
{
    public static readonly ConceptDescription CD_ClassId = new("0173-1#02-ABH996#001")
    {
        IdShort = "ClassId",
        Description =
        [
            new LangStringTextType("en", "Unique ID of the document class within a ClassificationSystem."),
        ],
    };

    public static readonly ConceptDescription CD_ClassName = new("0173-1#02-AAO102#003")
    {
        IdShort = "ClassName",
        Description =
        [
            new LangStringTextType("en", "List of language-dependent names of the selected ClassID."),
        ],
    };

    public static readonly ConceptDescription CD_ClassificationSystem = new("0173-1#02-ABH997#001")
    {
        IdShort = "ClassificationSystem",
        Description =
        [
            new LangStringTextType("en", "Identification of the classification system."),
        ],
    };

    public static readonly List<ConceptDescription> ConceptDescriptions =
    [
        CD_ClassId,
        CD_ClassName,
        CD_ClassificationSystem,
    ];

    public SubmodelElementCollection SubmodelElementCollection { get; }

    public DocumentClassification(int index)
    {
        ClassId = new Property(DataTypeDefXsd.String)
        {
            IdShort = CD_ClassId.IdShort,
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, CD_ClassId.Id)]),
        };

        ClassName = new MultiLanguageProperty()
        {
            IdShort = CD_ClassName.IdShort,
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, CD_ClassName.Id)]),
        };

        ClassificationSystem = new Property(DataTypeDefXsd.String)
        {
            IdShort = CD_ClassificationSystem.IdShort,
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, CD_ClassificationSystem.Id)]),
        };

        SubmodelElementCollection = new SubmodelElementCollection()
        {
            IdShort = $"{Document.CD_DocumentClassification.IdShort}{index:D2}",
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, Document.CD_DocumentClassification.Id)]),
            Value =
            [
                ClassId,
                ClassName,
                ClassificationSystem,
            ],
        };
    }

    public Property ClassId { get; }

    public MultiLanguageProperty ClassName { get; }

    public Property ClassificationSystem { get; }
}