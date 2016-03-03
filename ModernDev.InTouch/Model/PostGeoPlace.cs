/**
 * This file\code is part of InTouch project.
 *
 * InTouch - is a .NET wrapper for the vk.com API.
 * https://github.com/virtyaluk/InTouch
 *
 * Copyright (c) 2016 Bohdan Shtepan
 * http://modern-dev.com/
 *
 * Licensed under the GPLv3 license.
 */

using System.Diagnostics;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace ModernDev.InTouch
{
    /// <summary>
    /// A <see cref="PostGeoPlace"/> class describes an information about geo location.
    /// </summary>
    [DataContract]
    [DebuggerDisplay("PostGeoPlace {Country}, {City}")]
    public class PostGeoPlace : BasicPlace
    {
        /// <summary>
        /// The name of the country.
        /// </summary>
        [DataMember]
        [JsonProperty("")]
        public string Country { get; set; }

        /// <summary>
        /// The name of the city.
        /// </summary>
        [DataMember]
        [JsonProperty("city")]
        public string City { get; set; }
    }
}