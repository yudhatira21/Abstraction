using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.AbstractClass
{
    public class Avatar : Bioskop
    {
        public override void Film()
        {
            Console.WriteLine("Avatar");
            Console.WriteLine("Avatar, dikenal sebagai James Cameron's Avatar, adalah film fiksi ilmiah petualangan Amerika Serikat tahun 2009 yang disutradarai oleh James Cameron dan diproduseri oleh James Cameron dan Jon Landau. Naskah film ini ditulis oleh James Cameron. Film ini dibintangi oleh Sam Worthington, Zoe Saldana, Stephen Lang, Michelle Rodriguez dan Sigourney Weaver.");
        }
    }
}
