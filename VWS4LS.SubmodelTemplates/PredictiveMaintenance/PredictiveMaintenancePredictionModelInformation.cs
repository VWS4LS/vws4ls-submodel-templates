using AasCore.Aas3_0;

namespace VWS4LS.SubmodelTemplates.PredictiveMaintenance;

public class PredictiveMaintenancePredictionModelInformation
{
    // TODO: Implement model

    public static readonly List<ConceptDescription> ConceptDescriptions =
    [
    ];

    public SubmodelElementCollection SubmodelElementCollection { get; }

    public PredictiveMaintenancePredictionModelInformation()
    {
        SubmodelElementCollection = new SubmodelElementCollection()
        {
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, PredictiveMaintenanceRemainingUsefulLifePrediction.PredictionModelInformationConceptDescription.Id)]),
            IdShort = PredictiveMaintenanceRemainingUsefulLifePrediction.PredictionModelInformationConceptDescription.IdShort,
            Value =
            [
            ],
        };
    }
}