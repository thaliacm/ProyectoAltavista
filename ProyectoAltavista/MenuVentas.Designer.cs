﻿
namespace ProyectoAltavista
{
    partial class MenuVentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuVentas));
            this.lbVenta = new System.Windows.Forms.Label();
            this.btVentaPropio = new System.Windows.Forms.Button();
            this.btVentaTerceros = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.btConsultarVenta = new System.Windows.Forms.Button();
            this.pictureBox1Fondo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1Fondo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbVenta
            // 
            this.lbVenta.AutoSize = true;
            this.lbVenta.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVenta.Location = new System.Drawing.Point(333, 42);
            this.lbVenta.Name = "lbVenta";
            this.lbVenta.Size = new System.Drawing.Size(129, 57);
            this.lbVenta.TabIndex = 0;
            this.lbVenta.Text = "Venta";
            // 
            // btVentaPropio
            // 
            this.btVentaPropio.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVentaPropio.Location = new System.Drawing.Point(152, 131);
            this.btVentaPropio.Name = "btVentaPropio";
            this.btVentaPropio.Size = new System.Drawing.Size(160, 93);
            this.btVentaPropio.TabIndex = 1;
            this.btVentaPropio.Text = "Venta de inmuebles propios";
            this.btVentaPropio.UseVisualStyleBackColor = true;
            // 
            // btVentaTerceros
            // 
            this.btVentaTerceros.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVentaTerceros.Location = new System.Drawing.Point(501, 131);
            this.btVentaTerceros.Name = "btVentaTerceros";
            this.btVentaTerceros.Size = new System.Drawing.Size(172, 93);
            this.btVentaTerceros.TabIndex = 2;
            this.btVentaTerceros.Text = "Venta de inmuebles de terceros";
            this.btVentaTerceros.UseVisualStyleBackColor = true;
            // 
            // btSalir
            // 
            this.btSalir.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalir.Location = new System.Drawing.Point(630, 370);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(120, 39);
            this.btSalir.TabIndex = 3;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            // 
            // btConsultarVenta
            // 
            this.btConsultarVenta.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConsultarVenta.Location = new System.Drawing.Point(329, 263);
            this.btConsultarVenta.Name = "btConsultarVenta";
            this.btConsultarVenta.Size = new System.Drawing.Size(145, 70);
            this.btConsultarVenta.TabIndex = 4;
            this.btConsultarVenta.Text = "Consultar";
            this.btConsultarVenta.UseVisualStyleBackColor = true;
            // 
            // pictureBox1Fondo
            // 
            this.pictureBox1Fondo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1Fondo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1Fondo.Image")));
            this.pictureBox1Fondo.Location = new System.Drawing.Point(-8, -13);
            this.pictureBox1Fondo.Name = "pictureBox1Fondo";
            this.pictureBox1Fondo.Size = new System.Drawing.Size(815, 466);
            this.pictureBox1Fondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1Fondo.TabIndex = 53;
            this.pictureBox1Fondo.TabStop = false;
            // 
            // MenuVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btConsultarVenta);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btVentaTerceros);
            this.Controls.Add(this.btVentaPropio);
            this.Controls.Add(this.lbVenta);
            this.Controls.Add(this.pictureBox1Fondo);
            this.Name = "MenuVentas";
            this.Text = "MenuVentas";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1Fondo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbVenta;
        private System.Windows.Forms.Button btVentaPropio;
        private System.Windows.Forms.Button btVentaTerceros;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Button btConsultarVenta;
        private System.Windows.Forms.PictureBox pictureBox1Fondo;
    }
}