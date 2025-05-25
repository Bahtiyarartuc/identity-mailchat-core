ASP.NET Core 8.0 Identity Chat & Email Uygulaması

Bu proje, ASP.NET Core 8.0 ile geliştirilmiş, kullanıcı kimlik doğrulaması (Identity), anlık mesajlaşma (Chat), e-posta gönderme/alma ve çeşitli kullanıcı işlemlerini kapsayan tam fonksiyonel bir web uygulamasıdır.

🔧 Teknolojiler ve Araçlar

- ASP.NET Core MVC
- Entity Framework Core
- Razor View yapısıyla sayfa tasarımı
- Bootstrap 
- MSSQL 
- Tek katmanlı mima
- MS SQL Server ile veritabanı yönetimi

📌 Uygulama Özellikleri

🔐 Kullanıcı Kayıt ve Giriş

- Kullanıcılar e-posta ve şifre ile kolayca **kayıt olabilir**.
- Giriş yapan kullanıcılar oturum boyunca kimlikleri doğrulanmış şekilde sistemi kullanabilir.
- Giriş sonrası kullanıcı bilgileri session/token üzerinden yönetilir.

💬 Mesajlaşma (Chat)

- Giriş yapan kullanıcılar sistemdeki diğer kullanıcılarla birebir **mesajlaşabilir**.
- Gönderilen ve alınan mesajlar veritabanına kaydedilir.
- **Gelen Kutusu** (Inbox) ve **Çöp Kutusu** bölümleri ile kullanıcı mesajlarını yönetebilir.
- Her mesaj gönderimi zaman damgası ve gönderici bilgisiyle kayıt altına alınır.

📥 Gelen Mesajlar

- Kullanıcının kendisine gönderilen tüm mesajlar **Gelen Kutusu** altında listelenir.
- Okunmamış mesajlar özel olarak işaretlenebilir.
- Gelen mesajlar silindiğinde "Çöp Kutusu"na taşınır (soft delete mantığı).

🗑️ Çöp Kutusu

- Silinen mesajlar doğrudan veritabanından silinmez, **çöp kutusu**na taşınır.
- Kullanıcı isterse buradan mesajı geri alabilir veya tamamen silebilir.

 👤 Kullanıcı Kartı

- Her kullanıcı için bir **profil kartı** mevcuttur.
- Kullanıcı adı, e-posta adresi, kayıt tarihi gibi bilgiler görüntülenebilir.
- Bu kart üzerinden doğrudan mesaj gönderme özelliği sağlanabilir.

🚪 Oturum Sonlandırma (Çıkış Yap)

- Kullanıcılar tek tıklamayla sistemden **çıkış yapabilir**.
- Oturum bilgileri güvenli şekilde temizlenir.

![](https://github.com/Bahtiyarartuc/identity-mailchat-core/blob/8bd6b6f3d59964726092ce804166c12bcd19fc68/image/1.jpg)
![](https://github.com/Bahtiyarartuc/identity-mailchat-core/blob/8bd6b6f3d59964726092ce804166c12bcd19fc68/image/2.jpg)
![](https://github.com/Bahtiyarartuc/identity-mailchat-core/blob/8bd6b6f3d59964726092ce804166c12bcd19fc68/image/3.jpg)
![](https://github.com/Bahtiyarartuc/identity-mailchat-core/blob/8bd6b6f3d59964726092ce804166c12bcd19fc68/image/5.jpg)
