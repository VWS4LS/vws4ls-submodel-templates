using AasCore.Aas3_0;

namespace VWS4LS.SubmodelTemplates.PredictiveMaintenance;

public class PredictiveMaintenanceListRULBoundaryConditions
{
    public static readonly ConceptDescription RULConditionConceptDescription = new("https://example.com/ids/cd/7430_4151_5032_6288")
    {
        IdShort = "RULCondition",
        Description =
        [
            new LangStringTextType("en", "Description of a boundary condition for which remaining useful life has been predicted."),
            new LangStringTextType("de", "Beschreibung einer Randbedingung unter der die nutzbare Restlebensdauer prognostiziert wurde."),
        ],
    };

    public static readonly List<ConceptDescription> ConceptDescriptions =
    [
        RULConditionConceptDescription,
    ];

    public SubmodelElementCollection SubmodelElementCollection { get; }

    public PredictiveMaintenanceListRULBoundaryConditions()
    {
        SubmodelElementCollection = new SubmodelElementCollection()
        {
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, PredictiveMaintenanceRemainingUsefulLifePrediction.ListRULBoundaryConditionsConceptDescription.Id)]),
            IdShort = PredictiveMaintenanceRemainingUsefulLifePrediction.ListRULBoundaryConditionsConceptDescription.IdShort,
            Value =
            [
                // TODO: Implement RUL conditions
            ],
        };
    }
}
