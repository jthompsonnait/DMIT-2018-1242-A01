// ***********************************************************************
// Assembly         : HogWildSystem
// Author           : James Thompson
// Created          : 03-10-2025
//
// Last Modified By : James Thompson
// Last Modified On : 03-10-2025
// ***********************************************************************
// <copyright file="CustomerEditView.cs" company="HogWildSystem">
//     Copyright (c) NAIT. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HogWildSystem.ViewModels
{
    /// <summary>
    /// Class CustomerEditView.
    /// </summary>
    public class CustomerEditView
    {
        /// <summary>
        /// Gets or sets the customer identifier.
        /// </summary>
        /// <value>The customer identifier.</value>
        public int CustomerID { get; set; }
        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>The first name.</value>
        public string FirstName { get; set; }
        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>The last name.</value>
        public string LastName { get; set; }
        /// <summary>
        /// Gets or sets the address1.
        /// </summary>
        /// <value>The address1.</value>
        public string Address1 { get; set; }
        /// <summary>
        /// Gets or sets the address2.
        /// </summary>
        /// <value>The address2.</value>
        public string Address2 { get; set; }
        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        /// <value>The city.</value>
        public string City { get; set; }
        /// <summary>
        /// Gets or sets the prov state identifier.
        /// </summary>
        /// <value>The prov state identifier.</value>
        public int ProvStateID { get; set; }
        /// <summary>
        /// Gets or sets the country identifier.
        /// </summary>
        /// <value>The country identifier.</value>
        public int CountryID { get; set; }
        /// <summary>
        /// Gets or sets the postal code.
        /// </summary>
        /// <value>The postal code.</value>
        public string PostalCode { get; set; }
        /// <summary>
        /// Gets or sets the phone.
        /// </summary>
        /// <value>The phone.</value>
        public string Phone { get; set; }
        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>The email.</value>
        public string Email { get; set; }
        /// <summary>
        /// Gets or sets the status identifier.
        /// </summary>
        /// <value>The status identifier.</value>
        public int StatusID { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether [remove from view flag].
        /// </summary>
        /// <value><c>true</c> if [remove from view flag]; otherwise, <c>false</c>.</value>
        public bool RemoveFromViewFlag { get; set; }
    }
}
