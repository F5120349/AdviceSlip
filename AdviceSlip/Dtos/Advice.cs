using System;
using System.Collections.Generic;
using System.Text;

namespace AdviceSlip.Dtos
{
    public class AdviceResponse
    {
        public Slip slip { get; set; }
    }

    public class Slip
    {
        public int id { get; set; }
        public string advice { get; set; } = string.Empty;
    }
}