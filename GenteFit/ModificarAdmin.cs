using DotNet_GenteFit.CapaDatos;
using DotNet_GenteFit.CapaDatos.Entidades;
using DotNet_GenteFit.Servicios;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Monitor = DotNet_GenteFit.CapaDatos.Entidades.Monitor;

namespace DotNet_GenteFit
{
    public partial class ModificarAdmin : Form
    {
        private readonly Cliente _cliente;
        private readonly ServicioNavegacion _navegacion;
        private readonly CursosDatos _cursos;
        private readonly SalasDatos _salas;
        private readonly MonitorDatos _monitores;
        private readonly ActividadDatos _actividades;
        private Administrador admin;

        public ModificarAdmin(Cliente cliente) : this()
        {
            this._cliente = cliente;
        }
        public ModificarAdmin()
        {
            InitializeComponent();
            this._navegacion = new ServicioNavegacion();
            this._cursos = new CursosDatos();
            this._salas = new SalasDatos();
            this._monitores = new MonitorDatos();
            this._actividades = new ActividadDatos();
            CargaListas();
        }

        private void CargaListas()
        {
            this.cboActividades.DataSource = _actividades.LeerActividades();
            this.cboMonitores.DataSource = _monitores.LeerMonitores();
            this.cboSalas.DataSource = _salas.LeerSalas();
        }

        public ModificarAdmin(Administrador admin) : this()
        {
            this.admin = admin;
        }

        private void logout_Click(object sender, EventArgs e)
        {
            _navegacion.Logout();
        }

        private void menu_Click(object sender, EventArgs e)
        {
            CursosAdmin CursosAdmin = new CursosAdmin();

            this.Hide();

            CursosAdmin.Show();
        }

        internal void ShowNewCurso()
        {
            ShowCurso(new Horario
            {
                CapacidadMaxima = 10,
                Dia = DateTime.Today,
                HoraInicio = new TimeSpan(10, 0, 0),
                HoraFin = new TimeSpan(11, 0, 0),
                IdActividad = -1,
                IdSala = -1,
                IdMonitor = -1,
                IdHorario = -1
            });
        }

        internal void ShowCurso(InformacionCurso cursoInfo)
        {
            var curso = _cursos.GetHorario(cursoInfo.IdHorario);
            if (curso == null)
            {
                MessageBox.Show("No se encuentra el curso indicado");
                menu_Click(null, null);
            }
            else
            {
                ShowCurso(curso);
            }
        }

        private void ShowCurso(Horario curso)
        {
            SetCursoOnScreen(curso);
            this.Show();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            var curso = GetCursoFromScreen();
            _cursos.GuardaHorario(curso);
            SetCursoOnScreen(curso);
            MessageBox.Show("Curso guardado correctamente");
        }
        private void SetCursoOnScreen(Horario curso)
        {
            this.txtIdHorario.Text = curso.IdHorario.ToString();
            this.dtDia.Value = curso.Dia;
            this.dtHoraInicio.Value = DateFromTimeSpan(curso.HoraInicio);
            this.dtHoraFin.Value = DateFromTimeSpan(curso.HoraFin);
            SelectCbo<Actividad>(this.cboActividades, n => n.IdActividad == curso.IdActividad);
            SelectCbo<Monitor>(this.cboMonitores, n => n.IdMonitor == curso.IdMonitor);
            SelectCbo<Sala>(this.cboSalas, n => n.IdSala == curso.IdSala);
            txtCapacidadMaxima.Text = curso.CapacidadMaxima.ToString();
        }
        private Horario GetCursoFromScreen()
        {
            var curso = new Horario
            {
                Dia = this.dtDia.Value,
                HoraInicio = TimeSpanFromDate(this.dtHoraInicio.Value),
                HoraFin = TimeSpanFromDate(this.dtHoraFin.Value),
                IdActividad = (this.cboActividades.SelectedItem as Actividad).IdActividad,
                IdMonitor = (this.cboMonitores.SelectedItem as Monitor).IdMonitor,
                IdSala = (this.cboSalas.SelectedItem as Sala).IdSala,
                CapacidadMaxima = GetInt(txtCapacidadMaxima.Text)
            };
            var id = GetInt(this.txtIdHorario.Text);
            if (id >= 0) curso.IdHorario = id;
            return curso;
        }

        private TimeSpan TimeSpanFromDate(DateTime value)
        {
            return new TimeSpan(value.Hour, value.Minute, 0);
        }

        private int GetInt(string text)
        {
            if (int.TryParse(text, out var res)) return res;
            return 1;
        }

        private void SelectCbo<T>(ComboBox cbo, Func<T, bool> idCheck)
        {
            T item = cbo.Items.Cast<T>().FirstOrDefault(idCheck);
            cbo.SelectedItem = item;
            if (item == null) cbo.SelectedIndex = 0;
        }

        private DateTime DateFromTimeSpan(TimeSpan hora)
        {
            return new DateTime(2000, 1, 1, hora.Hours, hora.Minutes, 0);
        }
    }

}
