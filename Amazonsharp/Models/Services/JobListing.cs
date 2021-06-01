/* 
 * Selling Partner API for Services
 *
 * With the Services API, you can build applications that help service providers get and modify their service orders.
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace AmazonSharp.Models.Services
{
    /// <summary>
    /// The payload for the GetJobs operation.
    /// </summary>
    [DataContract]
    public partial class JobListing : IEquatable<JobListing>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JobListing" /> class.
        /// </summary>
        /// <param name="TotalResultSize">Total result size of the query result..</param>
        /// <param name="NextPageToken">A generated string used to pass information to your next request.If nextPageToken is returned, pass the value of nextPageToken to the pageToken to get next results..</param>
        /// <param name="PreviousPageToken">A generated string used to pass information to your next request.If previousPageToken is returned, pass the value of previousPageToken to the pageToken to get previous page results..</param>
        /// <param name="Jobs">List of job details for the given input..</param>
        public JobListing(int? TotalResultSize = default(int?), string NextPageToken = default(string), string PreviousPageToken = default(string), List<ServiceJob> Jobs = default(List<ServiceJob>))
        {
            this.TotalResultSize = TotalResultSize;
            this.NextPageToken = NextPageToken;
            this.PreviousPageToken = PreviousPageToken;
            this.Jobs = Jobs;
        }

        /// <summary>
        /// Total result size of the query result.
        /// </summary>
        /// <value>Total result size of the query result.</value>
        [DataMember(Name = "totalResultSize", EmitDefaultValue = false)]
        public int? TotalResultSize { get; set; }

        /// <summary>
        /// A generated string used to pass information to your next request.If nextPageToken is returned, pass the value of nextPageToken to the pageToken to get next results.
        /// </summary>
        /// <value>A generated string used to pass information to your next request.If nextPageToken is returned, pass the value of nextPageToken to the pageToken to get next results.</value>
        [DataMember(Name = "nextPageToken", EmitDefaultValue = false)]
        public string NextPageToken { get; set; }

        /// <summary>
        /// A generated string used to pass information to your next request.If previousPageToken is returned, pass the value of previousPageToken to the pageToken to get previous page results.
        /// </summary>
        /// <value>A generated string used to pass information to your next request.If previousPageToken is returned, pass the value of previousPageToken to the pageToken to get previous page results.</value>
        [DataMember(Name = "previousPageToken", EmitDefaultValue = false)]
        public string PreviousPageToken { get; set; }

        /// <summary>
        /// List of job details for the given input.
        /// </summary>
        /// <value>List of job details for the given input.</value>
        [DataMember(Name = "jobs", EmitDefaultValue = false)]
        public List<ServiceJob> Jobs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JobListing {\n");
            sb.Append("  TotalResultSize: ").Append(TotalResultSize).Append("\n");
            sb.Append("  NextPageToken: ").Append(NextPageToken).Append("\n");
            sb.Append("  PreviousPageToken: ").Append(PreviousPageToken).Append("\n");
            sb.Append("  Jobs: ").Append(Jobs).Append("\n");
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
            return this.Equals(input as JobListing);
        }

        /// <summary>
        /// Returns true if JobListing instances are equal
        /// </summary>
        /// <param name="input">Instance of JobListing to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JobListing input)
        {
            if (input == null)
                return false;

            return
                (
                    this.TotalResultSize == input.TotalResultSize ||
                    (this.TotalResultSize != null &&
                    this.TotalResultSize.Equals(input.TotalResultSize))
                ) &&
                (
                    this.NextPageToken == input.NextPageToken ||
                    (this.NextPageToken != null &&
                    this.NextPageToken.Equals(input.NextPageToken))
                ) &&
                (
                    this.PreviousPageToken == input.PreviousPageToken ||
                    (this.PreviousPageToken != null &&
                    this.PreviousPageToken.Equals(input.PreviousPageToken))
                ) &&
                (
                    this.Jobs == input.Jobs ||
                    this.Jobs != null &&
                    this.Jobs.SequenceEqual(input.Jobs)
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
                if (this.TotalResultSize != null)
                    hashCode = hashCode * 59 + this.TotalResultSize.GetHashCode();
                if (this.NextPageToken != null)
                    hashCode = hashCode * 59 + this.NextPageToken.GetHashCode();
                if (this.PreviousPageToken != null)
                    hashCode = hashCode * 59 + this.PreviousPageToken.GetHashCode();
                if (this.Jobs != null)
                    hashCode = hashCode * 59 + this.Jobs.GetHashCode();
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