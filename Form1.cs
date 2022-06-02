using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using System.Data.OleDb;
using System.Configuration;

namespace Formula1
{
    public partial class Form1 : KryptonForm
    {
        public Form1()
        {
            InitializeComponent();
            seasonsPanel.Visible = false;
            teamsPanel.Visible = false;
            driversPanel.Visible = false;
            scheudlePanel.Visible = false;
            mainPanel.Visible = true;

            previus.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/GrandPrixes/monaco.jpg");
            next.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/GrandPrixes/azerbaijan.jpg");

            third.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/Drivers/max verstappen.jpg");
            first.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/Drivers/sergio perez.jpg");
            second.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/Drivers/carlos sainz.jpg");
        }
        private void seasonsBtn_Click(object sender, EventArgs e)
        {
            seasonsPanel.Visible = true;
            teamsPanel.Visible = false;
            driversPanel.Visible = false;
            scheudlePanel.Visible = false;
            mainPanel.Visible = false;

            seasonsDataGridView.DataSource = GetFormulaList("2022");
            kryptonLabel1.Text = "2022";
        }
        private void teamsBtn_Click(object sender, EventArgs e)
        {
            seasonsPanel.Visible = false;
            teamsPanel.Visible = true;
            driversPanel.Visible = false;
            scheudlePanel.Visible = false;
            mainPanel.Visible = false;

            mercedesBtn.Visible = true;
            alfaBtn.Visible = true;
            alphaBtn.Visible = true;
            alpineBtn.Visible = true;
            ferrariBtn.Visible = true;
            haasBtn.Visible = true;
            mclarenBtn.Visible = true;
            redbullBtn.Visible = true;
            redbullBtn.Visible = true;
            astonBtn.Visible = true;
            williamsBtn.Visible = true;

            teamDataGridView.Visible = false;

            driver2Pb.Visible = false;
            driver1Pb.Visible = false;
            carPb.Visible = false;
            infoText.Visible = false;
            infoText2.Visible = false;
            kryptonButton11.Visible = false;
        }
        private void driversBtn_Click(object sender, EventArgs e)
        {
            seasonsPanel.Visible = false;
            teamsPanel.Visible = false;
            driversPanel.Visible = true;
            scheudlePanel.Visible = false;
            mainPanel.Visible = false;

            Pb1.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/Drivers/leclercPng.png");
            Pb2.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/Drivers/verstappenPng.png");
            Pb3.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/Drivers/perezPng.png");
            Pb4.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/Drivers/russellPng.png");
            Pb5.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/Drivers/sainzPng.png");
            Pb6.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/Drivers/norrisPng.png");
            Pb7.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/Drivers/hamiltonPng.png");
            Pb8.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/Drivers/bottasPng.png");
            Pb9.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/Drivers/oconPng.png");
            Pb10.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/Drivers/magnussenPng.png");

            leftBtn.Visible = false;
            rightBtn.Visible = true;

            pb1Label.Text = "1) Charles Leclerc\t86PTS";
            pb2Label.Text = "2) Max Verstappen\t59PTS";
            pb3Label.Text = "3) Sergio Perez\t54PTS";
            pb4Label.Text = "4) George Russell\t49PTS";
            pb5Label.Text = "5) Carlos Sainz\t38PTS";
            pb6Label.Text = "6) Lando Norris\t35PTS";
            pb7Label.Text = "7) Lewis Hamilton\t28PTS";
            pb8Label.Text = "8) Valtteri Bottas\t24PTS";
            pb9Label.Text = "9) Esteban Ocon\t20PTS";
            pb10Label.Text = "10) Kevin Magnussen\t15PTS";

            nat1.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/Nationalities/poland.jpg");
            nat2.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/Nationalities/netherland.jpg");
            nat3.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/Nationalities/mexico.jpg");
            nat4.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/Nationalities/gb.jpg");
            nat5.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/Nationalities/spain.jpg");
            nat6.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/Nationalities/gb.jpg");
            nat7.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/Nationalities/gb.jpg");
            nat8.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/Nationalities/finland.jpg");
            nat9.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/Nationalities/france.jpg");
            nat10.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/Nationalities/denmark.jpg");


        }
        private void scheduleBtn_Click(object sender, EventArgs e)
        {
            gpPicture1.Visible = true;
            gpPicture2.Visible = true;
            gpPicture3.Visible = true;
            gpPicture4.Visible = true;
            gpPicture5.Visible = true;
            gpPicture6.Visible = true;
            gpPicture7.Visible = true;
            gpPicture8.Visible = true;
            gpPicture9.Visible = true;
            gpPicture10.Visible = true;
            gpPicture11.Visible = true;
            gpPicture12.Visible = true;
            gpPicture13.Visible = true;
            gpPicture14.Visible = true;
            gpPicture15.Visible = true;

            gp1.Visible = true;
            gp2.Visible = true; 
            gp3.Visible = true;
            gp4.Visible = true;
            gp5.Visible = true;
            gp6.Visible = true;
            gp7.Visible = true;
            gp8.Visible = true;
            gp9.Visible = true;
            gp10.Visible = true;
            gp11.Visible = true;
            gp12.Visible = true;
            gp13.Visible = true;
            gp14.Visible = true;
            gp15.Visible = true;

            seasonsPanel.Visible = false;
            teamsPanel.Visible = false;
            driversPanel.Visible = false;
            scheudlePanel.Visible = true;
            mainPanel.Visible = false;

            gpPicture1.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/GrandPrixes/bahrein.jpg");
            gpPicture2.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/GrandPrixes/saudi.jpg");
            gpPicture3.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/GrandPrixes/australia.jpg");
            gpPicture4.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/GrandPrixes/emelia.jpg");
            gpPicture5.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/GrandPrixes/america.jpg");
            gpPicture6.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/GrandPrixes/spain.jpg");
            gpPicture7.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/GrandPrixes/monaco.jpg");
            gpPicture8.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/GrandPrixes/azerbaijan.jpg");
            gpPicture9.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/GrandPrixes/canada.jpg");
            gpPicture10.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/GrandPrixes/british.jpg");
            gpPicture11.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/GrandPrixes/austria.jpg");
            gpPicture12.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/GrandPrixes/france.jpg");
            gpPicture13.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/GrandPrixes/hungary.jpg");
            gpPicture14.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/GrandPrixes/belgium.jpg");
            gpPicture15.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/GrandPrixes/netherland.jpg");

            gp1.Text = "Bahrein";
            gp2.Text = "Saudi Arabia";
            gp3.Text = "Australia";
            gp4.Text = "Emelia";
            gp5.Text = "Miami";
            gp6.Text = "Barcelona";
            gp7.Text = "Monaco";
            gp8.Text = "Baku                        V";
            gp9.Text = "Canada";
            gp10.Text = "British";
            gp11.Text = "Austria";
            gp12.Text = "France";
            gp13.Text = "Hunagry";
            gp14.Text = "Belgium";
            gp15.Text = "Netherland";
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            seasonsPanel.Visible = false;
            teamsPanel.Visible = false;
            driversPanel.Visible = false;
            scheudlePanel.Visible = false;
            mainPanel.Visible = true;

            previus.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/GrandPrixes/monaco.jpg");
            next.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/GrandPrixes/azerbaijan.jpg");

            third.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/Drivers/max verstappen.jpg");
            first.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/Drivers/sergio perez.jpg");
            second.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/Drivers/carlos sainz.jpg");
        }

