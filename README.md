# Home Sweet Home

Home Sweet Home mobilya satışı yapan ve konsept oda tasarlayan hayali bir firma,
bende bu firma'nın websitesini tasarladım.Tasarımda görsel kısımda [lazzoni.com](https://lazzoni.com/) sitesinden veri çektim.Özellikle tasarımımı lazzoniye benzetmeye çalıştım.

## Kurulum
Öncelikle .Net sdk indirmemiz gerekiyor ben bu projede 7.0 sürümünü kullandım dolayısıyla .Net 7.0 sürümünü indirmeliyiz [buradan](https://dotnet.microsoft.com/en-us/download/dotnet) indirebilirsiniz.

Projenin çalışması için gerekli paketleri yüklemek için terminal üzerinden kodun bulunduğu dizine gelmeliyiz.(VSCode için "cntrl+j" kısayolu terminal ekranını açacaktır.)
Daha sonra aşşağıda belirttiğim komutları kopyalayıp tek tek yüklemeniz gerekli.  

Not:Ben projemde IDE olara VSCode kullandım,eğer Visual Studio kullanıyorsanız nuget paket  
yükleyicisine aşağıdaki gerekli paketleri tek tek aratıp yükleyebilirsiniz.  
Projemde database olarak SQLite kullandım fakat siz istediğiniz provider'ı [buradan](https://learn.microsoft.com/en-us/ef/core/providers/?tabs=dotnet-core-cli) ekleyebilirsiniz


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
Tekrar terminal kısmında projenin olduğu konuma geliyoruz.  
Daha sonra aşağıdaki kodu kopyalayıp terminal ekranına yapıştırıyoruz.  
Not:Kullandığınız IDE de dosyayı açarsanız "debug" butonu veya "run" butonu kullanarak da çalıştırabilirsiniz.
```
dotnet watch run
```
Eğer yukarıdaki komut yazılınca tarayıcınızda açılmıyorsa  
![1](https://drive.google.com/file/d/1fdSZCJTw3wyy20A_Lv-dVSF3PW9I9iN-/view?usp=sharing)
Terminal ekranında ki  locallhost linkine tıklayarak sayfayı açabilirsiniz.  
Durdurmak için "Cntrl-C" kısayolunu kullanarak terminali durdurabilir "Cntrl+R" ile reset atabilirsiniz.





