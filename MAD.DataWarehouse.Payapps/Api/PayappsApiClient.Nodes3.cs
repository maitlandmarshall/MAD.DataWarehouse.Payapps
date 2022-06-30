using Newtonsoft.Json;
using System.Collections.Generic;

namespace Payapps.Api
{
    public partial class Nodes3
    {
        public string Id { get; set; }
        public string Type { get; set; }

        [JsonProperty("line_ref_code")]
        public string Line_ref_code { get; set; }
        public string Description { get; set; }

        public Claimline Claimline { get; set; }
        public IEnumerable<ClaimlinesLineDto> Nodes { get; set; }
    }
}
