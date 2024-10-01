using AasCore.Aas3_0;
using VWS4LS.SubmodelTemplates.ContactInformation;

namespace VWS4LS.SubmodelTemplates.DigitalNameplate;

// https://industrialdigitaltwin.org/wp-content/uploads/2022/10/IDTA-02006-2-0_Submodel_Digital-Nameplate.pdf
public class DigitalNameplateSubmodel
{
    private static readonly ConceptDescription CD_URIOfTheProduct = new ConceptDescription("0173-1#02-AAY811#001")
    {
        IdShort = "URIOfTheProduct",
        Description = new List<ILangStringTextType>
            {
                new LangStringTextType("en", "unique global identification of the product using an universal resource identifier (URI)"),
            },
    };

    private static readonly ConceptDescription CD_ManufacturerName = new ConceptDescription("0173-1#02-AAO677#002")
    {
        IdShort = "ManufacturerName",
        Description = new List<ILangStringTextType>
            {
                new LangStringTextType("en", "legally valid designation of the natural or judicial person which is directly responsible for the design, production, packaging and labeling of a product in respect to its being brought into circulation"),
            },
    };

    private static readonly ConceptDescription CD_ManufacturerProductDesignation = new ConceptDescription("0173-1#02-AAW338#001")
    {
        IdShort = "ManufacturerProductDesignation",
        Description = new List<ILangStringTextType>
            {
                new LangStringTextType("en", "Short description of the product (short text)"),
            },
    };

    private static readonly ConceptDescription CD_ManufacturerProductRoot = new ConceptDescription("0173-1#02-AAU732#001")
    {
        IdShort = "ManufacturerProductRoot",
        Description = new List<ILangStringTextType>
            {
                new LangStringTextType("en", "Top level of a 3 level manufacturer specific product hierarchy"),
            },
    };

    private static readonly ConceptDescription CD_ManufacturerProductFamily = new ConceptDescription("0173-1#02-AAU731#001")
    {
        IdShort = "ManufacturerProductFamily",
        Description = new List<ILangStringTextType>
            {
                new LangStringTextType("en", "2nd level of a 3 level manufacturer specific product hierarchy"),
            },
    };

    private static readonly ConceptDescription CD_ManufacturerProductType = new ConceptDescription("0173-1#02-AAO057#002")
    {
        IdShort = "ManufacturerProductType",
        Description = new List<ILangStringTextType>
            {
                new LangStringTextType("en", "Characteristic to differentiate between different products of a product family or special variants"),
            },
    };

    private static readonly ConceptDescription CD_OrderCodeOfManufacturer = new ConceptDescription("0173-1#02-AAO227#002")
    {
        IdShort = "OrderCodeOfManufacturer",
        Description = new List<ILangStringTextType>
            {
                new LangStringTextType("en", "By manufactures issued unique combination of numbers and letters used to identify the device for ordering"),
            },
    };

    private static readonly ConceptDescription CD_ProductArticleNumberOfManufacturer = new ConceptDescription("0173-1#02-AAO676#003")
    {
        IdShort = "ProductArticleNumberOfManufacturer",
        Description = new List<ILangStringTextType>
            {
                new LangStringTextType("en", "unique product identifier of the manufacturer"),
            },
    };

    private static readonly ConceptDescription CD_SerialNumber = new ConceptDescription("0173-1#02-AAM556#002")
    {
        IdShort = "SerialNumber",
        Description = new List<ILangStringTextType>
            {
                new LangStringTextType("en", "unique combination of numbers and letters used to identify the device once it has been manufactured"),
            },
    };

    private static readonly ConceptDescription CD_YearOfConstruction = new ConceptDescription("0173-1#02-AAP906#001")
    {
        IdShort = "YearOfConstruction",
        Description = new List<ILangStringTextType>
            {
                new LangStringTextType("en", "Year as completion date of object"),
            },
    };

    private static readonly ConceptDescription CD_DateOfManufacture = new ConceptDescription("0173-1#02-AAR972#002")
    {
        IdShort = "DateOfManufacture",
        Description = new List<ILangStringTextType>
            {
                new LangStringTextType("en", "Date from which the production and / or development process is completed or from which a service is provided completely"),
            },
    };

    private static readonly ConceptDescription CD_HardwareVersion = new ConceptDescription("0173-1#02-AAN270#002")
    {
        IdShort = "HardwareVersion",
        Description = new List<ILangStringTextType>
            {
                new LangStringTextType("en", "Version of the hardware supplied with the device"),
            },
    };

