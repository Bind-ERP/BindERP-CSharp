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
    /// EditAccountingJournalItem
    /// </summary>
    [DataContract]
    public partial class EditAccountingJournalItem :  IEquatable<EditAccountingJournalItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EditAccountingJournalItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EditAccountingJournalItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EditAccountingJournalItem" /> class.
        /// </summary>
        /// <param name="SATCompanyAccountID">SATCompanyAccountID (required).</param>
        /// <param name="Cargo">Cargo (required).</param>
        /// <param name="Abono">Abono (required).</param>
        /// <param name="Comments">Comments.</param>
        public EditAccountingJournalItem(Guid? SATCompanyAccountID = default(Guid?), double? Cargo = default(double?), double? Abono = default(double?), string Comments = default(string))
        {
            // to ensure "SATCompanyAccountID" is required (not null)
            if (SATCompanyAccountID == null)
            {
                throw new InvalidDataException("SATCompanyAccountID is a required property for EditAccountingJournalItem and cannot be null");
            }
            else
            {
                this.SATCompanyAccountID = SATCompanyAccountID;
            }
            // to ensure "Cargo" is required (not null)
            if (Cargo == null)
            {
                throw new InvalidDataException("Cargo is a required property for EditAccountingJournalItem and cannot be null");
            }
            else
            {
                this.Cargo = Cargo;
            }
            // to ensure "Abono" is required (not null)
            if (Abono == null)
            {
                throw new InvalidDataException("Abono is a required property for EditAccountingJournalItem and cannot be null");
            }
            else
            {
                this.Abono = Abono;
            }
            this.Comments = Comments;
        }
        
        /// <summary>
        /// Gets or Sets SATCompanyAccountID
        /// </summary>
        [DataMember(Name="SATCompanyAccountID", EmitDefaultValue=false)]
        public Guid? SATCompanyAccountID { get; set; }

        /// <summary>
        /// Gets or Sets Cargo
        /// </summary>
        [DataMember(Name="Cargo", EmitDefaultValue=false)]
        public double? Cargo { get; set; }

        /// <summary>
        /// Gets or Sets Abono
        /// </summary>
        [DataMember(Name="Abono", EmitDefaultValue=false)]
        public double? Abono { get; set; }

        /// <summary>
        /// Gets or Sets Comments
        /// </summary>
        [DataMember(Name="Comments", EmitDefaultValue=false)]
        public string Comments { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EditAccountingJournalItem {\n");
            sb.Append("  SATCompanyAccountID: ").Append(SATCompanyAccountID).Append("\n");
            sb.Append("  Cargo: ").Append(Cargo).Append("\n");
            sb.Append("  Abono: ").Append(Abono).Append("\n");
            sb.Append("  Comments: ").Append(Comments).Append("\n");
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
            return this.Equals(input as EditAccountingJournalItem);
        }

        /// <summary>
        /// Returns true if EditAccountingJournalItem instances are equal
        /// </summary>
        /// <param name="input">Instance of EditAccountingJournalItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EditAccountingJournalItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SATCompanyAccountID == input.SATCompanyAccountID ||
                    (this.SATCompanyAccountID != null &&
                    this.SATCompanyAccountID.Equals(input.SATCompanyAccountID))
                ) && 
                (
                    this.Cargo == input.Cargo ||
                    (this.Cargo != null &&
                    this.Cargo.Equals(input.Cargo))
                ) && 
                (
                    this.Abono == input.Abono ||
                    (this.Abono != null &&
                    this.Abono.Equals(input.Abono))
                ) && 
                (
                    this.Comments == input.Comments ||
                    (this.Comments != null &&
                    this.Comments.Equals(input.Comments))
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
                if (this.SATCompanyAccountID != null)
                    hashCode = hashCode * 59 + this.SATCompanyAccountID.GetHashCode();
                if (this.Cargo != null)
                    hashCode = hashCode * 59 + this.Cargo.GetHashCode();
                if (this.Abono != null)
                    hashCode = hashCode * 59 + this.Abono.GetHashCode();
                if (this.Comments != null)
                    hashCode = hashCode * 59 + this.Comments.GetHashCode();
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
            // Cargo (double?) minimum
            if(this.Cargo < (double?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Cargo, must be a value greater than or equal to 0.", new [] { "Cargo" });
            }

            // Abono (double?) minimum
            if(this.Abono < (double?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Abono, must be a value greater than or equal to 0.", new [] { "Abono" });
            }

            yield break;
        }
    }

}