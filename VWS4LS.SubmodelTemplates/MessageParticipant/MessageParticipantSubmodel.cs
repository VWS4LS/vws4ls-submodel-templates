using AasCore.Aas3_0;

namespace VWS4LS.SubmodelTemplates.MessageParticipant;

public class MessageParticipantSubmodel
{
    public static ConceptDescription MessageParticipantConceptDescription = new("http://vws4ls.com/sample/submodel/type/messageParticipant/1/0/Submodel")
    {
        IdShort = "MessageParticipant",
    };

    public static ConceptDescription NewMessageConceptDescription = new("http://vws4ls.com/sample/submodel/type/messagePaticipant/newMessage/1/0")
    {
        IdShort = "newMessage",
    };

    public static ConceptDescription InteractionElementsConceptDescription = new("http://vws4ls.com/sample/submodel/type/messagePaticipant/interactionElements/1/0")
    {
        IdShort = "interactionElements",
    };

    public static ConceptDescription SubmodelReferencesConceptDescription = new("http://vws4ls.com/sample/submodel/type/messagePaticipant/submodelReferences/1/0")
    {
        IdShort = "submodelReferences",
    };

    public static ConceptDescription SubmodelReferenceConceptDescription = new("http://vws4ls.com/sample/submodel/type/messagePaticipant/submodelReference/1/0")
    {
        IdShort = "submodelReference",
    };

    public static ConceptDescription DataElementsConceptDescription = new("http://vws4ls.com/sample/submodel/type/messagePaticipant/dataElements/1/0")
    {
        IdShort = "dataElements",
        Description = [new LangStringTextType("de", "SMC mit Daten, die nicht in einem separaten Teilmodell stehen. Hierin können alle Teilmodellelemente des Metamodells verwendet werden.")],
    };

    public static ConceptDescription DataElementConceptDescription = new("http://vws4ls.com/sample/submodel/type/messagePaticipant/dataElement/1/0")
    {
        IdShort = "dataElement",
    };

    public static ConceptDescription FrameConceptDescription = new("http://vws4ls.com/sample/submodel/type/messagePaticipant/frame/1/0")
    {
        IdShort = "frame",
    };

    public static ConceptDescription TypeConceptDescription = new("http://vws4ls.com/sample/submodel/type/messagePaticipant/type/1/0")
    {
        IdShort = "type",
    };

    public static ConceptDescription RoleConceptDescription = new("http://vws4ls.com/sample/submodel/type/messagePaticipant/role/1/0")
    {
        IdShort = "role",
    };

    public static ConceptDescription SenderConceptDescription = new("http://vws4ls.com/sample/submodel/type/messagePaticipant/sender/1/0")
    {
        IdShort = "sender",
    };

    public static ConceptDescription ReceiverConceptDescription = new("http://vws4ls.com/sample/submodel/type/messagePaticipant/receiver/1/0")
    {
        IdShort = "receiver",
    };

    public static ConceptDescription ConversationIdConceptDescription = new("http://vws4ls.com/sample/submodel/type/messagePaticipant/conversationId/1/0")
    {
        IdShort = "conversationId",
    };

    public static ConceptDescription MessageIdConceptDescription = new("http://vws4ls.com/sample/submodel/type/messagePaticipant/messageId/1/0")
    {
        IdShort = "messageId",
    };

    public static ConceptDescription ReplyToConceptDescription = new("http://vws4ls.com/sample/submodel/type/messagePaticipant/replyTo/1/0")
    {
        IdShort = "replyTo",
    };

    public static ConceptDescription ReplyByConceptDescription = new("http://vws4ls.com/sample/submodel/type/messagePaticipant/replyBy/1/0")
    {
        IdShort = "replyBy",
    };

    public static ConceptDescription SemanticProtocolConceptDescription = new("http://vws4ls.com/sample/submodel/type/messagePaticipant/semanticProtocol/1/0")
    {
        IdShort = "semanticProtocol",
    };

    public static ConceptDescription SemanticProtocolsConceptDescription = new("http://vws4ls.com/sample/submodel/type/messagePaticipant/semanticProtocols/1/0")
    {
        IdShort = "semanticProtocols",
    };

