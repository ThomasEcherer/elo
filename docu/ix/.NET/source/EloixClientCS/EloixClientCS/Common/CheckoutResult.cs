using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EloixClient.IndexServerFW.Content;

namespace EloixClient.Common
{
    public class CheckoutResult
    {
        public FWDocument FWDocument { get; set; }
        public bool Success { get; set; }
        public string Message { get; set; }
    }
}
