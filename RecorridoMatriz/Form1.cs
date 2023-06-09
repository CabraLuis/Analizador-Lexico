﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.IO;
using System.Runtime.InteropServices;
using FontAwesome.Sharp;

namespace RecorridoMatriz
{
    public partial class frmLenguaje : Form
    {
        // Listas
        List<Token> listaTokens = new List<Token>();
        List<Error> listaErrores = new List<Error>();
        List<TablaDeSimbolos> tablaDeSimbolos = new List<TablaDeSimbolos>();
        List<string> listaPalabrasErroneas = new List<string>();

        // Arreglo del alfabeto
        string[] Alfabeto;

        // Datos Auxiliares
                // Variable para enumerar identificadores de tabla de simbolos
                int numIdentificador = 0;
                // Variables a usar para control de estado
                int intEstadoActual = 0;
                int intEstadoSiguiente = 0;

                // Arreglo para guardar los caracteres de cada linea
                char[] caracteresPorLinea;

                // Cadena donde se guarda cada linea de codigo
                string strLineaDeCodigo;

                // Variable para indicar linea de codigo
                int numLinea;

                // Variable para guardar identificador
                string strIDV = "";
                bool banderaIDV = false;

                // Variable para guardar cadenas
                string strPalabra = "";

        public frmLenguaje()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rtxbSentencias.SelectionStart = rtxbSentencias.Text.Length;
            dtgIden.ReadOnly = true;
            dtgIden.AllowUserToAddRows = false;
            dtgIden.AllowUserToDeleteRows = false;

            dtgTablaDeSimbolos.ReadOnly = true;
            dtgTablaDeSimbolos.AllowUserToAddRows = false;
            dtgTablaDeSimbolos.AllowUserToDeleteRows = false;
            dtgTablaDeSimbolos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dtgIden.DataSource = LlenarDatos();
            ReescribirMayusculas();

            // Definir alfabeto
            Alfabeto = new string[60] { "Estado", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n",
            "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9",
            "+", "-", "*", "/", "^", "<", ">", "=", "!", "&", "|", "#", "\"", ".", "(", ")", "{", "}", "[", "]", "_", "FDC", "CAT"};
        }

        void ReescribirMayusculas()
        {
            string strMayus;
            for(int i = 1; i<27; i++)
            {
                strMayus = dtgIden.Columns[i].HeaderText;
                dtgIden.Columns[i].HeaderText = Regex.Replace(strMayus, @"\B[A-Z]", ToString().ToLower());
            }
        }

        // Metodo para añadir texto al richtextbox del token
        void AgregarAToken(string strNota)
        {
            if (rtxbTokens.Text == "")
            {
                rtxbTokens.Text = strNota;
            }
            else
            {
                rtxbTokens.Text = rtxbTokens.Text + "\n" + strNota;
            }
            rtxbTokens.SelectionStart = rtxbTokens.Text.Length;
            rtxbTokens.ScrollToCaret();
        }
        void AgregarALineaToken(string strNota)
        {
            if (rtxbLineasTokens.Text == "")
            {
                rtxbLineasTokens.Text = strNota;
            }
            else
            {
                rtxbLineasTokens.Text = rtxbLineasTokens.Text + "\n" + strNota;
            }
            rtxbLineasTokens.SelectionStart = rtxbLineasTokens.Text.Length;
            rtxbLineasTokens.ScrollToCaret();
        }

        void AgregarAErrores(string strNota, string strNumero)
        {
            // Nombre de error
            if (rtxbNombreError.Text == "")
            {
                rtxbNombreError.Text = strNota;
            }
            else
            {
                rtxbNombreError.Text = rtxbNombreError.Text + "\n" + strNota;
            }
            rtxbNombreError.SelectionStart = rtxbNombreError.Text.Length;
            rtxbNombreError.ScrollToCaret();

            // Numero de linea
            if(rtxbNumError.Text == "")
            {
                rtxbNumError.Text = strNumero;
            }
            else
            {
                rtxbNumError.Text = rtxbNumError.Text + "\n" + strNumero;
            }
            rtxbNumError.SelectionStart = rtxbNumError.Text.Length;
            rtxbNumError.ScrollToCaret();
        }
        void ActualizarTOKENS()
        {
            rtxbTokens.Clear();
            foreach(Token unToken in listaTokens)
            {
                AgregarAToken(unToken.NombreTOKEN);
            }

            rtxbLineasTokens.Clear();
            // Actualiza los numeros de linea
            int n = rtxbTokens.Lines.Length;
            for(int i=1; i<=n; i++)
            {
                AgregarALineaToken(i.ToString());
            }
        }

