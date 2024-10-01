using AasCore.Aas3_0;

namespace VWS4LS.SubmodelTemplates.Capabilities;

public class ConstraintContainer
{
    public static readonly List<ConceptDescription> ConceptDescriptions = new()
    {

    };

    public SubmodelElementCollection SubmodelElementCollection { get; }

    public ConstraintContainer(int index)
    {
        SubmodelElementCollection = new SubmodelElementCollection()
        {
            IdShort = $"ConstraintContainer{index:D2}",
            // TODO: Add SemanticId (currently out of standard)
            // TODO: Add Description (currently out of standard)
            Value =
            [

            ],
        };
    }
}
