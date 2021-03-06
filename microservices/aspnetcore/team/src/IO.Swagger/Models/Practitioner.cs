/*
 * Allwissend Microservices API
 *
 * Allwissend Team API
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class Practitioner : IEquatable<Practitioner>
    { 
        /// <summary>
        /// Unique identifier representing a specific practitioner.
        /// </summary>
        /// <value>Unique identifier representing a specific practitioner.</value>
        [DataMember(Name="uuid")]
        public Guid? Uuid { get; set; }

        /// <summary>
        /// To do
        /// </summary>
        /// <value>To do</value>
        [DataMember(Name="active")]
        public bool? Active { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name")]
        public Name Name { get; set; }

        /// <summary>
        /// Gets or Sets Photo
        /// </summary>
        [DataMember(Name="photo")]
        public List<Attachment> Photo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Practitioner {\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Photo: ").Append(Photo).Append("\n");
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
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((Practitioner)obj);
        }

        /// <summary>
        /// Returns true if Practitioner instances are equal
        /// </summary>
        /// <param name="other">Instance of Practitioner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Practitioner other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Uuid == other.Uuid ||
                    Uuid != null &&
                    Uuid.Equals(other.Uuid)
                ) && 
                (
                    Active == other.Active ||
                    Active != null &&
                    Active.Equals(other.Active)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    Photo == other.Photo ||
                    Photo != null &&
                    Photo.SequenceEqual(other.Photo)
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
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (Uuid != null)
                    hashCode = hashCode * 59 + Uuid.GetHashCode();
                    if (Active != null)
                    hashCode = hashCode * 59 + Active.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (Photo != null)
                    hashCode = hashCode * 59 + Photo.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Practitioner left, Practitioner right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Practitioner left, Practitioner right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
