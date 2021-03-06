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
    /// NewCreditNote
    /// </summary>
    [DataContract]
    public partial class NewCreditNote :  IEquatable<NewCreditNote>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NewCreditNote" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NewCreditNote() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NewCreditNote" /> class.
        /// </summary>
        /// <param name="Amount">Amount (required).</param>
        /// <param name="BankAccount">BankAccount.</param>
        /// <param name="Comments">Comments.</param>
        /// <param name="Concept">Concept.</param>
        /// <param name="Unit">Unit.</param>
        /// <param name="CreditNotesItems">CreditNotesItems.</param>
        /// <param name="IEPSAmount">IEPSAmount.</param>
        /// <param name="InvoiceID">InvoiceID (required).</param>
        /// <param name="ISRRet">ISRRet.</param>
        /// <param name="PaymentMethod">PaymentMethod (required).</param>
        /// <param name="PaymentTerms">PaymentTerms (required).</param>
        /// <param name="SeriesID">SeriesID.</param>
        /// <param name="Type">Type (required).</param>
        /// <param name="VAT">VAT.</param>
        /// <param name="VATRet">VATRet.</param>
        public NewCreditNote(double? Amount = default(double?), string BankAccount = default(string), string Comments = default(string), string Concept = default(string), string Unit = default(string), List<NewCreditNotesItem> CreditNotesItems = default(List<NewCreditNotesItem>), double? IEPSAmount = default(double?), Guid? InvoiceID = default(Guid?), double? ISRRet = default(double?), int? PaymentMethod = default(int?), int? PaymentTerms = default(int?), Guid? SeriesID = default(Guid?), int? Type = default(int?), double? VAT = default(double?), double? VATRet = default(double?))
        {
            // to ensure "Amount" is required (not null)
            if (Amount == null)
            {
                throw new InvalidDataException("Amount is a required property for NewCreditNote and cannot be null");
            }
            else
            {
                this.Amount = Amount;
            }
            // to ensure "InvoiceID" is required (not null)
            if (InvoiceID == null)
            {
                throw new InvalidDataException("InvoiceID is a required property for NewCreditNote and cannot be null");
            }
            else
            {
                this.InvoiceID = InvoiceID;
            }
            // to ensure "PaymentMethod" is required (not null)
            if (PaymentMethod == null)
            {
                throw new InvalidDataException("PaymentMethod is a required property for NewCreditNote and cannot be null");
            }
            else
            {
                this.PaymentMethod = PaymentMethod;
            }
            // to ensure "PaymentTerms" is required (not null)
            if (PaymentTerms == null)
            {
                throw new InvalidDataException("PaymentTerms is a required property for NewCreditNote and cannot be null");
            }
            else
            {
                this.PaymentTerms = PaymentTerms;
            }
            // to ensure "Type" is required (not null)
            if (Type == null)
            {
                throw new InvalidDataException("Type is a required property for NewCreditNote and cannot be null");
            }
            else
            {
                this.Type = Type;
            }
            this.BankAccount = BankAccount;
            this.Comments = Comments;
            this.Concept = Concept;
            this.Unit = Unit;
            this.CreditNotesItems = CreditNotesItems;
            this.IEPSAmount = IEPSAmount;
            this.ISRRet = ISRRet;
            this.SeriesID = SeriesID;
            this.VAT = VAT;
            this.VATRet = VATRet;
        }
        
        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name="Amount", EmitDefaultValue=false)]
        public double? Amount { get; set; }

        /// <summary>
        /// Gets or Sets BankAccount
        /// </summary>
        [DataMember(Name="BankAccount", EmitDefaultValue=false)]
        public string BankAccount { get; set; }

        /// <summary>
        /// Gets or Sets Comments
        /// </summary>
        [DataMember(Name="Comments", EmitDefaultValue=false)]
        public string Comments { get; set; }

        /// <summary>
        /// Gets or Sets Concept
        /// </summary>
        [DataMember(Name="Concept", EmitDefaultValue=false)]
        public string Concept { get; set; }

        /// <summary>
        /// Gets or Sets Unit
        /// </summary>
        [DataMember(Name="Unit", EmitDefaultValue=false)]
        public string Unit { get; set; }

        /// <summary>
        /// Gets or Sets CreditNotesItems
        /// </summary>
        [DataMember(Name="CreditNotesItems", EmitDefaultValue=false)]
        public List<NewCreditNotesItem> CreditNotesItems { get; set; }

        /// <summary>
        /// Gets or Sets IEPSAmount
        /// </summary>
        [DataMember(Name="IEPSAmount", EmitDefaultValue=false)]
        public double? IEPSAmount { get; set; }

        /// <summary>
        /// Gets or Sets InvoiceID
        /// </summary>
        [DataMember(Name="InvoiceID", EmitDefaultValue=false)]
        public Guid? InvoiceID { get; set; }

        /// <summary>
        /// Gets or Sets ISRRet
        /// </summary>
        [DataMember(Name="ISRRet", EmitDefaultValue=false)]
        public double? ISRRet { get; set; }

        /// <summary>
        /// Gets or Sets PaymentMethod
        /// </summary>
        [DataMember(Name="PaymentMethod", EmitDefaultValue=false)]
        public int? PaymentMethod { get; set; }

        /// <summary>
        /// Gets or Sets PaymentTerms
        /// </summary>
        [DataMember(Name="PaymentTerms", EmitDefaultValue=false)]
        public int? PaymentTerms { get; set; }

        /// <summary>
        /// Gets or Sets SeriesID
        /// </summary>
        [DataMember(Name="SeriesID", EmitDefaultValue=false)]
        public Guid? SeriesID { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="Type", EmitDefaultValue=false)]
        public int? Type { get; set; }

        /// <summary>
        /// Gets or Sets VAT
        /// </summary>
        [DataMember(Name="VAT", EmitDefaultValue=false)]
        public double? VAT { get; set; }

        /// <summary>
        /// Gets or Sets VATRet
        /// </summary>
        [DataMember(Name="VATRet", EmitDefaultValue=false)]
        public double? VATRet { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NewCreditNote {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  BankAccount: ").Append(BankAccount).Append("\n");
            sb.Append("  Comments: ").Append(Comments).Append("\n");
            sb.Append("  Concept: ").Append(Concept).Append("\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
            sb.Append("  CreditNotesItems: ").Append(CreditNotesItems).Append("\n");
            sb.Append("  IEPSAmount: ").Append(IEPSAmount).Append("\n");
            sb.Append("  InvoiceID: ").Append(InvoiceID).Append("\n");
            sb.Append("  ISRRet: ").Append(ISRRet).Append("\n");
            sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
            sb.Append("  PaymentTerms: ").Append(PaymentTerms).Append("\n");
            sb.Append("  SeriesID: ").Append(SeriesID).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  VAT: ").Append(VAT).Append("\n");
            sb.Append("  VATRet: ").Append(VATRet).Append("\n");
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
            return this.Equals(input as NewCreditNote);
        }

        /// <summary>
        /// Returns true if NewCreditNote instances are equal
        /// </summary>
        /// <param name="input">Instance of NewCreditNote to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NewCreditNote input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.BankAccount == input.BankAccount ||
                    (this.BankAccount != null &&
                    this.BankAccount.Equals(input.BankAccount))
                ) && 
                (
                    this.Comments == input.Comments ||
                    (this.Comments != null &&
                    this.Comments.Equals(input.Comments))
                ) && 
                (
                    this.Concept == input.Concept ||
                    (this.Concept != null &&
                    this.Concept.Equals(input.Concept))
                ) && 
                (
                    this.Unit == input.Unit ||
                    (this.Unit != null &&
                    this.Unit.Equals(input.Unit))
                ) && 
                (
                    this.CreditNotesItems == input.CreditNotesItems ||
                    this.CreditNotesItems != null &&
                    this.CreditNotesItems.SequenceEqual(input.CreditNotesItems)
                ) && 
                (
                    this.IEPSAmount == input.IEPSAmount ||
                    (this.IEPSAmount != null &&
                    this.IEPSAmount.Equals(input.IEPSAmount))
                ) && 
                (
                    this.InvoiceID == input.InvoiceID ||
                    (this.InvoiceID != null &&
                    this.InvoiceID.Equals(input.InvoiceID))
                ) && 
                (
                    this.ISRRet == input.ISRRet ||
                    (this.ISRRet != null &&
                    this.ISRRet.Equals(input.ISRRet))
                ) && 
                (
                    this.PaymentMethod == input.PaymentMethod ||
                    (this.PaymentMethod != null &&
                    this.PaymentMethod.Equals(input.PaymentMethod))
                ) && 
                (
                    this.PaymentTerms == input.PaymentTerms ||
                    (this.PaymentTerms != null &&
                    this.PaymentTerms.Equals(input.PaymentTerms))
                ) && 
                (
                    this.SeriesID == input.SeriesID ||
                    (this.SeriesID != null &&
                    this.SeriesID.Equals(input.SeriesID))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.VAT == input.VAT ||
                    (this.VAT != null &&
                    this.VAT.Equals(input.VAT))
                ) && 
                (
                    this.VATRet == input.VATRet ||
                    (this.VATRet != null &&
                    this.VATRet.Equals(input.VATRet))
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
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.BankAccount != null)
                    hashCode = hashCode * 59 + this.BankAccount.GetHashCode();
                if (this.Comments != null)
                    hashCode = hashCode * 59 + this.Comments.GetHashCode();
                if (this.Concept != null)
                    hashCode = hashCode * 59 + this.Concept.GetHashCode();
                if (this.Unit != null)
                    hashCode = hashCode * 59 + this.Unit.GetHashCode();
                if (this.CreditNotesItems != null)
                    hashCode = hashCode * 59 + this.CreditNotesItems.GetHashCode();
                if (this.IEPSAmount != null)
                    hashCode = hashCode * 59 + this.IEPSAmount.GetHashCode();
                if (this.InvoiceID != null)
                    hashCode = hashCode * 59 + this.InvoiceID.GetHashCode();
                if (this.ISRRet != null)
                    hashCode = hashCode * 59 + this.ISRRet.GetHashCode();
                if (this.PaymentMethod != null)
                    hashCode = hashCode * 59 + this.PaymentMethod.GetHashCode();
                if (this.PaymentTerms != null)
                    hashCode = hashCode * 59 + this.PaymentTerms.GetHashCode();
                if (this.SeriesID != null)
                    hashCode = hashCode * 59 + this.SeriesID.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.VAT != null)
                    hashCode = hashCode * 59 + this.VAT.GetHashCode();
                if (this.VATRet != null)
                    hashCode = hashCode * 59 + this.VATRet.GetHashCode();
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
