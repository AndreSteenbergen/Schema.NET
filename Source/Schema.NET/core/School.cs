using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// A school.
    /// </summary>
    [DataContract]
    public partial class School : EducationalOrganization
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "School";
    }
}
