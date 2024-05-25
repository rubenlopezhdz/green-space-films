﻿namespace ProyectoGreenSpace
{
    partial class FrmPayInfo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPayInfo));
            this.btnBack = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.lblTotalApplied = new System.Windows.Forms.Label();
            this.lblTotalImportApplied = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblDiscountImport = new System.Windows.Forms.Label();
            this.lblTotalImport = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.txtDiscounts = new System.Windows.Forms.TextBox();
            this.txtTypeHall = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtShedule = new System.Windows.Forms.TextBox();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.txtSeats = new System.Windows.Forms.TextBox();
            this.txtMovie = new System.Windows.Forms.TextBox();
            this.lblDiscounts = new System.Windows.Forms.Label();
            this.lblSeats = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblShedule = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTypeHall = new System.Windows.Forms.Label();
            this.lblMovie = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pctMovie = new System.Windows.Forms.PictureBox();
            this.g2Bar = new Guna.UI2.WinForms.Guna2Panel();
            this.g2lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pibMinimize = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pibMaximize = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pibClose = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.grpInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctMovie)).BeginInit();
            this.g2Bar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibClose)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.SkyBlue;
            this.btnBack.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(657, 593);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(137, 45);
            this.btnBack.TabIndex = 53;
            this.btnBack.Text = "Atrás";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(817, 593);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(137, 45);
            this.btnCancel.TabIndex = 52;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.PaleGreen;
            this.btnPay.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Location = new System.Drawing.Point(970, 593);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(138, 45);
            this.btnPay.TabIndex = 51;
            this.btnPay.Text = "Pagar";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // lblTotalApplied
            // 
            this.lblTotalApplied.AutoSize = true;
            this.lblTotalApplied.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalApplied.Location = new System.Drawing.Point(889, 547);
            this.lblTotalApplied.Name = "lblTotalApplied";
            this.lblTotalApplied.Size = new System.Drawing.Size(182, 23);
            this.lblTotalApplied.TabIndex = 50;
            this.lblTotalApplied.Text = "TOTAL APLICADO:";
            // 
            // lblTotalImportApplied
            // 
            this.lblTotalImportApplied.AutoSize = true;
            this.lblTotalImportApplied.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalImportApplied.Location = new System.Drawing.Point(1114, 547);
            this.lblTotalImportApplied.Name = "lblTotalImportApplied";
            this.lblTotalImportApplied.Size = new System.Drawing.Size(21, 23);
            this.lblTotalImportApplied.TabIndex = 49;
            this.lblTotalImportApplied.Text = "€";
            this.lblTotalImportApplied.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(932, 514);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(131, 23);
            this.lblDiscount.TabIndex = 48;
            this.lblDiscount.Text = "DESCUENTO:";
            // 
            // lblDiscountImport
            // 
            this.lblDiscountImport.AutoSize = true;
            this.lblDiscountImport.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscountImport.Location = new System.Drawing.Point(1114, 514);
            this.lblDiscountImport.Name = "lblDiscountImport";
            this.lblDiscountImport.Size = new System.Drawing.Size(21, 23);
            this.lblDiscountImport.TabIndex = 47;
            this.lblDiscountImport.Text = "€";
            this.lblDiscountImport.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTotalImport
            // 
            this.lblTotalImport.AutoSize = true;
            this.lblTotalImport.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalImport.Location = new System.Drawing.Point(1114, 480);
            this.lblTotalImport.Name = "lblTotalImport";
            this.lblTotalImport.Size = new System.Drawing.Size(21, 23);
            this.lblTotalImport.TabIndex = 46;
            this.lblTotalImport.Text = "€";
            this.lblTotalImport.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(932, 480);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(72, 23);
            this.lblTotal.TabIndex = 45;
            this.lblTotal.Text = "TOTAL:";
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.txtDiscounts);
            this.grpInfo.Controls.Add(this.txtTypeHall);
            this.grpInfo.Controls.Add(this.txtName);
            this.grpInfo.Controls.Add(this.txtShedule);
            this.grpInfo.Controls.Add(this.txtDuration);
            this.grpInfo.Controls.Add(this.txtSeats);
            this.grpInfo.Controls.Add(this.txtMovie);
            this.grpInfo.Controls.Add(this.lblDiscounts);
            this.grpInfo.Controls.Add(this.lblSeats);
            this.grpInfo.Controls.Add(this.lblDuration);
            this.grpInfo.Controls.Add(this.lblShedule);
            this.grpInfo.Controls.Add(this.lblName);
            this.grpInfo.Controls.Add(this.lblTypeHall);
            this.grpInfo.Controls.Add(this.lblMovie);
            this.grpInfo.Controls.Add(this.lblTitle);
            this.grpInfo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInfo.Location = new System.Drawing.Point(535, 68);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(631, 395);
            this.grpInfo.TabIndex = 44;
            this.grpInfo.TabStop = false;
            // 
            // txtDiscounts
            // 
            this.txtDiscounts.BackColor = System.Drawing.Color.White;
            this.txtDiscounts.Enabled = false;
            this.txtDiscounts.Location = new System.Drawing.Point(17, 333);
            this.txtDiscounts.Multiline = true;
            this.txtDiscounts.Name = "txtDiscounts";
            this.txtDiscounts.Size = new System.Drawing.Size(232, 39);
            this.txtDiscounts.TabIndex = 33;
            // 
            // txtTypeHall
            // 
            this.txtTypeHall.BackColor = System.Drawing.Color.White;
            this.txtTypeHall.Enabled = false;
            this.txtTypeHall.Location = new System.Drawing.Point(412, 112);
            this.txtTypeHall.Multiline = true;
            this.txtTypeHall.Name = "txtTypeHall";
            this.txtTypeHall.Size = new System.Drawing.Size(193, 39);
            this.txtTypeHall.TabIndex = 32;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(17, 225);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(185, 39);
            this.txtName.TabIndex = 31;
            // 
            // txtShedule
            // 
            this.txtShedule.BackColor = System.Drawing.Color.White;
            this.txtShedule.Enabled = false;
            this.txtShedule.Location = new System.Drawing.Point(257, 225);
            this.txtShedule.Multiline = true;
            this.txtShedule.Name = "txtShedule";
            this.txtShedule.Size = new System.Drawing.Size(133, 39);
            this.txtShedule.TabIndex = 30;
            // 
            // txtDuration
            // 
            this.txtDuration.BackColor = System.Drawing.Color.White;
            this.txtDuration.Enabled = false;
            this.txtDuration.Location = new System.Drawing.Point(435, 225);
            this.txtDuration.Multiline = true;
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(144, 39);
            this.txtDuration.TabIndex = 29;
            // 
            // txtSeats
            // 
            this.txtSeats.BackColor = System.Drawing.Color.White;
            this.txtSeats.Enabled = false;
            this.txtSeats.Location = new System.Drawing.Point(309, 333);
            this.txtSeats.Multiline = true;
            this.txtSeats.Name = "txtSeats";
            this.txtSeats.Size = new System.Drawing.Size(81, 39);
            this.txtSeats.TabIndex = 28;
            // 
            // txtMovie
            // 
            this.txtMovie.BackColor = System.Drawing.Color.White;
            this.txtMovie.Enabled = false;
            this.txtMovie.Location = new System.Drawing.Point(17, 112);
            this.txtMovie.Multiline = true;
            this.txtMovie.Name = "txtMovie";
            this.txtMovie.Size = new System.Drawing.Size(294, 39);
            this.txtMovie.TabIndex = 27;
            // 
            // lblDiscounts
            // 
            this.lblDiscounts.AutoSize = true;
            this.lblDiscounts.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscounts.ForeColor = System.Drawing.Color.White;
            this.lblDiscounts.Location = new System.Drawing.Point(18, 307);
            this.lblDiscounts.Name = "lblDiscounts";
            this.lblDiscounts.Size = new System.Drawing.Size(133, 23);
            this.lblDiscounts.TabIndex = 25;
            this.lblDiscounts.Text = "DESCUENTOS";
            // 
            // lblSeats
            // 
            this.lblSeats.AutoSize = true;
            this.lblSeats.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeats.ForeColor = System.Drawing.Color.White;
            this.lblSeats.Location = new System.Drawing.Point(305, 307);
            this.lblSeats.Name = "lblSeats";
            this.lblSeats.Size = new System.Drawing.Size(63, 23);
            this.lblSeats.TabIndex = 24;
            this.lblSeats.Text = "SEATS";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.ForeColor = System.Drawing.Color.White;
            this.lblDuration.Location = new System.Drawing.Point(431, 199);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(118, 23);
            this.lblDuration.TabIndex = 23;
            this.lblDuration.Text = "DURACIÓN";
            // 
            // lblShedule
            // 
            this.lblShedule.AutoSize = true;
            this.lblShedule.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShedule.ForeColor = System.Drawing.Color.White;
            this.lblShedule.Location = new System.Drawing.Point(253, 199);
            this.lblShedule.Name = "lblShedule";
            this.lblShedule.Size = new System.Drawing.Size(103, 23);
            this.lblShedule.TabIndex = 22;
            this.lblShedule.Text = "HORARIO";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(23, 199);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(94, 23);
            this.lblName.TabIndex = 21;
            this.lblName.Text = "NOMBRE";
            // 
            // lblTypeHall
            // 
            this.lblTypeHall.AutoSize = true;
            this.lblTypeHall.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeHall.ForeColor = System.Drawing.Color.White;
            this.lblTypeHall.Location = new System.Drawing.Point(401, 82);
            this.lblTypeHall.Name = "lblTypeHall";
            this.lblTypeHall.Size = new System.Drawing.Size(137, 23);
            this.lblTypeHall.TabIndex = 20;
            this.lblTypeHall.Text = "TIPO DE SALA";
            // 
            // lblMovie
            // 
            this.lblMovie.AutoSize = true;
            this.lblMovie.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovie.ForeColor = System.Drawing.Color.White;
            this.lblMovie.Location = new System.Drawing.Point(18, 86);
            this.lblMovie.Name = "lblMovie";
            this.lblMovie.Size = new System.Drawing.Size(99, 23);
            this.lblMovie.TabIndex = 11;
            this.lblMovie.Text = "PELÍCULA";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(36, 28);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(482, 34);
            this.lblTitle.TabIndex = 19;
            this.lblTitle.Text = "ESTRENOS - PELÍCULAS MAYO 2024";
            // 
            // pctMovie
            // 
            this.pctMovie.Image = global::ProyectoGreenSpace.Properties.Resources.image_picture_icon_143003;
            this.pctMovie.Location = new System.Drawing.Point(50, 77);
            this.pctMovie.Name = "pctMovie";
            this.pctMovie.Size = new System.Drawing.Size(418, 561);
            this.pctMovie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctMovie.TabIndex = 43;
            this.pctMovie.TabStop = false;
            // 
            // g2Bar
            // 
            this.g2Bar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.g2Bar.Controls.Add(this.g2lblTitle);
            this.g2Bar.Controls.Add(this.pibMinimize);
            this.g2Bar.Controls.Add(this.pibMaximize);
            this.g2Bar.Controls.Add(this.pibClose);
            this.g2Bar.Location = new System.Drawing.Point(-1, -1);
            this.g2Bar.Name = "g2Bar";
            this.g2Bar.Size = new System.Drawing.Size(1207, 44);
            this.g2Bar.TabIndex = 54;
            // 
            // g2lblTitle
            // 
            this.g2lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.g2lblTitle.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.g2lblTitle.Location = new System.Drawing.Point(13, 8);
            this.g2lblTitle.Name = "g2lblTitle";
            this.g2lblTitle.Size = new System.Drawing.Size(194, 25);
            this.g2lblTitle.TabIndex = 36;
            this.g2lblTitle.Text = "GREEN SPACE FILMS";
            // 
            // pibMinimize
            // 
            this.pibMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pibMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pibMinimize.Image = ((System.Drawing.Image)(resources.GetObject("pibMinimize.Image")));
            this.pibMinimize.ImageRotate = 0F;
            this.pibMinimize.Location = new System.Drawing.Point(1074, 8);
            this.pibMinimize.Name = "pibMinimize";
            this.pibMinimize.Size = new System.Drawing.Size(35, 25);
            this.pibMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibMinimize.TabIndex = 35;
            this.pibMinimize.TabStop = false;
            this.pibMinimize.Click += new System.EventHandler(this.pibMinimize_Click);
            // 
            // pibMaximize
            // 
            this.pibMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pibMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pibMaximize.Image = global::ProyectoGreenSpace.Properties.Resources.maximizar;
            this.pibMaximize.ImageRotate = 0F;
            this.pibMaximize.Location = new System.Drawing.Point(1116, 8);
            this.pibMaximize.Name = "pibMaximize";
            this.pibMaximize.Size = new System.Drawing.Size(34, 25);
            this.pibMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibMaximize.TabIndex = 34;
            this.pibMaximize.TabStop = false;
            this.pibMaximize.Click += new System.EventHandler(this.pibMaximize_Click);
            // 
            // pibClose
            // 
            this.pibClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pibClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pibClose.Image = ((System.Drawing.Image)(resources.GetObject("pibClose.Image")));
            this.pibClose.ImageRotate = 0F;
            this.pibClose.Location = new System.Drawing.Point(1155, 3);
            this.pibClose.Name = "pibClose";
            this.pibClose.Size = new System.Drawing.Size(39, 33);
            this.pibClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibClose.TabIndex = 33;
            this.pibClose.TabStop = false;
            this.pibClose.Click += new System.EventHandler(this.pibClose_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.g2Bar;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // FrmPayInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 688);
            this.Controls.Add(this.g2Bar);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.lblTotalApplied);
            this.Controls.Add(this.lblTotalImportApplied);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblDiscountImport);
            this.Controls.Add(this.lblTotalImport);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.pctMovie);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPayInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPayInfo";
            this.Load += new System.EventHandler(this.FrmPayInfo_Load);
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctMovie)).EndInit();
            this.g2Bar.ResumeLayout(false);
            this.g2Bar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label lblTotalApplied;
        private System.Windows.Forms.Label lblTotalImportApplied;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblDiscountImport;
        private System.Windows.Forms.Label lblTotalImport;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.TextBox txtDiscounts;
        private System.Windows.Forms.TextBox txtTypeHall;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtShedule;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.TextBox txtSeats;
        private System.Windows.Forms.TextBox txtMovie;
        private System.Windows.Forms.Label lblDiscounts;
        private System.Windows.Forms.Label lblSeats;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblShedule;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTypeHall;
        private System.Windows.Forms.Label lblMovie;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pctMovie;
        private Guna.UI2.WinForms.Guna2Panel g2Bar;
        private Guna.UI2.WinForms.Guna2HtmlLabel g2lblTitle;
        private Guna.UI2.WinForms.Guna2PictureBox pibMinimize;
        private Guna.UI2.WinForms.Guna2PictureBox pibMaximize;
        private Guna.UI2.WinForms.Guna2PictureBox pibClose;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}