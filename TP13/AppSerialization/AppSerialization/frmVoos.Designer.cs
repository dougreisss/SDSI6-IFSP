namespace AppSerialization
{
    partial class frmVoos
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
            lblBinario = new Label();
            btnSerializarBinario = new Button();
            txtResultado = new TextBox();
            btnDesserializarBinario = new Button();
            label1 = new Label();
            btnDesserializarXml = new Button();
            btnSerializarXML = new Button();
            label2 = new Label();
            btnLimpar = new Button();
            SuspendLayout();
            // 
            // lblBinario
            // 
            lblBinario.AutoSize = true;
            lblBinario.Location = new Point(12, 20);
            lblBinario.Name = "lblBinario";
            lblBinario.Size = new Size(124, 15);
            lblBinario.TabIndex = 0;
            lblBinario.Text = "Converta para binário:";
            // 
            // btnSerializarBinario
            // 
            btnSerializarBinario.Location = new Point(142, 16);
            btnSerializarBinario.Name = "btnSerializarBinario";
            btnSerializarBinario.Size = new Size(80, 23);
            btnSerializarBinario.TabIndex = 1;
            btnSerializarBinario.Text = "Serializar ";
            btnSerializarBinario.UseVisualStyleBackColor = true;
            btnSerializarBinario.Click += btnSerializarBinario_Click;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(12, 118);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(436, 212);
            txtResultado.TabIndex = 2;
            // 
            // btnDesserializarBinario
            // 
            btnDesserializarBinario.Location = new Point(368, 20);
            btnDesserializarBinario.Name = "btnDesserializarBinario";
            btnDesserializarBinario.Size = new Size(80, 23);
            btnDesserializarBinario.TabIndex = 4;
            btnDesserializarBinario.Text = "Desserializar";
            btnDesserializarBinario.UseVisualStyleBackColor = true;
            btnDesserializarBinario.Click += btnDesserializarBinario_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 100);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 5;
            label1.Text = "Resultado:";
            // 
            // btnDesserializarXml
            // 
            btnDesserializarXml.Location = new Point(368, 60);
            btnDesserializarXml.Name = "btnDesserializarXml";
            btnDesserializarXml.Size = new Size(80, 23);
            btnDesserializarXml.TabIndex = 8;
            btnDesserializarXml.Text = "Desserializar";
            btnDesserializarXml.UseVisualStyleBackColor = true;
            btnDesserializarXml.Click += btnDesserializarXml_Click;
            // 
            // btnSerializarXML
            // 
            btnSerializarXML.Location = new Point(142, 64);
            btnSerializarXML.Name = "btnSerializarXML";
            btnSerializarXML.Size = new Size(80, 23);
            btnSerializarXML.TabIndex = 7;
            btnSerializarXML.Text = "Serializar ";
            btnSerializarXML.UseVisualStyleBackColor = true;
            btnSerializarXML.Click += btnSerializarXML_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 68);
            label2.Name = "label2";
            label2.Size = new Size(111, 15);
            label2.TabIndex = 6;
            label2.Text = "Converta para XML:";
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(12, 336);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(436, 23);
            btnLimpar.TabIndex = 9;
            btnLimpar.Text = "Limpar Resultado";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // frmVoos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(461, 368);
            Controls.Add(btnLimpar);
            Controls.Add(btnDesserializarXml);
            Controls.Add(btnSerializarXML);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDesserializarBinario);
            Controls.Add(txtResultado);
            Controls.Add(btnSerializarBinario);
            Controls.Add(lblBinario);
            Name = "frmVoos";
            Text = "Voos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBinario;
        private Button btnSerializarBinario;
        private TextBox txtResultado;
        private Button btnDesserializarBinario;
        private Label label1;
        private Button btnDesserializarXml;
        private Button btnSerializarXML;
        private Label label2;
        private Button btnLimpar;
    }
}
