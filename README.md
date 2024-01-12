# Home Sweet Home

**Techcareer.net Fullstack Web Developer Bootcamp bitirme projesi kapsamında tasarlamış olduğum**  
*Home Sweet Home* isimli mobilya satışı yapan ve konsept odalar tasarlayan hayali bir firmanın websitesi.
Tasarımda görsel kısımda [lazzoni.com](https://lazzoni.com/) sitesinden veri çektim.  
Özellikle tasarımımı lazzoni firmasının web sitesine benzetmeye çalıştım.    

  

  

**Web sitesinden görüntüler**


![web-home1](https://github.com/FURKANMEYDAN/Techcarreernet/assets/103230828/c79b4238-45d3-4c35-a6da-1fafea9e761c)   

![web-home2](https://github.com/FURKANMEYDAN/Techcarreernet/assets/103230828/701699ff-d41b-44cd-93d6-062825fceb59)  

![web-home3](https://github.com/FURKANMEYDAN/Techcarreernet/assets/103230828/aa6f1d6d-e7e9-4d3e-840c-e66c9081e1fb)






## Kurulum
Öncelikle .Net sdk indirmemiz gerekiyor ben bu projede 7.0 sürümünü kullandım dolayısıyla .Net 7.0 sürümünü indirmeliyiz [buradan](https://dotnet.microsoft.com/en-us/download/dotnet) indirebilirsiniz.

Projenin çalışması için gerekli paketleri yüklemek için terminal üzerinden kodun bulunduğu dizine gelmeliyiz.(VSCode için **"Cntrl+J"** kısayolu terminal ekranını açacaktır.)
Daha sonra aşağıda belirttiğim komutları kopyalayıp tek tek yüklemeniz gerekli.  

> **Not:** Ben projemde IDE olarak VSCode kullandım, eğer Visual Studio kullanıyorsanız nuget paket  
yükleyicisine aşağıdaki gerekli paketleri tek tek aratıp yükleyebilirsiniz.  
Projede database olarak SQLite kullanıldı fakat siz istediğiniz provider'ı [buradan](https://learn.microsoft.com/en-us/ef/core/providers/?tabs=dotnet-core-cli) indirip kurabilirsiniz.


```bash
dotnet add package Microsoft.EntityFrameworkCore --version 7.0
```  
```bash
dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore --version 7.0
```

```bash
dotnet add package Microsoft.EntityFrameworkCore.Sqlite --version 7.0
```
```bash
dotnet add package Microsoft.EntityFrameworkCore.Design --version 7.0
```
```
dotnet add package Microsoft.Owin.Host.SystemWeb --version 4.2.2
```
```
dotnet add package Microsoft.Owin.Security.Cookies --version 4.2.2
```
```
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --version 7.0
```
## Kullanım
Terminal kısmında projenin olduğu konuma geliyoruz.  
Daha sonra aşağıdaki kodu kopyalayıp terminal ekranına yapıştırıyoruz.  
> **Not:** Kullandığınız IDE de dosyayı açarsanız "debug" butonu veya "run" butonu kullanarak da çalıştırabilirsiniz.
```
dotnet watch run
```
- **Hata:** "Kodu çalıştırdım fakat hiçbir şey olmadı."
- **Çözüm:** Terminal ekranındaki locallhost linkine tıklayarak sayfayı tarayıcınızda açabilirsiniz.
- **Ekstra:** 
Durdurmak için **"Cntrl-C"** kısayolunu kullanarak terminali durdurabilir **"Cntrl+R"** ile  yenileyebilirsiniz.

## Docker Kurulumu
Eğer Docker Desktop uygulamanız yoksa [buradan](https://www.docker.com/products/docker-desktop/) işletim sisteminize göre indirebilirsiniz.
Herhangi bir üyeliğiniz bulunmuyorsa [buradan](https://hub.docker.com/signup) üyelik işlemlerinizi gerçekleştirebilirsiniz.  
## Docker ile çalıştırma

Yükleme ve kaydolma işlemlerini tamamladıktan sonra Docker Desktop adlı uygulamayı açıyoruz.  

> **Note:** Docker Desktop uygulamasının bilgisayarınızda yüklü olduğundan emin olun.Eğer yüklemediyseniz [buradan](https://www.docker.com/products/docker-desktop/) indirebilirsiniz.
Terminale aşşağıdaki komutları sırasıyla  yazıyoruz.

```bash
docker login
```
```bash
docker pull bfmeydan/homesweethome
```
```bash
docker run -p 8080:80 bfmeydan/homesweethome
```
> **Not:** Docker Desktop uygulamasının çalıştığından emin olunuz.
- **Hata:** "Çalıştırdım hiçbir şey gelmedi."
- **Çözüm:** tarayıcınızda  [http://localhost:8080/](http://localhost:8080/) linkini açınız.
