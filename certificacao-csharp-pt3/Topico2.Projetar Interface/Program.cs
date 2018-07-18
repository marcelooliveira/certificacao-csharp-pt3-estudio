using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topico2
{
    class Program
    {
        static void Main(string[] args)
        {
            Televisao televisao = new Televisao();
            Abajur abajur = new Abajur();
            Lanterna lanterna = new Lanterna();
            Radio radio = new Radio();
        }
    }

    class Televisao
    {
        public event EventHandler Ligou;
        public event EventHandler Desligou;

        public double FrequenciaDoCanal { get; set; }

        public void Desligar()
        {
        }

        public void Ligar()
        {
            if (Ligou != null)
            {
                Ligou(this, new EventArgs());
            }
        }
    }

    class Abajur
    {
        public int PotenciaDaLampada { get; set; }

        public event EventHandler Ligou;
        public event EventHandler Desligou;

        public void Desligar()
        {
        }

        public void Ligar()
        {
        }
    }

    class Lanterna
    {
        public double PotenciaDaLampada { get; set; }

        public event EventHandler Ligou;
        public event EventHandler Desligou;

        public void Desligar()
        {
        }

        public void Ligar()
        {
        }
    }

    class Radio
    {
        public event EventHandler Ligou;
        public event EventHandler Desligou;

        public double FrequenciaDaEstacao { get; set; }

        public void Desligar()
        {
        }

        public void Ligar()
        {
        }
    }

}

