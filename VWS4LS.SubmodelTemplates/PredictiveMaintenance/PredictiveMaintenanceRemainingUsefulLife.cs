using AasCore.Aas3_0;

namespace VWS4LS.SubmodelTemplates.PredictiveMaintenance;

public class PredictiveMaintenanceRemainingUsefulLife
{
    public static readonly ConceptDescription RemainingUsefulLifeInOperationConceptDescription = new("https://example.com/ids/cd/3374_2171_4032_8973")
    {
        IdShort = "RemainingUsefulLifeInOperation",
        Description =
        [
            new LangStringTextType("en", "Absolute value of operation time, when remaining usable life in operation ends, e.g. as time, operation cycles, distance, etc."),
            new LangStringTextType("de", "Absoluter Wert für die Betriebszeit, wenn die verbleibenden Nutzungsdauer endet, z.B. als Zeit, Zyklen, Wegstrecke, etc."),
        ],
    };

    public static readonly ConceptDescription ConfidenceIntervalConceptDescription = new("https://example.com/ids/cd/0080_0191_4032_0282")
    {
        IdShort = "ConfidenceInterval",
        Description =
        [
            new LangStringTextType("en", "Confidence intervall for remaining usable life prediction."),
            new LangStringTextType("de", "Konfidenzintervall für die prognotizierte verbleibende Nutzungsdauer."),
        ],
    };

    public static readonly List<ConceptDescription> ConceptDescriptions =
    [
        RemainingUsefulLifeInOperationConceptDescription,
        ConfidenceIntervalConceptDescription,
    ];

    public SubmodelElementCollection SubmodelElementCollection { get; }

    public PredictiveMaintenanceRemainingUsefulLife()
    {
        SubmodelElementCollection = new SubmodelElementCollection()
        {
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, PredictiveMaintenanceRemainingUsefulLifePrediction.RemainingUsefulLifeConceptDescription.Id)]),
            IdShort = PredictiveMaintenanceRemainingUsefulLifePrediction.RemainingUsefulLifeConceptDescription.IdShort,
            Value =
            [
                RemainingUsefulLifeInOperation,
                ConfidenceInterval,
            ],
        };
    }

    public Property RemainingUsefulLifeInOperation { get; } = new(DataTypeDefXsd.Decimal)
    {
        SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, RemainingUsefulLifeInOperationConceptDescription.Id)]),
        IdShort = RemainingUsefulLifeInOperationConceptDescription.IdShort,
    };

    public AasCore.Aas3_0.Range ConfidenceInterval { get; } = new(DataTypeDefXsd.Float)
    {
        SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, ConfidenceIntervalConceptDescription.Id)]),
        IdShort = ConfidenceIntervalConceptDescription.IdShort,
    };
}
