using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// A dry-cleaning business.
    /// </summary>
    [DataContract]
    public partial class DryCleaningOrLaundry : LocalBusiness
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "DryCleaningOrLaundry";
    }
}
