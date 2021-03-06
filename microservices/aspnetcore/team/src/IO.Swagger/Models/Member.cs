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
    /// Member?!
    /// </summary>
    [DataContract]
    public partial class Member : IEquatable<Member>
    { 
        /// <summary>
        /// Unique identifier representing a specific member
        /// </summary>
        /// <value>Unique identifier representing a specific member</value>
        [DataMember(Name="uuid")]
        public Guid? Uuid { get; set; }

        /// <summary>
        /// Gets or Sets Period
        /// </summary>
        [DataMember(Name="period")]
        public Period Period { get; set; }

        /// <summary>
        /// Gets or Sets Practitioner
        /// </summary>
        [DataMember(Name="practitioner")]
        public Practitioner Practitioner { get; set; }
        /// <summary>
        /// type....
        /// </summary>
        /// <value>type....</value>
        public enum TypeEnum
        { 
            /// <summary>
            /// Enum PermanentEnum for permanent
            /// </summary>
            [EnumMember(Value = "permanent")]
            PermanentEnum = 1,
            
            /// <summary>
            /// Enum TemporaryEnum for temporary
            /// </summary>
            [EnumMember(Value = "temporary")]
            TemporaryEnum = 2,
            
            /// <summary>
            /// Enum LoanedEnum for loaned
            /// </summary>
            [EnumMember(Value = "loaned")]
            LoanedEnum = 3,
            
            /// <summary>
            /// Enum OutsourcedEnum for outsourced
            /// </summary>
            [EnumMember(Value = "outsourced")]
            OutsourcedEnum = 4,
            
            /// <summary>
            /// Enum RentedEnum for rented
            /// </summary>
            [EnumMember(Value = "rented")]
            RentedEnum = 5
        }

        /// <summary>
        /// type....
        /// </summary>
        /// <value>type....</value>
        [DataMember(Name="type")]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Status...
        /// </summary>
        /// <value>Status...</value>
        public enum StatusEnum
        { 
            /// <summary>
            /// Enum EvaluationEnum for evaluation
            /// </summary>
            [EnumMember(Value = "evaluation")]
            EvaluationEnum = 1,
            
            /// <summary>
            /// Enum NotStartedEnum for not_started
            /// </summary>
            [EnumMember(Value = "not_started")]
            NotStartedEnum = 2,
            
            /// <summary>
            /// Enum InHiringEnum for in_hiring
            /// </summary>
            [EnumMember(Value = "in_hiring")]
            InHiringEnum = 3,
            
            /// <summary>
            /// Enum InTrainingEnum for in_training
            /// </summary>
            [EnumMember(Value = "in_training")]
            InTrainingEnum = 4,
            
            /// <summary>
            /// Enum AbsentEnum for absent
            /// </summary>
            [EnumMember(Value = "absent")]
            AbsentEnum = 5,
            
            /// <summary>
            /// Enum LunchEnum for lunch
            /// </summary>
            [EnumMember(Value = "lunch")]
            LunchEnum = 6,
            
            /// <summary>
            /// Enum PresentEnum for present
            /// </summary>
            [EnumMember(Value = "present")]
            PresentEnum = 7,
            
            /// <summary>
            /// Enum LoanedEnum for loaned
            /// </summary>
            [EnumMember(Value = "loaned")]
            LoanedEnum = 8,
            
            /// <summary>
            /// Enum WorkingEnum for working
            /// </summary>
            [EnumMember(Value = "working")]
            WorkingEnum = 9,
            
            /// <summary>
            /// Enum StoppedEnum for stopped
            /// </summary>
            [EnumMember(Value = "stopped")]
            StoppedEnum = 10,
            
            /// <summary>
            /// Enum LossEnum for loss
            /// </summary>
            [EnumMember(Value = "loss")]
            LossEnum = 11,
            
            /// <summary>
            /// Enum InjuredEnum for injured
            /// </summary>
            [EnumMember(Value = "injured")]
            InjuredEnum = 12,
            
            /// <summary>
            /// Enum AwayEnum for away
            /// </summary>
            [EnumMember(Value = "away")]
            AwayEnum = 13
        }

        /// <summary>
        /// Status...
        /// </summary>
        /// <value>Status...</value>
        [DataMember(Name="status")]
        public StatusEnum? Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Member {\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
            sb.Append("  Period: ").Append(Period).Append("\n");
            sb.Append("  Practitioner: ").Append(Practitioner).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Member)obj);
        }

        /// <summary>
        /// Returns true if Member instances are equal
        /// </summary>
        /// <param name="other">Instance of Member to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Member other)
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
                    Period == other.Period ||
                    Period != null &&
                    Period.Equals(other.Period)
                ) && 
                (
                    Practitioner == other.Practitioner ||
                    Practitioner != null &&
                    Practitioner.Equals(other.Practitioner)
                ) && 
                (
                    Type == other.Type ||
                    Type != null &&
                    Type.Equals(other.Type)
                ) && 
                (
                    Status == other.Status ||
                    Status != null &&
                    Status.Equals(other.Status)
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
                    if (Period != null)
                    hashCode = hashCode * 59 + Period.GetHashCode();
                    if (Practitioner != null)
                    hashCode = hashCode * 59 + Practitioner.GetHashCode();
                    if (Type != null)
                    hashCode = hashCode * 59 + Type.GetHashCode();
                    if (Status != null)
                    hashCode = hashCode * 59 + Status.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Member left, Member right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Member left, Member right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
