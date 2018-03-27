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
    /// NewInvoicePayment
    /// </summary>
    [DataContract]
    public partial class NewInvoicePayment :  IEquatable<NewInvoicePayment>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NewInvoicePayment" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NewInvoicePayment() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NewInvoicePayment" /> class.
        /// </summary>
        /// <param name="PaymentMethod">PaymentMethod (required).</param>
        /// <param name="AccountID">AccountID (required).</param>
        /// <param name="Amount">Amount (required).</param>
        /// <param name="ExchangeRate">ExchangeRate.</param>
        /// <param name="ExchangeRateAccount">ExchangeRateAccount.</param>
        /// <param name="Reference">Reference (required).</param>
        public NewInvoicePayment(int? PaymentMethod = default(int?), Guid? AccountID = default(Guid?), double? Amount = default(double?), double? ExchangeRate = default(double?), double? ExchangeRateAccount = default(double?), string Reference = default(string))
        {
            // to ensure "PaymentMethod" is required (not null)
            if (PaymentMethod == null)
            {
                throw new InvalidDataException("PaymentMethod is a required property for NewInvoicePayment and cannot be null");
            }
            else
            {
                this.PaymentMethod = PaymentMethod;
            }
            // to ensure "AccountID" is required (not null)
            if (AccountID == null)
            {
                throw new InvalidDataException("AccountID is a required property for NewInvoicePayment and cannot be null");
            }
            else
            {
                this.AccountID = AccountID;
            }
            // to ensure "Amount" is required (not null)
            if (Amount == null)
            {
                throw new InvalidDataException("Amount is a required property for NewInvoicePayment and cannot be null");
            }
            else
            {
                this.Amount = Amount;
            }
            // to ensure "Reference" is required (not null)
            if (Reference == null)
            {
                throw new InvalidDataException("Reference is a required property for NewInvoicePayment and cannot be null");
            }
            else
            {
                this.Reference = Reference;
            }
            this.ExchangeRate = ExchangeRate;
            this.ExchangeRateAccount = ExchangeRateAccount;
        }
        
        /// <summary>
        /// Gets or Sets PaymentMethod
        /// </summary>
        [DataMember(Name="PaymentMethod", EmitDefaultValue=false)]
        public int? PaymentMethod { get; set; }

        /// <summary>
        /// Gets or Sets AccountID
        /// </summary>
        [DataMember(Name="AccountID", EmitDefaultValue=false)]
        public Guid? AccountID { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name="Amount", EmitDefaultValue=false)]
        public double? Amount { get; set; }

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
        /// Gets or Sets Reference
        /// </summary>
        [DataMember(Name="Reference", EmitDefaultValue=false)]
        public string Reference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NewInvoicePayment {\n");
            sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
            sb.Append("  AccountID: ").Append(AccountID).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  ExchangeRate: ").Append(ExchangeRate).Append("\n");
            sb.Append("  ExchangeRateAccount: ").Append(ExchangeRateAccount).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
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
            return this.Equals(input as NewInvoicePayment);
        }

        /// <summary>
        /// Returns true if NewInvoicePayment instances are equal
        /// </summary>
        /// <param name="input">Instance of NewInvoicePayment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NewInvoicePayment input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PaymentMethod == input.PaymentMethod ||
                    (this.PaymentMethod != null &&
                    this.PaymentMethod.Equals(input.PaymentMethod))
                ) && 
                (
                    this.AccountID == input.AccountID ||
                    (this.AccountID != null &&
                    this.AccountID.Equals(input.AccountID))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
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
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
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
                if (this.PaymentMethod != null)
                    hashCode = hashCode * 59 + this.PaymentMethod.GetHashCode();
                if (this.AccountID != null)
                    hashCode = hashCode * 59 + this.AccountID.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.ExchangeRate != null)
                    hashCode = hashCode * 59 + this.ExchangeRate.GetHashCode();
                if (this.ExchangeRateAccount != null)
                    hashCode = hashCode * 59 + this.ExchangeRateAccount.GetHashCode();
                if (this.Reference != null)
                    hashCode = hashCode * 59 + this.Reference.GetHashCode();
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