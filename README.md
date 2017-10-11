# CDP4-SDK Community Edition
The Concurrent Design Platform Software Development Kit is an C# SDK that that is compliant with ECSS-E-TM-10-25A Annex A and Annex C. The SDK contains multiple libraries that are each packaged as a nuget and avaialble from nuget.org. The SDK is used in the Concurrent Design Platform (CDP4) to create an ECSS-E-TM-10-25A compliant implementation. The following libraries are made avaiable in the Community Edition under the GNU AGPL:

  - CDP4Common 
  - CDP4JsonSerializer
  - CDP4Dal

The license file is provided with each of these libraries in their respective. Please note that additional permission under GNU GPL version 3 section 7 are provided. The CDP4 Community Edition makes use of proprietary libraries 
  
## CDP4Common

The CDP4Common library is a C# implementation of the CDP4 UML master model. The CDP4 UML master model is based on the ECSS-E-TM-10-25A Annex A UML master model and extends it with CDP4 concepts to improve the use of ECSS-E-TM-10-25A Annex A for Concurrent Design of complex systems. The library contains both POCO and DTO implementations of the classes defined in the CDP4 UML master model. The POCO classes are used when a full object graph is required. The DTO's are used when a full object graph is not required, references to other class are represented by unique identifiers in the form of a GUID.

The CDP4Common library also includes a set of so-called MetaInfo classes. These classes are used to provide information about the classes in the UML master model such as the properties, relationships to other classes etc. These classes provide similar functionality as the C# reflection system, but with higher performance.

## CDP4JsonSerializer

The CDP4JsonSerializer library is an optimized CDP4Common specific JSON (de)serialization library that is used to serialize and deserialize the classes implemented in the CDP4Common class library. The (de)serialization makes use of the popular Json.NET framework to serialize and deserialize the CDP4Common DTO classes.

## CDP4Dal

Information coming soon

# License

The libraries contained in the CDP4-SDK Community Edition are provided to the community under the GNU Affero General Public License. The license that is used for each of these components is provided in their respective project folders. The CDP4 Community Edition, which makes use of the CDP4-SDK Community Edition, relies on open source and proprietary licensed components. Some of these components have a license that is not compatible with the GPL or AGPL. For these components Additional permission under GNU GPL version 3 section 7 are granted. See the license files for the details.