    public static ConceptDescription SemanticProtocolListEntryConceptDescription = new("http://vws4ls.com/sample/submodel/type/messagePaticipant/semanticProtocolListEntry/1/0")
    {
        Description = [new LangStringTextType("en", "In metamodel V3 this element is a list. The list contains all semantic protocols with their realized roles.")],
    };

    public static ConceptDescription DetermineFeasibleScopeConceptDescription = new("http://vws4ls.com/sample/submodel/type/messagePaticipant/userOperation/1/0")
    {
        IdShort = "determineFeasibleScope",
        Description = [new LangStringTextType("en", "Contains the interactionElements for the I4.0 message for an specific interaction. It's a userdefined operation implemented for every interaction pattern the AAS fulfills.")],
    };

    public static ConceptDescription ProposalStructureConceptDescription = new("http://vws4ls.com/sample/submodel/type/messagePaticipant/interactionProcessDefinedVariable/1/0")
    {
        IdShort = "proposalStructure",
    };

    public static ConceptDescription StartProcessConceptDescription = new("startProcess")
    {
        IdShort = "startProcess",
    };

    public static ConceptDescription ExecutedProcessesConceptDescription = new("executedProcesses")
    {
        IdShort = "executedProcesses",
    };

    public static ConceptDescription EndProcessConceptDescription = new("endProcess")
    {
        IdShort = "endProcess",
    };

    public static ConceptDescription PriceConceptDescription = new("0173-1#02-AAO822#001")
    {
        IdShort = "price",
        Description = [new LangStringTextType("de", "Nettopreis")],
    };

    public static ConceptDescription DurationConceptDescription = new("0173-1#02-AAQ203#001")
    {
        IdShort = "duration",
        Description = [new LangStringTextType("de", "Dauer")],
    };

    public static ConceptDescription CarbonFootprintConceptDescription = new("0173-1#02-ABG855#001")
    {
        IdShort = "carbonFootprint",
    };

    public static IList<IConceptDescription> ConceptDescriptions =
    [
        MessageParticipantConceptDescription,
        NewMessageConceptDescription,
        InteractionElementsConceptDescription,
        SubmodelReferencesConceptDescription,
        SubmodelReferenceConceptDescription,
        DataElementsConceptDescription,
        DataElementConceptDescription,
        FrameConceptDescription,
        TypeConceptDescription,
        RoleConceptDescription,
        SenderConceptDescription,
        ReceiverConceptDescription,
        ConversationIdConceptDescription,
        MessageIdConceptDescription,
        ReplyToConceptDescription,
        ReplyByConceptDescription,
        SemanticProtocolConceptDescription,
        SemanticProtocolsConceptDescription,
        SemanticProtocolListEntryConceptDescription,
        DetermineFeasibleScopeConceptDescription,
        ProposalStructureConceptDescription,
        StartProcessConceptDescription,
        ExecutedProcessesConceptDescription,
        EndProcessConceptDescription,
        PriceConceptDescription,
        DurationConceptDescription,
        CarbonFootprintConceptDescription,
    ];

    public Submodel Submodel { get; }

