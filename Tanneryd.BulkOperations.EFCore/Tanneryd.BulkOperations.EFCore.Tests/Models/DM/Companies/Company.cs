// <auto-generated>
// ReSharper disable All

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Tanneryd.BulkOperations.EFCore.Tests
{
    // Company
    public class Company
    {
        public long Id { get; set; } // Id (Primary key)
        public string Name { get; set; } // Name
        public long ParentCompanyId { get; set; } // ParentCompanyId

        // Reverse navigation

        /// <summary>
        /// Child Companies where [Company].[ParentCompanyId] point to this entity (FK_dbo.Company_dbo.Company_ParentCompanyId)
        /// </summary>
        public ICollection<Company> Companies { get; set; } // Company.FK_dbo.Company_dbo.Company_ParentCompanyId

        /// <summary>
        /// Child Employees where [Employee].[EmployerId] point to this entity (FK_dbo.Employee_dbo.Company_EmployerId)
        /// </summary>
        public ICollection<Employee> Employees { get; set; } // Employee.FK_dbo.Employee_dbo.Company_EmployerId

        // Foreign keys

        /// <summary>
        /// Parent Company pointed by [Company].([ParentCompanyId]) (FK_dbo.Company_dbo.Company_ParentCompanyId)
        /// </summary>
        public Company ParentCompany { get; set; } // FK_dbo.Company_dbo.Company_ParentCompanyId

        public Company()
        {
            Companies = new List<Company>();
            Employees = new List<Employee>();
        }
    }

}
// </auto-generated>
