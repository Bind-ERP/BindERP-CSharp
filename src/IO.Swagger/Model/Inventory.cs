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
    /// Inventory
    /// </summary>
    [DataContract]
    public partial class Inventory :  IEquatable<Inventory>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Inventory" /> class.
        /// </summary>
        /// <param name="ID">ID.</param>
        /// <param name="Value">Value.</param>
        /// <param name="Code">Code.</param>
        public Inventory(Guid? ID = default(Guid?), double? Value = default(double?), string Code = default(string))
        {
            this.ID = ID;
            this.Value = Value;
            this.Code = Code;
        }
        
        /// <summary>
        /// Gets or Sets Balance
        /// </summary>
        [DataMember(Name="Balance", EmitDefaultValue=false)]
        public double? Balance { get; private set; }

        /// <summary>
        /// Gets or Sets ClientOrdered
        /// </summary>
        [DataMember(Name="ClientOrdered", EmitDefaultValue=false)]
        public double? ClientOrdered { get; private set; }

        /// <summary>
        /// Gets or Sets CurrentInventory
        /// </summary>
        [DataMember(Name="CurrentInventory", EmitDefaultValue=false)]
        public double? CurrentInventory { get; private set; }

        /// <summary>
        /// Gets or Sets ID
        /// </summary>
        [DataMember(Name="ID", EmitDefaultValue=false)]
        public Guid? ID { get; set; }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name="Location", EmitDefaultValue=false)]
        public string Location { get; private set; }

        /// <summary>
        /// Gets or Sets ProvidedOrdered
        /// </summary>
        [DataMember(Name="ProvidedOrdered", EmitDefaultValue=false)]
        public double? ProvidedOrdered { get; private set; }

        /// <summary>
        /// Gets or Sets SKU
        /// </summary>
        [DataMember(Name="SKU", EmitDefaultValue=false)]
        public string SKU { get; private set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="Title", EmitDefaultValue=false)]
        public string Title { get; private set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="Value", EmitDefaultValue=false)]
        public double? Value { get; set; }

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name="Code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets ProductID
        /// </summary>
        [DataMember(Name="ProductID", EmitDefaultValue=false)]
        public Guid? ProductID { get; private set; }

        /// <summary>
        /// Gets or Sets Visible
        /// </summary>
        [DataMember(Name="Visible", EmitDefaultValue=false)]
        public bool? Visible { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Inventory {\n");
            sb.Append("  Balance: ").Append(Balance).Append("\n");
            sb.Append("  ClientOrdered: ").Append(ClientOrdered).Append("\n");
            sb.Append("  CurrentInventory: ").Append(CurrentInventory).Append("\n");
            sb.Append("  ID: ").Append(ID).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  ProvidedOrdered: ").Append(ProvidedOrdered).Append("\n");
            sb.Append("  SKU: ").Append(SKU).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  ProductID: ").Append(ProductID).Append("\n");
            sb.Append("  Visible: ").Append(Visible).Append("\n");
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
            return this.Equals(input as Inventory);
        }

        /// <summary>
        /// Returns true if Inventory instances are equal
        /// </summary>
        /// <param name="input">Instance of Inventory to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Inventory input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Balance == input.Balance ||
                    (this.Balance != null &&
                    this.Balance.Equals(input.Balance))
                ) && 
                (
                    this.ClientOrdered == input.ClientOrdered ||
                    (this.ClientOrdered != null &&
                    this.ClientOrdered.Equals(input.ClientOrdered))
                ) && 
                (
                    this.CurrentInventory == input.CurrentInventory ||
                    (this.CurrentInventory != null &&
                    this.CurrentInventory.Equals(input.CurrentInventory))
                ) && 
                (
                    this.ID == input.ID ||
                    (this.ID != null &&
                    this.ID.Equals(input.ID))
                ) && 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && 
                (
                    this.ProvidedOrdered == input.ProvidedOrdered ||
                    (this.ProvidedOrdered != null &&
                    this.ProvidedOrdered.Equals(input.ProvidedOrdered))
                ) && 
                (
                    this.SKU == input.SKU ||
                    (this.SKU != null &&
                    this.SKU.Equals(input.SKU))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.ProductID == input.ProductID ||
                    (this.ProductID != null &&
                    this.ProductID.Equals(input.ProductID))
                ) && 
                (
                    this.Visible == input.Visible ||
                    (this.Visible != null &&
                    this.Visible.Equals(input.Visible))
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
                if (this.Balance != null)
                    hashCode = hashCode * 59 + this.Balance.GetHashCode();
                if (this.ClientOrdered != null)
                    hashCode = hashCode * 59 + this.ClientOrdered.GetHashCode();
                if (this.CurrentInventory != null)
                    hashCode = hashCode * 59 + this.CurrentInventory.GetHashCode();
                if (this.ID != null)
                    hashCode = hashCode * 59 + this.ID.GetHashCode();
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.ProvidedOrdered != null)
                    hashCode = hashCode * 59 + this.ProvidedOrdered.GetHashCode();
                if (this.SKU != null)
                    hashCode = hashCode * 59 + this.SKU.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.ProductID != null)
                    hashCode = hashCode * 59 + this.ProductID.GetHashCode();
                if (this.Visible != null)
                    hashCode = hashCode * 59 + this.Visible.GetHashCode();
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
