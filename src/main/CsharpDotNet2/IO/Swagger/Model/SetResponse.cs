using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class SetResponse {
    /// <summary>
    /// Gets or Sets ResponseTime
    /// </summary>
    [DataMember(Name="ResponseTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ResponseTime")]
    public long? ResponseTime { get; set; }

    /// <summary>
    /// Gets or Sets _Response
    /// </summary>
    [DataMember(Name="Response", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Response")]
    public string _Response { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SetResponse {\n");
      sb.Append("  ResponseTime: ").Append(ResponseTime).Append("\n");
      sb.Append("  _Response: ").Append(_Response).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
