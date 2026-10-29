using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

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