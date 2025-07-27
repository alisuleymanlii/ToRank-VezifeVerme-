List<double> valyutalist = new List<double> { 1.7, 2, 0.04 };
List<string> valyutaisim = new List<string>{"Dolar","Euro","Tl"};

Console.WriteLine("Valyuta sistemine xos geldiniz!");

void mezenneler()
{
    int index = 1;
    Console.WriteLine("-----Mezenneler-----");
    foreach (var i in valyutalist)
    {
        Console.WriteLine(index + "-" + i + " " + valyutaisim[index - 1]);
        index++;
    }
}

void mezennesilme()
{
    Console.Write("Silmek istediyiniz mezennenin id-ni girin: ");
    int id = Convert.ToInt32(Console.ReadLine());
    if (id > 0 && id <= valyutalist.Count())
    {
        valyutalist.RemoveAt(id - 1);
        valyutaisim.RemoveAt(id - 1);
    }
    else
    {
        Console.WriteLine("Sehv id!");
    }
    mezenneler();
}

void mezenneelave()
{
    Console.Write("Elave etmek istediginiz mezenne adi: ");
    string ad = Console.ReadLine();
    Console.Write("Elave etmek istediginiz mezenne qiymeti: ");
    int qiymet = Convert.ToInt32(Console.ReadLine());

    valyutalist.Add(qiymet);
    valyutaisim.Add(ad);
    mezenneler();
}

void mezennedeyis()
{
    Console.Write("Deyismek istediyiniz mezenne id-ni girin: ");
    int id = Convert.ToInt32(Console.ReadLine());
    if (id > 0 && id <= valyutalist.Count)
    {
        Console.Write("Yeni qiymet girin: ");
        int yeniqiymet = Convert.ToInt32(Console.ReadLine());
        valyutalist[id - 1] = yeniqiymet;
    }
    else
    {
        Console.WriteLine("Sehv id!");
    }
}


//valyutaya cevirmek ele. do da id kecersizliyini duzelt.

do
{
    Console.WriteLine("----------");
    Console.WriteLine("1-Mezenneler \n2-Valyuta cevirmek \n3-Mezenne deyismek \n4-Mezenne elave etmek \n5-Mezenne silmek");
    Console.WriteLine("----------");
    Console.Write("Id girin: ");
    int id = Convert.ToInt32(Console.ReadLine());

    if (id == 1)
    {
        mezenneler();
    }

} while (true);

