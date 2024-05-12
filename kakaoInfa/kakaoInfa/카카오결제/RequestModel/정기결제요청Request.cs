using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kakaoInfa.카카오결제.RequestModel
{
    public class 정기결제요청Request
    {
        public string Cid { get; set; }
        public string Sid { get; set; }
        public string PartnerOrderId { get; set; }
        public string PartnerUserId { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public int TotalAmount { get; set; }
        public int VatAmount { get; set; }
        public int TaxFreeAmount { get; set; }
    }

}
