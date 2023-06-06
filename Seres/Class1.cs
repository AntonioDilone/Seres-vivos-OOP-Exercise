using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Seres
{
    internal class Ser
    {
        public string nombre { get; set; }

        public int edad { get; set; }

        public double peso { get; set; }

        public string tipo { get; set; }

        public virtual void Respirar()
        {
            Console.WriteLine("El ser vivo esta respirando");
        }
        public virtual void Alimentarse() {
            Console.WriteLine("El ser vivo se esta alimentando");
        }
    }

    internal class humano : Ser {
        public string cedula { get; set; }

        public void Hablar() {
            Console.WriteLine("El humano esta hablando");
        }

        public override void Alimentarse()
        {
            Console.WriteLine("El humano se esta alimentando");
        }

    }

    internal class planta : Ser
    {
        public int petalos { get; set; }

        public void Fotosintesis() {
            Console.WriteLine("La planta hace fotosintesis");
        }
    }

    internal class  animal : Ser {
        public string tipoRepro { get; set; }

        public void emitirSonido() {
            Console.WriteLine("El animal emite un sonido");
        }

    }

}
