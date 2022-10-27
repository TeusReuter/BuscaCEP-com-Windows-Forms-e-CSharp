using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_BuscaCep
{
    public partial class BuscaCep : Form
    {
        public BuscaCep()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var ws = new WSCorreios.AtendeClienteClient())
                {
                    var resultado = ws.consultaCEP(TextBoxCep.Text);
                    TextBoxEndereco.Text = resultado.end;
                    TextBoxComplemento.Text = resultado.complemento2;
                    TextBoxCidade.Text = resultado.cidade;
                    TextBoxBairro.Text = resultado.bairro;
                    TextBoxEstado.Text = resultado.uf;
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
