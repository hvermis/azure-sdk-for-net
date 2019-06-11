// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DevTestLabs.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The properties of a lab cost item.
    /// </summary>
    public partial class LabCostDetailsProperties
    {
        /// <summary>
        /// Initializes a new instance of the LabCostDetailsProperties class.
        /// </summary>
        public LabCostDetailsProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LabCostDetailsProperties class.
        /// </summary>
        /// <param name="date">The date of the cost item.</param>
        /// <param name="cost">The cost component of the cost item.</param>
        /// <param name="costType">The type of the cost. Possible values
        /// include: 'Unavailable', 'Reported', 'Projected'</param>
        public LabCostDetailsProperties(System.DateTime? date = default(System.DateTime?), double? cost = default(double?), string costType = default(string))
        {
            Date = date;
            Cost = cost;
            CostType = costType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the date of the cost item.
        /// </summary>
        [JsonProperty(PropertyName = "date")]
        public System.DateTime? Date { get; set; }

        /// <summary>
        /// Gets or sets the cost component of the cost item.
        /// </summary>
        [JsonProperty(PropertyName = "cost")]
        public double? Cost { get; set; }

        /// <summary>
        /// Gets or sets the type of the cost. Possible values include:
        /// 'Unavailable', 'Reported', 'Projected'
        /// </summary>
        [JsonProperty(PropertyName = "costType")]
        public string CostType { get; set; }

    }
}