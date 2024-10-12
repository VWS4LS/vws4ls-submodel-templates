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

## Approach

There is a dedicated class for each Submodel Template with public properties that expose the Submodel, its Submodel Elements, and corresponding Concept Descriptions. Concept Descriptions are static so they can be used without creating a class instance first.

Please note that Submodel Elements are always initialized when the object is constructed. This is done to make it simpler for callers to work with the Submodel without having to dynamically initialize elements. But this also means that all Submodel Elements that aren't used will still be initialized with empty values.

## Usage

The following example illustrates how to create a package with Asset Administration Shell and the Digital Nameplate Submodel.
```C#
using AasCore.Aas3.Package;
using AasCore.Aas3_0;
using System.Net.Mime;
using System.Xml;
using VWS4LS.SubmodelTemplates.DigitalNameplate;

// Create digital nameplate
DigitalNameplateSubmodel digitalNameplate = new(id: "http://vws4ls.de/sm/22A74882-213E-4678-ABD0-DE46755DA8FA");
digitalNameplate.CountryOfOrigin.Value = "Germany";
digitalNameplate.DateOfManufacture.Value = "2024-10-15";
digitalNameplate.YearOfConstruction.Value = "2024";
digitalNameplate.ManufacturerName.Value = [new LangStringTextType("de", "VWS4LS")];
digitalNameplate.CompanyLogo.Value = "https://avatars.githubusercontent.com/u/177032889?s=96&v=4";

// Create Asset Administration Shell
AssetInformation assetInformation = new(AssetKind.Type)
{
    GlobalAssetId = "http://admin-shell.io/aas/9C78EEC9-95DE-42FB-8464-1052D4EA8FA9",
};

AdministrativeInformation administrativeInformation = new(version: "1", revision: "0");

AssetAdministrationShell aas = new(
    id: "http://admin-shell.io/aas/9B391120-76AE-4B2D-8AD0-584D44FBB84D",
    assetInformation: assetInformation)
{
    Administration = administrativeInformation,
    IdShort = "VWS4LS_Example_AAS",
    Submodels = 
    [
        // Add a reference to the Digital Nameplate Submodel
        new Reference(ReferenceTypes.ModelReference, [new Key(KeyTypes.Submodel, digitalNameplate.Submodel.Id)]),
    ],
};


// Create the environment and add the AAS and the Digital Nameplate Submodel
// as well as the ConceptDescriptions of the Digital Nameplate Submodel
AasCore.Aas3_0.Environment environment = new()
{
    AssetAdministrationShells =
    [
        aas,
    ],
    Submodels =
    [
        digitalNameplate.Submodel,
    ],
    ConceptDescriptions =
    [
        .. DigitalNameplateSubmodel.ConceptDescriptions,
    ]
};


// Create a package
var packaging = new Packaging();
using var package = packaging.Create("VWS4LS_Example.aasx");

// Serialize the environment
using var stream = new MemoryStream();
using var writer = XmlWriter.Create(stream);

Xmlization.Serialize.To(environment, writer);
writer.Flush();
stream.Position = 0;

// Put the environment into the package
Uri envPath = new Uri("/aasx/data.xml", UriKind.Relative);
var envPart = package.PutPart(envPath, MediaTypeNames.Text.Xml, stream);

// Mark the environment as the main entry point
package.MakeSpec(envPart);

// Save the package
package.Flush();
```

Use [Eclipse AASX Package Explorer](https://github.com/eclipse-aaspe/package-explorer) to view the package file.

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
