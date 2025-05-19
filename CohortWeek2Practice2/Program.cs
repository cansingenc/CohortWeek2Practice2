////int sayac = 0;

////while (sayac < 10)
////{
////    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
////    sayac++;
////}


////int sayac = 1;

////while (sayac <=20)
////{
////    Console.WriteLine(sayac);
////    sayac++;

////}


//int sayac = 1;

//while (sayac <=20)
//{
//    if (sayac % 2 == 0)
//    {
//        Console.WriteLine(sayac);
//    }



//    sayac++;

//}

int toplam = 0;
int sayac = 50;

while (sayac <= 150)
{
    toplam = sayac + toplam; ;
    sayac++;
}

Console.WriteLine("Toplam: " + toplam);


int tek = 0;
int cift = 0;

int sayac = 1;

while (sayac <= 120)
{
    if (sayac % 2 == 0)
    {
        cift = sayac + cift;

    }
    else
    {
        tek = tek + sayac;
    }
    sayac++;
}

Console.WriteLine("Tek sayıların toplamı: " + tek);
Console.WriteLine("Çift sayıların toplamı: " + cift);




