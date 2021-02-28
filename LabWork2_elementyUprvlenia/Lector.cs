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
    public partial class Lector : Form
    {
        public Discipline discipline;
        private SaveJson fields;
        private Action<KeyPressEventArgs> AddLetter = (e) =>
        {
            char entered = e.KeyChar;
            if (Char.IsLetter(entered) || Char.IsControl(entered) || Char.IsPunctuation(entered) || Char.IsWhiteSpace(entered))
                e.Handled = false;
            else
                e.Handled = true;
        };
        private Func<Lector, bool> CheckLector = (lector) =>
        {
            return lector.fio.Text != null && lector.cafedra.SelectedItem != null &&
            lector.audienceNumber.Text != null;
        };
        public void GetFieldsObjFromDiscipline(ref SaveJson pfields)
        {
            fields = pfields;
        }
        public void Save()
        {
            fields.cafedra = cafedra.Text;
            fields.fio = fio.Text;
            fields.audienceNumber = audienceNumber.Text;

            using (StreamWriter stream = new StreamWriter(SaveJson.filePath))
            {
                stream.Write(JsonConvert.SerializeObject(fields));
            }
        }
        private void Clear()
        {
            fio.Text = audienceNumber.Text = null;
            cafedra.SelectedItem = null;
        }

        public Lector()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            AddLetter(e);            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void SaveButton(object sender, EventArgs e)
        {
            if (CheckLector(this))
            {
                Save();
                Clear();
                textBox2.Text = "сохранено";
            }
            else
                textBox2.Text = "данные не введены";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Lector_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BackToDiscipline_Click(object sender, EventArgs e)
        {
            this.Hide();
            discipline.Show();
        }
    }
}
