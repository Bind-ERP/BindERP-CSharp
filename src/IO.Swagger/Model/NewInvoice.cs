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
    /// NewInvoice
    /// </summary>
    [DataContract]
    public partial class NewInvoice :  IEquatable<NewInvoice>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NewInvoice" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NewInvoice() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NewInvoice" /> class.
        /// </summary>
        /// <param name="CurrencyID">CurrencyID (required).</param>
        /// <param name="ClientID">ClientID (required).</param>
        /// <param name="LocationID">LocationID (required).</param>
        /// <param name="WarehouseID">WarehouseID (required).</param>
        /// <param name="CFDIUse">CFDIUse (required).</param>
        /// <param name="InvoiceDate">InvoiceDate (required).</param>
        /// <param name="PriceListID">PriceListID (required).</param>
        /// <param name="ExchangeRate">ExchangeRate.</param>
        /// <param name="ISRRetRate">ISRRetRate.</param>
        /// <param name="VATRetRate">VATRetRate.</param>
        /// <param name="Comments">Comments.</param>
        /// <param name="VATRate">VATRate.</param>
        /// <param name="DiscountType">DiscountType.</param>
        /// <param name="DiscountAmount">DiscountAmount.</param>
        /// <param name="Products">Products.</param>
        /// <param name="Services">Services.</param>
        /// <param name="Emails">Emails.</param>
        /// <param name="PurchaseOrder">PurchaseOrder.</param>
        /// <param name="CreditDays">CreditDays.</param>
        /// <param name="IsFiscalInvoice">IsFiscalInvoice.</param>
        /// <param name="ShowIEPS">ShowIEPS.</param>
        /// <param name="Number">Number.</param>
        /// <param name="Account">Account.</param>
        /// <param name="Payments">Payments.</param>
        /// <param name="Serie">Serie.</param>
<<<<<<< HEAD
        /// <param name="Reference">Reference.</param>
        public NewInvoice(Guid? CurrencyID = default(Guid?), Guid? ClientID = default(Guid?), Guid? LocationID = default(Guid?), Guid? WarehouseID = default(Guid?), int? CFDIUse = default(int?), DateTime? InvoiceDate = default(DateTime?), Guid? PriceListID = default(Guid?), double? ExchangeRate = default(double?), double? ISRRetRate = default(double?), double? VATRetRate = default(double?), string Comments = default(string), double? VATRate = default(double?), int? DiscountType = default(int?), double? DiscountAmount = default(double?), List<NewInvoiceProduct> Products = default(List<NewInvoiceProduct>), List<NewInvoiceService> Services = default(List<NewInvoiceService>), List<string> Emails = default(List<string>), string PurchaseOrder = default(string), int? CreditDays = default(int?), bool? IsFiscalInvoice = default(bool?), bool? ShowIEPS = default(bool?), long? Number = default(long?), string Account = default(string), List<NewInvoicePayment> Payments = default(List<NewInvoicePayment>), string Serie = default(string), string Reference = default(string))
=======
        public NewInvoice(Guid? CurrencyID = default(Guid?), Guid? ClientID = default(Guid?), Guid? LocationID = default(Guid?), Guid? WarehouseID = default(Guid?), int? CFDIUse = default(int?), DateTime? InvoiceDate = default(DateTime?), Guid? PriceListID = default(Guid?), double? ExchangeRate = default(double?), double? ISRRetRate = default(double?), double? VATRetRate = default(double?), string Comments = default(string), double? VATRate = default(double?), int? DiscountType = default(int?), double? DiscountAmount = default(double?), List<NewInvoiceProduct> Products = default(List<NewInvoiceProduct>), List<NewInvoiceService> Services = default(List<NewInvoiceService>), List<string> Emails = default(List<string>), string PurchaseOrder = default(string), int? CreditDays = default(int?), bool? IsFiscalInvoice = default(bool?), bool? ShowIEPS = default(bool?), long? Number = default(long?), string Account = default(string), List<NewInvoicePayment> Payments = default(List<NewInvoicePayment>), string Serie = default(string))
