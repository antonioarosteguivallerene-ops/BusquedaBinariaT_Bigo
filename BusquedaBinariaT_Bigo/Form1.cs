using System.Windows.Forms;
using System;
using System.Collections.Generic;

namespace BusquedaBinaria
{
    public partial class Form1 : Form
    {
        private int[]? arreglo;
        private bool arregloGenerado = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtTamano.Text, out int n) || n <= 0)
            {
                MessageBox.Show("Ingrese un número entero positivo para el tamaño del arreglo.", "Error de validación");
                return;
            }

            arreglo = GenerarArreglo(n);
            MostrarArreglo();
            arregloGenerado = true;
            rtxtPasos.Clear();
            rtxtResultado.Clear();
        }

        private int[] GenerarArreglo(int n)
        {
            int[] arr = new int[n];
            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                arr[i] = random.Next(1, n * 100);
            }

            Array.Sort(arr);
            return arr;
        }

        private void MostrarArreglo()
        {
            lstDatos.Items.Clear();
            if (arreglo != null)
            {
                foreach (int valor in arreglo)
                {
                    lstDatos.Items.Add(valor);
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!arregloGenerado || arreglo == null)
            {
                MessageBox.Show("Primero debe generar un arreglo.", "Error");
                return;
            }

            if (!int.TryParse(txtBuscar.Text, out int valor))
            {
                MessageBox.Show("Ingrese un número entero válido para buscar.", "Error de validación");
                return;
            }

            BusquedaBinariaInfo resultado = BusquedaBinaria(arreglo, valor);
            MostrarResultado(resultado);
            MostrarComplejidad(resultado);
        }

        private BusquedaBinariaInfo BusquedaBinaria(int[] arr, int objetivo)
        {
            BusquedaBinariaInfo info = new BusquedaBinariaInfo();
            info.Pasos = new System.Collections.Generic.List<string>();
            info.Comparaciones = 0;

            int inicio = 0;
            int fin = arr.Length - 1;
            int iteracion = 1;

            while (inicio <= fin)
            {
                int medio = (inicio + fin) / 2;
                info.Comparaciones++;

                string paso = $"Iteración {iteracion}: inicio={inicio}, fin={fin}, medio={medio}, arr[{medio}]={arr[medio]}";
                info.Pasos.Add(paso);

                if (arr[medio] == objetivo)
                {
                    info.Encontrado = true;
                    info.Posicion = medio;
                    return info;
                }
                else if (arr[medio] < objetivo)
                {
                    inicio = medio + 1;
                }
                else
                {
                    fin = medio - 1;
                }

                iteracion++;
            }

            info.Encontrado = false;
            info.Posicion = -1;
            return info;
        }

        private void MostrarResultado(BusquedaBinariaInfo resultado)
        {
            rtxtPasos.Clear();
            if (resultado.Pasos != null)
            {
                foreach (string paso in resultado.Pasos)
                {
                    rtxtPasos.AppendText(paso + "\n");
                }
            }

            rtxtResultado.Clear();
            if (resultado.Encontrado)
            {
                rtxtResultado.AppendText($"✓ Valor encontrado en posición: {resultado.Posicion}\n");
            }
            else
            {
                rtxtResultado.AppendText($"✗ Valor no encontrado en el arreglo\n");
            }
            rtxtResultado.AppendText($"\nComparaciones realizadas: {resultado.Comparaciones}");
        }

        private void MostrarComplejidad(BusquedaBinariaInfo resultado)
        {
            rtxtComplejidad.Clear();

            if (arreglo == null) return;

            int n = arreglo.Length;
            int peorCaso = CalcularTn(n);

            rtxtComplejidad.AppendText("═══ BÚSQUEDA BINARIA ═══\n");
            rtxtComplejidad.AppendText($"T(n) = floor(log₂(n)) + 1\n");
            rtxtComplejidad.AppendText($"T({n}) = floor(log₂({n})) + 1 = {peorCaso}\n");
            rtxtComplejidad.AppendText($"Comparaciones en esta búsqueda: {resultado.Comparaciones}\n");
            rtxtComplejidad.AppendText($"Notación BigO: O(log n)\n");
            rtxtComplejidad.AppendText($"Razón: El arreglo se divide a la mitad en cada iteración.\n");

            rtxtComplejidad.AppendText("\n═══ BÚSQUEDA LINEAL (referencia) ═══\n");
            rtxtComplejidad.AppendText($"T(n) = n (peor caso)\n");
            rtxtComplejidad.AppendText($"T({n}) = {n}\n");
            rtxtComplejidad.AppendText($"Notación BigO: O(n)\n");
            rtxtComplejidad.AppendText($"Razón: Revisa elemento por elemento hasta encontrar o recorrer todo.");
        }

        private int CalcularTn(int n)
        {
            if (n <= 0) return 0;
            int comparaciones = 0;
            int valor = n;
            while (valor > 1)
            {
                valor /= 2;
                comparaciones++;
            }
            return comparaciones + 1;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtTamano.Clear();
            txtBuscar.Clear();
            lstDatos.Items.Clear();
            rtxtPasos.Clear();
            rtxtResultado.Clear();
            rtxtComplejidad.Clear();
            arregloGenerado = false;
            arreglo = null;
        }
    }

    public class BusquedaBinariaInfo
    {
        public bool Encontrado { get; set; }
        public int Posicion { get; set; }
        public int Comparaciones { get; set; }
        public System.Collections.Generic.List<string>? Pasos { get; set; }
    }
}