        void ActualizarListaErrores()
        {
            rtxbNumError.Clear(); rtxbNombreError.Clear();
            foreach (Error unError in listaErrores)
            {
                AgregarAErrores(unError.NombreDeError, unError.NLinea.ToString());
            }
            lblNumErrores.Text = rtxbNumError.Lines.Length.ToString();
        }

        void ActualizarTablaDeSimbolos()
        {
            dtgTablaDeSimbolos.Rows.Clear();
            foreach(TablaDeSimbolos registro in tablaDeSimbolos)
            {
                dtgTablaDeSimbolos.Rows.Add(registro.NumIdentificador, registro.Nombre);
            }
        }

        // Analisis lexico
        // Metodo de lectura de cadena
        void LecturaDeCadena()
        {
            // Empieza recorrido de lineas de codigo
            for (numLinea = 0; numLinea < rtxbSentencias.Lines.Length; numLinea++)
            {
                // Saltar si es una linea vacia
                if (rtxbSentencias.Lines[numLinea] == "")
                {
                    continue;
                }

                // Guardamos linea de codigo y le agregamos una "marca/blanco" para el FDC
                strLineaDeCodigo = rtxbSentencias.Lines[numLinea] + " ";

                // Se guarda la cadena en el arreglo de caracteres
                caracteresPorLinea = strLineaDeCodigo.ToCharArray();

                // Reiniciar valores para recorrer matriz
                int intColumna = 0;
                intEstadoActual = 0; intEstadoSiguiente = 0;

                // Empieza recorrido de caracteres de cada linea de codigo
                foreach (char c in caracteresPorLinea)
                {
                    intColumna = 0;
                    // Recorrido de alfabeto
                    RecorrerMatriz(c, ref intColumna);
                }
            }
        }

        // Metodo para leer la matriz de la base de datos
        public DataTable LlenarDatos()
        {
            Conexion.Conectar();
            DataTable dt = new DataTable();
            string consulta = "SELECT* FROM lexico";
            SqlCommand cmd = new SqlCommand(consulta, Conexion.Conectar());

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            return dt;
        }
        string[,] _matriz;
        void GenerarMatriz()
        {
            _matriz = new string[(dtgIden.Rows.Count), (dtgIden.Columns.Count)];
            foreach (DataGridViewRow row in dtgIden.Rows)
            {
                if (!row.IsNewRow)
                {
                    foreach (DataGridViewCell cel in row.Cells)
                    {
                        _matriz[cel.RowIndex, cel.ColumnIndex] = Convert.ToString(cel.Value);
                    }
                }
            }
        }

