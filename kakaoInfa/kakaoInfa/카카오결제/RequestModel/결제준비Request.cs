using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kakaoInfa.카카오결제.RequestModel
{
    public class 결제준비Request
    {
        public string Cid { get; set; } // 필수, 가맹점 코드, 10자
        public string CidSecret { get; set; } // 선택, 가맹점 코드 인증키, 24자, 숫자와 영문 소문자 조합
        public string PartnerOrderId { get; set; } // 필수, 가맹점 주문번호, 최대 100자
        public string PartnerUserId { get; set; } // 필수, 가맹점 회원 ID, 최대 100자
        public string ItemName { get; set; } // 필수, 상품명, 최대 100자
        public string ItemCode { get; set; } // 선택, 상품코드, 최대 100자
        public int Quantity { get; set; } // 필수, 상품 수량
        public int TotalAmount { get; set; } // 필수, 상품 총액
        public int TaxFreeAmount { get; set; } // 필수, 상품 비과세 금액
        public int? VatAmount { get; set; } // 선택, 상품 부가세 금액, 값이 없으면 자동 계산
        public int? GreenDeposit { get; set; } // 선택, 컵 보증금
        public string ApprovalUrl { get; set; } // 필수, 결제 성공 시 redirect URL, 최대 255자
        public string CancelUrl { get; set; } // 필수, 결제 취소 시 redirect URL, 최대 255자
        public string FailUrl { get; set; } // 필수, 결제 실패 시 redirect URL, 최대 255자
        public List<string> AvailableCards { get; set; } // 선택, 결제 허용 카드사 목록
        public string PaymentMethodType { get; set; } // 선택, 허용 결제 수단
        public int? InstallMonth { get; set; } // 선택, 카드 할부 개월 수
        public string UseShareInstallment { get; set; } // 선택, 분담 무이자 설정 (Y/N)
        public Dictionary<string, string> CustomJson { get; set; } // 선택, 사용자 정의 JSON 맵

        // VAT 자동 계산 메서드
        public void CalculateVat()
        {
            if (!VatAmount.HasValue)
            {
                VatAmount = (int)Math.Round((TotalAmount - TaxFreeAmount) / 11.0);
            }
        }
    }
}
