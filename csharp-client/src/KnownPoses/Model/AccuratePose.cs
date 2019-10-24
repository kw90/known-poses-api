/* 
 * Known Pose API
 *
 * Get and set (accurate) semantic poses for an environment.
 *
 * The version of the OpenAPI document: 1.1.0
 * Contact: Kai.Waelti@dfki.de
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using OpenAPIDateConverter = KnownPoses.Client.OpenAPIDateConverter;

namespace KnownPoses.Model
{
    /// <summary>
    /// AccuratePose
    /// </summary>
    [DataContract]
    public partial class AccuratePose :  IEquatable<AccuratePose>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccuratePose" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AccuratePose() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccuratePose" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="position">position (required).</param>
        /// <param name="orientation">orientation (required).</param>
        /// <param name="id">id (required).</param>
        /// <param name="takenAt">takenAt (required).</param>
        /// <param name="referenceScan">Contents of the reference scan assembled as point cloud data following [RFC 4648 § 5](https://tools.ietf.org/html/rfc4648#section-5) (required).</param>
        public AccuratePose(string name = default(string), Position position = default(Position), Orientation orientation = default(Orientation), Guid id = default(Guid), DateTime takenAt = default(DateTime), string referenceScan = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for AccuratePose and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            
            // to ensure "position" is required (not null)
            if (position == null)
            {
                throw new InvalidDataException("position is a required property for AccuratePose and cannot be null");
            }
            else
            {
                this.Position = position;
            }
            
            // to ensure "orientation" is required (not null)
            if (orientation == null)
            {
                throw new InvalidDataException("orientation is a required property for AccuratePose and cannot be null");
            }
            else
            {
                this.Orientation = orientation;
            }
            
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for AccuratePose and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            
            // to ensure "takenAt" is required (not null)
            if (takenAt == null)
            {
                throw new InvalidDataException("takenAt is a required property for AccuratePose and cannot be null");
            }
            else
            {
                this.TakenAt = takenAt;
            }
            
            // to ensure "referenceScan" is required (not null)
            if (referenceScan == null)
            {
                throw new InvalidDataException("referenceScan is a required property for AccuratePose and cannot be null");
            }
            else
            {
                this.ReferenceScan = referenceScan;
            }
            
        }
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Position
        /// </summary>
        [DataMember(Name="position", EmitDefaultValue=false)]
        public Position Position { get; set; }

        /// <summary>
        /// Gets or Sets Orientation
        /// </summary>
        [DataMember(Name="orientation", EmitDefaultValue=false)]
        public Orientation Orientation { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets TakenAt
        /// </summary>
        [DataMember(Name="taken_at", EmitDefaultValue=false)]
        public DateTime TakenAt { get; set; }

        /// <summary>
        /// Contents of the reference scan assembled as point cloud data following [RFC 4648 § 5](https://tools.ietf.org/html/rfc4648#section-5)
        /// </summary>
        /// <value>Contents of the reference scan assembled as point cloud data following [RFC 4648 § 5](https://tools.ietf.org/html/rfc4648#section-5)</value>
        [DataMember(Name="reference_scan", EmitDefaultValue=false)]
        public string ReferenceScan { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccuratePose {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  Orientation: ").Append(Orientation).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TakenAt: ").Append(TakenAt).Append("\n");
            sb.Append("  ReferenceScan: ").Append(ReferenceScan).Append("\n");
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
            return this.Equals(input as AccuratePose);
        }

        /// <summary>
        /// Returns true if AccuratePose instances are equal
        /// </summary>
        /// <param name="input">Instance of AccuratePose to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccuratePose input)
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
                    this.Position == input.Position ||
                    (this.Position != null &&
                    this.Position.Equals(input.Position))
                ) && 
                (
                    this.Orientation == input.Orientation ||
                    (this.Orientation != null &&
                    this.Orientation.Equals(input.Orientation))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.TakenAt == input.TakenAt ||
                    (this.TakenAt != null &&
                    this.TakenAt.Equals(input.TakenAt))
                ) && 
                (
                    this.ReferenceScan == input.ReferenceScan ||
                    (this.ReferenceScan != null &&
                    this.ReferenceScan.Equals(input.ReferenceScan))
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
                if (this.Position != null)
                    hashCode = hashCode * 59 + this.Position.GetHashCode();
                if (this.Orientation != null)
                    hashCode = hashCode * 59 + this.Orientation.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.TakenAt != null)
                    hashCode = hashCode * 59 + this.TakenAt.GetHashCode();
                if (this.ReferenceScan != null)
                    hashCode = hashCode * 59 + this.ReferenceScan.GetHashCode();
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
