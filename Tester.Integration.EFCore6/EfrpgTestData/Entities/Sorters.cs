// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace V6EfrpgTest
{
    // Sorters
    public class Sorters
    {
        public string SorterName { get; set; } // SorterName (Primary key) (length: 20)

        // Reverse navigation

        /// <summary>
        /// Parent (One-to-One) Sorters pointed by [SorterScannerGroup].[SorterName] (FK_SorterScannerGroup_Sorters)
        /// </summary>
        public virtual SorterScannerGroup SorterScannerGroup { get; set; } // SorterScannerGroup.FK_SorterScannerGroup_Sorters
    }

}
// </auto-generated>
