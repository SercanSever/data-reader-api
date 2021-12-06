## .Net framework ile geliştirdiğim API'de 3 katman kullanılmıştır.

## Contracts Katmanı

#### Contracts katmanında okunması gereken dosyalar(XML, CSV), dosyaların modelleri ve gerekli dtolar kullanılmıştır.
#### Bu katmanda Factory Design Pattern interfaceleri oluşturulmuştur.

## Service Katmanı

#### Service katmanında dosyalardan gelen datanın(XML, CSV) dönüştürme işlemi yapılmıştır..
#### Bu katmanda web.config dosyasında konfigürasyon olarak tutulan dosyaların endpoint ile değiştirilmesi için gerekli  kodlama yapılmıştır.
#### Bu katmanda gerekli olan Custom Exceptionlar oluşturulmuştur.

## Apı Katmanı

#### Api katmanında iki controller oluşturulmuştur. Bir controller dosya içeriğinin gösterilmesiyle ilgilenirken diğer controller kullanılacak olan verinin değiştirilmesini endpoint ile sağlamaktadır.
#### WebApiConfig dosyasında her gelen datanın jsona dönüştürülmesi için gerekli konfigürasyon yapılmıştır.

#### Proje mimarisinde Mvc, Factory Design Pattern ve Dependency Injection kullanılmıştır.
#### Factory Design Pattern ile veri kümeleri interface ile implement edilmiştir. Projede veri kümeleri birbirine benzediği için her seferinde new operatörü ile bir nesne türetmektense ya da birbirlerinden tamamen bağımsız gibi kodlamaktansa bu desenle tek bir interface ile birleştirilmiştir. Uzantısı farklı olan bir dosya  projeye eklendiği takdirde projede hiç bir değişikliğe gerek duymadan sadece yeni dosyanın okunma işlemi yapılmalıdır.
#### Dependency Injection ile veri aktarımı katmanlar arası tamamen interface kullanılarak yapılmıştır.

#### Projede Ninject.WepApi, Microsoft.Data.Odata gibi 3. parti kütüphaneler kullanılmıştır.
#### Ninject.WepApi ile Dependency Injection NinjectWebCommon dosyasında Ninject Ioc Container ile sağlanmıştır.

#### OData ile dosya içeriğinin filtrelenmesi tek bir metotta bir Attribute ile sağlanmıştır. Gerekli olan filtrelemeler;

* Şehir adına göre sırala
* Desc,Asc
* İlk 10 veriyi göster
* Sadece şehir adlarını ya da kodlarını göster vb. gibi filtrelemeler OData kullanılarak gerçekleştirilebilir.  

  
