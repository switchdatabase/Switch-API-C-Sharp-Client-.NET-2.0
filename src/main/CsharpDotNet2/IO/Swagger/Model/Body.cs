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
  public class Body {
    /// <summary>
    /// List name.
    /// </summary>
    /// <value>List name.</value>
    [DataMember(Name="list", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "list")]
    public string List { get; set; }

    /// <summary>
    /// Item count.
    /// </summary>
    /// <value>Item count.</value>
    [DataMember(Name="count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "count")]
    public int? Count { get; set; }

    /// <summary>
    /// Page number.
    /// </summary>
    /// <value>Page number.</value>
    [DataMember(Name="page", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "page")]
    public int? Page { get; set; }

    /// <summary>
    /// Optional enumerator. You can assign the mode of implementation of where criterions by using AND and OR types under whereType parameter.
    /// </summary>
    /// <value>Optional enumerator. You can assign the mode of implementation of where criterions by using AND and OR types under whereType parameter.</value>
    [DataMember(Name="whereType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "whereType")]
    public string WhereType { get; set; }

    /// <summary>
    /// Gets or Sets Where
    /// </summary>
    [DataMember(Name="where", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "where")]
    public List<WhereItem> Where { get; set; }

    /// <summary>
    /// Gets or Sets Order
    /// </summary>
    [DataMember(Name="order", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "order")]
    public ListOrder Order { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Body {\n");
      sb.Append("  List: ").Append(List).Append("\n");
      sb.Append("  Count: ").Append(Count).Append("\n");
      sb.Append("  Page: ").Append(Page).Append("\n");
      sb.Append("  WhereType: ").Append(WhereType).Append("\n");
      sb.Append("  Where: ").Append(Where).Append("\n");
      sb.Append("  Order: ").Append(Order).Append("\n");
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
