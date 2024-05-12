using Microsoft.Extensions.Configuration;
using System.Text.Json;
using System.Text;
using kakaoInfa.카카오결제.RequestModel;
using kakaoInfa.카카오결제.ResponseModel;
using Microsoft.Extensions.Logging;

namespace kakaoInfa.카카오결제
{
    public class 카카오결제APIService
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;
        private readonly ILogger<카카오결제APIService> _logger;

        public 카카오결제APIService(HttpClient httpClient, IConfiguration configuration, ILogger<카카오결제APIService> logger)
        {
            _httpClient = httpClient;
            _configuration = configuration;
            _logger = logger;
        }

        private async Task<T> SendRequestAsync<T>(string url, object request)
        {
            var jsonRequest = JsonSerializer.Serialize(request);
            var secretKey = _configuration["KaKaoKey"];

            using var requestMessage = new HttpRequestMessage(HttpMethod.Post, url)
            {
                Content = new StringContent(jsonRequest, Encoding.UTF8, "application/json")
            };

            // API 키를 헤더에 직접 추가
            requestMessage.Headers.Add("Authorization", $"SECRET_KEY {secretKey}");

            try
            {
                var response = await _httpClient.SendAsync(requestMessage);
                if (response.IsSuccessStatusCode)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    return JsonSerializer.Deserialize<T>(jsonResponse);
                }
                else
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    _logger.LogError($"API call to {url} failed: {response.StatusCode} - {errorContent}");
                    throw new Exception($"API call to {url} failed: {response.StatusCode} - {errorContent}");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error sending request to {Url}", url);
                throw;
            }
        }

        public Task<결제준비Response> 결제준비Async(결제준비Request request) => SendRequestAsync<결제준비Response>("https://open-api.kakaopay.com/online/v1/payment/ready", request);
        public Task<결제승인Response> 결제승인Async(결제승인Request request) => SendRequestAsync<결제승인Response>("https://open-api.kakaopay.com/online/v1/payment/approve", request);
        public Task<정기결제승인Response> 정기결제승인Async(정기결제승인Request request) => SendRequestAsync<정기결제승인Response>("https://open-api.kakaopay.com/online/v1/payment/approve", request);
        public Task<정기결제요청Response> 정기결제요청Async(정기결제요청Request request) => SendRequestAsync<정기결제요청Response>("https://open-api.kakaopay.com/online/v1/payment/approve", request);
        public Task<정기결제비활성화Response> 정기결제비활성화Async(정기결제비활성화Request request) => SendRequestAsync<정기결제비활성화Response>("https://open-api.kakaopay.com/online/v1/payment/manage/subscription/inactive", request);
        public Task<정기결제상태조회Response> 정기결제상태조회Async(정기결제상태조회Request request) => SendRequestAsync<정기결제상태조회Response>("https://open-api.kakaopay.com/online/v1/payment/manage/subscription/status", request);
        public Task<주문조회Response> 주문조회Async(주문조회Request request) => SendRequestAsync<주문조회Response>("https://open-api.kakaopay.com/online/v1/payment/order", request);
        public Task<주문취소Response> 주문취소Async(주문취소Request request) => SendRequestAsync<주문취소Response>("https://open-api.kakaopay.com/online/v1/payment/order", request);
    }
}
