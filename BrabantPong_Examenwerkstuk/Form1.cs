using System.Data;
using System.Data.SqlClient;
using System.Xml;

namespace BrabantPong_Examenwerkstuk
{
    public partial class formBrabantPong : Form
    {

        public formBrabantPong()
        {
            InitializeComponent();
        }

        /*Dit is de string die een link bevat naar mijn database.*/
        string databaseConnectie = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Sam\\OneDrive - Erasmushogeschool Brussel\\Bureaublad\\EHB\\.NET\\BrabantPong_Examenwerkstuk\\BrabantPong_Examenwerkstuk\\DeData.mdf\";Integrated Security=True";


        private void Form1_Load(object sender, EventArgs e)
        {
            
            
            /*Ik maak een nieuwe databaseconnectie aan genaamd 'connectie',
             Deze maakt gebruik van de eerder gebruikte string met de link naar de database.*/
            SqlConnection connectie = new SqlConnection(databaseConnectie);

            /*Ik pas de font aan vanaf het moment dat de form is geladen.
             Deze geef ik de font 'Arial' met een grootte van 15.
            Aangezien het een titel is, zet ik deze vetgedrukt met 'Bold' als font style.*/
            lblBrabantPongTitel.Font = new Font("Arial", 15, FontStyle.Bold);

            /*Ik zet KeyPreview op true.
             Als ik later zou willen, zou ik hierdoor ervoor kunnen zorgen dat er met keydowns
            een bepaalde knop wordt ingedrukt*/
            this.KeyPreview = true;
        }


        /*Momenteel heb ik maar in strip menu item, maar dit horen er later meer te worden.
         Wanneer het strip menu item wordt aangeklikt, opent de spelerkaart zich van de speler in kwestie.
        Hierbij sluit ik ook het huidige tabblad.*/
        private void strpitem1_Click(object sender, EventArgs e)
        {
            formSpelerKaart spelerkaart = new formSpelerKaart();
            this.Hide();
            spelerkaart.ShowDialog();
            this.Close();
        }

        /*Wanneer er op de Afsluiten-knop wordt gedrukt,
         sluit het formulier af.*/
        private void btnAfsluiten_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void spelersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Speler> lijstVanSpelers = new();
            /*Ik maak een nieuwe databaseconnectie aan genaamd 'connectie',
            Deze maakt gebruik van de eerder gebruikte string met de link naar de database.*/
            SqlConnection connectie = new SqlConnection(databaseConnectie);

            /*Ik open de eerder aangemaakte connectie aan de hand van de Open() method.*/
            connectie.Open();

            /*Ik maak een nieuwe Tool Strip aan.
             Deze geef ik de naam 'ts'.*/
            ToolStrip ts = new ToolStrip();

            /*Met de volgende SQL-Query haal ik alle gegevens op uit de Spelers-tabel.
             Al ga ik ze in de toolbox nog niet volledig gebruiken, vraag ik ze wel al op.
            Ik SELECT de Speler_Id, Club_Adres_Id, Speler_Gender, Speler_Voornaam en de Speler_Achternaam*/
            SqlCommand cmd = new("SELECT Speler_Id, Club_Adres_Id, Speler_Gender, Speler_Voornaam, Speler_Achternaam FROM Spelers", connectie);
            

            /*Vervolgens voeren wij de SlDataReader.*/
            SqlDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {
                /*Ik voeg de gegevens toe aan de lijst.*/
                lijstVanSpelers.Add(new()
                {
                    /*Wanneer ik deze zaken erbij zet, blijft er met de foreach gekopieerd worden.
                     Ik ken de reden niet, maar probeer het uit te zoeken.*/
                    //Speler_Id = (int)reader["Speler_Id"],
                    //Club_Adres_Id = (int)reader["Club_Adres_Id"],
                    //Speler_Gender = (string)reader["Speler_Gender"],
                    Speler_Voornaam = (string)reader["Speler_Voornaam"],
                    Speler_Achternaam = (string)reader["Speler_Achternaam"]
                });
                Speler.Speler_Id = (int)reader["Speler_Id"];
            }
            /*Ik sluit de reader met behulp van de Close()-methode.*/
            reader.Close();

            
            /*Dit is een in commentaar gezette linq-query.
             Ik weet niet of ik deze ga implementeren.
            Ik zoek echter wel nog naar een locatie om een linq-query te implementeren,
            ipv de manier waarop ik tot nu toe queries heb gebruikt.*/
            /*var spelerNamen = lijstVanSpelers
                              .Select(s => s)
                              .Where(st => st.Spele_Id > 0)
                              .Select(s => s.Speler_Voornaam);*/

