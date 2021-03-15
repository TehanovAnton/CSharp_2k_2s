using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace LabWork2_elementyUprvlenia
{
    public partial class Discipline : Form
    {
        private SaveJson fields;
        private Lector lector;
        private Action<KeyPressEventArgs> AddLetter = (e) =>
        {
            char entered = e.KeyChar;
            if (Char.IsLetter(entered) || Char.IsControl(entered))
                e.Handled = false;
            else
                e.Handled = true;
        };
        private Func<Discipline, bool> CheckDiscipline = (discipline) =>
        {
            bool semestr = false;
            bool curs = false;
            bool knowlegControl = false;
            foreach (RadioButton radioButton in discipline.curs.Controls)
                curs |= radioButton.Checked;

            foreach (RadioButton radioButton in discipline.groupBox2.Controls)
                semestr |= radioButton.Checked;

            foreach (RadioButton radioButton in discipline.groupBox3.Controls)
                knowlegControl |= radioButton.Checked;

            return discipline.disciplineName.Text != null &&
            discipline.lecNumber.Text != null &&
            discipline.labNumber.Text != null &&
            semestr && curs && knowlegControl;
        };
        private void Save()
        {
            fields = new SaveJson();
            fields.disicplineName = disciplineName.Text;
            fields.lecNumber = lecNumber.Text;
            fields.labNumber = labNumber.Text;
            fields.curs = firstCurs.Checked ? "курс: 1" : "курс: 2";
            fields.semestr = firstSemestr.Checked ? "семестр: 1" : "семестр: 2";
            fields.knowledgeControl = akzamen.Checked ? "экзамен" : "зачёт";

            lector.GetFieldsObjFromDiscipline(ref fields);
        }
        private void ShowSaved(SaveJson saved)
        {
            ShowWin.Text = string.Format("наз. дисциплины: {0}\r\n" +
                    "кол. лаб: {1}\r\n" +
                    "кол. лекций: {2}\r\n" +
                    "{3}\r\n" +
                    "{4}\r\n" +
                    "контроль знаний: {5}\r\n" +
                    "фио: {6}\r\n" +
                    "кафедра: {7}\r\n" +
                    "аудитория: {8}",
                    saved.disicplineName, saved.labNumber, saved.lecNumber, saved.curs, saved.semestr, saved.knowledgeControl, saved.fio, saved.cafedra, saved.audienceNumber);
        }        

        public Discipline()
        {
            InitializeComponent();
            lector = new Lector();
        }

        private void Discipline_Load(object sender, EventArgs e)
        {

        }

        private void LectorButton(object sender, EventArgs e)
        {
            if (CheckDiscipline(this))
            {
                Save();
                textBox2.Text = "сохранено";
                this.Hide();
                lector.discipline = this;
                lector.Show();
            }
            else
                textBox2.Text = "данные не введены";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            AddLetter(e);
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void ShowSavedButton_Click(object sender, EventArgs e)
        {
            SaveJson saved = new SaveJson();
            using(StreamReader reader = new StreamReader(SaveJson.filePath))
            {
                saved = JsonConvert.DeserializeObject<SaveJson>(reader.ReadToEnd());
            }

            ShowSaved(saved);
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
