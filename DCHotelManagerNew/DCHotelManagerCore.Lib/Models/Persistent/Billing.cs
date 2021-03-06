﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Billing.cs" company="">
//   
// </copyright>
// <summary>
//   The billing.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DCHotelManagerCore.Lib.Models.Persistent
{
    #region

    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    using DCHotelManagerCore.Lib.Models.Persistent.Interfaces;

    #endregion

    /// <summary>
    /// The billing.
    /// </summary>
    public class Billing : IEntity, IEntityAudit
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Billing"/> class.
        /// </summary>
        public Billing()
        {
            this.BillingServices = new List<BillingService>();
            this.Created = DateTime.Now;
            this.CreatedBy = Environment.MachineName;
        }

        /// <summary>
        /// Gets or sets the billing services.
        /// </summary>
        public virtual List<BillingService> BillingServices { get; set; }

        /// <summary>
        /// Gets or sets the booking id.
        /// </summary>
        public int BookingId { get; set; }

        /// <summary>
        /// Gets or sets the created.
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// Gets or sets the created by.
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// Gets or sets the deleted.
        /// </summary>
        public DateTime? Deleted { get; set; }

        /// <summary>
        /// Gets or sets the deleted by.
        /// </summary>
        public string DeletedBy { get; set; }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether is checked.
        /// </summary>
        public bool IsChecked { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether paid.
        /// </summary>
        public bool Paid { get; set; }

        /// <summary>
        /// Gets or sets the price for room.
        /// </summary>
        public double PriceForRoom { get; set; }

        /// <summary>
        /// Gets or sets the price for services.
        /// </summary>
        public double PriceForServices { get; set; }

        /// <summary>
        /// Gets or sets the updated.
        /// </summary>
        public DateTime? Updated { get; set; }

        /// <summary>
        /// Gets or sets the updated by.
        /// </summary>
        public string UpdatedBy { get; set; }
    }
}