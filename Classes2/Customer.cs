using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes2
{
    class Customer
    {   // bir müşterinin Özelliklerini bir class için tutabiliriz. Yani Bir Müşterinin yada X şeyin özelliklerini(property) tutmak için kullanabiliyoruz.
        public int Id { get; set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

        /*
         Not
         * Neden Prop Kullandık?
         * Prop yerine ör: public string FirstName; kullansak olmuyor mu?
         * prop yerine verilen örnek'deki kodu yazmak şuanda hiç bir farklılık göstermeyecek, Yani kod çok düzgün bir şekilde çalışcak.
         * ""public string FirstName;"" bu bir field(alan) tanımlamaktır.
         * ""public string FirstName { get; set; }"" bu bir property(özellik) tanımlamaktır.
         * autoproperty getter ve setter tanımla---- eski yöntem gettter ve setterların içerisine süslü parantezler ekle ve içerisine eklemeler yap. örnek
         *örnek:
                 private string _firstName;
                 public string FirstName { 
                 get
                 {
                    return _firstName Gett edilmek istenen _firstname içirisindeki string döndürülür.
                 } 
                 set
                 {
                    _firstName = value; Sette edilmek istenen string değer _fisrtName içerisine eklenir.
                 }
         * prop. kullanmamızın sebebi encapsulation kullanımında dahada netleşiyor.... 
         */
    }
}
