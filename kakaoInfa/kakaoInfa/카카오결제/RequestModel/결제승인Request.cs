namespace kakaoInfa.카카오결제.RequestModel
{
    public class 결제승인Request
    {
        public string Cid { get; set; }
        public string Tid { get; set; }
        public string PartnerOrderId { get; set; }
        public string PartnerUserId { get; set; }
        public string PgToken { get; set; }
    }
}
