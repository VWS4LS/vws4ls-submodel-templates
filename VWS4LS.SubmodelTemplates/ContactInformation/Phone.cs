using AasCore.Aas3_0;

namespace VWS4LS.SubmodelTemplates.ContactInformation;

public class Phone
{
    public static readonly ConceptDescription CD_Phone = new ConceptDescription("https://admin-shell.io/zvei/nameplate/1/0/ContactInformations/ContactInformation/Phone")
    {
        IdShort = "Phone",
        Description = [new LangStringTextType("en", "Phone number including type")],
    };

    public static readonly ConceptDescription CD_TelephoneNumber = new("0173-1#02-AAO136#002")
    {
        IdShort = "TelephoneNumber",
        Description = [new LangStringTextType("en", "Complete telephone number to be called to reach a business partner.")],
    };

    // Enumeration:
    // 0173-1#07-AAS754#001 (office),
    // 0173-1#07-AAS755#001 (office mobile),
    // 0173-1#07-AAS756#001 (secretary),
    // 0173-1#07-AAS757#001 (substitute),
    // 0173-1#07-AAS758#001 (home),
    // 0173-1#07-AAS759#001 (private mobile)
    public static readonly ConceptDescription CD_TypeOfTelephone = new("0173-1#02-AAO137#003")
    {
        IdShort = "TypeOfTelephone",
        Description = [new LangStringTextType("en", "Characterization of a telephone according to its location or usage.")],
    };

    public static readonly ConceptDescription CD_AvailableTime = new("https://admin-shell.io/zvei/nameplate/1/0/ContactInformations/ContactInformation/AvailableTime")
    {
        IdShort = "AvailableTime",
        Description = [new LangStringTextType("en", "Specification of the available time window.")],
    };

    public static readonly List<IConceptDescription> ConceptDescriptions =
    [
        CD_Phone,
        CD_TelephoneNumber,
        CD_TypeOfTelephone,
        CD_AvailableTime,
    ];

    public SubmodelElementCollection SubmodelElementCollection { get; }

    public Phone()
    {
        TelephoneNumber = new MultiLanguageProperty()
        {
            IdShort = CD_TelephoneNumber.IdShort,
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, CD_TelephoneNumber.Id)]),
        };

        TypeOfTelephone = new Property(DataTypeDefXsd.String)
        {
            IdShort = CD_TypeOfTelephone.IdShort,
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, CD_TypeOfTelephone.Id)]),
        };

        AvailableTime = new MultiLanguageProperty()
        {
            IdShort = CD_AvailableTime.IdShort,
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, CD_AvailableTime.Id)]),
        };

        SubmodelElementCollection = new SubmodelElementCollection()
        {
            IdShort = CD_Phone.IdShort,
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, CD_Phone.Id)]),
            Value = [TelephoneNumber, TypeOfTelephone, AvailableTime],
        };
    }

    public MultiLanguageProperty TelephoneNumber { get; }

    public Property TypeOfTelephone { get; }

    public MultiLanguageProperty AvailableTime { get; }
}
