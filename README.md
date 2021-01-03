# DevFramework
 Solid: Java , C gibi Object Orianted Programming((OOP) Nesneye Yönelik Programlama) mimarisine sahip
dillerde sıkıkla kullanılan yazılım geliştirme prensiplerinden biridir. Amaç geliştirme yaparken sıklıkla 
karşılaşılan sorunları 5 temel prensibe dayanarak temiz ve anlaşılır kod yazmaktır. Bu bağlamda Solid şu 
şekilde açıklanabilir.

 #S->Single Responsibility Principle(Tek Sorumluluk İlkesi):
	Özet cümle: “Her sınıfın veya metodun tek bir sorumluluğu olmalı”
	Solid'in S harfi bize her methodun bir sınıfın veya methodun yalnızca tek bir görevi olmalıdır. Bir sınıfın 
değişmesi için bir ve yalnızca bir nedeni olmalıdır.Çoğu geliştiricinin sağlam ve bakımı kolay yazılım oluşturmak için 
uyguladığı temel ilkelerden biridir. Bunu yalnızca sınıflara değil, aynı zamanda yazılım bileşenlerine ve mikro hizmetlere de 
uygulayabiliriz.Sorumluluk ayrımı yapılmadan geliştirilen kodlarda değişikliğe gidilmesi oldukça zorlaşır ve gelişitirme 
maliyeti fazla olan bad kod smell (kötü kokmuş kod) haline dönüşür.

 #O->Open / Closed Principle (Açık ve Kapalı İlkesi):
	Özet cümle:“Sınıflar değişikliğe kapalı ancak gelişime açık olmalıdır.
	Yazılım varlıkları(sınıflar, modüller,fonksiyonlar vb.) gelişmeye açık ama değişmeye kapalı olmalıdır. Amaç
kaynak kodu değiştirmeden modülün işlevini genişletmektir.Sınıflarımız veya metotlarımızı oluştururken ileride 
olabilecek yeni istekler ve gelişmeleri de öngörerek tasarlamamız gerekir. Projemizde oluşabilecek yeni istek ve ihtiyaçlar 
sonucunda yapacağımız geliştirmeler, projemizdeki diğer sistemleri etkilememeli ve herhangi bir değişikliğe sebebiyet vermemelidir.
 
 #L->Liskov’s Substitution Principle(Liskov’un İkame İlkesi):
	Özet cümle:“Yerine geçebilme prensibidir.”
	Alt sınıflar miras aldığı üst sınıfın bütün özelliklerini kullanmalı, 
alt sınıflarda oluşturulan nesneler üst sınıfların nesneleriyle yer değiştirdiklerinde aynı davranışı göstermeli ve 
herhangi bir kullanılmayan özellik olmamalı.

 #I->Interface Segregation Principle(Arayüz Ayrışma Prensibi):
	Özet cümle:“İstemciler, kullanmadıkları arayüzlere bağımlı olmaya zorlanmamalıdır.”
	ISP, temel amacı ara yüz implementation sonucunda oluşacak gereksiz kodları önlemek ve kodumuzun daha amaca yönelik 
hale gelmesini sağlamaktır.

 #D->Dependency Inversion Principle(Bağımlılık Tersine Çevirme Prensibi):
	Özet cümle:“Katmanlı mimarilerde üst seviye modüller alt seviyedeki modüllere doğruda bağımlı olmamalıdır.”
	Prensibin Türkçeye çevrilmiş hali bağımlılıkların tersine çevrilmesi şeklindedir. Pek anlaşılır gelmediğinin farkındayım 
biz bunun yerine açıklamada belirtilen ifadeyi biraz daha açarak “üst seviyeli katmanlar kesinlikle alt seviyedeki katmanlara bağlı 
olmamalı, bağımlılıklar sadece abstract (soyut) kavramlara olmalıdır” şeklinde ifade edebiliriz.Burada amaç üst seviyedeki modüllerin 
alt seviyelere bağımlı olmasından dolayı çıkabilecek sorunları ortadan kaldırmaktır. Yani alt seviyede yapılan herhangi bir değişikliğin 
üst seviyede kod değişikliğine veya onun bağlılıklarının etkilenmesine engel olmaktır.	

Kullanılan Teknolojiler:
	#AutoMapper: Projelerimiz içerisinde tasarladığımız Dto,ViewModel gibi nesnelerimiz ile veritabanı tablolarımızı temsil eden 
	entitylerimizi merkezi bir noktadan daha performanslı bir şekilde eşleştirmemize olanak sağlayan bir kütüphanedir.

	#EntityFramework: Yazılım geliştiricilerin katı sql sorguları yazmalarını ortadan kaldırarak bir ORM (Object Relational Mapping)
	 imkanı sağlayan framework’tür.

	#FluentNHibernate: Nhibernatedeki xml olarak yapılan nesnelerin mapping işlemini classlarda daha kolay bir şekilde yapmamıza olanak sağlayan bir yapıdır.

	#FluentValidation: Kontrollerinin daha esnek hale getirilebilmesini, kolayca değiştirilebilmesini ve genişletilebilmesine olanak sağlamaktadır.

	#Moq:Mock kavramı istediğimiz bir objenin yerine geçebilen fake objelerdir. Bu objelerin istediğimiz gibi davranmalarını sağlayabiliriz. 
	Moq’ta bu tarz işlemleri handle eden ve mock objelerini bize hazır sunan bir kütüphane.

	#NHibernate: Nesneye yönelik bir etki alanı modelini geleneksel ilişkisel veritabanıyla eşleştirmek için bir çerçeve sağlar. 
	Amacı, geliştiriciyi ilişkisel veri kalıcılığıyla ilgili programlama görevlerinin önemli bir bölümünden kurtarmaktır. 

	#Newtonsoft.Json: Yüksek performanslı JSON çerçevesidir.

	#Ninject: Bağımlılıkları enjekte etmede kullanılan open source bir kütüphanedir.

	#PostSharp: Kendi Attribute’ünüzü türetmeniz için bir Base Attribute veriyor.
 
	#log4net:Uygulamamız içerisinden mesajlarımızı loglanmak üzere logger'a gönderdikten sonra, logger uygulamanın loglama seviyesine 
	(bu seviye konfigurasyon dosyasında tutulur) bakar. Eğer mesaj loglama seviyesinin belirlediği hassaslığa uygun ise loglanır.
	
