using BLL;

namespace ListaTelefonica
{
    public partial class Form1 : Form
    {

        public RepositorioDeTelefones RepositorioDeTelefones { get; set; } = new RepositorioDeTelefones();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            ListagemTelefones listagemTelefones = new ListagemTelefones();

            listagemTelefones.Nome = txtNome.Text;
            listagemTelefones.Telefone = TextBoxTelefone.Text;

            RepositorioDeTelefones.Incluir(listagemTelefones);
            MessageBox.Show("O contato foi incluído com sucesso!");

            txtNome.Text = "";
            TextBoxTelefone.Text = "";
        }



        private void btnListar_Click(object sender, EventArgs e)
        {
            listListaDeTelefone.Items.Clear();
            foreach (var contato in RepositorioDeTelefones.ListagemTelefones)
            {
                listListaDeTelefone.Items.Add(contato);
            }
        }
    }
}