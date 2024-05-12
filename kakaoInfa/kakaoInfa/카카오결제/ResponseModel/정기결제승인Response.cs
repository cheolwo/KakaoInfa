using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kakaoInfa.카카오결제.ResponseModel
{
    public class 정기결제승인Response
    {
        public string Cid { get; set; }
        public string Aid { get; set; }
        public string Tid { get; set; }
        public string Sid { get; set; }
        public string PartnerOrderId { get; set; }
        public string PartnerUserId { get; set; }
        public string PaymentMethodType { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public Amount Amount { get; set; }
        public CardInfo CardInfo { get; set; }
        public List<SequentialPaymentMethod> SequentialPaymentMethods { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ApprovedAt { get; set; }
    }

    public class SequentialPaymentMethod
    {
        public int PaymentPriority { get; set; }
        public string Sid { get; set; }
        public string PaymentMethodType { get; set; }
        public CardInfo CardInfo { get; set; }
    }
}
