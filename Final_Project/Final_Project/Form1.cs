using System;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Final_Project
{
    public partial class Form1 : Form
    {
        Planet planets = new Planet();
        Spaceship spaceship = new Spaceship();
        public Form1()
        {
            InitializeComponent();
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
             1.เลือกฟังก์ชัน OpenFileDialog มาใช้และตั้งค่าให้กรองไฟล์เป็น .csv
             2.อ่านข้อมูลทั้งหมดจากไฟล์ที่เลือกมา
             3.แยกข้อมูลแต่ละแถวด้วยเครื่องหมายจุลภาค
             4.วนลูปผ่านข้อมูลแต่ละแถวเพื่อเพิ่มข้อมูลแต่ละแถวลงในตาราง dataGridView1
             5.แสดงข้อมูลในตาราง dataGridView1

             โค้ดนี้สามารถเปิดไฟล์ .csv และแสดงข้อมูลในตาราง dataGridView1 ได้
             */
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV (*.csv) | *.csv";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] readAllLine = File.ReadAllLines(openFileDialog.FileName);

                string readAllText = File.ReadAllText(openFileDialog.FileName);
                for (int i = 0; i < readAllLine.Length; i++)
                {
                    string allDATARAW = readAllLine[i];
                    string[] allDATASplited = allDATARAW.Split(',');
                    this.dataGridView1.Rows.Add(allDATASplited[0], allDATASplited[1], allDATASplited[2], allDATASplited[3], allDATASplited[4], allDATASplited[5], allDATASplited[6]);
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
             1.ตรวจสอบว่ามีข้อมูลในตาราง dataGridView1 หรือไม่ ถ้าไม่มีข้อมูลฟังก์ชันจะไม่ทำงาน
             2.เลือกฟังก์ชัน SaveFileDialog มาใช้ และตั้งค่าให้กรองเอาไฟล์เป็น .csv
             3.สร้างตัวแปร column เก็บชื่อคอลัมน์ทั้งหมดในตาราง
             4.สร้างตัว outputCSV เพื่อเก็บข้อมูลทั้งหมดในตาราง
             5.วนลูปแต่ละแถวในตารางเพื่อเพิ่มข้อมูลในแต่ละแถวลงใน outputCSV
             6.บันทึกข้อมูลใน outputCSV ไปยังไฟล์ .csv

             โค้ดนี้สามารถบันทึกข้อมูลในตาราง dataGridView1 ไปเป็นไฟล์ .csv ได้
            */
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "CSV(*.csv)|*.csv";
                bool fileError = false;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (!fileError)
                    {
                        try
                        {
                            int columnCount = dataGridView1.Columns.Count;
                            string column = "";
                            string[] outputCSV = new string[dataGridView1.Rows.Count + 1];
                            for (int i = 0; i < columnCount; i++)
                            {
                                column += dataGridView1.Columns[i].HeaderText.ToString() + ",";
                            }
                            outputCSV[0] += column;
                            for (int i = 1; (i - 1) < dataGridView1.Rows.Count; i++)
                            {
                                for (int j = 0; j < columnCount; j++)
                                {
                                    outputCSV[i] += dataGridView1.Rows[i - 1].Cells[j].Value.ToString() + ",";
                                }
                            }
                            File.WriteAllLines(saveFileDialog.FileName, outputCSV, Encoding.UTF8);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CalPrice calculatePrice = new CalPrice();
            // ดึงข้อมูลจาก comboBox
            string spaceship = shipcomboBox.SelectedItem.ToString();
            string planet = PlanetcomboBox.SelectedItem.ToString();

            // เรียกใช้ method CalculateTotalPrice
            double totalPrice = calculatePrice.CalculateTotalPrice(spaceship, planet);

            TotalPricetextBox.Text = totalPrice.ToString("C");
            //ตัวอักษร C ใน totalPrice.ToString("C") (currency) ใส่เพื่อ format ตัวเลขให้เป็นรูปแบบสกุลเงิน
        }
        private void Savebutton_Click(object sender, EventArgs e)
        {

            string name = NametextBox.Text;
            int Phonenumber = Convert.ToInt32(phonetextBox.Text);
            long Idcard = long.Parse(IDtextBox.Text);
            string type = shipcomboBox.Text;
            string planet = PlanetcomboBox.Text;
            string Date = dateTimePicker1.Text;
            string TotalPrice = TotalPricetextBox.Text;


            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = name;
            dataGridView1.Rows[n].Cells[1].Value = Phonenumber;
            dataGridView1.Rows[n].Cells[2].Value = Idcard;
            dataGridView1.Rows[n].Cells[3].Value = type;
            dataGridView1.Rows[n].Cells[4].Value = planet;
            dataGridView1.Rows[n].Cells[5].Value = Date;
            dataGridView1.Rows[n].Cells[6].Value = TotalPrice;

            if (type == "Skywalker_OG")
            {
                string type1 = spaceship.getSky();
                dataGridView1.Rows[n].Cells[3].Value = type1;

            }
            else if (type == "Ghost_Train_Haze")
            {
                string type2 = spaceship.getGhost();
                dataGridView1.Rows[n].Cells[3].Value = type2;
            }
            else if (type == "Blue_Dream")
            {
                string type3 = spaceship.getBlue();
                dataGridView1.Rows[n].Cells[3].Value = type3;
            }
            else if (type == "Candy_Kush_Express")
            {
                string type4 = spaceship.getCandy();
                dataGridView1.Rows[n].Cells[3].Value = type4;
            }


            if (planet == "Matar_Bay")
            {
                string planet1 = planets.getMatar_Bay();
                dataGridView1.Rows[n].Cells[4].Value = planet1;
            }
            else if (planet == "Alathfar_XI")
            {
                string planet2 = planets.getalathfar_XI();
                dataGridView1.Rows[n].Cells[4].Value = planet2;
            }
            else if (planet == "Charon_Prime")
            {
                string planet3 = planets.getCharon_Prime();
                dataGridView1.Rows[n].Cells[4].Value = planet3;
            }
            else if (planet == "Asperoth_Prime")
            {
                string planet4 = planets.getasproth_prime();
                dataGridView1.Rows[n].Cells[4].Value = planet4;
            }
            else if (planet == "Bore_Rock")
            {
                string planet5 = planets.getBore_Rock();
                dataGridView1.Rows[n].Cells[4].Value = planet5;
            }
            else if (planet == "Pathfinder_V")
            {
                string planet6 = planets.getpathfinder_V();
                dataGridView1.Rows[n].Cells[4].Value = planet6;
            }
            else if (planet == "Klen_Dahth_II")
            {
                string planet7 = planets.getklen_dahth_II();
                dataGridView1.Rows[n].Cells[4].Value = planet7;
            }
            else if (planet == "Widows_Harbor")
            {
                string planet8 = planets.getwindows_harbor();
                dataGridView1.Rows[n].Cells[4].Value = planet8;
            }
            else if (planet == "New_Haven")
            {
                string planet9 = planets.getnew_haven();
                dataGridView1.Rows[n].Cells[4].Value = planet9;
            }
            else if (planet == "Pilen_V")
            {
                string planet10 = planets.getpilen_V();
                dataGridView1.Rows[n].Cells[4].Value = planet10;
            }



            shipcomboBox.Text = null;
            PlanetcomboBox.Text = null;
            NametextBox.Text = "";
            phonetextBox.Text = "";
            IDtextBox.Text = "";
            TotalPricetextBox.Text = "";
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(rowIndex);
        }

        
    }
}
