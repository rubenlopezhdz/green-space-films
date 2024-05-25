﻿using ProyectoGreenSpace.Classes;
using ProyectoGreenSpace.LangResources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoGreenSpace
{
    public partial class FrmMovieMaintenance : Form
    {
        public FrmMovieMaintenance()
        {
            InitializeComponent();

            grpClock.BackColor = Color.FromArgb(168, 228, 116);
            grpMaintenance.BackColor = Color.FromArgb(168, 228, 116);
        }

        #region Validaciones
        private bool ValidateInputs()
        {
            bool godrickElInjertado = true;
            errorProvider1.Clear();

            if (EmptyGenres())
            {
                godrickElInjertado = false;
                errorProvider1.SetError(cmbGenre1, "Introduce dos géneros obligatoriamente.");
                errorProvider1.SetError(cmbGenre2, "Introduce dos géneros obligatoriamente.");
            }
            else if (SameGenres())
            {
                godrickElInjertado = false;
                errorProvider1.SetError(cmbGenre1, "No es posible introducir el mismo genero varias veces.");
                errorProvider1.SetError(cmbGenre2, "No es posible introducir el mismo genero varias veces.");
            }
            else if (String.IsNullOrEmpty(txtFilm.Text))
            {
                godrickElInjertado = false;
                errorProvider1.SetError(txtFilm, "Inserta una película.");
            }
            else if (String.IsNullOrEmpty(rtbSynopsis.Text))
            {
                godrickElInjertado = false;
                errorProvider1.SetError(rtbSynopsis, "Inserta una sinopsis.");
            }
            else if (String.IsNullOrEmpty(txtDuration.Text))
            {
                godrickElInjertado = false;
                errorProvider1.SetError(txtDuration, "Inserta la duración.");
            }
            else if (String.IsNullOrEmpty(txtPrice.Text))
            {
                godrickElInjertado = false;
                errorProvider1.SetError(txtPrice, "Inserta el precio.");
            }
            else if (String.IsNullOrEmpty(txtDuration.Text))
            {
                godrickElInjertado = false;
                errorProvider1.SetError(txtDuration, "Inserta la duración.");
            }
            else if (String.IsNullOrEmpty(cmbGenre1.Text))
            {
                godrickElInjertado = false;
                errorProvider1.SetError(cmbGenre1, "Inserta el primer género.");
            }
            else if (String.IsNullOrEmpty(cmbGenre1.Text))
            {
                godrickElInjertado = false;
                errorProvider1.SetError(cmbGenre2, "Inserta el segundo género.");
            }
            else if (pibImage.Image == null)
            {
                godrickElInjertado = false;
                errorProvider1.SetError(btnUpload, "Inserta una imagen.");
            } else if (chbPremiering.Checked && chbNextPremiering.Checked)
            {
                godrickElInjertado = false;
                errorProvider1.SetError(chbPremiering, "Selecciona una única opción.");
                errorProvider1.SetError(chbNextPremiering, "Selecciona una única opción.");
            }

            return godrickElInjertado;
        }

        private bool SameGenres()
        {
            return cmbGenre1.Text.Equals(cmbGenre2.Text);
        }
        private bool EmptyGenres()
        {
            return string.IsNullOrEmpty(cmbGenre1.Text) || string.IsNullOrEmpty(cmbGenre2.Text);
        }
        #endregion

        private void LoadGenres()
        {
            string[] genres = Film.ObtainGenres();

            cmbGenre1.Items.AddRange(genres);
            cmbGenre2.Items.AddRange(genres);
        }

        private void CleanData()
        {
            txtFilm.Text = string.Empty;
            rtbSynopsis.Text = string.Empty;
            txtDuration.Text = string.Empty;
            txtPrice.Text = string.Empty;
            nudMinAge.Value = 0;
            cmbGenre1.Text = string.Empty;
            cmbGenre2.Text = string.Empty;
            chbPremiering.Checked = false;
            chbNextPremiering.Checked = false;
        }
        private void ApplyLanguage()
        {
            lblFilm.Text = StringResources.lblFilm;
            lblSynopsis.Text = StringResources.lblSynopsis;
            lblDuration.Text = StringResources.lblDuration;
            lblMinAge.Text = StringResources.lblMinAge;
            lblPrice.Text = StringResources.lblPrice;
            lblGenre.Text = StringResources.lblGenre;
            chbNextPremiering.Text = StringResources.chbNextPremiering;
            chbPremiering.Text = StringResources.chbPremiering;
            btnInsert.Text = StringResources.btnInsert;
            btnModifyFrm.Text = StringResources.btnModifyFrm;
            btnDeleteFrm.Text = StringResources.btnDeleteFrm;
            btnUpload.Text = StringResources.btnUpload;
            btnBack.Text = StringResources.buttonExit;
            btnInsertSessions.Text = StringResources.btnAccessSessions;
        }

        private void FrmMovieMaintenance_Load(object sender, EventArgs e)
        {
            timerClock.Enabled = true;
            timerClock.Interval = 1000;
            timerClock.Start();

            g2Bar.BackColor = Color.FromArgb(76, 80, 144);
            g2lblTitle.ForeColor = Color.FromArgb(168, 228, 116);

            LoadListMovies();
            ApplyLanguage();

            lblClock.Text = DateTime.Now.ToString("HH:mm:ss");
            lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy");

            txtFilm.Focus();

            LoadGenres();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdSelect = new OpenFileDialog();
            ofdSelect.Filter = "Imagenes|*.jpg; *.png"; // Imagenes --> Leyenda|Filtrar solo por estas extensiones 
            ofdSelect.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures); // Directorio donde cogemos las imágenes
            ofdSelect.Title = "Seleccionar imagen";

            if (ofdSelect.ShowDialog() == DialogResult.OK)
            {
                pibImage.Image = Image.FromFile(ofdSelect.FileName); // Agregar el archivo seleccionado y mostrarlo en el cuadro.
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
                return;
            }

            try
            {
                string[] genres = new string[]
                {
                    cmbGenre1.Text,
                    cmbGenre2.Text
                };

                Film film = new Film(
                    txtFilm.Text,
                    rtbSynopsis.Text,
                    pibImage.Image,
                    TimeSpan.Parse(txtDuration.Text),
                    (int)nudMinAge.Value,
                    Convert.ToDouble(txtPrice.Text),
                    genres,
                    chbPremiering.Checked,
                    chbNextPremiering.Checked
                );

                film.Create();
                LoadListMovies();
                CleanData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void timerClock_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        private void LoadListMovies()
        {
            dgvFilms.DataSource = Film.ObtainAll();
        }

        private void btnInsertSessions_Click(object sender, EventArgs e)
        {
            FrmInsertSession frmInsertSession = new FrmInsertSession();
            frmInsertSession.Show();
            this.Close();
        }

        #region Diseño de interface
        private void grpMaintenance_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, grpMaintenance.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private void grpClock_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, grpClock.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);

        }

        private void pibImage_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, pibImage.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }
        #endregion

        #region Acceso a formularios de acceso
        private void btnModifyFrm_Click(object sender, EventArgs e)
        {
            FrmMovieModify frmMovieModify = new FrmMovieModify();
            frmMovieModify.Show();
            this.Close();
        }

        private void btnDeleteFrm_Click(object sender, EventArgs e)
        {
            FrmMovieDelete frmMovieDelete = new FrmMovieDelete();
            frmMovieDelete.Show();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmAccount frmAccount = new FrmAccount();
            frmAccount.Show();
            this.Close();
        }

        #endregion

        #region Diseño de barra minimizadora
        private void pibMinimize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Minimized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }
        private void pibMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void pibClose_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                Application.Exit();
            }
        }
        #endregion
    }
}