namespace Exercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ReordenaLista()
        {
            this.txtInicial.Text = String.Empty;
            this.txtInvertida.Text = String.Empty;

            int[] array = new int[Convert.ToInt32(txtQuantidade.Text)];

            for (int i = 0; i < array.Length; i++)
            {
                Random rnd = new();
                array[i] = rnd.Next(100);
            }

            for (int i = 0; i < array.Length; i++)
            {
                this.txtInicial.Text += array[i].ToString() + ", ";
            }

            for (int i = array.Length - 1; i >= 0; i--)
            {
                this.txtInvertida.Text += array[i].ToString() + ", ";
            }
        }

        private bool ValidaCampos()
        {
            if (Convert.ToInt32(this.txtQuantidade.Text) <= 1)
            {
                MessageBox.Show("Defina um valor maior que 1 para o array", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }
        private void btnGerarLista_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidaCampos())
                {
                    this.ReordenaLista();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}