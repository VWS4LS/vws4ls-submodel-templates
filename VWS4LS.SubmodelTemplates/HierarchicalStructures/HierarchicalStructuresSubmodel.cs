using AasCore.Aas3_0;

namespace VWS4LS.SubmodelTemplates.HierarchicalStructures;

public class HierarchicalStructuresSubmodel
{
    public static readonly ConceptDescription EntryNodeConceptDescription = new("https://admin-shell.io/idta/HierarchicalStructures/EntryNode/1/0")
    {
        IdShort = "EntryNode",
        Description = [
            new LangStringTextType("en", "Base entry point for the Entity tree in this Submodel, this must be a Self-managed Entity reflecting the Assets administrated in the AAS this Submodel is part of."),
        ],
    };

    public static readonly ConceptDescription ArcheTypeConceptDescription = new("https://admin-shell.io/idta/HierarchicalStructures/ArcheType/1/0")
    {
        IdShort = "ArcheType",
        Description = [
            new LangStringTextType("en", "ArcheType of the Submodel, there are three allowed enumeration entries: 1. “Full”, 2. “OneDown” and 3. “OneUp”. These entries reflect the structure of the Submodel as defined in 1.5.1.3 & 1.5.1.4."),
        ],
    };

    public static readonly ConceptDescription NodeConceptDescription = new("https://admin-shell.io/idta/HierarchicalStructures/Node/1/0")
    {
        IdShort = "Node",
        Description = [
            new LangStringTextType("en", "The Entity Node can be a co-managed or self-managed entity representing an asset in the hierarchical structure."),
        ],
    };

    public static readonly ConceptDescription SameAsConceptDescription = new("https://admin-shell.io/idta/HierarchicalStructures/SameAs/1/0")
    {
        IdShort = "SameAs",
        Description = [
            new LangStringTextType("en", "Reference between two Entities in the same Submodel or across Submodels."),
        ],
    };

    public static readonly ConceptDescription IsPartOfConceptDescription = new("https://admin-shell.io/idta/HierarchicalStructures/IsPartOf/1/0")
    {
        IdShort = "IsPartOf",
        Description = [
            new LangStringTextType("en", "Modeling of logical connections between asset and subasset. Either this or HasPart must be used, not both. First and Second attributes must contain either a EntryNode or a Node. The relationships shall only reference EntryNodes or Nodes in the same Submodel."),
        ],
    };

    public static readonly ConceptDescription HasPartConceptDescription = new("https://admin-shell.io/idta/HierarchicalStructures/HasPart/1/0")
    {
        IdShort = "HasPart",
        Description = [
            new LangStringTextType("en", "Modeling of logical connections between components and sub-components. Either this or IsPartOf must be used, not both."),
        ],
    };

    public static readonly ConceptDescription BulkCountConceptDescription = new("https://admin-shell.io/idta/HierarchicalStructures/BulkCount/1/0")
    {
        IdShort = "BulkCount",
        Description = [
            new LangStringTextType("en", "To be used if bulk components are referenced, e.g., a 10x M4x30 screw."),
        ],
    };

    public static readonly List<ConceptDescription> ConceptDescriptions = [
        EntryNodeConceptDescription,
        ArcheTypeConceptDescription,
        NodeConceptDescription,
        SameAsConceptDescription,
        IsPartOfConceptDescription,
        HasPartConceptDescription,
        BulkCountConceptDescription,
    ];

    public Submodel Submodel { get; }

    public HierarchicalStructuresSubmodel(string id, string idShort, string archeType, string entryNodeIdShort)
    {
        ArcheType.Value = archeType;

        EntryNode = new(EntityType.SelfManagedEntity)
        {
            IdShort = entryNodeIdShort,
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, EntryNodeConceptDescription.Id)]),
            Statements = [],
        };

        Submodel = new Submodel(id)
        {
            Kind = ModellingKind.Instance,
            IdShort = idShort,
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.Submodel, "https://admin-shell.io/idta/HierarchicalStructures/1/0/Submodel")]),
            Administration = new AdministrativeInformation()
            {
                Version = "1",
                Revision = "0",
            },
            Description =
            [
                new LangStringTextType("en", "Definition of the Submodel HierarchicalStructures identified by its semanticId. The Submodel idShort can be picked freely."),
            ],
            SubmodelElements = [
                EntryNode,
                ArcheType,
            ],
        };
    }

    public Entity EntryNode { get; }

    public Property ArcheType { get; } = new(DataTypeDefXsd.String)
    {
        IdShort = ArcheTypeConceptDescription.IdShort,
        SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, ArcheTypeConceptDescription.Id)]),
    };
}