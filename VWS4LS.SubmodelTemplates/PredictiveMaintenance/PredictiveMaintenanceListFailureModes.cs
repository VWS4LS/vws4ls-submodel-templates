using AasCore.Aas3_0;

namespace VWS4LS.SubmodelTemplates.PredictiveMaintenance;

public class PredictiveMaintenanceListFailureModes
{
    public static readonly ConceptDescription FailureModeConceptDescription = new("https://example.com/ids/cd/2561_2151_5032_8023")
    {
        IdShort = "FailureMode",
        Description =
        [
            new LangStringTextType("en", "Failure Mode according to DIN EN IEC 63270:2022-09."),
            new LangStringTextType("de", "Ausfallart gemäß DIN EN IEC 63270:2022-09."),
        ],
    };

    public static readonly List<ConceptDescription> ConceptDescriptions =
    [
        FailureModeConceptDescription,
        .. PredictiveMaintenanceFailureMode.ConceptDescriptions,
    ];

    public SubmodelElementCollection SubmodelElementCollection { get; }

    public PredictiveMaintenanceListFailureModes()
    {
        SubmodelElementCollection = new SubmodelElementCollection()
        {
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, PredictiveMaintenanceFaultDiagnosis.ListOfFailureModesConceptDescription.Id)]),
            IdShort = PredictiveMaintenanceFaultDiagnosis.ListOfFailureModesConceptDescription.IdShort,
            Value = [],
        };
    }

    public void AddFailureMode(PredictiveMaintenanceFailureMode failureMode)
    {
        SubmodelElementCollection.Value ??= [];

        int count = SubmodelElementCollection.Value!.Count(e => e.IdShort!.StartsWith(FailureModeConceptDescription.IdShort!));

        failureMode.SubmodelElementCollection.IdShort = $"{FailureModeConceptDescription.IdShort}{count + 1:D2}";

        SubmodelElementCollection.Value.Add(failureMode.SubmodelElementCollection);
    }
}
