using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrabantPong_Examenwerkstuk
{
    public partial class formInformatie : Form
    {
        public formInformatie()
        {
            InitializeComponent();
        }

        private void formInformatie_Load(object sender, EventArgs e)
        {
            /*In de onderstaande string geef ik informatie over het programma.
             Met \n zet ik zaken op volgende regels.*/
            string informatie = "Hieronder vindt u wat informatie omtrent mijn programma\n\n" +
            "- Bij het open klappen van het toolstripmenutje, komen er namen van spelers tevoorschijn.\n" +
            "Als je één van deze spelers aanklikt, opent zich een nieuw formuliertje genaamd 'SpelerKaart'.\n" +
            "SpelerKaart is een tabblad.\n" +
            "- In de klasse 'Kaart' wordt een event aangemaakt genaamd 'KaartNagaan'\nen maakt gebruik van de " +
            "delegate 'Melding'.\n Deze wordt vervolgens aangeroepen wanneer SpelerKaart wordt geladen.\n" +
            "Deze gaat na of de form juist laadt.\n" +
            "- Form1 is een MDI-form en de parent van de informatie-form.\nVia de Informatie-knop, kan de child-" +
            "form worden geopend.\nDit is de form waarop u zich nu bevindt.\nDeze kunt u ongelimiteerd wegklikken en " +
            "heraanklikken.\n" +
            "- Via een lambda expressie worden de voornaam en achternaam van\nde spelers in één herbruikbare string " +
            "gegoten.\n" +
            "- Ik maak gebruik van drie database tabellen.\nDeze zijn: Spelers, Niveaus en Adressen.\n" +
            "De voor- en achternamen worden hiervan al uit de database gehaald in het toolstrip menu.\n" +
            "Ik ben er ook in geslaagd om deze informatie op de spelerkaart te zetten.\n" +
            "Voor nu kunt u bekijken hoe de SpelerKaart eruit hoort te zien,\ndoor te klikken op de naam " +
            "'Test Persoon' die ik er hardcoded in heb gezet voor nu.\nDe database is gekoppeld via " +
            "een connectiestring die ik gebruik.\n" +
            "- In een klasse Speler, Adres en Niveau,\nzet ik alle componenten met de exacte namen van de database " +
            "tabellen als property,\nmet getters, setters en juiste datatype.\n- Ik maak een gelijkaardige klasse voor " +
            "een lijst die ik gemaakt heb\nwaaruit de clubnamen en clubadressen worden gehaald via Linq-queries.\n" +
            "Dit wordt gedaan binnen een nieuwe form.";

            /*Ik vul het tekstveld 'tbInformatie' met de eerder gedeclareerde variabele 'informatie'.*/
            lblInformatie.Text = informatie;
        }
        
    }
}
