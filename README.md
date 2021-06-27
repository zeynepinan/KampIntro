# KampIntro
Yazılım Geliştirici Yetiştirme Kampı-Giriş

{C# dilinde bulunan veri tipleri:  
Tam Sayı;
1 - byte (1 byte)
2 - short (2 byte)
3 - int (4 byte)
4 - long (8 byte)

Ondalıklı Sayı;
1 - float (4 byte)
2 - double (8 byte)
3 - deciminal (16 byte)

Metin;
1 - char (2 byte)
1 - string

Mantıksal;
1 - bool

Diğer;
object}

{ Ternary Operatörü

Ternary operatörü tek satırsa if-else komutunu aynı anda kullanabilmemizi sağlar. 
örnek => koşul ? if-işlemleri : else-işlemleri}



{ Switch yapısı

switch(sayilar)//burada case'lerde kontrol edicek değişkeni giriyoruz.
{
case 1: ....... break;// değişkenin değeri 1 ise case 1'in içerisindeki kodları yapacak
case 2: ....... break;// değişkenin değeri 2 ise case 2'nin içerisindeki kodları yapacak
.
.
default: ...... break;// değişkenin değeri caselerde yok ise default değer içerisindeki kodları yapacak
}

}




{ WHİLE DÖNGÜSÜ
while(koşul)
{
}
while yanında yazan koşul doğru olduğu sürece işleyecek bir döngüdür
}


{  REF VE OUT ANAHTAR KELİMELERİ 
Değer Tipli değişkenlerin adreslerini(referanslarını) parametre olarak aktarabilmek için REF veya OUT ifadelerini kullanmaktayız. 
Parametre olarak değişkenin adresi gönderildiği taktirde tıpkı referans tipli değişkenlerde olduğu gibi metot içerisinde yapılan 
değişiklikler ana değişkeni doğrudan etkilenecektir.

Ref ve Out arasındaki tek fark; Out ile tanımlanmış parametrelere ilk değer verme gibi bir zorunluluk yokken ref ile tanımlanmış 
parametrelere ilk değer mutlaka verilmelidir.

}



{Dictionary YAPISI

Dictionary ogrenci = new Dictionary();
ogrenci.Add(134, "kodlama");
ogrenci.Add(431, "youtube");

List classının aksine dinamik yapılı, birden fazla parametre atayabilirsiniz.
Kullanım mantığı bir kapı var, bu kapının arkasına eşyanızı koydunuz. Daha sonra sizde olan, 
kendi oluşturduğunuz bu anahtarla gidip kapıyı açıp, eşyanızı alıyorsunuz.
List yapısında siz veriyi atıyordunuz o sırasıyla tane, tane her attığınızda anahtar oluşturuyor 1,2,3,4. 
dictionary'de ise kendi anahtarınızı kendiniz oluşturup istediğiniz index değerini veriyorsunuz.


}