    private static readonly ConceptDescription CD_FirmwareVersion = new ConceptDescription("0173-1#02-AAM985#002")
    {
        IdShort = "FirmwareVersion",
        Description = new List<ILangStringTextType>
            {
                new LangStringTextType("en", "Version of the firmware supplied with the device"),
            },
    };

    private static readonly ConceptDescription CD_SoftwareVersion = new ConceptDescription("0173-1#02-AAM737#002")
    {
        IdShort = "SoftwareVersion",
        Description = new List<ILangStringTextType>
            {
                new LangStringTextType("en", "Version of the software used by the device"),
            },
    };

    private static readonly ConceptDescription CD_CountryOfOrigin = new ConceptDescription("0173-1#02-AAO259#004")
    {
        IdShort = "CountryOfOrigin",
        Description = new List<ILangStringTextType>
            {
                new LangStringTextType("en", "Country where the product was manufactured"),
            },
    };

    private static readonly ConceptDescription CD_CompanyLogo = new ConceptDescription("https://admin-shell.io/zvei/nameplate/2/0/Nameplate/CompanyLogo")
    {
        IdShort = "CompanyLogo",
        Description = new List<ILangStringTextType>
            {
                new LangStringTextType("en", "A graphic mark used to represent a company, an organisation or a product"),
            },
    };

    private static readonly ConceptDescription CD_Markings = new ConceptDescription("0173-1#01-AGZ673#001")
    {
        IdShort = "Markings",
        Description = new List<ILangStringTextType>
            {
                new LangStringTextType("en", "Collection of product markings"),
            },
    };

    private static readonly ConceptDescription CD_AssetSpecificProperties = new ConceptDescription("0173-1#01-AGZ672#001")
    {
        IdShort = "AssetSpecificProperties",
        Description = new List<ILangStringTextType>
            {
                new LangStringTextType("en", "Group of properties that are listed on the asset's nameplate and are grouped based on guidelines"),
            },
    };

    public static readonly List<IConceptDescription> ConceptDescriptions = new(ContactInfo.ConceptDescriptions)
    {
        CD_URIOfTheProduct,
        CD_ManufacturerName,
        CD_ManufacturerProductDesignation,
        CD_ManufacturerProductRoot,
        CD_ManufacturerProductFamily,
        CD_ManufacturerProductType,
        CD_OrderCodeOfManufacturer,
        CD_ProductArticleNumberOfManufacturer,
        CD_SerialNumber,
        CD_YearOfConstruction,
        CD_DateOfManufacture,
        CD_HardwareVersion,
        CD_FirmwareVersion,
        CD_SoftwareVersion,
        CD_CountryOfOrigin,
        CD_CompanyLogo,
        CD_Markings,
        CD_AssetSpecificProperties,
    };

    public Submodel Submodel { get; }

