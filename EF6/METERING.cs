//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EF6
{
    using System;
    using System.Collections.Generic;
    
    public partial class METERING
    {
        public int IDOBJECT { get; set; }
        public int IDTYPE_OBJECT { get; set; }
        public System.DateTime TIME_BEGIN { get; set; }
        public System.DateTime TIME_END { get; set; }
        public int IDOBJECT_AGGREGATE { get; set; }
        public int IDOBJECT_AVERAGE { get; set; }
        public Nullable<int> STATUS { get; set; }
        public double VALUE_METERING { get; set; }
        public System.DateTime TIME_INSERT { get; set; }
    }
}
