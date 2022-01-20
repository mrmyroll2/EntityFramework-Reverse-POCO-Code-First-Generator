// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Tester.Integration.EFCore6.Single_context_many_files
{
    // BlahBlargLink
    public class BlahBlargLink
    {
        public int BlahId { get; set; } // BlahID (Primary key)
        public int BlargId { get; set; } // BlargID (Primary key)

        // Foreign keys

        /// <summary>
        /// Parent Blah pointed by [BlahBlargLink].([BlahId]) (FK_BlahBlargLink_Blah)
        /// </summary>
        public virtual Blah Blah { get; set; } // FK_BlahBlargLink_Blah

        /// <summary>
        /// Parent Blarg pointed by [BlahBlargLink].([BlargId]) (FK_BlahBlargLink_Blarg)
        /// </summary>
        public virtual Blarg Blarg { get; set; } // FK_BlahBlargLink_Blarg
    }

}
// </auto-generated>