        private DataTable GetFormulaList(string year)
        {
            DataTable result = new DataTable();
            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;

            using(OleDbConnection con = new OleDbConnection(connString))
            {
                using (OleDbCommand cmd = new OleDbCommand("SELECT * FROM " + year, con))
                {
                    con.Open();
                    OleDbDataReader reader = cmd.ExecuteReader();
                    result.Load(reader);
                }
            }
            return result;
        }

        private void season2022Btn_Click(object sender, EventArgs e)
        {
            driverPhoto.Visible = true;
            seasonsDataGridView.DataSource = GetFormulaList("2022");
            kryptonLabel1.Text = "2022";
        }
        private void season2021Btn_Click(object sender, EventArgs e)
        {
            driverPhoto.Visible = false;
            seasonsDataGridView.DataSource = GetFormulaList("2021");
            kryptonLabel1.Text = "2021";
        }
        private void season2020Btn_Click(object sender, EventArgs e)
        {
            seasonsDataGridView.DataSource = GetFormulaList("2020");
            driverPhoto.Visible = false;
            kryptonLabel1.Text = "2020";
        }
        private void season2019Btn_Click(object sender, EventArgs e)
        {
            seasonsDataGridView.DataSource = GetFormulaList("2019");
            driverPhoto.Visible = false;
            kryptonLabel1.Text = "2019";
        }
        private void season2018Btn_Click(object sender, EventArgs e)
        {
            seasonsDataGridView.DataSource = GetFormulaList("2018");
            driverPhoto.Visible = false;
            kryptonLabel1.Text = "2018";
        }
        private void season2017Btn_Click(object sender, EventArgs e)
        {
            seasonsDataGridView.DataSource = GetFormulaList("2017");
            driverPhoto.Visible = false;
            kryptonLabel1.Text = "2017";
        }
        private void season2016Btn_Click(object sender, EventArgs e)
        {
            seasonsDataGridView.DataSource = GetFormulaList("2016");
            driverPhoto.Visible = false;
            kryptonLabel1.Text = "2016";
        }
        private void season2015Btn_Click(object sender, EventArgs e)
        {
            seasonsDataGridView.DataSource = GetFormulaList("2015");
            driverPhoto.Visible = false;
            kryptonLabel1.Text = "2015";
        }
        private void season2014Btn_Click(object sender, EventArgs e)
        {
            seasonsDataGridView.DataSource = GetFormulaList("2014");
            driverPhoto.Visible = false;
            kryptonLabel1.Text = "2014";
        }
        private void season2013Btn_Click(object sender, EventArgs e)
        {
            seasonsDataGridView.DataSource = GetFormulaList("2013");
            driverPhoto.Visible = false;
            kryptonLabel1.Text = "2013";
        }

