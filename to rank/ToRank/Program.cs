string data = "data.txt";
List<string> datalist = new List<string>();

Console.WriteLine("Vezife verme proqramina xos geldiniz!");
do
{
    Console.WriteLine("----------------");
    Console.WriteLine("1-Listeye baxmaq \n2-Listeye elave etmek \n3.Listeden silmek \n4-Baglamaq");
    Console.WriteLine("----------------");
    Console.Write("Girilen Id(1-4): ");
    int secme = Convert.ToInt32(Console.ReadLine());

    if (secme == 1)
    {
        listeyebaxmaq();
    }
    else if (secme == 2)
    {
        listeyeelaveetmek();
    }
    else if (secme == 3)
    {
        listedensil();
    }
    else if (secme == 4)
    {
        break;
    }
    else{
        Console.WriteLine("Sehv id!");
    }

} while (true);



void listeyebaxmaq()
{
    string[] lines = File.ReadAllLines(data);
    Console.WriteLine("\n--- LISTE ---");
    Console.WriteLine("Ad - Soyad - Vezife");
    for (int i = 0; i < lines.Length; i++)
    {
        Console.WriteLine($"{i + 1}.{lines[i]}");
    }
}


void listeyeelaveetmek()
{
    if (File.Exists(data))
    {
        datalist = File.ReadAllLines(data).ToList();
    }
    else
    {
        Console.WriteLine("Data faylı yoxdur");
    }

    Console.Write("Adi girin: ");
    string ad = Console.ReadLine();
    Console.Write("Soyadini girin: ");
    string soyad = Console.ReadLine();
    Console.Write("Vezifesini girin: ");
    string vezife = Console.ReadLine();

    string tamamlalist = ad + " " + soyad + " " + vezife;
    datalist.Add(tamamlalist);
    File.WriteAllLines(data, datalist);
    listeyebaxmaq();
}

void listedensil()
{
    if (File.Exists(data))
    {
        datalist = File.ReadAllLines(data).ToList();
    }
    else
    {
        Console.WriteLine("Data faylı yoxdur");
    }

    Console.Write("Silmek istediginiz adamin id girin: ");
    int id = Convert.ToInt32(Console.ReadLine());
    if (id > 0 && id <= datalist.Count())
    {
        datalist.RemoveAt(id - 1);
        File.WriteAllLines(data, datalist);
        listeyebaxmaq();
    }
    else
    {
        Console.WriteLine("Sehv id!");
    }
}