    public MessageParticipantSubmodel(string id, string aasId)
    {
        DetermineFeasibleScope.Qualifiers.First(q => q.Type == "invocationDelegation").Value = $"http://node-red:1880/aasCommunicationManager/determineFeasibleScope?aasId={aasId}";

        Submodel = new Submodel(id)
        {
            IdShort = MessageParticipantConceptDescription.IdShort,
            Kind = ModellingKind.Instance,
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, MessageParticipantConceptDescription.Id)]),
            Administration = new AdministrativeInformation()
            {
                Version = "1",
                Revision = "0",
            },
            SubmodelElements =
            [
                NewMessage,
                SemanticProtocols,
                DetermineFeasibleScope,
            ],
        };
    }

    public Operation NewMessage { get; } = new()
    {
        SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, NewMessageConceptDescription.Id)]),
        IdShort = NewMessageConceptDescription.IdShort,
        Qualifiers =
        [
            new Qualifier("invocationDelegation", DataTypeDefXsd.String)
            {
                Value = "http://node-red:1880/aasCommunicationManager/newMessage",
            }
        ],
        InputVariables =
        [
            new OperationVariable(new SubmodelElementCollection // "interactionElements"
            {
                SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, InteractionElementsConceptDescription.Id)]),
                IdShort = InteractionElementsConceptDescription.IdShort,
                Value =
                [
                    new SubmodelElementCollection // "submodelReferences"
                    {
                        SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, SubmodelReferencesConceptDescription.Id)]),
                        IdShort = SubmodelReferencesConceptDescription.IdShort,
                        Value =
                        [
                            new ReferenceElement // "submodelReference"
                            {
                                SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, SubmodelReferenceConceptDescription.Id)]),
                                IdShort = SubmodelReferenceConceptDescription.IdShort,
                            }
                        ],
                    },
                    new SubmodelElementCollection // "dataElements"
                    {
                        SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, DataElementsConceptDescription.Id)]),
                        IdShort = DataElementsConceptDescription.IdShort,
                        Value =
                        [
                            new Property(DataTypeDefXsd.String) // "dataElement"
                            {
                                SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, DataElementConceptDescription.Id)]),
                                IdShort = $"{DataElementConceptDescription.IdShort}01",
                            }
                        ],
                    },
                ]
            }),
            new OperationVariable(new SubmodelElementCollection // "frame"
            {
                SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, FrameConceptDescription.Id)]),
                IdShort = FrameConceptDescription.IdShort,
                Value =
                [
                    new Property(DataTypeDefXsd.String) // "type"
                    {
                        SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, TypeConceptDescription.Id)]),
                        IdShort = TypeConceptDescription.IdShort,
                    },
                    new Property(DataTypeDefXsd.String) // "role"
                    {
                        SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, RoleConceptDescription.Id)]),
                        IdShort = RoleConceptDescription.IdShort,
                    },
                    new Property(DataTypeDefXsd.String) // "sender"
                    {
                        SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, SenderConceptDescription.Id)]),
                        IdShort = SenderConceptDescription.IdShort,
                    },
                    new Property(DataTypeDefXsd.String) // "receiver"
                    {
                        SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, ReceiverConceptDescription.Id)]),
                        IdShort = ReceiverConceptDescription.IdShort,
                    },
                    new Property(DataTypeDefXsd.String) // "conversationId"
                    {
                        SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, ConversationIdConceptDescription.Id)]),
                        IdShort = ConversationIdConceptDescription.IdShort,
                    },
                    new Property(DataTypeDefXsd.String) // "messageId"
                    {
                        SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, MessageIdConceptDescription.Id)]),
                        IdShort = MessageIdConceptDescription.IdShort,
                    },
                    new Property(DataTypeDefXsd.String) // "replyTo"
                    {
                        SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, ReplyToConceptDescription.Id)]),
                        IdShort = ReplyToConceptDescription.IdShort,
                    },
                    new Property(DataTypeDefXsd.DateTime) // "replyBy"
                    {
                        SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, ReplyByConceptDescription.Id)]),
                        IdShort = ReplyByConceptDescription.IdShort,
                    },
                    new Property(DataTypeDefXsd.String) // "semanticProtocol"
                    {
                        SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, SemanticProtocolConceptDescription.Id)]),
                        IdShort = SemanticProtocolConceptDescription.IdShort,
                    },
                ],
            }),
        ],
        OutputVariables = [],
    };

    public SubmodelElementList SemanticProtocols { get; } = new(AasSubmodelElements.SubmodelElementCollection)
    {
        SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, SemanticProtocolsConceptDescription.Id)]),
        IdShort = SemanticProtocolsConceptDescription.IdShort,
        Value =
        [
            new SubmodelElementCollection // "semanticProtocolListEntry"
            {
                SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, SemanticProtocolListEntryConceptDescription.Id)]),
                IdShort = SemanticProtocolListEntryConceptDescription.IdShort,
                Value =
                [
                    new Property(DataTypeDefXsd.String) // "role"
                    {
                        SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, RoleConceptDescription.Id)]),
                        IdShort = RoleConceptDescription.IdShort,
                        Qualifiers =
                        [
                            new Qualifier("FormChoices", DataTypeDefXsd.String)
                            {
                                Value = "ServiceRequester; ServiceProvider; SynchronisationMessageReceiver; SynchronisationMessageProvider",
                            },
                        ],
                        Value = "ServiceProvider",
                    },
                    new Property(DataTypeDefXsd.String) // "semanticProtocol"
                    {
                        SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, SemanticProtocolConceptDescription.Id)]),
                        IdShort = SemanticProtocolConceptDescription.IdShort,
                        Qualifiers =
                        [
                            new Qualifier("FormChoices", DataTypeDefXsd.String)
                            {
                                Value = "VDI_2193-2; Synchronisation; ChangeManagement",
                            },
                        ],
                        Value = "VDI_2193-2",
                    },
                ],
            },
        ],
    };

    public Operation DetermineFeasibleScope { get; } = new()
    {
        SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, DetermineFeasibleScopeConceptDescription.Id)]),
        IdShort = DetermineFeasibleScopeConceptDescription.IdShort,
        Qualifiers =
        [
            new Qualifier("invocationDelegation", DataTypeDefXsd.String)
            {
                // Defined in the constructor.
                Value = "http://node-red:1880/aasCommunicationManager/determineFeasibleScope?aasId={aasId}",
            }
        ],
        InputVariables =
        [
            new OperationVariable(new SubmodelElementCollection // "interactionElements"
            {
                SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, InteractionElementsConceptDescription.Id)]),
                IdShort = InteractionElementsConceptDescription.IdShort,
                Value =
                [
                    new SubmodelElementCollection // "submodelReferences"
                    {
                        SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, SubmodelReferencesConceptDescription.Id)]),
                        IdShort = SubmodelReferencesConceptDescription.IdShort,
                        Value =
                        [
                            new ReferenceElement // "submodelReference"
                            {
                                SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, SubmodelReferenceConceptDescription.Id)]),
                                IdShort = SubmodelReferenceConceptDescription.IdShort,
                            }
                        ],
                    },
                    new SubmodelElementCollection // "dataElements"
                    {
                        SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, DataElementsConceptDescription.Id)]),
                        IdShort = DataElementsConceptDescription.IdShort,
                        Value =
                        [
                            new Property(DataTypeDefXsd.String) // "dataElement"
                            {
                                SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, DataElementConceptDescription.Id)]),
                                IdShort = $"{DataElementConceptDescription.IdShort}01",
                            }
                        ],
                    },
                ],
            }),
        ],
        OutputVariables =
        [
            new OperationVariable(new SubmodelElementList(AasSubmodelElements.SubmodelElementCollection) // "proposalStructure"
            {
                SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, ProposalStructureConceptDescription.Id)]),
                IdShort = ProposalStructureConceptDescription.IdShort,
                Value =
                [
                    new SubmodelElementCollection // #00
                    {
                        Value =
                        [
                            new Property(DataTypeDefXsd.String) // "startProcess"
                            {
                                SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, StartProcessConceptDescription.Id)]),
                                IdShort = StartProcessConceptDescription.IdShort,
                                Value = "Prozesskennung",
                            },
                            new SubmodelElementList(AasSubmodelElements.Property, orderRelevant: true) // "executedProcesses"
                            {
                                SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, ExecutedProcessesConceptDescription.Id)]),
                                IdShort = ExecutedProcessesConceptDescription.IdShort,
                                Value =
                                [
                                    new Property(DataTypeDefXsd.String) // #00
                                    {
                                        Value = "Prozesskennung",
                                    },
                                ],
                            },
                            new Property(DataTypeDefXsd.String) // "endProcess"
                            {
                                SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, EndProcessConceptDescription.Id)]),
                                IdShort = EndProcessConceptDescription.IdShort,
                                Value = "Prozesskennung",
                            },
                            new Property(DataTypeDefXsd.String) // "price"
                            {
                                SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, PriceConceptDescription.Id)]),
                                IdShort = PriceConceptDescription.IdShort,
                            },
                            new Property(DataTypeDefXsd.String) // "duration"
                            {
                                SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, DurationConceptDescription.Id)]),
                                IdShort = DurationConceptDescription.IdShort,
                            },
                            new Property(DataTypeDefXsd.String) // "carbonFootprint"
                            {
                                SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, CarbonFootprintConceptDescription.Id)]),
                                IdShort = CarbonFootprintConceptDescription.IdShort,
                            },
                        ],
                    }
                ],
            }),
        ],
    };
}
