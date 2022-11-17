using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrabantPong_Examenwerkstuk
{
    internal class Niveau
    {
        /*Voor elk onderdeel van de database-tabel Niveaus, 
         maak ik een public property aan, met het juiste type, getters en setters.
         Ik maak gebruik van de exacte benaming.*/
        public int Speler_Id { get; set; }
        public string Klassement { get; set; }
        public int Elo_Punten { get; set; }
    }
}
