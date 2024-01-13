using System;
using System.Collections.Generic;
class program
{
    static List<Film> filmListesi = new List<Film>();   //filmlistesi static olarak belirlendiği için platform sınıfının örneği olmadan çalıştırılabilinir.
    //static bir film koleksiyona film eklenmek için liste oluşturuluyor.
    //film nesneleri depolanıyor.

    static void Main(string[] args)
    {
        Console.WriteLine("- film inceleme platformuna hoşgeldiniz!! -");
        KullaniciGirisi();   //ilk olarak kullanıcı girişini çağırıyoruz.

        //film listesine filmler ekleniyor.
        filmListesi.Add(new Film("Hobbit: Beklenmedik Yolculuk", "Peter Jackson", "Martin Freeman", 2012, FilmTur.Fantastik));
        filmListesi.Add(new Film("Malefiz ", "Robert Stromberg", "Angelina Jolie,Elle Fanning ", 2014, FilmTur.Fantastik));
        filmListesi.Add(new Film("The Jungle Book", " Jon Favreau ", "Neel Sethi, ", 2016, FilmTur.Fantastik));
        filmListesi.Add(new Film("Umudunu Kaybetme ", "Gabriele Muccino", "Will Smith", 2006, FilmTur.Dram));
        filmListesi.Add(new Film("Titanic", "James Cameron", "Leonardo DiCaprio,Kate Winslet", 1997, FilmTur.Dram));
        filmListesi.Add(new Film("La la Land", "Damien Chazelle", "Emma Stone,Ryan Gosling", 2016, FilmTur.Dram));
        filmListesi.Add(new Film("The Matrix", "Christopher Nolan", "Christian Bale, Heath Ledger", 1999, FilmTur.Aksiyon));
        filmListesi.Add(new Film("John Wick", "Chad Stahelski", "Keanu Reeves", 2014, FilmTur.Aksiyon));
        filmListesi.Add(new Film("Mr.& Mrs. Smith", "Doug Liman ", "Angelina Jolie, Brad Pitt", 2005, FilmTur.Aksiyon));
        filmListesi.Add(new Film("YıldızlarArası", "Christopher Nolan", "Matthew McConaughey", 2014, FilmTur.Bilimkurgu));
        filmListesi.Add(new Film("Lucy", "Luc Besson", "Scarlett Johansson", 2014, FilmTur.Bilimkurgu));
        filmListesi.Add(new Film("Mr.Nobody", "Jaco Van Dormael", "Jared Leto", 2009, FilmTur.Bilimkurgu));
        filmListesi.Add(new Film("Merkezi istihbarat", "Rawson Marshall Thurber ", "Dwayne Johnson , Kevin Hart", 2016, FilmTur.Komedi));
        filmListesi.Add(new Film("3 Idiots", "Rajkumar Hirani", " Aamir Khan, R. Madhavan, Sharman Joshi", 2009, FilmTur.Komedi));
        filmListesi.Add(new Film("The Princess Diaries", "Anne Hathaway", "Garry Marshall ", 2001, FilmTur.Komedi));


        filmListesi[0].Puan = 7.8;   //puan özelliği sayesinde filmlere puanları aktarılıyor.
        filmListesi[1].Puan = 6.9;
        filmListesi[2].Puan = 7.4;
        filmListesi[3].Puan = 8;
        filmListesi[4].Puan = 7.9;
        filmListesi[5].Puan = 8;
        filmListesi[6].Puan = 8.7;
        filmListesi[7].Puan = 7.4;
        filmListesi[8].Puan = 7.4;
        filmListesi[9].Puan = 8.7;
        filmListesi[10].Puan = 6.4;
        filmListesi[11].Puan = 7.7;
        filmListesi[12].Puan = 6.3;
        filmListesi[13].Puan = 8.4;
        filmListesi[14].Puan = 6.4;

        FantastikFilmleriListele();   //oluşturduğumuz fonksiyonları çağıran metodlar 
        DramFilmleriListele();
        AksiyonFilmleriListele();
        BilimkurguFilmleriListele();
        KomediFilmleriListele();



        static void FantastikFilmleriListele()   //film türleri listeleniyor.metod ile 
        {
            var fantastikFilmler = filmListesi.FindAll(film => film.Tur == FilmTur.Fantastik); //fantastikfilmler değişkeni tanımlanıyor.

            Console.WriteLine("\nFantastik Filmler:");
            foreach (var film in fantastikFilmler)
            {
                Console.WriteLine($"Ad: {film.Ad} - Yönetmen: {film.Yonetmen} - Başroller: {film.Basroller} - Yıl: {film.Yil} - Puan: {film.Puan}");
            }
        }
        static void DramFilmleriListele()
        {
            var Dramfilmler = filmListesi.FindAll(film => film.Tur == FilmTur.Dram);

            Console.WriteLine("\nDram Filmler:");
            foreach (var film in Dramfilmler)
            {
                Console.WriteLine($"Ad: {film.Ad} - Yönetmen: {film.Yonetmen} - Başroller: {film.Basroller} - Yıl: {film.Yil} - Puan: {film.Puan}");
            }
        }
        static void AksiyonFilmleriListele()  //filmlistesi içinde aksiyon filmlerimi ekrana yazdırıyor.
        {
            var aksiyonFilmler = filmListesi.FindAll(film => film.Tur == FilmTur.Aksiyon);

            Console.WriteLine("\n Aksiyon Filmler:");
            foreach (var film in aksiyonFilmler)
            {
                Console.WriteLine($"Ad: {film.Ad} - Yönetmen: {film.Yonetmen} - Başroller: {film.Basroller} - Yıl: {film.Yil} - Puan: {film.Puan}");
            }
        }

        static void BilimkurguFilmleriListele()
        {
            var bilimkurgufilmler = filmListesi.FindAll(film => film.Tur == FilmTur.Bilimkurgu);

            Console.WriteLine("\n bilimkurgu filmler:");
            foreach (var film in bilimkurgufilmler)
            {
                Console.WriteLine($"Ad: {film.Ad} - Yönetmen: {film.Yonetmen} - Başroller: {film.Basroller} - Yıl: {film.Yil} - Puan: {film.Puan}");
            }
        }
        static void KomediFilmleriListele()
        {
            var komedifilmler = filmListesi.FindAll(film => film.Tur == FilmTur.Komedi);

            Console.WriteLine("\n KomediFilmler:");
            foreach (var film in komedifilmler)
            {
                Console.WriteLine($"Ad: {film.Ad} - Yönetmen: {film.Yonetmen} - Başroller: {film.Basroller} - Yıl: {film.Yil} - Puan: {film.Puan}");
            }
        }


        while (true)
        {
            Console.WriteLine("\n Film İnceleme Plaformu  ");
            Console.WriteLine("-------------------------");
            Console.WriteLine("1. Film Ekle");
            Console.WriteLine("2. Film Seç ");
            Console.WriteLine("3. Film Puanla");
            Console.WriteLine("4. Filmleri Listele");
            Console.WriteLine("5. Türdeki Filmleri Listele");
            Console.WriteLine("6. Film Sil ");
            Console.WriteLine("7. Çıkış");

            int secim;
            while (true)
            {
                Console.Write("Lütfen bir seçenek girin (1-7): ");
                if (int.TryParse(Console.ReadLine(), out secim) && secim >= 1 && secim <= 7)
                    break;

                Console.WriteLine("Geçersiz giriş. Lütfen 1 ile 7 arasında bir sayı girin.");
            }
            switch (secim)
            {
                case 1:
                    FilmEkle();
                    break;
                case 2:
                    FilmSeç();
                    break;
                case 3:
                    FilmPuanla();
                    break;
                case 4:
                    FilmleriListele();
                    break;
                case 5:
                    TurdekiFilmleriListele();
                    break;
                case 6:
                    Console.WriteLine("Silmek istediğiniz film adını girin:");
                    string silinecekFilmAdi = Console.ReadLine();
                    FilmSil(silinecekFilmAdi);
                    break;
                case 7:
                    Environment.Exit(0);
                    break;
            }
        }
    }
    static void KullaniciGirisi()    //soyutlama kullanıldı.
    {
        Console.WriteLine();
        string kullaniciAdi, sifre;
        int girisDenemesi = 0;

        do
        {
            Console.WriteLine("Kullanıcı Adınız:");
            kullaniciAdi = Console.ReadLine();
            Console.WriteLine("Şifreniz:");
            sifre = SifreliYaz();

            if (GirisKontrol(kullaniciAdi, sifre))
            {
                Console.WriteLine("Sisteme giriş yapılmıştır.");
                Console.ReadKey(); break;
            }
            else
            {
                Console.WriteLine("Geçersiz kullanıcı adı veya şifre girdiniz . Lütfen Tekrar deneyiniz.");
                Console.ReadKey(); girisDenemesi++;
                if (girisDenemesi >= 3)
                {
                    Console.WriteLine("Fazla sayıda hatalı giriş yaptınız. Programdan çıkılıyor.");
                    Environment.Exit(0);
                }
            }
        } while (true);
    }

