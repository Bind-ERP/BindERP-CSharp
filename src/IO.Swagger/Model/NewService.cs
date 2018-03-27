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
    /// NewService
    /// </summary>
    [DataContract]
    public partial class NewService :  IEquatable<NewService>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NewService" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NewService() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NewService" /> class.
        /// </summary>
        /// <param name="Code">Code (required).</param>
        /// <param name="Title">Title (required).</param>
        /// <param name="CurrencyID">CurrencyID (required).</param>
        /// <param name="SATCompanyAccountID">SATCompanyAccountID (required).</param>
        /// <param name="MeasurementUnit">MeasurementUnit (required).</param>
        /// <param name="Description">Description.</param>
        /// <param name="Category1ID">Category1ID.</param>
        /// <param name="Category2ID">Category2ID.</param>
        /// <param name="Category3ID">Category3ID.</param>
        /// <param name="VariableConcept">VariableConcept.</param>
        /// <param name="ChargeVAT">ChargeVAT.</param>
        public NewService(string Code = default(string), string Title = default(string), Guid? CurrencyID = default(Guid?), Guid? SATCompanyAccountID = default(Guid?), string MeasurementUnit = default(string), string Description = default(string), Guid? Category1ID = default(Guid?), Guid? Category2ID = default(Guid?), Guid? Category3ID = default(Guid?), bool? VariableConcept = default(bool?), bool? ChargeVAT = default(bool?))
        {
            // to ensure "Code" is required (not null)
            if (Code == null)
            {
                throw new InvalidDataException("Code is a required property for NewService and cannot be null");
            }
            else
            {
                this.Code = Code;
            }
            // to ensure "Title" is required (not null)
            if (Title == null)
            {
                throw new InvalidDataException("Title is a required property for NewService and cannot be null");
            }
            else
            {
                this.Title = Title;
            }
            // to ensure "CurrencyID" is required (not null)
            if (CurrencyID == null)
            {
                throw new InvalidDataException("CurrencyID is a required property for NewService and cannot be null");
            }
            else
            {
                this.CurrencyID = CurrencyID;
            }
            // to ensure "SATCompanyAccountID" is required (not null)
            if (SATCompanyAccountID == null)
            {
                throw new InvalidDataException("SATCompanyAccountID is a required property for NewService and cannot be null");
            }
            else
            {
                this.SATCompanyAccountID = SATCompanyAccountID;
            }
            // to ensure "MeasurementUnit" is required (not null)
            if (MeasurementUnit == null)
            {
                throw new InvalidDataException("MeasurementUnit is a required property for NewService and cannot be null");
            }
            else
            {
                this.MeasurementUnit = MeasurementUnit;
            }
            this.Description = Description;
            this.Category1ID = Category1ID;
            this.Category2ID = Category2ID;
            this.Category3ID = Category3ID;
            this.VariableConcept = VariableConcept;
            this.ChargeVAT = ChargeVAT;
        }
        
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
        /// Gets or Sets CurrencyID
        /// </summary>
        [DataMember(Name="CurrencyID", EmitDefaultValue=false)]
        public Guid? CurrencyID { get; set; }

        /// <summary>
        /// Gets or Sets SATCompanyAccountID
        /// </summary>
        [DataMember(Name="SATCompanyAccountID", EmitDefaultValue=false)]
        public Guid? SATCompanyAccountID { get; set; }

        /// <summary>
        /// Gets or Sets MeasurementUnit
        /// </summary>
        [DataMember(Name="MeasurementUnit", EmitDefaultValue=false)]
        public string MeasurementUnit { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public string Description { get; set; }

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
        /// Gets or Sets VariableConcept
        /// </summary>
        [DataMember(Name="VariableConcept", EmitDefaultValue=false)]
        public bool? VariableConcept { get; set; }

        /// <summary>
        /// Gets or Sets ChargeVAT
        /// </summary>
        [DataMember(Name="ChargeVAT", EmitDefaultValue=false)]
        public bool? ChargeVAT { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NewService {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  CurrencyID: ").Append(CurrencyID).Append("\n");
            sb.Append("  SATCompanyAccountID: ").Append(SATCompanyAccountID).Append("\n");
            sb.Append("  MeasurementUnit: ").Append(MeasurementUnit).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Category1ID: ").Append(Category1ID).Append("\n");
            sb.Append("  Category2ID: ").Append(Category2ID).Append("\n");
            sb.Append("  Category3ID: ").Append(Category3ID).Append("\n");
            sb.Append("  VariableConcept: ").Append(VariableConcept).Append("\n");
            sb.Append("  ChargeVAT: ").Append(ChargeVAT).Append("\n");
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
            return this.Equals(input as NewService);
        }

        /// <summary>
        /// Returns true if NewService instances are equal
        /// </summary>
        /// <param name="input">Instance of NewService to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NewService input)
        {
            if (input == null)
                return false;

            return 
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
                    this.CurrencyID == input.CurrencyID ||
                    (this.CurrencyID != null &&
                    this.CurrencyID.Equals(input.CurrencyID))
                ) && 
                (
                    this.SATCompanyAccountID == input.SATCompanyAccountID ||
                    (this.SATCompanyAccountID != null &&
                    this.SATCompanyAccountID.Equals(input.SATCompanyAccountID))
                ) && 
                (
                    this.MeasurementUnit == input.MeasurementUnit ||
                    (this.MeasurementUnit != null &&
                    this.MeasurementUnit.Equals(input.MeasurementUnit))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                    this.VariableConcept == input.VariableConcept ||
                    (this.VariableConcept != null &&
                    this.VariableConcept.Equals(input.VariableConcept))
                ) && 
                (
                    this.ChargeVAT == input.ChargeVAT ||
                    (this.ChargeVAT != null &&
                    this.ChargeVAT.Equals(input.ChargeVAT))
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
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.CurrencyID != null)
                    hashCode = hashCode * 59 + this.CurrencyID.GetHashCode();
                if (this.SATCompanyAccountID != null)
                    hashCode = hashCode * 59 + this.SATCompanyAccountID.GetHashCode();
                if (this.MeasurementUnit != null)
                    hashCode = hashCode * 59 + this.MeasurementUnit.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Category1ID != null)
                    hashCode = hashCode * 59 + this.Category1ID.GetHashCode();
                if (this.Category2ID != null)
                    hashCode = hashCode * 59 + this.Category2ID.GetHashCode();
                if (this.Category3ID != null)
                    hashCode = hashCode * 59 + this.Category3ID.GetHashCode();
                if (this.VariableConcept != null)
                    hashCode = hashCode * 59 + this.VariableConcept.GetHashCode();
                if (this.ChargeVAT != null)
                    hashCode = hashCode * 59 + this.ChargeVAT.GetHashCode();
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
