/* 
 * Swagger Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * OpenAPI spec version: 1.0.0
 * Contact: apiteam@swagger.io
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
    /// Body3
    /// </summary>
    [DataContract]
        public partial class Body3 :  IEquatable<Body3>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Body3" /> class.
        /// </summary>
        /// <param name="integer">None.</param>
        /// <param name="int32">None.</param>
        /// <param name="int64">None.</param>
        /// <param name="number">None (required).</param>
        /// <param name="_float">None.</param>
        /// <param name="_double">None (required).</param>
        /// <param name="_string">None.</param>
        /// <param name="patternWithoutDelimiter">None (required).</param>
        /// <param name="_byte">None (required).</param>
        /// <param name="binary">None.</param>
        /// <param name="date">None.</param>
        /// <param name="dateTime">None.</param>
        /// <param name="password">None.</param>
        /// <param name="callback">None.</param>
        public Body3(int? integer = default(int?), int? int32 = default(int?), long? int64 = default(long?), decimal? number = default(decimal?), float? _float = default(float?), double? _double = default(double?), string _string = default(string), string patternWithoutDelimiter = default(string), byte[] _byte = default(byte[]), byte[] binary = default(byte[]), DateTime? date = default(DateTime?), DateTime? dateTime = default(DateTime?), string password = default(string), string callback = default(string))
        {
            // to ensure "number" is required (not null)
            if (number == null)
            {
                throw new InvalidDataException("number is a required property for Body3 and cannot be null");
            }
            else
            {
                this.Number = number;
            }
            // to ensure "_double" is required (not null)
            if (_double == null)
            {
                throw new InvalidDataException("_double is a required property for Body3 and cannot be null");
            }
            else
            {
                this._Double = _double;
            }
            // to ensure "patternWithoutDelimiter" is required (not null)
            if (patternWithoutDelimiter == null)
            {
                throw new InvalidDataException("patternWithoutDelimiter is a required property for Body3 and cannot be null");
            }
            else
            {
                this.PatternWithoutDelimiter = patternWithoutDelimiter;
            }
            // to ensure "_byte" is required (not null)
            if (_byte == null)
            {
                throw new InvalidDataException("_byte is a required property for Body3 and cannot be null");
            }
            else
            {
                this._Byte = _byte;
            }
            this.Integer = integer;
            this.Int32 = int32;
            this.Int64 = int64;
            this._Float = _float;
            this._String = _string;
            this.Binary = binary;
            this.Date = date;
            this.DateTime = dateTime;
            this.Password = password;
            this.Callback = callback;
        }
        
        /// <summary>
        /// None
        /// </summary>
        /// <value>None</value>
        [DataMember(Name="integer", EmitDefaultValue=false)]
        public int? Integer { get; set; }

        /// <summary>
        /// None
        /// </summary>
        /// <value>None</value>
        [DataMember(Name="int32", EmitDefaultValue=false)]
        public int? Int32 { get; set; }

        /// <summary>
        /// None
        /// </summary>
        /// <value>None</value>
        [DataMember(Name="int64", EmitDefaultValue=false)]
        public long? Int64 { get; set; }

        /// <summary>
        /// None
        /// </summary>
        /// <value>None</value>
        [DataMember(Name="number", EmitDefaultValue=false)]
        public decimal? Number { get; set; }

        /// <summary>
        /// None
        /// </summary>
        /// <value>None</value>
        [DataMember(Name="float", EmitDefaultValue=false)]
        public float? _Float { get; set; }

        /// <summary>
        /// None
        /// </summary>
        /// <value>None</value>
        [DataMember(Name="double", EmitDefaultValue=false)]
        public double? _Double { get; set; }

        /// <summary>
        /// None
        /// </summary>
        /// <value>None</value>
        [DataMember(Name="string", EmitDefaultValue=false)]
        public string _String { get; set; }

        /// <summary>
        /// None
        /// </summary>
        /// <value>None</value>
        [DataMember(Name="pattern_without_delimiter", EmitDefaultValue=false)]
        public string PatternWithoutDelimiter { get; set; }

        /// <summary>
        /// None
        /// </summary>
        /// <value>None</value>
        [DataMember(Name="byte", EmitDefaultValue=false)]
        public byte[] _Byte { get; set; }

        /// <summary>
        /// None
        /// </summary>
        /// <value>None</value>
        [DataMember(Name="binary", EmitDefaultValue=false)]
        public byte[] Binary { get; set; }

        /// <summary>
        /// None
        /// </summary>
        /// <value>None</value>
        [DataMember(Name="date", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? Date { get; set; }

        /// <summary>
        /// None
        /// </summary>
        /// <value>None</value>
        [DataMember(Name="dateTime", EmitDefaultValue=false)]
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// None
        /// </summary>
        /// <value>None</value>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// None
        /// </summary>
        /// <value>None</value>
        [DataMember(Name="callback", EmitDefaultValue=false)]
        public string Callback { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Body3 {\n");
            sb.Append("  Integer: ").Append(Integer).Append("\n");
            sb.Append("  Int32: ").Append(Int32).Append("\n");
            sb.Append("  Int64: ").Append(Int64).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  _Float: ").Append(_Float).Append("\n");
            sb.Append("  _Double: ").Append(_Double).Append("\n");
            sb.Append("  _String: ").Append(_String).Append("\n");
            sb.Append("  PatternWithoutDelimiter: ").Append(PatternWithoutDelimiter).Append("\n");
            sb.Append("  _Byte: ").Append(_Byte).Append("\n");
            sb.Append("  Binary: ").Append(Binary).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  DateTime: ").Append(DateTime).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Callback: ").Append(Callback).Append("\n");
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
            return this.Equals(input as Body3);
        }

        /// <summary>
        /// Returns true if Body3 instances are equal
        /// </summary>
        /// <param name="input">Instance of Body3 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Body3 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Integer == input.Integer ||
                    (this.Integer != null &&
                    this.Integer.Equals(input.Integer))
                ) && 
                (
                    this.Int32 == input.Int32 ||
                    (this.Int32 != null &&
                    this.Int32.Equals(input.Int32))
                ) && 
                (
                    this.Int64 == input.Int64 ||
                    (this.Int64 != null &&
                    this.Int64.Equals(input.Int64))
                ) && 
                (
                    this.Number == input.Number ||
                    (this.Number != null &&
                    this.Number.Equals(input.Number))
                ) && 
                (
                    this._Float == input._Float ||
                    (this._Float != null &&
                    this._Float.Equals(input._Float))
                ) && 
                (
                    this._Double == input._Double ||
                    (this._Double != null &&
                    this._Double.Equals(input._Double))
                ) && 
                (
                    this._String == input._String ||
                    (this._String != null &&
                    this._String.Equals(input._String))
                ) && 
                (
                    this.PatternWithoutDelimiter == input.PatternWithoutDelimiter ||
                    (this.PatternWithoutDelimiter != null &&
                    this.PatternWithoutDelimiter.Equals(input.PatternWithoutDelimiter))
                ) && 
                (
                    this._Byte == input._Byte ||
                    (this._Byte != null &&
                    this._Byte.Equals(input._Byte))
                ) && 
                (
                    this.Binary == input.Binary ||
                    (this.Binary != null &&
                    this.Binary.Equals(input.Binary))
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.DateTime == input.DateTime ||
                    (this.DateTime != null &&
                    this.DateTime.Equals(input.DateTime))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.Callback == input.Callback ||
                    (this.Callback != null &&
                    this.Callback.Equals(input.Callback))
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
                if (this.Integer != null)
                    hashCode = hashCode * 59 + this.Integer.GetHashCode();
                if (this.Int32 != null)
                    hashCode = hashCode * 59 + this.Int32.GetHashCode();
                if (this.Int64 != null)
                    hashCode = hashCode * 59 + this.Int64.GetHashCode();
                if (this.Number != null)
                    hashCode = hashCode * 59 + this.Number.GetHashCode();
                if (this._Float != null)
                    hashCode = hashCode * 59 + this._Float.GetHashCode();
                if (this._Double != null)
                    hashCode = hashCode * 59 + this._Double.GetHashCode();
                if (this._String != null)
                    hashCode = hashCode * 59 + this._String.GetHashCode();
                if (this.PatternWithoutDelimiter != null)
                    hashCode = hashCode * 59 + this.PatternWithoutDelimiter.GetHashCode();
                if (this._Byte != null)
                    hashCode = hashCode * 59 + this._Byte.GetHashCode();
                if (this.Binary != null)
                    hashCode = hashCode * 59 + this.Binary.GetHashCode();
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.DateTime != null)
                    hashCode = hashCode * 59 + this.DateTime.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.Callback != null)
                    hashCode = hashCode * 59 + this.Callback.GetHashCode();
                return hashCode;
            }
        }

    }
}
