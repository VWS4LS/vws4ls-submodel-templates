using AasCore.Aas3_0;
using System.Net.Mime;

namespace VWS4LS.SubmodelTemplates.TechnicalData;

public class GeneralInformation
{
    public static readonly ConceptDescription ManufacturerNameConceptDescription = new("0173-1#02-AAO677#002")
    {
        IdShort = "ManufacturerName",
        Description = [
            new LangStringTextType("en", "Legally valid designation of the natural or judicial body which is directly responsible for the design, production, packaging and labeling of a product in respect to its being brought into the market."),
        ],
    };

    public static readonly ConceptDescription CD_ManufacturerLogo = new("https://admin-shell.io/ZVEI/TechnicalData/ManufacturerLogo/1/1")
    {
        IdShort = "ManufacturerLogo",
        Description = [
            new LangStringTextType("en", "Imagefile for logo of manufacturer provided in common format (.png, .jpg)."),
        ],
    };

    public static readonly ConceptDescription ManufacturerProductDesignationConceptDescription = new(" 0173-1#02-AAW338#001")
    {
        IdShort = "ManufacturerProductDesignation",
        Description = [
            new LangStringTextType("en", "Product designation as given by the manufacturer. Short description of the product, product group or function (short text) in common language."),
        ],
    };

    public static readonly ConceptDescription ManufacturerArticleNumberConceptDescription = new(" 0173-1#02-AAO676#003")
    {
        IdShort = "ManufacturerArticleNumber",
        Description = [
            new LangStringTextType("en", "unique product identifier of the manufacturer"),
        ],
    };

    public static readonly ConceptDescription ManufacturerOrderCodeConceptDescription = new("0173-1#02-AAO227#002")
    {
        IdShort = "ManufacturerOrderCode",
        Description = [
            new LangStringTextType("en", "By manufactures issued unique combination of numbers and letters used to identify the device for ordering"),
        ],
    };

    public static readonly ConceptDescription CD_ProductImage = new("https://admin-shell.io/ZVEI/TechnicalData/ProductImage/1/1")
    {
        IdShort = "ProductImage",
        Description = [
            new LangStringTextType("en", "Image file for associated product provided in common format (.png, .jpg)."),
        ],
    };

    public static readonly List<ConceptDescription> ConceptDescriptions =
    [
        ManufacturerNameConceptDescription,
        CD_ManufacturerLogo,
        ManufacturerProductDesignationConceptDescription,
        ManufacturerArticleNumberConceptDescription,
        ManufacturerOrderCodeConceptDescription,
        CD_ProductImage,
    ];

    public SubmodelElementCollection SubmodelElementCollection { get; }

    public GeneralInformation()
    {
        ManufacturerLogo = new AasCore.Aas3_0.File(MediaTypeNames.Image.Png)
        {
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, CD_ManufacturerLogo.Id)]),
            IdShort = CD_ManufacturerLogo.IdShort,
        };

        SubmodelElementCollection = new SubmodelElementCollection()
        {
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, TechnicalDataSubmodel.GeneralInformationConceptDescription.Id)]),
            IdShort = TechnicalDataSubmodel.GeneralInformationConceptDescription.IdShort,
            Value = [
                ManufacturerName,
                ManufacturerLogo,
                ManufacturerProductDesignation,
                ManufacturerArticleNumber,
                ManufacturerOrderCode,
            ],
        };
    }

    public Property ManufacturerName { get; } = new(DataTypeDefXsd.String)
    {
        SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, ManufacturerNameConceptDescription.Id)]),
        IdShort = ManufacturerNameConceptDescription.IdShort,
    };

    public AasCore.Aas3_0.File ManufacturerLogo { get; }

    public MultiLanguageProperty ManufacturerProductDesignation { get; } = new()
    {
        SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, ManufacturerProductDesignationConceptDescription.Id)]),
        IdShort = ManufacturerProductDesignationConceptDescription.IdShort,
    };

    public Property ManufacturerArticleNumber { get; } = new(DataTypeDefXsd.String)
    {
        SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, ManufacturerArticleNumberConceptDescription.Id)]),
        IdShort = ManufacturerArticleNumberConceptDescription.IdShort,
    };

    public Property ManufacturerOrderCode { get; } = new(DataTypeDefXsd.String)
    {
        SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, ManufacturerOrderCodeConceptDescription.Id)]),
        IdShort = ManufacturerOrderCodeConceptDescription.IdShort,
    };

    public void SetManufacturerLogo(string uri)
    {
        var logo = SubmodelElementCollection.Value.FirstOrDefault(x => x.IdShort == CD_ManufacturerLogo.IdShort) as AasCore.Aas3_0.File;

        if (logo is null)
        {
            logo = new AasCore.Aas3_0.File(MediaTypeNames.Image.Png)
            {
                SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, CD_ManufacturerLogo.Id)]),
                IdShort = CD_ManufacturerLogo.IdShort,
            };

            SubmodelElementCollection.Value.Add(logo);
        }

        logo.Value = uri;
    }

    public void AddProductImage(string uri, string mediaType)
    {
        var image = new AasCore.Aas3_0.File(mediaType)
        {
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, CD_ProductImage.Id)]),
            IdShort = CD_ProductImage.IdShort,
            Value = uri,
        };

        SubmodelElementCollection.Value.Add(image);
    }
}
