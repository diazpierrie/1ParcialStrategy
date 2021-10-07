using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using EE;
using BLL;


namespace UI
{
    public partial class MainForm : Form
    {
        private List<EEArma> _estrategiasDisparo;
        private BindingList<EEObjetivo> _objetivos;
        private EEBaseMilitar _baseMilitar = new EEBaseMilitar();

        BLLObjetivo _bllObjetivo = new BLLObjetivo();
        BLLBaseMilitar _bllBaseMilitar = new BLLBaseMilitar();

        public MainForm()
        {
            InitializeComponent();

            _baseMilitar = new EEBaseMilitar();
            _objetivos = new BindingList<EEObjetivo>();

            _estrategiasDisparo = new List<EEArma>();
            _estrategiasDisparo.Add(new EECanonCorto());
            _estrategiasDisparo.Add(new EECanonUltrasonico());
            _estrategiasDisparo.Add(new EERayoLaserDestructorBionico());

            ObjetivosDataGrid.DataSource = _objetivos;
            ObjetivosDataGrid.Columns["Id"].Visible = false;
            ObjetivosDataGrid.Columns["Activo"].Visible = false;
            labelArma.Hide();
        }

        private void RadarBtn_Click(object sender, System.EventArgs e)
        {
            RefrescarTabla();
            _bllBaseMilitar.DeterminarArma(ObjetivosDataGrid.CurrentCell.RowIndex, _baseMilitar, _estrategiasDisparo, _objetivos);
            labelArma.Show();
            labelArma.Text = $@"El arma recomendada a esa distancia es el {_baseMilitar.RetornarEstrategia()}";
        }

        private void RefrescarTabla()
        {
            _objetivos = new BindingList<EEObjetivo>();
            foreach (var objetivo in _bllObjetivo.EscanearObjetivos())
            {
                _objetivos.Add(objetivo);
            }
            ObjetivosDataGrid.DataSource = _objetivos;
        }

        private void DispararBtn_Click(object sender, System.EventArgs e)
        {
            if (ObjetivosDataGrid.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show(@"Debe seleccionar un objetivo antes de disparar");
            }
            else
            {
                EEObjetivo oObjetivo = _objetivos[ObjetivosDataGrid.CurrentCell.RowIndex];

                DialogResult boton = MessageBox.Show(string.Format(
                    @"Desea dispararle al {0} usando el {1} con una probabilidad de acertar de {2}%?",
                    oObjetivo.Nombre,
                    _baseMilitar.RetornarEstrategia(),
                    oObjetivo.ProbabilidadAcierto), @"Alerta", MessageBoxButtons.YesNo);
                if (boton == DialogResult.Yes)
                {
                    if (_bllBaseMilitar.DispararArma(oObjetivo, _baseMilitar.RetornarEstrategia()))
                    {
                        MessageBox.Show("Objetivo destruido");
                        RefrescarTabla();
                    }
                    else
                    {
                        MessageBox.Show("Disparo errado");
                    }
                }
            }
        }

        private void ObjetivosDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _bllBaseMilitar.DeterminarArma(ObjetivosDataGrid.CurrentCell.RowIndex, _baseMilitar, _estrategiasDisparo, _objetivos);
            labelArma.Text = $@"El arma recomendada a esa distancia es el {_baseMilitar.RetornarEstrategia()}";
        }
    }
}
