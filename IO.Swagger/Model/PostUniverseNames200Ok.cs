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
    public partial class PostUniverseNames200Ok :  IEquatable<PostUniverseNames200Ok>, IValidatableObject
    {
        /// <summary>
        /// category string
        /// </summary>
        /// <value>category string</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CategoryEnum
        {
            
            /// <summary>
            /// Enum Alliance for "alliance"
            /// </summary>
            [EnumMember(Value = "alliance")]
            Alliance,
            
            /// <summary>
            /// Enum Character for "character"
            /// </summary>
            [EnumMember(Value = "character")]
            Character,
            
            /// <summary>
            /// Enum Constellation for "constellation"
            /// </summary>
            [EnumMember(Value = "constellation")]
            Constellation,
            
            /// <summary>
            /// Enum Corporation for "corporation"
            /// </summary>
            [EnumMember(Value = "corporation")]
            Corporation,
            
            /// <summary>
            /// Enum Inventorytype for "inventory_type"
            /// </summary>
            [EnumMember(Value = "inventory_type")]
            Inventorytype,
            
            /// <summary>
            /// Enum Region for "region"
            /// </summary>
            [EnumMember(Value = "region")]
            Region,
            
            /// <summary>
            /// Enum Solarsystem for "solar_system"
            /// </summary>
            [EnumMember(Value = "solar_system")]
            Solarsystem,
            
            /// <summary>
            /// Enum Station for "station"
            /// </summary>
            [EnumMember(Value = "station")]
            Station
        }

        /// <summary>
        /// category string
        /// </summary>
        /// <value>category string</value>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public CategoryEnum? Category { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PostUniverseNames200Ok" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PostUniverseNames200Ok() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PostUniverseNames200Ok" /> class.
        /// </summary>
        /// <param name="Category">category string (required).</param>
        /// <param name="Id">id integer (required).</param>
        /// <param name="Name">name string (required).</param>
        public PostUniverseNames200Ok(CategoryEnum? Category = default(CategoryEnum?), int? Id = default(int?), string Name = default(string))
        {
            // to ensure "Category" is required (not null)
            if (Category == null)
            {
                throw new InvalidDataException("Category is a required property for PostUniverseNames200Ok and cannot be null");
            }
            else
            {
                this.Category = Category;
            }
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for PostUniverseNames200Ok and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for PostUniverseNames200Ok and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
        }
        

        /// <summary>
        /// id integer
        /// </summary>
        /// <value>id integer</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// name string
        /// </summary>
        /// <value>name string</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PostUniverseNames200Ok {\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as PostUniverseNames200Ok);
        }

        /// <summary>
        /// Returns true if PostUniverseNames200Ok instances are equal
        /// </summary>
        /// <param name="input">Instance of PostUniverseNames200Ok to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostUniverseNames200Ok input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.Category != null)
                    hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
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
