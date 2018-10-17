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
    /// IEdmSchemaElement
    /// </summary>
    [DataContract]
    public partial class IEdmSchemaElement :  IEquatable<IEdmSchemaElement>, IValidatableObject
    {
        /// <summary>
        /// Defines SchemaElementKind
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SchemaElementKindEnum
        {
            
            /// <summary>
            /// Enum None for value: None
            /// </summary>
            [EnumMember(Value = "None")]
            None = 1,
            
            /// <summary>
            /// Enum TypeDefinition for value: TypeDefinition
            /// </summary>
            [EnumMember(Value = "TypeDefinition")]
            TypeDefinition = 2,
            
            /// <summary>
            /// Enum Function for value: Function
            /// </summary>
            [EnumMember(Value = "Function")]
            Function = 3,
            
            /// <summary>
            /// Enum ValueTerm for value: ValueTerm
            /// </summary>
            [EnumMember(Value = "ValueTerm")]
            ValueTerm = 4,
            
            /// <summary>
            /// Enum EntityContainer for value: EntityContainer
            /// </summary>
            [EnumMember(Value = "EntityContainer")]
            EntityContainer = 5
        }

        /// <summary>
        /// Gets or Sets SchemaElementKind
        /// </summary>
        [DataMember(Name="SchemaElementKind", EmitDefaultValue=false)]
        public SchemaElementKindEnum? SchemaElementKind { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="IEdmSchemaElement" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public IEdmSchemaElement()
        {
        }
        

        /// <summary>
        /// Gets or Sets _Namespace
        /// </summary>
        [DataMember(Name="Namespace", EmitDefaultValue=false)]
        public string _Namespace { get; private set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IEdmSchemaElement {\n");
            sb.Append("  SchemaElementKind: ").Append(SchemaElementKind).Append("\n");
            sb.Append("  _Namespace: ").Append(_Namespace).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as IEdmSchemaElement);
        }

        /// <summary>
        /// Returns true if IEdmSchemaElement instances are equal
        /// </summary>
        /// <param name="input">Instance of IEdmSchemaElement to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IEdmSchemaElement input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SchemaElementKind == input.SchemaElementKind ||
                    (this.SchemaElementKind != null &&
                    this.SchemaElementKind.Equals(input.SchemaElementKind))
                ) && 
                (
                    this._Namespace == input._Namespace ||
                    (this._Namespace != null &&
                    this._Namespace.Equals(input._Namespace))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.SchemaElementKind != null)
                    hashCode = hashCode * 59 + this.SchemaElementKind.GetHashCode();
                if (this._Namespace != null)
                    hashCode = hashCode * 59 + this._Namespace.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
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
