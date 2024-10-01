using AasCore.Aas3_0;

namespace VWS4LS.SubmodelTemplates.TimeSeriesData;

public class TimeSeriesRecords
{
    public SubmodelElementCollection SubmodelElementCollection { get; }

    public TimeSeriesRecords()
    {
        SubmodelElementCollection = new SubmodelElementCollection()
        {
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, TimeSeriesInternalSegment.RecordsConceptDescription.Id)]),
            IdShort = TimeSeriesInternalSegment.RecordsConceptDescription.IdShort,
            Value = [],
        };
    }

    public void AddRecord(TimeSeriesRecord record)
    {
        SubmodelElementCollection.Value ??= [];
        SubmodelElementCollection.Value.Add(record.SubmodelElementCollection);
    }

    public int Count => SubmodelElementCollection.Value?.Count(e => e.IdShort!.StartsWith(TimeSeriesMetadata.RecordConceptDescription.IdShort!)) ?? 0;
}