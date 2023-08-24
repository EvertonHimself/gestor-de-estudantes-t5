using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student_manager
{
    public partial class FormListarEstudantes : Form
    {
        public FormListarEstudantes()
        {
            InitializeComponent();
        }

        // Instanciação de uma classe, ou seja, criação de um objeto.
        Estudante estudante = new Estudante();

        private void FormListarEstudantes_Load(object sender, EventArgs e)
        {
            // Preencher a tabela com os dados dos estudantes.
            MySqlCommand comando = new MySqlCommand("SELECT * FROM `estudantes`");
            dataGridViewLista.ReadOnly = true;
            DataGridViewImageColumn colunaDeImagens = new DataGridViewImageColumn();
            dataGridViewLista.RowTemplate.Height = 80;
            dataGridViewLista.DataSource = estudante.pegarEstudantes(comando);
            colunaDeImagens = (DataGridViewImageColumn)dataGridViewLista.Columns[7];
            colunaDeImagens.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridViewLista.AllowUserToAddRows = false;
        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            // Atualiza a tabela de estudantes.
        }

        private void dataGridViewLista_DoubleClick(object sender, EventArgs e)
        {
            // Abre o estudante selecionado em uma nova janela.
        }
    }
}
