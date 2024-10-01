using AasCore.Aas3_0;

namespace VWS4LS.SubmodelTemplates.TimeSeriesData;

public class TimeSeriesMetadata
{
    public static readonly ConceptDescription NameConceptDescription = new("https://admin-shell.io/idta/TimeSeries/Metadata/Name/1/1")
    {
        IdShort = "Name",
        Description =
        [
            new LangStringTextType("en", "Meaningful name for labeling."),
            new LangStringTextType("de", "Aussagekräftiger Name zur Beschriftung."),
        ],
    };

    public static readonly ConceptDescription DescriptionConceptDescription = new("https://admin-shell.io/idta/TimeSeries/Metadata/Description/1/1")
    {
        IdShort = "Description",
        Description =
        [
            new LangStringTextType("en", "Short description of the time series."),
            new LangStringTextType("de", "Kurze Beschreibung der Zeitreihendaten."),
        ],
    };

    public static readonly ConceptDescription RecordConceptDescription = new("https://admin-shell.io/idta/TimeSeries/Record/1/1")
    {
        IdShort = "Record",
        Description =
        [
            new LangStringTextType("en", "A time series record is unique by its ID within the time series and contains the timestamps and variable values referenced to the ID."),
            new LangStringTextType("de", "Ein Zeitreihen-Datensatz ist durch seine ID innerhalb der Zeitreihe eindeutig und beinhaltet die auf die ID referenzierten Zeitstempel und Variablenwerte."),
        ],
    };

    public static readonly List<ConceptDescription> ConceptDescriptions =
    [
        NameConceptDescription,
        DescriptionConceptDescription,
        RecordConceptDescription,
        .. TimeSeriesRecord.ConceptDescriptions,
    ];

    public SubmodelElementCollection SubmodelElementCollection { get; }

    public TimeSeriesMetadata(TimeSeriesRecord record, string name)
    {
        Record = record;

        // This is a hack to clear the values in the "metadata" record.
        Record.SubmodelElementCollection.Value?.ForEach(e => (e as Property).Value = null);

        Name = new()
        {
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, NameConceptDescription.Id)]),
            IdShort = NameConceptDescription.IdShort,
            Value = [new LangStringTextType("en", name)],
        };

        SubmodelElementCollection = new()
        {
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, TimeSeriesDataSubmodel.MetadataConceptDescription.Id)]),
            IdShort = TimeSeriesDataSubmodel.MetadataConceptDescription.IdShort,
            Value =
            [
                Name,
                Description,
                Record.SubmodelElementCollection,
            ],
        };
    }

    public MultiLanguageProperty Name { get; }

    public MultiLanguageProperty Description = new()
    {
        SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, DescriptionConceptDescription.Id)]),
        IdShort = DescriptionConceptDescription.IdShort,
    };

    public TimeSeriesRecord Record { get; }
}
