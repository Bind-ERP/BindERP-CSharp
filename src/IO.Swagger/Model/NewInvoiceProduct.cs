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
    /// NewInvoiceProduct
    /// </summary>
    [DataContract]
    public partial class NewInvoiceProduct :  IEquatable<NewInvoiceProduct>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NewInvoiceProduct" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NewInvoiceProduct() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NewInvoiceProduct" /> class.
        /// </summary>
        /// <param name="ID">ID (required).</param>
        /// <param name="Price">Price (required).</param>
        /// <param name="VAT">VAT.</param>
        /// <param name="IndexNumber">IndexNumber.</param>
        /// <param name="IEPS">IEPS.</param>
        /// <param name="IEPSType">IEPSType.</param>
        /// <param name="Qty">Qty (required).</param>
        /// <param name="Comments">Comments.</param>
        /// <param name="VATExempt">VATExempt.</param>
        /// <param name="RequireLot">RequireLot.</param>
        /// <param name="SelectedImports">SelectedImports.</param>
        /// <param name="OrderItemID">OrderItemID.</param>
        /// <param name="Unit">Unit.</param>
        public NewInvoiceProduct(Guid? ID = default(Guid?), double? Price = default(double?), double? VAT = default(double?), int? IndexNumber = default(int?), double? IEPS = default(double?), int? IEPSType = default(int?), double? Qty = default(double?), string Comments = default(string), bool? VATExempt = default(bool?), bool? RequireLot = default(bool?), List<Guid?> SelectedImports = default(List<Guid?>), Guid? OrderItemID = default(Guid?), string Unit = default(string))
        {
            // to ensure "ID" is required (not null)
            if (ID == null)
            {
                throw new InvalidDataException("ID is a required property for NewInvoiceProduct and cannot be null");
            }
            else
            {
                this.ID = ID;
            }
            // to ensure "Price" is required (not null)
            if (Price == null)
            {
                throw new InvalidDataException("Price is a required property for NewInvoiceProduct and cannot be null");
            }
            else
            {
                this.Price = Price;
            }
            // to ensure "Qty" is required (not null)
            if (Qty == null)
            {
                throw new InvalidDataException("Qty is a required property for NewInvoiceProduct and cannot be null");
            }
            else
            {
                this.Qty = Qty;
            }
            this.VAT = VAT;
            this.IndexNumber = IndexNumber;
            this.IEPS = IEPS;
            this.IEPSType = IEPSType;
            this.Comments = Comments;
            this.VATExempt = VATExempt;
            this.RequireLot = RequireLot;
            this.SelectedImports = SelectedImports;
            this.OrderItemID = OrderItemID;
            this.Unit = Unit;
        }
        
        /// <summary>
        /// Gets or Sets ID
        /// </summary>
        [DataMember(Name="ID", EmitDefaultValue=false)]
        public Guid? ID { get; set; }

        /// <summary>
        /// Gets or Sets Price
        /// </summary>
        [DataMember(Name="Price", EmitDefaultValue=false)]
        public double? Price { get; set; }

        /// <summary>
        /// Gets or Sets VAT
        /// </summary>
        [DataMember(Name="VAT", EmitDefaultValue=false)]
        public double? VAT { get; set; }

        /// <summary>
        /// Gets or Sets IndexNumber
        /// </summary>
        [DataMember(Name="IndexNumber", EmitDefaultValue=false)]
        public int? IndexNumber { get; set; }

        /// <summary>
        /// Gets or Sets IEPS
        /// </summary>
        [DataMember(Name="IEPS", EmitDefaultValue=false)]
        public double? IEPS { get; set; }

        /// <summary>
        /// Gets or Sets IEPSType
        /// </summary>
        [DataMember(Name="IEPSType", EmitDefaultValue=false)]
        public int? IEPSType { get; set; }

        /// <summary>
        /// Gets or Sets Qty
        /// </summary>
        [DataMember(Name="Qty", EmitDefaultValue=false)]
        public double? Qty { get; set; }

        /// <summary>
        /// Gets or Sets Comments
        /// </summary>
        [DataMember(Name="Comments", EmitDefaultValue=false)]
        public string Comments { get; set; }

        /// <summary>
        /// Gets or Sets VATExempt
        /// </summary>
        [DataMember(Name="VATExempt", EmitDefaultValue=false)]
        public bool? VATExempt { get; set; }

        /// <summary>
        /// Gets or Sets RequireLot
        /// </summary>
        [DataMember(Name="RequireLot", EmitDefaultValue=false)]
        public bool? RequireLot { get; set; }

        /// <summary>
        /// Gets or Sets SelectedImports
        /// </summary>
        [DataMember(Name="SelectedImports", EmitDefaultValue=false)]
        public List<Guid?> SelectedImports { get; set; }

        /// <summary>
        /// Gets or Sets OrderItemID
        /// </summary>
        [DataMember(Name="OrderItemID", EmitDefaultValue=false)]
        public Guid? OrderItemID { get; set; }

        /// <summary>
        /// Gets or Sets Unit
        /// </summary>
        [DataMember(Name="Unit", EmitDefaultValue=false)]
        public string Unit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NewInvoiceProduct {\n");
            sb.Append("  ID: ").Append(ID).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  VAT: ").Append(VAT).Append("\n");
            sb.Append("  IndexNumber: ").Append(IndexNumber).Append("\n");
            sb.Append("  IEPS: ").Append(IEPS).Append("\n");
            sb.Append("  IEPSType: ").Append(IEPSType).Append("\n");
            sb.Append("  Qty: ").Append(Qty).Append("\n");
            sb.Append("  Comments: ").Append(Comments).Append("\n");
            sb.Append("  VATExempt: ").Append(VATExempt).Append("\n");
            sb.Append("  RequireLot: ").Append(RequireLot).Append("\n");
            sb.Append("  SelectedImports: ").Append(SelectedImports).Append("\n");
            sb.Append("  OrderItemID: ").Append(OrderItemID).Append("\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
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
            return this.Equals(input as NewInvoiceProduct);
        }

        /// <summary>
        /// Returns true if NewInvoiceProduct instances are equal
        /// </summary>
        /// <param name="input">Instance of NewInvoiceProduct to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NewInvoiceProduct input)
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
                    this.Price == input.Price ||
                    (this.Price != null &&
                    this.Price.Equals(input.Price))
                ) && 
                (
                    this.VAT == input.VAT ||
                    (this.VAT != null &&
                    this.VAT.Equals(input.VAT))
                ) && 
                (
                    this.IndexNumber == input.IndexNumber ||
                    (this.IndexNumber != null &&
                    this.IndexNumber.Equals(input.IndexNumber))
                ) && 
                (
                    this.IEPS == input.IEPS ||
                    (this.IEPS != null &&
                    this.IEPS.Equals(input.IEPS))
                ) && 
                (
                    this.IEPSType == input.IEPSType ||
                    (this.IEPSType != null &&
                    this.IEPSType.Equals(input.IEPSType))
                ) && 
                (
                    this.Qty == input.Qty ||
                    (this.Qty != null &&
                    this.Qty.Equals(input.Qty))
                ) && 
                (
                    this.Comments == input.Comments ||
                    (this.Comments != null &&
                    this.Comments.Equals(input.Comments))
                ) && 
                (
                    this.VATExempt == input.VATExempt ||
                    (this.VATExempt != null &&
                    this.VATExempt.Equals(input.VATExempt))
                ) && 
                (
                    this.RequireLot == input.RequireLot ||
                    (this.RequireLot != null &&
                    this.RequireLot.Equals(input.RequireLot))
                ) && 
                (
                    this.SelectedImports == input.SelectedImports ||
                    this.SelectedImports != null &&
                    this.SelectedImports.SequenceEqual(input.SelectedImports)
                ) && 
                (
                    this.OrderItemID == input.OrderItemID ||
                    (this.OrderItemID != null &&
                    this.OrderItemID.Equals(input.OrderItemID))
                ) && 
                (
                    this.Unit == input.Unit ||
                    (this.Unit != null &&
                    this.Unit.Equals(input.Unit))
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
                if (this.Price != null)
                    hashCode = hashCode * 59 + this.Price.GetHashCode();
                if (this.VAT != null)
                    hashCode = hashCode * 59 + this.VAT.GetHashCode();
                if (this.IndexNumber != null)
                    hashCode = hashCode * 59 + this.IndexNumber.GetHashCode();
                if (this.IEPS != null)
                    hashCode = hashCode * 59 + this.IEPS.GetHashCode();
                if (this.IEPSType != null)
                    hashCode = hashCode * 59 + this.IEPSType.GetHashCode();
                if (this.Qty != null)
                    hashCode = hashCode * 59 + this.Qty.GetHashCode();
                if (this.Comments != null)
                    hashCode = hashCode * 59 + this.Comments.GetHashCode();
                if (this.VATExempt != null)
                    hashCode = hashCode * 59 + this.VATExempt.GetHashCode();
                if (this.RequireLot != null)
                    hashCode = hashCode * 59 + this.RequireLot.GetHashCode();
                if (this.SelectedImports != null)
                    hashCode = hashCode * 59 + this.SelectedImports.GetHashCode();
                if (this.OrderItemID != null)
                    hashCode = hashCode * 59 + this.OrderItemID.GetHashCode();
                if (this.Unit != null)
                    hashCode = hashCode * 59 + this.Unit.GetHashCode();
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