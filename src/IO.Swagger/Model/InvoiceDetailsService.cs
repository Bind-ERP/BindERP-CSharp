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
    /// InvoiceDetailsService
    /// </summary>
    [DataContract]
    public partial class InvoiceDetailsService :  IEquatable<InvoiceDetailsService>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceDetailsService" /> class.
        /// </summary>
        /// <param name="ID">ID.</param>
        /// <param name="IndexNumber">IndexNumber.</param>
        /// <param name="ServiceID">ServiceID.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Code">Code.</param>
        /// <param name="Qty">Qty.</param>
        /// <param name="Price">Price.</param>
        /// <param name="VATRate">VATRate.</param>
        /// <param name="Discount">Discount.</param>
        public InvoiceDetailsService(Guid? ID = default(Guid?), int? IndexNumber = default(int?), Guid? ServiceID = default(Guid?), string Name = default(string), string Code = default(string), double? Qty = default(double?), double? Price = default(double?), double? VATRate = default(double?), double? Discount = default(double?))
        {
            this.ID = ID;
            this.IndexNumber = IndexNumber;
            this.ServiceID = ServiceID;
            this.Name = Name;
            this.Code = Code;
            this.Qty = Qty;
            this.Price = Price;
            this.VATRate = VATRate;
            this.Discount = Discount;
        }
        
        /// <summary>
        /// Gets or Sets ID
        /// </summary>
        [DataMember(Name="ID", EmitDefaultValue=false)]
        public Guid? ID { get; set; }

        /// <summary>
        /// Gets or Sets IndexNumber
        /// </summary>
        [DataMember(Name="IndexNumber", EmitDefaultValue=false)]
        public int? IndexNumber { get; set; }

        /// <summary>
        /// Gets or Sets ServiceID
        /// </summary>
        [DataMember(Name="ServiceID", EmitDefaultValue=false)]
        public Guid? ServiceID { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name="Code", EmitDefaultValue=false)]
        public string Code { get; set; }

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
        /// Gets or Sets VATRate
        /// </summary>
        [DataMember(Name="VATRate", EmitDefaultValue=false)]
        public double? VATRate { get; set; }

        /// <summary>
        /// Gets or Sets Discount
        /// </summary>
        [DataMember(Name="Discount", EmitDefaultValue=false)]
        public double? Discount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InvoiceDetailsService {\n");
            sb.Append("  ID: ").Append(ID).Append("\n");
            sb.Append("  IndexNumber: ").Append(IndexNumber).Append("\n");
            sb.Append("  ServiceID: ").Append(ServiceID).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Qty: ").Append(Qty).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  VATRate: ").Append(VATRate).Append("\n");
            sb.Append("  Discount: ").Append(Discount).Append("\n");
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
            return this.Equals(input as InvoiceDetailsService);
        }

        /// <summary>
        /// Returns true if InvoiceDetailsService instances are equal
        /// </summary>
        /// <param name="input">Instance of InvoiceDetailsService to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InvoiceDetailsService input)
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
                    this.IndexNumber == input.IndexNumber ||
                    (this.IndexNumber != null &&
                    this.IndexNumber.Equals(input.IndexNumber))
                ) && 
                (
                    this.ServiceID == input.ServiceID ||
                    (this.ServiceID != null &&
                    this.ServiceID.Equals(input.ServiceID))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
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
                    this.VATRate == input.VATRate ||
                    (this.VATRate != null &&
                    this.VATRate.Equals(input.VATRate))
                ) && 
                (
                    this.Discount == input.Discount ||
                    (this.Discount != null &&
                    this.Discount.Equals(input.Discount))
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
                if (this.IndexNumber != null)
                    hashCode = hashCode * 59 + this.IndexNumber.GetHashCode();
                if (this.ServiceID != null)
                    hashCode = hashCode * 59 + this.ServiceID.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Qty != null)
                    hashCode = hashCode * 59 + this.Qty.GetHashCode();
                if (this.Price != null)
                    hashCode = hashCode * 59 + this.Price.GetHashCode();
                if (this.VATRate != null)
                    hashCode = hashCode * 59 + this.VATRate.GetHashCode();
                if (this.Discount != null)
                    hashCode = hashCode * 59 + this.Discount.GetHashCode();
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
