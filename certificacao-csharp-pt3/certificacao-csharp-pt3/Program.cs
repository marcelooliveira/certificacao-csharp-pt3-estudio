using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topico1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Funcionario funcionario = new Funcionario();
            //funcionario.salario = 1000;
            //Console.WriteLine(funcionario.salario);

            //funcionario.salario = -1200;
            //Console.WriteLine(funcionario.salario);

            //funcionario.Salario = -1200;

            //funcionario.Salario = 1000;
            //var funcionario = new Funcionario(1000);
            //Console.WriteLine(funcionario.Salario);


            var funcionario = new Funcionario(1000, 150);
            //funcionario.Descontos = 170;
            funcionario.RedefinirDescontos(190);
            Console.WriteLine(funcionario.SalarioLiquido);

            //Console.WriteLine(funcionario.SalarioMinimo);
            Console.WriteLine(Funcionario.SalarioMinimo);

            //var funcionario = new Funcionario(1000, 150);
            //Console.WriteLine(funcionario.SalarioLiquido);
            //funcionario.Descontos = 180;

            //Console.WriteLine(funcionario.SalarioMinimo);
            //Console.WriteLine(Funcionario.SalarioMinimo);





            Console.WriteLine(funcionario.PropriedadePublic);
            //Console.WriteLine(funcionario.PropriedadeProtected);
            Console.WriteLine(funcionario.PropriedadeProtectedInternal);
            Console.WriteLine(funcionario.PropriedadeInternal);
            //Console.WriteLine(funcionario.PropriedadePrivate);

            Console.ReadKey();
        }
    }

    //class Funcionario
    //{
    //    public decimal salario;
    //}


    //class Funcionario
    //{
    //    private decimal salario;

    //    public decimal Salario
    //    {
    //        get
    //        {
    //            return salario;
    //        }
    //        set
    //        {
    //            salario = value;
    //        }
    //    }
    //}



    //class Funcionario
    //{
    //    private decimal salario;

    //    public decimal Salario
    //    {
    //        get
    //        {
    //            return salario;
    //        }
    //        //set
    //        //{
    //        //    if (value < 0)
    //        //    {
    //        //        throw new ArgumentOutOfRangeException("salário não pode ser negativo");
    //        //    }
    //        //    salario = value;
    //        //}
    //    }
    //}

    //class Funcionario
    //{
    //    private readonly decimal salario;
    //    public decimal Salario
    //    {
    //        get
    //        {
    //            return salario;
    //        }
    //    }

    //    public Funcionario(decimal salario)
    //    {
    //        if (salario < 0)
    //        {
    //            throw new ArgumentOutOfRangeException("salário não pode ser negativo");
    //        }
    //        this.salario = salario;
    //    }
    //}


    //class Funcionario
    //{
    //    private decimal salario;

    //    public decimal Salario { get => salario; set => salario = value; }
    //}

    //class Funcionario
    //{
    //    public decimal Salario { get; set; }
    //}


    //class Funcionario
    //{
    //    private readonly decimal salario;
    //    public decimal Salario
    //    {
    //        get
    //        {
    //            return salario;
    //        }
    //    }
    //    public decimal Descontos { get; set; }

    //    public Funcionario(decimal salario)
    //    {
    //        if (salario < 0)
    //        {
    //            throw new ArgumentOutOfRangeException("salário não pode ser negativo");
    //        }
    //        this.salario = salario;
    //    }

    //    public Funcionario(decimal salario, decimal descontos)
    //    {
    //        if (salario < 0)
    //        {
    //            throw new ArgumentOutOfRangeException("salário não pode ser negativo");
    //        }
    //        this.salario = salario;
    //        this.Descontos = descontos;
    //    }

    //      public void RedefinirDescontos(decimal descontos)
    //      {
    //          if (salario < 0)
    //          {
    //              throw new ArgumentOutOfRangeException("descontos não podem ser negativos");
    //          }
    //          this.Descontos = descontos;
    //      }

    //    public decimal SalarioLiquido
    //    {
    //        get
    //        {
    //            return salario - Descontos;
    //        }
    //    }
    //}

    //class Funcionario
    //{
    //    private readonly decimal salario;
    //    public decimal Salario
    //    {
    //        get
    //        {
    //            return salario;
    //        }
    //    }
    //    public decimal Descontos { get; private set; }

    //    public Funcionario(decimal salario)
    //    {
    //        if (salario < 0)
    //        {
    //            throw new ArgumentOutOfRangeException("salário não pode ser negativo");
    //        }
    //        this.salario = salario;
    //    }

    //    public Funcionario(decimal salario, decimal descontos)
    //    {
    //        if (salario < 0)
    //        {
    //            throw new ArgumentOutOfRangeException("salário não pode ser negativo");
    //        }
    //        this.salario = salario;
    //        this.Descontos = descontos;
    //    }

    //    public void RedefinirDescontos(decimal descontos)
    //    {
    //        if (salario < 0)
    //        {
    //            throw new ArgumentOutOfRangeException("descontos não podem ser negativos");
    //        }
    //        this.Descontos = descontos;
    //    }

    //    public decimal SalarioLiquido
    //    {
    //        get
    //        {
    //            return salario - Descontos;
    //        }
    //    }
    //}

    public class Funcionario
    {
        private static decimal salarioMinimo = 800;
        public static decimal SalarioMinimo
        {
            get
            {
                return salarioMinimo;
            }
        }

        private readonly decimal salario;
        public decimal Salario
        {
            get
            {
                return salario;
            }
        }
        public decimal Descontos { get; private set; }

        public Funcionario(decimal salario)
        {
            if (salario < 0)
            {
                throw new ArgumentOutOfRangeException("salário não pode ser negativo");
            }
            this.salario = salario;
        }

        public Funcionario(decimal salario, decimal descontos)
        {
            if (salario < 0)
            {
                throw new ArgumentOutOfRangeException("salário não pode ser negativo");
            }
            this.salario = salario;
            this.Descontos = descontos;
        }

        public void RedefinirDescontos(decimal descontos)
        {
            if (salario < 0)
            {
                throw new ArgumentOutOfRangeException("descontos não podem ser negativos");
            }
            this.Descontos = descontos;
        }

        public decimal SalarioLiquido
        {
            get
            {
                return salario - Descontos;
            }
        }
    }
}


