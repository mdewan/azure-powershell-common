// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Monitor.Version2018_09_01.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Specifies the criteria for converting log to metric.
    /// </summary>
    public partial class Dimension
    {
        /// <summary>
        /// Initializes a new instance of the Dimension class.
        /// </summary>
        public Dimension()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Dimension class.
        /// </summary>
        /// <param name="name">Name of the dimension</param>
        /// <param name="values">List of dimension values</param>
        public Dimension(string name, IList<string> values)
        {
            Name = name;
            Values = values;
            CustomInit();
        }
        /// <summary>
        /// Static constructor for Dimension class.
        /// </summary>
        static Dimension()
        {
            OperatorProperty = "Include";
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of the dimension
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets list of dimension values
        /// </summary>
        [JsonProperty(PropertyName = "values")]
        public IList<string> Values { get; set; }

        /// <summary>
        /// Operator for dimension values
        /// </summary>
        [JsonProperty(PropertyName = "operator")]
        public static string OperatorProperty { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (Values == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Values");
            }
        }
    }
}