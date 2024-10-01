using AasCore.Aas3_0;

namespace VWS4LS.SubmodelTemplates.Capabilities;

public class ConditionContainer
{
    public static readonly ConceptDescription CD_CapabilityCondition = new("https://wiki.eclipse.org/BaSyx_/_Documentation_/_Submodels_/_Capability#CapabilityCondition")
    {
        IdShort = "CapabilityCondition",
        Description = [new LangStringTextType("en", "Specific condition which apply before the skill is triggered or the skill is completed, respectively. These conditions can be used to check the availability of the capability.")],
    };

    public static readonly List<ConceptDescription> ConceptDescriptions =
    [
        CD_CapabilityCondition,
    ];

    public SubmodelElementCollection SubmodelElementCollection { get; }

    public ConditionContainer(int index)
    {
        SubmodelElementCollection = new SubmodelElementCollection()
        {
            IdShort = $"ConditionContainer{index:D2}",
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, "https://wiki.eclipse.org/BaSyx_/_Documentation_/_Submodels_/_Capability#ConditionContainer")]),
            Description =
            [
                new LangStringTextType("en", "Container to specifiy conditions which apply before the skill is triggered or the skill is completed, respectively. These conditions can be used to check the availability of the capability."),
            ],
            Value =
            [

            ],
        };
    }

    public void AddCapabilityCondition(IReference capability, IReference condition)
    {
        var relationship = new RelationshipElement(capability, condition)
        {
            IdShort = CD_CapabilityCondition.IdShort,
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, CD_CapabilityCondition.Id)]),
        };

        SubmodelElementCollection.Value!.Add(relationship);
    }
}
