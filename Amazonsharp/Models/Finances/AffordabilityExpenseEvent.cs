/* 
 * Selling Partner API for Finances
 *
 * The Selling Partner API for Finances helps you obtain financial information relevant to a seller's business. You can obtain financial events for a given order, financial event group, or date range without having to wait until a statement period closes. You can also obtain financial event groups for a given date range.
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

namespace AmazonSharp.Models.Finances
{
    /// <summary>
    /// An expense related to an affordability promotion.
    /// </summary>
    [DataContract]
    public partial class AffordabilityExpenseEvent : IEquatable<AffordabilityExpenseEvent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AffordabilityExpenseEvent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AffordabilityExpenseEvent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AffordabilityExpenseEvent" /> class.
        /// </summary>
        /// <param name="AmazonOrderId">An Amazon-defined identifier for an order..</param>
        /// <param name="PostedDate">The date and time when the financial event was created..</param>
        /// <param name="MarketplaceId">An encrypted, Amazon-defined marketplace identifier..</param>
        /// <param name="TransactionType">Indicates the type of transaction.   Possible values:  * Charge - For an affordability promotion expense.  * Refund - For an affordability promotion expense reversal..</param>
        /// <param name="BaseExpense">The amount charged for clicks incurred under the Sponsored Products program..</param>
        /// <param name="TaxTypeCGST">Central Goods and Service Tax, charged and collected by the central government. (required).</param>
        /// <param name="TaxTypeSGST">State Goods and Service Tax, charged and collected by the state government. (required).</param>
        /// <param name="TaxTypeIGST">Integrated Goods and Service Tax, charged and collected by the central government. (required).</param>
        /// <param name="TotalExpense">The total amount charged to the seller. TotalExpense &#x3D; BaseExpense + TaxTypeIGST + TaxTypeCGST + TaxTypeSGST..</param>
        public AffordabilityExpenseEvent(string AmazonOrderId = default(string), DateTime? PostedDate = default(DateTime?), string MarketplaceId = default(string), string TransactionType = default(string), Currency BaseExpense = default(Currency), Currency TaxTypeCGST = default(Currency), Currency TaxTypeSGST = default(Currency), Currency TaxTypeIGST = default(Currency), Currency TotalExpense = default(Currency))
        {
            // to ensure "TaxTypeCGST" is required (not null)
            if (TaxTypeCGST == null)
            {
                throw new InvalidDataException("TaxTypeCGST is a required property for AffordabilityExpenseEvent and cannot be null");
            }
            else
            {
                this.TaxTypeCGST = TaxTypeCGST;
            }
            // to ensure "TaxTypeSGST" is required (not null)
            if (TaxTypeSGST == null)
            {
                throw new InvalidDataException("TaxTypeSGST is a required property for AffordabilityExpenseEvent and cannot be null");
            }
            else
            {
                this.TaxTypeSGST = TaxTypeSGST;
            }
            // to ensure "TaxTypeIGST" is required (not null)
            if (TaxTypeIGST == null)
            {
                throw new InvalidDataException("TaxTypeIGST is a required property for AffordabilityExpenseEvent and cannot be null");
            }
            else
            {
                this.TaxTypeIGST = TaxTypeIGST;
            }
            this.AmazonOrderId = AmazonOrderId;
            this.PostedDate = PostedDate;
            this.MarketplaceId = MarketplaceId;
            this.TransactionType = TransactionType;
            this.BaseExpense = BaseExpense;
            this.TotalExpense = TotalExpense;
        }

        /// <summary>
        /// An Amazon-defined identifier for an order.
        /// </summary>
        /// <value>An Amazon-defined identifier for an order.</value>
        [DataMember(Name = "AmazonOrderId", EmitDefaultValue = false)]
        public string AmazonOrderId { get; set; }

        /// <summary>
        /// The date and time when the financial event was created.
        /// </summary>
        /// <value>The date and time when the financial event was created.</value>
        [DataMember(Name = "PostedDate", EmitDefaultValue = false)]
        public DateTime? PostedDate { get; set; }

        /// <summary>
        /// An encrypted, Amazon-defined marketplace identifier.
        /// </summary>
        /// <value>An encrypted, Amazon-defined marketplace identifier.</value>
        [DataMember(Name = "MarketplaceId", EmitDefaultValue = false)]
        public string MarketplaceId { get; set; }

        /// <summary>
        /// Indicates the type of transaction.   Possible values:  * Charge - For an affordability promotion expense.  * Refund - For an affordability promotion expense reversal.
        /// </summary>
        /// <value>Indicates the type of transaction.   Possible values:  * Charge - For an affordability promotion expense.  * Refund - For an affordability promotion expense reversal.</value>
        [DataMember(Name = "TransactionType", EmitDefaultValue = false)]
        public string TransactionType { get; set; }

        /// <summary>
        /// The amount charged for clicks incurred under the Sponsored Products program.
        /// </summary>
        /// <value>The amount charged for clicks incurred under the Sponsored Products program.</value>
        [DataMember(Name = "BaseExpense", EmitDefaultValue = false)]
        public Currency BaseExpense { get; set; }

        /// <summary>
        /// Central Goods and Service Tax, charged and collected by the central government.
        /// </summary>
        /// <value>Central Goods and Service Tax, charged and collected by the central government.</value>
        [DataMember(Name = "TaxTypeCGST", EmitDefaultValue = false)]
        public Currency TaxTypeCGST { get; set; }

        /// <summary>
        /// State Goods and Service Tax, charged and collected by the state government.
        /// </summary>
        /// <value>State Goods and Service Tax, charged and collected by the state government.</value>
        [DataMember(Name = "TaxTypeSGST", EmitDefaultValue = false)]
        public Currency TaxTypeSGST { get; set; }

        /// <summary>
        /// Integrated Goods and Service Tax, charged and collected by the central government.
        /// </summary>
        /// <value>Integrated Goods and Service Tax, charged and collected by the central government.</value>
        [DataMember(Name = "TaxTypeIGST", EmitDefaultValue = false)]
        public Currency TaxTypeIGST { get; set; }

        /// <summary>
        /// The total amount charged to the seller. TotalExpense &#x3D; BaseExpense + TaxTypeIGST + TaxTypeCGST + TaxTypeSGST.
        /// </summary>
        /// <value>The total amount charged to the seller. TotalExpense &#x3D; BaseExpense + TaxTypeIGST + TaxTypeCGST + TaxTypeSGST.</value>
        [DataMember(Name = "TotalExpense", EmitDefaultValue = false)]
        public Currency TotalExpense { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AffordabilityExpenseEvent {\n");
            sb.Append("  AmazonOrderId: ").Append(AmazonOrderId).Append("\n");
            sb.Append("  PostedDate: ").Append(PostedDate).Append("\n");
            sb.Append("  MarketplaceId: ").Append(MarketplaceId).Append("\n");
            sb.Append("  TransactionType: ").Append(TransactionType).Append("\n");
            sb.Append("  BaseExpense: ").Append(BaseExpense).Append("\n");
            sb.Append("  TaxTypeCGST: ").Append(TaxTypeCGST).Append("\n");
            sb.Append("  TaxTypeSGST: ").Append(TaxTypeSGST).Append("\n");
            sb.Append("  TaxTypeIGST: ").Append(TaxTypeIGST).Append("\n");
            sb.Append("  TotalExpense: ").Append(TotalExpense).Append("\n");
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
            return this.Equals(input as AffordabilityExpenseEvent);
        }

        /// <summary>
        /// Returns true if AffordabilityExpenseEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of AffordabilityExpenseEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AffordabilityExpenseEvent input)
        {
            if (input == null)
                return false;

            return
                (
                    this.AmazonOrderId == input.AmazonOrderId ||
                    (this.AmazonOrderId != null &&
                    this.AmazonOrderId.Equals(input.AmazonOrderId))
                ) &&
                (
                    this.PostedDate == input.PostedDate ||
                    (this.PostedDate != null &&
                    this.PostedDate.Equals(input.PostedDate))
                ) &&
                (
                    this.MarketplaceId == input.MarketplaceId ||
                    (this.MarketplaceId != null &&
                    this.MarketplaceId.Equals(input.MarketplaceId))
                ) &&
                (
                    this.TransactionType == input.TransactionType ||
                    (this.TransactionType != null &&
                    this.TransactionType.Equals(input.TransactionType))
                ) &&
                (
                    this.BaseExpense == input.BaseExpense ||
                    (this.BaseExpense != null &&
                    this.BaseExpense.Equals(input.BaseExpense))
                ) &&
                (
                    this.TaxTypeCGST == input.TaxTypeCGST ||
                    (this.TaxTypeCGST != null &&
                    this.TaxTypeCGST.Equals(input.TaxTypeCGST))
                ) &&
                (
                    this.TaxTypeSGST == input.TaxTypeSGST ||
                    (this.TaxTypeSGST != null &&
                    this.TaxTypeSGST.Equals(input.TaxTypeSGST))
                ) &&
                (
                    this.TaxTypeIGST == input.TaxTypeIGST ||
                    (this.TaxTypeIGST != null &&
                    this.TaxTypeIGST.Equals(input.TaxTypeIGST))
                ) &&
                (
                    this.TotalExpense == input.TotalExpense ||
                    (this.TotalExpense != null &&
                    this.TotalExpense.Equals(input.TotalExpense))
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
                if (this.AmazonOrderId != null)
                    hashCode = hashCode * 59 + this.AmazonOrderId.GetHashCode();
                if (this.PostedDate != null)
                    hashCode = hashCode * 59 + this.PostedDate.GetHashCode();
                if (this.MarketplaceId != null)
                    hashCode = hashCode * 59 + this.MarketplaceId.GetHashCode();
                if (this.TransactionType != null)
                    hashCode = hashCode * 59 + this.TransactionType.GetHashCode();
                if (this.BaseExpense != null)
                    hashCode = hashCode * 59 + this.BaseExpense.GetHashCode();
                if (this.TaxTypeCGST != null)
                    hashCode = hashCode * 59 + this.TaxTypeCGST.GetHashCode();
                if (this.TaxTypeSGST != null)
                    hashCode = hashCode * 59 + this.TaxTypeSGST.GetHashCode();
                if (this.TaxTypeIGST != null)
                    hashCode = hashCode * 59 + this.TaxTypeIGST.GetHashCode();
                if (this.TotalExpense != null)
                    hashCode = hashCode * 59 + this.TotalExpense.GetHashCode();
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