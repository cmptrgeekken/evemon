/* 
 * EVE Swagger Interface
 *
 * An OpenAPI for EVE Online
 *
 * OpenAPI spec version: 0.5.5
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// 200 ok object
    /// </summary>
    [DataContract]
    public partial class GetUniverseRegionsRegionIdOk :  IEquatable<GetUniverseRegionsRegionIdOk>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetUniverseRegionsRegionIdOk" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetUniverseRegionsRegionIdOk() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetUniverseRegionsRegionIdOk" /> class.
        /// </summary>
        /// <param name="Constellations">constellations array (required).</param>
        /// <param name="Description">description string.</param>
        /// <param name="Name">name string (required).</param>
        /// <param name="RegionId">region_id integer (required).</param>
        public GetUniverseRegionsRegionIdOk(List<int?> Constellations = default(List<int?>), string Description = default(string), string Name = default(string), int? RegionId = default(int?))
        {
            // to ensure "Constellations" is required (not null)
            if (Constellations == null)
            {
                throw new InvalidDataException("Constellations is a required property for GetUniverseRegionsRegionIdOk and cannot be null");
            }
            else
            {
                this.Constellations = Constellations;
            }
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for GetUniverseRegionsRegionIdOk and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "RegionId" is required (not null)
            if (RegionId == null)
            {
                throw new InvalidDataException("RegionId is a required property for GetUniverseRegionsRegionIdOk and cannot be null");
            }
            else
            {
                this.RegionId = RegionId;
            }
            this.Description = Description;
        }
        
        /// <summary>
        /// constellations array
        /// </summary>
        /// <value>constellations array</value>
        [DataMember(Name="constellations", EmitDefaultValue=false)]
        public List<int?> Constellations { get; set; }

        /// <summary>
        /// description string
        /// </summary>
        /// <value>description string</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// name string
        /// </summary>
        /// <value>name string</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// region_id integer
        /// </summary>
        /// <value>region_id integer</value>
        [DataMember(Name="region_id", EmitDefaultValue=false)]
        public int? RegionId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetUniverseRegionsRegionIdOk {\n");
            sb.Append("  Constellations: ").Append(Constellations).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  RegionId: ").Append(RegionId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as GetUniverseRegionsRegionIdOk);
        }

        /// <summary>
        /// Returns true if GetUniverseRegionsRegionIdOk instances are equal
        /// </summary>
        /// <param name="input">Instance of GetUniverseRegionsRegionIdOk to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetUniverseRegionsRegionIdOk input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Constellations == input.Constellations ||
                    this.Constellations != null &&
                    this.Constellations.SequenceEqual(input.Constellations)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.RegionId == input.RegionId ||
                    (this.RegionId != null &&
                    this.RegionId.Equals(input.RegionId))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Constellations != null)
                    hashCode = hashCode * 59 + this.Constellations.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.RegionId != null)
                    hashCode = hashCode * 59 + this.RegionId.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
