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
    /// Information about tags.
    /// </summary>
    [DataContract]
    [DebuggerDisplay("Tags {Count}")]
    public class Tags
    {
        /// <summary>
        /// The total number of the tags.
        /// </summary>
        [DataMember]
        [JsonProperty("count")]
        public int Count { get; set; }
    }
}