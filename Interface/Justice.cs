using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Interface
{
    public class Justice : IBioskop
    {
        public void Film()
        {
            Console.WriteLine("Justice League");
            Console.WriteLine("Justice League adalah film pahlawan super Amerika Serikat produksi tahun 2017 yang diangkat dari DC Comics superhero dengan judul yang sama, didistribusikan oleh Warner Bros. Pictures. Ini merupakan instalasi ke tujuh dari DC Extended Universe. Justice League disutradarai oleh Zack Snyder, berdasarkan skenario yang ditulis oleh Chris Terrio, hasil adaptasi dari cerita karya Snyder dan Terrio.");
        }
    }
}
