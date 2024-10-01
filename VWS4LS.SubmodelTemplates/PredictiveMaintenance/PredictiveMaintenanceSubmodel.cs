using AasCore.Aas3_0;

namespace VWS4LS.SubmodelTemplates.PredictiveMaintenance;

public class PredictiveMaintenanceSubmodel
{
    public static readonly ConceptDescription ConditionMonitoringConceptDescription = new("https://example.com/ids/cd/3045_9051_5032_6159")
    {
        IdShort = "ConditionMonitoring",
        Description =
        [
            new LangStringTextType("en", "Contains condition monitoring indicators and data."),
            new LangStringTextType("de", "Enthält Indikatoren und Daten zur Zustandsüberwachung."),
        ],
    };

    public static readonly ConceptDescription FaultDiagnosisConceptDescription = new("https://example.com/ids/cd/5380_2151_5032_2670")
    {
        IdShort = "FaultDiagnosis",
        Description =
        [
            new LangStringTextType("en", "Contains data and indicators about fault diagnosis relevant for predictive maintenance."),
            new LangStringTextType("de", "Enthält Daten und Indikatoren über die Fehlerdiagnose, die für vorausschauende Wartung relevant sind."),
        ],
    };

    public static readonly ConceptDescription RemainingUsefulLifePredictionConceptDescription = new("https://example.com/ids/cd/7513_3151_5032_3911")
    {
        IdShort = "RemainingUsefulLifePrediction",
        Description =
        [
            new LangStringTextType("en", "Information on prediction of remaining usable life of an asset."),
            new LangStringTextType("de", "Informationen über die Vorhersage der Restlebensdauer des Assets."),
        ],
    };

    public static readonly ConceptDescription LastMaintenanceRelevantEventsConceptDescription = new("https://example.com/ids/cd/6555_4151_5032_7244")
    {
        IdShort = "LastMaintenanceRelevantEvents",
        Description =
        [
            new LangStringTextType("en", "Wear relevant information about last maintenance event."),
            new LangStringTextType("de", "Verschleißrelevante Informationen zu den letzten Wartungs- und Instandsetzungsmaßnahmen."),
        ],
    };

    public static readonly List<ConceptDescription> ConceptDescriptions =
    [
        ConditionMonitoringConceptDescription,
        .. PredictiveMaintenanceConditionMonitoring.ConceptDescriptions,
        FaultDiagnosisConceptDescription,
        .. PredictiveMaintenanceFaultDiagnosis.ConceptDescriptions,
        RemainingUsefulLifePredictionConceptDescription,
        .. PredictiveMaintenanceRemainingUsefulLifePrediction.ConceptDescriptions,
        LastMaintenanceRelevantEventsConceptDescription,
    ];

    public Submodel Submodel { get; }

    public PredictiveMaintenanceSubmodel(string id)
    {
        Submodel = new Submodel(id)
        {
            IdShort = "PredictiveMaintenance",
            Kind = ModellingKind.Instance,
            Administration = new AdministrativeInformation()
            {
                Version = "1",
                Revision = "1",
            },
            SubmodelElements =
            [
                ConditionMonitoring.SubmodelElementCollection,
                FaultDiagnosis.SubmodelElementCollection,
                RemainingUsefulLifePrediction.SubmodelElementCollection,
                LastMaintenanceRelevantEvents,
            ],
        };
    }

    public PredictiveMaintenanceConditionMonitoring ConditionMonitoring { get; } = new();

    public PredictiveMaintenanceFaultDiagnosis FaultDiagnosis { get; } = new();

    public PredictiveMaintenanceRemainingUsefulLifePrediction RemainingUsefulLifePrediction { get; } = new();

    public SubmodelElementCollection LastMaintenanceRelevantEvents { get; } = new()
    {
        SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, LastMaintenanceRelevantEventsConceptDescription.Id)]),
        IdShort = LastMaintenanceRelevantEventsConceptDescription.IdShort,
        Value = [],
    };
}
