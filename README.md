# Tech Store Console Application

Bu proje, C# programlama dili ile yazılmış bir konsol uygulamasıdır. Kullanıcının bir telefon ya da bilgisayar oluşturmasına olanak tanır.

---

## Projede Kullanılan Kavramlar

- **Inheritance (Kalıtım):**  
  `Phone` ve `Computer` sınıfları, ortak özellikleri barındıran `BaseMachine` sınıfından türetilmiştir.

- **Encapsulation (Kapsülleme):**  
  Tüm özellikler `get; set;` yapısı ile tanımlanmıştır.

- **Polymorphism (Çok Biçimlilik):**  
  `ProductInfo()` metodu, alt sınıflarda override edilerek her ürün kendi bilgilerini gösterir.

---

## Nasıl Çalışır?

1. Uygulama kullanıcıya bir telefon (1) ya da bilgisayar (2) oluşturmak isteyip istemediğini sorar.
2. Seçilen ürüne ait özellikler atanır.
3. `ProductInfo()` metodu çağrılır ve ürün bilgileri konsola yazdırılır.
4. Kullanıcıya yeni bir ürün oluşturmak isteyip istemediği sorulur.
5. "yes" derse başa döner, "no" derse uygulama kapanır.

---
