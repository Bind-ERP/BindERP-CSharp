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
    /// Service
    /// </summary>
    [DataContract]
    public partial class Service :  IEquatable<Service>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Service" /> class.
        /// </summary>
        /// <param name="ID">ID.</param>
        /// <param name="Code">Code.</param>
        /// <param name="Title">Title.</param>
        /// <param name="Description">Description.</param>
        /// <param name="CreationDate">CreationDate.</param>
        /// <param name="Category1ID">Category1ID.</param>
        /// <param name="Category2ID">Category2ID.</param>
        /// <param name="Category3ID">Category3ID.</param>
        /// <param name="ChargeVAT">ChargeVAT.</param>
        /// <param name="PricingType">PricingType.</param>
        /// <param name="Unit">Unit.</param>
        /// <param name="CurrencyID">CurrencyID.</param>
        /// <param name="CurrencyCode">CurrencyCode.</param>
        /// <param name="VariableConcept">VariableConcept.</param>
        /// <param name="SATCode">SATCode.</param>
        /// <param name="SATUnit">SATUnit.</param>
        public Service(Guid? ID = default(Guid?), string Code = default(string), string Title = default(string), string Description = default(string), DateTime? CreationDate = default(DateTime?), Guid? Category1ID = default(Guid?), Guid? Category2ID = default(Guid?), Guid? Category3ID = default(Guid?), bool? ChargeVAT = default(bool?), int? PricingType = default(int?), string Unit = default(string), Guid? CurrencyID = default(Guid?), string CurrencyCode = default(string), bool? VariableConcept = default(bool?), int? SATCode = default(int?), int? SATUnit = default(int?))
        {
            this.ID = ID;
            this.Code = Code;
            this.Title = Title;
            this.Description = Description;
            this.CreationDate = CreationDate;
            this.Category1ID = Category1ID;
            this.Category2ID = Category2ID;
            this.Category3ID = Category3ID;
            this.ChargeVAT = ChargeVAT;
            this.PricingType = PricingType;
            this.Unit = Unit;
            this.CurrencyID = CurrencyID;
            this.CurrencyCode = CurrencyCode;
            this.VariableConcept = VariableConcept;
            this.SATCode = SATCode;
            this.SATUnit = SATUnit;
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
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="Title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets CreationDate
        /// </summary>
        [DataMember(Name="CreationDate", EmitDefaultValue=false)]
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Gets or Sets Category1ID
        /// </summary>
        [DataMember(Name="Category1ID", EmitDefaultValue=false)]
        public Guid? Category1ID { get; set; }

        /// <summary>
        /// Gets or Sets Category2ID
        /// </summary>
        [DataMember(Name="Category2ID", EmitDefaultValue=false)]
        public Guid? Category2ID { get; set; }

        /// <summary>
        /// Gets or Sets Category3ID
        /// </summary>
        [DataMember(Name="Category3ID", EmitDefaultValue=false)]
        public Guid? Category3ID { get; set; }

        /// <summary>
        /// Gets or Sets ChargeVAT
        /// </summary>
        [DataMember(Name="ChargeVAT", EmitDefaultValue=false)]
        public bool? ChargeVAT { get; set; }

        /// <summary>
        /// Gets or Sets PricingType
        /// </summary>
        [DataMember(Name="PricingType", EmitDefaultValue=false)]
        public int? PricingType { get; set; }

        /// <summary>
        /// Gets or Sets PricingTypeText
        /// </summary>
        [DataMember(Name="PricingTypeText", EmitDefaultValue=false)]
        public string PricingTypeText { get; private set; }

        /// <summary>
        /// Gets or Sets Unit
        /// </summary>
        [DataMember(Name="Unit", EmitDefaultValue=false)]
        public string Unit { get; set; }

        /// <summary>
        /// Gets or Sets CurrencyID
        /// </summary>
        [DataMember(Name="CurrencyID", EmitDefaultValue=false)]
        public Guid? CurrencyID { get; set; }

        /// <summary>
        /// Gets or Sets CurrencyCode
        /// </summary>
        [DataMember(Name="CurrencyCode", EmitDefaultValue=false)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Gets or Sets VariableConcept
        /// </summary>
        [DataMember(Name="VariableConcept", EmitDefaultValue=false)]
        public bool? VariableConcept { get; set; }

        /// <summary>
        /// Gets or Sets SATCode
        /// </summary>
        [DataMember(Name="SATCode", EmitDefaultValue=false)]
        public int? SATCode { get; set; }

        /// <summary>
        /// Gets or Sets SATUnit
        /// </summary>
        [DataMember(Name="SATUnit", EmitDefaultValue=false)]
        public int? SATUnit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Service {\n");
            sb.Append("  ID: ").Append(ID).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
            sb.Append("  Category1ID: ").Append(Category1ID).Append("\n");
            sb.Append("  Category2ID: ").Append(Category2ID).Append("\n");
            sb.Append("  Category3ID: ").Append(Category3ID).Append("\n");
            sb.Append("  ChargeVAT: ").Append(ChargeVAT).Append("\n");
            sb.Append("  PricingType: ").Append(PricingType).Append("\n");
            sb.Append("  PricingTypeText: ").Append(PricingTypeText).Append("\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
            sb.Append("  CurrencyID: ").Append(CurrencyID).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  VariableConcept: ").Append(VariableConcept).Append("\n");
            sb.Append("  SATCode: ").Append(SATCode).Append("\n");
            sb.Append("  SATUnit: ").Append(SATUnit).Append("\n");
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
            return this.Equals(input as Service);
        }

        /// <summary>
        /// Returns true if Service instances are equal
        /// </summary>
        /// <param name="input">Instance of Service to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Service input)
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
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.CreationDate == input.CreationDate ||
                    (this.CreationDate != null &&
                    this.CreationDate.Equals(input.CreationDate))
                ) && 
                (
                    this.Category1ID == input.Category1ID ||
                    (this.Category1ID != null &&
                    this.Category1ID.Equals(input.Category1ID))
                ) && 
                (
                    this.Category2ID == input.Category2ID ||
                    (this.Category2ID != null &&
                    this.Category2ID.Equals(input.Category2ID))
                ) && 
                (
                    this.Category3ID == input.Category3ID ||
                    (this.Category3ID != null &&
                    this.Category3ID.Equals(input.Category3ID))
                ) && 
                (
                    this.ChargeVAT == input.ChargeVAT ||
                    (this.ChargeVAT != null &&
                    this.ChargeVAT.Equals(input.ChargeVAT))
                ) && 
                (
                    this.PricingType == input.PricingType ||
                    (this.PricingType != null &&
                    this.PricingType.Equals(input.PricingType))
                ) && 
                (
                    this.PricingTypeText == input.PricingTypeText ||
                    (this.PricingTypeText != null &&
                    this.PricingTypeText.Equals(input.PricingTypeText))
                ) && 
                (
                    this.Unit == input.Unit ||
                    (this.Unit != null &&
                    this.Unit.Equals(input.Unit))
                ) && 
                (
                    this.CurrencyID == input.CurrencyID ||
                    (this.CurrencyID != null &&
                    this.CurrencyID.Equals(input.CurrencyID))
                ) && 
                (
                    this.CurrencyCode == input.CurrencyCode ||
                    (this.CurrencyCode != null &&
                    this.CurrencyCode.Equals(input.CurrencyCode))
                ) && 
                (
                    this.VariableConcept == input.VariableConcept ||
                    (this.VariableConcept != null &&
                    this.VariableConcept.Equals(input.VariableConcept))
                ) && 
                (
                    this.SATCode == input.SATCode ||
                    (this.SATCode != null &&
                    this.SATCode.Equals(input.SATCode))
                ) && 
                (
                    this.SATUnit == input.SATUnit ||
                    (this.SATUnit != null &&
                    this.SATUnit.Equals(input.SATUnit))
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
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.CreationDate != null)
                    hashCode = hashCode * 59 + this.CreationDate.GetHashCode();
                if (this.Category1ID != null)
                    hashCode = hashCode * 59 + this.Category1ID.GetHashCode();
                if (this.Category2ID != null)
                    hashCode = hashCode * 59 + this.Category2ID.GetHashCode();
                if (this.Category3ID != null)
                    hashCode = hashCode * 59 + this.Category3ID.GetHashCode();
                if (this.ChargeVAT != null)
                    hashCode = hashCode * 59 + this.ChargeVAT.GetHashCode();
                if (this.PricingType != null)
                    hashCode = hashCode * 59 + this.PricingType.GetHashCode();
                if (this.PricingTypeText != null)
                    hashCode = hashCode * 59 + this.PricingTypeText.GetHashCode();
                if (this.Unit != null)
                    hashCode = hashCode * 59 + this.Unit.GetHashCode();
                if (this.CurrencyID != null)
                    hashCode = hashCode * 59 + this.CurrencyID.GetHashCode();
                if (this.CurrencyCode != null)
                    hashCode = hashCode * 59 + this.CurrencyCode.GetHashCode();
                if (this.VariableConcept != null)
                    hashCode = hashCode * 59 + this.VariableConcept.GetHashCode();
                if (this.SATCode != null)
                    hashCode = hashCode * 59 + this.SATCode.GetHashCode();
                if (this.SATUnit != null)
                    hashCode = hashCode * 59 + this.SATUnit.GetHashCode();
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
