using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parte1
{
    /*Gabriel Gonçalves de Lima F058BC-4
     * Guilherme  de Jesus Teixeira D93DH-9
     * Vitória da Silva  N41412-0
     */
    public partial class Form1 : Form
    {
        List<Pessoa> pessoas;
        public Form1()
        {
            // ESTES ELEMENTOS ESSTÃO PRESENTES NO COMBOBOX RESPONSÁVEL PELO O ESTADO CIVIL DO USUÁRIO
            InitializeComponent();
            pessoas = new List<Pessoa>();

            ComboEC.Items.Add("Casado");
            ComboEC.Items.Add("Solteiro");
            ComboEC.Items.Add("Viúvo");
            ComboEC.Items.Add("Divorciado");

            ComboEC.SelectedIndex = 0;


        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
        /* O METODO CADASTRAR BTN TEM COMO FUNÇAO O PROCESSO DE COLOETAR E VERIFICAR OS DADOS DO CLIENTE
         */
        private void CadastrarBTN_Click(object sender, EventArgs e)
        {
            int index = -1;
            foreach(Pessoa pessoa in pessoas)
            {
                if (pessoa.Nome == txtNome.Text)
                {
                    index = pessoas.IndexOf(pessoa);
                }
            }
            if (txtNome.Text == "") 
            {
                MessageBox.Show("Preencha o campo nome.");
                txtNome.Focus();
                return;
            }
            if (txttelefone.Text == "(  )     -") 
            {
                MessageBox.Show("Preencha o campo telefone.");
                txtNome.Focus();
                return;
            }
            if (txtcpf.Text == "   ,   ,   /")
            {
                MessageBox.Show("Preencha o campo CPF.");
                txtNome.Focus();
                return;

            }

     

            char sexo;
            if (radioM.Checked)
            {
                sexo = 'M';

            }
            else if (radioF.Checked)
            {
                sexo = 'F';
            }
            else
            {
                sexo = 'O';
            }
            /* é utilizada a classe pessoa para a implementação dos daods
             */
            Pessoa p = new Pessoa();
            p.Nome = txtNome.Text;
            p.DataNascimento = txtData.Text;
            p.EstadoCIvil = ComboEC.SelectedItem.ToString();
            p.Telefone = txttelefone.Text;
            p.CPF = txtcpf.Text;
            p.CasaPropria = checkcasa.Checked;
            p.Veiculo = checkcarro.Checked;
            p.Sexo = sexo;
            p.Quartos = comboQuarto.SelectedItem.ToString();
            p.CheckIN = DataCheckIn.Text;
            p.CheckOUT = DataCheckOut.Text;
           

            if (index < 0)
            {
                pessoas.Add(p);
            }
            else
            {
                pessoas[index] = p;
            }

            LimparBTN_Click( LimparBTN , EventArgs.Empty);
            
            Listar();
        }

        private void ExcluirBTN_Click(object sender, EventArgs e)
        {
            //O METODO EXCLUIR REMOVE O INDICE APAGANDO OS DAODS JÁ REGISTRADOS 
            int indice = lista.SelectedIndex;
            pessoas.RemoveAt(indice);
            Listar();
        }

        private void LimparBTN_Click(object sender, EventArgs e)
        {
            // O METODO LIMPAR REALIZA APÓS A EFETUAÇÃO DE UM CADASTRO OU RESERVA //
            txtNome.Text = "";
            txtData.Text = "";
            ComboEC.SelectedIndex = 0;
            txttelefone.Text = "";
            txtcpf.Text = "";
            checkcasa.Checked = false;
            checkcarro.Checked = false;
            radioM.Checked = true;
            radioF.Checked = false;
            radioO.Checked = false;
            comboQuarto.SelectedIndex = 0;
            DataCheckIn.Text = "";
            DataCheckOut.Text = "";
            txtNome.Focus();

          // ATRIBUI AS VARIAVEIS VALORES "VAZIOS"//
        }

        private void Listar()
        {
            lista.Items.Clear();
            foreach(Pessoa p in pessoas)
            {
                lista.Items.Add(p.Nome);
            }
        }

        private void Txttelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Lista_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // A SEGUIR TEM-SE O METODO LISTA QUE ADICIONA OS RESULTADOS DO USUÁRIO E GRAVA TUDO EM UMA LISTA
            int indice = lista.SelectedIndex;
            Pessoa p = pessoas[indice];

            txtNome.Text = p.Nome;
            txtData.Text = p.DataNascimento;
            ComboEC.SelectedItem = p.EstadoCIvil;
            txttelefone.Text = p.Telefone;
            txtcpf.Text = p.CPF;
            checkcasa.Checked = p.CasaPropria;
            checkcarro.Checked = p.Veiculo;
            comboQuarto.SelectedItem = p.Quartos;
            DataCheckIn.Text = p.CheckIN;
            DataCheckOut.Text = p.CheckOUT;
            switch (p.Sexo)
            {
                case 'M':
                    radioM.Checked = true;
                    break;
                case 'F':
                    radioF.Checked = true;
                    break;
                default:
                    break;
                

            }


        }

    

        private void InserirDatas_Click(object sender, EventArgs e)
        {

            DateTime startdate = DataCheckIn.Value;
            DateTime EndDate =   DataCheckOut.Value;
            Qtdias.Text = CalcData(startdate,EndDate).ToString();
          
        }
         public long CalcData( System.DateTime StartDate, System.DateTime EndDate)
        {
            //O METODO A SEGUIR REALIZA UM CALCULO DOS DATETIMESPICKERS E APREANSETA O TOTAL DE DIAS QUE FORAM RESERVADOS PARA A VIAGEM//
            long data = 0;
            System.TimeSpan ts = new TimeSpan(EndDate.Ticks - StartDate.Ticks);
        
            data = (long)(ts.Days);
            

            return data;
        }
      
        private void TxtCPF_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
