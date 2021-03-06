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
    /// OrderDetailsProduct
    /// </summary>
    [DataContract]
    public partial class OrderDetailsProduct :  IEquatable<OrderDetailsProduct>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderDetailsProduct" /> class.
        /// </summary>
        /// <param name="ProductID">ProductID.</param>
        /// <param name="Name">Name.</param>
        /// <param name="IndexNumber">IndexNumber.</param>
        /// <param name="Code">Code.</param>
        /// <param name="Unit">Unit.</param>
        /// <param name="UnitMultiplier">UnitMultiplier.</param>
        /// <param name="Qty">Qty.</param>
        /// <param name="Price">Price.</param>
        /// <param name="IEPSRate">IEPSRate.</param>
        /// <param name="Comments">Comments.</param>
        public OrderDetailsProduct(Guid? ProductID = default(Guid?), string Name = default(string), int? IndexNumber = default(int?), string Code = default(string), string Unit = default(string), double? UnitMultiplier = default(double?), double? Qty = default(double?), double? Price = default(double?), double? IEPSRate = default(double?), string Comments = default(string))
        {
            this.ProductID = ProductID;
            this.Name = Name;
            this.IndexNumber = IndexNumber;
            this.Code = Code;
            this.Unit = Unit;
            this.UnitMultiplier = UnitMultiplier;
            this.Qty = Qty;
            this.Price = Price;
            this.IEPSRate = IEPSRate;
            this.Comments = Comments;
        }
        
        /// <summary>
        /// Gets or Sets ProductID
        /// </summary>
        [DataMember(Name="ProductID", EmitDefaultValue=false)]
        public Guid? ProductID { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets IndexNumber
        /// </summary>
        [DataMember(Name="IndexNumber", EmitDefaultValue=false)]
        public int? IndexNumber { get; set; }

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name="Code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets Unit
        /// </summary>
        [DataMember(Name="Unit", EmitDefaultValue=false)]
        public string Unit { get; set; }

        /// <summary>
        /// Gets or Sets UnitMultiplier
        /// </summary>
        [DataMember(Name="UnitMultiplier", EmitDefaultValue=false)]
        public double? UnitMultiplier { get; set; }

        /// <summary>
        /// Gets or Sets Qty
        /// </summary>
        [DataMember(Name="Qty", EmitDefaultValue=false)]
        public double? Qty { get; set; }

        /// <summary>
        /// Gets or Sets Price
        /// </summary>
        [DataMember(Name="Price", EmitDefaultValue=false)]
        public double? Price { get; set; }

        /// <summary>
        /// Gets or Sets IEPSRate
        /// </summary>
        [DataMember(Name="IEPSRate", EmitDefaultValue=false)]
        public double? IEPSRate { get; set; }

        /// <summary>
        /// Gets or Sets Comments
        /// </summary>
        [DataMember(Name="Comments", EmitDefaultValue=false)]
        public string Comments { get; set; }

        /// <summary>
        /// Gets or Sets QtyFullFilled
        /// </summary>
        [DataMember(Name="QtyFullFilled", EmitDefaultValue=false)]
        public double? QtyFullFilled { get; private set; }

        /// <summary>
        /// Gets or Sets VATRate
        /// </summary>
        [DataMember(Name="VATRate", EmitDefaultValue=false)]
        public double? VATRate { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderDetailsProduct {\n");
            sb.Append("  ProductID: ").Append(ProductID).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  IndexNumber: ").Append(IndexNumber).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
            sb.Append("  UnitMultiplier: ").Append(UnitMultiplier).Append("\n");
            sb.Append("  Qty: ").Append(Qty).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  IEPSRate: ").Append(IEPSRate).Append("\n");
            sb.Append("  Comments: ").Append(Comments).Append("\n");
            sb.Append("  QtyFullFilled: ").Append(QtyFullFilled).Append("\n");
            sb.Append("  VATRate: ").Append(VATRate).Append("\n");
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
            return this.Equals(input as OrderDetailsProduct);
        }

        /// <summary>
        /// Returns true if OrderDetailsProduct instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderDetailsProduct to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderDetailsProduct input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProductID == input.ProductID ||
                    (this.ProductID != null &&
                    this.ProductID.Equals(input.ProductID))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.IndexNumber == input.IndexNumber ||
                    (this.IndexNumber != null &&
                    this.IndexNumber.Equals(input.IndexNumber))
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Unit == input.Unit ||
                    (this.Unit != null &&
                    this.Unit.Equals(input.Unit))
                ) && 
                (
                    this.UnitMultiplier == input.UnitMultiplier ||
                    (this.UnitMultiplier != null &&
                    this.UnitMultiplier.Equals(input.UnitMultiplier))
                ) && 
                (
                    this.Qty == input.Qty ||
                    (this.Qty != null &&
                    this.Qty.Equals(input.Qty))
                ) && 
                (
                    this.Price == input.Price ||
                    (this.Price != null &&
                    this.Price.Equals(input.Price))
                ) && 
                (
                    this.IEPSRate == input.IEPSRate ||
                    (this.IEPSRate != null &&
                    this.IEPSRate.Equals(input.IEPSRate))
                ) && 
                (
                    this.Comments == input.Comments ||
                    (this.Comments != null &&
                    this.Comments.Equals(input.Comments))
                ) && 
                (
                    this.QtyFullFilled == input.QtyFullFilled ||
                    (this.QtyFullFilled != null &&
                    this.QtyFullFilled.Equals(input.QtyFullFilled))
                ) && 
                (
                    this.VATRate == input.VATRate ||
                    (this.VATRate != null &&
                    this.VATRate.Equals(input.VATRate))
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
                if (this.ProductID != null)
                    hashCode = hashCode * 59 + this.ProductID.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.IndexNumber != null)
                    hashCode = hashCode * 59 + this.IndexNumber.GetHashCode();
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Unit != null)
                    hashCode = hashCode * 59 + this.Unit.GetHashCode();
                if (this.UnitMultiplier != null)
                    hashCode = hashCode * 59 + this.UnitMultiplier.GetHashCode();
                if (this.Qty != null)
                    hashCode = hashCode * 59 + this.Qty.GetHashCode();
                if (this.Price != null)
                    hashCode = hashCode * 59 + this.Price.GetHashCode();
                if (this.IEPSRate != null)
                    hashCode = hashCode * 59 + this.IEPSRate.GetHashCode();
                if (this.Comments != null)
                    hashCode = hashCode * 59 + this.Comments.GetHashCode();
                if (this.QtyFullFilled != null)
                    hashCode = hashCode * 59 + this.QtyFullFilled.GetHashCode();
                if (this.VATRate != null)
                    hashCode = hashCode * 59 + this.VATRate.GetHashCode();
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