        // Metodo de recorrido de matriz
        void RecorrerMatriz(char c, ref int intColumna)
        {
            // Recorrido de alfabeto
            foreach (string simbolo in Alfabeto)
            {
                // Si el caracter se encuentra en el alfabeto
                if (c.ToString() == simbolo)
                {
                    // Verificamos si se trata de un IDV
                    if (char.IsLetter(c))
                    {
                        // Activa bool
                        banderaIDV = true;
                    }
                    if (banderaIDV)
                    {
                        // Va guardando el nombre del IDV
                        strIDV = strIDV + c.ToString();
                    }
                    // Añadimos caracter para formar palabra
                    strPalabra = strPalabra + c.ToString();

                    // Avanza al estado indicado en la celda
                    intEstadoSiguiente = int.Parse(_matriz[(intEstadoActual), intColumna]);
                    intEstadoActual = intEstadoSiguiente;
                    break;
                }

                // Si llega a FDC
                if (c.ToString() == " " && simbolo == "FDC")
                {
                    // Si es un blanco en el estado 0
                    if (intEstadoActual == 0)
                    {
                        strPalabra = "";
                        break;
                    }
                    // Verificar si se trata de un error
                    if ((_matriz[intEstadoActual, intColumna]).Contains("ERROR"))
                    {
                        ElementosNoValidos(ref intColumna);
                    }
                    else
                    {
                        // Continua normal
                        strPalabra = "";
                        intEstadoActual = intEstadoSiguiente;

                        intColumna++;
                    }

                    // Estado de aceptacion


                    // Se procede a añadir a la lista de TOKENS

                    // Declaramos un bool para indicar si es un token en nueva linea de codigo
                    bool bandera = true;

                    // Verifica si es de la misma linea de codigo
                    int iteracion = 0;
                    foreach (Token token in listaTokens)
                    {
                        if (token.NumLinea == numLinea)
                        {
                            Token unToken1 = new Token();
                            unToken1.NombreTOKEN = _matriz[intEstadoActual, intColumna];
                            if(unToken1.NombreTOKEN.Contains("ERROR"))
                            {
                                string numeros = Regex.Match(unToken1.NombreTOKEN, @"\d+").Value;
                                if (numeros != "")
                                {
                                    unToken1.NombreTOKEN = unToken1.NombreTOKEN.Replace(numeros, string.Empty);
                                }
                            }
                            
                            // Verificamos si se trata de un identificador
                            bool yaExiste = false;
                            if (unToken1.NombreTOKEN == "IDV")
                            {
                                // Buscamos en la tabla de simbolos si ya existe un IDV con el mismo nombre
                                BusquedaEnLaTablaDeSimbolos(ref yaExiste);

                                // Si ya existe IDV...
                                if (yaExiste)
                                {
                                    // Agregamos al archivo con TOKEN ya existente
                                    unToken1.NombreTOKEN = unToken1.NombreTOKEN + numIdentificador;
                                }
                                // Sino, se enumera TOKEN y añadimos IDV a tabla de simbolos
                                else
                                {
                                    int conteoIDV = 0;
                                    // Buscamos si ya existe algún IDV para ENUMERARLO
                                    ConteoDeTablaDeSimbolos(ref conteoIDV);
                                    conteoIDV = conteoIDV + 1;
                                    unToken1.NombreTOKEN = unToken1.NombreTOKEN + conteoIDV;

                                    // Añadimos a la tabla de simbolos
                                    TablaDeSimbolos unRegistro = new TablaDeSimbolos();
                                    unRegistro.Nombre = strIDV;
                                    unRegistro.NumIdentificador = conteoIDV;
                                    tablaDeSimbolos.Add(unRegistro);
                                }
                                // Limpiamos variable que guarda nombre de IDV
                                strIDV = "";
                            }


                            // Agrega a la linea de TOKEN que actualmente se encuentra
                            string tokenAnterior = listaTokens[iteracion].NombreTOKEN;
                            listaTokens[iteracion].NombreTOKEN = tokenAnterior + " " + unToken1.NombreTOKEN;
                            // Volvemos a reiniciar estados
                            intEstadoActual = 0; intEstadoSiguiente = 0;
                            bandera = false; banderaIDV = false;
                            break;
                        }
                        iteracion++;
                    }

                    // Se ejecutara este codigo si el token se añade en nueva linea de codigo
                    if (bandera)
                    {
                        Token unToken = new Token();
                        unToken.NombreTOKEN = _matriz[intEstadoActual, intColumna];
                        if(unToken.NombreTOKEN.Contains("ERROR"))
                        {
                            string numeros = Regex.Match(unToken.NombreTOKEN, @"\d+").Value;
                            if (numeros != "")
                            {
                                unToken.NombreTOKEN = unToken.NombreTOKEN.Replace(numeros, string.Empty);
                            }
                        }

                        // Verificamos si se trata de un identificador
                        bool yaExiste = false;
                        if (unToken.NombreTOKEN == "IDV")
                        {
                            // Buscamos en la tabla de simbolos si ya existe un IDV con el mismo nombre
                            BusquedaEnLaTablaDeSimbolos(ref yaExiste);

                            // Si ya existe IDV...
                            if (yaExiste)
                            {
                                // Agregamos al archivo con TOKEN ya existente
                                unToken.NombreTOKEN = unToken.NombreTOKEN + numIdentificador;
                            }
                            // Sino, se enumera TOKEN y añadimos IDV a tabla de simbolos
                            else
                            {
                                int conteoIDV = 0;
                                // Buscamos si ya existe algún IDV para ENUMERARLO
                                ConteoDeTablaDeSimbolos(ref conteoIDV);

                                conteoIDV = conteoIDV + 1;
                                unToken.NombreTOKEN = unToken.NombreTOKEN + conteoIDV;

                                // Añadimos a la tabla de simbolos
                                TablaDeSimbolos unRegistro = new TablaDeSimbolos();
                                unRegistro.Nombre = strIDV;
                                unRegistro.NumIdentificador = conteoIDV;
                                tablaDeSimbolos.Add(unRegistro);
                            }
                            // Limpiamos variable que guarda nombre de IDV
                            strIDV = "";
                        }
                        unToken.NumLinea = numLinea;
                        listaTokens.Add(unToken);

                        // Volvemos a reiniciar estados
                        intEstadoActual = 0; intEstadoSiguiente = 0;
                        banderaIDV = false;
                        break;
                    }
                }
                intColumna++;
            }
        }

