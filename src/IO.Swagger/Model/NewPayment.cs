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
    /// NewPayment
    /// </summary>
    [DataContract]
    public partial class NewPayment :  IEquatable<NewPayment>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NewPayment" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NewPayment() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NewPayment" /> class.
        /// </summary>
        /// <param name="InvoiceID">InvoiceID (required).</param>
        /// <param name="AccountID">AccountID (required).</param>
        /// <param name="Date">Date (required).</param>
        /// <param name="Reference">Reference (required).</param>
        /// <param name="Amount">Amount (required).</param>
        /// <param name="PaymentTerm">PaymentTerm (required).</param>
        /// <param name="Comments">Comments.</param>
        /// <param name="ExchangeRate">ExchangeRate.</param>
        /// <param name="ExchangeRateAccount">ExchangeRateAccount.</param>
        public NewPayment(Guid? InvoiceID = default(Guid?), Guid? AccountID = default(Guid?), DateTime? Date = default(DateTime?), string Reference = default(string), double? Amount = default(double?), int? PaymentTerm = default(int?), string Comments = default(string), double? ExchangeRate = default(double?), double? ExchangeRateAccount = default(double?))
        {
            // to ensure "InvoiceID" is required (not null)
            if (InvoiceID == null)
            {
                throw new InvalidDataException("InvoiceID is a required property for NewPayment and cannot be null");
            }
            else
            {
                this.InvoiceID = InvoiceID;
            }
            // to ensure "AccountID" is required (not null)
            if (AccountID == null)
            {
                throw new InvalidDataException("AccountID is a required property for NewPayment and cannot be null");
            }
            else
            {
                this.AccountID = AccountID;
            }
            // to ensure "Date" is required (not null)
            if (Date == null)
            {
                throw new InvalidDataException("Date is a required property for NewPayment and cannot be null");
            }
            else
            {
                this.Date = Date;
            }
            // to ensure "Reference" is required (not null)
            if (Reference == null)
            {
                throw new InvalidDataException("Reference is a required property for NewPayment and cannot be null");
            }
            else
            {
                this.Reference = Reference;
            }
            // to ensure "Amount" is required (not null)
            if (Amount == null)
            {
                throw new InvalidDataException("Amount is a required property for NewPayment and cannot be null");
            }
            else
            {
                this.Amount = Amount;
            }
            // to ensure "PaymentTerm" is required (not null)
            if (PaymentTerm == null)
            {
                throw new InvalidDataException("PaymentTerm is a required property for NewPayment and cannot be null");
            }
            else
            {
                this.PaymentTerm = PaymentTerm;
            }
            this.Comments = Comments;
            this.ExchangeRate = ExchangeRate;
            this.ExchangeRateAccount = ExchangeRateAccount;
        }
        
        /// <summary>
        /// Gets or Sets InvoiceID
        /// </summary>
        [DataMember(Name="InvoiceID", EmitDefaultValue=false)]
        public Guid? InvoiceID { get; set; }

        /// <summary>
        /// Gets or Sets AccountID
        /// </summary>
        [DataMember(Name="AccountID", EmitDefaultValue=false)]
        public Guid? AccountID { get; set; }

        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        [DataMember(Name="Date", EmitDefaultValue=false)]
        public DateTime? Date { get; set; }

        /// <summary>
        /// Gets or Sets Reference
        /// </summary>
        [DataMember(Name="Reference", EmitDefaultValue=false)]
        public string Reference { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name="Amount", EmitDefaultValue=false)]
        public double? Amount { get; set; }

        /// <summary>
        /// Gets or Sets PaymentTerm
        /// </summary>
        [DataMember(Name="PaymentTerm", EmitDefaultValue=false)]
        public int? PaymentTerm { get; set; }

        /// <summary>
        /// Gets or Sets Comments
        /// </summary>
        [DataMember(Name="Comments", EmitDefaultValue=false)]
        public string Comments { get; set; }

        /// <summary>
        /// Gets or Sets ExchangeRate
        /// </summary>
        [DataMember(Name="ExchangeRate", EmitDefaultValue=false)]
        public double? ExchangeRate { get; set; }

        /// <summary>
        /// Gets or Sets ExchangeRateAccount
        /// </summary>
        [DataMember(Name="ExchangeRateAccount", EmitDefaultValue=false)]
        public double? ExchangeRateAccount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NewPayment {\n");
            sb.Append("  InvoiceID: ").Append(InvoiceID).Append("\n");
            sb.Append("  AccountID: ").Append(AccountID).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  PaymentTerm: ").Append(PaymentTerm).Append("\n");
            sb.Append("  Comments: ").Append(Comments).Append("\n");
            sb.Append("  ExchangeRate: ").Append(ExchangeRate).Append("\n");
            sb.Append("  ExchangeRateAccount: ").Append(ExchangeRateAccount).Append("\n");
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
            return this.Equals(input as NewPayment);
        }

        /// <summary>
        /// Returns true if NewPayment instances are equal
        /// </summary>
        /// <param name="input">Instance of NewPayment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NewPayment input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InvoiceID == input.InvoiceID ||
                    (this.InvoiceID != null &&
                    this.InvoiceID.Equals(input.InvoiceID))
                ) && 
                (
                    this.AccountID == input.AccountID ||
                    (this.AccountID != null &&
                    this.AccountID.Equals(input.AccountID))
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.PaymentTerm == input.PaymentTerm ||
                    (this.PaymentTerm != null &&
                    this.PaymentTerm.Equals(input.PaymentTerm))
                ) && 
                (
                    this.Comments == input.Comments ||
                    (this.Comments != null &&
                    this.Comments.Equals(input.Comments))
                ) && 
                (
                    this.ExchangeRate == input.ExchangeRate ||
                    (this.ExchangeRate != null &&
                    this.ExchangeRate.Equals(input.ExchangeRate))
                ) && 
                (
                    this.ExchangeRateAccount == input.ExchangeRateAccount ||
                    (this.ExchangeRateAccount != null &&
                    this.ExchangeRateAccount.Equals(input.ExchangeRateAccount))
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
                if (this.InvoiceID != null)
                    hashCode = hashCode * 59 + this.InvoiceID.GetHashCode();
                if (this.AccountID != null)
                    hashCode = hashCode * 59 + this.AccountID.GetHashCode();
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.Reference != null)
                    hashCode = hashCode * 59 + this.Reference.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.PaymentTerm != null)
                    hashCode = hashCode * 59 + this.PaymentTerm.GetHashCode();
                if (this.Comments != null)
                    hashCode = hashCode * 59 + this.Comments.GetHashCode();
                if (this.ExchangeRate != null)
                    hashCode = hashCode * 59 + this.ExchangeRate.GetHashCode();
                if (this.ExchangeRateAccount != null)
                    hashCode = hashCode * 59 + this.ExchangeRateAccount.GetHashCode();
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
