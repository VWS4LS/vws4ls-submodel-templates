using AasCore.Aas3_0;

namespace VWS4LS.SubmodelTemplates.PredictiveMaintenance;

public class PredictiveMaintenanceRemainingUsefulLifePrediction
{
    public static readonly ConceptDescription RemainingUsefulLifeConceptDescription = new("https://example.com/ids/cd/7553_3151_5032_7284")
    {
        IdShort = "RemainingUsefulLife",
        Description =
        [
            new LangStringTextType("en", "Information on predicted remaining useful life."),
            new LangStringTextType("de", "Informationen zur prognostizierten Restlebensdauer."),
        ],
    };

    public static readonly ConceptDescription ListRULBoundaryConditionsConceptDescription = new("https://example.com/ids/cd/8410_4151_5032_7713")
    {
        IdShort = "ListRULBoundaryConditions",
        Description =
        [
            new LangStringTextType("en", "List of boundary conditions for which remaining useful life has been predicted."),
            new LangStringTextType("de", "Liste der Randbedingungen unter denen die nutzbare Restlebensdauer prognositiziert wurde."),
        ],
    };

    public static readonly ConceptDescription PredictionModelInformationConceptDescription = new("https://example.com/ids/cd/8413_4151_5032_4159")
    {
        IdShort = "PredictionModelInformation",
        Description =
        [
            new LangStringTextType("en", "Information about the model used for prediction of remaining useful life: type of the model and textual description of the model."),
            new LangStringTextType("de", "Informationen über das zur Vorhersage der Restnutzungsdauer verwendete Modell: Art des Modells und textliche Beschreibung des Modells."),
        ],
    };

    public static readonly List<ConceptDescription> ConceptDescriptions =
    [
        RemainingUsefulLifeConceptDescription,
        .. PredictiveMaintenanceRemainingUsefulLife.ConceptDescriptions,
        ListRULBoundaryConditionsConceptDescription,
        .. PredictiveMaintenanceListRULBoundaryConditions.ConceptDescriptions,
        PredictionModelInformationConceptDescription,
        .. PredictiveMaintenancePredictionModelInformation.ConceptDescriptions,
    ];

    public SubmodelElementCollection SubmodelElementCollection { get; }

    public PredictiveMaintenanceRemainingUsefulLifePrediction()
    {
        SubmodelElementCollection = new SubmodelElementCollection()
        {
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, PredictiveMaintenanceSubmodel.RemainingUsefulLifePredictionConceptDescription.Id)]),
            IdShort = PredictiveMaintenanceSubmodel.RemainingUsefulLifePredictionConceptDescription.IdShort,
            Value =
            [
                RemainingUsefulLife.SubmodelElementCollection,
                ListRULBoundaryConditions.SubmodelElementCollection,
                PredictionModelInformation.SubmodelElementCollection,
            ],
        };
    }

    public PredictiveMaintenanceRemainingUsefulLife RemainingUsefulLife { get; } = new();

    public PredictiveMaintenanceListRULBoundaryConditions ListRULBoundaryConditions { get; } = new();

    public PredictiveMaintenancePredictionModelInformation PredictionModelInformation { get; } = new();
}
