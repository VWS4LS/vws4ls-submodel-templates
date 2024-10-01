using AasCore.Aas3_0;

namespace VWS4LS.SubmodelTemplates.PredictiveMaintenance;

public class PredictiveMaintenanceListConditionLevels
{
    public static readonly ConceptDescription ConditionLevelConceptDescription = new("https://example.com/ids/cd/9414_0151_5032_9489")
    {
        IdShort = "ConditionLevel",
        Description =
        [
            new LangStringTextType("en", "condition level, e.g. warning or alert level."),
            new LangStringTextType("de", "Zustandslevel wie Warn-/bzw. Alarmstufe."),
        ],
    };

    public static readonly List<ConceptDescription> ConceptDescriptions =
    [
        ConditionLevelConceptDescription,
        .. PredictiveMaintenanceConditionLevel.conceptDescriptions,
    ];

    public SubmodelElementCollection SubmodelElementCollection { get; }

    public PredictiveMaintenanceListConditionLevels()
    {
        SubmodelElementCollection = new SubmodelElementCollection()
        {
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, PredictiveMaintenanceConditionIndicator.ListConditionLevelsConceptDescription.Id)]),
            IdShort = PredictiveMaintenanceConditionIndicator.ListConditionLevelsConceptDescription.IdShort,
            Value = [],
        };
    }

    public void AddConditionLevel(PredictiveMaintenanceConditionLevel conditionLevel)
    {
        SubmodelElementCollection.Value ??= [];

        int count = SubmodelElementCollection.Value!.Count(e => e.IdShort!.StartsWith(ConditionLevelConceptDescription.IdShort!));
        conditionLevel.SubmodelElementCollection.IdShort = $"{ConditionLevelConceptDescription.IdShort}{count + 1:D2}";

        SubmodelElementCollection.Value.Add(conditionLevel.SubmodelElementCollection);
    }
}
