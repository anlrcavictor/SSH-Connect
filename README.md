# SSH-Connect

## Neden Bu Proje
*İlk stajımı yaptığım türk telekom santral bölümünde çalışan mühendis ve teknikerlerin işlerine yarayacak birşeyler yapmak istemem
sebebi ile aslında kendimi geliştirmek istediğim Java Programlama Dilinden farklı olarak bu projeyi yaptım.Santral de çalışanların 
Linux işletim sistemi ile çalışan EMSAN adlı ağ cihazlarını konfigürasyon ve güncelleme amaçlı SSH Protololünü kullanarak devamlı 
yaptıkları bir işlem vardı.Yaptıkları işlem ise kendi kurdukları bir web sitesi vasıtasıyla kendi DB lerinden aldıkları bazı bilgileri
kopyalayarak PUTTY adlı program vasıtasıyla EMSAN ları güncelliyorlardı.Bu işlem için PUTTY Terminaline aldıkları bilgileri ve gerekli 
linux komutarını elleriyle yazıyorlardı.Anlamsız bir iş tekrarı vardı.Çalışan mühendislerden birisinin C# programlama diline giriş 
seviyesinde hakim olduğunu ve bazı görsel programlama işlemlerini yapabildiğini de göz önünde bulunarak.PUTTY nin yaptığı işi yapan ve 
zamanla yapılan işe uygun şekilde özelleştirilerk iş tekrarı ve vakit kaybını ortadan kaldırabilecek bu programı yapmak için 20 iş günü
olan staj süresi boyunca bu proje ile uğraştım.*

### Proje Açıklaması

![SSH Connect](https://github.com/anlrcavictor/SSH-Connect/blob/master/SSHDeneme/ImgForReadme/SshConnectGorunum.png?raw=true)


*SSH Protokolünü kullanararak uzaktan Linux İşletim Sistemi Tabanlı bir Sunucuyu uzaktan kontrol eden C# programlama dili ile yazılmış
bir programdır.Programı gerçekleştirmek için araştırmalarım sonucu Renci.SshNet adlı kütüphaneyi kullanmaya karar verdim.Ne yazıkki 
kütüphanenin 3.şahıslar tarafından yazılması ve açıklama belgelerinin zayıf olması işimi zorlaştırdı.Kütüphanenin hazır bazı fonksiyonları 
ana şartlarıyla yapmamız gereken işlere uygundu.Staj arkadaşımın ubuntu kurulu bilgisyarına Linux Server yükleyerek programımızı denedik.
Terminalimizle kontrol işlemi sağlanıyordu.Özelleştirmek için tek bir button la ping ve ipconfig işlemini uygulamaya çalıştım.*</br>
![İpconfig + Ping Butonu](https://github.com/anlrcavictor/SSH-Connect/blob/master/SSHDeneme/ImgForReadme/ifconfigPing.JPG?raw=true)
</br>
*Günlük uygulanan tüm komutları o günün tarihi ile kayıt işlemi gibi özellikleri ekledim.Günde uygulanan tüm komutlar ve cevapları
(Konsol Ekranı)O günün tarihi ile istenilen konumda yeni bir txt dosyası oluşturularak kayıt ediliyor.*
![Loglama İşlemi](https://github.com/anlrcavictor/SSH-Connect/blob/master/SSHDeneme/ImgForReadme/Kay%C4%B1t.JPG?raw=true)
*Bu özelleştirmeleri string fonksiyonlarını (kesme birleştirme,Replace vb.)kullanarak gerçekleştirdim.Bu çözüm konsol ekranında dönen 
cevapları dinleyen ve şunu gördüğün zaman şunu yap mantığıyla çalışıyor.Akılcı bir çözüm olduğunu düşünmüyorum çünkü bağlanılan her
cihazın adı ve durumu farklı olduğu için bu okuma işemi hatalara gebe durumdadır.*
</br></br>
*Tüm bu işlemler Form1.Cs ve Atomik.cs classlarında yapılmaktadır.Proje İsmi SSHDenemedir.*
</br></br>
*Proje Windows a yüklenebilir hale getirilmiştir.Setup Dosyası SSHConnect/Debug/ altındadır*
</br></br>
*Renci.SshNet Kütüphanesinin açıklama belgelerini [buradan](http://www.nudoq.org/#!/Packages/SSH.NET/Renci.SshNet/Renci.SshNet) inceleyebilirsiniz.*






