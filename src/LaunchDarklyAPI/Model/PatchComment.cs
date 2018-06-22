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
    /// PatchComment
    /// </summary>
    [DataContract]
    public partial class PatchComment :  IEquatable<PatchComment>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PatchComment" /> class.
        /// </summary>
        /// <param name="comment">comment.</param>
        /// <param name="patch">patch.</param>
        public PatchComment(string comment = default(string), List<PatchOperation> patch = default(List<PatchOperation>))
        {
            this.Comment = comment;
            this.Patch = patch;
        }
        
        /// <summary>
        /// Gets or Sets Comment
        /// </summary>
        [DataMember(Name="comment", EmitDefaultValue=false)]
        public string Comment { get; set; }

        /// <summary>
        /// Gets or Sets Patch
        /// </summary>
        [DataMember(Name="patch", EmitDefaultValue=false)]
        public List<PatchOperation> Patch { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PatchComment {\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  Patch: ").Append(Patch).Append("\n");
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
            return this.Equals(input as PatchComment);
        }

        /// <summary>
        /// Returns true if PatchComment instances are equal
        /// </summary>
        /// <param name="input">Instance of PatchComment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PatchComment input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Comment == input.Comment ||
                    (this.Comment != null &&
                    this.Comment.Equals(input.Comment))
                ) && 
                (
                    this.Patch == input.Patch ||
                    this.Patch != null &&
                    this.Patch.SequenceEqual(input.Patch)
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
                if (this.Comment != null)
                    hashCode = hashCode * 59 + this.Comment.GetHashCode();
                if (this.Patch != null)
                    hashCode = hashCode * 59 + this.Patch.GetHashCode();
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
