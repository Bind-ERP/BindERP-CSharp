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
    /// NewComment
    /// </summary>
    [DataContract]
    public partial class NewComment :  IEquatable<NewComment>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NewComment" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NewComment() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NewComment" /> class.
        /// </summary>
        /// <param name="ExternalID">ExternalID (required).</param>
        /// <param name="Comment">Comment (required).</param>
        public NewComment(Guid? ExternalID = default(Guid?), string Comment = default(string))
        {
            // to ensure "ExternalID" is required (not null)
            if (ExternalID == null)
            {
                throw new InvalidDataException("ExternalID is a required property for NewComment and cannot be null");
            }
            else
            {
                this.ExternalID = ExternalID;
            }
            // to ensure "Comment" is required (not null)
            if (Comment == null)
            {
                throw new InvalidDataException("Comment is a required property for NewComment and cannot be null");
            }
            else
            {
                this.Comment = Comment;
            }
        }
        
        /// <summary>
        /// Gets or Sets ExternalID
        /// </summary>
        [DataMember(Name="ExternalID", EmitDefaultValue=false)]
        public Guid? ExternalID { get; set; }

        /// <summary>
        /// Gets or Sets Comment
        /// </summary>
        [DataMember(Name="Comment", EmitDefaultValue=false)]
        public string Comment { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NewComment {\n");
            sb.Append("  ExternalID: ").Append(ExternalID).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
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
            return this.Equals(input as NewComment);
        }

        /// <summary>
        /// Returns true if NewComment instances are equal
        /// </summary>
        /// <param name="input">Instance of NewComment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NewComment input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ExternalID == input.ExternalID ||
                    (this.ExternalID != null &&
                    this.ExternalID.Equals(input.ExternalID))
                ) && 
                (
                    this.Comment == input.Comment ||
                    (this.Comment != null &&
                    this.Comment.Equals(input.Comment))
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
                if (this.ExternalID != null)
                    hashCode = hashCode * 59 + this.ExternalID.GetHashCode();
                if (this.Comment != null)
                    hashCode = hashCode * 59 + this.Comment.GetHashCode();
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
