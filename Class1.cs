using System;
using System.Net;
 
namespace GetIPCS
{
 /// <summary>
 /// �������� IP ������ ��������� ������
 /// </summary>
 class classGetIPCS
 {
  /// <summary>
  /// �������� IP ������ ��������� ������
  /// </summary>
  [STAThread]
  static void Main(string[] args)
  {
   // �������� ��� ����������
   String strHostName = Dns.GetHostName();
   Console.WriteLine("Host Name: " + strHostName);
 
   // ���� ���� �� �����
   IPHostEntry iphostentry = Dns.GetHostByName(strHostName);
 
   // ����������� IP ������
   int nIP = 0;
   foreach(IPAddress ipaddress in iphostentry.AddressList)
   {
    Console.WriteLine("IP #" + ++nIP + ": " +
                      ipaddress.ToString());
   }
  }
 }
}