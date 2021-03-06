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
    /// OrderByClause
    /// </summary>
    [DataContract]
    public partial class OrderByClause :  IEquatable<OrderByClause>, IValidatableObject
    {
        /// <summary>
        /// Defines Direction
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DirectionEnum
        {
            
            /// <summary>
            /// Enum Ascending for value: Ascending
            /// </summary>
            [EnumMember(Value = "Ascending")]
            Ascending = 1,
            
            /// <summary>
            /// Enum Descending for value: Descending
            /// </summary>
            [EnumMember(Value = "Descending")]
            Descending = 2
        }

        /// <summary>
        /// Gets or Sets Direction
        /// </summary>
        [DataMember(Name="Direction", EmitDefaultValue=false)]
        public DirectionEnum? Direction { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderByClause" /> class.
        /// </summary>
        /// <param name="ThenBy">ThenBy.</param>
        /// <param name="Expression">Expression.</param>
        /// <param name="RangeVariable">RangeVariable.</param>
        /// <param name="ItemType">ItemType.</param>
        public OrderByClause(OrderByClause ThenBy = default(OrderByClause), SingleValueNode Expression = default(SingleValueNode), RangeVariable RangeVariable = default(RangeVariable), IEdmTypeReference ItemType = default(IEdmTypeReference))
        {
            this.ThenBy = ThenBy;
            this.Expression = Expression;
            this.RangeVariable = RangeVariable;
            this.ItemType = ItemType;
        }
        
        /// <summary>
        /// Gets or Sets ThenBy
        /// </summary>
        [DataMember(Name="ThenBy", EmitDefaultValue=false)]
        public OrderByClause ThenBy { get; set; }

        /// <summary>
        /// Gets or Sets Expression
        /// </summary>
        [DataMember(Name="Expression", EmitDefaultValue=false)]
        public SingleValueNode Expression { get; set; }


        /// <summary>
        /// Gets or Sets RangeVariable
        /// </summary>
        [DataMember(Name="RangeVariable", EmitDefaultValue=false)]
        public RangeVariable RangeVariable { get; set; }

        /// <summary>
        /// Gets or Sets ItemType
        /// </summary>
        [DataMember(Name="ItemType", EmitDefaultValue=false)]
        public IEdmTypeReference ItemType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderByClause {\n");
            sb.Append("  ThenBy: ").Append(ThenBy).Append("\n");
            sb.Append("  Expression: ").Append(Expression).Append("\n");
            sb.Append("  Direction: ").Append(Direction).Append("\n");
            sb.Append("  RangeVariable: ").Append(RangeVariable).Append("\n");
            sb.Append("  ItemType: ").Append(ItemType).Append("\n");
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
            return this.Equals(input as OrderByClause);
        }

        /// <summary>
        /// Returns true if OrderByClause instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderByClause to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderByClause input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ThenBy == input.ThenBy ||
                    (this.ThenBy != null &&
                    this.ThenBy.Equals(input.ThenBy))
                ) && 
                (
                    this.Expression == input.Expression ||
                    (this.Expression != null &&
                    this.Expression.Equals(input.Expression))
                ) && 
                (
                    this.Direction == input.Direction ||
                    (this.Direction != null &&
                    this.Direction.Equals(input.Direction))
                ) && 
                (
                    this.RangeVariable == input.RangeVariable ||
                    (this.RangeVariable != null &&
                    this.RangeVariable.Equals(input.RangeVariable))
                ) && 
                (
                    this.ItemType == input.ItemType ||
                    (this.ItemType != null &&
                    this.ItemType.Equals(input.ItemType))
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
                if (this.ThenBy != null)
                    hashCode = hashCode * 59 + this.ThenBy.GetHashCode();
                if (this.Expression != null)
                    hashCode = hashCode * 59 + this.Expression.GetHashCode();
                if (this.Direction != null)
                    hashCode = hashCode * 59 + this.Direction.GetHashCode();
                if (this.RangeVariable != null)
                    hashCode = hashCode * 59 + this.RangeVariable.GetHashCode();
                if (this.ItemType != null)
                    hashCode = hashCode * 59 + this.ItemType.GetHashCode();
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
