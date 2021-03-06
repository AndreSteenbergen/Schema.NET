using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// The act of authoring written creative content.
    /// </summary>
    [DataContract]
    public partial class WriteAction : CreateAction
    {
        public interface IInLanguage : IWrapper { }
        public interface IInLanguage<T> : IInLanguage { new T Data { get; set; } }
        public class InLanguageLanguage : IInLanguage<Language>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Language) value; } }
            public virtual Language Data { get; set; }
            public InLanguageLanguage () { }
            public InLanguageLanguage (Language data) { Data = data; }
            public static implicit operator InLanguageLanguage (Language data) { return new InLanguageLanguage (data); }
        }

        public class InLanguagestring : IInLanguage<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public InLanguagestring () { }
            public InLanguagestring (string data) { Data = data; }
            public static implicit operator InLanguagestring (string data) { return new InLanguagestring (data); }
        }


        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "WriteAction";

        /// <summary>
        /// The language of the content or performance or used in an action. Please use one of the language codes from the &lt;a href="http://tools.ietf.org/html/bcp47"&gt;IETF BCP 47 standard&lt;/a&gt;. See also &lt;a class="localLink" href="http://schema.org/availableLanguage"&gt;availableLanguage&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "inLanguage", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IInLanguage>? InLanguage { get; set; } //Language, string
    }
}