        // Metodo de busqueda en la tabla de simbolos y asignacion de nuevos valores
        void BusquedaEnLaTablaDeSimbolos(ref bool yaExiste)
        {
            foreach (TablaDeSimbolos tablaDeSimbolos in tablaDeSimbolos)
            {
                if (tablaDeSimbolos.Nombre == strIDV)
                {
                    yaExiste = true;
                    numIdentificador = tablaDeSimbolos.NumIdentificador;
                }
            }
        }
        void ConteoDeTablaDeSimbolos(ref int conteoIDV)
        {
            foreach (TablaDeSimbolos registros in tablaDeSimbolos)
            {
                if (registros == null)
                {
                    break;
                }
                conteoIDV++;
            }
        }

        // Metodo para recuperacion de errores
        void ElementosNoValidos(ref int intColumna)
        {
            Error unError = new Error();
            unError.NombreDeError = _matriz[intEstadoActual, intColumna];
            string extraerNumero = Regex.Match(unError.NombreDeError, @"\d+").Value;
            if (extraerNumero != "")
            {
                unError.NombreDeError = _matriz[int.Parse(extraerNumero), 60];
                unError.NLinea = numLinea + 1;
            }
            else
            {
                int intColumnaError = intColumna + 1;

                unError.NLinea = numLinea + 1;
                unError.NombreDeError = _matriz[intEstadoActual, intColumnaError];
            }
            // Añade palabra erronea a la lista
            listaPalabrasErroneas.Add(strPalabra);
            listaErrores.Add(unError);
            ActualizarListaErrores();
            strPalabra = "";
            strIDV = "";
        }
        void CambiarColor()
        {
            // Cambia color en el código
            foreach (string s in listaPalabrasErroneas)
            {
                Utility.CambiarColor(rtxbSentencias, s, Color.Red);
            }

            // Cambiar color en los TOKENS
            Utility.CambiarColor(rtxbTokens, "ERROR", Color.Red);
        }

        private void rtxbSentencias_TextChanged(object sender, EventArgs e)
        {
            rtxbSentencias.SelectionBackColor = Color.FromArgb(9, 17, 59);
            ActualizarLineasDeCodigo();
            // Codigo para restablecer color normal de codigo
            string strTexto = rtxbSentencias.Text;
            foreach (string s1 in listaPalabrasErroneas)
            {
                strTexto.Replace(s1, string.Empty);
            }
            Utility.CambiarColor(rtxbSentencias, strTexto, Color.FromArgb(0,0,0));
            CambiarColor();
            rtxbSentencias.SelectionBackColor = Color.DimGray;
        }

        private void ActualizarLineasDeCodigo()
        {
            string strCodigo = rtxbSentencias.Text;
            int ic = 2;
            rtxbLineasCodigo.Text = "1";
            foreach (var c in strCodigo)
            {
                if ((int)c == 10)
                {
                    rtxbLineasCodigo.Text += "\n" + ic;
                    ic++;
                    rtxbLineasCodigo.SelectionStart = rtxbLineasCodigo.TextLength;
                    rtxbLineasCodigo.ScrollToCaret();
                }
            }
        }

        private void rtxbSentencias_Click(object sender, EventArgs e)
        {
            rtxbSentencias.SelectionColor = Color.FromArgb(128, 255, 255);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }
        
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void frmLenguaje_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void RbtnNuevo_Click(object sender, EventArgs e)
        {
            rtxbTokens.Text = "";
            rtxbNombreError.Clear();
            rtxbSentencias.Text = "";
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            // Generar matriz
            GenerarMatriz();

            // Limpiar listas
            listaTokens.Clear(); listaErrores.Clear(); tablaDeSimbolos.Clear(); listaPalabrasErroneas.Clear();

            banderaIDV = false;

            // Empieza recorrido de lineas de codigo
            LecturaDeCadena();

            // Se actualiza rtxb para archivo token
            ActualizarTOKENS();

            // Se actualiza tabla de simbolos
            ActualizarTablaDeSimbolos();

            // Se actualiza la lista de errores
            ActualizarListaErrores();

            // Cambiamos color de errores en codigo
            CambiarColor();
        }

    }
}
