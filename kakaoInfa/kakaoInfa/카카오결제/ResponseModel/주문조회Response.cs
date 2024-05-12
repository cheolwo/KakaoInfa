using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kakaoInfa.카카오결제.ResponseModel
{
    public class 주문조회Response
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
        public Amount CanceledAmount { get; set; }
        public Amount CancelAvailableAmount { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ApprovedAt { get; set; }
        public List<PaymentActionDetail> PaymentActionDetails { get; set; }
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

    public class PaymentActionDetail
    {
        public string Aid { get; set; }
        public string PaymentActionType { get; set; }
        public string PaymentMethodType { get; set; }
        public int Amount { get; set; }
        public int PointAmount { get; set; }
        public int DiscountAmount { get; set; }
        public DateTime ApprovedAt { get; set; }
        public int GreenDeposit { get; set; }
    }
}
