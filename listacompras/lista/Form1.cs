namespace lista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            listboxcomanda.Items.Clear();
            double total = 0;


            if (btnpequeno.Checked)
            {
                listboxcomanda.Items.Add("Açaí Pequeno - R$12,90");
                total += 12.90;
            }
            else if (btnmedio.Checked)
            {
                listboxcomanda.Items.Add("Açaí Médio - R$15,90");
                total += 15.90;
            }
            else if (btngrande.Checked)
            {
                listboxcomanda.Items.Add("Açaí Grande - R$17,90");
                total += 17.90;
            }


            if (btnmorangofruta.Checked)
            {
                listboxcomanda.Items.Add("Morango - R$4,90");
                total += 4.90;
            }
            if (btnkiwi.Checked)
            {
                listboxcomanda.Items.Add("Kiwi - R$4,90");
                total += 4.90;
            }
            if (btncremeavela.Checked)
            {
                listboxcomanda.Items.Add("Creme de Avelã - R$5,90");
                total += 5.90;
            }
            if (btncastanhas.Checked)
            {
                listboxcomanda.Items.Add("Castanhas - R$5,90");
                total += 5.90;
            }
            if (btncerejas.Checked)
            {
                listboxcomanda.Items.Add("Cerejas - R$6,90");
                total += 6.90;
            }
            if (btnextrachoco.Checked)
            {
                listboxcomanda.Items.Add("Chocolates - R$6,90");
                total += 6.90;
            }
            if (btnchantilly.Checked)
            {
                listboxcomanda.Items.Add("Chantilly - R$6,90");
                total += 6.90;
            }
            if (btnsorvete.Checked)
            {
                listboxcomanda.Items.Add("Sorvete - R$6,90");
                total += 6.90;
            }


            if (btnbanana.Checked) listboxcomanda.Items.Add("Banana");
            if (btnpacoca.Checked) listboxcomanda.Items.Add("Paçoca");
            if (btngranola.Checked) listboxcomanda.Items.Add("Granola");
            if (btnleite.Checked) listboxcomanda.Items.Add("Leite Condensado");
            if (btnleitepo.Checked) listboxcomanda.Items.Add("Leite em Pó");
            if (btnchoco.Checked) listboxcomanda.Items.Add("Cobertura de Chocolate");
            if (btnmorango.Checked) listboxcomanda.Items.Add("Cobertura de Morango");
            if (btnconfetes.Checked) listboxcomanda.Items.Add("Confetes");
            if (btnovomaltine.Checked) listboxcomanda.Items.Add("Ovomaltine");
            if (btndoceleite.Checked) listboxcomanda.Items.Add("Doce de Leite");


            txtboxtotal.Text = total.ToString("C2");
        }
    }
}