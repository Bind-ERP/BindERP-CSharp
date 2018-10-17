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
    /// TopQueryOption
    /// </summary>
    [DataContract]
    public partial class TopQueryOption :  IEquatable<TopQueryOption>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TopQueryOption" /> class.
        /// </summary>
        /// <param name="Context">Context.</param>
        /// <param name="Validator">Validator.</param>
        public TopQueryOption(ODataQueryContext Context = default(ODataQueryContext), TopQueryValidator Validator = default(TopQueryValidator))
        {
            this.Context = Context;
            this.Validator = Validator;
        }
        
        /// <summary>
        /// Gets or Sets Context
        /// </summary>
        [DataMember(Name="Context", EmitDefaultValue=false)]
        public ODataQueryContext Context { get; set; }

        /// <summary>
        /// Gets or Sets RawValue
        /// </summary>
        [DataMember(Name="RawValue", EmitDefaultValue=false)]
        public string RawValue { get; private set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="Value", EmitDefaultValue=false)]
        public int? Value { get; private set; }

        /// <summary>
        /// Gets or Sets Validator
        /// </summary>
        [DataMember(Name="Validator", EmitDefaultValue=false)]
        public TopQueryValidator Validator { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TopQueryOption {\n");
            sb.Append("  Context: ").Append(Context).Append("\n");
            sb.Append("  RawValue: ").Append(RawValue).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Validator: ").Append(Validator).Append("\n");
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
            return this.Equals(input as TopQueryOption);
        }

        /// <summary>
        /// Returns true if TopQueryOption instances are equal
        /// </summary>
        /// <param name="input">Instance of TopQueryOption to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TopQueryOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Context == input.Context ||
                    (this.Context != null &&
                    this.Context.Equals(input.Context))
                ) && 
                (
                    this.RawValue == input.RawValue ||
                    (this.RawValue != null &&
                    this.RawValue.Equals(input.RawValue))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.Validator == input.Validator ||
                    (this.Validator != null &&
                    this.Validator.Equals(input.Validator))
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
                if (this.Context != null)
                    hashCode = hashCode * 59 + this.Context.GetHashCode();
                if (this.RawValue != null)
                    hashCode = hashCode * 59 + this.RawValue.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.Validator != null)
                    hashCode = hashCode * 59 + this.Validator.GetHashCode();
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
