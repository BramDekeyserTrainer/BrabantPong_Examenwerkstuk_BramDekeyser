namespace BrabantPong_Examenwerkstuk
{
    public partial class formSpelerKaart : Form
    {
        public formSpelerKaart()
        {
            InitializeComponent();
        }

        /*Deze variabelen zijn op dit moment hard coded.
         Het is de bedoeling dat in elk van deze variabelen,
        later de gegevens komen uit de database 
        en afhankelijk zijn van welke naam je in het strip menu hebt aangeklikt.*/
        string voornaam = "Test";
        string achternaam = "Persoon";
        string gender = "V";
        string club = "Halle";

        string klassement = "D4";
        int ELO = 1326;


        private void formSpelerKaart_Load(object sender, EventArgs e)
        {
            /*Uitvoering van de event:*/
            /*Er wordt een nieuwe kaart aangemaakt.*/
            Kaart k1 = new Kaart();

            /*Ik registreert het via het event.*/
            k1.KaartNagaan += k1_KaartNagaan;

            /*Het proces wordt gestart.*/
            k1.ProcesStart();

            /*Ik maak een lambda expressie aan genaamd 'samenvoegen.
             * Deze kan drie strings samenvoegen tot één geheel.
             * Deze expressie ga ik later nog gebruiken.'*/
            var samenvoegen = (string deel1, string deel2, string deel3)
                => deel1 + deel2 + deel3;

            /*Aangezien ik de labels niet meer wil hardcoden,
             maar wil aanvullen met informatie uit de database,
            heb ik de eerder gemaakte variabelen die ik in de labels zette,
            die ik inmiddels uit de design heb verwijderd,
            in commentaar gezet.*/
            /*Ik vul de andere placeholder labels met de juiste variabelen.*/
            //lblPhClub.Text = club;
            //lblPhClubAdres.Text = clubAdres;
            //lblPhKlassement.Text = klassement;

            /*Aangezien er gebruik gemaakt wordt van een integer bij de ELO-punten,
             wordt de inhoud van de variabele ELO, die in een numerieke waarde is tot nu toe,
            omgezet naar tekst via de .ToString() function.*/
            //lblPhELO.Text = ELO.ToString();


        }

        /*Bij de Keer terug-knop wordt de Spelerkaart gesloten en de hoofdform opnieuw geopend.*/
        private void btnKeerTerug_Click(object sender, EventArgs e)
        {
            formBrabantPong hoofdform = new formBrabantPong();
            this.Hide();
            hoofdform.ShowDialog();
            this.Close();
        }

        /*Bij het aanklikken van de afsluiten-knop,
         wordt het formulier gesloten.*/
        private void btnAfsluiten_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*Dit is mijn event handler voor de eerste kaart.*/
        public static void k1_KaartNagaan()
        {
            /*Er wordt in een messagebox gemeld dat het openen van de kaart is gelukt.*/
            MessageBox.Show("De kaart aanmaken en tonen is gelukt!");
        }
    }
}