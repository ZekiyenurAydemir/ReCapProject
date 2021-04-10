using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Hashing
{
    //bizim için bi araç o yüzden çıplak kalabilir
    public class HashingHelper
    {
        //verdiğimiz password ün hash oluşturma
        //1 password vereceğiz diğer iki yapıyı dışarı çıkaracağız
        public static void CreatePasswordHash
            (string password, out byte[] passwordHash, out byte[] passwordSalt)
        {

            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;//her kullanıcı için ayrı key oluşturur
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));//string değeri byte[] dönüştürdük
            }

        }

        //password hash i doğrulama methodu
        //out kullanmıyoruz çünkü veritabanındaki hash ve salt değerini kullanıyoruz
        //password : kullanıcnın tekrardan girerken girdiği parola
        public static bool VerifyPasswordHash
            (string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                //hesaplanan hash ile bizdeki hash karşılaştırması
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != passwordHash[i])
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
