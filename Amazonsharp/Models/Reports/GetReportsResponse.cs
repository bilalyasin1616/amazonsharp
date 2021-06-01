/* 
 * Selling Partner API for Reports
 *
 * The Selling Partner API for Reports lets you retrieve and manage a variety of reports that can help selling partners manage their businesses.
 *
 * OpenAPI spec version: 2020-09-04
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace AmazonSharp.Models.Reports
{
    /// <summary>
    /// The response for the getReports operation.
    /// </summary>
    [DataContract]
    public partial class GetReportsResponse : IEquatable<GetReportsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetReportsResponse" /> class.
        /// </summary>
        /// <param name="Payload">The payload for the getReports operation..</param>
        /// <param name="NextToken">Returned when the number of results exceeds pageSize. To get the next page of results, call getReports with this token as the only parameter..</param>
        /// <param name="Errors">Errors.</param>
        public GetReportsResponse(ReportList Payload = default(ReportList), string NextToken = default(string), ErrorList Errors = default(ErrorList))
        {
            this.Payload = Payload;
            this.NextToken = NextToken;
            this.Errors = Errors;
        }

        /// <summary>
        /// The payload for the getReports operation.
        /// </summary>
        /// <value>The payload for the getReports operation.</value>
        [DataMember(Name = "payload", EmitDefaultValue = false)]
        public ReportList Payload { get; set; }

        /// <summary>
        /// Returned when the number of results exceeds pageSize. To get the next page of results, call getReports with this token as the only parameter.
        /// </summary>
        /// <value>Returned when the number of results exceeds pageSize. To get the next page of results, call getReports with this token as the only parameter.</value>
        [DataMember(Name = "nextToken", EmitDefaultValue = false)]
        public string NextToken { get; set; }

        /// <summary>
        /// Gets or Sets Errors
        /// </summary>
        [DataMember(Name = "errors", EmitDefaultValue = false)]
        public ErrorList Errors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetReportsResponse {\n");
            sb.Append("  Payload: ").Append(Payload).Append("\n");
            sb.Append("  NextToken: ").Append(NextToken).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
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
            return this.Equals(input as GetReportsResponse);
        }

        /// <summary>
        /// Returns true if GetReportsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetReportsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetReportsResponse input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Payload == input.Payload ||
                    (this.Payload != null &&
                    this.Payload.Equals(input.Payload))
                ) &&
                (
                    this.NextToken == input.NextToken ||
                    (this.NextToken != null &&
                    this.NextToken.Equals(input.NextToken))
                ) &&
                (
                    this.Errors == input.Errors ||
                    (this.Errors != null &&
                    this.Errors.Equals(input.Errors))
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
                if (this.Payload != null)
                    hashCode = hashCode * 59 + this.Payload.GetHashCode();
                if (this.NextToken != null)
                    hashCode = hashCode * 59 + this.NextToken.GetHashCode();
                if (this.Errors != null)
                    hashCode = hashCode * 59 + this.Errors.GetHashCode();
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