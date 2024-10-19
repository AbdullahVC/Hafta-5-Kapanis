# Araba Üretim Konsol Uygulaması

Bu C# konsol uygulaması, bir araba fabrikasında araba üretme sürecini simüle eden basit bir projedir. Kullanıcıya araba üretip üretmek istemediği sorulur ve kullanıcıdan girilen bilgilere göre arabalar oluşturulur. Uygulama, kullanıcıyı hatalı girişlere karşı yönlendirir ve araba üretim sürecini yönetir.

## Özellikler
- Kullanıcıdan **Seri Numarası**, **Marka**, **Model**, **Renk** ve **Kapı Sayısı** bilgileri alınarak araba nesneleri üretilir.
- Araba nesneleri üretildiği an otomatik olarak **Üretim Tarihi** alır.
- Kullanıcı birden fazla araba üretebilir ve hepsi bir listeye eklenir.
- **Kapı Sayısı** alanı için sayısal olmayan girişler kabul edilmez, kullanıcı uyarılarak doğru giriş yapması istenir.
- Üretim tamamlandığında, tüm arabaların **Seri Numarası** ve **Marka** bilgileri ekrana yazdırılır.

## Program Akışı
1. Kullanıcıya araba üretmek isteyip istemediği sorulur.
2. Kullanıcı "e" tuşuna basarsa bir araba üretme süreci başlar, "h" tuşuna basarsa program sonlanır.
3. Kullanıcıdan alınan bilgilerle bir araba nesnesi üretilir ve arabalar listesine eklenir.
4. Kullanıcı araba üretmek istemediğinde, program sona erer ve üretilen arabaların **Seri Numarası** ile **Marka** bilgileri ekrana yazdırılır.

## Kullanım
1. Konsolu açın ve uygulamayı çalıştırın.
2. Araba üretmek istiyorsanız "e", istemiyorsanız "h" tuşuna basın.
3. Üretim süreci sırasında araba bilgilerini doldurun:
    - Seri Numarası
    - Marka
    - Model
    - Renk
    - Kapı Sayısı (Sayısal bir değer olmalı)
4. Hatalı bir giriş yaparsanız uyarı alırsınız ve tekrar doğru giriş yapmanız istenir.
5. Tüm arabalar üretildikten sonra, konsol üretilen arabaların seri numaralarını ve markalarını gösterecektir.

## Gereksinimler
- .NET Framework veya .NET Core
- C# destekleyen bir IDE (Visual Studio, Rider, vb.)

## Lisans
Bu proje MIT lisansı ile lisanslanmıştır.
