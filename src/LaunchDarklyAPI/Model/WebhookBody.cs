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
    /// WebhookBody
    /// </summary>
    [DataContract]
    public partial class WebhookBody :  IEquatable<WebhookBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookBody" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WebhookBody() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookBody" /> class.
        /// </summary>
        /// <param name="url">The URL of the remote webhook. (required).</param>
        /// <param name="secret">If sign is true, and the secret attribute is omitted, LaunchDarkly will automatically generate a secret for you..</param>
        /// <param name="sign">If sign is false, the webhook will not include a signature header, and the secret can be omitted. (required).</param>
        /// <param name="on">Whether this webhook is enabled or not. (required).</param>
        /// <param name="name">The name of the webhook..</param>
        public WebhookBody(string url = default(string), string secret = default(string), bool? sign = default(bool?), bool? on = default(bool?), string name = default(string))
        {
            // to ensure "url" is required (not null)
            if (url == null)
            {
                throw new InvalidDataException("url is a required property for WebhookBody and cannot be null");
            }
            else
            {
                this.Url = url;
            }
            // to ensure "sign" is required (not null)
            if (sign == null)
            {
                throw new InvalidDataException("sign is a required property for WebhookBody and cannot be null");
            }
            else
            {
                this.Sign = sign;
            }
            // to ensure "on" is required (not null)
            if (on == null)
            {
                throw new InvalidDataException("on is a required property for WebhookBody and cannot be null");
            }
            else
            {
                this.On = on;
            }
            this.Secret = secret;
            this.Name = name;
        }
        
        /// <summary>
        /// The URL of the remote webhook.
        /// </summary>
        /// <value>The URL of the remote webhook.</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }

        /// <summary>
        /// If sign is true, and the secret attribute is omitted, LaunchDarkly will automatically generate a secret for you.
        /// </summary>
        /// <value>If sign is true, and the secret attribute is omitted, LaunchDarkly will automatically generate a secret for you.</value>
        [DataMember(Name="secret", EmitDefaultValue=false)]
        public string Secret { get; set; }

        /// <summary>
        /// If sign is false, the webhook will not include a signature header, and the secret can be omitted.
        /// </summary>
        /// <value>If sign is false, the webhook will not include a signature header, and the secret can be omitted.</value>
        [DataMember(Name="sign", EmitDefaultValue=false)]
        public bool? Sign { get; set; }

        /// <summary>
        /// Whether this webhook is enabled or not.
        /// </summary>
        /// <value>Whether this webhook is enabled or not.</value>
        [DataMember(Name="on", EmitDefaultValue=false)]
        public bool? On { get; set; }

        /// <summary>
        /// The name of the webhook.
        /// </summary>
        /// <value>The name of the webhook.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebhookBody {\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Secret: ").Append(Secret).Append("\n");
            sb.Append("  Sign: ").Append(Sign).Append("\n");
            sb.Append("  On: ").Append(On).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as WebhookBody);
        }

        /// <summary>
        /// Returns true if WebhookBody instances are equal
        /// </summary>
        /// <param name="input">Instance of WebhookBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhookBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.Secret == input.Secret ||
                    (this.Secret != null &&
                    this.Secret.Equals(input.Secret))
                ) && 
                (
                    this.Sign == input.Sign ||
                    (this.Sign != null &&
                    this.Sign.Equals(input.Sign))
                ) && 
                (
                    this.On == input.On ||
                    (this.On != null &&
                    this.On.Equals(input.On))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.Secret != null)
                    hashCode = hashCode * 59 + this.Secret.GetHashCode();
                if (this.Sign != null)
                    hashCode = hashCode * 59 + this.Sign.GetHashCode();
                if (this.On != null)
                    hashCode = hashCode * 59 + this.On.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
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
