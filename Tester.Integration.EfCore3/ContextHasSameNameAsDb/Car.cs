// <auto-generated>
// ReSharper disable All

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Tester.Integration.EfCore3.ContextHasSameNameAsDb
{
    // Car
    public class Car
    {
        public int Id { get; set; } // Id (Primary key)
        public int PrimaryColourId { get; set; } // PrimaryColourId
        public string CarMake { get; set; } // CarMake (length: 255)
        public int? ComputedColumn { get; private set; } // computed_column
        public int ComputedColumnPersisted { get; private set; } // computed_column_persisted
    }

}
// </auto-generated>
