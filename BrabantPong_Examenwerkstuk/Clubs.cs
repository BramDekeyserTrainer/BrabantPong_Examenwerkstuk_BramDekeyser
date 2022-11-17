using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace BrabantPong_Examenwerkstuk
{
    public partial class formClubs : Form
    {
        public formClubs()
        {
            InitializeComponent();
        }

        private void formClubs_Load(object sender, EventArgs e)
        {
            int i = 0;

            /*Ik maak een lijst met clubs aan, zodat ik op deze een linq query kan toepassen.
             Deze bevat een Club_Id, een Clubnaam ene en Clubadres.
            Deze lijst staat los van de eigenlijke database.*/
            IList<Club> clubLijst = new List<Club>() {
    new Club() { Club_Id = 1, Clubnaam = "Den Hoek", Clubadres = "Rue Tête d'Epine 14, 1640 Rhode-Saint-Genèse" } ,
    new Club() { Club_Id = 2, Clubnaam = "Dilbeek", Clubadres = "Jozef Mertensstraat 27a, 1702 Dilbeek" } ,
    new Club() { Club_Id = 3, Clubnaam = "Leuven", Clubadres = "Dekenstraat 3, 3000 Leuven" } ,
    new Club() { Club_Id = 4, Clubnaam = "Tienen" , Clubadres = "Alexianenweg 2, 3300 Tienen" } ,
    new Club() { Club_Id = 5, Clubnaam = "Wemmel" , Clubadres = "Dijck 34, 1780 Wemmel" }
};

            /*Ik maak gebruik van een linq-query om de eerste clubnaam uit de lijst te halen.*/
            var clubquery1 = from s in clubLijst
                                   where s.Club_Id == 1
                                   select new{ Clubnaam = s.Clubnaam };

            clubquery1.ToList().ForEach(s => tbClubnamen.Text = s.Clubnaam);

            /*Ik maak gebruik van een linq-query om de tweede clubnaam uit de lijst te halen.*/
            var clubquery2 = from s in clubLijst
                             where s.Club_Id == 2
                             select new { Clubnaam = s.Clubnaam };

            clubquery2.ToList().ForEach(s => tbClubnamen2.Text = s.Clubnaam);

            /*Ik maak gebruik van een linq-query om de derde clubnaam uit de lijst te halen.*/
            var clubquery3 = from s in clubLijst
                             where s.Club_Id == 3
                             select new { Clubnaam = s.Clubnaam };

            clubquery3.ToList().ForEach(s => tbClubnamen3.Text = s.Clubnaam);

            /*Ik maak gebruik van een linq-query om de vierde clubnaam uit de lijst te halen.*/
            var clubquery4 = from s in clubLijst
                             where s.Club_Id == 4
                             select new { Clubnaam = s.Clubnaam };

            clubquery4.ToList().ForEach(s => tbClubnamen4.Text = s.Clubnaam);

            /*Ik maak gebruik van een linq-query om de wijfde clubnaam uit de lijst te halen.*/
            var clubquery5 = from s in clubLijst
                             where s.Club_Id == 5
                             select new { Clubnaam = s.Clubnaam };

            clubquery5.ToList().ForEach(s => tbClubnamen5.Text = s.Clubnaam);

            /*Ik maak gebruik van een linq-query om het eerste clubdadres uit de lijst te halen.*/
            var adresquery1 = from s in clubLijst
                             where s.Club_Id == 1
                             select new { Clubadres = s.Clubadres };

            adresquery1.ToList().ForEach(s => tbAdressen.Text = s.Clubadres);

            /*Ik maak gebruik van een linq-query om het tweede clubdadres uit de lijst te halen.*/
            var adresquery2 = from s in clubLijst
                              where s.Club_Id == 2
                              select new { Clubadres = s.Clubadres };

            adresquery2.ToList().ForEach(s => tbAdressen2.Text = s.Clubadres);

            /*Ik maak gebruik van een linq-query om het derde clubdadres uit de lijst te halen.*/
            var adresquery3 = from s in clubLijst
                              where s.Club_Id == 3
                              select new { Clubadres = s.Clubadres };

            adresquery3.ToList().ForEach(s => tbAdressen3.Text = s.Clubadres);

            /*Ik maak gebruik van een linq-query om het vierde clubdadres uit de lijst te halen.*/
            var adresquery4 = from s in clubLijst
                              where s.Club_Id == 4
                              select new { Clubadres = s.Clubadres };

            adresquery4.ToList().ForEach(s => tbAdressen4.Text = s.Clubadres);

            /*Ik maak gebruik van een linq-query om het vijfde clubdadres uit de lijst te halen.*/
            var adresquery5 = from s in clubLijst
                              where s.Club_Id == 5
                              select new { Clubadres = s.Clubadres };

            adresquery5.ToList().ForEach(s => tbAdressen5.Text = s.Clubadres);
        }

        /*Met de Keer Terug-knop, open ik de hoofdform opnieuw en sluit ik deze.*/
        private void btnKeerTerug_Click(object sender, EventArgs e)
        {
            formBrabantPong hoofdform = new formBrabantPong();
            this.Hide();
            hoofdform.ShowDialog();
            this.Close();
        }

        /*Ik sluit de form af met de Close()-methode.*/
        private void btnAfsluiten_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
