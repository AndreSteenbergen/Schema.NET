using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// The act of starting or activating a device or application (e.g. starting a timer or turning on a flashlight).
    /// </summary>
    [DataContract]
    public partial class ActivateAction : ControlAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ActivateAction";
    }
}
