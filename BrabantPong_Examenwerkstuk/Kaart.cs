using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrabantPong_Examenwerkstuk
{
    public class Kaart
    {
        /*Ik maak de delegate 'Melding' aan die ik verder bij mijn event ga gebruiken.*/
        public delegate void Melding();

            /*Ik maak een publieke event aan met de naam 'KaartNagaan'*/
            public event Melding KaartNagaan; // event

            /*Wanneer de event van start gaat, 
             wordt er eerst een melding via een messagebox gegeven.
             Deze geeft aan dat het openen van de spelerkaart is begonnen.*/
            public void ProcesStart()
            {
                MessageBox.Show("Openen van de spelerkaart is begonnen...");

            /*Vervolgens activeert men de methode OnKaartNagaan().*/
                OnKaartNagaan();
            }

            /*OnKaartNagaan() is een protected virtuele methode.*/
            protected virtual void OnKaartNagaan()
            {
                /*Als ProcessStart() geen null is,
                 wordt de delegate aangeroepen.*/
                KaartNagaan?.Invoke();
            }
        
    }
}
