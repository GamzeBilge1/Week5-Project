
using Week5_Pratic;



List<Araba> arabaListesi = new List<Araba>();  // Araba nesnelerinin tutulacağı liste

while (true)
{
    Console.WriteLine("araba üretmek ister misiniz(e/h)");
    string cevap = Console.ReadLine().ToLower(); // Cevap küçük harfe dönüştürülerek okunuyor


    if (cevap == "e" || cevap == "evet")
    {
sorgu2: Araba araba = new Araba();  // Yeni bir araba üretimine başlangıç etiketi (sorgu2) -- Yeni bir araba nesnesi oluşturuluyor
        araba.UretimTarihi = DateTime.Now; // Arabanın üretim tarihi otomatik atanıyor (şu anki zaman)

        Console.WriteLine("seri no giriniz:");
        araba.SeriNo = Console.ReadLine();

        Console.WriteLine("marka giriniz");
        araba.Marka = Console.ReadLine();

        Console.WriteLine("model giriniz");
        araba.Model = Console.ReadLine();

        Console.WriteLine("Renk giriniz");
        araba.Renk = Console.ReadLine();

sorgu: Console.WriteLine("Kapı sayısı giriniz:");
        string input = Console.ReadLine();

        if (!int.TryParse(input, out int kapıSayisi))
        {
            // Geçersiz giriş durumunda uyarı verilir ve tekrar giriş yapılır
            Console.WriteLine("Geçersiz giriş! Lütfen sayısal bir değer giriniz.");
            goto sorgu; // Yeniden girişe dön
        }

        // Geçerli bir sayı girildiyse araba nesnesine atanır
        araba.KapiSayisi = kapıSayisi;

        arabaListesi.Add(araba);  // Oluşturulan araba listeye ekleniyor

        Console.WriteLine("Tekrar araba üretmek ister misiniz(e/h)");
        string cevap2 = Console.ReadLine().ToLower();

        if (cevap2 == "e" || cevap2 == "evet") // Eğer kullanıcı tekrar üretmek isterse
        {
            goto sorgu2;  // Yeni araba üretimine dönülüyor
        }
        else // Kullanıcı hayır derse
        {
            // Liste içeriği yazdırılıyor
            Console.WriteLine("araç bilgileri");
            foreach (var item in arabaListesi)
            {
                Console.WriteLine("araba seri no: " + item.SeriNo);
                Console.WriteLine("araba marka: " + item.Marka);
                Console.WriteLine("-------------------------------------");
            }
            break;  // Döngü sonlandırılıyor
        }


    }
    else if (cevap == "h" || cevap == "hayır")
    {
        break;  // Program sonlandırılıyor
    }
    else
    {
        Console.WriteLine("cevap geçersiz"); // Hata mesajı

    }

}