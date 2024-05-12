using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kakaoInfa.카카오결제.RequestModel
{
    public class 정기결제승인Request
    {
        public string Cid { get; set; }
        public string Tid { get; set; }
        public string PartnerOrderId { get; set; }
        public string PartnerUserId { get; set; }
        public string PgToken { get; set; }
    }
}
