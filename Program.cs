using System;

public class rangkum_dncc
{
    public static void Main(string[] args)
    {
         /*
         //Menampilkan teks tanpa variabel
            Console.WriteLine ("Aku Anime");
        
        string divisi = "Game"; // 
            Console.WriteLine (divisi);
        
        int nomor = 1; // integer
            Console.WriteLine (nomor);
        
        //Kata Kunci Var
        
        var divisi2 = "Data Analyst";
        var nomor2   = 2;
            Console.WriteLine (divisi2);
            Console.WriteLine (nomor2);
            
        // Kata Kunci Const
        const float phi = 3.14f;
            Console.WriteLine (phi);
        */
        
        //Numbering
        /*
        int a = 42069;
        float b = 420.69696969f;
        double c = 3.14159265358979323846264338327950288419716939937510;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        */
        
        //String
        /*
        string nama = "Allam";
        string nim = "A11.2023.15401";
            Console.WriteLine(nama);
            Console.WriteLine(nim);
        */
        
        //Karakter Backslash
        /*
        string hari ="Senin \tSelasa \tRabu \tKamis \tJum'at \tSabtu \tMinggu";
        string jadwal = "Tidur \rTidur \rTidur";
        
        Console.WriteLine(hari);
        Console.WriteLine(jadwal);
        */
        
        //Manipulasi String
        /*
        string txt1 = "Ini teks";
        string txt2 = "Ini termasuk teks";
        
            Console.WriteLine(txt1.ToUpper());
            Console.WriteLine(txt1.ToLower());
            Console.WriteLine(txt1.Length);
            Console.WriteLine("Apa ini?" + \rtxt1 + \rtxt2);
        */
        
        //String Interpolation
        /*
        string firstName = "Abdul";
        string lastName = "Allam";
        Console.WriteLine($"Nama saya {firstName} {lastName}, salam kenal");
        */
        
        //Boolean
        /*
        bool benar = true;
        
        if (benar == false)
        {
            Console.WriteLine("Jawaban Salah");
        }
        {
            Console.WriteLine("Jawaban Benar");
        }
        */
        
        //Konversi Float ke Integer
        /*
        float first = 3.14f;
        int second = (int)first;
            Console.WriteLine(second);
        */
            
        //Number to String
        /*
        int a = 1;
        float b = 1.5f;
            Console.WriteLine($"{a.ToString()} + {b.ToString()}");
        */
            
    //String to Integer
    /*
    string a = "1";
    string b = "2";
    
    int sum = int.Parse(a) + int.Parse(b);
        Console.WriteLine(sum);
    */
    
    //Operasi Aritmatika
    /*
    var a = 5 + 5;
    var b = 5 - 5;
    var c = 5 / 5;
    var d = 5 * 5;
    var e = 6 % 5;
    var f = -5;
    
    Console.WriteLine(a);
    Console.WriteLine(b);
    Console.WriteLine(c);
    Console.WriteLine(d);
    Console.WriteLine(e);
    Console.WriteLine(f);
    */
    
    //Operator Penugasan
    //Increment
    /*
    int a = 3;
        Console.WriteLine("\r" + a);
        Console.WriteLine(a++);
        Console.WriteLine(a);
    
    int b = 5;
        Console.WriteLine("\r" + b);
        Console.WriteLine(++b);
        Console.WriteLine(b);
    //Decrement
    int c = 8;
        Console.WriteLine("\r" + c);
        Console.WriteLine(c--);
        Console.WriteLine(c);
        
    int d = 6;
        Console.WriteLine("\r" + d);
        Console.WriteLine(--d);
        Console.WriteLine(d);
    */
    
    //Operator Perbandingan
    /*
    int a = 5;
    int b = 4;
        Console.WriteLine(a==b);
        Console.WriteLine(a>b);
        Console.WriteLine(a<b);
    */
        
    //Operator Logika
    //&&
    /*
    int a = 5;
    int b = 4;
    
    bool c = true;
    bool d = false;
    
    if(a < 10 && b > 1)
        {
        Console.WriteLine("true");
        }
        else
        {
        Console.WriteLine("false");
        }
    */
    //Operator Negasi
    /*
    int a = 5;
    int b = 4;
    
    bool c = true;
    bool d = false;
    
    if(a != 6)
        {
        Console.WriteLine("true");
        }
        else
        {
        Console.WriteLine("false");
        }
    */
    
    //Array
    //Integer
    /*
    int [] angka = new int[3];
    angka[0] = 1;
    angka[1] = 2;
    angka[2] = 3;
    
    Console.WriteLine();
    Console.WriteLine(angka[0]);
    Console.WriteLine(angka[1]);
    Console.WriteLine(angka[2]);
    */
    
    //Array Multidimensi
    /*
    int[,] number = new int [2,3];
    int[,] numbers = { {1, 2, 3 }, {4, 5, 6 } };
        Console.WriteLine(numbers[0 , 1]);
        Console.WriteLine(numbers[1 , 6]);
    */
    
    //List
    //add(),AddRange(),Remove(),RemoveAt(),IndexOf(), Containts(),Count()
    /*
    var a = new List<string> { "Game", "Mobile", "Web" };
    for (int i = 0; i < a.Count; i++)
        {
            Console.Write(a[i] + " ");
        }
    */
    
    }
}
