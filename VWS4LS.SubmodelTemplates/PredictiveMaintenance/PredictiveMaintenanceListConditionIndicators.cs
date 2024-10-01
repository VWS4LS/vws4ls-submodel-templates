using AasCore.Aas3_0;

namespace VWS4LS.SubmodelTemplates.PredictiveMaintenance;

public class PredictiveMaintenanceListConditionIndicators
{
    public static readonly ConceptDescription ConditionIndicatorConceptDescription = new("https://example.com/ids/cd/3301_0151_5032_6664")
    {
        IdShort = "ConditionIndicator",
        Description =
        [
            new LangStringTextType("en", "Definition of a condition indicator, e.g. values from sensors, models, used for monitoring the condition of a sub system."),
            new LangStringTextType("de", "Definition eines Zustandsindikators, z.B. Werte von Sensoren, Modellen, der für die Überwachung eines Sub-Systems verwendet wird."),
        ],
    };

    public static readonly List<ConceptDescription> ConceptDescriptions =
    [
        ConditionIndicatorConceptDescription,
        .. PredictiveMaintenanceConditionIndicator.ConceptDescriptions,
    ];

    public SubmodelElementCollection SubmodelElementCollection { get; }

    public PredictiveMaintenanceListConditionIndicators()
    {
        SubmodelElementCollection = new SubmodelElementCollection()
        {
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, PredictiveMaintenanceConditionMonitoring.ListConditionIndicatorsConceptDescription.Id)]),
            IdShort = PredictiveMaintenanceConditionMonitoring.ListConditionIndicatorsConceptDescription.IdShort,
            Value = [],
        };
    }

    public void AddConditionIndicator(PredictiveMaintenanceConditionIndicator indicator)
    {
        SubmodelElementCollection.Value ??= [];
        SubmodelElementCollection.Value.Add(indicator.SubmodelElementCollection);
    }
}
