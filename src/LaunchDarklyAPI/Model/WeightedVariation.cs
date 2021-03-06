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
    /// WeightedVariation
    /// </summary>
    [DataContract]
    public partial class WeightedVariation :  IEquatable<WeightedVariation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WeightedVariation" /> class.
        /// </summary>
        /// <param name="variation">variation.</param>
        /// <param name="weight">weight.</param>
        public WeightedVariation(int? variation = default(int?), int? weight = default(int?))
        {
            this.Variation = variation;
            this.Weight = weight;
        }
        
        /// <summary>
        /// Gets or Sets Variation
        /// </summary>
        [DataMember(Name="variation", EmitDefaultValue=false)]
        public int? Variation { get; set; }

        /// <summary>
        /// Gets or Sets Weight
        /// </summary>
        [DataMember(Name="weight", EmitDefaultValue=false)]
        public int? Weight { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WeightedVariation {\n");
            sb.Append("  Variation: ").Append(Variation).Append("\n");
            sb.Append("  Weight: ").Append(Weight).Append("\n");
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
            return this.Equals(input as WeightedVariation);
        }

        /// <summary>
        /// Returns true if WeightedVariation instances are equal
        /// </summary>
        /// <param name="input">Instance of WeightedVariation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WeightedVariation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Variation == input.Variation ||
                    (this.Variation != null &&
                    this.Variation.Equals(input.Variation))
                ) && 
                (
                    this.Weight == input.Weight ||
                    (this.Weight != null &&
                    this.Weight.Equals(input.Weight))
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
                if (this.Variation != null)
                    hashCode = hashCode * 59 + this.Variation.GetHashCode();
                if (this.Weight != null)
                    hashCode = hashCode * 59 + this.Weight.GetHashCode();
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
