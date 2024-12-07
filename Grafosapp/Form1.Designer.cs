namespace Grafosapp
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
            txtOrigen = new TextBox();
            txtDestino = new TextBox();
            txtNodo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnAgregarNodo = new Button();
            btnAgregarArista = new Button();
            btnMostrarGrafo = new Button();
            lstAdyacencias = new ListView();
            SuspendLayout();
            // 
            // txtOrigen
            // 
            txtOrigen.Location = new Point(92, 175);
            txtOrigen.Name = "txtOrigen";
            txtOrigen.Size = new Size(153, 23);
            txtOrigen.TabIndex = 0;
            // 
            // txtDestino
            // 
            txtDestino.Location = new Point(92, 272);
            txtDestino.Name = "txtDestino";
            txtDestino.Size = new Size(153, 23);
            txtDestino.TabIndex = 1;
            // 
            // txtNodo
            // 
            txtNodo.Location = new Point(92, 83);
            txtNodo.Name = "txtNodo";
            txtNodo.Size = new Size(153, 23);
            txtNodo.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(92, 65);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 3;
            label1.Text = "Nodo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(92, 157);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 4;
            label2.Text = "Origen";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(92, 254);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 5;
            label3.Text = "Destino";
            // 
            // btnAgregarNodo
            // 
            btnAgregarNodo.Location = new Point(281, 70);
            btnAgregarNodo.Name = "btnAgregarNodo";
            btnAgregarNodo.RightToLeft = RightToLeft.No;
            btnAgregarNodo.Size = new Size(167, 46);
            btnAgregarNodo.TabIndex = 7;
            btnAgregarNodo.Text = "Agregar Nodo";
            btnAgregarNodo.UseVisualStyleBackColor = true;
            btnAgregarNodo.Click += btnAgregarNodo_Click;
            // 
            // btnAgregarArista
            // 
            btnAgregarArista.Location = new Point(281, 202);
            btnAgregarArista.Name = "btnAgregarArista";
            btnAgregarArista.Size = new Size(167, 46);
            btnAgregarArista.TabIndex = 8;
            btnAgregarArista.Text = "Agregar Arista";
            btnAgregarArista.UseVisualStyleBackColor = true;
            btnAgregarArista.Click += btnAgregarArista_Click;
            // 
            // btnMostrarGrafo
            // 
            btnMostrarGrafo.Location = new Point(325, 379);
            btnMostrarGrafo.Name = "btnMostrarGrafo";
            btnMostrarGrafo.Size = new Size(167, 46);
            btnMostrarGrafo.TabIndex = 9;
            btnMostrarGrafo.Text = "Mostrar Grafo";
            btnMostrarGrafo.UseVisualStyleBackColor = true;
            btnMostrarGrafo.Click += btnMostrarGrafo_Click;
            // 
            // lstAdyacencias
            // 
            lstAdyacencias.Location = new Point(498, 272);
            lstAdyacencias.Name = "lstAdyacencias";
            lstAdyacencias.Size = new Size(236, 153);
            lstAdyacencias.TabIndex = 10;
            lstAdyacencias.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 450);
            Controls.Add(lstAdyacencias);
            Controls.Add(btnMostrarGrafo);
            Controls.Add(btnAgregarArista);
            Controls.Add(btnAgregarNodo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNodo);
            Controls.Add(txtDestino);
            Controls.Add(txtOrigen);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtOrigen;
        private TextBox txtDestino;
        private TextBox txtNodo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnAgregarNodo;
        private Button btnAgregarArista;
        private Button btnMostrarGrafo;
        private ListView lstAdyacencias;
    }
}
