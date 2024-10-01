using AasCore.Aas3_0;

namespace VWS4LS.SubmodelTemplates.Capabilities;

public class CapabilityRelationships
{
    public static readonly ConceptDescription CD_RealizedBy = new("https://wiki.eclipse.org/BaSyx_/_Documentation_/_Submodels_/_Capability#CapabilityRealizedBy")
    {
        IdShort = "realizedBy",
        Description = [new LangStringTextType("en", "Relation to an capabaility submodel-external skill/implementation realizing the capability.")],
    };

    public static readonly List<ConceptDescription> ConceptDescriptions = new(ConditionContainer.ConceptDescriptions.Concat(ConstraintContainer.ConceptDescriptions))
    {
        CD_RealizedBy,
    };

    public SubmodelElementCollection SubmodelElementCollection { get; }

    public CapabilityRelationships()
    {
        SubmodelElementCollection = new SubmodelElementCollection()
        {
            IdShort = "CapabilityRelationships",
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, "https://wiki.eclipse.org/BaSyx_/_Documentation_/_Submodels_/_Capability#CapabilityRelationships")]),
            Description =
            [
                new LangStringTextType("en", "Set of all relations of the capability, contained in the capability container."),
            ],
            Value =
            [

            ],
        };
    }

    public void AddRealizedBy(IReference capability, IReference skill)
    {
        var relationship = new RelationshipElement(capability, skill)
        {
            IdShort = CD_RealizedBy.IdShort,
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, CD_RealizedBy.Id)]),
        };

        SubmodelElementCollection.Value!.Add(relationship);
    }

    public void AddRealizedBy(IReference capability, IReference skill, List<IDataElement> annotations)
    {
        var relationship = new AnnotatedRelationshipElement(capability, skill, annotations: annotations)
        {
            IdShort = CD_RealizedBy.IdShort,
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, CD_RealizedBy.Id)]),
        };

        SubmodelElementCollection.Value!.Add(relationship);
    }

    public void AddConditionContainer(ConditionContainer conditionContainer)
    {
        SubmodelElementCollection.Value!.Add(conditionContainer.SubmodelElementCollection);
    }

    public void AddConstraintContainer(ConstraintContainer constraintContainer)
    {
        SubmodelElementCollection.Value!.Add(constraintContainer.SubmodelElementCollection);
    }
}
