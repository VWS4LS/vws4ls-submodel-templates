using AasCore.Aas3_0;

namespace VWS4LS.SubmodelTemplates.TimeSeriesData;

public class TimeSeriesSegments
{
    public static readonly ConceptDescription InternalSegmentConceptDescription = new("https://admin-shell.io/idta/TimeSeries/Segments/InternalSegment/1/1")
    {
        IdShort = "InternalSegment",
        Description =
        [
            new LangStringTextType("en", "Grouped sequence of data points in sequential order over a specified period of time."),
            new LangStringTextType("de", "Gruppierte Abfolge von Datenpunkten in aufeinanderfolgender Reihenfolge über einen bestimmten Zeitraum."),
        ],
    };

    public static readonly List<ConceptDescription> ConceptDescriptions =
    [
        InternalSegmentConceptDescription,
        .. TimeSeriesInternalSegment.ConceptDescriptions,
    ];

    public SubmodelElementCollection SubmodelElementCollection { get; }

    public TimeSeriesSegments()
    {
        SubmodelElementCollection = new SubmodelElementCollection()
        {
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, TimeSeriesDataSubmodel.SegmentsConceptDescription.Id)]),
            IdShort = TimeSeriesDataSubmodel.SegmentsConceptDescription.IdShort,
            Value = [],
        };
    }

    public void AddInternalSegment(TimeSeriesInternalSegment segment)
    {
        SubmodelElementCollection.Value ??= [];
        SubmodelElementCollection.Value.Add(segment.SubmodelElementCollection);
    }
}
