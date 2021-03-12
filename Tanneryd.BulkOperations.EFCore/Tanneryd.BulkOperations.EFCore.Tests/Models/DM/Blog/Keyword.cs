// <auto-generated>
// ReSharper disable All

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Tanneryd.BulkOperations.EFCore.Tests
{
    // Keyword
    public class Keyword
    {
        public Guid Id { get; set; } // Id (Primary key)
        public Guid PostId { get; set; } // PostId
        public string Text { get; set; } // Text

        // Foreign keys

        /// <summary>
        /// Parent Post pointed by [Keyword].([PostId]) (FK_dbo.Keyword_dbo.Post_PostId)
        /// </summary>
        public Post Post { get; set; } // FK_dbo.Keyword_dbo.Post_PostId

        public Keyword()
        {
            Id = Guid.NewGuid();
        }
    }

}
// </auto-generated>
