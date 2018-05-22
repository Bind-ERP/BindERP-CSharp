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
    /// NewAccount
    /// </summary>
    [DataContract]
    public partial class NewAccount :  IEquatable<NewAccount>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NewAccount" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NewAccount() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NewAccount" /> class.
        /// </summary>
        /// <param name="SubGroupID">SubGroupID (required).</param>
        /// <param name="Description">Description (required).</param>
        /// <param name="Depreciation">Depreciation.</param>
        public NewAccount(Guid? SubGroupID = default(Guid?), string Description = default(string), double? Depreciation = default(double?))
        {
            // to ensure "SubGroupID" is required (not null)
            if (SubGroupID == null)
            {
                throw new InvalidDataException("SubGroupID is a required property for NewAccount and cannot be null");
            }
            else
            {
                this.SubGroupID = SubGroupID;
            }
            // to ensure "Description" is required (not null)
            if (Description == null)
            {
                throw new InvalidDataException("Description is a required property for NewAccount and cannot be null");
            }
            else
            {
                this.Description = Description;
            }
            this.Depreciation = Depreciation;
        }
        
        /// <summary>
        /// Gets or Sets SubGroupID
        /// </summary>
        [DataMember(Name="SubGroupID", EmitDefaultValue=false)]
        public Guid? SubGroupID { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Depreciation
        /// </summary>
        [DataMember(Name="Depreciation", EmitDefaultValue=false)]
        public double? Depreciation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NewAccount {\n");
            sb.Append("  SubGroupID: ").Append(SubGroupID).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Depreciation: ").Append(Depreciation).Append("\n");
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
            return this.Equals(input as NewAccount);
        }

        /// <summary>
        /// Returns true if NewAccount instances are equal
        /// </summary>
        /// <param name="input">Instance of NewAccount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NewAccount input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SubGroupID == input.SubGroupID ||
                    (this.SubGroupID != null &&
                    this.SubGroupID.Equals(input.SubGroupID))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Depreciation == input.Depreciation ||
                    (this.Depreciation != null &&
                    this.Depreciation.Equals(input.Depreciation))
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
                if (this.SubGroupID != null)
                    hashCode = hashCode * 59 + this.SubGroupID.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Depreciation != null)
                    hashCode = hashCode * 59 + this.Depreciation.GetHashCode();
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
