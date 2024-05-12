using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kakaoInfa.카카오결제.ResponseModel
{
    public class 정기결제상태조회Response
    {
        public bool Available { get; set; }
        public string Cid { get; set; }
        public string Sid { get; set; }
        public string Status { get; set; }
        public string ItemName { get; set; }
        public string PaymentMethodType { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastApprovedAt { get; set; }
        public string UsePointStatus { get; set; }
    }

}
