using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kakaoInfa.카카오결제.ResponseModel
{
    public class 주문취소Response
    {
        public string Tid { get; set; }
        public string Cid { get; set; }
        public string Status { get; set; }
        public string PartnerOrderId { get; set; }
        public string PartnerUserId { get; set; }
        public string PaymentMethodType { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public Amount Amount { get; set; }
        public Amount ApprovedCancelAmount { get; set; }
        public Amount CanceledAmount { get; set; }
        public Amount CancelAvailableAmount { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ApprovedAt { get; set; }
        public DateTime CanceledAt { get; set; }
    }

    public class Amount
    {
        public int Total { get; set; }
        public int TaxFree { get; set; }
        public int Vat { get; set; }
        public int Point { get; set; }
        public int Discount { get; set; }
        public int GreenDeposit { get; set; }
    }

}
