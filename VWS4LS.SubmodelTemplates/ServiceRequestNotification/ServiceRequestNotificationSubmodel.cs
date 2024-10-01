using AasCore.Aas3_0;

namespace VWS4LS.SubmodelTemplates.ServiceRequestNotification;

public class ServiceRequestNotificationSubmodel
{
    public static readonly ConceptDescription ServiceRequestNotificationConceptDescription = new("0173-1#01-AHX443#001")
    {
        IdShort = "ServiceRequestNotification",
        Description = [new LangStringTextType("en", "This Submodel template aims to standardize the description of a Service Request Notification that can be used to create a Service Request Notification for industrial assets or the asset creates it by itself.")],
    };

    public static readonly ConceptDescription NumberOfServiceRequestNotificationsConceptDescription = new("0173-1#02-ABI761#001")
    {
        IdShort = "NumberOfServiceRequestNotifications",
        Description = [new LangStringTextType("en", "The number of Service Request Notifications that are available.")],
    };

    public static readonly List<ConceptDescription> ConceptDescriptions =
    [
        ServiceRequestNotificationConceptDescription,
        NumberOfServiceRequestNotificationsConceptDescription,
    ];

    public Submodel Submodel { get; }

    public ServiceRequestNotificationSubmodel(string id)
    {
        Submodel = new Submodel(id)
        {
            IdShort = ServiceRequestNotificationConceptDescription.IdShort,
            Kind = ModellingKind.Instance,
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.Submodel, ServiceRequestNotificationConceptDescription.Id)]),
            Administration = new AdministrativeInformation()
            {
                Version = "1",
                Revision = "1",
            },
            SubmodelElements =
            [
                NumberOfServiceRequestNotifications,
            ],
        };

        // Note: Technically, SMC ServiceRequestNotification has a cardinality of 1..* but we don't have any notifications yet.
    }

    public Property NumberOfServiceRequestNotifications { get; } = new(DataTypeDefXsd.Int)
    {
        SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, NumberOfServiceRequestNotificationsConceptDescription.Id)]),
        IdShort = NumberOfServiceRequestNotificationsConceptDescription.IdShort,
        Value = "0",
    };
}
