/* 
 * Bind ERP API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
<<<<<<< HEAD
 * OpenAPI spec version: v1
=======
 * OpenAPI spec version: v1.2
>>>>>>> 00a0f02ad3caf59a4284f6cc77ac538a3fc20070
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
    /// InvoiceListItem
    /// </summary>
    [DataContract]
    public partial class InvoiceListItem :  IEquatable<InvoiceListItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceListItem" /> class.
        /// </summary>
<<<<<<< HEAD
        /// <param name="ID">ID.</param>
=======
>>>>>>> 00a0f02ad3caf59a4284f6cc77ac538a3fc20070
        /// <param name="Serie">Serie.</param>
        /// <param name="Date">Date.</param>
        /// <param name="Number">Number.</param>
        /// <param name="UUID">UUID.</param>
        /// <param name="ExpirationDate">ExpirationDate.</param>
        /// <param name="ClientID">ClientID.</param>
        /// <param name="ClientName">ClientName.</param>
        /// <param name="RFC">RFC.</param>
        /// <param name="Cost">Cost.</param>
        /// <param name="Subtotal">Subtotal.</param>
        /// <param name="Discount">Discount.</param>
        /// <param name="VAT">VAT.</param>
        /// <param name="IEPS">IEPS.</param>
        /// <param name="ISRRet">ISRRet.</param>
        /// <param name="VATRet">VATRet.</param>
        /// <param name="Total">Total.</param>
        /// <param name="Payments">Payments.</param>
        /// <param name="CreditNotes">CreditNotes.</param>
        /// <param name="CurrencyID">CurrencyID.</param>
        /// <param name="LocationID">LocationID.</param>
        /// <param name="WarehouseID">WarehouseID.</param>
        /// <param name="PriceListID">PriceListID.</param>
<<<<<<< HEAD
=======
        /// <param name="CFDIID">CFDIID.</param>
>>>>>>> 00a0f02ad3caf59a4284f6cc77ac538a3fc20070
        /// <param name="CFDIUse">CFDIUse.</param>
        /// <param name="ExchangeRate">ExchangeRate.</param>
        /// <param name="VATRetRate">VATRetRate.</param>
        /// <param name="Comments">Comments.</param>
        /// <param name="VATRate">VATRate.</param>
        /// <param name="PurchaseOrder">PurchaseOrder.</param>
        /// <param name="IsFiscalInvoice">IsFiscalInvoice.</param>
        /// <param name="ShowIEPS">ShowIEPS.</param>
        /// <param name="Status">Status.</param>
<<<<<<< HEAD
        public InvoiceListItem(Guid? ID = default(Guid?), string Serie = default(string), DateTime? Date = default(DateTime?), long? Number = default(long?), Guid? UUID = default(Guid?), DateTime? ExpirationDate = default(DateTime?), Guid? ClientID = default(Guid?), string ClientName = default(string), string RFC = default(string), double? Cost = default(double?), double? Subtotal = default(double?), double? Discount = default(double?), double? VAT = default(double?), double? IEPS = default(double?), double? ISRRet = default(double?), double? VATRet = default(double?), double? Total = default(double?), double? Payments = default(double?), double? CreditNotes = default(double?), Guid? CurrencyID = default(Guid?), Guid? LocationID = default(Guid?), Guid? WarehouseID = default(Guid?), Guid? PriceListID = default(Guid?), int? CFDIUse = default(int?), double? ExchangeRate = default(double?), double? VATRetRate = default(double?), string Comments = default(string), double? VATRate = default(double?), string PurchaseOrder = default(string), bool? IsFiscalInvoice = default(bool?), bool? ShowIEPS = default(bool?), int? Status = default(int?))
        {
            this.ID = ID;
=======
        public InvoiceListItem(string Serie = default(string), DateTime? Date = default(DateTime?), long? Number = default(long?), Guid? UUID = default(Guid?), DateTime? ExpirationDate = default(DateTime?), Guid? ClientID = default(Guid?), string ClientName = default(string), string RFC = default(string), double? Cost = default(double?), double? Subtotal = default(double?), double? Discount = default(double?), double? VAT = default(double?), double? IEPS = default(double?), double? ISRRet = default(double?), double? VATRet = default(double?), double? Total = default(double?), double? Payments = default(double?), double? CreditNotes = default(double?), Guid? CurrencyID = default(Guid?), Guid? LocationID = default(Guid?), Guid? WarehouseID = default(Guid?), Guid? PriceListID = default(Guid?), Guid? CFDIID = default(Guid?), int? CFDIUse = default(int?), double? ExchangeRate = default(double?), double? VATRetRate = default(double?), string Comments = default(string), double? VATRate = default(double?), string PurchaseOrder = default(string), bool? IsFiscalInvoice = default(bool?), bool? ShowIEPS = default(bool?), int? Status = default(int?))
        {
>>>>>>> 00a0f02ad3caf59a4284f6cc77ac538a3fc20070
            this.Serie = Serie;
            this.Date = Date;
            this.Number = Number;
            this.UUID = UUID;
            this.ExpirationDate = ExpirationDate;
            this.ClientID = ClientID;
            this.ClientName = ClientName;
            this.RFC = RFC;
            this.Cost = Cost;
            this.Subtotal = Subtotal;
            this.Discount = Discount;
            this.VAT = VAT;
            this.IEPS = IEPS;
            this.ISRRet = ISRRet;
            this.VATRet = VATRet;
            this.Total = Total;
            this.Payments = Payments;
            this.CreditNotes = CreditNotes;
            this.CurrencyID = CurrencyID;
            this.LocationID = LocationID;
            this.WarehouseID = WarehouseID;
            this.PriceListID = PriceListID;
<<<<<<< HEAD
=======
            this.CFDIID = CFDIID;
>>>>>>> 00a0f02ad3caf59a4284f6cc77ac538a3fc20070
            this.CFDIUse = CFDIUse;
            this.ExchangeRate = ExchangeRate;
            this.VATRetRate = VATRetRate;
            this.Comments = Comments;
            this.VATRate = VATRate;
            this.PurchaseOrder = PurchaseOrder;
            this.IsFiscalInvoice = IsFiscalInvoice;
            this.ShowIEPS = ShowIEPS;
            this.Status = Status;
        }
        
        /// <summary>
<<<<<<< HEAD
        /// Gets or Sets ID
        /// </summary>
        [DataMember(Name="ID", EmitDefaultValue=false)]
        public Guid? ID { get; set; }

        /// <summary>
=======
>>>>>>> 00a0f02ad3caf59a4284f6cc77ac538a3fc20070
        /// Gets or Sets Serie
        /// </summary>
        [DataMember(Name="Serie", EmitDefaultValue=false)]
        public string Serie { get; set; }

        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        [DataMember(Name="Date", EmitDefaultValue=false)]
        public DateTime? Date { get; set; }

        /// <summary>
        /// Gets or Sets Number
        /// </summary>
        [DataMember(Name="Number", EmitDefaultValue=false)]
        public long? Number { get; set; }

        /// <summary>
        /// Gets or Sets UUID
        /// </summary>
        [DataMember(Name="UUID", EmitDefaultValue=false)]
        public Guid? UUID { get; set; }

        /// <summary>
        /// Gets or Sets ExpirationDate
        /// </summary>
        [DataMember(Name="ExpirationDate", EmitDefaultValue=false)]
        public DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// Gets or Sets ClientID
        /// </summary>
        [DataMember(Name="ClientID", EmitDefaultValue=false)]
        public Guid? ClientID { get; set; }

        /// <summary>
        /// Gets or Sets ClientName
        /// </summary>
        [DataMember(Name="ClientName", EmitDefaultValue=false)]
        public string ClientName { get; set; }

        /// <summary>
        /// Gets or Sets RFC
        /// </summary>
        [DataMember(Name="RFC", EmitDefaultValue=false)]
        public string RFC { get; set; }

        /// <summary>
        /// Gets or Sets Cost
        /// </summary>
        [DataMember(Name="Cost", EmitDefaultValue=false)]
        public double? Cost { get; set; }

        /// <summary>
        /// Gets or Sets Subtotal
        /// </summary>
        [DataMember(Name="Subtotal", EmitDefaultValue=false)]
        public double? Subtotal { get; set; }

        /// <summary>
        /// Gets or Sets Discount
        /// </summary>
        [DataMember(Name="Discount", EmitDefaultValue=false)]
        public double? Discount { get; set; }

        /// <summary>
        /// Gets or Sets VAT
        /// </summary>
        [DataMember(Name="VAT", EmitDefaultValue=false)]
        public double? VAT { get; set; }

        /// <summary>
        /// Gets or Sets IEPS
        /// </summary>
        [DataMember(Name="IEPS", EmitDefaultValue=false)]
        public double? IEPS { get; set; }

        /// <summary>
        /// Gets or Sets ISRRet
        /// </summary>
        [DataMember(Name="ISRRet", EmitDefaultValue=false)]
        public double? ISRRet { get; set; }

        /// <summary>
        /// Gets or Sets VATRet
        /// </summary>
        [DataMember(Name="VATRet", EmitDefaultValue=false)]
        public double? VATRet { get; set; }

        /// <summary>
        /// Gets or Sets Total
        /// </summary>
        [DataMember(Name="Total", EmitDefaultValue=false)]
        public double? Total { get; set; }

        /// <summary>
        /// Gets or Sets Payments
        /// </summary>
        [DataMember(Name="Payments", EmitDefaultValue=false)]
        public double? Payments { get; set; }

        /// <summary>
        /// Gets or Sets CreditNotes
        /// </summary>
        [DataMember(Name="CreditNotes", EmitDefaultValue=false)]
        public double? CreditNotes { get; set; }

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
        /// Gets or Sets WarehouseID
        /// </summary>
        [DataMember(Name="WarehouseID", EmitDefaultValue=false)]
        public Guid? WarehouseID { get; set; }

        /// <summary>
        /// Gets or Sets PriceListID
        /// </summary>
        [DataMember(Name="PriceListID", EmitDefaultValue=false)]
        public Guid? PriceListID { get; set; }

        /// <summary>
<<<<<<< HEAD
=======
        /// Gets or Sets CFDIID
        /// </summary>
        [DataMember(Name="CFDIID", EmitDefaultValue=false)]
        public Guid? CFDIID { get; set; }

        /// <summary>
>>>>>>> 00a0f02ad3caf59a4284f6cc77ac538a3fc20070
        /// Gets or Sets CFDIUse
        /// </summary>
        [DataMember(Name="CFDIUse", EmitDefaultValue=false)]
        public int? CFDIUse { get; set; }

        /// <summary>
        /// Gets or Sets ExchangeRate
        /// </summary>
        [DataMember(Name="ExchangeRate", EmitDefaultValue=false)]
        public double? ExchangeRate { get; set; }

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
        /// Gets or Sets PurchaseOrder
        /// </summary>
        [DataMember(Name="PurchaseOrder", EmitDefaultValue=false)]
        public string PurchaseOrder { get; set; }

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
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="Status", EmitDefaultValue=false)]
        public int? Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InvoiceListItem {\n");
<<<<<<< HEAD
            sb.Append("  ID: ").Append(ID).Append("\n");
=======
>>>>>>> 00a0f02ad3caf59a4284f6cc77ac538a3fc20070
            sb.Append("  Serie: ").Append(Serie).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  UUID: ").Append(UUID).Append("\n");
            sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
            sb.Append("  ClientID: ").Append(ClientID).Append("\n");
            sb.Append("  ClientName: ").Append(ClientName).Append("\n");
            sb.Append("  RFC: ").Append(RFC).Append("\n");
            sb.Append("  Cost: ").Append(Cost).Append("\n");
            sb.Append("  Subtotal: ").Append(Subtotal).Append("\n");
            sb.Append("  Discount: ").Append(Discount).Append("\n");
            sb.Append("  VAT: ").Append(VAT).Append("\n");
            sb.Append("  IEPS: ").Append(IEPS).Append("\n");
            sb.Append("  ISRRet: ").Append(ISRRet).Append("\n");
            sb.Append("  VATRet: ").Append(VATRet).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  Payments: ").Append(Payments).Append("\n");
            sb.Append("  CreditNotes: ").Append(CreditNotes).Append("\n");
            sb.Append("  CurrencyID: ").Append(CurrencyID).Append("\n");
            sb.Append("  LocationID: ").Append(LocationID).Append("\n");
            sb.Append("  WarehouseID: ").Append(WarehouseID).Append("\n");
            sb.Append("  PriceListID: ").Append(PriceListID).Append("\n");
<<<<<<< HEAD
=======
            sb.Append("  CFDIID: ").Append(CFDIID).Append("\n");
>>>>>>> 00a0f02ad3caf59a4284f6cc77ac538a3fc20070
            sb.Append("  CFDIUse: ").Append(CFDIUse).Append("\n");
            sb.Append("  ExchangeRate: ").Append(ExchangeRate).Append("\n");
            sb.Append("  VATRetRate: ").Append(VATRetRate).Append("\n");
            sb.Append("  Comments: ").Append(Comments).Append("\n");
            sb.Append("  VATRate: ").Append(VATRate).Append("\n");
            sb.Append("  PurchaseOrder: ").Append(PurchaseOrder).Append("\n");
            sb.Append("  IsFiscalInvoice: ").Append(IsFiscalInvoice).Append("\n");
            sb.Append("  ShowIEPS: ").Append(ShowIEPS).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as InvoiceListItem);
        }

        /// <summary>
        /// Returns true if InvoiceListItem instances are equal
        /// </summary>
        /// <param name="input">Instance of InvoiceListItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InvoiceListItem input)
        {
            if (input == null)
                return false;

            return 
                (
<<<<<<< HEAD
                    this.ID == input.ID ||
                    (this.ID != null &&
                    this.ID.Equals(input.ID))
                ) && 
                (
=======
>>>>>>> 00a0f02ad3caf59a4284f6cc77ac538a3fc20070
                    this.Serie == input.Serie ||
                    (this.Serie != null &&
                    this.Serie.Equals(input.Serie))
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.Number == input.Number ||
                    (this.Number != null &&
                    this.Number.Equals(input.Number))
                ) && 
                (
                    this.UUID == input.UUID ||
                    (this.UUID != null &&
                    this.UUID.Equals(input.UUID))
                ) && 
                (
                    this.ExpirationDate == input.ExpirationDate ||
                    (this.ExpirationDate != null &&
                    this.ExpirationDate.Equals(input.ExpirationDate))
                ) && 
                (
                    this.ClientID == input.ClientID ||
                    (this.ClientID != null &&
                    this.ClientID.Equals(input.ClientID))
                ) && 
                (
                    this.ClientName == input.ClientName ||
                    (this.ClientName != null &&
                    this.ClientName.Equals(input.ClientName))
                ) && 
                (
                    this.RFC == input.RFC ||
                    (this.RFC != null &&
                    this.RFC.Equals(input.RFC))
                ) && 
                (
                    this.Cost == input.Cost ||
                    (this.Cost != null &&
                    this.Cost.Equals(input.Cost))
                ) && 
                (
                    this.Subtotal == input.Subtotal ||
                    (this.Subtotal != null &&
                    this.Subtotal.Equals(input.Subtotal))
                ) && 
                (
                    this.Discount == input.Discount ||
                    (this.Discount != null &&
                    this.Discount.Equals(input.Discount))
                ) && 
                (
                    this.VAT == input.VAT ||
                    (this.VAT != null &&
                    this.VAT.Equals(input.VAT))
                ) && 
                (
                    this.IEPS == input.IEPS ||
                    (this.IEPS != null &&
                    this.IEPS.Equals(input.IEPS))
                ) && 
                (
                    this.ISRRet == input.ISRRet ||
                    (this.ISRRet != null &&
                    this.ISRRet.Equals(input.ISRRet))
                ) && 
                (
                    this.VATRet == input.VATRet ||
                    (this.VATRet != null &&
                    this.VATRet.Equals(input.VATRet))
                ) && 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
                ) && 
                (
                    this.Payments == input.Payments ||
                    (this.Payments != null &&
                    this.Payments.Equals(input.Payments))
                ) && 
                (
                    this.CreditNotes == input.CreditNotes ||
                    (this.CreditNotes != null &&
                    this.CreditNotes.Equals(input.CreditNotes))
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
                    this.WarehouseID == input.WarehouseID ||
                    (this.WarehouseID != null &&
                    this.WarehouseID.Equals(input.WarehouseID))
                ) && 
                (
                    this.PriceListID == input.PriceListID ||
                    (this.PriceListID != null &&
                    this.PriceListID.Equals(input.PriceListID))
                ) && 
                (
<<<<<<< HEAD
=======
                    this.CFDIID == input.CFDIID ||
                    (this.CFDIID != null &&
                    this.CFDIID.Equals(input.CFDIID))
                ) && 
                (
>>>>>>> 00a0f02ad3caf59a4284f6cc77ac538a3fc20070
                    this.CFDIUse == input.CFDIUse ||
                    (this.CFDIUse != null &&
                    this.CFDIUse.Equals(input.CFDIUse))
                ) && 
                (
                    this.ExchangeRate == input.ExchangeRate ||
                    (this.ExchangeRate != null &&
                    this.ExchangeRate.Equals(input.ExchangeRate))
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
                    this.PurchaseOrder == input.PurchaseOrder ||
                    (this.PurchaseOrder != null &&
                    this.PurchaseOrder.Equals(input.PurchaseOrder))
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
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
<<<<<<< HEAD
                if (this.ID != null)
                    hashCode = hashCode * 59 + this.ID.GetHashCode();
=======
>>>>>>> 00a0f02ad3caf59a4284f6cc77ac538a3fc20070
                if (this.Serie != null)
                    hashCode = hashCode * 59 + this.Serie.GetHashCode();
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.Number != null)
                    hashCode = hashCode * 59 + this.Number.GetHashCode();
                if (this.UUID != null)
                    hashCode = hashCode * 59 + this.UUID.GetHashCode();
                if (this.ExpirationDate != null)
                    hashCode = hashCode * 59 + this.ExpirationDate.GetHashCode();
                if (this.ClientID != null)
                    hashCode = hashCode * 59 + this.ClientID.GetHashCode();
                if (this.ClientName != null)
                    hashCode = hashCode * 59 + this.ClientName.GetHashCode();
                if (this.RFC != null)
                    hashCode = hashCode * 59 + this.RFC.GetHashCode();
                if (this.Cost != null)
                    hashCode = hashCode * 59 + this.Cost.GetHashCode();
                if (this.Subtotal != null)
                    hashCode = hashCode * 59 + this.Subtotal.GetHashCode();
                if (this.Discount != null)
                    hashCode = hashCode * 59 + this.Discount.GetHashCode();
                if (this.VAT != null)
                    hashCode = hashCode * 59 + this.VAT.GetHashCode();
                if (this.IEPS != null)
                    hashCode = hashCode * 59 + this.IEPS.GetHashCode();
                if (this.ISRRet != null)
                    hashCode = hashCode * 59 + this.ISRRet.GetHashCode();
                if (this.VATRet != null)
                    hashCode = hashCode * 59 + this.VATRet.GetHashCode();
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.Payments != null)
                    hashCode = hashCode * 59 + this.Payments.GetHashCode();
                if (this.CreditNotes != null)
                    hashCode = hashCode * 59 + this.CreditNotes.GetHashCode();
                if (this.CurrencyID != null)
                    hashCode = hashCode * 59 + this.CurrencyID.GetHashCode();
                if (this.LocationID != null)
                    hashCode = hashCode * 59 + this.LocationID.GetHashCode();
                if (this.WarehouseID != null)
                    hashCode = hashCode * 59 + this.WarehouseID.GetHashCode();
                if (this.PriceListID != null)
                    hashCode = hashCode * 59 + this.PriceListID.GetHashCode();
<<<<<<< HEAD
=======
                if (this.CFDIID != null)
                    hashCode = hashCode * 59 + this.CFDIID.GetHashCode();
>>>>>>> 00a0f02ad3caf59a4284f6cc77ac538a3fc20070
                if (this.CFDIUse != null)
                    hashCode = hashCode * 59 + this.CFDIUse.GetHashCode();
                if (this.ExchangeRate != null)
                    hashCode = hashCode * 59 + this.ExchangeRate.GetHashCode();
                if (this.VATRetRate != null)
                    hashCode = hashCode * 59 + this.VATRetRate.GetHashCode();
                if (this.Comments != null)
                    hashCode = hashCode * 59 + this.Comments.GetHashCode();
                if (this.VATRate != null)
                    hashCode = hashCode * 59 + this.VATRate.GetHashCode();
                if (this.PurchaseOrder != null)
                    hashCode = hashCode * 59 + this.PurchaseOrder.GetHashCode();
                if (this.IsFiscalInvoice != null)
                    hashCode = hashCode * 59 + this.IsFiscalInvoice.GetHashCode();
                if (this.ShowIEPS != null)
                    hashCode = hashCode * 59 + this.ShowIEPS.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
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
