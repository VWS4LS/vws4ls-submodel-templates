using AasCore.Aas3_0;

namespace VWS4LS.SubmodelTemplates.PredictiveMaintenance;

public class PredictiveMaintenanceConditionMonitoring
{
    public static readonly ConceptDescription ListConditionIndicatorsConceptDescription = new("https://example.com/ids/cd/4510_0151_5032_2078")
    {
        IdShort = "ListConditionIndicators",
        Description =
        [
            new LangStringTextType("en", "List of condition indicators time series, e.g. values from sensors, models."),
            new LangStringTextType("de", "Liste von Zustandsindikator-Zeitreihen, z.B. Werte von Sensoren, Modellen."),
        ],
    };

    public static readonly List<ConceptDescription> ConceptDescriptions =
    [
        ListConditionIndicatorsConceptDescription,
        .. PredictiveMaintenanceListConditionIndicators.ConceptDescriptions,
    ];

    public SubmodelElementCollection SubmodelElementCollection { get; }

    public PredictiveMaintenanceConditionMonitoring()
    {
        SubmodelElementCollection = new SubmodelElementCollection()
        {
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, PredictiveMaintenanceSubmodel.ConditionMonitoringConceptDescription.Id)]),
            IdShort = PredictiveMaintenanceSubmodel.ConditionMonitoringConceptDescription.IdShort,
            Value =
            [
                ListConditionIndicators.SubmodelElementCollection,
            ],
        };
    }

    public PredictiveMaintenanceListConditionIndicators ListConditionIndicators { get; } = new();
}
