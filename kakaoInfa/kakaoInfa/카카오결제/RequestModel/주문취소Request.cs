using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kakaoInfa.카카오결제.RequestModel
{
    public class 주문취소Request
    {
        public string Cid { get; set; }
        public string Tid { get; set; }
        public int CancelAmount { get; set; }
        public int CancelTaxFreeAmount { get; set; }
        public int CancelVatAmount { get; set; }
        public int CancelAvailableAmount { get; set; }
    }
}
