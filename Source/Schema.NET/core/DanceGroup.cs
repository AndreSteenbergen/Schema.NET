using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// A dance group&amp;#x2014;for example, the Alvin Ailey Dance Theater or Riverdance.
    /// </summary>
    [DataContract]
    public partial class DanceGroup : PerformingGroup
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "DanceGroup";
    }
}
