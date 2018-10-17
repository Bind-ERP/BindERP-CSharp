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
    /// SelectExpandClause
    /// </summary>
    [DataContract]
    public partial class SelectExpandClause :  IEquatable<SelectExpandClause>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SelectExpandClause" /> class.
        /// </summary>
        /// <param name="SelectedItems">SelectedItems.</param>
        public SelectExpandClause(List<SelectItem> SelectedItems = default(List<SelectItem>))
        {
            this.SelectedItems = SelectedItems;
        }
        
        /// <summary>
        /// Gets or Sets SelectedItems
        /// </summary>
        [DataMember(Name="SelectedItems", EmitDefaultValue=false)]
        public List<SelectItem> SelectedItems { get; set; }

        /// <summary>
        /// Gets or Sets AllSelected
        /// </summary>
        [DataMember(Name="AllSelected", EmitDefaultValue=false)]
        public bool? AllSelected { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SelectExpandClause {\n");
            sb.Append("  SelectedItems: ").Append(SelectedItems).Append("\n");
            sb.Append("  AllSelected: ").Append(AllSelected).Append("\n");
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
            return this.Equals(input as SelectExpandClause);
        }

        /// <summary>
        /// Returns true if SelectExpandClause instances are equal
        /// </summary>
        /// <param name="input">Instance of SelectExpandClause to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SelectExpandClause input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SelectedItems == input.SelectedItems ||
                    this.SelectedItems != null &&
                    this.SelectedItems.SequenceEqual(input.SelectedItems)
                ) && 
                (
                    this.AllSelected == input.AllSelected ||
                    (this.AllSelected != null &&
                    this.AllSelected.Equals(input.AllSelected))
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
                if (this.SelectedItems != null)
                    hashCode = hashCode * 59 + this.SelectedItems.GetHashCode();
                if (this.AllSelected != null)
                    hashCode = hashCode * 59 + this.AllSelected.GetHashCode();
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
