/*
 * Allwissend Microservices API
 *
 * Allwissend Auth API
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

namespace Allwissend.AllPlan.Auth.Models
{ 
    /// <summary>
    /// Time period when contact was/is in use. Allows contact to be placed in historical context.
    /// </summary>
    [DataContract]
    public partial class JWToken : IEquatable<JWToken>
    { 
        /// <summary>
        /// Issuer
        /// </summary>
        /// <value>Issuer</value>
        [DataMember(Name="iss")]
        public string Iss { get; set; }

        /// <summary>
        /// Subject
        /// </summary>
        /// <value>Subject</value>
        [DataMember(Name="sub")]
        public string Sub { get; set; }

        /// <summary>
        /// Audience
        /// </summary>
        /// <value>Audience</value>
        [DataMember(Name="aud")]
        public string Aud { get; set; }

        /// <summary>
        /// Expiration Time
        /// </summary>
        /// <value>Expiration Time</value>
        [DataMember(Name="exp")]
        public string Exp { get; set; }

        /// <summary>
        /// Not Before
        /// </summary>
        /// <value>Not Before</value>
        [DataMember(Name="nbf")]
        public string Nbf { get; set; }

        /// <summary>
        /// Issued At
        /// </summary>
        /// <value>Issued At</value>
        [DataMember(Name="iat")]
        public string Iat { get; set; }

        /// <summary>
        /// JWT ID
        /// </summary>
        /// <value>JWT ID</value>
        [DataMember(Name="jti")]
        public string Jti { get; set; }

        /// <summary>
        /// Unique identifier representing a specific user.
        /// </summary>
        /// <value>Unique identifier representing a specific user.</value>
        [DataMember(Name="uuid")]
        public Guid? Uuid { get; set; }

        /// <summary>
        /// Full name
        /// </summary>
        /// <value>Full name</value>
        [DataMember(Name="name")]
        public string Name { get; set; }

        /// <summary>
        /// Given name(s) or first name(s)
        /// </summary>
        /// <value>Given name(s) or first name(s)</value>
        [DataMember(Name="given_name")]
        public string GivenName { get; set; }

        /// <summary>
        /// Casual name
        /// </summary>
        /// <value>Casual name</value>
        [DataMember(Name="nickname")]
        public string Nickname { get; set; }

        /// <summary>
        /// Preferred e-mail address
        /// </summary>
        /// <value>Preferred e-mail address</value>
        [DataMember(Name="email")]
        public string Email { get; set; }

        /// <summary>
        /// True if the e-mail address has been verified; otherwise false
        /// </summary>
        /// <value>True if the e-mail address has been verified; otherwise false</value>
        [DataMember(Name="email_verified")]
        public bool? EmailVerified { get; set; }

        /// <summary>
        /// Time zone
        /// </summary>
        /// <value>Time zone</value>
        [DataMember(Name="zoneinfo")]
        public string Zoneinfo { get; set; }

        /// <summary>
        /// Locale
        /// </summary>
        /// <value>Locale</value>
        [DataMember(Name="locale")]
        public string Locale { get; set; }

        /// <summary>
        /// Confirmation
        /// </summary>
        /// <value>Confirmation</value>
        [DataMember(Name="cnf")]
        public string Cnf { get; set; }

        /// <summary>
        /// Originating Identity String
        /// </summary>
        /// <value>Originating Identity String</value>
        [DataMember(Name="orig")]
        public string Orig { get; set; }

        /// <summary>
        /// Destination Identity String
        /// </summary>
        /// <value>Destination Identity String</value>
        [DataMember(Name="dest")]
        public string Dest { get; set; }

        /// <summary>
        /// Media Key Fingerprint String
        /// </summary>
        /// <value>Media Key Fingerprint String</value>
        [DataMember(Name="mky")]
        public string Mky { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JWToken {\n");
            sb.Append("  Iss: ").Append(Iss).Append("\n");
            sb.Append("  Sub: ").Append(Sub).Append("\n");
            sb.Append("  Aud: ").Append(Aud).Append("\n");
            sb.Append("  Exp: ").Append(Exp).Append("\n");
            sb.Append("  Nbf: ").Append(Nbf).Append("\n");
            sb.Append("  Iat: ").Append(Iat).Append("\n");
            sb.Append("  Jti: ").Append(Jti).Append("\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  GivenName: ").Append(GivenName).Append("\n");
            sb.Append("  Nickname: ").Append(Nickname).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  EmailVerified: ").Append(EmailVerified).Append("\n");
            sb.Append("  Zoneinfo: ").Append(Zoneinfo).Append("\n");
            sb.Append("  Locale: ").Append(Locale).Append("\n");
            sb.Append("  Cnf: ").Append(Cnf).Append("\n");
            sb.Append("  Orig: ").Append(Orig).Append("\n");
            sb.Append("  Dest: ").Append(Dest).Append("\n");
            sb.Append("  Mky: ").Append(Mky).Append("\n");
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
            return obj.GetType() == GetType() && Equals((JWToken)obj);
        }

        /// <summary>
        /// Returns true if JWToken instances are equal
        /// </summary>
        /// <param name="other">Instance of JWToken to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JWToken other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Iss == other.Iss ||
                    Iss != null &&
                    Iss.Equals(other.Iss)
                ) && 
                (
                    Sub == other.Sub ||
                    Sub != null &&
                    Sub.Equals(other.Sub)
                ) && 
                (
                    Aud == other.Aud ||
                    Aud != null &&
                    Aud.Equals(other.Aud)
                ) && 
                (
                    Exp == other.Exp ||
                    Exp != null &&
                    Exp.Equals(other.Exp)
                ) && 
                (
                    Nbf == other.Nbf ||
                    Nbf != null &&
                    Nbf.Equals(other.Nbf)
                ) && 
                (
                    Iat == other.Iat ||
                    Iat != null &&
                    Iat.Equals(other.Iat)
                ) && 
                (
                    Jti == other.Jti ||
                    Jti != null &&
                    Jti.Equals(other.Jti)
                ) && 
                (
                    Uuid == other.Uuid ||
                    Uuid != null &&
                    Uuid.Equals(other.Uuid)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    GivenName == other.GivenName ||
                    GivenName != null &&
                    GivenName.Equals(other.GivenName)
                ) && 
                (
                    Nickname == other.Nickname ||
                    Nickname != null &&
                    Nickname.Equals(other.Nickname)
                ) && 
                (
                    Email == other.Email ||
                    Email != null &&
                    Email.Equals(other.Email)
                ) && 
                (
                    EmailVerified == other.EmailVerified ||
                    EmailVerified != null &&
                    EmailVerified.Equals(other.EmailVerified)
                ) && 
                (
                    Zoneinfo == other.Zoneinfo ||
                    Zoneinfo != null &&
                    Zoneinfo.Equals(other.Zoneinfo)
                ) && 
                (
                    Locale == other.Locale ||
                    Locale != null &&
                    Locale.Equals(other.Locale)
                ) && 
                (
                    Cnf == other.Cnf ||
                    Cnf != null &&
                    Cnf.Equals(other.Cnf)
                ) && 
                (
                    Orig == other.Orig ||
                    Orig != null &&
                    Orig.Equals(other.Orig)
                ) && 
                (
                    Dest == other.Dest ||
                    Dest != null &&
                    Dest.Equals(other.Dest)
                ) && 
                (
                    Mky == other.Mky ||
                    Mky != null &&
                    Mky.Equals(other.Mky)
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
                    if (Iss != null)
                    hashCode = hashCode * 59 + Iss.GetHashCode();
                    if (Sub != null)
                    hashCode = hashCode * 59 + Sub.GetHashCode();
                    if (Aud != null)
                    hashCode = hashCode * 59 + Aud.GetHashCode();
                    if (Exp != null)
                    hashCode = hashCode * 59 + Exp.GetHashCode();
                    if (Nbf != null)
                    hashCode = hashCode * 59 + Nbf.GetHashCode();
                    if (Iat != null)
                    hashCode = hashCode * 59 + Iat.GetHashCode();
                    if (Jti != null)
                    hashCode = hashCode * 59 + Jti.GetHashCode();
                    if (Uuid != null)
                    hashCode = hashCode * 59 + Uuid.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (GivenName != null)
                    hashCode = hashCode * 59 + GivenName.GetHashCode();
                    if (Nickname != null)
                    hashCode = hashCode * 59 + Nickname.GetHashCode();
                    if (Email != null)
                    hashCode = hashCode * 59 + Email.GetHashCode();
                    if (EmailVerified != null)
                    hashCode = hashCode * 59 + EmailVerified.GetHashCode();
                    if (Zoneinfo != null)
                    hashCode = hashCode * 59 + Zoneinfo.GetHashCode();
                    if (Locale != null)
                    hashCode = hashCode * 59 + Locale.GetHashCode();
                    if (Cnf != null)
                    hashCode = hashCode * 59 + Cnf.GetHashCode();
                    if (Orig != null)
                    hashCode = hashCode * 59 + Orig.GetHashCode();
                    if (Dest != null)
                    hashCode = hashCode * 59 + Dest.GetHashCode();
                    if (Mky != null)
                    hashCode = hashCode * 59 + Mky.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(JWToken left, JWToken right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(JWToken left, JWToken right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
