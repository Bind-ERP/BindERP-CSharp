/* 
 * Bind ERP API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1.2
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
    /// InventorytPage
    /// </summary>
    [DataContract]
    public partial class InventorytPage :  IEquatable<InventorytPage>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InventorytPage" /> class.
        /// </summary>
        /// <param name="value">value.</param>
        /// <param name="nextLink">nextLink.</param>
        /// <param name="count">count.</param>
        public InventorytPage(List<Inventory> value = default(List<Inventory>), string nextLink = default(string), long? count = default(long?))
        {
            this.value = value;
            this.nextLink = nextLink;
            this.count = count;
        }
        
        /// <summary>
        /// Gets or Sets value
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public List<Inventory> value { get; set; }

        /// <summary>
        /// Gets or Sets nextLink
        /// </summary>
        [DataMember(Name="nextLink", EmitDefaultValue=false)]
        public string nextLink { get; set; }

        /// <summary>
        /// Gets or Sets count
        /// </summary>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public long? count { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InventorytPage {\n");
            sb.Append("  value: ").Append(value).Append("\n");
            sb.Append("  nextLink: ").Append(nextLink).Append("\n");
            sb.Append("  count: ").Append(count).Append("\n");
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
            return this.Equals(input as InventorytPage);
        }

        /// <summary>
        /// Returns true if InventorytPage instances are equal
        /// </summary>
        /// <param name="input">Instance of InventorytPage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InventorytPage input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.value == input.value ||
                    this.value != null &&
                    this.value.SequenceEqual(input.value)
                ) && 
                (
                    this.nextLink == input.nextLink ||
                    (this.nextLink != null &&
                    this.nextLink.Equals(input.nextLink))
                ) && 
                (
                    this.count == input.count ||
                    (this.count != null &&
                    this.count.Equals(input.count))
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
                if (this.value != null)
                    hashCode = hashCode * 59 + this.value.GetHashCode();
                if (this.nextLink != null)
                    hashCode = hashCode * 59 + this.nextLink.GetHashCode();
                if (this.count != null)
                    hashCode = hashCode * 59 + this.count.GetHashCode();
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
