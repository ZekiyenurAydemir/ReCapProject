using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.JWT
{//helper class , iç değerler option old. için çoğul olarak isimlendirme yaptık
    public class TokenOptions
    {
        public string Audience { get; set; }
        public string Issuer { get; set; }
        public int AccessTokenExpiration { get; set; }
        public string SecurityKey { get; set; }
    }
}
