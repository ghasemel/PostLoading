using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PostLoading
{
    class DoreDTO
    {
        public int DoreId { get; set; }
        public string DoreName { get; set; }


        public override string ToString()
        {
            return DoreName;
        }
    }
}
