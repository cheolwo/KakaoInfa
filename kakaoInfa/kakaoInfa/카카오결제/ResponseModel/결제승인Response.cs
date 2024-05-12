namespace kakaoInfa.카카오결제.ResponseModel
{
    public class 결제승인Response
    {
        public string Aid { get; set; }
        public string Tid { get; set; }
        public string Cid { get; set; }
        public string PartnerOrderId { get; set; }
        public string PartnerUserId { get; set; }
        public string PaymentMethodType { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public Amount Amount { get; set; }
        public CardInfo CardInfo { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ApprovedAt { get; set; }
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

    public class CardInfo
    {
        public string InterestFreeInstall { get; set; }
        public string Bin { get; set; }
        public string CardType { get; set; }
        public string CardMid { get; set; }
        public string ApprovedId { get; set; }
        public string InstallMonth { get; set; }
        public string InstallmentType { get; set; }
        public string KakaopayPurchaseCorp { get; set; }
        public string KakaopayPurchaseCorpCode { get; set; }
        public string KakaopayIssuerCorp { get; set; }
        public string KakaopayIssuerCorpCode { get; set; }
    }
}
