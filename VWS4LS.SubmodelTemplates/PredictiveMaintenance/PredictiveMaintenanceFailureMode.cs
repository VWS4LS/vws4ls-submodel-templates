using AasCore.Aas3_0;

namespace VWS4LS.SubmodelTemplates.PredictiveMaintenance;

public class PredictiveMaintenanceFailureMode
{
    public static readonly ConceptDescription StatusDetectedConceptDescription = new("https://example.com/ids/cd/2222_2151_5032_2694")
    {
        IdShort = "StatusDetected",
        Description =
        [
            new LangStringTextType("en", "Status of the failure mode: true: detected, false: not detected. In case of \"true\" SMC FailueModeDetectedInformation has to be provided."),
            new LangStringTextType("de", "Status der Ausfallart: true: aufgetreten, false: nicht aufgetreten. Im Fall \"true\" muss die SMC ailueModeDetectedInformation bereitgestellt werden."),
        ],
    };

    public static readonly ConceptDescription FailureDescriptionConceptDescription = new("https://example.com/ids/cd/3262_2151_5032_0899")
    {
        IdShort = "FailureDescription",
        Description =
        [
            new LangStringTextType("en", "Description of the failure mode."),
            new LangStringTextType("de", "Beschreibung der Ausfallart."),
        ],
    };

    public static readonly ConceptDescription FailureCodeConceptDescription = new("https://example.com/ids/cd/6093_3110_6032_6663")
    {
        IdShort = "FailureCode",
        Description =
        [
            new LangStringTextType("en", "Alphanumerical code of a specific failure."),
            new LangStringTextType("de", "Alphanumerischer Code eines bestimmten Fehlers."),
        ],
    };

    public static readonly List<ConceptDescription> ConceptDescriptions =
    [
        StatusDetectedConceptDescription,
        FailureDescriptionConceptDescription,
        FailureCodeConceptDescription,
    ];

    public SubmodelElementCollection SubmodelElementCollection { get; }

    public PredictiveMaintenanceFailureMode(bool status, string description, string code)
    {
        SubmodelElementCollection = new SubmodelElementCollection()
        {
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, PredictiveMaintenanceListFailureModes.FailureModeConceptDescription.Id)]),
            IdShort = PredictiveMaintenanceListFailureModes.FailureModeConceptDescription.IdShort,
            Value =
            [
                StatusDetected,
                FailureDescription,
                FailureCode,
            ],
        };

        StatusDetected.Value = $"{status}";
        FailureDescription.Value = [new LangStringTextType("en", description)];
        FailureCode.Value = code;
    }

    public Property StatusDetected { get; } = new(DataTypeDefXsd.Boolean)
    {
        SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, StatusDetectedConceptDescription.Id)]),
        IdShort = StatusDetectedConceptDescription.IdShort,
    };

    public MultiLanguageProperty FailureDescription { get; } = new()
    {
        SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, FailureDescriptionConceptDescription.Id)]),
        IdShort = FailureDescriptionConceptDescription.IdShort,
    };

    public Property FailureCode { get; } = new(DataTypeDefXsd.String)
    {
        SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, FailureCodeConceptDescription.Id)]),
        IdShort = FailureCodeConceptDescription.IdShort,
    };
}
