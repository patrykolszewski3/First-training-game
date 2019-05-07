using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gra1
{
    public partial class FormGame : Form
    {
        int counter = 0; //stan licznika
        int workForce = 6; //punkty siły roboczej do rozdania

        // poziom poszczególnych zasobów
        int morale = 0; 
        int tools = 0;
        int weapon = 0;
        int architecture = 0;
        int food = 0;

        // poziom ulepszenia przyrostu poszczególnych zasobów
        int moraleLvl = 0;
        int toolsLvl = 0;
        int weaponLvl = 0;
        int architectureLvl = 0;
        int foodLvl = 0;

        public FormGame()
        {
            InitializeComponent();
            timerCounter.Start(); // rozpoczęcie działania timera
        }

        private void label1_Click(object sender, EventArgs e) // status zasobu broń
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++; //zwiększenie stanu licznika o 1 co sekundę

            // wyświetlenie wskaźników zasobów, poziomów ulepszenia przyrostu, punktów siły roboczej, liczby dni i czasu jako tekst
            labelTimer.Text = counter.ToString(); 

            labelWorkForce.Text = workForce.ToString();
            labelMorale.Text = morale.ToString();
            labelTools.Text = tools.ToString();
            labelWeapon.Text = weapon.ToString();
            labelArchitecture.Text = architecture.ToString();
            labelFood.Text = food.ToString();
            
            textBoxMoraleLvl.Text = moraleLvl.ToString();
            textBoxToolsLvl.Text = toolsLvl.ToString();
            textBoxWeaponLvl.Text = weaponLvl.ToString();
            textBoxArchitectureLvl.Text = architectureLvl.ToString();
            textBoxFoodLvl.Text = foodLvl.ToString();

            // mechanika przyrostu zasobów jeżeli są mniejsze niż 25

            if  (morale == 0 || morale < 25) // wzrost morali jeżeli są mniejsze niż 25
            {
                morale = morale + moraleLvl;

            }

            if (tools == 0 || tools < 25) // wzrost narzędzi jeżeli są mniejsze niż 25
            {
                tools = tools + toolsLvl;

            }

            if (weapon == 0 || weapon < 25) // wzrost broni jeżeli są mniejsze niż 25
            {
                weapon = weapon + weaponLvl;

            }

            if (architecture == 0 || architecture < 25) // wzrost architektury jeżeli są mniejsze niż 25
            {
                architecture = architecture + architectureLvl;

            }

            if (food == 0 || food < 25) // wzrost żywności jeżeli są mniejsze niż 25
            {
                food = food + foodLvl;

            }

            // mechanika wspomagania przyrostu zasobów przez inne zasoby  

            if (morale >= 25 && morale < 80) //boostowanie przyrostu NARZĘDZI przez MORALE, 
            {
                tools = tools + 1 + (1 * toolsLvl);

            } else if ( morale > 80)
            {
                tools = tools + 2 * (1 * toolsLvl);
            }

            if (tools >= 25 && tools < 80) //boostowanie przyrostu BRONI przez NARZĘDZIA, 
            {
                weapon = weapon + 1 + (1 * weaponLvl);

            }
            else if (tools > 80)
            {
                weapon = weapon + 2 * (1 * weaponLvl);
            }

            if (weapon >= 25 && weapon < 80) //boostowanie przyrostu ARCHITEKTURY przez BROŃ, 
            {
                architecture = architecture + 1 + (1 * architectureLvl);

            }
            else if (weapon > 80)
            {
                architecture = architecture + 2 + (1 * architectureLvl);
            }

            if (architecture >= 25 && architecture < 80) //boostowanie przyrostu ŻYWNOŚCI przez ARCHITEKTURE, 
            {
                food = food + 1 + (1 * foodLvl);

            }
            else if (architecture > 80)
            {
                food = food + 2 + (1 * foodLvl);
            }

            if (food >= 25 && food < 80) //boostowanie przyrostu MORALI przez ŻYWNOŚC, 
            {
                morale = morale + 1 + (1 * moraleLvl);

            }
            else if (food > 80)
            {
                morale = morale + 2 + (1 * moraleLvl);
            }


            if (counter == 1) // wyświetlenie początkowych informacji w pierwszej sekundzie
            {
                textBoxNews.Text = "Nadchodzą zombie! Wypatrzono całkiem sporą hordę, która dojdzie tutaj za 100 dni. " +
                    "Musimy wzmocnić fortyfikacje (architektura do 200) i przygotować sporo broni (broń do 100), inaczej nie mamy z nimi szans!";

            }

            if (counter == 50 && weapon < 50) // zdarzenie negatywne
            {
                textBoxNews.Text = "Mniejsza grupka Zombie zatakowała budowniczych! Mieliśmy zbyt mało broni, aby w porę ich odeprzeć, przez co Zombie zdążyły uszkodzić konstrukcje. Musimy odbudować kilka rzeczy, co nie wszystkim się spodoba. (spadają morale i architektura)";

                if (morale < 50 )
                {
                    morale = morale - morale;
                } else
                {
                    morale = morale - 50;
                }

                if (architecture < 50)
                {
                    architecture = architecture - architecture;
                }
                else
                {
                    architecture = architecture - 50;
                }

                
            }

            if (counter == 90)
            {
                labelTimer.ForeColor = Color.Red;
            }

            if (counter == 100 && architecture < 200 && weapon < 100 ) // informacje o przegranej/wygranej
            {
                textBoxNews.Text = "Horda Zombie zniszczyła osadę!";
                timerCounter.Stop();
            } else if (counter == 100)
            {
                textBoxNews.Text = "Po zaciętej bitwie odparliśmy atak hordy Zombie!";
                timerCounter.Stop();
            }


        }

        private void labelPeople_Click(object sender, EventArgs e) // status punktów Siły Roboczej
        {
            
        }

        private void labelShelterLifepoints_Click(object sender, EventArgs e) // status zasobu narzędzia
        {

        }

        
        private void labelTechniqueDescription_Click(object sender, EventArgs e) // nazwa zasobu Narzędzia
        {

        }

        private void labelTimer_Click(object sender, EventArgs e) // licznik czasu (dni)
        {

        }

        

        private void buttonAddMorale_Click(object sender, EventArgs e) // zwiększanie poziomu ulepszenia przyrostu morali kosztem jednego puntktu siły roboczej
        {
            if (workForce > 0)
            {
                moraleLvl++;
                workForce--;
            }
        }

        private void textBoxMoraleLvl_TextChanged(object sender, EventArgs e) // poziom ulepszenia przyrostu zasobu Morale
        {

        }

        private void buttonAddTechnique_Click(object sender, EventArgs e) // zwiększanie poziomu ulepszenia przyrostu narzędzi kosztem jednego puntktu siły roboczej 
        {
            if (workForce > 0)
            {
                toolsLvl++;
                workForce--;
            }
        }

        private void buttonAddWeapon_Click(object sender, EventArgs e) // zwiększanie poziomu ulepszenia przyrostu broni kosztem jednego puntktu siły roboczej
        {
            if (workForce > 0)
            {
                weaponLvl++;
                workForce--;
            }
        }

        private void buttonAddArchitecture_Click(object sender, EventArgs e) // zwiększanie poziomu ulepszenia przyrostu architektury kosztem jednego puntktu siły roboczej
        {
            if (workForce > 0)
            {
                architectureLvl++;
                workForce--;
            }
        }

        private void buttonAddFood_Click(object sender, EventArgs e) // zwiększanie poziomu ulepszenia przyrostu żywności kosztem jednego puntktu siły roboczej
        {
            if (workForce > 0)
            {
                foodLvl++;
                workForce--;
            }
        }

       

        private void textBoxNews_TextChanged(object sender, EventArgs e) // okienko informacyjne, mówiące o tym co się dzieje w grze
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e) // zamykanie programu
        {
            Close();
        }

        private void buttonBackToMenu_Click(object sender, EventArgs e) // zamykanie okna gry i otwieranie okna menu
        {
            this.Hide();
            FormMenu formMenu = new FormMenu();
            formMenu.Closed += (s, args) => this.Close();
            formMenu.Show();
        }

        private void labelMoraleDescription_Click(object sender, EventArgs e) // nazwa zasobu morale
        {

        }

        private void labelArchitecture_Click(object sender, EventArgs e) // status zasobu architektura
        {

        }

        private void labelFood_Click(object sender, EventArgs e) //  status zasobu żywność
        {

        }

        private void labelMorale_Click(object sender, EventArgs e) // status zasobu morale
        {

        }

        private void labelWeaponDescription_Click(object sender, EventArgs e) // nazwa zasobu Broń
        {

        }

        private void labelArchitectureDescription_Click(object sender, EventArgs e) //  nazwa zasobu Architektura
        {

        }

        private void labelFoodDescription_Click(object sender, EventArgs e) // nazwa zasobu Żywność
        {

        }

        private void textBoxToolsLvl_TextChanged(object sender, EventArgs e) // poziom ulepszenia przyrostu zasobu Narzędzia
        {

        }

        private void textBoxWeaponLvl_TextChanged(object sender, EventArgs e) // poziom ulepszenia przyrostu zasobu Broń
        {

        }

        private void textBoxArchitectureLvl_TextChanged(object sender, EventArgs e) // poziom ulepszenia przyrostu zasobu Architektura
        {

        }

        private void textBoxFoodLvl_TextChanged(object sender, EventArgs e) // poziom ulepszenia przyrostu zasobu Żywność
        {

        }

        private void labelWorkForceDescription_Click(object sender, EventArgs e) // nazwa licznika punktów siły roboczej
        {

        }

        private void labelDay_Click(object sender, EventArgs e) // podpis licznika czasu (dni)
        {

        }

        private void pictureBoxAdvisor_Click(object sender, EventArgs e) // podobizna doradzy którego słowa wyswietają się obok
        {

        }
    }
}