    static bool GirisKontrol(string kullaniciAdi, string sifre)
    {
        if (!GecerlikullaniciAdi(kullaniciAdi))
        {
            Console.WriteLine("Geçersiz kullanıcı adı girdiniz.Şifreniz sadece harf ve sayı içermelidir.");
            return false;
        }

        if (!GecerliSifre(sifre))
        {
            Console.WriteLine("Geçersiz şifre girişi yaptınız.Şifreniz sadece sayı içermelidir.");
            return false;
        }
        return true;
    }

    static bool GecerlikullaniciAdi(string kullaniciadi)
    {
        return !string.IsNullOrEmpty(kullaniciadi) && kullaniciadi.All(char.IsLetterOrDigit);
    }

    static bool GecerliSifre(string sifre)
    {
        return !string.IsNullOrEmpty(sifre) && sifre.All(char.IsDigit);
    }

    static string SifreliYaz()
    {
        string sifre = "";
        do
        {
            ConsoleKeyInfo key = Console.ReadKey(true);

            if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
            {
                sifre += key.KeyChar;
                Console.Write("*");
            }
            else
            {
                if (key.Key == ConsoleKey.Backspace && sifre.Length > 0)
                {
                    sifre = sifre.Substring(0, (sifre.Length - 1));
                    Console.Write("\b \b");
                }
                else if (key.Key == ConsoleKey.Enter)
                {
                    break;
                }
            }
        } while (true);

        Console.WriteLine();

        return sifre;
    }


