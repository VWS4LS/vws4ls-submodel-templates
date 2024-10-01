using AasCore.Aas3_0;

namespace VWS4LS.SubmodelTemplates.HandoverDocumentation;

public class DocumentVersion
{
    public static readonly ConceptDescription CD_Language = new("0173-1#02-AAN468#006")
    {
        IdShort = "Language",
        Description =
        [
            new LangStringTextType("en", "This property contains a list of languages used within the DocumentVersion."),
        ],
    };

    public static readonly ConceptDescription CD_DocumentVersionId = new("0173-1#02-AAO100#002")
    {
        IdShort = "DocumentVersionId",
        Description =
        [
            new LangStringTextType("en", "Unambiguous identification number of a DocumentVersion."),
        ],
    };

    public static readonly ConceptDescription CD_Title = new("0173-1#02-AAO105#002")
    {
        IdShort = "Title",
        Description =
        [
            new LangStringTextType("en", "List of language-dependent titles of the Document."),
        ],
    };

    public static readonly ConceptDescription CD_SubTitle = new("0173-1#02-ABH998#001")
    {
        IdShort = "SubTitle",
        Description =
        [
            new LangStringTextType("en", "List of language-dependent subtitles of the Document."),
        ],
    };

    public static readonly ConceptDescription CD_Summary = new("0173-1#02-AAO106#002")
    {
        IdShort = "Summary",
        Description =
        [
            new LangStringTextType("en", "List of language-dependent summaries of the Document."),
        ],
    };

    public static readonly ConceptDescription CD_KeyWords = new("0173-1#02-ABH999#001")
    {
        IdShort = "KeyWords",
        Description =
        [
            new LangStringTextType("en", "List of language-dependent keywords of the Document."),
        ],
    };

    public static readonly ConceptDescription CD_StatusSetDate = new("0173-1#02-ABI000#001")
    {
        IdShort = "StatusSetDate",
        Description =
        [
            new LangStringTextType("en", "Date when the document status was set. Format is YYYY-MM-dd."),
        ],
    };

    public static readonly ConceptDescription CD_StatusValue = new("0173-1#02-ABI001#001")
    {
        IdShort = "StatusValue",
        Description =
        [
            new LangStringTextType("en", "Each document version represents a point in time in the document lifecycle.This status value refers to the milestones in the document lifecycle.The following two values should be used for the application of this guideline: InReview (under review), Released (released)."),
        ],
    };

    public static readonly ConceptDescription CD_OrganizationName = new("0173-1#02-ABI002#001")
    {
        IdShort = "OrganizationName",
        Description =
        [
            new LangStringTextType("en", "Organization short name of the author of the Document."),
        ],
    };

    public static readonly ConceptDescription CD_OrganizationOfficialName = new("0173-1#02-ABI004#001")
    {
        IdShort = "OrganizationOfficialName",
        Description =
        [
            new LangStringTextType("en", "Official name of the organization of author of the Document."),
        ],
    };

    public static readonly ConceptDescription CD_DigitalFile = new("0173-1#02-ABI504#001/0173-1#01-AHF583#001")
    {
        IdShort = "DigitalFile",
        Description =
        [
            new LangStringTextType("en", "DigitalFile is a class that represents a digital file."),
        ],
    };

    public static readonly ConceptDescription CD_PreviewFile = new("0173-1#02-ABI505#001/0173-1#01-AHF584#001")
    {
        IdShort = "PreviewFile",
        Description =
        [
            new LangStringTextType("en", "Provides a preview image of the DocumentVersion, e.g. first page, in a commonly used image format and in low resolution."),
        ],
    };

    public static readonly List<ConceptDescription> ConceptDescriptions =
    [
        CD_Language,
        CD_DocumentVersionId,
        CD_Title,
        CD_SubTitle,
        CD_Summary,
        CD_KeyWords,
        CD_StatusSetDate,
        CD_StatusValue,
        CD_OrganizationName,
        CD_OrganizationOfficialName,
        CD_DigitalFile,
        CD_PreviewFile,
    ];

