using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp6
{
    public class Auto
    {


        private string marca;
        private string modelo;
        private string version;
        private int stock;
        private bool estado;

        public string Marca { 
            get { return marca; } 
            set { marca = value; } 
        }
        public string Modelo
        {
            get { return modelo; }
            set { 
                if(this.marca == "ford")
                {
                    if (value == "fiesta")
                        modelo = value;
                    else
                        throw new Exception();
                }
                else
                {
                    modelo = value;
                }
                    
            }
        }
        public string Version //read only
        {
            get { return version; }
            
        }

        public Auto() { }
        public Auto(string marca, string modelo, string version)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.version = version;
            this.stock = 10;
        }
        public override string ToString()
        {
            return string.Format("{0} - {1} - {2}", this.Marca, this.Modelo, this.Version);
        }

        public void AgregarUnaUnidad()
        {
            this.stock = this.stock+1;
        }

        public void QuitarStock(int cantidad)
        {
            this.stock = this.stock - cantidad;
        }

        /// <summary>
        /// En caso de querer desactivar enviar false
        /// </summary>
        /// <param name="cantidad"></param>
        /// <param name="desactivar"></param>
        public void QuitarStock(int cantidad, bool desactivar)
        {
            this.stock = this.stock - cantidad;

            if (desactivar)
                estado = false;
        }

        public bool Vendido()
        {
            if (stock == 0)
                return true;
            else
                return false;

            
        }

        public void HagoAlgo()
        {
            // NO PUEDE HABER ACCESO A LA CAPA DE PRESENTACION DESDE UNA ENTIDAD
            Console.WriteLine("Hago algo");
        }

    }
}
