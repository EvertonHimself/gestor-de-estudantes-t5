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
    public partial class FormInserirEstudante : Form
    {
        public FormInserirEstudante()
        {
            InitializeComponent();
        }

        private void buttonEnviarFoto_Click(object sender, EventArgs e)
        {
            // Cria uma caixa de diálogo para enviar a foto do aluno.
            OpenFileDialog inserirFoto = new OpenFileDialog();
            // Filtrar os tipos de arquivo que podem ser enviados.
            inserirFoto.Filter = "Selecionar Imagem(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif;";
            if (inserirFoto.ShowDialog() == DialogResult.OK)
            {
                pictureBoxFoto.Image = Image.FromFile(inserirFoto.FileName);
            }
        }
    }
}
