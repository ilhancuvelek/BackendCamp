using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "ürün eklendi";
        public static string ProductNameInvalid = "ürün ismi geçersiz";
        public static string MaintenanceTime = "sistem bakımda";
        public static string ProductListed = "ürünler listelendi";
        public static string ProductCountOfCategoryError="bir kategoride 10 ürün olmalı";
        public static string ProductNameAlreadyExists="bu isimde zaten başka bir ürün var";
        public static string CategoryLimitedExceded="kategori limiti aşıldığı için yeni ürün eklenemiyor";
        public static string AuthorizationDenied ="yetkiniz yok";
        public static string UserNotFound ="kullanıcı bulunamadı";
        public static string PasswordError ="şifre hatalı";
        public static string SuccessfulLogin="başarılı giriş";
        public static string UserAlreadyExists="kullanıcı mevcut";
        public static string AccessTokenCreated="token oluştu";
        internal static string ProductUpdated;
    }
}
