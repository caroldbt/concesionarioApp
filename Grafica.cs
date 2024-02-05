using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
namespace concesionarioApp
{
    public partial class Grafica : Form
    {
        List<Coches> listaCochesNueva;
        String tipoDeGrafica;
        public Grafica(List<Coches> coches, String tipoDeGraf)
        {
            InitializeComponent();
            listaCochesNueva = coches;
            tipoDeGrafica = tipoDeGraf;
            this.generalRd.Text = Strings.graficaGeneral;
            this.comprasRd.Text = Strings.comprasRd;
            this.marcasRd.Text = Strings.marcasRd;
            this.disponiblesRd.Text = Strings.disponiblesRd;
            this.generalRd.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            this.comprasRd.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            this.marcasRd.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            this.disponiblesRd.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            this.generalRd.Checked = true;
        }

        private void Grafica_Load(object sender, EventArgs e)
        {
        }
        private void graficaGeneral()
        {
            graficaResultado.Series.Clear();

            foreach (var series in graficaResultado.Series)
            {
                series.Points.Clear();
            }

            graficaResultado.Series.Clear();


            Chart Chart0 = new Chart();
            ChartArea ChartArea0 = new ChartArea("General");
            Chart0.ChartAreas.Add(ChartArea0);
            Series Series0 = new Series();
            Chart0.Series.Add(Series0);
            Series0.ChartArea = "General";

            List<Coches> listaCoches = listaCochesNueva;

            int enVenta = 0, comprados = 0;
            graficaResultado.Series.Add("En Venta");
            graficaResultado.Series.Add("Comprado");
            graficaResultado.Series.Add("En Alquiler");
            graficaResultado.Series.Add("En Taller");
            //graficaResultado.Series["En Venta"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            //graficaResultado.Series["Comprado"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            int enTaller = 0, enAlquiler = 0;
            for (int i = 0; i < listaCoches.Count; i++)
            {
                if (listaCoches[i].enTaller == "1")
                {
                    enTaller++;
                }
                else if (listaCoches[i].enAlquiler == "1")
                {
                    enAlquiler++;
                }
                else if (listaCoches[i].enVenta == "1")
                {

                    if (listaCoches[i].propietario != null && listaCoches[i].propietario != "null")
                    {
                        String[] cadena = listaCoches[i].propietario.Split(' ');
                        int prop = Convert.ToInt32(cadena[0]);



                        if (prop != null && prop > 0)
                        {
                            comprados = comprados + 1;
                        }
                    }
                    else
                    {
                        enVenta = enVenta + 1;
                    }
                }
            }
            if (comprados > 0)
            {
                graficaResultado.Series["Comprado"].XValueMember = "Comprados";
                graficaResultado.Series["Comprado"].Points.AddY(comprados);
            }

            if (enVenta > 0)
            {
                graficaResultado.Series["En Venta"].XValueMember = "En Venta";
                graficaResultado.Series["En Venta"].Points.AddY(enVenta);
            }


            if (enTaller > 0)
            {
                graficaResultado.Series["En Taller"].XValueMember = "En Taller";
                graficaResultado.Series["En Taller"].Points.AddY(enTaller);
            }


            if (enAlquiler > 0)
            {
                graficaResultado.Series["En Alquiler"].XValueMember = "En Alquiler";
                graficaResultado.Series["En Alquiler"].Points.AddY(enAlquiler);
            }




        }


