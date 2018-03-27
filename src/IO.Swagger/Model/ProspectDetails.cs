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
    /// ProspectDetails
    /// </summary>
    [DataContract]
    public partial class ProspectDetails :  IEquatable<ProspectDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProspectDetails" /> class.
        /// </summary>
        /// <param name="Comments">Comments.</param>
        /// <param name="Company">Company.</param>
        /// <param name="CreationDate">CreationDate.</param>
        /// <param name="Email">Email.</param>
        /// <param name="EmployeeID">EmployeeID.</param>
        /// <param name="ID">ID.</param>
        /// <param name="IsPublic">IsPublic.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Phone">Phone.</param>
        /// <param name="PhoneExt">PhoneExt.</param>
        public ProspectDetails(string Comments = default(string), string Company = default(string), DateTime? CreationDate = default(DateTime?), string Email = default(string), Guid? EmployeeID = default(Guid?), Guid? ID = default(Guid?), bool? IsPublic = default(bool?), string Name = default(string), string Phone = default(string), string PhoneExt = default(string))
        {
            this.Comments = Comments;
            this.Company = Company;
            this.CreationDate = CreationDate;
            this.Email = Email;
            this.EmployeeID = EmployeeID;
            this.ID = ID;
            this.IsPublic = IsPublic;
            this.Name = Name;
            this.Phone = Phone;
            this.PhoneExt = PhoneExt;
        }
        
        /// <summary>
        /// Gets or Sets Comments
        /// </summary>
        [DataMember(Name="Comments", EmitDefaultValue=false)]
        public string Comments { get; set; }

        /// <summary>
        /// Gets or Sets Company
        /// </summary>
        [DataMember(Name="Company", EmitDefaultValue=false)]
        public string Company { get; set; }

        /// <summary>
        /// Gets or Sets CreationDate
        /// </summary>
        [DataMember(Name="CreationDate", EmitDefaultValue=false)]
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="Email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets EmployeeID
        /// </summary>
        [DataMember(Name="EmployeeID", EmitDefaultValue=false)]
        public Guid? EmployeeID { get; set; }

        /// <summary>
        /// Gets or Sets ID
        /// </summary>
        [DataMember(Name="ID", EmitDefaultValue=false)]
        public Guid? ID { get; set; }

        /// <summary>
        /// Gets or Sets IsPublic
        /// </summary>
        [DataMember(Name="IsPublic", EmitDefaultValue=false)]
        public bool? IsPublic { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Phone
        /// </summary>
        [DataMember(Name="Phone", EmitDefaultValue=false)]
        public string Phone { get; set; }

        /// <summary>
        /// Gets or Sets PhoneExt
        /// </summary>
        [DataMember(Name="PhoneExt", EmitDefaultValue=false)]
        public string PhoneExt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProspectDetails {\n");
            sb.Append("  Comments: ").Append(Comments).Append("\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  EmployeeID: ").Append(EmployeeID).Append("\n");
            sb.Append("  ID: ").Append(ID).Append("\n");
            sb.Append("  IsPublic: ").Append(IsPublic).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  PhoneExt: ").Append(PhoneExt).Append("\n");
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
            return this.Equals(input as ProspectDetails);
        }

        /// <summary>
        /// Returns true if ProspectDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of ProspectDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProspectDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Comments == input.Comments ||
                    (this.Comments != null &&
                    this.Comments.Equals(input.Comments))
                ) && 
                (
                    this.Company == input.Company ||
                    (this.Company != null &&
                    this.Company.Equals(input.Company))
                ) && 
                (
                    this.CreationDate == input.CreationDate ||
                    (this.CreationDate != null &&
                    this.CreationDate.Equals(input.CreationDate))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.EmployeeID == input.EmployeeID ||
                    (this.EmployeeID != null &&
                    this.EmployeeID.Equals(input.EmployeeID))
                ) && 
                (
                    this.ID == input.ID ||
                    (this.ID != null &&
                    this.ID.Equals(input.ID))
                ) && 
                (
                    this.IsPublic == input.IsPublic ||
                    (this.IsPublic != null &&
                    this.IsPublic.Equals(input.IsPublic))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Phone == input.Phone ||
                    (this.Phone != null &&
                    this.Phone.Equals(input.Phone))
                ) && 
                (
                    this.PhoneExt == input.PhoneExt ||
                    (this.PhoneExt != null &&
                    this.PhoneExt.Equals(input.PhoneExt))
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
                if (this.Comments != null)
                    hashCode = hashCode * 59 + this.Comments.GetHashCode();
                if (this.Company != null)
                    hashCode = hashCode * 59 + this.Company.GetHashCode();
                if (this.CreationDate != null)
                    hashCode = hashCode * 59 + this.CreationDate.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.EmployeeID != null)
                    hashCode = hashCode * 59 + this.EmployeeID.GetHashCode();
                if (this.ID != null)
                    hashCode = hashCode * 59 + this.ID.GetHashCode();
                if (this.IsPublic != null)
                    hashCode = hashCode * 59 + this.IsPublic.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Phone != null)
                    hashCode = hashCode * 59 + this.Phone.GetHashCode();
                if (this.PhoneExt != null)
                    hashCode = hashCode * 59 + this.PhoneExt.GetHashCode();
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