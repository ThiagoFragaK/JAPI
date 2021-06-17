using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JAPI.Model
{
    public class Entry
    {
        public int EntryId { get; set; }
        public string EntryTitle { get; set; }
        public string EntryDescr { get; set; }
        public DateTime EntryDate { get; set; }
    }
}
