using AasCore.Aas3_0;

namespace VWS4LS.SubmodelTemplates.PredictiveMaintenance;

public class PredictiveMaintenanceFaultDecision
{
    public static readonly ConceptDescription DecisionConceptDescription = new("https://example.com/ids/cd/7315_2151_5032_9814")
    {
        IdShort = "Decision",
        Description =
        [
            new LangStringTextType("en", "Decision whether to continue, continue with adjusted parameters, continue with adjusted mode of operation, or stop the process."),
            new LangStringTextType("de", "Entscheidung, ob der Prozess ohne Anpassung, mit angepassten Parametern, in einem angepassten Betriebsmodus weiterbetrieben wird oder der Prozess gestoppt wird definition @de: wahr: Status der Ausfallart its \"detektiert\", falsch: Status der Ausfallart its \"nicht detektiert\"."),
        ],
    };

    public static readonly List<ConceptDescription> ConceptDescriptions =
    [
        DecisionConceptDescription,
    ];

    public SubmodelElementCollection SubmodelElementCollection { get; }

    public PredictiveMaintenanceFaultDecision(string decision)
    {
        SubmodelElementCollection = new SubmodelElementCollection()
        {
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, PredictiveMaintenanceFaultDiagnosis.FaultDecisionConceptDescription.Id)]),
            IdShort = PredictiveMaintenanceFaultDiagnosis.FaultDecisionConceptDescription.IdShort,
            Value =
            [
                Decision,
            ],
        };

        Decision.Value = decision;
    }

    public Property Decision { get; } = new(DataTypeDefXsd.String)
    {
        SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, DecisionConceptDescription.Id)]),
        IdShort = DecisionConceptDescription.IdShort,
    };
}