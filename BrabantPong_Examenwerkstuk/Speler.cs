using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrabantPong_Examenwerkstuk
{
    internal class Speler
    {
        /*Voor elk onderdeel van de database-tabel Spelers,
         maak ik een public property aan, met het juiste type, getters en setters.
        Ik maak gebruik van de exacte benaming.*/
        public static int Speler_Id { get; set; }
        public int Club_Adres_Id { get; set; }
        public string Speler_Gender { get; set; }
        public string Club_Naam { get; set; }
        public string Speler_Voornaam { get; set; }
        public string Speler_Achternaam { get; set; }

    }
}
