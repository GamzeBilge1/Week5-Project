# Araba Fabrikası Programı

Bu program, bir araba fabrikasında kullanıcıdan giriş alarak araba üretimi yapan bir konsol uygulamasıdır. Kullanıcıdan araba bilgilerini alarak bir listeye kaydeder ve üretim bilgilerini görüntüler.

---

## Program Akışı

### 1. **Kullanıcıya Soru Sorma**
- Program, kullanıcıya araba üretmek isteyip istemediğini sorar.
- Kullanıcı cevabını **`e`** veya **`h`** olarak girer:
  - **`e`** veya **`evet`**: Araba üretim süreci başlar.
  - **`h`** veya **`hayır`**: Program sonlanır.
  - Geçersiz bir cevap verilirse program uyarı verir ve yeniden sorar.

---

### 2. **Araba Üretim Süreci**
- **Üretim Tarihi**: Araba nesnesinin üretim tarihi otomatik olarak atanır.
- Kullanıcı, aşağıdaki bilgileri sırayla girer:
  1. Seri Numarası
  2. Marka
  3. Model
  4. Renk
  5. Kapı Sayısı
    - Kapı sayısı için sayısal olmayan bir değer girilirse program hata mesajı gösterir ve kullanıcı tekrar giriş yapar.

---

### 3. **Listeye Ekleme**
- Kullanıcının girdiği bilgilerle oluşturulan araba nesnesi, bir **listeye (`List<Araba>`)** eklenir.

---

### 4. **Yeni Araba Üretimi**
- Kullanıcıya tekrar araba üretmek isteyip istemediği sorulur:
  - **`e`** veya **`evet`**: Yeni bir araba üretim süreci başlar.
  - **`h`** veya **`hayır`**: Araba üretim süreci sonlanır ve liste bilgileri görüntülenir.

---

### 5. **Listeyi Yazdırma**
- Kullanıcı "hayır" dediğinde, üretilen tüm arabaların bilgileri şu formatta ekrana yazdırılır:
  - **Seri Numarası**
  - **Marka**
- Her araba bilgisi, diğerlerinden ayırıcı çizgilerle ayrılır.

---

## Kullanılan Özellikler

### 1. **`Araba` Sınıfı**
Araba nesnesi şu özelliklere sahiptir:
- `UretimTarihi`: Otomatik atanır.
- `SeriNo`: Kullanıcıdan alınır.
- `Marka`: Kullanıcıdan alınır.
- `Model`: Kullanıcıdan alınır.
- `Renk`: Kullanıcıdan alınır.
- `KapiSayisi`: Kullanıcıdan alınır ve yalnızca geçerli bir sayı kabul edilir.

### 2. **Kapı Sayısı Girişi Kontrolü**
- `int.TryParse` ile kullanıcı girişi kontrol edilir.
- Geçersiz girişlerde program kullanıcıyı tekrar aynı satıra yönlendirir.

### 3. **Listeleme**
- Araba nesneleri, `List<Araba>` adlı bir listeye kaydedilir ve program sonunda liste bilgileri ekrana yazdırılır.

---

