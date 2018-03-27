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
    /// IEdmVocabularyAnnotation
    /// </summary>
    [DataContract]
    public partial class IEdmVocabularyAnnotation :  IEquatable<IEdmVocabularyAnnotation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IEdmVocabularyAnnotation" /> class.
        /// </summary>
        /// <param name="Term">Term.</param>
        /// <param name="Target">Target.</param>
        public IEdmVocabularyAnnotation(IEdmTerm Term = default(IEdmTerm), IEdmVocabularyAnnotatable Target = default(IEdmVocabularyAnnotatable))
        {
            this.Term = Term;
            this.Target = Target;
        }
        
        /// <summary>
        /// Gets or Sets Qualifier
        /// </summary>
        [DataMember(Name="Qualifier", EmitDefaultValue=false)]
        public string Qualifier { get; private set; }

        /// <summary>
        /// Gets or Sets Term
        /// </summary>
        [DataMember(Name="Term", EmitDefaultValue=false)]
        public IEdmTerm Term { get; set; }

        /// <summary>
        /// Gets or Sets Target
        /// </summary>
        [DataMember(Name="Target", EmitDefaultValue=false)]
        public IEdmVocabularyAnnotatable Target { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IEdmVocabularyAnnotation {\n");
            sb.Append("  Qualifier: ").Append(Qualifier).Append("\n");
            sb.Append("  Term: ").Append(Term).Append("\n");
            sb.Append("  Target: ").Append(Target).Append("\n");
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
            return this.Equals(input as IEdmVocabularyAnnotation);
        }

        /// <summary>
        /// Returns true if IEdmVocabularyAnnotation instances are equal
        /// </summary>
        /// <param name="input">Instance of IEdmVocabularyAnnotation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IEdmVocabularyAnnotation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Qualifier == input.Qualifier ||
                    (this.Qualifier != null &&
                    this.Qualifier.Equals(input.Qualifier))
                ) && 
                (
                    this.Term == input.Term ||
                    (this.Term != null &&
                    this.Term.Equals(input.Term))
                ) && 
                (
                    this.Target == input.Target ||
                    (this.Target != null &&
                    this.Target.Equals(input.Target))
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
                if (this.Qualifier != null)
                    hashCode = hashCode * 59 + this.Qualifier.GetHashCode();
                if (this.Term != null)
                    hashCode = hashCode * 59 + this.Term.GetHashCode();
                if (this.Target != null)
                    hashCode = hashCode * 59 + this.Target.GetHashCode();
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