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
  public class WhereItem {
    /// <summary>
    /// You can explain the controls of more than one state with where. The controls of states: equal, notEqual, like, greaterThan, lessThan
    /// </summary>
    /// <value>You can explain the controls of more than one state with where. The controls of states: equal, notEqual, like, greaterThan, lessThan</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// Column name
    /// </summary>
    /// <value>Column name</value>
    [DataMember(Name="column", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "column")]
    public string Column { get; set; }

    /// <summary>
    /// Column value
    /// </summary>
    /// <value>Column value</value>
    [DataMember(Name="value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "value")]
    public string Value { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class WhereItem {\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Column: ").Append(Column).Append("\n");
      sb.Append("  Value: ").Append(Value).Append("\n");
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
