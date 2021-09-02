// <auto-generated>
// ReSharper disable All

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Tanneryd.BulkOperations.EFCore.Tests
{
    // Prime
    public class Prime
    {
        public long NumberId { get; set; } // NumberId (Primary key)
        public DateTime UpdatedAt { get; set; } // UpdatedAt
        public string UpdatedBy { get; set; } // UpdatedBy

        // Reverse navigation

        /// <summary>
        /// Child CompositePrimes where [CompositePrime].[PrimeId] point to this entity (FK_dbo.CompositePrime_dbo.Prime_PrimeId)
        /// </summary>
        public ICollection<CompositePrime> CompositePrimes { get; set; } // CompositePrime.FK_dbo.CompositePrime_dbo.Prime_PrimeId

        // Foreign keys

        /// <summary>
        /// Parent Number pointed by [Prime].([NumberId]) (FK_dbo.Prime_dbo.Number_NumberId)
        /// </summary>
        public Number Number { get; set; } // FK_dbo.Prime_dbo.Number_NumberId

        public Prime()
        {
            CompositePrimes = new List<CompositePrime>();
        }
    }

}
// </auto-generated>