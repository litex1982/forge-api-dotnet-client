/* 
 * Forge SDK
 *
 * The Forge Platform contains an expanding collection of web service components that can be used with Autodesk cloud-based products or your own technologies. Take advantage of Autodesk’s expertise in design and engineering.
 *
 * OpenAPI spec version: 0.1.0
 * Contact: forge.help@autodesk.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Autodesk.Forge.Model
{
    /// <summary>
    /// JsonApiErrorErrors
    /// </summary>
    [DataContract]
    public partial class JsonApiErrorErrors :  IEquatable<JsonApiErrorErrors>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JsonApiErrorErrors" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected JsonApiErrorErrors() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="JsonApiErrorErrors" /> class.
        /// </summary>
        /// <param name="Id">a unique identifier for this particular occurrence of the problem (required).</param>
        /// <param name="Status">the HTTP status code applicable to this problem, expressed as a string value (required).</param>
        /// <param name="Code">an application-specific error code, expressed as a string value.</param>
        /// <param name="Title">a short, human-readable summary of the problem that SHOULD NOT change from occurrence to occurrence of the problem, except for purposes of localization.</param>
        /// <param name="Detail">a human-readable explanation specific to this occurrence of the problem. Like title, this field&#39;s value can be localized (required).</param>
        /// <param name="Meta">a meta object containing non-standard meta-information about the error.</param>
        /// <param name="Links">Links.</param>
        public JsonApiErrorErrors(string Id = null, string Status = null, string Code = null, string Title = null, string Detail = null, Object Meta = null, JsonApiErrorLinks Links = null)
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for JsonApiErrorErrors and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "Status" is required (not null)
            if (Status == null)
            {
                throw new InvalidDataException("Status is a required property for JsonApiErrorErrors and cannot be null");
            }
            else
            {
                this.Status = Status;
            }
            // to ensure "Detail" is required (not null)
            if (Detail == null)
            {
                throw new InvalidDataException("Detail is a required property for JsonApiErrorErrors and cannot be null");
            }
            else
            {
                this.Detail = Detail;
            }
            this.Code = Code;
            this.Title = Title;
            this.Meta = Meta;
            this.Links = Links;
        }
        
        /// <summary>
        /// a unique identifier for this particular occurrence of the problem
        /// </summary>
        /// <value>a unique identifier for this particular occurrence of the problem</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// the HTTP status code applicable to this problem, expressed as a string value
        /// </summary>
        /// <value>the HTTP status code applicable to this problem, expressed as a string value</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
        /// <summary>
        /// an application-specific error code, expressed as a string value
        /// </summary>
        /// <value>an application-specific error code, expressed as a string value</value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }
        /// <summary>
        /// a short, human-readable summary of the problem that SHOULD NOT change from occurrence to occurrence of the problem, except for purposes of localization
        /// </summary>
        /// <value>a short, human-readable summary of the problem that SHOULD NOT change from occurrence to occurrence of the problem, except for purposes of localization</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }
        /// <summary>
        /// a human-readable explanation specific to this occurrence of the problem. Like title, this field&#39;s value can be localized
        /// </summary>
        /// <value>a human-readable explanation specific to this occurrence of the problem. Like title, this field&#39;s value can be localized</value>
        [DataMember(Name="detail", EmitDefaultValue=false)]
        public string Detail { get; set; }
        /// <summary>
        /// a meta object containing non-standard meta-information about the error
        /// </summary>
        /// <value>a meta object containing non-standard meta-information about the error</value>
        [DataMember(Name="meta", EmitDefaultValue=false)]
        public Object Meta { get; set; }
        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue=false)]
        public JsonApiErrorLinks Links { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JsonApiErrorErrors {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Detail: ").Append(Detail).Append("\n");
            sb.Append("  Meta: ").Append(Meta).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as JsonApiErrorErrors);
        }

        /// <summary>
        /// Returns true if JsonApiErrorErrors instances are equal
        /// </summary>
        /// <param name="other">Instance of JsonApiErrorErrors to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JsonApiErrorErrors other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.Code == other.Code ||
                    this.Code != null &&
                    this.Code.Equals(other.Code)
                ) && 
                (
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title)
                ) && 
                (
                    this.Detail == other.Detail ||
                    this.Detail != null &&
                    this.Detail.Equals(other.Detail)
                ) && 
                (
                    this.Meta == other.Meta ||
                    this.Meta != null &&
                    this.Meta.Equals(other.Meta)
                ) && 
                (
                    this.Links == other.Links ||
                    this.Links != null &&
                    this.Links.Equals(other.Links)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.Code != null)
                    hash = hash * 59 + this.Code.GetHashCode();
                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();
                if (this.Detail != null)
                    hash = hash * 59 + this.Detail.GetHashCode();
                if (this.Meta != null)
                    hash = hash * 59 + this.Meta.GetHashCode();
                if (this.Links != null)
                    hash = hash * 59 + this.Links.GetHashCode();
                return hash;
            }
        }
    }

}