>>>>>>> 00a0f02ad3caf59a4284f6cc77ac538a3fc20070
        {
            // to ensure "CurrencyID" is required (not null)
            if (CurrencyID == null)
            {
                throw new InvalidDataException("CurrencyID is a required property for NewInvoice and cannot be null");
            }
            else
            {
                this.CurrencyID = CurrencyID;
            }
            // to ensure "ClientID" is required (not null)
            if (ClientID == null)
            {
                throw new InvalidDataException("ClientID is a required property for NewInvoice and cannot be null");
            }
            else
            {
                this.ClientID = ClientID;
            }
            // to ensure "LocationID" is required (not null)
            if (LocationID == null)
            {
                throw new InvalidDataException("LocationID is a required property for NewInvoice and cannot be null");
            }
            else
            {
                this.LocationID = LocationID;
            }
            // to ensure "WarehouseID" is required (not null)
            if (WarehouseID == null)
            {
                throw new InvalidDataException("WarehouseID is a required property for NewInvoice and cannot be null");
            }
            else
            {
                this.WarehouseID = WarehouseID;
            }
            // to ensure "CFDIUse" is required (not null)
            if (CFDIUse == null)
            {
                throw new InvalidDataException("CFDIUse is a required property for NewInvoice and cannot be null");
            }
            else
            {
                this.CFDIUse = CFDIUse;
            }
            // to ensure "InvoiceDate" is required (not null)
            if (InvoiceDate == null)
            {
                throw new InvalidDataException("InvoiceDate is a required property for NewInvoice and cannot be null");
            }
            else
            {
                this.InvoiceDate = InvoiceDate;
            }
            // to ensure "PriceListID" is required (not null)
            if (PriceListID == null)
            {
                throw new InvalidDataException("PriceListID is a required property for NewInvoice and cannot be null");
            }
            else
            {
                this.PriceListID = PriceListID;
            }
            this.ExchangeRate = ExchangeRate;
            this.ISRRetRate = ISRRetRate;
            this.VATRetRate = VATRetRate;
            this.Comments = Comments;
            this.VATRate = VATRate;
            this.DiscountType = DiscountType;
            this.DiscountAmount = DiscountAmount;
            this.Products = Products;
            this.Services = Services;
            this.Emails = Emails;
            this.PurchaseOrder = PurchaseOrder;
            this.CreditDays = CreditDays;
            this.IsFiscalInvoice = IsFiscalInvoice;
            this.ShowIEPS = ShowIEPS;
            this.Number = Number;
            this.Account = Account;
            this.Payments = Payments;
            this.Serie = Serie;
            this.Reference = Reference;
        }
        
        /// <summary>
        /// Gets or Sets CurrencyID
        /// </summary>
        [DataMember(Name="CurrencyID", EmitDefaultValue=false)]
        public Guid? CurrencyID { get; set; }

        /// <summary>
        /// Gets or Sets ClientID
        /// </summary>
        [DataMember(Name="ClientID", EmitDefaultValue=false)]
        public Guid? ClientID { get; set; }

        /// <summary>
        /// Gets or Sets LocationID
        /// </summary>
        [DataMember(Name="LocationID", EmitDefaultValue=false)]
        public Guid? LocationID { get; set; }

        /// <summary>
        /// Gets or Sets WarehouseID
        /// </summary>
        [DataMember(Name="WarehouseID", EmitDefaultValue=false)]
        public Guid? WarehouseID { get; set; }

        /// <summary>
        /// Gets or Sets CFDIUse
        /// </summary>
        [DataMember(Name="CFDIUse", EmitDefaultValue=false)]
        public int? CFDIUse { get; set; }

        /// <summary>
        /// Gets or Sets InvoiceDate
        /// </summary>
        [DataMember(Name="InvoiceDate", EmitDefaultValue=false)]
        public DateTime? InvoiceDate { get; set; }

        /// <summary>
        /// Gets or Sets PriceListID
        /// </summary>
        [DataMember(Name="PriceListID", EmitDefaultValue=false)]
        public Guid? PriceListID { get; set; }

        /// <summary>
        /// Gets or Sets ExchangeRate
        /// </summary>
        [DataMember(Name="ExchangeRate", EmitDefaultValue=false)]
        public double? ExchangeRate { get; set; }

        /// <summary>
        /// Gets or Sets ISRRetRate
        /// </summary>
        [DataMember(Name="ISRRetRate", EmitDefaultValue=false)]
        public double? ISRRetRate { get; set; }

        /// <summary>
        /// Gets or Sets VATRetRate
        /// </summary>
        [DataMember(Name="VATRetRate", EmitDefaultValue=false)]
        public double? VATRetRate { get; set; }

        /// <summary>
        /// Gets or Sets Comments
        /// </summary>
        [DataMember(Name="Comments", EmitDefaultValue=false)]
        public string Comments { get; set; }

        /// <summary>
        /// Gets or Sets VATRate
        /// </summary>
        [DataMember(Name="VATRate", EmitDefaultValue=false)]
        public double? VATRate { get; set; }

        /// <summary>
        /// Gets or Sets DiscountType
        /// </summary>
        [DataMember(Name="DiscountType", EmitDefaultValue=false)]
        public int? DiscountType { get; set; }

        /// <summary>
        /// Gets or Sets DiscountAmount
        /// </summary>
        [DataMember(Name="DiscountAmount", EmitDefaultValue=false)]
        public double? DiscountAmount { get; set; }

        /// <summary>
        /// Gets or Sets Products
        /// </summary>
        [DataMember(Name="Products", EmitDefaultValue=false)]
        public List<NewInvoiceProduct> Products { get; set; }

        /// <summary>
        /// Gets or Sets Services
        /// </summary>
        [DataMember(Name="Services", EmitDefaultValue=false)]
        public List<NewInvoiceService> Services { get; set; }

        /// <summary>
        /// Gets or Sets Emails
        /// </summary>
        [DataMember(Name="Emails", EmitDefaultValue=false)]
        public List<string> Emails { get; set; }

        /// <summary>
        /// Gets or Sets PurchaseOrder
        /// </summary>
        [DataMember(Name="PurchaseOrder", EmitDefaultValue=false)]
        public string PurchaseOrder { get; set; }

        /// <summary>
        /// Gets or Sets CreditDays
        /// </summary>
        [DataMember(Name="CreditDays", EmitDefaultValue=false)]
        public int? CreditDays { get; set; }

        /// <summary>
        /// Gets or Sets IsFiscalInvoice
        /// </summary>
        [DataMember(Name="IsFiscalInvoice", EmitDefaultValue=false)]
        public bool? IsFiscalInvoice { get; set; }

        /// <summary>
        /// Gets or Sets ShowIEPS
        /// </summary>
        [DataMember(Name="ShowIEPS", EmitDefaultValue=false)]
        public bool? ShowIEPS { get; set; }

        /// <summary>
        /// Gets or Sets Number
        /// </summary>
        [DataMember(Name="Number", EmitDefaultValue=false)]
        public long? Number { get; set; }

        /// <summary>
        /// Gets or Sets Account
        /// </summary>
        [DataMember(Name="Account", EmitDefaultValue=false)]
        public string Account { get; set; }

        /// <summary>
        /// Gets or Sets Payments
        /// </summary>
        [DataMember(Name="Payments", EmitDefaultValue=false)]
        public List<NewInvoicePayment> Payments { get; set; }

        /// <summary>
        /// Gets or Sets Serie
        /// </summary>
        [DataMember(Name="Serie", EmitDefaultValue=false)]
        public string Serie { get; set; }

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
            sb.Append("class NewInvoice {\n");
            sb.Append("  CurrencyID: ").Append(CurrencyID).Append("\n");
            sb.Append("  ClientID: ").Append(ClientID).Append("\n");
            sb.Append("  LocationID: ").Append(LocationID).Append("\n");
            sb.Append("  WarehouseID: ").Append(WarehouseID).Append("\n");
            sb.Append("  CFDIUse: ").Append(CFDIUse).Append("\n");
            sb.Append("  InvoiceDate: ").Append(InvoiceDate).Append("\n");
            sb.Append("  PriceListID: ").Append(PriceListID).Append("\n");
            sb.Append("  ExchangeRate: ").Append(ExchangeRate).Append("\n");
            sb.Append("  ISRRetRate: ").Append(ISRRetRate).Append("\n");
            sb.Append("  VATRetRate: ").Append(VATRetRate).Append("\n");
            sb.Append("  Comments: ").Append(Comments).Append("\n");
            sb.Append("  VATRate: ").Append(VATRate).Append("\n");
            sb.Append("  DiscountType: ").Append(DiscountType).Append("\n");
            sb.Append("  DiscountAmount: ").Append(DiscountAmount).Append("\n");
            sb.Append("  Products: ").Append(Products).Append("\n");
            sb.Append("  Services: ").Append(Services).Append("\n");
            sb.Append("  Emails: ").Append(Emails).Append("\n");
            sb.Append("  PurchaseOrder: ").Append(PurchaseOrder).Append("\n");
            sb.Append("  CreditDays: ").Append(CreditDays).Append("\n");
            sb.Append("  IsFiscalInvoice: ").Append(IsFiscalInvoice).Append("\n");
            sb.Append("  ShowIEPS: ").Append(ShowIEPS).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  Payments: ").Append(Payments).Append("\n");
            sb.Append("  Serie: ").Append(Serie).Append("\n");
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
            return this.Equals(input as NewInvoice);
        }

        /// <summary>
        /// Returns true if NewInvoice instances are equal
        /// </summary>
        /// <param name="input">Instance of NewInvoice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NewInvoice input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CurrencyID == input.CurrencyID ||
                    (this.CurrencyID != null &&
                    this.CurrencyID.Equals(input.CurrencyID))
                ) && 
                (
                    this.ClientID == input.ClientID ||
                    (this.ClientID != null &&
                    this.ClientID.Equals(input.ClientID))
                ) && 
                (
                    this.LocationID == input.LocationID ||
                    (this.LocationID != null &&
                    this.LocationID.Equals(input.LocationID))
                ) && 
                (
                    this.WarehouseID == input.WarehouseID ||
                    (this.WarehouseID != null &&
                    this.WarehouseID.Equals(input.WarehouseID))
                ) && 
                (
                    this.CFDIUse == input.CFDIUse ||
                    (this.CFDIUse != null &&
                    this.CFDIUse.Equals(input.CFDIUse))
                ) && 
                (
                    this.InvoiceDate == input.InvoiceDate ||
                    (this.InvoiceDate != null &&
                    this.InvoiceDate.Equals(input.InvoiceDate))
                ) && 
                (
                    this.PriceListID == input.PriceListID ||
                    (this.PriceListID != null &&
                    this.PriceListID.Equals(input.PriceListID))
                ) && 
                (
                    this.ExchangeRate == input.ExchangeRate ||
                    (this.ExchangeRate != null &&
                    this.ExchangeRate.Equals(input.ExchangeRate))
                ) && 
                (
                    this.ISRRetRate == input.ISRRetRate ||
                    (this.ISRRetRate != null &&
                    this.ISRRetRate.Equals(input.ISRRetRate))
                ) && 
                (
                    this.VATRetRate == input.VATRetRate ||
                    (this.VATRetRate != null &&
                    this.VATRetRate.Equals(input.VATRetRate))
                ) && 
                (
                    this.Comments == input.Comments ||
                    (this.Comments != null &&
                    this.Comments.Equals(input.Comments))
                ) && 
                (
                    this.VATRate == input.VATRate ||
                    (this.VATRate != null &&
                    this.VATRate.Equals(input.VATRate))
                ) && 
                (
                    this.DiscountType == input.DiscountType ||
                    (this.DiscountType != null &&
                    this.DiscountType.Equals(input.DiscountType))
                ) && 
                (
                    this.DiscountAmount == input.DiscountAmount ||
                    (this.DiscountAmount != null &&
                    this.DiscountAmount.Equals(input.DiscountAmount))
                ) && 
                (
                    this.Products == input.Products ||
                    this.Products != null &&
                    this.Products.SequenceEqual(input.Products)
                ) && 
                (
                    this.Services == input.Services ||
                    this.Services != null &&
                    this.Services.SequenceEqual(input.Services)
                ) && 
                (
                    this.Emails == input.Emails ||
                    this.Emails != null &&
                    this.Emails.SequenceEqual(input.Emails)
                ) && 
                (
                    this.PurchaseOrder == input.PurchaseOrder ||
                    (this.PurchaseOrder != null &&
                    this.PurchaseOrder.Equals(input.PurchaseOrder))
                ) && 
                (
                    this.CreditDays == input.CreditDays ||
                    (this.CreditDays != null &&
                    this.CreditDays.Equals(input.CreditDays))
                ) && 
                (
                    this.IsFiscalInvoice == input.IsFiscalInvoice ||
                    (this.IsFiscalInvoice != null &&
                    this.IsFiscalInvoice.Equals(input.IsFiscalInvoice))
                ) && 
                (
                    this.ShowIEPS == input.ShowIEPS ||
                    (this.ShowIEPS != null &&
                    this.ShowIEPS.Equals(input.ShowIEPS))
                ) && 
                (
                    this.Number == input.Number ||
                    (this.Number != null &&
                    this.Number.Equals(input.Number))
                ) && 
                (
                    this.Account == input.Account ||
                    (this.Account != null &&
                    this.Account.Equals(input.Account))
                ) && 
                (
                    this.Payments == input.Payments ||
                    this.Payments != null &&
                    this.Payments.SequenceEqual(input.Payments)
                ) && 
                (
                    this.Serie == input.Serie ||
                    (this.Serie != null &&
                    this.Serie.Equals(input.Serie))
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
                if (this.CurrencyID != null)
                    hashCode = hashCode * 59 + this.CurrencyID.GetHashCode();
                if (this.ClientID != null)
                    hashCode = hashCode * 59 + this.ClientID.GetHashCode();
                if (this.LocationID != null)
                    hashCode = hashCode * 59 + this.LocationID.GetHashCode();
                if (this.WarehouseID != null)
                    hashCode = hashCode * 59 + this.WarehouseID.GetHashCode();
                if (this.CFDIUse != null)
                    hashCode = hashCode * 59 + this.CFDIUse.GetHashCode();
                if (this.InvoiceDate != null)
                    hashCode = hashCode * 59 + this.InvoiceDate.GetHashCode();
                if (this.PriceListID != null)
                    hashCode = hashCode * 59 + this.PriceListID.GetHashCode();
                if (this.ExchangeRate != null)
                    hashCode = hashCode * 59 + this.ExchangeRate.GetHashCode();
                if (this.ISRRetRate != null)
                    hashCode = hashCode * 59 + this.ISRRetRate.GetHashCode();
                if (this.VATRetRate != null)
                    hashCode = hashCode * 59 + this.VATRetRate.GetHashCode();
                if (this.Comments != null)
                    hashCode = hashCode * 59 + this.Comments.GetHashCode();
                if (this.VATRate != null)
                    hashCode = hashCode * 59 + this.VATRate.GetHashCode();
                if (this.DiscountType != null)
                    hashCode = hashCode * 59 + this.DiscountType.GetHashCode();
                if (this.DiscountAmount != null)
                    hashCode = hashCode * 59 + this.DiscountAmount.GetHashCode();
                if (this.Products != null)
                    hashCode = hashCode * 59 + this.Products.GetHashCode();
                if (this.Services != null)
                    hashCode = hashCode * 59 + this.Services.GetHashCode();
                if (this.Emails != null)
                    hashCode = hashCode * 59 + this.Emails.GetHashCode();
                if (this.PurchaseOrder != null)
                    hashCode = hashCode * 59 + this.PurchaseOrder.GetHashCode();
                if (this.CreditDays != null)
                    hashCode = hashCode * 59 + this.CreditDays.GetHashCode();
                if (this.IsFiscalInvoice != null)
                    hashCode = hashCode * 59 + this.IsFiscalInvoice.GetHashCode();
                if (this.ShowIEPS != null)
                    hashCode = hashCode * 59 + this.ShowIEPS.GetHashCode();
                if (this.Number != null)
                    hashCode = hashCode * 59 + this.Number.GetHashCode();
                if (this.Account != null)
                    hashCode = hashCode * 59 + this.Account.GetHashCode();
                if (this.Payments != null)
                    hashCode = hashCode * 59 + this.Payments.GetHashCode();
                if (this.Serie != null)
                    hashCode = hashCode * 59 + this.Serie.GetHashCode();
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
