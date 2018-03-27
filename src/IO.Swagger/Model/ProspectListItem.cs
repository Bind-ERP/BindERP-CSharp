/* 
 * Bind ERP API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1
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
    /// ProspectListItem
    /// </summary>
    [DataContract]
    public partial class ProspectListItem :  IEquatable<ProspectListItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProspectListItem" /> class.
        /// </summary>
        /// <param name="CompanyName">CompanyName.</param>
        /// <param name="ProspectName">ProspectName.</param>
        /// <param name="Email">Email.</param>
        /// <param name="Phone">Phone.</param>
        /// <param name="ID">ID.</param>
        /// <param name="SalesMan">SalesMan.</param>
        public ProspectListItem(string CompanyName = default(string), string ProspectName = default(string), string Email = default(string), string Phone = default(string), Guid? ID = default(Guid?), string SalesMan = default(string))
        {
            this.CompanyName = CompanyName;
            this.ProspectName = ProspectName;
            this.Email = Email;
            this.Phone = Phone;
            this.ID = ID;
            this.SalesMan = SalesMan;
        }
        
        /// <summary>
        /// Gets or Sets CompanyName
        /// </summary>
        [DataMember(Name="CompanyName", EmitDefaultValue=false)]
        public string CompanyName { get; set; }

        /// <summary>
        /// Gets or Sets ProspectName
        /// </summary>
        [DataMember(Name="ProspectName", EmitDefaultValue=false)]
        public string ProspectName { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="Email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets Phone
        /// </summary>
        [DataMember(Name="Phone", EmitDefaultValue=false)]
        public string Phone { get; set; }

        /// <summary>
        /// Gets or Sets ID
        /// </summary>
        [DataMember(Name="ID", EmitDefaultValue=false)]
        public Guid? ID { get; set; }

        /// <summary>
        /// Gets or Sets SalesMan
        /// </summary>
        [DataMember(Name="SalesMan", EmitDefaultValue=false)]
        public string SalesMan { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProspectListItem {\n");
            sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
            sb.Append("  ProspectName: ").Append(ProspectName).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  ID: ").Append(ID).Append("\n");
            sb.Append("  SalesMan: ").Append(SalesMan).Append("\n");
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
            return this.Equals(input as ProspectListItem);
        }

        /// <summary>
        /// Returns true if ProspectListItem instances are equal
        /// </summary>
        /// <param name="input">Instance of ProspectListItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProspectListItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CompanyName == input.CompanyName ||
                    (this.CompanyName != null &&
                    this.CompanyName.Equals(input.CompanyName))
                ) && 
                (
                    this.ProspectName == input.ProspectName ||
                    (this.ProspectName != null &&
                    this.ProspectName.Equals(input.ProspectName))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Phone == input.Phone ||
                    (this.Phone != null &&
                    this.Phone.Equals(input.Phone))
                ) && 
                (
                    this.ID == input.ID ||
                    (this.ID != null &&
                    this.ID.Equals(input.ID))
                ) && 
                (
                    this.SalesMan == input.SalesMan ||
                    (this.SalesMan != null &&
                    this.SalesMan.Equals(input.SalesMan))
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
                if (this.CompanyName != null)
                    hashCode = hashCode * 59 + this.CompanyName.GetHashCode();
                if (this.ProspectName != null)
                    hashCode = hashCode * 59 + this.ProspectName.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Phone != null)
                    hashCode = hashCode * 59 + this.Phone.GetHashCode();
                if (this.ID != null)
                    hashCode = hashCode * 59 + this.ID.GetHashCode();
                if (this.SalesMan != null)
                    hashCode = hashCode * 59 + this.SalesMan.GetHashCode();
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