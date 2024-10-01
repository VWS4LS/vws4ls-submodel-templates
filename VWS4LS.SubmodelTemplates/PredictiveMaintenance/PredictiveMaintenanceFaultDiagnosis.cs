using AasCore.Aas3_0;

namespace VWS4LS.SubmodelTemplates.PredictiveMaintenance;

public class PredictiveMaintenanceFaultDiagnosis
{
    public static readonly ConceptDescription ListOfFailureModesConceptDescription = new("https://example.com/ids/cd/5521_2151_5032_7852")
    {
        IdShort = "ListOfFailureModes",
        Description =
        [
            new LangStringTextType("en", "List of failure modes that may occur in a sub-system."),
            new LangStringTextType("de", "Liste möglicher Ausfallarten, die in einem Sub-System auftreten können."),
        ],
    };

    public static readonly ConceptDescription FaultDecisionConceptDescription = new("https://example.com/ids/cd/7315_2151_5032_9814")
    {
        IdShort = "FaultDecision",
        Description =
        [
            new LangStringTextType("en", "Enumerated category of fault decision whether to continue, continue with adjusted parameters, continue with adjusted mode of operation, or stop the process."),
            new LangStringTextType("de", "Enumerierte Kategorie der Entscheidung nache einem Fehler, ob der Prozess ohne Anpassung, mit angepassten Parametern, in einem angepassten Betriebsmodus weiterbetrieben wird oder der Prozess gestoppt wird."),
        ],
    };

    public static readonly List<ConceptDescription> ConceptDescriptions =
    [
        ListOfFailureModesConceptDescription,
        .. PredictiveMaintenanceListFailureModes.ConceptDescriptions,
        FaultDecisionConceptDescription,
        .. PredictiveMaintenanceFaultDecision.ConceptDescriptions,
    ];

    public SubmodelElementCollection SubmodelElementCollection { get; }

    public PredictiveMaintenanceFaultDiagnosis()
    {
        SubmodelElementCollection = new SubmodelElementCollection()
        {
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, PredictiveMaintenanceSubmodel.FaultDiagnosisConceptDescription.Id)]),
            IdShort = PredictiveMaintenanceSubmodel.FaultDiagnosisConceptDescription.IdShort,
            Value =
            [
                ListFailureModes.SubmodelElementCollection,
                FaultDecision.SubmodelElementCollection,
            ],
        };
    }

    public PredictiveMaintenanceListFailureModes ListFailureModes { get; } = new();

    public PredictiveMaintenanceFaultDecision FaultDecision { get; } = new("FaultDecisionContinue");
}
