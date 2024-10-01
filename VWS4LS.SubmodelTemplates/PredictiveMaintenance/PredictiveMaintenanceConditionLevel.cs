using AasCore.Aas3_0;

namespace VWS4LS.SubmodelTemplates.PredictiveMaintenance;

public class PredictiveMaintenanceConditionLevel
{
    public static readonly ConceptDescription IndicatedConditionConceptDescription = new("0173-1#02-AAQ575#004")
    {
        IdShort = "IndicatedCondition",
        Description =
        [
            new LangStringTextType("en", "Indicated condition."),
            new LangStringTextType("de", "Angezeigter Zustand."),
        ],
    };

    public static readonly ConceptDescription ValueRangeConceptDescription = new("0173-1#02-AAV991#001")
    {
        IdShort = "ValueRange",
        Description =
        [
            new LangStringTextType("en", "Value range."),
            new LangStringTextType("de", "Wertebereich."),
        ],
    };

    public static readonly List<ConceptDescription> conceptDescriptions =
    [
        IndicatedConditionConceptDescription,
        ValueRangeConceptDescription,
    ];

    public SubmodelElementCollection SubmodelElementCollection { get; }

    public PredictiveMaintenanceConditionLevel(string condition, int rangeMin, int rangeMax, string? handler)
    {
        SubmodelElementCollection = new SubmodelElementCollection()
        {
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, PredictiveMaintenanceListConditionLevels.ConditionLevelConceptDescription.Id)]),
            IdShort = PredictiveMaintenanceListConditionLevels.ConditionLevelConceptDescription.IdShort,
            Value =
            [
                IndicatedCondition,
                ValueRange,
            ],
        };

        IndicatedCondition.Value = condition;

        ValueRange.Min = $"{rangeMin}";
        ValueRange.Max = $"{rangeMax}";

        // Special case for VWS4LS (non-normative)
        if (handler != null)
        {
            Handler = new()
            {
                IdShort = "Handler",
                Qualifiers =
                [
                    new Qualifier("invocationDelegation", DataTypeDefXsd.String, value: handler)
                ],
            };

            SubmodelElementCollection.Value.Add(Handler);
        }
    }

    public Property IndicatedCondition { get; } = new(DataTypeDefXsd.String)
    {
        SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, IndicatedConditionConceptDescription.Id)]),
        IdShort = IndicatedConditionConceptDescription.IdShort,
    };

    public AasCore.Aas3_0.Range ValueRange { get; } = new(DataTypeDefXsd.PositiveInteger)
    {
        SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, ValueRangeConceptDescription.Id)]),
        IdShort = ValueRangeConceptDescription.IdShort,
    };

    // Special case for VWS4LS (non-normative)
    public Operation Handler { get; }
}