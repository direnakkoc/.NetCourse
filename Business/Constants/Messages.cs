using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Urun eklendi";
        public static string ProductNameInvalid = "Urun ismi gecersiz";
        public static string MaintenanceTime="Sistem bakimda";
        public static string ProductsListed="Urunler listelendi";

        public static string ProductCountOfCategoryError = "En fazla 10 urun yazabilirsin";

        public static string ProductNameAlreadyExist = "Bu isimde zaten baska bir urun var.";

        public static string CategoryLimitExceded = "Kategory limiti asildigi icin yeni urun eklenemiyor.";

        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string UserRegistered=" ";
        public static string UserNotFound =" ";
        public static string PasswordError = " ";
        public static string SuccessfulLogin = " ";
        public static string UserAlreadyExists = " ";
        public static string AccessTokenCreated = " ";
    }
}
