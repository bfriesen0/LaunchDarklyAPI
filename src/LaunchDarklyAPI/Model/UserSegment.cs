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
    /// UserSegment
    /// </summary>
    [DataContract]
    public partial class UserSegment :  IEquatable<UserSegment>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserSegment" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserSegment() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserSegment" /> class.
        /// </summary>
        /// <param name="key">Unique identifier for the user segment. (required).</param>
        /// <param name="name">Name of the user segment. (required).</param>
        /// <param name="description">Description of the user segment..</param>
        /// <param name="tags">An array of tags for this user segment..</param>
        /// <param name="creationDate">A unix epoch time in milliseconds specifying the creation time of this flag. (required).</param>
        /// <param name="included">An array of user keys that are included in this segment..</param>
        /// <param name="excluded">An array of user keys that should not be included in this segment, unless they are also listed in \&quot;included\&quot;..</param>
        /// <param name="rules">An array of rules that can cause a user to be included in this segment..</param>
        /// <param name="version">version.</param>
        /// <param name="links">links.</param>
        public UserSegment(string key = default(string), string name = default(string), string description = default(string), List<string> tags = default(List<string>), decimal? creationDate = default(decimal?), List<string> included = default(List<string>), List<string> excluded = default(List<string>), List<UserSegmentRule> rules = default(List<UserSegmentRule>), int? version = default(int?), Links links = default(Links))
        {
            // to ensure "key" is required (not null)
            if (key == null)
            {
                throw new InvalidDataException("key is a required property for UserSegment and cannot be null");
            }
            else
            {
                this.Key = key;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for UserSegment and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "creationDate" is required (not null)
            if (creationDate == null)
            {
                throw new InvalidDataException("creationDate is a required property for UserSegment and cannot be null");
            }
            else
            {
                this.CreationDate = creationDate;
            }
            this.Description = description;
            this.Tags = tags;
            this.Included = included;
            this.Excluded = excluded;
            this.Rules = rules;
            this.Version = version;
            this.Links = links;
        }
        
        /// <summary>
        /// Unique identifier for the user segment.
        /// </summary>
        /// <value>Unique identifier for the user segment.</value>
        [DataMember(Name="key", EmitDefaultValue=false)]
        public string Key { get; set; }

        /// <summary>
        /// Name of the user segment.
        /// </summary>
        /// <value>Name of the user segment.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Description of the user segment.
        /// </summary>
        /// <value>Description of the user segment.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// An array of tags for this user segment.
        /// </summary>
        /// <value>An array of tags for this user segment.</value>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// A unix epoch time in milliseconds specifying the creation time of this flag.
        /// </summary>
        /// <value>A unix epoch time in milliseconds specifying the creation time of this flag.</value>
        [DataMember(Name="creationDate", EmitDefaultValue=false)]
        public decimal? CreationDate { get; set; }

        /// <summary>
        /// An array of user keys that are included in this segment.
        /// </summary>
        /// <value>An array of user keys that are included in this segment.</value>
        [DataMember(Name="included", EmitDefaultValue=false)]
        public List<string> Included { get; set; }

        /// <summary>
        /// An array of user keys that should not be included in this segment, unless they are also listed in \&quot;included\&quot;.
        /// </summary>
        /// <value>An array of user keys that should not be included in this segment, unless they are also listed in \&quot;included\&quot;.</value>
        [DataMember(Name="excluded", EmitDefaultValue=false)]
        public List<string> Excluded { get; set; }

        /// <summary>
        /// An array of rules that can cause a user to be included in this segment.
        /// </summary>
        /// <value>An array of rules that can cause a user to be included in this segment.</value>
        [DataMember(Name="rules", EmitDefaultValue=false)]
        public List<UserSegmentRule> Rules { get; set; }

        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="_links", EmitDefaultValue=false)]
        public Links Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserSegment {\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
            sb.Append("  Included: ").Append(Included).Append("\n");
            sb.Append("  Excluded: ").Append(Excluded).Append("\n");
            sb.Append("  Rules: ").Append(Rules).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
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
            return this.Equals(input as UserSegment);
        }

        /// <summary>
        /// Returns true if UserSegment instances are equal
        /// </summary>
        /// <param name="input">Instance of UserSegment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserSegment input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                ) && 
                (
                    this.CreationDate == input.CreationDate ||
                    (this.CreationDate != null &&
                    this.CreationDate.Equals(input.CreationDate))
                ) && 
                (
                    this.Included == input.Included ||
                    this.Included != null &&
                    this.Included.SequenceEqual(input.Included)
                ) && 
                (
                    this.Excluded == input.Excluded ||
                    this.Excluded != null &&
                    this.Excluded.SequenceEqual(input.Excluded)
                ) && 
                (
                    this.Rules == input.Rules ||
                    this.Rules != null &&
                    this.Rules.SequenceEqual(input.Rules)
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.Links == input.Links ||
                    (this.Links != null &&
                    this.Links.Equals(input.Links))
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
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.CreationDate != null)
                    hashCode = hashCode * 59 + this.CreationDate.GetHashCode();
                if (this.Included != null)
                    hashCode = hashCode * 59 + this.Included.GetHashCode();
                if (this.Excluded != null)
                    hashCode = hashCode * 59 + this.Excluded.GetHashCode();
                if (this.Rules != null)
                    hashCode = hashCode * 59 + this.Rules.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
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