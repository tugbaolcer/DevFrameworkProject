using System.Data.Entity.Infrastructure.Interception;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DevFramework.Core.Aspects.Postsharp.ExceptionAspects;
using DevFramework.Core.Aspects.Postsharp.LogAspects;
using DevFramework.Core.Aspects.Postsharp.PerformanceAspects;
using DevFramework.Core.CrossCuttingConcernes.Logging.Log4Net.Loggers;
using DatabaseLogger = System.Data.Entity.Infrastructure.Interception.DatabaseLogger;

// Bir bütünleştirilmiş koda ilişkin Genel Bilgiler aşağıdaki öznitelikler kümesiyle
// denetlenir. Bütünleştirilmiş kod ile ilişkili bilgileri değiştirmek için
// bu öznitelik değerlerini değiştirin.
[assembly: AssemblyTitle("DevFramework.Northwind.Business")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("DevFramework.Northwind.Business")]
[assembly: AssemblyCopyright("Copyright ©  2020")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: LogAspect(typeof(DatabaseLogger), AttributeTargetTypes = "DevFramework.Northwind.Business.Concrete.Managers.*")]
[assembly: ExceptionLogAspect(typeof(FileLogger), AttributeTargetTypes = "DevFramework.Northwind.Business.Concrete.Managers.*")]
[assembly: PerformanceCounterAspect(AttributeTargetTypes = "DevFramework.Northwind.Business.Concrete.Managers.*")]

// ComVisible özniteliğinin false olarak ayarlanması bu bütünleştirilmiş koddaki türleri
// COM bileşenleri için görünmez yapar. Bu bütünleştirilmiş koddaki bir türe
// erişmeniz gerekirse ComVisible özniteliğini o türde true olarak ayarlayın.
[assembly: ComVisible(false)]

// Bu proje COM'un kullanımına sunulursa, aşağıdaki GUID tür kitaplığının kimliği içindir
[assembly: Guid("1ac7997f-e9fa-44e0-8578-a064dfc284ae")]

// Bir derlemenin sürüm bilgileri aşağıdaki dört değerden oluşur:
//
//      Ana Sürüm
//      İkincil Sürüm 
//      Yapı Numarası
//      Düzeltme
//
// Tüm değerleri belirtebilir veya varsayılan Derleme ve Düzeltme Numaralarını kullanmak için
// '*' kullanarak varsayılana ayarlayabilirsiniz:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]
