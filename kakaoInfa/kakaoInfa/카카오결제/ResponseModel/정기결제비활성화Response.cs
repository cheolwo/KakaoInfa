using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kakaoInfa.카카오결제.ResponseModel
{
    public class 정기결제비활성화Response
    {
        public string Cid { get; set; }
        public string Sid { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime InactivatedAt { get; set; }
        public DateTime LastApprovedAt { get; set; }
    }

}
