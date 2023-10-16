// See https://aka.ms/new-console-template for more information
using System.Data;

Console.WriteLine("Hello, World!");
/*
 * 1. Anlamlı isim kullanın!
 */
int x = 0;
int i = 0;
int d = 0;//Müşterinin üye olmasından bu yana geçen toplam gün sayısı.
int daysSinceCustomerCreated = 150;
int musterininKaydindanBuYanaGecenGunSayisi = 256;

//2. Kısaltmalardan kaçının
var healthPoint = 50;

bool isCorrected = false;
bool isApproved = false;
//3. Instance'lara isim verirken, class ismi kullan veya temsilci isim belirle.
DataTable customersDataTable = new DataTable();
Random randomNumberGenerator = new Random();

var emailList = new List<string>();
//4. Eğer koleksiyon tanımlıyorsanız çoğul (plural) ekler kullanın!
var emails = new List<string>();
//Eğer, şirketin yazılım departmanı bir kod kılavuzu geliştirmiş ise buna uyulmalı.

int intNumber = 0;
//5. Benzer sembol KULLANMAYIN (küfürü yersiniz!)
var o = 0;
var l = 1;
if (o == 1)
{
    o = l;
}

var isOk = false;
var isCanceled = false;
var hasAddress = false;

var isAbsoluteOKAndIncludeAddress = isOk && !isCanceled && hasAddress;

if (isAbsoluteOKAndIncludeAddress)
{

}



//void checkFraudAndSendMail()
//{
//    bool isFraudFinded = true;
//    if (isFraudFinded)
//    {
//        sendMail("prod@vakif.com.tr");
//    }
//}

//void sendMail(string v)
//{
//    throw new NotImplementedException();
//}