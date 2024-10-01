using AasCore.Aas3_0;

namespace VWS4LS.SubmodelTemplates.TimeSeriesData;

public class TimeSeriesRecord
{
    public static readonly ConceptDescription TimeConceptDescription = new("https://admin-shell.io/idta/TimeSeries/UtcTime/1/1")
    {
        IdShort = "Time",
        Description =
        [
            new LangStringTextType("en", "Time."),
            new LangStringTextType("de", "Zeit."),
        ],
    };

    public static readonly List<ConceptDescription> ConceptDescriptions =
    [
        TimeConceptDescription,
    ];

    public SubmodelElementCollection SubmodelElementCollection { get; }

    public TimeSeriesRecord(DateTime time) : this(time, TimeSeriesMetadata.RecordConceptDescription.IdShort!)
    {
    }

    public TimeSeriesRecord(DateTime time, string idShort)
    {
        SubmodelElementCollection = new()
        {
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, TimeSeriesMetadata.RecordConceptDescription.Id)]),
            IdShort = idShort,
            Value = [],
        };

        AddTime(time);
    }

    public void AddTime(DateTime time)
    {
        SubmodelElementCollection.Value ??= [];

        int count = SubmodelElementCollection.Value.Count(e => e.IdShort!.StartsWith(TimeConceptDescription.IdShort!));

        SubmodelElementCollection.Value.Add(new Property(DataTypeDefXsd.DateTime)
        {
            IdShort = $"{TimeConceptDescription.IdShort}{(count > 0 ? (++count).ToString("D2") : "")}",
            Value = time != DateTime.MinValue ? $"{time:yyyy-MM-ddTHH:mm:ssZ}" : null,
        });
    }

    public void AddVariable(ISubmodelElement variable)
    {
        SubmodelElementCollection.Value ??= [];
        SubmodelElementCollection.Value.Add(variable);
    }
}