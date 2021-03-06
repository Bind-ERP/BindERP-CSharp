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
    /// Group
    /// </summary>
    [DataContract]
    public partial class Group :  IEquatable<Group>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Group" /> class.
        /// </summary>
        /// <param name="ID">ID.</param>
        /// <param name="Code">Code.</param>
        /// <param name="Prefix">Prefix.</param>
        /// <param name="Description">Description.</param>
        /// <param name="SubGroups">SubGroups.</param>
        public Group(Guid? ID = default(Guid?), string Code = default(string), string Prefix = default(string), string Description = default(string), List<SubGroups> SubGroups = default(List<SubGroups>))
        {
            this.ID = ID;
            this.Code = Code;
            this.Prefix = Prefix;
            this.Description = Description;
            this.SubGroups = SubGroups;
        }
        
        /// <summary>
        /// Gets or Sets ID
        /// </summary>
        [DataMember(Name="ID", EmitDefaultValue=false)]
        public Guid? ID { get; set; }

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name="Code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets Prefix
        /// </summary>
        [DataMember(Name="Prefix", EmitDefaultValue=false)]
        public string Prefix { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets SubGroups
        /// </summary>
        [DataMember(Name="SubGroups", EmitDefaultValue=false)]
        public List<SubGroups> SubGroups { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Group {\n");
            sb.Append("  ID: ").Append(ID).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Prefix: ").Append(Prefix).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  SubGroups: ").Append(SubGroups).Append("\n");
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
            return this.Equals(input as Group);
        }

        /// <summary>
        /// Returns true if Group instances are equal
        /// </summary>
        /// <param name="input">Instance of Group to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Group input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ID == input.ID ||
                    (this.ID != null &&
                    this.ID.Equals(input.ID))
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Prefix == input.Prefix ||
                    (this.Prefix != null &&
                    this.Prefix.Equals(input.Prefix))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.SubGroups == input.SubGroups ||
                    this.SubGroups != null &&
                    this.SubGroups.SequenceEqual(input.SubGroups)
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
                if (this.ID != null)
                    hashCode = hashCode * 59 + this.ID.GetHashCode();
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Prefix != null)
                    hashCode = hashCode * 59 + this.Prefix.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.SubGroups != null)
                    hashCode = hashCode * 59 + this.SubGroups.GetHashCode();
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