    static void FilmEkle()
    {
        Console.Write("Film Adı: ");
        string ad = Console.ReadLine();

        Console.Write("Yönetmen: ");
        string yonetmen = Console.ReadLine();

        Console.Write("Başroller : ");
        string basroller = Console.ReadLine();

        Console.Write("Yıl: ");
        int yil;

        while (!int.TryParse(Console.ReadLine(), out yil) || yil < 1800 || yil > DateTime.Now.Year)
        {
            Console.WriteLine($"Geçersiz giriş. Lütfen 1800 ile {DateTime.Now.Year} arasında bir sayı girin.");
        }

        Console.WriteLine("\n Tür Seçenekleri:");
        foreach (FilmTur tur1 in Enum.GetValues(typeof(FilmTur)))
        {
            Console.WriteLine($"{(int)tur1}. {tur1}");
        }

        Console.Write("Tür (sayı): ");
        int turSecim;
        while (!int.TryParse(Console.ReadLine(), out turSecim) || !Enum.IsDefined(typeof(FilmTur), turSecim))
        {
            Console.WriteLine("Geçersiz giriş. Lütfen geçerli bir tür numarası girin.");
        }

        FilmTur tur = (FilmTur)turSecim;

        Film film = new Film(ad, yonetmen, basroller, yil, tur);
        filmListesi.Add(film);

        Console.WriteLine("\nFilm başarıyla eklendi!");
    }
    static void FilmSeç()
    {
        FilmleriListele();

        if (filmListesi.Count == 0)
        {
            Console.WriteLine("Listede film bulunmuyor.");
            return;
        }

        Console.Write("\nHangi filmi seçmek istiyorsunuz? (Film Adı): ");
        string filmAdi = Console.ReadLine();

        Film secilenFilm = filmListesi.Find(film => film.Ad.Equals(filmAdi, StringComparison.OrdinalIgnoreCase));

        if (secilenFilm != null)
        {
            Console.WriteLine($"\nSeçilen Film: {secilenFilm.Ad} - Yönetmen: {secilenFilm.Yonetmen} - Başroller: {secilenFilm.Basroller} - Yıl: {secilenFilm.Yil} - Tür: {secilenFilm.Tur} - Puan: {secilenFilm.Puan}");

            Console.Write($"Lütfen {secilenFilm.Ad} filmini puanlayın (0-10 arası): ");
            double kullaniciPuani;
            while (!double.TryParse(Console.ReadLine(), out kullaniciPuani) || kullaniciPuani < 0 || kullaniciPuani > 10)
            {
                Console.WriteLine("Geçersiz giriş. Lütfen 0 ile 10 arasında bir sayı girin.");
            }

            secilenFilm.Puanla(kullaniciPuani);
            Console.WriteLine($"{secilenFilm.Ad} filminin puanı güncellendi. Yeni Puan: {secilenFilm.Puan}");
        }
        else
        {
            Console.WriteLine("Belirttiğiniz isimde bir film bulunamadı.");
        }
    }
    static void FilmPuanla()
    {
        FilmleriListele();

        if (filmListesi.Count == 0)
        {
            Console.WriteLine("Puan verilecek film bulunmuyor.");
        }
        else
        {
            Console.Write("\nHangi filmi puanlamak istiyorsunuz? (Film Adı): ");
            string filmAdi = Console.ReadLine();

            Film secilenFilm = filmListesi.Find(film => film.Ad.Equals(filmAdi, StringComparison.OrdinalIgnoreCase));

            if (secilenFilm != null)
            {
                Console.Write($"Lütfen {secilenFilm.Ad} filmini puanlayın (0-10 arası): ");
                double kullaniciPuani;
                while (!double.TryParse(Console.ReadLine(), out kullaniciPuani) || kullaniciPuani < 0 || kullaniciPuani > 10)
                {
                    Console.WriteLine("Geçersiz giriş. Lütfen 0 ile 10 arasında bir sayı girin.");
                }

                secilenFilm.Puanla(kullaniciPuani);
                Console.WriteLine($"{secilenFilm.Ad} filminin puanı güncellendi. Yeni Puan: {secilenFilm.Puan}");
            }
            else
            {
                Console.WriteLine("Belirttiğiniz isimde bir film bulunamadı.");
            }
        }
    }
    static void FilmleriListele()
    {
        if (filmListesi.Count == 0)
        {
            Console.WriteLine("Henüz hiç film eklenmemiş.");
        }
        else
        {
            Console.WriteLine("\nFilmler:");
            foreach (var film in filmListesi)
            {
                Console.WriteLine($"Ad: {film.Ad} - Yönetmen: {film.Yonetmen} - Başroller: {film.Basroller} - Yıl: {film.Yil} - Tür: {film.Tur} - Puan: {film.Puan}");
            }
        }
    }
    static void TurdekiFilmleriListele()
    {
        Console.WriteLine("\nTür Seçenekleri:");
        foreach (FilmTur tur in Enum.GetValues(typeof(FilmTur)))
        {
            Console.WriteLine($"{(int)tur}. {tur}");
        }

        int secim;
        while (true)
        {
            Console.Write("Lütfen bir tür seçin (1-5): ");
            if (int.TryParse(Console.ReadLine(), out secim) && secim >= 1 && secim <= 5)
                break;

            Console.WriteLine("Geçersiz giriş. Lütfen 1 ile 5 arasında bir sayı girin.");
        }

        FilmTur secilenTur = (FilmTur)secim;

        var filmler = filmListesi.FindAll(film => film.Tur == secilenTur);

        if (filmler.Count == 0)
        {
            Console.WriteLine($"Henüz {secilenTur} türünde film eklenmemiş.");
        }
        else
        {
            Console.WriteLine($"\n{secilenTur} Filmleri:");
            foreach (var film in filmler)
            {
                Console.WriteLine($"Ad: {film.Ad} - Yönetmen: {film.Yonetmen} - Başroller: {film.Basroller} - Yıl: {film.Yil} - Puan: {film.Puan}");
            }
        }
    }

