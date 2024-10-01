using AasCore.Aas3_0;

namespace VWS4LS.SubmodelTemplates.ContactInformation;

public class ContactInfo
{
    public static readonly ConceptDescription CD_ContactInformation = new ConceptDescription("https://admin-shell.io/zvei/nameplate/1/0/ContactInformations/ContactInformation")
    {
        IdShort = "ContactInformation",
        Description = new List<ILangStringTextType>()
            {
                new LangStringTextType("en", "The SMC “ContactInformation” contains information on how to contact the manufacturer or an authorised service provider, e.g. when a maintenance service is required"),
            },
    };

    public static readonly ConceptDescription CD_RoleOfContactPerson = new ConceptDescription("0173-1#02-AAO204#003")
    {
        IdShort = "RoleOfContactPerson",
        Description = new List<ILangStringTextType>()
            {
                new LangStringTextType("en", "function of a contact person in a process"),
            },
    };

    public static readonly ConceptDescription CD_NationalCode = new ConceptDescription("0173-1#02-AAO134#002")
    {
        IdShort = "NationalCode",
        Description = new List<ILangStringTextType>()
            {
                new LangStringTextType("en", "code of a country"),
            },
    };

    public static readonly ConceptDescription CD_Language = new ConceptDescription("https://admin-shell.io/zvei/nameplate/1/0/ContactInformations/ContactInformation/Language")
    {
        IdShort = "Language",
        Description = new List<ILangStringTextType>()
            {
                new LangStringTextType("en", "Available language"),
            },
        IsCaseOf = [new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, "0173-1#02-AAO895#003")])],
    };

    public static readonly ConceptDescription CD_TimeZone = new ConceptDescription("https://admin-shell.io/zvei/nameplate/1/0/ContactInformations/ContactInformation/TimeZone")
    {
        IdShort = "TimeZone",
        Description = new List<ILangStringTextType>()
            {
                new LangStringTextType("en", "offsets from Coordinated Universal Time (UTC)\r\n"),
            },
    };

    public static readonly ConceptDescription CD_CityTown = new ConceptDescription("0173-1#02-AAO132#002")
    {
        IdShort = "CityTown",
        Description = new List<ILangStringTextType>()
            {
                new LangStringTextType("en", "name of a city or town"),
            },
    };

    public static readonly ConceptDescription CD_Company = new ConceptDescription("0173-1#02-AAW001#001")
    {
        IdShort = "Company",
        Description = new List<ILangStringTextType>()
            {
                new LangStringTextType("en", "name of the company"),
            },
    };

    public static readonly ConceptDescription CD_Department = new ConceptDescription("0173-1#02-AAO127#003")
    {
        IdShort = "Department",
        Description = new List<ILangStringTextType>()
            {
                new LangStringTextType("en", "administrative section within an organisation where a business partner is located"),
            },
    };

    public static readonly ConceptDescription CD_Fax = new ConceptDescription("0173-1#02-AAQ834#005")
    {
        IdShort = "Fax",
        Description = new List<ILangStringTextType>()
            {
                new LangStringTextType("en", "Fax number including type"),
            },
    };

    public static readonly ConceptDescription CD_Email = new ConceptDescription("0173-1#02-AAQ836#005")
    {
        IdShort = "Email",
        Description = new List<ILangStringTextType>()
            {
                new LangStringTextType("en", "E-mail address and encryption method"),
            },
    };

    public static readonly ConceptDescription CD_IPCommunication = new ConceptDescription("https://admin-shell.io/zvei/nameplate/1/0/ContactInformations/ContactInformation/IPCommunication")
    {
        IdShort = "IPCommunication",
        Description = new List<ILangStringTextType>()
            {
                new LangStringTextType("en", "IP-based communication channels, e.g. chat or video call"),
            },
    };

    public static readonly ConceptDescription CD_Street = new ConceptDescription("0173-1#02-AAO128#002")
    {
        IdShort = "Street",
        Description = new List<ILangStringTextType>()
            {
                new LangStringTextType("en", "street name and house number"),
            },
    };

    public static readonly ConceptDescription CD_Zipcode = new ConceptDescription("0173-1#02-AAO129#002")
    {
        IdShort = "Zipcode",
        Description = new List<ILangStringTextType>()
            {
                new LangStringTextType("en", "ZIP code of address"),
            },
    };

    public static readonly ConceptDescription CD_POBox = new ConceptDescription("0173-1#02-AAO130#002")
    {
        IdShort = "POBox",
        Description = new List<ILangStringTextType>()
            {
                new LangStringTextType("en", "post office box number"),
            },
    };

    public static readonly ConceptDescription CD_ZipCodeOfPOBox = new ConceptDescription("0173-1#02-AAO131#002")
    {
        IdShort = "ZipCodeOfPOBox",
        Description = new List<ILangStringTextType>()
            {
                new LangStringTextType("en", "ZIP code of post office box"),
            },
    };

    public static readonly ConceptDescription CD_StateCounty = new ConceptDescription("0173-1#02-AAO133#002")
    {
        IdShort = "StateCounty",
        Description = new List<ILangStringTextType>()
            {
                new LangStringTextType("en", "name of a state or county"),
            },
    };

    public static readonly ConceptDescription CD_NameOfContact = new ConceptDescription("0173-1#02-AAO205#002")
    {
        IdShort = "NameOfContact",
        Description = new List<ILangStringTextType>()
            {
                new LangStringTextType("en", "name of a contact person"),
            },
    };

    public static readonly ConceptDescription CD_FirstName = new ConceptDescription("0173-1#02-AAO206#002")
    {
        IdShort = "FirstName",
        Description = new List<ILangStringTextType>()
            {
                new LangStringTextType("en", "first name of a contact person"),
            },
    };

    public static readonly ConceptDescription CD_MiddleName = new ConceptDescription("0173-1#02-AAO207#002")
    {
        IdShort = "MiddleName",
        Description = new List<ILangStringTextType>()
            {
                new LangStringTextType("en", "middle names of a contact person"),
            },
    };

    public static readonly ConceptDescription CD_Title = new ConceptDescription("0173-1#02-AAO208#003")
    {
        IdShort = "Title",
        Description = new List<ILangStringTextType>()
            {
                new LangStringTextType("en", "common, formal, religious, or other title preceding a contact person's name"),
            },
    };

    public static readonly ConceptDescription CD_AcademicTitle = new ConceptDescription("0173-1#02-AAO209#003")
    {
        IdShort = "AcademicTitle",
        Description = new List<ILangStringTextType>()
            {
                new LangStringTextType("en", "academic title preceding a contact person's name"),
            },
    };

    public static readonly ConceptDescription CD_FurtherDetailsOfContact = new ConceptDescription("0173-1#02-AAO210#002")
    {
        IdShort = "FurtherDetailsOfContact",
        Description = new List<ILangStringTextType>()
            {
                new LangStringTextType("en", "additional information about a contact person"),
            },
    };

    public static readonly ConceptDescription CD_AddressOfAdditionalLink = new ConceptDescription("0173-1#02-AAQ326#002")
    {
        IdShort = "AddressOfAdditionalLink",
        Description = new List<ILangStringTextType>()
            {
                new LangStringTextType("en", "web site address where information about the product or contact is given"),
            },
    };

    public static readonly List<IConceptDescription> ConceptDescriptions = new(Phone.ConceptDescriptions)
    {
        CD_ContactInformation,
        CD_RoleOfContactPerson,
        CD_NationalCode,
        CD_Language,
        CD_TimeZone,
        CD_CityTown,
        CD_Company,
        CD_Department,
        CD_Fax,
        CD_Email,
        CD_IPCommunication,
        CD_Street,
        CD_Zipcode,
        CD_POBox,
        CD_ZipCodeOfPOBox,
        CD_StateCounty,
        CD_NameOfContact,
        CD_FirstName,
        CD_MiddleName,
        CD_Title,
        CD_AcademicTitle,
        CD_FurtherDetailsOfContact,
        CD_AddressOfAdditionalLink,
    };

    public SubmodelElementCollection SubmodelElementCollection { get; }

    public ContactInfo(int index)
    {
        RoleOfContactPerson = new Property(DataTypeDefXsd.String)
        {
            IdShort = CD_RoleOfContactPerson.IdShort,
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, CD_RoleOfContactPerson.Id)]),
        };

        NationalCode = new MultiLanguageProperty()
        {
            IdShort = CD_NationalCode.IdShort,
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, CD_NationalCode.Id)]),
        };

        Language = new Property(DataTypeDefXsd.String)
        {
            IdShort = CD_Language.IdShort,
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, CD_Language.Id)]),
        };

        TimeZone = new Property(DataTypeDefXsd.String)
        {
            IdShort = CD_TimeZone.IdShort,
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, CD_TimeZone.Id)]),
        };

        CityTown = new MultiLanguageProperty()
        {
            IdShort = CD_CityTown.IdShort,
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, CD_CityTown.Id)]),
        };

        Company = new MultiLanguageProperty()
        {
            IdShort = CD_Company.IdShort,
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, CD_Company.Id)]),
        };

        Department = new MultiLanguageProperty()
        {
            IdShort = CD_Department.IdShort,
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, CD_Department.Id)]),
        };

        Phone = new Phone();

        Fax = new SubmodelElementCollection
        {
            IdShort = CD_Fax.IdShort,
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, CD_Fax.Id)]),
        };

        Email = new SubmodelElementCollection
        {
            IdShort = CD_Email.IdShort,
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, CD_Email.Id)]),
        };

        Street = new MultiLanguageProperty()
        {
            IdShort = CD_Street.IdShort,
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, CD_Street.Id)]),
        };

        Zipcode = new MultiLanguageProperty()
        {
            IdShort = CD_Zipcode.IdShort,
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, CD_Zipcode.Id)]),
        };

        POBox = new MultiLanguageProperty()
        {
            IdShort = CD_POBox.IdShort,
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, CD_POBox.Id)]),
        };

        ZipCodeOfPOBox = new MultiLanguageProperty()
        {
            IdShort = CD_ZipCodeOfPOBox.IdShort,
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, CD_ZipCodeOfPOBox.Id)]),
        };

        StateCounty = new MultiLanguageProperty()
        {
            IdShort = CD_StateCounty.IdShort,
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, CD_StateCounty.Id)]),
        };

        NameOfContact = new MultiLanguageProperty()
        {
            IdShort = CD_NameOfContact.IdShort,
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, CD_NameOfContact.Id)]),
        };

        FirstName = new MultiLanguageProperty()
        {
            IdShort = CD_FirstName.IdShort,
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, CD_FirstName.Id)]),
        };

        MiddleName = new MultiLanguageProperty()
        {
            IdShort = CD_MiddleName.IdShort,
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, CD_MiddleName.Id)]),
        };

        Title = new MultiLanguageProperty()
        {
            IdShort = CD_Title.IdShort,
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, CD_Title.Id)]),
        };

        AcademicTitle = new MultiLanguageProperty()
        {
            IdShort = CD_AcademicTitle.IdShort,
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, CD_AcademicTitle.Id)]),
        };

        FurtherDetailsOfContact = new MultiLanguageProperty()
        {
            IdShort = CD_FurtherDetailsOfContact.IdShort,
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, CD_FurtherDetailsOfContact.Id)]),
        };

        AddressOfAdditionalLink = new Property(DataTypeDefXsd.AnyUri)
        {
            IdShort = CD_AddressOfAdditionalLink.IdShort,
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, CD_AddressOfAdditionalLink.Id)]),
        };

        SubmodelElementCollection = new SubmodelElementCollection
        {
            IdShort = $"{CD_ContactInformation.IdShort}{index:00}",
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, CD_ContactInformation.Id)]),
            Value = [
                RoleOfContactPerson,
                NationalCode,
                Language,
                TimeZone,
                CityTown,
                Company,
                Department,
                Phone.SubmodelElementCollection,
                Fax,
                Email,
                Street,
                Zipcode,
                POBox,
                ZipCodeOfPOBox,
                StateCounty,
                NameOfContact,
                FirstName,
                MiddleName,
                Title,
                AcademicTitle,
                FurtherDetailsOfContact,
                AddressOfAdditionalLink,
            ]
        };
    }

    public Property RoleOfContactPerson { get; }

    public MultiLanguageProperty NationalCode { get; }

    public Property Language { get; }

    public Property TimeZone { get; }

    public MultiLanguageProperty CityTown { get; }

    public MultiLanguageProperty Company { get; }

    public MultiLanguageProperty Department { get; }

    public Phone Phone { get; }

    public SubmodelElementCollection Fax { get; }

    public SubmodelElementCollection Email { get; }

    public MultiLanguageProperty Street { get; }

    public MultiLanguageProperty Zipcode { get; }

    public MultiLanguageProperty POBox { get; }

    public MultiLanguageProperty ZipCodeOfPOBox { get; }

    public MultiLanguageProperty StateCounty { get; }

    public MultiLanguageProperty NameOfContact { get; }

    public MultiLanguageProperty FirstName { get; }

    public MultiLanguageProperty MiddleName { get; }

    public MultiLanguageProperty Title { get; }

    public MultiLanguageProperty AcademicTitle { get; }

    public MultiLanguageProperty FurtherDetailsOfContact { get; }

    public Property AddressOfAdditionalLink { get; }
}