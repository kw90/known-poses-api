/* 
 * Known Pose API
 *
 * Define and retrieve (accurate) semantic poses in a 2D environment. This version is a workaround for some not yet available features of the OpenAPI Specification v3.0 (e.g. `anyOf` as a response type and adding a  `discriminator` for supporting polymorphism/composition). Therefore, ATM the sub-components BasicPose and InaccuratePose are reference objects inside their respective parent model.  
 *
 * OpenAPI spec version: 1.1.0
 * Contact: Kai.Waelti@dfki.de
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
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// An basic Pose in free space composed of position and orientation.
    /// </summary>
    [DataContract]
        public partial class BasicPose :  IEquatable<BasicPose>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BasicPose" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="position">position (required).</param>
        /// <param name="orientation">orientation (required).</param>
        public BasicPose(string name = default(string), Position position = default(Position), Orientation orientation = default(Orientation))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for BasicPose and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "position" is required (not null)
            if (position == null)
            {
                throw new InvalidDataException("position is a required property for BasicPose and cannot be null");
            }
            else
            {
                this.Position = position;
            }
            // to ensure "orientation" is required (not null)
            if (orientation == null)
            {
                throw new InvalidDataException("orientation is a required property for BasicPose and cannot be null");
            }
            else
            {
                this.Orientation = orientation;
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BasicPose {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  Orientation: ").Append(Orientation).Append("\n");
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
            return this.Equals(input as BasicPose);
        }

        /// <summary>
        /// Returns true if BasicPose instances are equal
        /// </summary>
        /// <param name="input">Instance of BasicPose to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BasicPose input)
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