        private void seasonsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = seasonsDataGridView.Rows[e.RowIndex];

                driverTb.Text = row.Cells["Driver"].Value.ToString();
                nationalityTb.Text = row.Cells["Nationality"].Value.ToString();
                carTb.Text = row.Cells["Car"].Value.ToString();
                pointsTb.Text = row.Cells["Points"].Value.ToString();
                driverTb.Enabled = false;
                nationalityTb.Enabled = false;
                carTb.Enabled = false;
                pointsTb.Enabled = false;
                if (driverPhoto.Visible)
                {
                    driverPhoto.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/Drivers/" + driverTb.Text.ToLower() + ".jpg");
                }
                
            }
        }

        private void mercedesBtn_Click(object sender, EventArgs e)
        {
            mercedesBtn.Visible = false;
            alfaBtn.Visible = false;
            alphaBtn.Visible = false;
            alpineBtn.Visible = false;
            ferrariBtn.Visible = false;
            haasBtn.Visible = false;
            mclarenBtn.Visible = false;
            redbullBtn.Visible = false;
            astonBtn.Visible=false;
            williamsBtn.Visible = false;

            teamDataGridView.Visible = true;
            teamDataGridView.DataSource = GetFormulaList("Mercedes");

            driver1Pb.Visible = true;
            driver2Pb.Visible = true;
            carPb.Visible = true;
            driver1Pb.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/Drivers/lewis hamilton.jpg");
            driver2Pb.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/Drivers/george russell.jpg");
            carPb.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/mercedesCar.jpg");

            kryptonButton11.Visible = true;
        }
        private void alfaBtn_Click(object sender, EventArgs e)
        {
            mercedesBtn.Visible = false;
            alfaBtn.Visible = false;
            alphaBtn.Visible = false;
            alpineBtn.Visible = false;
            ferrariBtn.Visible = false;
            haasBtn.Visible = false;
            mclarenBtn.Visible = false;
            redbullBtn.Visible = false;
            astonBtn.Visible = false;
            williamsBtn.Visible = false;

            teamDataGridView.Visible = true;
            teamDataGridView.DataSource = GetFormulaList("Alfa");

            driver1Pb.Visible = true;
            driver2Pb.Visible = true;
            carPb.Visible = true;
            driver1Pb.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/Drivers/valtteri bottas.jpg");
            driver2Pb.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/Drivers/zhou guanyu.jpg");
            carPb.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/alfaCar.jpg");

            kryptonButton11.Visible = true;
        }
        private void alphaBtn_Click(object sender, EventArgs e)
        {
            mercedesBtn.Visible = false;
            alfaBtn.Visible = false;
            alphaBtn.Visible = false;
            alpineBtn.Visible = false;
            ferrariBtn.Visible = false;
            haasBtn.Visible = false;
            mclarenBtn.Visible = false;
            redbullBtn.Visible = false;
            astonBtn.Visible = false;
            williamsBtn.Visible = false;

            teamDataGridView.Visible = true;
            teamDataGridView.DataSource = GetFormulaList("Alpha");

            driver1Pb.Visible = true;
            driver2Pb.Visible = true;
            carPb.Visible = true;
            driver1Pb.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/Drivers/yuki tsunoda.jpg");
            driver2Pb.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/Drivers/pierre gasly.jpg");
            carPb.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/alphaCar.jpg");

            kryptonButton11.Visible = true;
        }
        private void ferrariBtn_Click(object sender, EventArgs e)
        {
            mercedesBtn.Visible = false;
            alfaBtn.Visible = false;
            alphaBtn.Visible = false;
            alpineBtn.Visible = false;
            ferrariBtn.Visible = false;
            haasBtn.Visible = false;
            mclarenBtn.Visible = false;
            redbullBtn.Visible = false;
            astonBtn.Visible = false;
            williamsBtn.Visible = false;

            teamDataGridView.Visible = true;
            teamDataGridView.DataSource = GetFormulaList("Ferrari");

            driver1Pb.Visible = true;
            driver2Pb.Visible = true;
            carPb.Visible = true;
            driver1Pb.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/Drivers/charles leclerc.jpg");
            driver2Pb.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/Drivers/carlos sainz.jpg");
            carPb.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/ferrariCar.jpg");

            kryptonButton11.Visible = true;
        }
        private void haasBtn_Click(object sender, EventArgs e)
        {
            mercedesBtn.Visible = false;
            alfaBtn.Visible = false;
            alphaBtn.Visible = false;
            alpineBtn.Visible = false;
            ferrariBtn.Visible = false;
            haasBtn.Visible = false;
            mclarenBtn.Visible = false;
            redbullBtn.Visible = false;
            astonBtn.Visible = false;
            williamsBtn.Visible = false;

            teamDataGridView.Visible = true;
            teamDataGridView.DataSource = GetFormulaList("Haas");

            driver1Pb.Visible = true;
            driver2Pb.Visible = true;
            carPb.Visible = true;
            driver1Pb.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/Drivers/kevin magnussen.jpg");
            driver2Pb.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/Drivers/mick schumacher.jpg");
            carPb.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/haasCar.jpg");

            kryptonButton11.Visible = true;
        }
        private void mclarenBtn_Click(object sender, EventArgs e)
        {
            mercedesBtn.Visible = false;
            alfaBtn.Visible = false;
            alphaBtn.Visible = false;
            alpineBtn.Visible = false;
            ferrariBtn.Visible = false;
            haasBtn.Visible = false;
            mclarenBtn.Visible = false;
            redbullBtn.Visible = false;
            astonBtn.Visible = false;
            williamsBtn.Visible = false;

            teamDataGridView.Visible = true;
            teamDataGridView.DataSource = GetFormulaList("McLaren");

            driver1Pb.Visible = true;
            driver2Pb.Visible = true;
            carPb.Visible = true;
            driver1Pb.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/Drivers/daniel ricciardo.jpg");
            driver2Pb.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/Drivers/lando norris.jpg");
            carPb.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/mclarenCar.jpg");

            kryptonButton11.Visible = true;
        }
        private void redbullBtn_Click(object sender, EventArgs e)
        {
            mercedesBtn.Visible = false;
            alfaBtn.Visible = false;
            alphaBtn.Visible = false;
            alpineBtn.Visible = false;
            ferrariBtn.Visible = false;
            haasBtn.Visible = false;
            mclarenBtn.Visible = false;
            redbullBtn.Visible = false;
            astonBtn.Visible = false;
            williamsBtn.Visible = false;

            teamDataGridView.Visible = true;
            teamDataGridView.DataSource = GetFormulaList("RedBull");

            driver1Pb.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/Drivers/max verstappen.jpg");
            driver2Pb.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/Drivers/sergio perez.jpg");
            carPb.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/redbullCar.jpg");

            kryptonButton11.Visible = true;

            driver1Pb.Visible = true;
            driver2Pb.Visible = true;
            carPb.Visible = true;
        }
        private void williamsBtn_Click(object sender, EventArgs e)
        {
            mercedesBtn.Visible = false;
            alfaBtn.Visible = false;
            alphaBtn.Visible = false;
            alpineBtn.Visible = false;
            ferrariBtn.Visible = false;
            haasBtn.Visible = false;
            mclarenBtn.Visible = false;
            redbullBtn.Visible = false;
            astonBtn.Visible = false;
            williamsBtn.Visible = false;

            teamDataGridView.Visible = true;
            teamDataGridView.DataSource = GetFormulaList("Williams");

            driver1Pb.Visible = true;
            driver2Pb.Visible = true;
            carPb.Visible = true;
            driver1Pb.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/Drivers/alexander albon.jpg");
            driver2Pb.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/Drivers/nicholas latifi.jpg");
            carPb.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/williamsCar.jpg");

            kryptonButton11.Visible = true;
        }
        private void alpineBtn_Click(object sender, EventArgs e)
        {
            mercedesBtn.Visible = false;
            alfaBtn.Visible = false;
            alphaBtn.Visible = false;
            alpineBtn.Visible = false;
            ferrariBtn.Visible = false;
            haasBtn.Visible = false;
            mclarenBtn.Visible = false;
            redbullBtn.Visible = false;
            astonBtn.Visible = false;
            williamsBtn.Visible = false;

            teamDataGridView.Visible = true;
            teamDataGridView.DataSource = GetFormulaList("Alpine");

            driver1Pb.Visible = true;
            driver2Pb.Visible = true;
            carPb.Visible = true;
            driver1Pb.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/Drivers/esteban ocon.jpg");
            driver2Pb.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/Drivers/fernando alonso.jpg");
            carPb.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/alpineCar.jpg");

            kryptonButton11.Visible = true;
        }
        private void astonBtn_Click(object sender, EventArgs e)
        {
            mercedesBtn.Visible = false;
            alfaBtn.Visible = false;
            alphaBtn.Visible = false;
            alpineBtn.Visible = false;
            ferrariBtn.Visible = false;
            haasBtn.Visible = false;
            mclarenBtn.Visible = false;
            redbullBtn.Visible = false;
            astonBtn.Visible = false;
            williamsBtn.Visible = false;

            teamDataGridView.Visible = true;
            teamDataGridView.DataSource = GetFormulaList("Aston");

            driver1Pb.Visible = true;
            driver2Pb.Visible = true;
            carPb.Visible = true;
            driver1Pb.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/Drivers/lance stroll.jpg");
            driver2Pb.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/Drivers/sebastian vettel.jpg");
            carPb.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/astonCar.jpg");

            kryptonButton11.Visible = true;
        }

        private void teamDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = teamDataGridView.Rows[e.RowIndex];

                infoText.Text = "Point:" + row.Cells["FirstPoints"].Value.ToString() + "\n" + "Position:" + row.Cells["FirstPosition"].Value.ToString();
                infoText2.Text = "Point:" + row.Cells["SecondPoints"].Value.ToString() + "\n" + "Position:" + row.Cells["SecondPosition"].Value.ToString();

                infoText2.Visible = true;
                infoText.Visible = true;
            }
        }


        private void leftBtn_Click(object sender, EventArgs e)
        {
            Pb1.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/Drivers/leclercPng.png");
            Pb2.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/Drivers/verstappenPng.png");
            Pb3.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/Drivers/perezPng.png");
            Pb4.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/Drivers/russellPng.png");
            Pb5.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/Drivers/sainzPng.png");
            Pb6.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/Drivers/norrisPng.png");
            Pb7.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/Drivers/hamiltonPng.png");
            Pb8.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/Drivers/bottasPng.png");
            Pb9.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/Drivers/oconPng.png");
            Pb10.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/Drivers/magnussenPng.png");

            leftBtn.Visible = false;
            rightBtn.Visible = true;

            pb1Label.Text = "1) Charles Leclerc\t86PTS";
            pb2Label.Text = "2) Max Verstappen\t59PTS";
            pb3Label.Text = "3) Sergio Perez\t54PTS";
            pb4Label.Text = "4) George Russell\t49PTS";
            pb5Label.Text = "5) Carlos Sainz\t38PTS";
            pb6Label.Text = "6) Lando Norris\t35PTS";
            pb7Label.Text = "7) Lewis Hamilton\t28PTS";
            pb8Label.Text = "8) Valtteri Bottas\t24PTS";
            pb9Label.Text = "9) Esteban Ocon\t20PTS";
            pb10Label.Text = "10) Kevin Magnussen\t15PTS";

            nat1.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/Nationalities/poland.jpg");
            nat2.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/Nationalities/netherland.jpg");
            nat3.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/Nationalities/mexico.jpg");
            nat4.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/Nationalities/gb.jpg");
            nat5.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/Nationalities/spain.jpg");
            nat6.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/Nationalities/gb.jpg");
            nat7.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/Nationalities/gb.jpg");
            nat8.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/Nationalities/finland.jpg");
            nat9.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/Nationalities/france.jpg");
            nat10.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/Nationalities/denmark.jpg");
        }

        private void kryptonButton11_Click(object sender, EventArgs e)
        {
            mercedesBtn.Visible = true;
            alfaBtn.Visible = true;
            alphaBtn.Visible = true;
            alpineBtn.Visible = true;
            ferrariBtn.Visible = true;
            haasBtn.Visible = true;
            mclarenBtn.Visible = true;
            redbullBtn.Visible = true;
            redbullBtn.Visible = true;
            astonBtn.Visible = true;
            williamsBtn.Visible = true;

            teamDataGridView.Visible = false;

            driver2Pb.Visible = false;
            driver1Pb.Visible = false;
            carPb.Visible = false;
            infoText.Visible = false;
            infoText2.Visible = false;

            kryptonButton11.Visible = false;
        }

        private void rightBtn_Click(object sender, EventArgs e)
        {
            Pb1.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/Drivers/ricciardoPng.png");
            Pb2.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/Drivers/tsunodaPng.png");
            Pb3.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/Drivers/gaslyPng.png");
            Pb4.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/Drivers/vettelPng.png");
            Pb5.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/Drivers/alonsoPng.png");
            Pb6.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/Drivers/guanyuPng.png");
            Pb7.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/Drivers/albonPng.png");
            Pb8.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/Drivers/strollPng.png");
            Pb9.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/Drivers/schumacherPng.png");
            Pb10.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/Drivers/latifiPng.png");

            rightBtn.Visible = false;
            leftBtn.Visible = true;

            pb1Label.Text = "11) Daniel Ricciardo\t11PTS";
            pb2Label.Text = "12) Yuki Tsunoda\t10PTS";
            pb3Label.Text = "13) Pierre Gasly\t6PTS";
            pb4Label.Text = "14) Sebastian Vettel\t4PTS";
            pb5Label.Text = "15) Fernando Alonso\t2PTS";
            pb6Label.Text = "16) Zhou Guanyu\t1PTS";
            pb7Label.Text = "17) Alexander Albon\t1PTS";
            pb8Label.Text = "18) Lance Stroll\t1PTS";
            pb9Label.Text = "19) Mick Schumacher\t0PTS";
            pb10Label.Text = "20) Nicholas Latifi\t0PTS";

            nat1.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/Nationalities/australia.jpg");
            nat2.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/Nationalities/japan.jpg");
            nat3.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/Nationalities/france.jpg");
            nat4.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/Nationalities/germany.jpg");
            nat5.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/Nationalities/spain.jpg");
            nat6.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/Nationalities/china.jpg");
            nat7.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/Nationalities/thailand.jpg");
            nat8.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/Nationalities/canada.jpg");
            nat9.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/Nationalities/germany.jpg");
            nat10.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/Nationalities/canada.jpg");
        }

        private void rightArrow_Click(object sender, EventArgs e)
        {
            rightArrow.Visible = false;
            leftArrow.Visible = true;

            gp1.Text = "Italy";
            gp2.Text = "Singapore";
            gp3.Text = "Japan";
            gp4.Text = "United States";
            gp5.Text = "Mexico";
            gp7.Text = "Brazil";
            gp9.Text = "Abu Dhabi";
            gp6.Visible = false;
            gp8.Visible = false;
            gp10.Visible = false;
            gp11.Visible = false;
            gp12.Visible = false;
            gp13.Visible = false;
            gp14.Visible = false;
            gp15.Visible = false;

            gpPicture6.Visible = false;
            gpPicture8.Visible = false;
            gpPicture10.Visible = false;
            gpPicture11.Visible = false;
            gpPicture12.Visible = false;
            gpPicture13.Visible = false;
            gpPicture14.Visible = false;
            gpPicture15.Visible = false;
            gpPicture1.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/GrandPrixes/italy.jpg");
            gpPicture2.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/GrandPrixes/singapore.jpg");
            gpPicture3.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/GrandPrixes/japan.jpg");
            gpPicture4.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/GrandPrixes/united states.jpg");
            gpPicture5.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/GrandPrixes/mexico.jpg");
            gpPicture7.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/GrandPrixes/brazil.jpg");
            gpPicture9.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/GrandPrixes/abu dhabi.jpg");
        }

        private void leftArrow_Click(object sender, EventArgs e)
        {
            leftArrow.Visible = false;
            rightArrow.Visible = true;
            gpPicture6.Visible = true;
            gpPicture8.Visible = true;
            gpPicture10.Visible = true;
            gpPicture11.Visible = true;
            gpPicture12.Visible = true;
            gpPicture13.Visible = true;
            gpPicture14.Visible = true;
            gpPicture15.Visible = true;
            gp6.Visible = true;
            gp8.Visible = true;
            gp10.Visible = true;
            gp11.Visible = true;
            gp12.Visible = true;
            gp13.Visible = true;
            gp14.Visible = true;
            gp15.Visible = true;

            gp1.Text = "Bahrein";
            gp2.Text = "Saudi Arabia";
            gp3.Text = "Australia";
            gp4.Text = "Emelia";
            gp5.Text = "Miami";
            gp7.Text = "Monaco";
            gp9.Text = "Canada";

            gpPicture1.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/GrandPrixes/bahrein.jpg");
            gpPicture2.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/GrandPrixes/saudi.jpg");
            gpPicture3.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/GrandPrixes/australia.jpg");
            gpPicture4.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/GrandPrixes/emelia.jpg");
            gpPicture5.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/GrandPrixes/america.jpg");
            gpPicture7.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/GrandPrixes/monaco.jpg");
            gpPicture9.BackgroundImage = Image.FromFile("C:/Users/bangf/source/repos/Formula1/Images/GrandPrixes/canada.jpg");
        }

        private void kryptonLinkLabel1_LinkClicked(object sender, EventArgs e)
        {
            try
            {
                GoLink();
            }
            catch(Exception exeption)
            {
                MessageBox.Show("Somethings went wrong...");
            }
        }
        private void GoLink()
        {
            kryptonLinkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.formula1.com/");
        }
        
    }
}
