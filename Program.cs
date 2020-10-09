using System;

namespace Pustakamedia
{
    class Program
    {
        static void Main(string[] args)
        {
            Book SeratDewiRuci = new Book("Serat Dewi Ruci", "Luthfi Asmara");
            Member JackWilshere = new Member("Jack Wilshere", "jackwil@gmail.com");
            string title = SeratDewiRuci.getTitle();
            string author = SeratDewiRuci.getAuthor();

            string name = JackWilshere.getName();
            string email = JackWilshere.getEmail();

            Console.WriteLine("Judul Buku    : " + title);
            Console.WriteLine("Author        : " + author);
            Console.WriteLine("Nama Peminjam : " + name);
            Console.WriteLine("Email         : " + email);


        } 
    }
}
