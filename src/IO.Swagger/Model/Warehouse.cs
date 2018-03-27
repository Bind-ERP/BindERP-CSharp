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
    /// Warehouse
    /// </summary>
    [DataContract]
    public partial class Warehouse :  IEquatable<Warehouse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Warehouse" /> class.
        /// </summary>
        /// <param name="ID">ID.</param>
        /// <param name="Name">Name.</param>
        /// <param name="LocationID">LocationID.</param>
        /// <param name="AvailableInOtherLoc">AvailableInOtherLoc.</param>
        public Warehouse(Guid? ID = default(Guid?), string Name = default(string), Guid? LocationID = default(Guid?), bool? AvailableInOtherLoc = default(bool?))
        {
            this.ID = ID;
            this.Name = Name;
            this.LocationID = LocationID;
            this.AvailableInOtherLoc = AvailableInOtherLoc;
        }
        
        /// <summary>
        /// Gets or Sets ID
        /// </summary>
        [DataMember(Name="ID", EmitDefaultValue=false)]
        public Guid? ID { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets LocationID
        /// </summary>
        [DataMember(Name="LocationID", EmitDefaultValue=false)]
        public Guid? LocationID { get; set; }

        /// <summary>
        /// Gets or Sets AvailableInOtherLoc
        /// </summary>
        [DataMember(Name="AvailableInOtherLoc", EmitDefaultValue=false)]
        public bool? AvailableInOtherLoc { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Warehouse {\n");
            sb.Append("  ID: ").Append(ID).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  LocationID: ").Append(LocationID).Append("\n");
            sb.Append("  AvailableInOtherLoc: ").Append(AvailableInOtherLoc).Append("\n");
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
            return this.Equals(input as Warehouse);
        }

        /// <summary>
        /// Returns true if Warehouse instances are equal
        /// </summary>
        /// <param name="input">Instance of Warehouse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Warehouse input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.LocationID == input.LocationID ||
                    (this.LocationID != null &&
                    this.LocationID.Equals(input.LocationID))
                ) && 
                (
                    this.AvailableInOtherLoc == input.AvailableInOtherLoc ||
                    (this.AvailableInOtherLoc != null &&
                    this.AvailableInOtherLoc.Equals(input.AvailableInOtherLoc))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.LocationID != null)
                    hashCode = hashCode * 59 + this.LocationID.GetHashCode();
                if (this.AvailableInOtherLoc != null)
                    hashCode = hashCode * 59 + this.AvailableInOtherLoc.GetHashCode();
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
