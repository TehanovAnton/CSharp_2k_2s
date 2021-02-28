using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;


namespace supportWinFormsProj
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Data data;

        public Form()
        {
            InitializeComponent();
        }

        private void text(object sender, EventArgs e)
        {

        }

        private void Enter_Click(object sender, EventArgs e)
        {
            data = new Data(int.Parse(textBox.Text));

            var results = new List<ValidationResult>();
            var context = new ValidationContext(data);
            if (!Validator.TryValidateObject(data, context, results, true))
            {
                foreach (var err in results)
                    Console.WriteLine(err.ErrorMessage);
            }
        }
    }
    public class Data
    {
        [Required(ErrorMessage = "error")]
        [Range(1,2, ErrorMessage = "piz")]
        public int textInfo { get; set; }

        public Data(int textInfo)
        {
            this.textInfo = textInfo;
        }

        public Data()
        {

        }
    }
}
