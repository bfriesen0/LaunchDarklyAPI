/* 
 * LaunchDarkly REST API
 *
 * Build custom integrations with the LaunchDarkly REST API
 *
 * OpenAPI spec version: 2.0.3
 * Contact: support@launchdarkly.com
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
using SwaggerDateConverter = LaunchDarklyAPI.Client.SwaggerDateConverter;

namespace LaunchDarklyAPI.Model
{
    /// <summary>
    /// UserSegmentRule
    /// </summary>
    [DataContract]
    public partial class UserSegmentRule :  IEquatable<UserSegmentRule>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserSegmentRule" /> class.
        /// </summary>
        /// <param name="clauses">clauses.</param>
        /// <param name="weight">weight.</param>
        /// <param name="bucketBy">bucketBy.</param>
        public UserSegmentRule(List<Clause> clauses = default(List<Clause>), int? weight = default(int?), string bucketBy = default(string))
        {
            this.Clauses = clauses;
            this.Weight = weight;
            this.BucketBy = bucketBy;
        }
        
        /// <summary>
        /// Gets or Sets Clauses
        /// </summary>
        [DataMember(Name="clauses", EmitDefaultValue=false)]
        public List<Clause> Clauses { get; set; }

        /// <summary>
        /// Gets or Sets Weight
        /// </summary>
        [DataMember(Name="weight", EmitDefaultValue=false)]
        public int? Weight { get; set; }

        /// <summary>
        /// Gets or Sets BucketBy
        /// </summary>
        [DataMember(Name="bucketBy", EmitDefaultValue=false)]
        public string BucketBy { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserSegmentRule {\n");
            sb.Append("  Clauses: ").Append(Clauses).Append("\n");
            sb.Append("  Weight: ").Append(Weight).Append("\n");
            sb.Append("  BucketBy: ").Append(BucketBy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
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
            return this.Equals(input as UserSegmentRule);
        }

        /// <summary>
        /// Returns true if UserSegmentRule instances are equal
        /// </summary>
        /// <param name="input">Instance of UserSegmentRule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserSegmentRule input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Clauses == input.Clauses ||
                    this.Clauses != null &&
                    this.Clauses.SequenceEqual(input.Clauses)
                ) && 
                (
                    this.Weight == input.Weight ||
                    (this.Weight != null &&
                    this.Weight.Equals(input.Weight))
                ) && 
                (
                    this.BucketBy == input.BucketBy ||
                    (this.BucketBy != null &&
                    this.BucketBy.Equals(input.BucketBy))
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
                if (this.Clauses != null)
                    hashCode = hashCode * 59 + this.Clauses.GetHashCode();
                if (this.Weight != null)
                    hashCode = hashCode * 59 + this.Weight.GetHashCode();
                if (this.BucketBy != null)
                    hashCode = hashCode * 59 + this.BucketBy.GetHashCode();
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
