using AasCore.Aas3_0;

namespace VWS4LS.SubmodelTemplates.PredictiveMaintenance;

public class PredictiveMaintenanceConditionIndicator
{
    public static readonly ConceptDescription ConditionIndicatorNameConceptDescription = new("https://example.com/ids/cd/6570_0180_5032_9837")
    {
        IdShort = "ConditionIndicatorName",
        Description =
        [
            new LangStringTextType("en", "Name of a condition indicator which is used for monitoring the sub system."),
            new LangStringTextType("de", "Bezeichnung eines Zustandsindikators, der für die Überwachung des Sub-Systems verwendet wird.."),
        ],
    };

    public static readonly ConceptDescription IndicatorDomainConceptDescription = new("https://example.com/ids/cd/3122_0151_5032_6408")
    {
        IdShort = "IndicatorDomain",
        Description =
        [
            new LangStringTextType("en", "domain of the indicator: time, frequency, mixed, other."),
            new LangStringTextType("de", "Domäne des Indikators: Zeit, Frequenz, gemischt, andere."),
        ],
    };

    public static readonly ConceptDescription TimeSeriesConceptDescription = new("https://admin-shell.io/sandbox/zvei/TimeSeriesData/1/0")
    {
        IdShort = "TimeSeries",
        Description =
        [
            new LangStringTextType("en", "Contains time series data and references to time series data to discover and semantically describe them along the asset lifecycle."),
            new LangStringTextType("de", "Enthält Zeitreihendaten und Referenzen auf Zeitreihendaten, um diese entlang des Asset Lebenszyklus aufzufinden und semantisch zu beschreiben."),
        ],
    };

    public static readonly ConceptDescription MeasurementAccuracyConceptDescription = new("0173-1#02-BAB511#006")
    {
        IdShort = "MeasurementAccuracy",
        Description =
        [
            new LangStringTextType("en", "measurement accuracy."),
            new LangStringTextType("de", "Messgenauigkeit."),
        ],
    };

    public static readonly ConceptDescription ListConditionLevelsConceptDescription = new("https://example.com/ids/cd/5313_0151_5032_8129")
    {
        IdShort = "ListConditionLevels",
        Description =
        [
            new LangStringTextType("en", "List of possible condition levels, e.g. warning or alert levels."),
            new LangStringTextType("de", "Liste der möglichen Zustandslevel wie Warn-/bzw. Alarmlevel."),
        ],
    };

    public static readonly List<ConceptDescription> ConceptDescriptions =
    [
        ConditionIndicatorNameConceptDescription,
        IndicatorDomainConceptDescription,
        TimeSeriesConceptDescription,
        MeasurementAccuracyConceptDescription,
        ListConditionLevelsConceptDescription,
        .. PredictiveMaintenanceListConditionLevels.ConceptDescriptions,
    ];

    public SubmodelElementCollection SubmodelElementCollection { get; }

    public PredictiveMaintenanceConditionIndicator(string name, string domain, Reference timeSeries, double accuracy)
    {
        SubmodelElementCollection = new SubmodelElementCollection()
        {
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, PredictiveMaintenanceListConditionIndicators.ConditionIndicatorConceptDescription.Id)]),
            IdShort = PredictiveMaintenanceListConditionIndicators.ConditionIndicatorConceptDescription.IdShort,
            Value =
            [
                ConditionIndicatorName,
                IndicatorDomain,
                TimeSeries,
                MeasurementAccuracy,
                ListConditionLevels.SubmodelElementCollection,
            ],
        };

        ConditionIndicatorName.Value = [new LangStringTextType("en", name)];
        IndicatorDomain.Value = domain;
        TimeSeries.Value = timeSeries;
        MeasurementAccuracy.Value = $"{accuracy}";
    }

    public MultiLanguageProperty ConditionIndicatorName { get; } = new()
    {
        SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, ConditionIndicatorNameConceptDescription.Id)]),
        IdShort = ConditionIndicatorNameConceptDescription.IdShort,
    };

    public Property IndicatorDomain { get; } = new(DataTypeDefXsd.String)
    {
        SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, IndicatorDomainConceptDescription.Id)]),
        IdShort = IndicatorDomainConceptDescription.IdShort,
    };

    public ReferenceElement TimeSeries { get; } = new()
    {
        SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, TimeSeriesConceptDescription.Id)]),
        IdShort = TimeSeriesConceptDescription.IdShort,
    };

    public Property MeasurementAccuracy { get; } = new(DataTypeDefXsd.Double)
    {
        SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, MeasurementAccuracyConceptDescription.Id)]),
        IdShort = MeasurementAccuracyConceptDescription.IdShort,
    };

    public PredictiveMaintenanceListConditionLevels ListConditionLevels { get; } = new();
}
