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
    /// ClientDetails
    /// </summary>
    [DataContract]
    public partial class ClientDetails :  IEquatable<ClientDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientDetails" /> class.
        /// </summary>
        /// <param name="ID">ID.</param>
        /// <param name="RFC">RFC.</param>
        /// <param name="LegalName">LegalName.</param>
        /// <param name="CommercialName">CommercialName.</param>
        /// <param name="CreditDays">CreditDays.</param>
        /// <param name="CreditAmount">CreditAmount.</param>
        /// <param name="PaymentMethod">PaymentMethod.</param>
        /// <param name="CreationDate">CreationDate.</param>
        /// <param name="Status">Status.</param>
        /// <param name="SalesContact">SalesContact.</param>
        /// <param name="CreditContact">CreditContact.</param>
        /// <param name="Loctaion">Loctaion.</param>
        /// <param name="LoctaionID">LoctaionID.</param>
        /// <param name="Comments">Comments.</param>
        /// <param name="PriceList">PriceList.</param>
        /// <param name="PriceListID">PriceListID.</param>
        /// <param name="PaymentTermType">PaymentTermType.</param>
        /// <param name="Email">Email.</param>
        /// <param name="Telephones">Telephones.</param>
        /// <param name="Number">Number.</param>
        /// <param name="AccountNumber">AccountNumber.</param>
        /// <param name="DefaultDiscount">DefaultDiscount.</param>
        /// <param name="ClientSource">ClientSource.</param>
        /// <param name="Account">Account.</param>
        /// <param name="City">City.</param>
        /// <param name="State">State.</param>
        /// <param name="Addresses">Addresses.</param>
        public ClientDetails(Guid? ID = default(Guid?), string RFC = default(string), string LegalName = default(string), string CommercialName = default(string), int? CreditDays = default(int?), double? CreditAmount = default(double?), string PaymentMethod = default(string), DateTime? CreationDate = default(DateTime?), string Status = default(string), string SalesContact = default(string), string CreditContact = default(string), string Loctaion = default(string), Guid? LoctaionID = default(Guid?), string Comments = default(string), string PriceList = default(string), Guid? PriceListID = default(Guid?), string PaymentTermType = default(string), string Email = default(string), string Telephones = default(string), long? Number = default(long?), string AccountNumber = default(string), double? DefaultDiscount = default(double?), string ClientSource = default(string), string Account = default(string), string City = default(string), string State = default(string), List<Guid?> Addresses = default(List<Guid?>))
        {
            this.ID = ID;
            this.RFC = RFC;
            this.LegalName = LegalName;
            this.CommercialName = CommercialName;
            this.CreditDays = CreditDays;
            this.CreditAmount = CreditAmount;
            this.PaymentMethod = PaymentMethod;
            this.CreationDate = CreationDate;
            this.Status = Status;
            this.SalesContact = SalesContact;
            this.CreditContact = CreditContact;
            this.Loctaion = Loctaion;
            this.LoctaionID = LoctaionID;
            this.Comments = Comments;
            this.PriceList = PriceList;
            this.PriceListID = PriceListID;
            this.PaymentTermType = PaymentTermType;
            this.Email = Email;
            this.Telephones = Telephones;
            this.Number = Number;
            this.AccountNumber = AccountNumber;
            this.DefaultDiscount = DefaultDiscount;
            this.ClientSource = ClientSource;
            this.Account = Account;
            this.City = City;
            this.State = State;
            this.Addresses = Addresses;
        }
        
        /// <summary>
        /// Gets or Sets ID
        /// </summary>
        [DataMember(Name="ID", EmitDefaultValue=false)]
        public Guid? ID { get; set; }

        /// <summary>
        /// Gets or Sets RFC
        /// </summary>
        [DataMember(Name="RFC", EmitDefaultValue=false)]
        public string RFC { get; set; }

        /// <summary>
        /// Gets or Sets LegalName
        /// </summary>
        [DataMember(Name="LegalName", EmitDefaultValue=false)]
        public string LegalName { get; set; }

        /// <summary>
        /// Gets or Sets CommercialName
        /// </summary>
        [DataMember(Name="CommercialName", EmitDefaultValue=false)]
        public string CommercialName { get; set; }

        /// <summary>
        /// Gets or Sets CreditDays
        /// </summary>
        [DataMember(Name="CreditDays", EmitDefaultValue=false)]
        public int? CreditDays { get; set; }

        /// <summary>
        /// Gets or Sets CreditAmount
        /// </summary>
        [DataMember(Name="CreditAmount", EmitDefaultValue=false)]
        public double? CreditAmount { get; set; }

        /// <summary>
        /// Gets or Sets PaymentMethod
        /// </summary>
        [DataMember(Name="PaymentMethod", EmitDefaultValue=false)]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// Gets or Sets CreationDate
        /// </summary>
        [DataMember(Name="CreationDate", EmitDefaultValue=false)]
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="Status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets SalesContact
        /// </summary>
        [DataMember(Name="SalesContact", EmitDefaultValue=false)]
        public string SalesContact { get; set; }

        /// <summary>
        /// Gets or Sets CreditContact
        /// </summary>
        [DataMember(Name="CreditContact", EmitDefaultValue=false)]
        public string CreditContact { get; set; }

        /// <summary>
        /// Gets or Sets Loctaion
        /// </summary>
        [DataMember(Name="Loctaion", EmitDefaultValue=false)]
        public string Loctaion { get; set; }

        /// <summary>
        /// Gets or Sets LoctaionID
        /// </summary>
        [DataMember(Name="LoctaionID", EmitDefaultValue=false)]
        public Guid? LoctaionID { get; set; }

        /// <summary>
        /// Gets or Sets Comments
        /// </summary>
        [DataMember(Name="Comments", EmitDefaultValue=false)]
        public string Comments { get; set; }

        /// <summary>
        /// Gets or Sets PriceList
        /// </summary>
        [DataMember(Name="PriceList", EmitDefaultValue=false)]
        public string PriceList { get; set; }

        /// <summary>
        /// Gets or Sets PriceListID
        /// </summary>
        [DataMember(Name="PriceListID", EmitDefaultValue=false)]
        public Guid? PriceListID { get; set; }

        /// <summary>
        /// Gets or Sets PaymentTermType
        /// </summary>
        [DataMember(Name="PaymentTermType", EmitDefaultValue=false)]
        public string PaymentTermType { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="Email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets Telephones
        /// </summary>
        [DataMember(Name="Telephones", EmitDefaultValue=false)]
        public string Telephones { get; set; }

        /// <summary>
        /// Gets or Sets Number
        /// </summary>
        [DataMember(Name="Number", EmitDefaultValue=false)]
        public long? Number { get; set; }

        /// <summary>
        /// Gets or Sets AccountNumber
        /// </summary>
        [DataMember(Name="AccountNumber", EmitDefaultValue=false)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Gets or Sets DefaultDiscount
        /// </summary>
        [DataMember(Name="DefaultDiscount", EmitDefaultValue=false)]
        public double? DefaultDiscount { get; set; }

        /// <summary>
        /// Gets or Sets ClientSource
        /// </summary>
        [DataMember(Name="ClientSource", EmitDefaultValue=false)]
        public string ClientSource { get; set; }

        /// <summary>
        /// Gets or Sets Account
        /// </summary>
        [DataMember(Name="Account", EmitDefaultValue=false)]
        public string Account { get; set; }

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
        /// Gets or Sets Addresses
        /// </summary>
        [DataMember(Name="Addresses", EmitDefaultValue=false)]
        public List<Guid?> Addresses { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClientDetails {\n");
            sb.Append("  ID: ").Append(ID).Append("\n");
            sb.Append("  RFC: ").Append(RFC).Append("\n");
            sb.Append("  LegalName: ").Append(LegalName).Append("\n");
            sb.Append("  CommercialName: ").Append(CommercialName).Append("\n");
            sb.Append("  CreditDays: ").Append(CreditDays).Append("\n");
            sb.Append("  CreditAmount: ").Append(CreditAmount).Append("\n");
            sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
            sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  SalesContact: ").Append(SalesContact).Append("\n");
            sb.Append("  CreditContact: ").Append(CreditContact).Append("\n");
            sb.Append("  Loctaion: ").Append(Loctaion).Append("\n");
            sb.Append("  LoctaionID: ").Append(LoctaionID).Append("\n");
            sb.Append("  Comments: ").Append(Comments).Append("\n");
            sb.Append("  PriceList: ").Append(PriceList).Append("\n");
            sb.Append("  PriceListID: ").Append(PriceListID).Append("\n");
            sb.Append("  PaymentTermType: ").Append(PaymentTermType).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Telephones: ").Append(Telephones).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  DefaultDiscount: ").Append(DefaultDiscount).Append("\n");
            sb.Append("  ClientSource: ").Append(ClientSource).Append("\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Addresses: ").Append(Addresses).Append("\n");
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
            return this.Equals(input as ClientDetails);
        }

        /// <summary>
        /// Returns true if ClientDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of ClientDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientDetails input)
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
                    this.RFC == input.RFC ||
                    (this.RFC != null &&
                    this.RFC.Equals(input.RFC))
                ) && 
                (
                    this.LegalName == input.LegalName ||
                    (this.LegalName != null &&
                    this.LegalName.Equals(input.LegalName))
                ) && 
                (
                    this.CommercialName == input.CommercialName ||
                    (this.CommercialName != null &&
                    this.CommercialName.Equals(input.CommercialName))
                ) && 
                (
                    this.CreditDays == input.CreditDays ||
                    (this.CreditDays != null &&
                    this.CreditDays.Equals(input.CreditDays))
                ) && 
                (
                    this.CreditAmount == input.CreditAmount ||
                    (this.CreditAmount != null &&
                    this.CreditAmount.Equals(input.CreditAmount))
                ) && 
                (
                    this.PaymentMethod == input.PaymentMethod ||
                    (this.PaymentMethod != null &&
                    this.PaymentMethod.Equals(input.PaymentMethod))
                ) && 
                (
                    this.CreationDate == input.CreationDate ||
                    (this.CreationDate != null &&
                    this.CreationDate.Equals(input.CreationDate))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.SalesContact == input.SalesContact ||
                    (this.SalesContact != null &&
                    this.SalesContact.Equals(input.SalesContact))
                ) && 
                (
                    this.CreditContact == input.CreditContact ||
                    (this.CreditContact != null &&
                    this.CreditContact.Equals(input.CreditContact))
                ) && 
                (
                    this.Loctaion == input.Loctaion ||
                    (this.Loctaion != null &&
                    this.Loctaion.Equals(input.Loctaion))
                ) && 
                (
                    this.LoctaionID == input.LoctaionID ||
                    (this.LoctaionID != null &&
                    this.LoctaionID.Equals(input.LoctaionID))
                ) && 
                (
                    this.Comments == input.Comments ||
                    (this.Comments != null &&
                    this.Comments.Equals(input.Comments))
                ) && 
                (
                    this.PriceList == input.PriceList ||
                    (this.PriceList != null &&
                    this.PriceList.Equals(input.PriceList))
                ) && 
                (
                    this.PriceListID == input.PriceListID ||
                    (this.PriceListID != null &&
                    this.PriceListID.Equals(input.PriceListID))
                ) && 
                (
                    this.PaymentTermType == input.PaymentTermType ||
                    (this.PaymentTermType != null &&
                    this.PaymentTermType.Equals(input.PaymentTermType))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Telephones == input.Telephones ||
                    (this.Telephones != null &&
                    this.Telephones.Equals(input.Telephones))
                ) && 
                (
                    this.Number == input.Number ||
                    (this.Number != null &&
                    this.Number.Equals(input.Number))
                ) && 
                (
                    this.AccountNumber == input.AccountNumber ||
                    (this.AccountNumber != null &&
                    this.AccountNumber.Equals(input.AccountNumber))
                ) && 
                (
                    this.DefaultDiscount == input.DefaultDiscount ||
                    (this.DefaultDiscount != null &&
                    this.DefaultDiscount.Equals(input.DefaultDiscount))
                ) && 
                (
                    this.ClientSource == input.ClientSource ||
                    (this.ClientSource != null &&
                    this.ClientSource.Equals(input.ClientSource))
                ) && 
                (
                    this.Account == input.Account ||
                    (this.Account != null &&
                    this.Account.Equals(input.Account))
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
                ) && 
                (
                    this.Addresses == input.Addresses ||
                    this.Addresses != null &&
                    this.Addresses.SequenceEqual(input.Addresses)
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
                if (this.RFC != null)
                    hashCode = hashCode * 59 + this.RFC.GetHashCode();
                if (this.LegalName != null)
                    hashCode = hashCode * 59 + this.LegalName.GetHashCode();
                if (this.CommercialName != null)
                    hashCode = hashCode * 59 + this.CommercialName.GetHashCode();
                if (this.CreditDays != null)
                    hashCode = hashCode * 59 + this.CreditDays.GetHashCode();
                if (this.CreditAmount != null)
                    hashCode = hashCode * 59 + this.CreditAmount.GetHashCode();
                if (this.PaymentMethod != null)
                    hashCode = hashCode * 59 + this.PaymentMethod.GetHashCode();
                if (this.CreationDate != null)
                    hashCode = hashCode * 59 + this.CreationDate.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.SalesContact != null)
                    hashCode = hashCode * 59 + this.SalesContact.GetHashCode();
                if (this.CreditContact != null)
                    hashCode = hashCode * 59 + this.CreditContact.GetHashCode();
                if (this.Loctaion != null)
                    hashCode = hashCode * 59 + this.Loctaion.GetHashCode();
                if (this.LoctaionID != null)
                    hashCode = hashCode * 59 + this.LoctaionID.GetHashCode();
                if (this.Comments != null)
                    hashCode = hashCode * 59 + this.Comments.GetHashCode();
                if (this.PriceList != null)
                    hashCode = hashCode * 59 + this.PriceList.GetHashCode();
                if (this.PriceListID != null)
                    hashCode = hashCode * 59 + this.PriceListID.GetHashCode();
                if (this.PaymentTermType != null)
                    hashCode = hashCode * 59 + this.PaymentTermType.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Telephones != null)
                    hashCode = hashCode * 59 + this.Telephones.GetHashCode();
                if (this.Number != null)
                    hashCode = hashCode * 59 + this.Number.GetHashCode();
                if (this.AccountNumber != null)
                    hashCode = hashCode * 59 + this.AccountNumber.GetHashCode();
                if (this.DefaultDiscount != null)
                    hashCode = hashCode * 59 + this.DefaultDiscount.GetHashCode();
                if (this.ClientSource != null)
                    hashCode = hashCode * 59 + this.ClientSource.GetHashCode();
                if (this.Account != null)
                    hashCode = hashCode * 59 + this.Account.GetHashCode();
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Addresses != null)
                    hashCode = hashCode * 59 + this.Addresses.GetHashCode();
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
