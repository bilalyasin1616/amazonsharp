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
using System.IO;
using System.Runtime.Serialization;
using System.Text;

namespace AmazonSharp.Models.FulfillmentInbound
{
    /// <summary>
    /// The request schema for the createInboundShipmentPlan operation.
    /// </summary>
    [DataContract]
    public partial class CreateInboundShipmentPlanRequest : IEquatable<CreateInboundShipmentPlanRequest>, IValidatableObject
    {
        /// <summary>
        /// The seller&#39;s preference for label preparation for an inbound shipment.
        /// </summary>
        /// <value>The seller&#39;s preference for label preparation for an inbound shipment.</value>
        [DataMember(Name = "LabelPrepPreference", EmitDefaultValue = false)]
        public LabelPrepPreference LabelPrepPreference { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateInboundShipmentPlanRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateInboundShipmentPlanRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateInboundShipmentPlanRequest" /> class.
        /// </summary>
        /// <param name="ShipFromAddress">The address from which the inbound shipment will be sent. (required).</param>
        /// <param name="LabelPrepPreference">The seller&#39;s preference for label preparation for an inbound shipment. (required).</param>
        /// <param name="ShipToCountryCode">The two-character country code for the country where the inbound shipment is to be sent.  Note: Not required. Specifying both ShipToCountryCode and ShipToCountrySubdivisionCode returns an error.   Values:   ShipToCountryCode values for North America:  * CA – Canada  * MX - Mexico  * US - United States  ShipToCountryCode values for MCI sellers in Europe:  * DE – Germany  * ES – Spain  * FR – France  * GB – United Kingdom  * IT – Italy  Default: The country code for the seller&#39;s home marketplace..</param>
        /// <param name="ShipToCountrySubdivisionCode">The two-character country code, followed by a dash and then up to three characters that represent the subdivision of the country where the inbound shipment is to be sent. For example, \&quot;IN-MH\&quot;. In full ISO 3166-2 format.  Note: Not required. Specifying both ShipToCountryCode and ShipToCountrySubdivisionCode returns an error..</param>
        /// <param name="InboundShipmentPlanRequestItems">InboundShipmentPlanRequestItems (required).</param>
        public CreateInboundShipmentPlanRequest(Address ShipFromAddress = default(Address), LabelPrepPreference LabelPrepPreference = default(LabelPrepPreference), string ShipToCountryCode = default(string), string ShipToCountrySubdivisionCode = default(string), InboundShipmentPlanRequestItemList InboundShipmentPlanRequestItems = default(InboundShipmentPlanRequestItemList))
        {
            // to ensure "ShipFromAddress" is required (not null)
            if (ShipFromAddress == null)
            {
                throw new InvalidDataException("ShipFromAddress is a required property for CreateInboundShipmentPlanRequest and cannot be null");
            }
            else
            {
                this.ShipFromAddress = ShipFromAddress;
            }
            // to ensure "LabelPrepPreference" is required (not null)
            if (LabelPrepPreference == null)
            {
                throw new InvalidDataException("LabelPrepPreference is a required property for CreateInboundShipmentPlanRequest and cannot be null");
            }
            else
            {
                this.LabelPrepPreference = LabelPrepPreference;
            }
            // to ensure "InboundShipmentPlanRequestItems" is required (not null)
            if (InboundShipmentPlanRequestItems == null)
            {
                throw new InvalidDataException("InboundShipmentPlanRequestItems is a required property for CreateInboundShipmentPlanRequest and cannot be null");
            }
            else
            {
                this.InboundShipmentPlanRequestItems = InboundShipmentPlanRequestItems;
            }
            this.ShipToCountryCode = ShipToCountryCode;
            this.ShipToCountrySubdivisionCode = ShipToCountrySubdivisionCode;
        }

        /// <summary>
        /// The address from which the inbound shipment will be sent.
        /// </summary>
        /// <value>The address from which the inbound shipment will be sent.</value>
        [DataMember(Name = "ShipFromAddress", EmitDefaultValue = false)]
        public Address ShipFromAddress { get; set; }


        /// <summary>
        /// The two-character country code for the country where the inbound shipment is to be sent.  Note: Not required. Specifying both ShipToCountryCode and ShipToCountrySubdivisionCode returns an error.   Values:   ShipToCountryCode values for North America:  * CA – Canada  * MX - Mexico  * US - United States  ShipToCountryCode values for MCI sellers in Europe:  * DE – Germany  * ES – Spain  * FR – France  * GB – United Kingdom  * IT – Italy  Default: The country code for the seller&#39;s home marketplace.
        /// </summary>
        /// <value>The two-character country code for the country where the inbound shipment is to be sent.  Note: Not required. Specifying both ShipToCountryCode and ShipToCountrySubdivisionCode returns an error.   Values:   ShipToCountryCode values for North America:  * CA – Canada  * MX - Mexico  * US - United States  ShipToCountryCode values for MCI sellers in Europe:  * DE – Germany  * ES – Spain  * FR – France  * GB – United Kingdom  * IT – Italy  Default: The country code for the seller&#39;s home marketplace.</value>
        [DataMember(Name = "ShipToCountryCode", EmitDefaultValue = false)]
        public string ShipToCountryCode { get; set; }

        /// <summary>
        /// The two-character country code, followed by a dash and then up to three characters that represent the subdivision of the country where the inbound shipment is to be sent. For example, \&quot;IN-MH\&quot;. In full ISO 3166-2 format.  Note: Not required. Specifying both ShipToCountryCode and ShipToCountrySubdivisionCode returns an error.
        /// </summary>
        /// <value>The two-character country code, followed by a dash and then up to three characters that represent the subdivision of the country where the inbound shipment is to be sent. For example, \&quot;IN-MH\&quot;. In full ISO 3166-2 format.  Note: Not required. Specifying both ShipToCountryCode and ShipToCountrySubdivisionCode returns an error.</value>
        [DataMember(Name = "ShipToCountrySubdivisionCode", EmitDefaultValue = false)]
        public string ShipToCountrySubdivisionCode { get; set; }

        /// <summary>
        /// Gets or Sets InboundShipmentPlanRequestItems
        /// </summary>
        [DataMember(Name = "InboundShipmentPlanRequestItems", EmitDefaultValue = false)]
        public InboundShipmentPlanRequestItemList InboundShipmentPlanRequestItems { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateInboundShipmentPlanRequest {\n");
            sb.Append("  ShipFromAddress: ").Append(ShipFromAddress).Append("\n");
            sb.Append("  LabelPrepPreference: ").Append(LabelPrepPreference).Append("\n");
            sb.Append("  ShipToCountryCode: ").Append(ShipToCountryCode).Append("\n");
            sb.Append("  ShipToCountrySubdivisionCode: ").Append(ShipToCountrySubdivisionCode).Append("\n");
            sb.Append("  InboundShipmentPlanRequestItems: ").Append(InboundShipmentPlanRequestItems).Append("\n");
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
            return this.Equals(input as CreateInboundShipmentPlanRequest);
        }

        /// <summary>
        /// Returns true if CreateInboundShipmentPlanRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateInboundShipmentPlanRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateInboundShipmentPlanRequest input)
        {
            if (input == null)
                return false;

            return
                (
                    this.ShipFromAddress == input.ShipFromAddress ||
                    (this.ShipFromAddress != null &&
                    this.ShipFromAddress.Equals(input.ShipFromAddress))
                ) &&
                (
                    this.LabelPrepPreference == input.LabelPrepPreference ||
                    (this.LabelPrepPreference != null &&
                    this.LabelPrepPreference.Equals(input.LabelPrepPreference))
                ) &&
                (
                    this.ShipToCountryCode == input.ShipToCountryCode ||
                    (this.ShipToCountryCode != null &&
                    this.ShipToCountryCode.Equals(input.ShipToCountryCode))
                ) &&
                (
                    this.ShipToCountrySubdivisionCode == input.ShipToCountrySubdivisionCode ||
                    (this.ShipToCountrySubdivisionCode != null &&
                    this.ShipToCountrySubdivisionCode.Equals(input.ShipToCountrySubdivisionCode))
                ) &&
                (
                    this.InboundShipmentPlanRequestItems == input.InboundShipmentPlanRequestItems ||
                    (this.InboundShipmentPlanRequestItems != null &&
                    this.InboundShipmentPlanRequestItems.Equals(input.InboundShipmentPlanRequestItems))
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
                if (this.ShipFromAddress != null)
                    hashCode = hashCode * 59 + this.ShipFromAddress.GetHashCode();
                if (this.LabelPrepPreference != null)
                    hashCode = hashCode * 59 + this.LabelPrepPreference.GetHashCode();
                if (this.ShipToCountryCode != null)
                    hashCode = hashCode * 59 + this.ShipToCountryCode.GetHashCode();
                if (this.ShipToCountrySubdivisionCode != null)
                    hashCode = hashCode * 59 + this.ShipToCountrySubdivisionCode.GetHashCode();
                if (this.InboundShipmentPlanRequestItems != null)
                    hashCode = hashCode * 59 + this.InboundShipmentPlanRequestItems.GetHashCode();
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
