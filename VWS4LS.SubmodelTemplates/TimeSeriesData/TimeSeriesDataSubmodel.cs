using AasCore.Aas3_0;

namespace VWS4LS.SubmodelTemplates.TimeSeriesData;

public class TimeSeriesDataSubmodel
{
    public static readonly ConceptDescription TimeSeriesConceptDescription = new("https://admin-shell.io/idta/TimeSeries/1/1")
    {
        IdShort = "TimeSeries",
        Description =
        [
            new LangStringTextType("en", "Contains time series data and references to time series data to discover and semantically describe them along the asset lifecycle."),
            new LangStringTextType("de", "Enthält Zeitreihendaten und Referenzen auf Zeitreihendaten, um diese entlang des Asset Lebenszyklus aufzufinden und semantisch zu beschreiben."),
        ],
    };

    public static readonly ConceptDescription MetadataConceptDescription = new("https://admin-shell.io/idta/TimeSeries/Metadata/1/1")
    {
        IdShort = "Metadata",
        Description =
        [
            new LangStringTextType("en", "A set of data describing and providing information about the time series."),
            new LangStringTextType("de", "Eine Reihe von Daten, welche die Zeitreihe beschreiben und über sie Auskunft geben."),
        ],
    };

    public static readonly ConceptDescription SegmentsConceptDescription = new("https://admin-shell.io/idta/TimeSeries/Segments/1/1")
    {
        IdShort = "Segments",
        Description =
        [
            new LangStringTextType("en", "Contains segments of a time series."),
            new LangStringTextType("de", "Enthält Segmente einer Zeitreihe."),
        ],
    };

    public static readonly List<ConceptDescription> ConceptDescriptions =
    [
        TimeSeriesConceptDescription,
        MetadataConceptDescription,
        .. TimeSeriesMetadata.ConceptDescriptions,
        SegmentsConceptDescription,
        .. TimeSeriesSegments.ConceptDescriptions,
    ];

    public Submodel Submodel { get; }

    public TimeSeriesDataSubmodel(string id, TimeSeriesMetadata metadata)
    {
        Metadata = metadata;

        Submodel = new Submodel(id)
        {
            IdShort = TimeSeriesConceptDescription.IdShort,
            Kind = ModellingKind.Instance,
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.Submodel, TimeSeriesConceptDescription.Id)]),
            Administration = new AdministrativeInformation()
            {
                Version = "1",
                Revision = "1",
            },
            SubmodelElements =
            [
                Metadata.SubmodelElementCollection,
                Segments.SubmodelElementCollection,
            ],
        };
    }

    public TimeSeriesMetadata Metadata { get; }

    public TimeSeriesSegments Segments = new();
}
