// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Commands.Common.Compute.Version_2018_04.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Resource Id.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class VirtualMachineCaptureResult : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the VirtualMachineCaptureResult
        /// class.
        /// </summary>
        public VirtualMachineCaptureResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VirtualMachineCaptureResult
        /// class.
        /// </summary>
        /// <param name="id">Resource Id</param>
        /// <param name="output">Operation output data (raw JSON)</param>
        public VirtualMachineCaptureResult(string id = default(string), object output = default(object))
            : base(id)
        {
            Output = output;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets operation output data (raw JSON)
        /// </summary>
        [JsonProperty(PropertyName = "properties.output")]
        public object Output { get; set; }

    }
}