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
    /// ODataQueryOptionsWebHook
    /// </summary>
    [DataContract]
    public partial class ODataQueryOptionsWebHook :  IEquatable<ODataQueryOptionsWebHook>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ODataQueryOptionsWebHook" /> class.
        /// </summary>
        /// <param name="IfMatch">IfMatch.</param>
        /// <param name="IfNoneMatch">IfNoneMatch.</param>
        /// <param name="Context">Context.</param>
        /// <param name="Request">Request.</param>
        /// <param name="RawValues">RawValues.</param>
        /// <param name="SelectExpand">SelectExpand.</param>
        /// <param name="Filter">Filter.</param>
        /// <param name="OrderBy">OrderBy.</param>
        /// <param name="Skip">Skip.</param>
        /// <param name="Top">Top.</param>
        /// <param name="InlineCount">InlineCount.</param>
        /// <param name="Validator">Validator.</param>
        public ODataQueryOptionsWebHook(Object IfMatch = default(Object), Object IfNoneMatch = default(Object), ODataQueryContext Context = default(ODataQueryContext), Object Request = default(Object), ODataRawQueryOptions RawValues = default(ODataRawQueryOptions), SelectExpandQueryOption SelectExpand = default(SelectExpandQueryOption), FilterQueryOption Filter = default(FilterQueryOption), OrderByQueryOption OrderBy = default(OrderByQueryOption), SkipQueryOption Skip = default(SkipQueryOption), TopQueryOption Top = default(TopQueryOption), InlineCountQueryOption InlineCount = default(InlineCountQueryOption), ODataQueryValidator Validator = default(ODataQueryValidator))
        {
            this.IfMatch = IfMatch;
            this.IfNoneMatch = IfNoneMatch;
            this.Context = Context;
            this.Request = Request;
            this.RawValues = RawValues;
            this.SelectExpand = SelectExpand;
            this.Filter = Filter;
            this.OrderBy = OrderBy;
            this.Skip = Skip;
            this.Top = Top;
            this.InlineCount = InlineCount;
            this.Validator = Validator;
        }
        
        /// <summary>
        /// Gets or Sets IfMatch
        /// </summary>
        [DataMember(Name="IfMatch", EmitDefaultValue=false)]
        public Object IfMatch { get; set; }

        /// <summary>
        /// Gets or Sets IfNoneMatch
        /// </summary>
        [DataMember(Name="IfNoneMatch", EmitDefaultValue=false)]
        public Object IfNoneMatch { get; set; }

        /// <summary>
        /// Gets or Sets Context
        /// </summary>
        [DataMember(Name="Context", EmitDefaultValue=false)]
        public ODataQueryContext Context { get; set; }

        /// <summary>
        /// Gets or Sets Request
        /// </summary>
        [DataMember(Name="Request", EmitDefaultValue=false)]
        public Object Request { get; set; }

        /// <summary>
        /// Gets or Sets RawValues
        /// </summary>
        [DataMember(Name="RawValues", EmitDefaultValue=false)]
        public ODataRawQueryOptions RawValues { get; set; }

        /// <summary>
        /// Gets or Sets SelectExpand
        /// </summary>
        [DataMember(Name="SelectExpand", EmitDefaultValue=false)]
        public SelectExpandQueryOption SelectExpand { get; set; }

        /// <summary>
        /// Gets or Sets Filter
        /// </summary>
        [DataMember(Name="Filter", EmitDefaultValue=false)]
        public FilterQueryOption Filter { get; set; }

        /// <summary>
        /// Gets or Sets OrderBy
        /// </summary>
        [DataMember(Name="OrderBy", EmitDefaultValue=false)]
        public OrderByQueryOption OrderBy { get; set; }

        /// <summary>
        /// Gets or Sets Skip
        /// </summary>
        [DataMember(Name="Skip", EmitDefaultValue=false)]
        public SkipQueryOption Skip { get; set; }

        /// <summary>
        /// Gets or Sets Top
        /// </summary>
        [DataMember(Name="Top", EmitDefaultValue=false)]
        public TopQueryOption Top { get; set; }

        /// <summary>
        /// Gets or Sets InlineCount
        /// </summary>
        [DataMember(Name="InlineCount", EmitDefaultValue=false)]
        public InlineCountQueryOption InlineCount { get; set; }

        /// <summary>
        /// Gets or Sets Validator
        /// </summary>
        [DataMember(Name="Validator", EmitDefaultValue=false)]
        public ODataQueryValidator Validator { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ODataQueryOptionsWebHook {\n");
            sb.Append("  IfMatch: ").Append(IfMatch).Append("\n");
            sb.Append("  IfNoneMatch: ").Append(IfNoneMatch).Append("\n");
            sb.Append("  Context: ").Append(Context).Append("\n");
            sb.Append("  Request: ").Append(Request).Append("\n");
            sb.Append("  RawValues: ").Append(RawValues).Append("\n");
            sb.Append("  SelectExpand: ").Append(SelectExpand).Append("\n");
            sb.Append("  Filter: ").Append(Filter).Append("\n");
            sb.Append("  OrderBy: ").Append(OrderBy).Append("\n");
            sb.Append("  Skip: ").Append(Skip).Append("\n");
            sb.Append("  Top: ").Append(Top).Append("\n");
            sb.Append("  InlineCount: ").Append(InlineCount).Append("\n");
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
            return this.Equals(input as ODataQueryOptionsWebHook);
        }

        /// <summary>
        /// Returns true if ODataQueryOptionsWebHook instances are equal
        /// </summary>
        /// <param name="input">Instance of ODataQueryOptionsWebHook to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ODataQueryOptionsWebHook input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IfMatch == input.IfMatch ||
                    (this.IfMatch != null &&
                    this.IfMatch.Equals(input.IfMatch))
                ) && 
                (
                    this.IfNoneMatch == input.IfNoneMatch ||
                    (this.IfNoneMatch != null &&
                    this.IfNoneMatch.Equals(input.IfNoneMatch))
                ) && 
                (
                    this.Context == input.Context ||
                    (this.Context != null &&
                    this.Context.Equals(input.Context))
                ) && 
                (
                    this.Request == input.Request ||
                    (this.Request != null &&
                    this.Request.Equals(input.Request))
                ) && 
                (
                    this.RawValues == input.RawValues ||
                    (this.RawValues != null &&
                    this.RawValues.Equals(input.RawValues))
                ) && 
                (
                    this.SelectExpand == input.SelectExpand ||
                    (this.SelectExpand != null &&
                    this.SelectExpand.Equals(input.SelectExpand))
                ) && 
                (
                    this.Filter == input.Filter ||
                    (this.Filter != null &&
                    this.Filter.Equals(input.Filter))
                ) && 
                (
                    this.OrderBy == input.OrderBy ||
                    (this.OrderBy != null &&
                    this.OrderBy.Equals(input.OrderBy))
                ) && 
                (
                    this.Skip == input.Skip ||
                    (this.Skip != null &&
                    this.Skip.Equals(input.Skip))
                ) && 
                (
                    this.Top == input.Top ||
                    (this.Top != null &&
                    this.Top.Equals(input.Top))
                ) && 
                (
                    this.InlineCount == input.InlineCount ||
                    (this.InlineCount != null &&
                    this.InlineCount.Equals(input.InlineCount))
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
                if (this.IfMatch != null)
                    hashCode = hashCode * 59 + this.IfMatch.GetHashCode();
                if (this.IfNoneMatch != null)
                    hashCode = hashCode * 59 + this.IfNoneMatch.GetHashCode();
                if (this.Context != null)
                    hashCode = hashCode * 59 + this.Context.GetHashCode();
                if (this.Request != null)
                    hashCode = hashCode * 59 + this.Request.GetHashCode();
                if (this.RawValues != null)
                    hashCode = hashCode * 59 + this.RawValues.GetHashCode();
                if (this.SelectExpand != null)
                    hashCode = hashCode * 59 + this.SelectExpand.GetHashCode();
                if (this.Filter != null)
                    hashCode = hashCode * 59 + this.Filter.GetHashCode();
                if (this.OrderBy != null)
                    hashCode = hashCode * 59 + this.OrderBy.GetHashCode();
                if (this.Skip != null)
                    hashCode = hashCode * 59 + this.Skip.GetHashCode();
                if (this.Top != null)
                    hashCode = hashCode * 59 + this.Top.GetHashCode();
                if (this.InlineCount != null)
                    hashCode = hashCode * 59 + this.InlineCount.GetHashCode();
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