        private void graficaVentas()
        {

            graficaResultado.Series.Clear();

            foreach (var series in graficaResultado.Series)
            {
                series.Points.Clear();
            }


            graficaResultado.Series.Clear();


            Chart Chart0 = new Chart();
            ChartArea ChartArea0 = new ChartArea("Ventas");
            Chart0.ChartAreas.Add(ChartArea0);
            Series Series0 = new Series();
            Chart0.Series.Add(Series0);
            Series0.ChartArea = "Ventas";

            List<string> fechas = new List<string>();
            List<Coches> vendidos = new List<Coches>();
            List<Coches> alquileres = new List<Coches>();
            List<string> fechaNueva = new List<string>();
            List<double> vendidosordenados = new List<double>();
            List<double> alquilerOrdenados = new List<double>();
            List<Coches> listaCoches = listaCochesNueva;


            listaCoches.Sort(delegate (Coches x, Coches y)
            {
                if (x.fechaAdquisicion == null && y.fechaAdquisicion == null) return 0;
                else if (x.fechaAdquisicion == null) return -1;
                else if (y.fechaAdquisicion == null) return 1;
                else return x.fechaAdquisicion.CompareTo(y.fechaAdquisicion);
            });


            for (int i = 0; i < listaCoches.Count; i++)
            {
                fechas.Add(listaCoches[i].fechaAdquisicion);
                if (listaCoches[i].enVenta == "1")
                {
                    vendidos.Add(listaCoches[i]);
                }
                else if (listaCoches[i].enAlquiler == "1")
                {
                    alquileres.Add(listaCoches[i]);
                }
            }
            double suma = 0;

            double sumaAlquiler = 0;

            for (int i = 0; i < fechas.Count; i++)
            {
                suma = 0;
                for (int j = 0; j < vendidos.Count; j++)
                {
                    if (vendidos[j].fechaAdquisicion == fechas[i])
                    {

                        if (vendidos[j].propietario != null && vendidos[j].propietario != "null")
                        {
                            String[] cadena = vendidos[j].propietario.Split(' ');
                            int propietario = Convert.ToInt32(cadena[0]);
                            if (propietario > 0)
                            {
                                suma = suma + Convert.ToDouble(vendidos[j].precioCompra);

                            }
                        }

                        vendidos.RemoveAt(j);

                    }

                }


                for (int j = 0; j < alquileres.Count; j++)
                {
                    if (alquileres[j].fechaAdquisicion == fechas[i])
                    {

                        if (alquileres[j].propietario != null && alquileres[j].propietario != "null")
                        {
                            String[] cadena = alquileres[j].propietario.Split(' ');
                            int propietario = Convert.ToInt32(cadena[0]);
                            if (propietario > 0)
                            {
                                sumaAlquiler = sumaAlquiler + Convert.ToDouble(alquileres[j].precioCompra);

                            }
                        }

                        alquileres.RemoveAt(j);

                    }

                }


                if (fechaNueva.Contains(fechas[i]) == false)
                {
                    vendidosordenados.Add(suma);
                    alquilerOrdenados.Add(sumaAlquiler);
                    fechaNueva.Add(fechas[i]);
                }
                else
                {
                    fechas.RemoveAt(i);
                    i = 0;
                }


            }
            int enVenta = 0, comprados = 0;
            graficaResultado.Series.Add("Vendidos");
            graficaResultado.Series["Vendidos"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            graficaResultado.Series.Add("Alquilados");
            graficaResultado.Series["Alquilados"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            graficaResultado.Series["Alquilados"].Color = Color.Red;

            graficaResultado.Series["Alquilados"].BorderWidth = 4;
            graficaResultado.Series["Vendidos"].BorderWidth = 4;
            //graficaResultado.Series["Comprado"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            int enTaller = 0, enAlquiler = 0;


            for (int i = 0; i < vendidosordenados.Count; i++)
            {
                graficaResultado.Series["Vendidos"].Points.AddXY(fechaNueva[i], vendidosordenados[i]);

            }

            for (int i = 0; i < alquilerOrdenados.Count; i++)
            {
                graficaResultado.Series["Alquilados"].Points.AddXY(fechaNueva[i], alquilerOrdenados[i]);

            }

        }



        private void graficaDisponibilidades()
        {

            graficaResultado.Series.Clear();

            foreach (var series in graficaResultado.Series)
            {
                series.Points.Clear();
            }
            this.graficaResultado.Titles.Clear();


            graficaResultado.Series.Clear();


            Chart Chart0 = new Chart();
            ChartArea ChartArea0 = new ChartArea("Disponibles");
            Chart0.ChartAreas.Add(ChartArea0);
            Series Series0 = new Series();
            Chart0.Series.Add(Series0);
            Series0.ChartArea = "Disponibles";

            this.graficaResultado.Titles.Add("Disponibles");
            List<Coches> listaCoches = listaCochesNueva;



            listaCoches.Sort(delegate (Coches x, Coches y)
            {
                if (x.fechaAdquisicion == null && y.fechaAdquisicion == null) return 0;
                else if (x.fechaAdquisicion == null) return -1;
                else if (y.fechaAdquisicion == null) return 1;
                else return x.fechaAdquisicion.CompareTo(y.fechaAdquisicion);
            });
            int posibleCompra = 0, posibleAlquiler = 0, vendidos = 0, alquilados = 0;

            for (int i = 0; i < listaCoches.Count; i++)
            {
                if (listaCoches[i].enVenta == "1")
                {
                    if (listaCoches[i].propietario != null && listaCoches[i].propietario != "null")
                    {
                        String[] cadena = listaCoches[i].propietario.Split(' ');
                        int propietario = Convert.ToInt32(cadena[0]);
                        if (propietario > 0)
                        {
                            vendidos = vendidos + 1;
                        }
                        else
                        {
                            posibleCompra = posibleCompra + 1;
                        }
                    }
                    else
                    {
                        posibleCompra = posibleCompra + 1;
                    }
                }
                else if (listaCoches[i].enAlquiler == "1")
                {
                    if (listaCoches[i].propietario != null && listaCoches[i].propietario != "null")
                    {
                        String[] cadena = listaCoches[i].propietario.Split(' ');
                        int propietario = Convert.ToInt32(cadena[0]);
                        if (propietario > 0)
                        {
                            alquilados = alquilados + 1;
                        }
                        else
                        {
                            posibleAlquiler = posibleAlquiler + 1;
                        }
                    }
                    else
                    {
                        posibleAlquiler = posibleAlquiler + 1;
                    }
                }
            }

            // int enVenta = 0, comprados = 0;
            graficaResultado.Series.Add("Posibles_Ventas");
            // graficaResultado.Series["Vendidos"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            graficaResultado.Series.Add("Posibles_Alquileres");
            //graficaResultado.Series["Alquilados"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            graficaResultado.Series["Posibles_Alquileres"].Color = Color.Red;
            //graficaResultado.Series["Comprado"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;



            graficaResultado.Series.Add("Vendidos");
            //graficaResultado.Series["Alquilados"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            graficaResultado.Series["Vendidos"].Color = Color.Green;



            graficaResultado.Series.Add("Alquilados");
            //graficaResultado.Series["Alquilados"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            graficaResultado.Series["Alquilados"].Color = Color.Orange;
            int enTaller = 0, enAlquiler = 0;



            /*
             
             
            for (int i = 0; i <= posibleAlquiler; i++)
            {
                graficaResultado.Series["Posibles_Alquileres"].Points.AddXY(1, i);

                // graficaResultado.Series["Vendidos"].Points.AddXY(8, i);

            }
            for (int i = 0; i <= alquilados; i++)
            {
                graficaResultado.Series["Alquilados"].Points.AddXY(2, i);

            }

            for (int i = 0; i <= posibleCompra; i++)
            {
                graficaResultado.Series["Posibles_Ventas"].Points.AddXY(3, i);

            }

            for (int i = 0; i <= vendidos; i++)
            {
                graficaResultado.Series["Vendidos"].Points.AddXY(4, i);

            }

             
             */

            graficaResultado.Series["Posibles_Alquileres"].Points.AddY(posibleAlquiler);
            graficaResultado.Series["Alquilados"].Points.AddY(alquilados);
            graficaResultado.Series["Posibles_Ventas"].Points.AddY(posibleCompra);
            graficaResultado.Series["Vendidos"].Points.AddY(vendidos);



        }






        private void graficaMarcas()
        {
            graficaResultado.Series.Clear();

            foreach (var series in graficaResultado.Series)
            {
                series.Points.Clear();
            }

            graficaResultado.Series.Clear();


            Chart Chart0 = new Chart();
            ChartArea ChartArea0 = new ChartArea("Marcas");
            Chart0.ChartAreas.Add(ChartArea0);
            Series Series0 = new Series();
            Chart0.Series.Add(Series0);
            Series0.ChartArea = "Marcas";

            this.graficaResultado.Titles.Clear();
            this.graficaResultado.Titles.Add("Marcas");

            List<string> listaMarcas = new List<string>();
            List<int> numCochesMarca = new List<int>();
            List<Coches> listaCoches = listaCochesNueva;







            /*
            var chartArea = chart1.ChartAreas[series.ChartArea];

            // set view range to [0,max]
            chartArea.AxisX.Minimum = 0;
            chartArea.AxisX.Maximum = valuesArray.Length;

            // enable autoscroll
            chartArea.CursorX.AutoScroll = true;
            */
            listaCoches.Sort(delegate (Coches x, Coches y)
            {
                if (x.marca == null && y.marca == null) return 0;
                else if (x.marca == null) return -1;
                else if (y.marca == null) return 1;
                else return x.marca.CompareTo(y.marca);
            });
            int posibleCompra = 0, posibleAlquiler = 0, vendidos = 0, alquilados = 0;

            for (int i = 0; i < listaCoches.Count; i++)
            {
                if (listaMarcas.Contains(listaCoches[i].marca) == false)
                {
                    listaMarcas.Add(listaCoches[i].marca);
                }
            }
            int suma = 0;
            for (int i = 0; i < listaMarcas.Count; i++)
            {
                suma = 0;
                for (int j = 0; j < listaCoches.Count; j++)
                {
                    if (listaMarcas[i].Equals(listaCoches[j].marca))
                    {
                        suma = suma + 1;
                    }
                }
                numCochesMarca.Add(suma);
            }



            for (int i = 0; i < listaMarcas.Count; i++)
            {
                // Add series.
                Series series = this.graficaResultado.Series.Add(listaMarcas[i]);


                //  graficaResultado.Series[listaMarcas[i]].XValueMember = listaMarcas[i];
                graficaResultado.Series[listaMarcas[i]].YValueMembers = "Cantidad";

                //                graficaResultado.Series[listaMarcas[i]].Points.AddXY(listaMarcas[i],numCochesMarca[i]);

                graficaResultado.Series[listaMarcas[i]].Points.AddY(numCochesMarca[i]);
                //    graficaResultado.Series[listaMarcas[i]].AxisLabel = listaMarcas[i];
                //   graficaResultado.Series[listaMarcas[i]].Points[i].LegendText = listaMarcas[i];

            }



        }





        /*

                 private void graficaVentas()
        {

            List<string> fechas = new List<string>();
            List<Coches> vendidos = new List<Coches>();
            List<Coches> alquilar = new List<Coches>();
            List<string> fechaNueva = new List<string>();
            List<double> vendidosordenados = new List<double>();

            listaCoches.Sort(delegate (Coches x, Coches y)
            {
                if (x.fechaAdquisicion == null && y.fechaAdquisicion == null) return 0;
                else if (x.fechaAdquisicion == null) return -1;
                else if (y.fechaAdquisicion == null) return 1;
                else return x.fechaAdquisicion.CompareTo(y.fechaAdquisicion);
            });


            for (int i = 0; i < listaCoches.Count; i++)
            {
                fechas.Add(listaCoches[i].fechaAdquisicion);
                vendidos.Add(listaCoches[i]);
            }
            double suma = 0;
            for (int i = 0; i < fechas.Count; i++)
            {
                suma = 0;
                for (int j = 0; j < vendidos.Count; j++)
                {
                    if (vendidos[j].fechaAdquisicion == fechas[i])
                    {

                        if (vendidos[j].propietario != null && vendidos[j].propietario != "null")
                        {
                            String[] cadena = vendidos[j].propietario.Split(' ');
                            int propietario = Convert.ToInt32(cadena[0]);
                            if (propietario > 0)
                            {
                                suma = suma + Convert.ToDouble(vendidos[j].precioCompra);

                            }
                        }

                        vendidos.RemoveAt(j);

                    }

                }

                if (fechaNueva.Contains(fechas[i]) == false)
                {
                    vendidosordenados.Add(suma);
                    fechaNueva.Add(fechas[i]);
                }
                else
                {
                    fechas.RemoveAt(i);
                }


            }
            graficaResultado.Series.Add("Ventas");
            int enVenta = 0, comprados = 0;
            graficaResultado.Series["Ventas"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            //graficaResultado.Series["Comprado"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            int enTaller = 0, enAlquiler = 0;


            for (int i = 0; i < vendidosordenados.Count; i++)
            {
                graficaResultado.Series["Ventas"].Points.AddXY(fechaNueva[i], vendidosordenados[i]);

            }

        }


         */
        private void graficaResultado_Click(object sender, EventArgs e)
        {

        }


        void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if (rb.Checked == true)
            {
                if (rb.Name.Equals("generalRd"))
                {
                    graficaResultado.Series.Clear();
                    graficaGeneral();
                    return;
                }
                else if (rb.Name.Equals("comprasRd"))
                {
                    graficaResultado.Series.Clear();

                    graficaVentas();
                    return;
                }
                else if (rb.Name.Equals("disponiblesRd"))
                {
                    graficaResultado.Series.Clear();

                    graficaDisponibilidades();

                    return;
                }
                else if (rb.Name.Equals("marcasRd"))
                {

                    graficaResultado.Series.Clear();

                    graficaMarcas();

                    //tablaCoche("&filtro=enTaller");
                    return;
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
