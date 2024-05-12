using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kakaoInfa.카카오결제.ResponseModel
{
    public class 결제준비Response
    {
        public string Tid { get; set; } // 거래 ID

        /// <summary>
        /// PC 환경에서 사용할 결제 페이지 URL.
        /// 일반적으로 팝업(Popup) 또는 레이어(Layer) 방식으로 표시됩니다.
        /// QR 코드를 통한 결제 수단 전환이 가능하며,
        /// 사용자는 생년월일과 휴대전화 번호를 입력하여 카카오톡 메시지로 결제 요청을 할 수 있습니다.
        /// </summary>
        public string NextRedirectPcUrl { get; set; }

        /// <summary>
        /// 모바일 웹 환경에서 사용할 결제 페이지 URL.
        /// URL은 웹뷰(Web view)로 표시되며, iframe 사용은 지양됩니다.
        /// iOS에서는 canOpenURL 사용 시 Info.plist에 "kakaotalk" 스킴을 LSApplicationQueriesSchemes 키 값으로 추가해야 합니다.
        /// </summary>
        public string NextRedirectMobileUrl { get; set; }

        /// <summary>
        /// 모바일 앱 환경에서 사용할 결제 페이지 URL.
        /// 카카오톡 결제 화면으로 자동 이동하는 커스텀 앱 스킴을 호출하며,
        /// 해당 URL은 웹뷰로 표시되며, iframe 사용은 지양됩니다.
        /// iOS에서는 canOpenURL 사용 시 Info.plist에 "kakaotalk" 스킴을 LSApplicationQueriesSchemes 키 값으로 추가해야 합니다.
        /// </summary>
        public string NextRedirectAppUrl { get; set; }

        public string AndroidAppScheme { get; set; } // 안드로이드 앱 스킴
        public string IosAppScheme { get; set; } // iOS 앱 스킴
        public DateTime CreatedAt { get; set; } // 결제 준비 요청이 생성된 시간

        /// <summary>
        /// 결제 준비(ready) API의 응답으로 받은 Redirect URL을 사용하여 사용자 접속 환경에 맞는 URL을 선택해 오픈합니다.
        /// 클라이언트에는 결제 대기 화면이 노출되며, 사용자는 카카오톡 결제 화면에서 결제 수단을 선택할 수 있습니다.
        /// 결제 대기 화면은 사용자가 카카오톡 결제 화면에서 결제 수단을 선택할 때까지 카운트다운을 하며,
        /// 결제 상태를 지속적으로 직접 체크(polling 방식)합니다.
        /// 사용자가 결제 수단을 선택하고 비밀번호 인증을 마친 후,
        /// 결제 대기 화면은 결제 준비 API 요청 시 전달받은 approval_url에 pg_token 파라미터를 붙여 대기화면을
        /// approval_url로 redirect합니다. 이 pg_token은 결제 승인 API 호출 시 사용됩니다.
        /// </summary>
    }
}
