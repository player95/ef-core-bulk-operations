// <auto-generated>
// ReSharper disable All

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Tanneryd.BulkOperations.EFCore.Tests
{
    // TeamWithDbGeneratedGuid
    public class TeamWithDbGeneratedGuid
    {
        public Guid Id { get; set; } // Id (Primary key)
        public string Name { get; set; } // Name

        // Reverse navigation

        /// <summary>
        /// Child CoachTeamsWithDbGeneratedGuids where [CoachTeamsWithDbGeneratedGuid].[TeamId] point to this entity (FK_dbo.CoachTeamsWithDbGeneratedGuid_dbo.TeamWithDbGeneratedGuid_TeamId)
        /// </summary>
        public ICollection<CoachTeamsWithDbGeneratedGuid> CoachTeamsWithDbGeneratedGuids { get; set; } // CoachTeamsWithDbGeneratedGuid.FK_dbo.CoachTeamsWithDbGeneratedGuid_dbo.TeamWithDbGeneratedGuid_TeamId

        /// <summary>
        /// Child PlayerWithDbGeneratedGuids where [PlayerWithDbGeneratedGuid].[TeamId] point to this entity (FK_dbo.PlayerWithDbGeneratedGuid_dbo.TeamWithDbGeneratedGuid_TeamId)
        /// </summary>
        public ICollection<PlayerWithDbGeneratedGuid> PlayerWithDbGeneratedGuids { get; set; } // PlayerWithDbGeneratedGuid.FK_dbo.PlayerWithDbGeneratedGuid_dbo.TeamWithDbGeneratedGuid_TeamId

        public TeamWithDbGeneratedGuid()
        {
            Id = Guid.NewGuid();
            CoachTeamsWithDbGeneratedGuids = new List<CoachTeamsWithDbGeneratedGuid>();
            PlayerWithDbGeneratedGuids = new List<PlayerWithDbGeneratedGuid>();
        }
    }

}
// </auto-generated>
