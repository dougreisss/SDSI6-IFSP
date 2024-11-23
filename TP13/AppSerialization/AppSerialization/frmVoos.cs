using AppSerialization.Model;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace AppSerialization
{
    public partial class frmVoos : Form
    {
        public frmVoos()
        {
            InitializeComponent();
        }

        private void btnSerializarBinario_Click(object sender, EventArgs e)
        {
            try
            {
                List<Voo> lstVoos = new List<Voo>()
                {
                    new Voo("VG456", "CGH", "POA", new DateTime(2024, 11, 23, 14, 35, 0), "Varig", 'T'),
                    new Voo("AZ002", "VCP", "SSA", new DateTime(2024, 11, 23, 18, 00, 0), "Azul", 'F'),
                    new Voo("VG455", "SDU", "SSA", new DateTime(2024, 11, 23, 15, 00, 0), "Varig", 'T'),
                    new Voo("JG013", "POA", "VCP", new DateTime(2024, 11, 23, 12, 10, 0), "TAM", 'T'),
                    new Voo("GG123", "CGH", "FLN", new DateTime(2024, 11, 23, 06, 00, 0), "Gol", 'F'),
                    new Voo("AZ012", "VCP", "SDU", new DateTime(2024, 11, 23, 14, 00, 0), "Azul", 'T')
                };

                string path = Path.Combine(Directory.GetCurrentDirectory(), "ArquivosTeste", "Voo.bin");

                FileStream fs = new FileStream(path, FileMode.Create);

                #pragma warning disable SYSLIB0011
                BinaryFormatter bf = new BinaryFormatter();

                bf.Serialize(fs, lstVoos);

                fs.Close();

                MessageBox.Show("Arquivo binário criado com sucesso!");
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu erro na criação do arquivo binário.");
                throw;
            }
        }

        private void btnDesserializarBinario_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";

            string path = Path.Combine(Directory.GetCurrentDirectory(), "ArquivosTeste", "Voo.bin");

            FileInfo file = new FileInfo(path);

            if (file.Exists)
            {
                FileStream fs = new FileStream(path, FileMode.Open);

                BinaryFormatter bf = new BinaryFormatter();

                List<Voo> lstVoos = (List<Voo>)bf.Deserialize(fs);

                fs.Close();

                txtResultado.Text += "Resultado Binário: ";
                txtResultado.Text += Environment.NewLine;
                txtResultado.Text += string.Join(Environment.NewLine, lstVoos.Select(x => x.ToString()));
            }
            else
            {
                txtResultado.Text = "Arquivo inexistente.";
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
        }

        private void btnSerializarXML_Click(object sender, EventArgs e)
        {
            try
            {
                List<Voo> lstVoos = new List<Voo>()
                {
                    new Voo("VG456", "CGH", "POA", new DateTime(2024, 11, 23, 14, 35, 0), "Varig", 'T'),
                    new Voo("AZ002", "VCP", "SSA", new DateTime(2024, 11, 23, 18, 00, 0), "Azul", 'F'),
                    new Voo("VG455", "SDU", "SSA", new DateTime(2024, 11, 23, 15, 00, 0), "Varig", 'T'),
                    new Voo("JG013", "POA", "VCP", new DateTime(2024, 11, 23, 12, 10, 0), "TAM", 'T'),
                    new Voo("GG123", "CGH", "FLN", new DateTime(2024, 11, 23, 06, 00, 0), "Gol", 'F'),
                    new Voo("AZ012", "VCP", "SDU", new DateTime(2024, 11, 23, 14, 00, 0), "Azul", 'T')
                };

                string path = Path.Combine(Directory.GetCurrentDirectory(), "ArquivosTeste", "Voo.xml");

                FileStream fs = new FileStream(path, FileMode.Create);

                XmlSerializer xs = new XmlSerializer(typeof(List<Voo>));
                xs.Serialize(fs, lstVoos);
                fs.Close();

                MessageBox.Show("Arquivo XML criado com sucesso!");
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro na criação do arquivo XML.");
                throw;
            }
          
        }

        private void btnDesserializarXml_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "ArquivosTeste", "Voo.xml");

            txtResultado.Text = "";

            FileInfo fi = new FileInfo(path);

            if (fi.Exists)
            {
                FileStream fs = new FileStream(path, FileMode.Open);
                XmlSerializer xs = new XmlSerializer(typeof(List<Voo>));

                List<Voo> lstVoos = (List<Voo>)xs.Deserialize(fs);

                fs.Close();

                txtResultado.Text += "Resultado XML: ";
                txtResultado.Text += Environment.NewLine;
                txtResultado.Text += string.Join(Environment.NewLine, lstVoos.Select(x => x.ToString()));
            }
            else 
            {
                txtResultado.Text = "Arquivo inexistente.";
            }
        }
    }
}
