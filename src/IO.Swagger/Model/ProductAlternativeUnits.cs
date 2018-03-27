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
    /// ProductAlternativeUnits
    /// </summary>
    [DataContract]
    public partial class ProductAlternativeUnits :  IEquatable<ProductAlternativeUnits>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductAlternativeUnits" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Multiplier">Multiplier.</param>
        /// <param name="SalesUnit">SalesUnit.</param>
        /// <param name="PurchaseUnit">PurchaseUnit.</param>
        public ProductAlternativeUnits(string Name = default(string), double? Multiplier = default(double?), bool? SalesUnit = default(bool?), bool? PurchaseUnit = default(bool?))
        {
            this.Name = Name;
            this.Multiplier = Multiplier;
            this.SalesUnit = SalesUnit;
            this.PurchaseUnit = PurchaseUnit;
        }
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Multiplier
        /// </summary>
        [DataMember(Name="Multiplier", EmitDefaultValue=false)]
        public double? Multiplier { get; set; }

        /// <summary>
        /// Gets or Sets SalesUnit
        /// </summary>
        [DataMember(Name="SalesUnit", EmitDefaultValue=false)]
        public bool? SalesUnit { get; set; }

        /// <summary>
        /// Gets or Sets PurchaseUnit
        /// </summary>
        [DataMember(Name="PurchaseUnit", EmitDefaultValue=false)]
        public bool? PurchaseUnit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductAlternativeUnits {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Multiplier: ").Append(Multiplier).Append("\n");
            sb.Append("  SalesUnit: ").Append(SalesUnit).Append("\n");
            sb.Append("  PurchaseUnit: ").Append(PurchaseUnit).Append("\n");
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
            return this.Equals(input as ProductAlternativeUnits);
        }

        /// <summary>
        /// Returns true if ProductAlternativeUnits instances are equal
        /// </summary>
        /// <param name="input">Instance of ProductAlternativeUnits to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductAlternativeUnits input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Multiplier == input.Multiplier ||
                    (this.Multiplier != null &&
                    this.Multiplier.Equals(input.Multiplier))
                ) && 
                (
                    this.SalesUnit == input.SalesUnit ||
                    (this.SalesUnit != null &&
                    this.SalesUnit.Equals(input.SalesUnit))
                ) && 
                (
                    this.PurchaseUnit == input.PurchaseUnit ||
                    (this.PurchaseUnit != null &&
                    this.PurchaseUnit.Equals(input.PurchaseUnit))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Multiplier != null)
                    hashCode = hashCode * 59 + this.Multiplier.GetHashCode();
                if (this.SalesUnit != null)
                    hashCode = hashCode * 59 + this.SalesUnit.GetHashCode();
                if (this.PurchaseUnit != null)
                    hashCode = hashCode * 59 + this.PurchaseUnit.GetHashCode();
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
