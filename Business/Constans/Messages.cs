using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constans
{
    public static class Messages
    {
        public static string CarAdded = "Araç Eklendi";
        public static string CarUpdated = "Araç Güncellendi";
        public static string CarDeleted = "Araç silindi";
        public static string CarListed = "Araçlar Listelendi";
        public static string CarNameInvalid = "Araç ismi geçersiz";
        

        public static string BrandAdded = "Marka Eklendi";
        public static string BrandDeleted = "Marka silindi";
        public static string BrandUpdated = "Marka güncellendi";        
        public static string BrandListed = "Markalar listelendi";
        public static string BrandAddedNameInvalid = "Marka geçersiz";
        public static string BrandNameAlreadyExists = "Bu isimde zaten başka bir marka mevcut";

        public static string ColorAdded = "Renk eklendi";
        public static string ColorDeleted = "Renk silindi";
        public static string ColorUpdated = "Renk güncellendi";
        public static string ColorListed = "Renkler listelendi";

        public static string UserAdded = "Kullanıcı eklendi";
        public static string UserDeleted = "Kullanıcı silindi";
        public static string UserUpdated = "Kullanıcı güncellendi";

        public static string CustomerAdded = "Müşteri Eklendi";
        public static string CustomerDeleted = "Müşteri silindi";
        public static string CustomerUpdated = "Müşteri güncellendi";
        public static string CustomerListed = "Müşteriler listelendi";

        public static string RentalAdded = "Araç kiralama başarılı";
        public static string RentalDeleted = "Araç Kiralama silindi";
        public static string RentalUpdated = "Araç Kiralama güncellendi";
        public static string RentalReturnDateIsNull = "Araç teslim edilmemiş";

        public static string CarImageAdded = "Araba resmi eklendi";
        public static string CarImageDeleted = "Araba resmi silindi";
        public static string CarImageUpdated = "Araba resmi güncellendi";
        public static string CarLimitExceded = "Arabaya eklebilecek max resim limitine ulaşıldı!";

        public static string InvalidRequest = "Lütfen bilgileri kontrol edip, tekrar deneyin";      

        public static string AuthorizationDenied = "Yetkiniz yok!";
    }
}