    public SubmodelElementCollection SubmodelElementCollection { get; }

    public DocumentVersion(int index)
    {
        Language = new Property(DataTypeDefXsd.String)
        {
            IdShort = CD_Language.IdShort,
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, CD_Language.Id)]),
        };

        DocumentVersionId = new Property(DataTypeDefXsd.String)
        {
            IdShort = CD_DocumentVersionId.IdShort,
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, CD_DocumentVersionId.Id)]),
        };

        Title = new MultiLanguageProperty()
        {
            IdShort = CD_Title.IdShort,
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, CD_Title.Id)]),
        };

        SubTitle = new MultiLanguageProperty()
        {
            IdShort = CD_SubTitle.IdShort,
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, CD_SubTitle.Id)]),
        };

        Summary = new MultiLanguageProperty()
        {
            IdShort = CD_Summary.IdShort,
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, CD_Summary.Id)]),
        };

        KeyWords = new MultiLanguageProperty()
        {
            IdShort = CD_KeyWords.IdShort,
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, CD_KeyWords.Id)]),
        };

        StatusSetDate = new Property(DataTypeDefXsd.Date)
        {
            IdShort = CD_StatusSetDate.IdShort,
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, CD_StatusSetDate.Id)]),
        };

        StatusValue = new Property(DataTypeDefXsd.String)
        {
            IdShort = CD_StatusValue.IdShort,
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, CD_StatusValue.Id)]),
        };

        OrganizationName = new Property(DataTypeDefXsd.String)
        {
            IdShort = CD_OrganizationName.IdShort,
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, CD_OrganizationName.Id)]),
        };

        OrganizationOfficialName = new Property(DataTypeDefXsd.String)
        {
            IdShort = CD_OrganizationOfficialName.IdShort,
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, CD_OrganizationOfficialName.Id)]),
        };

        SubmodelElementCollection = new SubmodelElementCollection()
        {
            IdShort = $"DocumentVersion{index:D2}",
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, "0173-1#02-ABI503#001/0173-1#01-AHF582#001")]),
            Description =
            [
                new LangStringTextType("en", "Information elements of individual VDI 2770 DocumentVersion entities."),
            ],
            Value = [
                Language,
                DocumentVersionId,
                Title,
                SubTitle,
                Summary,
                KeyWords,
                StatusSetDate,
                StatusValue,
                OrganizationName,
                OrganizationOfficialName,
            ],
        };
    }

    public Property Language { get; }

    public Property DocumentVersionId { get; }

    public MultiLanguageProperty Title { get; }

    public MultiLanguageProperty SubTitle { get; }

    public MultiLanguageProperty Summary { get; }

    public MultiLanguageProperty KeyWords { get; }

    public Property StatusSetDate { get; }

    public Property StatusValue { get; }

    public Property OrganizationName { get; }

    public Property OrganizationOfficialName { get; }

    public void AddDigitalFile(string contentType, string filePath)
    {
        if (SubmodelElementCollection.Value == null)
        {
            SubmodelElementCollection.Value = [];
        }

        int count = SubmodelElementCollection.Value.Where(x => x.IdShort.StartsWith(CD_DigitalFile.IdShort)).Count() + 1;

        var file = new AasCore.Aas3_0.File(contentType)
        {
            IdShort = $"{CD_DigitalFile.IdShort}{count:D2}",
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, CD_DigitalFile.Id)]),
            Value = filePath,
        };

        SubmodelElementCollection.Value.Add(file);
    }

    public void AddPreviewFile(string contentType, string filePath)
    {
        if (SubmodelElementCollection.Value == null)
        {
            SubmodelElementCollection.Value = [];
        }

        int count = SubmodelElementCollection.Value.Where(x => x.IdShort.StartsWith(CD_PreviewFile.IdShort)).Count() + 1;

        var file = new AasCore.Aas3_0.File(contentType)
        {
            IdShort = $"{CD_PreviewFile.IdShort}{count:D2}",
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, CD_PreviewFile.Id)]),
            Value = filePath,
        };

        SubmodelElementCollection.Value.Add(file);
    }
}
