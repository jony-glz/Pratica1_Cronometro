namespace Pratica1_Cronometro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // variables para guardar el tiempo en cada unidad (h,m,s)
        int segs = 0, mins = 0, hrs = 0;

        private void tmpCronometro_Tick(object sender, EventArgs e)
        {
            // incrementa los segundos
            segs++;

            // incrementa las horas y minutos conforme aumentan los segundos
            if (segs == 60)
            {
                mins++;
                segs = 0;
            }
            if (mins == 60)
            {
                hrs++;
                mins = 0;
            }

            // devuelve el cronometro completamente funcional
            lbTemporizador.Text = hrs.ToString("00") + ":" + mins.ToString("00") + ":" + segs.ToString("00");
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            tmpCronometro.Enabled = true;
        }

        private void btnPausa_Click(object sender, EventArgs e)
        {
            //tmpCronometro.Enabled = false;
            tmpCronometro.Enabled=false;
        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            lbTemporizador.Text = "00:00:00";
            segs = 0;
            mins = 0;
            hrs = 0;
            tmpCronometro.Enabled = true;
        }
    }
}
