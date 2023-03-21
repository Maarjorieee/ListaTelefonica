namespace ListaTelefonica
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
            this.ImagemLogo = new System.Windows.Forms.PictureBox();
            this.lblAgenda = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.TextBoxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.listListaDeTelefone = new System.Windows.Forms.ListBox();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImagemLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // ImagemLogo
            // 
            this.ImagemLogo.ErrorImage = null;
            this.ImagemLogo.Image = global::ListaTelefonica.Properties.Resources.logoagenda1;
            this.ImagemLogo.Location = new System.Drawing.Point(31, 27);
            this.ImagemLogo.Name = "ImagemLogo";
            this.ImagemLogo.Size = new System.Drawing.Size(131, 123);
            this.ImagemLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImagemLogo.TabIndex = 0;
            this.ImagemLogo.TabStop = false;
            // 
            // lblAgenda
            // 
            this.lblAgenda.AutoSize = true;
            this.lblAgenda.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAgenda.Location = new System.Drawing.Point(305, 48);
            this.lblAgenda.Name = "lblAgenda";
            this.lblAgenda.Size = new System.Drawing.Size(635, 86);
            this.lblAgenda.TabIndex = 1;
            this.lblAgenda.Text = "Agenda da Marjorie";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNome.Location = new System.Drawing.Point(56, 258);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(109, 40);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNome.Location = new System.Drawing.Point(161, 250);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(399, 46);
            this.txtNome.TabIndex = 3;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTelefone.Location = new System.Drawing.Point(595, 258);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(142, 40);
            this.lblTelefone.TabIndex = 4;
            this.lblTelefone.Text = "Telefone:";
            // 
            // TextBoxTelefone
            // 
            this.TextBoxTelefone.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxTelefone.Location = new System.Drawing.Point(743, 252);
            this.TextBoxTelefone.Mask = "(99) 0000-0000";
            this.TextBoxTelefone.Name = "TextBoxTelefone";
            this.TextBoxTelefone.Size = new System.Drawing.Size(214, 46);
            this.TextBoxTelefone.TabIndex = 6;
            // 
            // listListaDeTelefone
            // 
            this.listListaDeTelefone.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listListaDeTelefone.FormattingEnabled = true;
            this.listListaDeTelefone.ItemHeight = 40;
            this.listListaDeTelefone.Location = new System.Drawing.Point(56, 360);
            this.listListaDeTelefone.Name = "listListaDeTelefone";
            this.listListaDeTelefone.Size = new System.Drawing.Size(901, 284);
            this.listListaDeTelefone.TabIndex = 7;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIncluir.Location = new System.Drawing.Point(1010, 250);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(139, 59);
            this.btnIncluir.TabIndex = 8;
            this.btnIncluir.Text = "INCLUIR";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnListar
            // 
            this.btnListar.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnListar.Location = new System.Drawing.Point(1010, 460);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(139, 58);
            this.btnListar.TabIndex = 9;
            this.btnListar.Text = "LISTAR";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 696);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.listListaDeTelefone);
            this.Controls.Add(this.TextBoxTelefone);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblAgenda);
            this.Controls.Add(this.ImagemLogo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ImagemLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox ImagemLogo;
        private Label lblAgenda;
        private Label lblNome;
        private TextBox txtNome;
        private Label lblTelefone;
        private MaskedTextBox TextBoxTelefone;
        private ListBox listListaDeTelefone;
        private Button btnIncluir;
        private Button btnListar;
    }
}