    public DigitalNameplateSubmodel(string id)
    {
        Submodel = new Submodel(id);
        Submodel.SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.Submodel, "https://admin-shell.io/zvei/nameplate/2/0/Nameplate")]);
        Submodel.Kind = ModellingKind.Instance;
        Submodel.IdShort = "Nameplate";

        Submodel.Administration = new AdministrativeInformation
        {
            Version = "2",
            Revision = "0",
        };

        Submodel.Description = new List<ILangStringTextType>
        {
            new LangStringTextType("en", "Contains the nameplate information attached to the product"),
        };

        URIOfTheProduct = new Property(DataTypeDefXsd.String)
        {
            IdShort = CD_URIOfTheProduct.IdShort,
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, CD_URIOfTheProduct.Id)]),
        };

        ManufacturerName = new MultiLanguageProperty()
        {
            IdShort = CD_ManufacturerName.IdShort,
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, CD_ManufacturerName.Id)]),
        };

        ManufacturerProductDesignation = new MultiLanguageProperty()
        {
            IdShort = CD_ManufacturerProductDesignation.IdShort,
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, CD_ManufacturerProductDesignation.Id)]),
        };

        ContactInformation = new ContactInfo(0);

        ManufacturerProductRoot = new MultiLanguageProperty()
        {
            IdShort = CD_ManufacturerProductRoot.IdShort,
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, CD_ManufacturerProductRoot.Id)]),
        };

        ManufacturerProductFamily = new MultiLanguageProperty()
        {
            IdShort = CD_ManufacturerProductFamily.IdShort,
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, CD_ManufacturerProductFamily.Id)]),
        };

        ManufacturerProductType = new MultiLanguageProperty()
        {
            IdShort = CD_ManufacturerProductType.IdShort,
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, CD_ManufacturerProductType.Id)]),
        };

        OrderCodeOfManufacturer = new MultiLanguageProperty()
        {
            IdShort = CD_OrderCodeOfManufacturer.IdShort,
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, CD_OrderCodeOfManufacturer.Id)]),
        };

        ProductArticleNumberOfManufacturer = new MultiLanguageProperty()
        {
            IdShort = CD_ProductArticleNumberOfManufacturer.IdShort,
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, CD_ProductArticleNumberOfManufacturer.Id)]),
        };

        SerialNumber = new Property(DataTypeDefXsd.String)
        {
            IdShort = CD_SerialNumber.IdShort,
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, CD_SerialNumber.Id)]),
        };

        YearOfConstruction = new Property(DataTypeDefXsd.String)
        {
            IdShort = CD_YearOfConstruction.IdShort,
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, CD_YearOfConstruction.Id)]),
        };

        DateOfManufacture = new Property(DataTypeDefXsd.DateTime)
        {
            IdShort = CD_DateOfManufacture.IdShort,
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, CD_DateOfManufacture.Id)]),
        };

        HardwareVersion = new MultiLanguageProperty()
        {
            IdShort = CD_HardwareVersion.IdShort,
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, CD_HardwareVersion.Id)]),
        };

        FirmwareVersion = new MultiLanguageProperty()
        {
            IdShort = CD_FirmwareVersion.IdShort,
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, CD_FirmwareVersion.Id)]),
        };

        SoftwareVersion = new MultiLanguageProperty()
        {
            IdShort = CD_SoftwareVersion.IdShort,
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, CD_SoftwareVersion.Id)]),
        };

        CountryOfOrigin = new Property(DataTypeDefXsd.String)
        {
            IdShort = CD_CountryOfOrigin.IdShort,
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, CD_CountryOfOrigin.Id)]),
        };

        CompanyLogo = new AasCore.Aas3_0.File("image/png")
        {
            IdShort = CD_CompanyLogo.IdShort,
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, CD_CompanyLogo.Id)]),
        };

        Markings = new SubmodelElementCollection()
        {
            IdShort = CD_Markings.IdShort,
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, CD_Markings.Id)]),
        };

        AssetSpecificProperties = new SubmodelElementCollection()
        {
            IdShort = CD_AssetSpecificProperties.IdShort,
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, CD_AssetSpecificProperties.Id)]),
        };

        Submodel.SubmodelElements = new List<ISubmodelElement>()
        {
            URIOfTheProduct,
            ManufacturerName,
            ManufacturerProductDesignation,
            ContactInformation.SubmodelElementCollection,
            ManufacturerProductRoot,
            ManufacturerProductFamily,
            ManufacturerProductType,
            OrderCodeOfManufacturer,
            ProductArticleNumberOfManufacturer,
            SerialNumber,
            YearOfConstruction,
            DateOfManufacture,
            HardwareVersion,
            FirmwareVersion,
            SoftwareVersion,
            CountryOfOrigin,
            CompanyLogo,
            Markings,
            AssetSpecificProperties,
        };
    }

    public Property URIOfTheProduct { get; }

    public MultiLanguageProperty ManufacturerName { get; }

    public MultiLanguageProperty ManufacturerProductDesignation { get; }

    public ContactInfo ContactInformation { get; }

    public MultiLanguageProperty ManufacturerProductRoot { get; }

    public MultiLanguageProperty ManufacturerProductFamily { get; }

    public MultiLanguageProperty ManufacturerProductType { get; }

    public MultiLanguageProperty OrderCodeOfManufacturer { get; }

    public MultiLanguageProperty ProductArticleNumberOfManufacturer { get; }

    public Property SerialNumber { get; }

    public Property YearOfConstruction { get; }

    public Property DateOfManufacture { get; }

    public MultiLanguageProperty HardwareVersion { get; }

    public MultiLanguageProperty FirmwareVersion { get; }

    public MultiLanguageProperty SoftwareVersion { get; }

    public Property CountryOfOrigin { get; }

    public AasCore.Aas3_0.File CompanyLogo { get; }

    public SubmodelElementCollection Markings { get; }

    public SubmodelElementCollection AssetSpecificProperties { get; }
}