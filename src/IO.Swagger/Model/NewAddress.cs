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
    /// NewAddress
    /// </summary>
    [DataContract]
    public partial class NewAddress :  IEquatable<NewAddress>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NewAddress" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NewAddress() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NewAddress" /> class.
        /// </summary>
        /// <param name="StreetName">StreetName (required).</param>
        /// <param name="InteriorNumber">InteriorNumber.</param>
        /// <param name="ExteriorNumber">ExteriorNumber (required).</param>
        /// <param name="Colonia">Colonia (required).</param>
        /// <param name="Comments">Comments.</param>
        /// <param name="ZipCode">ZipCode (required).</param>
        /// <param name="Localidad">Localidad.</param>
        /// <param name="City">City (required).</param>
        /// <param name="State">State (required).</param>
        public NewAddress(string StreetName = default(string), string InteriorNumber = default(string), string ExteriorNumber = default(string), string Colonia = default(string), string Comments = default(string), string ZipCode = default(string), string Localidad = default(string), string City = default(string), string State = default(string))
        {
            // to ensure "StreetName" is required (not null)
            if (StreetName == null)
            {
                throw new InvalidDataException("StreetName is a required property for NewAddress and cannot be null");
            }
            else
            {
                this.StreetName = StreetName;
            }
            // to ensure "ExteriorNumber" is required (not null)
            if (ExteriorNumber == null)
            {
                throw new InvalidDataException("ExteriorNumber is a required property for NewAddress and cannot be null");
            }
            else
            {
                this.ExteriorNumber = ExteriorNumber;
            }
            // to ensure "Colonia" is required (not null)
            if (Colonia == null)
            {
                throw new InvalidDataException("Colonia is a required property for NewAddress and cannot be null");
            }
            else
            {
                this.Colonia = Colonia;
            }
            // to ensure "ZipCode" is required (not null)
            if (ZipCode == null)
            {
                throw new InvalidDataException("ZipCode is a required property for NewAddress and cannot be null");
            }
            else
            {
                this.ZipCode = ZipCode;
            }
            // to ensure "City" is required (not null)
            if (City == null)
            {
                throw new InvalidDataException("City is a required property for NewAddress and cannot be null");
            }
            else
            {
                this.City = City;
            }
            // to ensure "State" is required (not null)
            if (State == null)
            {
                throw new InvalidDataException("State is a required property for NewAddress and cannot be null");
            }
            else
            {
                this.State = State;
            }
            this.InteriorNumber = InteriorNumber;
            this.Comments = Comments;
            this.Localidad = Localidad;
        }
        
        /// <summary>
        /// Gets or Sets StreetName
        /// </summary>
        [DataMember(Name="StreetName", EmitDefaultValue=false)]
        public string StreetName { get; set; }

        /// <summary>
        /// Gets or Sets InteriorNumber
        /// </summary>
        [DataMember(Name="InteriorNumber", EmitDefaultValue=false)]
        public string InteriorNumber { get; set; }

        /// <summary>
        /// Gets or Sets ExteriorNumber
        /// </summary>
        [DataMember(Name="ExteriorNumber", EmitDefaultValue=false)]
        public string ExteriorNumber { get; set; }

        /// <summary>
        /// Gets or Sets Colonia
        /// </summary>
        [DataMember(Name="Colonia", EmitDefaultValue=false)]
        public string Colonia { get; set; }

        /// <summary>
        /// Gets or Sets Comments
        /// </summary>
        [DataMember(Name="Comments", EmitDefaultValue=false)]
        public string Comments { get; set; }

        /// <summary>
        /// Gets or Sets ZipCode
        /// </summary>
        [DataMember(Name="ZipCode", EmitDefaultValue=false)]
        public string ZipCode { get; set; }

        /// <summary>
        /// Gets or Sets Localidad
        /// </summary>
        [DataMember(Name="Localidad", EmitDefaultValue=false)]
        public string Localidad { get; set; }

        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name="City", EmitDefaultValue=false)]
        public string City { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="State", EmitDefaultValue=false)]
        public string State { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NewAddress {\n");
            sb.Append("  StreetName: ").Append(StreetName).Append("\n");
            sb.Append("  InteriorNumber: ").Append(InteriorNumber).Append("\n");
            sb.Append("  ExteriorNumber: ").Append(ExteriorNumber).Append("\n");
            sb.Append("  Colonia: ").Append(Colonia).Append("\n");
            sb.Append("  Comments: ").Append(Comments).Append("\n");
            sb.Append("  ZipCode: ").Append(ZipCode).Append("\n");
            sb.Append("  Localidad: ").Append(Localidad).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
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
            return this.Equals(input as NewAddress);
        }

        /// <summary>
        /// Returns true if NewAddress instances are equal
        /// </summary>
        /// <param name="input">Instance of NewAddress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NewAddress input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StreetName == input.StreetName ||
                    (this.StreetName != null &&
                    this.StreetName.Equals(input.StreetName))
                ) && 
                (
                    this.InteriorNumber == input.InteriorNumber ||
                    (this.InteriorNumber != null &&
                    this.InteriorNumber.Equals(input.InteriorNumber))
                ) && 
                (
                    this.ExteriorNumber == input.ExteriorNumber ||
                    (this.ExteriorNumber != null &&
                    this.ExteriorNumber.Equals(input.ExteriorNumber))
                ) && 
                (
                    this.Colonia == input.Colonia ||
                    (this.Colonia != null &&
                    this.Colonia.Equals(input.Colonia))
                ) && 
                (
                    this.Comments == input.Comments ||
                    (this.Comments != null &&
                    this.Comments.Equals(input.Comments))
                ) && 
                (
                    this.ZipCode == input.ZipCode ||
                    (this.ZipCode != null &&
                    this.ZipCode.Equals(input.ZipCode))
                ) && 
                (
                    this.Localidad == input.Localidad ||
                    (this.Localidad != null &&
                    this.Localidad.Equals(input.Localidad))
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
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
                if (this.StreetName != null)
                    hashCode = hashCode * 59 + this.StreetName.GetHashCode();
                if (this.InteriorNumber != null)
                    hashCode = hashCode * 59 + this.InteriorNumber.GetHashCode();
                if (this.ExteriorNumber != null)
                    hashCode = hashCode * 59 + this.ExteriorNumber.GetHashCode();
                if (this.Colonia != null)
                    hashCode = hashCode * 59 + this.Colonia.GetHashCode();
                if (this.Comments != null)
                    hashCode = hashCode * 59 + this.Comments.GetHashCode();
                if (this.ZipCode != null)
                    hashCode = hashCode * 59 + this.ZipCode.GetHashCode();
                if (this.Localidad != null)
                    hashCode = hashCode * 59 + this.Localidad.GetHashCode();
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
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
