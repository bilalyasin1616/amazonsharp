/* 
 * Selling Partner API for Fulfillment Inbound
 *
 * The Selling Partner API for Fulfillment Inbound lets you create applications that create and update inbound shipments of inventory to Amazon's fulfillment network.
 *
 * OpenAPI spec version: v0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace AmazonSharp.Models.FulfillmentInbound
{
    /// <summary>
    /// GetShipmentItemsResult
    /// </summary>
    [DataContract]
    public partial class GetShipmentItemsResult : IEquatable<GetShipmentItemsResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetShipmentItemsResult" /> class.
        /// </summary>
        /// <param name="ItemData">A list of item information for an inbound shipment..</param>
        /// <param name="NextToken">When present and not empty, pass this string token in the next request to return the next response page..</param>
        public GetShipmentItemsResult(InboundShipmentItemList ItemData = default(InboundShipmentItemList), string NextToken = default(string))
        {
            this.ItemData = ItemData;
            this.NextToken = NextToken;
        }

        /// <summary>
        /// A list of item information for an inbound shipment.
        /// </summary>
        /// <value>A list of item information for an inbound shipment.</value>
        [DataMember(Name = "ItemData", EmitDefaultValue = false)]
        public InboundShipmentItemList ItemData { get; set; }

        /// <summary>
        /// When present and not empty, pass this string token in the next request to return the next response page.
        /// </summary>
        /// <value>When present and not empty, pass this string token in the next request to return the next response page.</value>
        [DataMember(Name = "NextToken", EmitDefaultValue = false)]
        public string NextToken { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetShipmentItemsResult {\n");
            sb.Append("  ItemData: ").Append(ItemData).Append("\n");
            sb.Append("  NextToken: ").Append(NextToken).Append("\n");
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
            return this.Equals(input as GetShipmentItemsResult);
        }

        /// <summary>
        /// Returns true if GetShipmentItemsResult instances are equal
        /// </summary>
        /// <param name="input">Instance of GetShipmentItemsResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetShipmentItemsResult input)
        {
            if (input == null)
                return false;

            return
                (
                    this.ItemData == input.ItemData ||
                    (this.ItemData != null &&
                    this.ItemData.Equals(input.ItemData))
                ) &&
                (
                    this.NextToken == input.NextToken ||
                    (this.NextToken != null &&
                    this.NextToken.Equals(input.NextToken))
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
                if (this.ItemData != null)
                    hashCode = hashCode * 59 + this.ItemData.GetHashCode();
                if (this.NextToken != null)
                    hashCode = hashCode * 59 + this.NextToken.GetHashCode();
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