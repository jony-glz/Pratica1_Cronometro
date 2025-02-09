namespace Pratica1_Cronometro
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lbTemporizador = new Label();
            tmpCronometro = new System.Windows.Forms.Timer(components);
            btnIniciar = new Button();
            btnPausa = new Button();
            btnRestablecer = new Button();
            SuspendLayout();
            // 
            // lbTemporizador
            // 
            lbTemporizador.AutoSize = true;
            lbTemporizador.Font = new Font("Consolas", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTemporizador.Location = new Point(127, 59);
            lbTemporizador.Name = "lbTemporizador";
            lbTemporizador.Size = new Size(702, 168);
            lbTemporizador.TabIndex = 0;
            lbTemporizador.Text = "00:00:00";
            // 
            // tmpCronometro
            // 
            tmpCronometro.Interval = 1000;
            tmpCronometro.Tick += tmpCronometro_Tick;
            // 
            // btnIniciar
            // 
            btnIniciar.Font = new Font("Arial Rounded MT Bold", 10F);
            btnIniciar.Image = (Image)resources.GetObject("btnIniciar.Image");
            btnIniciar.Location = new Point(12, 332);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(128, 103);
            btnIniciar.TabIndex = 1;
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnPausa
            // 
            btnPausa.Font = new Font("Arial Rounded MT Bold", 10F);
            btnPausa.Image = (Image)resources.GetObject("btnPausa.Image");
            btnPausa.Location = new Point(220, 332);
            btnPausa.Name = "btnPausa";
            btnPausa.Size = new Size(128, 103);
            btnPausa.TabIndex = 2;
            btnPausa.UseVisualStyleBackColor = true;
            btnPausa.Click += btnPausa_Click;
            // 
            // btnRestablecer
            // 
            btnRestablecer.Font = new Font("Arial Rounded MT Bold", 10F);
            btnRestablecer.Image = (Image)resources.GetObject("btnRestablecer.Image");
            btnRestablecer.Location = new Point(760, 332);
            btnRestablecer.Name = "btnRestablecer";
            btnRestablecer.Size = new Size(128, 103);
            btnRestablecer.TabIndex = 3;
            btnRestablecer.UseVisualStyleBackColor = true;
            btnRestablecer.Click += btnRestablecer_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(991, 548);
            Controls.Add(btnRestablecer);
            Controls.Add(btnPausa);
            Controls.Add(btnIniciar);
            Controls.Add(lbTemporizador);
            Name = "Form1";
            Text = "Cronómetro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTemporizador;
        private System.Windows.Forms.Timer tmpCronometro;
        private Button btnIniciar;
        private Button btnPausa;
        private Button btnRestablecer;
    }
}
