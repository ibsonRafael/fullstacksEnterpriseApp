/*
 * Allwissend Microservices API
 *
 * Allwissend Practitioner API
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

namespace Allwissend.AllPlan.Practitioner.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class Qualification : IEquatable<Qualification>
    { 
        /// <summary>
        /// Unique identifier
        /// </summary>
        /// <value>Unique identifier</value>
        [Required]
        [DataMember(Name="uuid")]
        public Guid? Uuid { get; set; }

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [Required]
        [DataMember(Name="code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets Text
        /// </summary>
        [DataMember(Name="text")]
        public string Text { get; set; }

        /// <summary>
        /// Gets or Sets Period
        /// </summary>
        [DataMember(Name="period")]
        public QualificationPeriod Period { get; set; }

        /// <summary>
        /// Gets or Sets Issuer
        /// </summary>
        [DataMember(Name="issuer")]
        public string Issuer { get; set; }

        /// <summary>
        /// Date qualification was first created
        /// </summary>
        /// <value>Date qualification was first created</value>
        [DataMember(Name="creation")]
        public string Creation { get; set; }

        /// <summary>
        /// Date qualification was last updated
        /// </summary>
        /// <value>Date qualification was last updated</value>
        [DataMember(Name="lastUpdated")]
        public string LastUpdated { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Qualification {\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Period: ").Append(Period).Append("\n");
            sb.Append("  Issuer: ").Append(Issuer).Append("\n");
            sb.Append("  Creation: ").Append(Creation).Append("\n");
            sb.Append("  LastUpdated: ").Append(LastUpdated).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Qualification)obj);
        }

        /// <summary>
        /// Returns true if Qualification instances are equal
        /// </summary>
        /// <param name="other">Instance of Qualification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Qualification other)
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
                    Code == other.Code ||
                    Code != null &&
                    Code.Equals(other.Code)
                ) && 
                (
                    Text == other.Text ||
                    Text != null &&
                    Text.Equals(other.Text)
                ) && 
                (
                    Period == other.Period ||
                    Period != null &&
                    Period.Equals(other.Period)
                ) && 
                (
                    Issuer == other.Issuer ||
                    Issuer != null &&
                    Issuer.Equals(other.Issuer)
                ) && 
                (
                    Creation == other.Creation ||
                    Creation != null &&
                    Creation.Equals(other.Creation)
                ) && 
                (
                    LastUpdated == other.LastUpdated ||
                    LastUpdated != null &&
                    LastUpdated.Equals(other.LastUpdated)
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
                    if (Code != null)
                    hashCode = hashCode * 59 + Code.GetHashCode();
                    if (Text != null)
                    hashCode = hashCode * 59 + Text.GetHashCode();
                    if (Period != null)
                    hashCode = hashCode * 59 + Period.GetHashCode();
                    if (Issuer != null)
                    hashCode = hashCode * 59 + Issuer.GetHashCode();
                    if (Creation != null)
                    hashCode = hashCode * 59 + Creation.GetHashCode();
                    if (LastUpdated != null)
                    hashCode = hashCode * 59 + LastUpdated.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Qualification left, Qualification right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Qualification left, Qualification right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
