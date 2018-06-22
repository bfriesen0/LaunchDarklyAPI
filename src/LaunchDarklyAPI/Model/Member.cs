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
    /// Member
    /// </summary>
    [DataContract]
    public partial class Member :  IEquatable<Member>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Role
        /// </summary>
        [DataMember(Name="role", EmitDefaultValue=false)]
        public Role? Role { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Member" /> class.
        /// </summary>
        /// <param name="links">links.</param>
        /// <param name="id">id.</param>
        /// <param name="role">role.</param>
        /// <param name="email">email.</param>
        /// <param name="pendingInvite">pendingInvite.</param>
        /// <param name="isBeta">isBeta.</param>
        /// <param name="customRoles">customRoles.</param>
        public Member(Links links = default(Links), Id id = default(Id), Role? role = default(Role?), string email = default(string), bool? pendingInvite = default(bool?), bool? isBeta = default(bool?), List<Id> customRoles = default(List<Id>))
        {
            this.Links = links;
            this.Id = id;
            this.Role = role;
            this.Email = email;
            this.PendingInvite = pendingInvite;
            this.IsBeta = isBeta;
            this.CustomRoles = customRoles;
        }
        
        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="_links", EmitDefaultValue=false)]
        public Links Links { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="_id", EmitDefaultValue=false)]
        public Id Id { get; set; }


        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets PendingInvite
        /// </summary>
        [DataMember(Name="_pendingInvite", EmitDefaultValue=false)]
        public bool? PendingInvite { get; set; }

        /// <summary>
        /// Gets or Sets IsBeta
        /// </summary>
        [DataMember(Name="isBeta", EmitDefaultValue=false)]
        public bool? IsBeta { get; set; }

        /// <summary>
        /// Gets or Sets CustomRoles
        /// </summary>
        [DataMember(Name="customRoles", EmitDefaultValue=false)]
        public List<Id> CustomRoles { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Member {\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  PendingInvite: ").Append(PendingInvite).Append("\n");
            sb.Append("  IsBeta: ").Append(IsBeta).Append("\n");
            sb.Append("  CustomRoles: ").Append(CustomRoles).Append("\n");
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
            return this.Equals(input as Member);
        }

        /// <summary>
        /// Returns true if Member instances are equal
        /// </summary>
        /// <param name="input">Instance of Member to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Member input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Links == input.Links ||
                    (this.Links != null &&
                    this.Links.Equals(input.Links))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Role == input.Role ||
                    (this.Role != null &&
                    this.Role.Equals(input.Role))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.PendingInvite == input.PendingInvite ||
                    (this.PendingInvite != null &&
                    this.PendingInvite.Equals(input.PendingInvite))
                ) && 
                (
                    this.IsBeta == input.IsBeta ||
                    (this.IsBeta != null &&
                    this.IsBeta.Equals(input.IsBeta))
                ) && 
                (
                    this.CustomRoles == input.CustomRoles ||
                    this.CustomRoles != null &&
                    this.CustomRoles.SequenceEqual(input.CustomRoles)
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
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Role != null)
                    hashCode = hashCode * 59 + this.Role.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.PendingInvite != null)
                    hashCode = hashCode * 59 + this.PendingInvite.GetHashCode();
                if (this.IsBeta != null)
                    hashCode = hashCode * 59 + this.IsBeta.GetHashCode();
                if (this.CustomRoles != null)
                    hashCode = hashCode * 59 + this.CustomRoles.GetHashCode();
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