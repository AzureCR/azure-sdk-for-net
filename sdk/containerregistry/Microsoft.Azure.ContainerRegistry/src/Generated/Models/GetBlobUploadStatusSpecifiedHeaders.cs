// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.ContainerRegistry.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines headers for GetBlobUploadStatusSpecified operation.
    /// </summary>
    public partial class GetBlobUploadStatusSpecifiedHeaders
    {
        /// <summary>
        /// Initializes a new instance of the
        /// GetBlobUploadStatusSpecifiedHeaders class.
        /// </summary>
        public GetBlobUploadStatusSpecifiedHeaders()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// GetBlobUploadStatusSpecifiedHeaders class.
        /// </summary>
        /// <param name="range">Range indicating the current progress of the
        /// upload.</param>
        /// <param name="dockerUploadUUID">Identifies the docker upload uuid
        /// for the current request.</param>
        public GetBlobUploadStatusSpecifiedHeaders(string range = default(string), string dockerUploadUUID = default(string))
        {
            Range = range;
            DockerUploadUUID = dockerUploadUUID;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets range indicating the current progress of the upload.
        /// </summary>
        [JsonProperty(PropertyName = "Range")]
        public string Range { get; set; }

        /// <summary>
        /// Gets or sets identifies the docker upload uuid for the current
        /// request.
        /// </summary>
        [JsonProperty(PropertyName = "Docker-Upload-UUID")]
        public string DockerUploadUUID { get; set; }

    }
}
