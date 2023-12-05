using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day_3
{
    public class EngineSchematic
    {
        public EngineSchematicCell[][] Cells { get; set; }
        public int MaxColumnIndex { get; set; }
        public int maxRowIndex { get; set; }
    }
}