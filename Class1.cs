using System;
using System.Net;
 
namespace GetIPCS
{
 /// <summary>
 /// Получаем IP адреса локальной машины
 /// </summary>
 class classGetIPCS
 {
  /// <summary>
  /// Получаем IP адреса локальной машины
  /// </summary>
  [STAThread]
  static void Main(string[] args)
  {
   // Получаем имя компьютера
   String strHostName = Dns.GetHostName();
   Console.WriteLine("Host Name: " + strHostName);
 
   // Ищем хост по имени
   IPHostEntry iphostentry = Dns.GetHostByName(strHostName);
 
   // Перечисляем IP адреса
   int nIP = 0;
   foreach(IPAddress ipaddress in iphostentry.AddressList)
   {
    Console.WriteLine("IP #" + ++nIP + ": " +
                      ipaddress.ToString());
   }
  }
 }
}