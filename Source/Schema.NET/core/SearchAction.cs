using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// &lt;p&gt;The act of searching for an object.&lt;/p&gt;
    /// &lt;p&gt;Related actions:&lt;/p&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/FindAction"&gt;FindAction&lt;/a&gt;: SearchAction generally leads to a FindAction, but not necessarily.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    [DataContract]
    public partial class SearchAction : Action
    {
        public interface IQueryInput : IWrapper { }
        public interface IQueryInput<T> : IQueryInput { new T Data { get; set; } }
        public class QueryInputstring : IQueryInput<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public QueryInputstring () { }
            public QueryInputstring (string data) { Data = data; }
            public static implicit operator QueryInputstring (string data) { return new QueryInputstring (data); }
        }

        public class QueryInputPropertyValueSpecification : IQueryInput<PropertyValueSpecification>
        {
            object IWrapper.Data { get { return Data; } set { Data = (PropertyValueSpecification) value; } }
            public virtual PropertyValueSpecification Data { get; set; }
            public QueryInputPropertyValueSpecification () { }
            public QueryInputPropertyValueSpecification (PropertyValueSpecification data) { Data = data; }
            public static implicit operator QueryInputPropertyValueSpecification (PropertyValueSpecification data) { return new QueryInputPropertyValueSpecification (data); }
        }


        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "SearchAction";

        /// <summary>
        /// A sub property of instrument. The query used on this action.
        /// </summary>
        [DataMember(Name = "query", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? Query { get; set; } 

        /// <summary>
        /// Gets or sets the query input search parameter.
        /// </summary>
        [DataMember(Name = "query-input", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IQueryInput>? QueryInput { get; set; } //string, PropertyValueSpecification
    }
}