    static void FilmSil(string filmAdi)
    {
        var silinecekFilm = filmListesi.Find(film => film.Ad == filmAdi);

        if (silinecekFilm != null)
        {
            // filmi listeden kaldır
            filmListesi.Remove(silinecekFilm);
            Console.WriteLine($"{filmAdi} adlı film başarıyla silindi.");
        }
        else
        {
            Console.WriteLine($"{filmAdi} adlı film bulunamadı.");
        }

    }

    enum FilmTur
    {
        Fantastik, //0
        Dram,  //1
        Aksiyon, //2
        Bilimkurgu,  //3
        Komedi, //4
    }
    class Film
    {
        //filmin özellikleri
        public string Ad { get; }   //kapsülleme kullanıldı
        public string Yonetmen { get; }
        public string Basroller { get; }
        public int Yil { get; }
        public FilmTur Tur { get; }
        public double Puan { get; set; }
        public Film(string ad, string yonetmen, string basroller, int yil, FilmTur tur)
        {
            //film sınıfının yapıcı metodu
            Ad = ad;
            Yonetmen = yonetmen;
            Basroller = basroller;
            Yil = yil;
            Tur = tur;
        }

        public void Puanla(double kullaniciPuani)    //kullanıcının puanına göre puanı güncelliyor.
        {
            Puan = (Puan + kullaniciPuani) / 2;
        }
    }
}

