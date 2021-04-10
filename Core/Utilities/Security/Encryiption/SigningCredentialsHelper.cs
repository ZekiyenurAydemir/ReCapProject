using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Encryiption
{//JWT yi yönetirken kullanacağı anahtar ve algoritmasını söylüyoruz
    public class SigningCredentialsHelper
    {
        public static SigningCredentials CreateSigningCredentials(SecurityKey securityKey)
        { //Hangi anahtar, hangi algoritma kullanılacak
            return
                new SigningCredentials(securityKey,SecurityAlgorithms.HmacSha512Signature);
        }
    }
}
