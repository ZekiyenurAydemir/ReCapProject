using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.JWT
{
    public interface ITokenHelper
    {//kullanıcı bilg. doğru ise DB ye gidecek onun için bir JWT oluşturacak,ve ona gönderecek
        AccessToken CreateToken(User user,List<OperationClaim> operationClaims);
    }
}
