namespace ConsultarCEPs
{
    public partial class FrmConsultarCeps : Form
    {
        public FrmConsultarCeps()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //sair
            this.Close();
        }

        private async void btnConsultar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCEP.Text))
            {
                using (var ws = new ServiceReference1.AtendeClienteClient())
                {
                    try
                    {              
                       
                        var endereco = await ws.consultaCEPAsync(txtCEP.Text.Trim());
                        //pode ter erro aqui

                        txtEstado.Text = endereco.@return.uf;
                        txtCidade.Text = endereco.@return.cidade;
                        txtBairro.Text = endereco.@return.bairro;
                        txtRua.Text = endereco.@return.end;


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            else 
            {
                MessageBox.Show("Informe um CEP válido...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

            txtCEP.Text = string.Empty;
            txtEstado.Text = string.Empty;
            txtCidade.Text = string.Empty;
            txtBairro.Text = string.Empty;
            txtRua.Text = string.Empty;

        }
    }
}