            /*Ik maak een try-catch aan om een fout op te vangen,
              indien er niet één speler in de database zou ijn.*/
            try
            {
                /*Ik loop doorheen de lijst van spelers.*/
                foreach (Speler sp in lijstVanSpelers)
                {
                    /*Er wordt voor elke speler een ToolStripDropDownButton aangemaakt met de voor- 
                     en achternaam van de speler erin.*/
                    ToolStripDropDownButton tsdb = new(sp.Speler_Voornaam + " " + sp.Speler_Achternaam);

                    /*Deze ToolStripDropDownButton wordt bij deze ook toegevoegd aan het menutje.*/
                    spelersToolStripMenuItem.DropDownItems.Add(tsdb);
                    tsdb.Click += new EventHandler(KaartGenereren);


                    /*Ik dock deze bovenaan.*/
                    ts.Dock = DockStyle.Top;
                  


                }

            }
            /*Dit is wat er gebeurd als de try faalt:*/
            catch
            {
                /*In plaats van te crashen als er een spelers zijn in de database,
                 wordt er een MessageBox aangemaakt die meldt dat 
                er geen spelers in de database zijn.*/
                MessageBox.Show("Er is geen speler in de database.");
            }

            /*Ik maak een methode genaamd 'KaartGenereren' waarmee ik aan de hand van SQL queries,
             zaken select uit de databank.*/
            void KaartGenereren(object? sender, EventArgs e)
            {
                /*Ik selecteer alle componenten uit de tabel Spelers.
                 De ToolStripItem is de sender en ook de index.*/
                SqlCommand sql = new("SELECT Speler_Id, Club_Adres_Id, Speler_Gender, Club_Naam, " +
                    "Speler_Voornaam, Speler_Achternaam FROM Spelers WHERE Speler_Id='"
                    + ((ToolStripItem)sender).Owner.Items.IndexOf((ToolStripItem)sender) + "'", connectie);
                
                /*Ik maak een SqlDataReader aan voor de componenten uit de tabel Spelers.
                 Deze noem ik 'reader'.*/
                SqlDataReader reader = sql.ExecuteReader();
                
                /*Ik laat de reader de database inlezen.
                 Read() is eigenlijk een methode om de reader op te starten.*/
                reader.Read();

                /*Ik maak variabelen aan die ik gelijkstel aan informatie uit de database.
                 Dit doe ik voor voornaam, achternaam, clubnaam en gender,
                aangezien die de componenten zijn uit de tabel Spelers die ik ook in de form
                wil laten zien.
                Ik maak van deze allemaal strings.*/
                string voornaam = (string)reader["Speler_Voornaam"];
                string achternaam = (string)reader["Speler_Achternaam"];
                string clubnaam = (string)reader["Club_Naam"];
                string gender = (string)reader["speler_Gender"];

                /*Ik sluit de reader.*/
                reader.Close();

                /*Ik selecteer alle componenten uit de tabel Niveaus..
                 De ToolStripItem is de sender en ook de index.*/
                SqlCommand niveausql = new("SELECT Speler_Id, Klassement, ELO_Punten " +
                    "FROM Niveaus WHERE Speler_Id='" 
                    + ((ToolStripItem)sender).Owner.Items.IndexOf((ToolStripItem)sender) + "'", connectie);
                SqlDataReader niveaureader = niveausql.ExecuteReader();

                /*Ik maak een SqlDataReader aan voor de componenten uit de tabel Niveaus.
                 * Deze noem ik 'niveaureader'.*/
                niveaureader.Read();

                /*Ik maak variabelen aan die ik gelijkstel aan informatie uit de database.
                 Dit doe ik voor ELO_Punten en Klassement, 
                aangezien die de componenten zijn uit de tabel Niveaus die ik ook in de form
                wil laten zien.
                In het geval van Klassement wordt deze als string gebruikt, 
                en bij ELO_Punten als integer.*/
                int ELO_Punten = (int)niveaureader["ELO_Punten"];
                string Klassement = (string)niveaureader["Klassement"];

                /*Ik sluit de reader.*/
                niveaureader.Close();  

                /*Ik maak een nieuwe formSpelerKaart aan en noem deze 'spk'.
                 Deze geef ik als grootte 818 op 498.
                Ik geef dezelfde maten voor de minimum grootte en maximum grootte.*/
                formSpelerKaart spk = new();
                spk.Size = new(818, 498);
                spk.MinimumSize = new(818, 498);
                spk.MaximumSize = new(818, 498);

                /*Hieronder maak ik de nieuwe labels aan voor de componenten die ik wil tonen 
                 uit de tabel Spelers.
                Dit zijn de voornaam, achternaam, gender en clubnaam.
                Ik maak telkens een nieuwe label aan, vul deze met de juiste informatie,
                en positioneer deze telkens tegenover de bovenkant en linkerkant.*/

                /*Ik maak een lambda expressie aan genaamd 'samenvoegen.
                 Deze kan drie strings samenvoegen tot één geheel.
                Deze expressie ga ik later nog gebruiken.'*/
                var samenvoegen = (string deel1, string deel2, string deel3)
                    => deel1 + deel2 + deel3;



                Label lbl_Voornaam = new();
                lbl_Voornaam.Text = voornaam;
                lbl_Voornaam.Top = 50;
                lbl_Voornaam.Left = 10;

                Label lbl_Achternaam = new();
                lbl_Achternaam.Text = achternaam;
                lbl_Achternaam.Top = 80;
                lbl_Achternaam.Left = 10;

                Label lbl_VolledigeNaam = new();

                /*Ik geef dezelfde font, font-size en font-style aan de label
                 * voor de volledige naam als dat ik bij de titel eerder deed.*/
                lbl_VolledigeNaam.Font = new Font("Arial", 12, FontStyle.Bold);
                
                /*Doordat de string volledigenaam gevormd wordt door twee componenten uit de databank,
                 wordt er hiertussen een grotere spatie gecreëerd dan dat ik wil.
                Ik vind dit onoverzichtelijk, maar ben er niet in geslaagd dit op te lossen.
                Ik vond het iets overzichtelijker door de volledige naam in een grijs kadertje te zetten.
                Dan is het duidelijker dat de voornaam en achternaam samenhoren.*/
                lbl_VolledigeNaam.BackColor = Color.Gray;

                /*Ik vul het tekstveld tbVolledigeNaam met de volledige naam.
                 * Ik maak gebruik van de eerder gemaakte lambda expressie om deze volledige naam te vormen.
                 * Ik geef zelf in welke informatie deel1, deel2 en deel3 moeten ontvangen.
                 * In dit geval gebruik ik eerst de achternaam, dan een spatie en ten slotte de voornaam.
                Hier roep ik als het ware de lambda expressie aan.*/
                string volledigenaam = samenvoegen(achternaam, " ", voornaam);

                lbl_VolledigeNaam.Text = volledigenaam;

                lbl_VolledigeNaam.Top = 50;
                lbl_VolledigeNaam.Left = 75;
                lbl_VolledigeNaam.Size = new(450, 25);

                Label lbl_Speler_Gender = new();

                /*Ik maak een switch case aan die het gender nagaat van de speler.
                 In de database maak ik gebruik van de letter 'M' bij een man,
                en de letter 'V' bij een vrouw.
                Dit maakt dat in de eerste instantie, bij het gender in de form,
                het teken 'M' of 'V' werd gezet, al wou ik deze liever voluit geschreven.
                Als het gender 'V' is, zal lbl_Speler_Gender als inhoud 'Vrouw' hebben.
                Wanneer het gender als 'M' is ingesteld in de database, zal lbl_Speler_Gender
                als inhoud 'Man' hebben.*/
                switch (gender)
                {
                    case "V":
                        lbl_Speler_Gender.Text = "Vrouw";
                        break;
                    case "M":
                        lbl_Speler_Gender.Text = "Man";
                        break;
                    /*De default case is leeg.*/
                    default:
                        break;
                }

                lbl_Speler_Gender.Top = 194;
                lbl_Speler_Gender.Left = 240;

                Label lbl_Club_Naam = new();
                lbl_Club_Naam.Text = clubnaam;
                lbl_Club_Naam.Top = 237;
                lbl_Club_Naam.Left = 240;

                /*Hieronder maak ik de nieuwe labels aan voor de componenten die ik wil tonen 
                uit de tabel Niveaus.
                Dit zijn ELO_Punten en Klassement.
                Ik maak telkens een nieuwe label aan, vul deze met de juiste informatie,
                en positioneer deze telkens tegenover de bovenkant en linkerkant.
                Ik doe hier dus als het ware hetzelfde als dat ik bij de labels voor Spelers heb gedaan.*/
                Label lbl_ELO_Punten = new();
                lbl_ELO_Punten.Text = ELO_Punten.ToString();
                lbl_ELO_Punten.Top = 237;
                lbl_ELO_Punten.Left = 500;

                Label lbl_Klassement = new();
                lbl_Klassement.Text = Klassement;
                lbl_Klassement.Top = 194;
                lbl_Klassement.Left = 500;

                /*Ik voeg de labels voor Spelers toe als controls aan de form.*/
                //spk.Controls.Add(lbl_Voornaam);
                //spk.Controls.Add(lbl_Achternaam);
                spk.Controls.Add(lbl_VolledigeNaam);
                spk.Controls.Add(lbl_Club_Naam);
                spk.Controls.Add(lbl_Speler_Gender);

                /*Ik voeg de labels voor Niveaus toe als controls aan de form.*/
                spk.Controls.Add(lbl_ELO_Punten);
                spk.Controls.Add(lbl_Klassement);

                /*Ik toon de formSpelerkaart spk.*/
                spk.ShowDialog();
                
            }


        }

        private void btnInformatie_Click(object sender, EventArgs e)
        {
            /*Ik maak een nieuwe informatieform aan.*/
            formInformatie informatie = new formInformatie();

            /*Ik zeg dat deze form een MdiContainer is.*/
            this.IsMdiContainer = true;

            /*Ik verklaar dat de form 'informatie',
             deze form, zijnde Form1, als MDI parent heeft.*/
            informatie.MdiParent = this;

            /*Nadat ik heb verklaard dat informatie een childform is van de MDI parent,
             laat ik ook de informatie-form zien.*/
            informatie.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formClubs clubform = new formClubs();
            this.Hide();
            clubform.ShowDialog();
            this.Close();
        }
    }
}