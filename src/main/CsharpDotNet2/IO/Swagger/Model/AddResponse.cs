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
  public class AddResponse {
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
    /// Gets or Sets ListItemId
    /// </summary>
    [DataMember(Name="ListItemId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ListItemId")]
    public string ListItemId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AddResponse {\n");
      sb.Append("  ResponseTime: ").Append(ResponseTime).Append("\n");
      sb.Append("  _Response: ").Append(_Response).Append("\n");
      sb.Append("  ListItemId: ").Append(ListItemId).Append("\n");
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
