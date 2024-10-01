# vws4ls-submodel-templates

This project provides an incomplete implementation of submodel templates used for the [VWS4LS](https://github.com/vws4ls) research project. The submodels are implemented in C# using the [aas-core3.0-csharp](https://github.com/aas-core-works/aas-core3.0-csharp) library. It can be used in conjunction with the [aas-package3-csharp](https://github.com/aas-core-works/aas-package3-csharp) library to produce AASX package files.

## Supported Submodel Templates

The following submodel templates are supported by this library:

| Submodel Template                                  | Version | IDTA Number | Link                    | Remarks                                       |
| -------------------------------------------------- | ------- | ----------- | ----------------------- | --------------------------------------------- |
| Asset Interfaces Description                       | 1.0     | 02017       | [Submodel Template][1]  |
| Capability Description                             | 1.0     | 02020       | [Submodel Template][2]  | Based on an early draft of the submodel.      |
| Contact Information                                | 1.0     | 02002       | [Submodel Template][3]  |
| Digital Nameplate                                  | 2.0     | 02006       | [Submodel Template][4]  |
| Handover Documentation                             | 1.2     | 02004       | [Submodel Template][5]  |
| Hierarchical Structures enabling Bills of Material | 1.0     | 02011       | [Submodel Template][6]  |
| Message Participant                                | 1.0     |             | [TP6][7]                | New submodel developed by the VWS4LS project. |
| Predictive Maintenance                             | 1.1     | 02048       |                         | Based on an early draft of the submodel.      |
| Service Request Notification                       | 1.1     | 02010       | [Submodel Template][8]  |
| Technical Data                                     | 1.2     | 02003       | [Submodel Template][9]  |
| Time Series Data                                   | 1.1     | 02008       | [Submodel Template][10] |

<!-- links -->
[1]: https://industrialdigitaltwin.org/wp-content/uploads/2024/01/IDTA-02017-1-0_Submodel_Asset-Interfaces-Description.pdf
[2]: https://github.com/admin-shell-io/submodel-templates/tree/0b6ff2a9ae21cf6e3305081e0a1a478f393b54a7/development/Capability/1/0
[3]: https://industrialdigitaltwin.org/wp-content/uploads/2022/10/IDTA-02002-1-0_Submodel_ContactInformation.pdf
[4]: https://industrialdigitaltwin.org/wp-content/uploads/2022/10/IDTA-02006-2-0_Submodel_Digital-Nameplate.pdf
[5]: https://industrialdigitaltwin.org/wp-content/uploads/2023/03/IDTA-02004-1-2_Submodel_Handover-Documentation.pdf
[6]: https://industrialdigitaltwin.org/wp-content/uploads/2024/06/IDTA-02011-1-1_Submodel_HierarchicalStructuresEnablingBoM.pdf
[7]: https://github.com/VWS4LS/vws4ls-subproject-results/tree/main/TP06
[8]: https://industrialdigitaltwin.org/wp-content/uploads/2023/10/IDTA-02010-1-0_Submodel_ServiceRequestNotification.pdf
[9]: https://industrialdigitaltwin.org/wp-content/uploads/2022/10/IDTA-02003-1-2_Submodel_TechnicalData.pdf
[10]: https://industrialdigitaltwin.org/wp-content/uploads/2023/03/IDTA-02008-1-1_Submodel_TimeSeriesData.pdf