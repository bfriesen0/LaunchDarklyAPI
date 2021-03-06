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
    /// UserSegmentBody
    /// </summary>
    [DataContract]
    public partial class UserSegmentBody :  IEquatable<UserSegmentBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserSegmentBody" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserSegmentBody() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserSegmentBody" /> class.
        /// </summary>
        /// <param name="name">A human-friendly name for the user segment. (required).</param>
        /// <param name="key">A unique key that will be used to reference the user segment in feature flags. (required).</param>
        /// <param name="description">A description for the user segment..</param>
        /// <param name="tags">Tags for the user segment..</param>
        public UserSegmentBody(string name = default(string), string key = default(string), string description = default(string), List<string> tags = default(List<string>))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for UserSegmentBody and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "key" is required (not null)
            if (key == null)
            {
                throw new InvalidDataException("key is a required property for UserSegmentBody and cannot be null");
            }
            else
            {
                this.Key = key;
            }
            this.Description = description;
            this.Tags = tags;
        }
        
        /// <summary>
        /// A human-friendly name for the user segment.
        /// </summary>
        /// <value>A human-friendly name for the user segment.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// A unique key that will be used to reference the user segment in feature flags.
        /// </summary>
        /// <value>A unique key that will be used to reference the user segment in feature flags.</value>
        [DataMember(Name="key", EmitDefaultValue=false)]
        public string Key { get; set; }

        /// <summary>
        /// A description for the user segment.
        /// </summary>
        /// <value>A description for the user segment.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Tags for the user segment.
        /// </summary>
        /// <value>Tags for the user segment.</value>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserSegmentBody {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
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
            return this.Equals(input as UserSegmentBody);
        }

        /// <summary>
        /// Returns true if UserSegmentBody instances are equal
        /// </summary>
        /// <param name="input">Instance of UserSegmentBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserSegmentBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
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
