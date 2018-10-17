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
    /// NewOrder
    /// </summary>
    [DataContract]
    public partial class NewOrder :  IEquatable<NewOrder>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NewOrder" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NewOrder() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NewOrder" /> class.
        /// </summary>
        /// <param name="AddressID">AddressID (required).</param>
        /// <param name="ClientID">ClientID (required).</param>
        /// <param name="CurrencyID">CurrencyID (required).</param>
        /// <param name="LocationID">LocationID (required).</param>
        /// <param name="OrderDate">OrderDate (required).</param>
        /// <param name="PriceListID">PriceListID (required).</param>
        /// <param name="WarehouseID">WarehouseID (required).</param>
        /// <param name="Comments">Comments.</param>
        /// <param name="DiscountAmount">DiscountAmount.</param>
        /// <param name="DiscountType">DiscountType.</param>
        /// <param name="DocNumberID">DocNumberID.</param>
        /// <param name="ExchangeRate">ExchangeRate.</param>
        /// <param name="ISRRate">ISRRate.</param>
        /// <param name="PurchaseOrder">PurchaseOrder.</param>
        /// <param name="VATRate">VATRate.</param>
        /// <param name="VATRetRate">VATRetRate.</param>
        /// <param name="Emails">Emails.</param>
        /// <param name="Products">Products.</param>
        /// <param name="Services">Services.</param>
        public NewOrder(Guid? AddressID = default(Guid?), Guid? ClientID = default(Guid?), Guid? CurrencyID = default(Guid?), Guid? LocationID = default(Guid?), DateTime? OrderDate = default(DateTime?), Guid? PriceListID = default(Guid?), Guid? WarehouseID = default(Guid?), string Comments = default(string), double? DiscountAmount = default(double?), int? DiscountType = default(int?), Guid? DocNumberID = default(Guid?), double? ExchangeRate = default(double?), double? ISRRate = default(double?), string PurchaseOrder = default(string), double? VATRate = default(double?), double? VATRetRate = default(double?), List<string> Emails = default(List<string>), List<NewOrderProduct> Products = default(List<NewOrderProduct>), List<NewOrderService> Services = default(List<NewOrderService>))
        {
            // to ensure "AddressID" is required (not null)
            if (AddressID == null)
            {
                throw new InvalidDataException("AddressID is a required property for NewOrder and cannot be null");
            }
            else
            {
                this.AddressID = AddressID;
            }
            // to ensure "ClientID" is required (not null)
            if (ClientID == null)
            {
                throw new InvalidDataException("ClientID is a required property for NewOrder and cannot be null");
            }
            else
            {
                this.ClientID = ClientID;
            }
            // to ensure "CurrencyID" is required (not null)
            if (CurrencyID == null)
            {
                throw new InvalidDataException("CurrencyID is a required property for NewOrder and cannot be null");
            }
            else
            {
                this.CurrencyID = CurrencyID;
            }
            // to ensure "LocationID" is required (not null)
            if (LocationID == null)
            {
                throw new InvalidDataException("LocationID is a required property for NewOrder and cannot be null");
            }
            else
            {
                this.LocationID = LocationID;
            }
            // to ensure "OrderDate" is required (not null)
            if (OrderDate == null)
            {
                throw new InvalidDataException("OrderDate is a required property for NewOrder and cannot be null");
            }
            else
            {
                this.OrderDate = OrderDate;
            }
            // to ensure "PriceListID" is required (not null)
            if (PriceListID == null)
            {
                throw new InvalidDataException("PriceListID is a required property for NewOrder and cannot be null");
            }
            else
            {
                this.PriceListID = PriceListID;
            }
            // to ensure "WarehouseID" is required (not null)
            if (WarehouseID == null)
            {
                throw new InvalidDataException("WarehouseID is a required property for NewOrder and cannot be null");
            }
            else
            {
                this.WarehouseID = WarehouseID;
            }
            this.Comments = Comments;
            this.DiscountAmount = DiscountAmount;
            this.DiscountType = DiscountType;
            this.DocNumberID = DocNumberID;
            this.ExchangeRate = ExchangeRate;
            this.ISRRate = ISRRate;
            this.PurchaseOrder = PurchaseOrder;
            this.VATRate = VATRate;
            this.VATRetRate = VATRetRate;
            this.Emails = Emails;
            this.Products = Products;
            this.Services = Services;
        }
        
        /// <summary>
        /// Gets or Sets AddressID
        /// </summary>
        [DataMember(Name="AddressID", EmitDefaultValue=false)]
        public Guid? AddressID { get; set; }

        /// <summary>
        /// Gets or Sets ClientID
        /// </summary>
        [DataMember(Name="ClientID", EmitDefaultValue=false)]
        public Guid? ClientID { get; set; }

        /// <summary>
        /// Gets or Sets CurrencyID
        /// </summary>
        [DataMember(Name="CurrencyID", EmitDefaultValue=false)]
        public Guid? CurrencyID { get; set; }

        /// <summary>
        /// Gets or Sets LocationID
        /// </summary>
        [DataMember(Name="LocationID", EmitDefaultValue=false)]
        public Guid? LocationID { get; set; }

        /// <summary>
        /// Gets or Sets OrderDate
        /// </summary>
        [DataMember(Name="OrderDate", EmitDefaultValue=false)]
        public DateTime? OrderDate { get; set; }

        /// <summary>
        /// Gets or Sets PriceListID
        /// </summary>
        [DataMember(Name="PriceListID", EmitDefaultValue=false)]
        public Guid? PriceListID { get; set; }

        /// <summary>
        /// Gets or Sets WarehouseID
        /// </summary>
        [DataMember(Name="WarehouseID", EmitDefaultValue=false)]
        public Guid? WarehouseID { get; set; }

        /// <summary>
        /// Gets or Sets Comments
        /// </summary>
        [DataMember(Name="Comments", EmitDefaultValue=false)]
        public string Comments { get; set; }

        /// <summary>
        /// Gets or Sets DiscountAmount
        /// </summary>
        [DataMember(Name="DiscountAmount", EmitDefaultValue=false)]
        public double? DiscountAmount { get; set; }

        /// <summary>
        /// Gets or Sets DiscountType
        /// </summary>
        [DataMember(Name="DiscountType", EmitDefaultValue=false)]
        public int? DiscountType { get; set; }

        /// <summary>
        /// Gets or Sets DocNumberID
        /// </summary>
        [DataMember(Name="DocNumberID", EmitDefaultValue=false)]
        public Guid? DocNumberID { get; set; }

        /// <summary>
        /// Gets or Sets ExchangeRate
        /// </summary>
        [DataMember(Name="ExchangeRate", EmitDefaultValue=false)]
        public double? ExchangeRate { get; set; }

        /// <summary>
        /// Gets or Sets ISRRate
        /// </summary>
        [DataMember(Name="ISRRate", EmitDefaultValue=false)]
        public double? ISRRate { get; set; }

        /// <summary>
        /// Gets or Sets PurchaseOrder
        /// </summary>
        [DataMember(Name="PurchaseOrder", EmitDefaultValue=false)]
        public string PurchaseOrder { get; set; }

        /// <summary>
        /// Gets or Sets VATRate
        /// </summary>
        [DataMember(Name="VATRate", EmitDefaultValue=false)]
        public double? VATRate { get; set; }

        /// <summary>
        /// Gets or Sets VATRetRate
        /// </summary>
        [DataMember(Name="VATRetRate", EmitDefaultValue=false)]
        public double? VATRetRate { get; set; }

        /// <summary>
        /// Gets or Sets Emails
        /// </summary>
        [DataMember(Name="Emails", EmitDefaultValue=false)]
        public List<string> Emails { get; set; }

        /// <summary>
        /// Gets or Sets Products
        /// </summary>
        [DataMember(Name="Products", EmitDefaultValue=false)]
        public List<NewOrderProduct> Products { get; set; }

        /// <summary>
        /// Gets or Sets Services
        /// </summary>
        [DataMember(Name="Services", EmitDefaultValue=false)]
        public List<NewOrderService> Services { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NewOrder {\n");
            sb.Append("  AddressID: ").Append(AddressID).Append("\n");
            sb.Append("  ClientID: ").Append(ClientID).Append("\n");
            sb.Append("  CurrencyID: ").Append(CurrencyID).Append("\n");
            sb.Append("  LocationID: ").Append(LocationID).Append("\n");
            sb.Append("  OrderDate: ").Append(OrderDate).Append("\n");
            sb.Append("  PriceListID: ").Append(PriceListID).Append("\n");
            sb.Append("  WarehouseID: ").Append(WarehouseID).Append("\n");
            sb.Append("  Comments: ").Append(Comments).Append("\n");
            sb.Append("  DiscountAmount: ").Append(DiscountAmount).Append("\n");
            sb.Append("  DiscountType: ").Append(DiscountType).Append("\n");
            sb.Append("  DocNumberID: ").Append(DocNumberID).Append("\n");
            sb.Append("  ExchangeRate: ").Append(ExchangeRate).Append("\n");
            sb.Append("  ISRRate: ").Append(ISRRate).Append("\n");
            sb.Append("  PurchaseOrder: ").Append(PurchaseOrder).Append("\n");
            sb.Append("  VATRate: ").Append(VATRate).Append("\n");
            sb.Append("  VATRetRate: ").Append(VATRetRate).Append("\n");
            sb.Append("  Emails: ").Append(Emails).Append("\n");
            sb.Append("  Products: ").Append(Products).Append("\n");
            sb.Append("  Services: ").Append(Services).Append("\n");
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
            return this.Equals(input as NewOrder);
        }

        /// <summary>
        /// Returns true if NewOrder instances are equal
        /// </summary>
        /// <param name="input">Instance of NewOrder to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NewOrder input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AddressID == input.AddressID ||
                    (this.AddressID != null &&
                    this.AddressID.Equals(input.AddressID))
                ) && 
                (
                    this.ClientID == input.ClientID ||
                    (this.ClientID != null &&
                    this.ClientID.Equals(input.ClientID))
                ) && 
                (
                    this.CurrencyID == input.CurrencyID ||
                    (this.CurrencyID != null &&
                    this.CurrencyID.Equals(input.CurrencyID))
                ) && 
                (
                    this.LocationID == input.LocationID ||
                    (this.LocationID != null &&
                    this.LocationID.Equals(input.LocationID))
                ) && 
                (
                    this.OrderDate == input.OrderDate ||
                    (this.OrderDate != null &&
                    this.OrderDate.Equals(input.OrderDate))
                ) && 
                (
                    this.PriceListID == input.PriceListID ||
                    (this.PriceListID != null &&
                    this.PriceListID.Equals(input.PriceListID))
                ) && 
                (
                    this.WarehouseID == input.WarehouseID ||
                    (this.WarehouseID != null &&
                    this.WarehouseID.Equals(input.WarehouseID))
                ) && 
                (
                    this.Comments == input.Comments ||
                    (this.Comments != null &&
                    this.Comments.Equals(input.Comments))
                ) && 
                (
                    this.DiscountAmount == input.DiscountAmount ||
                    (this.DiscountAmount != null &&
                    this.DiscountAmount.Equals(input.DiscountAmount))
                ) && 
                (
                    this.DiscountType == input.DiscountType ||
                    (this.DiscountType != null &&
                    this.DiscountType.Equals(input.DiscountType))
                ) && 
                (
                    this.DocNumberID == input.DocNumberID ||
                    (this.DocNumberID != null &&
                    this.DocNumberID.Equals(input.DocNumberID))
                ) && 
                (
                    this.ExchangeRate == input.ExchangeRate ||
                    (this.ExchangeRate != null &&
                    this.ExchangeRate.Equals(input.ExchangeRate))
                ) && 
                (
                    this.ISRRate == input.ISRRate ||
                    (this.ISRRate != null &&
                    this.ISRRate.Equals(input.ISRRate))
                ) && 
                (
                    this.PurchaseOrder == input.PurchaseOrder ||
                    (this.PurchaseOrder != null &&
                    this.PurchaseOrder.Equals(input.PurchaseOrder))
                ) && 
                (
                    this.VATRate == input.VATRate ||
                    (this.VATRate != null &&
                    this.VATRate.Equals(input.VATRate))
                ) && 
                (
                    this.VATRetRate == input.VATRetRate ||
                    (this.VATRetRate != null &&
                    this.VATRetRate.Equals(input.VATRetRate))
                ) && 
                (
                    this.Emails == input.Emails ||
                    this.Emails != null &&
                    this.Emails.SequenceEqual(input.Emails)
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
                if (this.AddressID != null)
                    hashCode = hashCode * 59 + this.AddressID.GetHashCode();
                if (this.ClientID != null)
                    hashCode = hashCode * 59 + this.ClientID.GetHashCode();
                if (this.CurrencyID != null)
                    hashCode = hashCode * 59 + this.CurrencyID.GetHashCode();
                if (this.LocationID != null)
                    hashCode = hashCode * 59 + this.LocationID.GetHashCode();
                if (this.OrderDate != null)
                    hashCode = hashCode * 59 + this.OrderDate.GetHashCode();
                if (this.PriceListID != null)
                    hashCode = hashCode * 59 + this.PriceListID.GetHashCode();
                if (this.WarehouseID != null)
                    hashCode = hashCode * 59 + this.WarehouseID.GetHashCode();
                if (this.Comments != null)
                    hashCode = hashCode * 59 + this.Comments.GetHashCode();
                if (this.DiscountAmount != null)
                    hashCode = hashCode * 59 + this.DiscountAmount.GetHashCode();
                if (this.DiscountType != null)
                    hashCode = hashCode * 59 + this.DiscountType.GetHashCode();
                if (this.DocNumberID != null)
                    hashCode = hashCode * 59 + this.DocNumberID.GetHashCode();
                if (this.ExchangeRate != null)
                    hashCode = hashCode * 59 + this.ExchangeRate.GetHashCode();
                if (this.ISRRate != null)
                    hashCode = hashCode * 59 + this.ISRRate.GetHashCode();
                if (this.PurchaseOrder != null)
                    hashCode = hashCode * 59 + this.PurchaseOrder.GetHashCode();
                if (this.VATRate != null)
                    hashCode = hashCode * 59 + this.VATRate.GetHashCode();
                if (this.VATRetRate != null)
                    hashCode = hashCode * 59 + this.VATRetRate.GetHashCode();
                if (this.Emails != null)
                    hashCode = hashCode * 59 + this.Emails.GetHashCode();
                if (this.Products != null)
                    hashCode = hashCode * 59 + this.Products.GetHashCode();
                if (this.Services != null)
                    hashCode = hashCode * 59 + this.Services.GetHashCode();
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
