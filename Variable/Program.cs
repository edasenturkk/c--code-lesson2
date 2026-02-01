// type safe language: degiskenin ismi ve tip bilgisini vermek zorundasın.

String name = "Ahmet";
Console.WriteLine("Merhaba "+name+" nasılsın?");

//Tip güvenliği 
// Derleme zamanı kontrolleri ile pek çok hatayı erken yakalar.
// Dönüştürmeler, genericler nullable tür anotasyonları ve pattern matching ile güvenliği arttırır.

Console.WriteLine("Lütfen adınızı giriniz: ");
var ad = Console.ReadLine();
Console.WriteLine("Merhaba " + ad);
Console.WriteLine(ad?.GetType());

//String yerine var da kullanılabilir dinamik bir atama yapmak istersen.


//Nullcheck
int? age = 22;
var nam = "Ali";

Console.WriteLine("age değişken tipi: " + age?.GetType()) ;
Console.WriteLine("nam değişken tipi: " +nam.GetType()) ;

string? nullable = null;  //nullable string
Console.WriteLine("Büyük harf: " + nullable?.ToUpper());
Console.WriteLine("Kullanıcı Adı " + (nullable ?? "Bilinmiyor"));
Console.WriteLine("Yaş: " + (age ?? 0));

Console.ReadKey();
