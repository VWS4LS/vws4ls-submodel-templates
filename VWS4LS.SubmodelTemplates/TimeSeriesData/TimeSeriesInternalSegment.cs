using AasCore.Aas3_0;

namespace VWS4LS.SubmodelTemplates.TimeSeriesData;

public class TimeSeriesInternalSegment
{
    public static readonly ConceptDescription StateConceptDescription = new("https://admin-shell.io/idta/TimeSeries/Segment/State/1/1")
    {
        IdShort = "State",
        Description =
        [
            new LangStringTextType("en", "State of the time series related to its progress."),
            new LangStringTextType("de", "Zustand der Zeitreihe bezogen auf ihren Fortschritt."),
        ],
    };

    public static readonly ConceptDescription StateInProgressConceptDescription = new("https://admin-shell.io/idta/TimeSeries/Segment/State/InProgress/1/1")
    {
        IdShort = "in progress",
    };

    public static readonly ConceptDescription StateCompletedConceptDescription = new("https://admin-shell.io/idta/TimeSeries/Segment/State/Completed/1/1")
    {
        IdShort = "completed",
    };

    public static readonly ConceptDescription RecordsConceptDescription = new("https://admin-shell.io/idta/TimeSeries/Records/1/1")
    {
        IdShort = "Records",
        Description =
        [
            new LangStringTextType("en", "Group of data points in successive order over a specified period of time."),
            new LangStringTextType("de", "Gruppe von Datenpunkten in aufeinanderfolgender Reihenfolge über einen bestimmten Zeitraum."),
        ],
    };

    public static readonly List<ConceptDescription> ConceptDescriptions =
    [
        StateConceptDescription,
        StateInProgressConceptDescription,
        StateCompletedConceptDescription,
        RecordsConceptDescription,
    ];

    public SubmodelElementCollection SubmodelElementCollection { get; }

    public TimeSeriesInternalSegment()
    {
        SubmodelElementCollection = new SubmodelElementCollection()
        {
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, TimeSeriesSegments.InternalSegmentConceptDescription.Id)]),
            IdShort = TimeSeriesSegments.InternalSegmentConceptDescription.IdShort,
            Value =
            [
                Records.SubmodelElementCollection,
            ],
        };
    }

    public TimeSeriesSegmentState? State {
        get => (SubmodelElementCollection.Value?.FirstOrDefault(e => e.IdShort == StateConceptDescription.IdShort) as Property)?.Value switch
        {
            "InProgress" => TimeSeriesSegmentState.InProgress,
            "Completed" => TimeSeriesSegmentState.Completed,
            _ => TimeSeriesSegmentState.InProgress,
        };
        set {
            SubmodelElementCollection.Value ??= [];
            SubmodelElementCollection.Value.RemoveAll(e => e.IdShort == StateConceptDescription.IdShort);
            SubmodelElementCollection.Value.Add(new Property(DataTypeDefXsd.String)
            {
                IdShort = StateConceptDescription.IdShort,
                Value = value switch
                {
                    TimeSeriesSegmentState.InProgress => StateInProgressConceptDescription.IdShort,
                    TimeSeriesSegmentState.Completed => StateCompletedConceptDescription.IdShort,
                    _ => throw new NotImplementedException(),
                },
            });
        }
    }

    public TimeSeriesRecords Records = new();
}
