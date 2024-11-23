using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSerialization.Model
{
    [Serializable]
    public class Voo
    {
        public string Codigo { get; set; }
        public string Origem { get; set; }
        public string Destino { get; set; }
        public DateTime Horario { get; set; }
        public string Compania { get; set; }
        public char Operando { get; set; }

        public Voo()
        {

        }

        public Voo(string codigo, string origem, string destino, DateTime horario, string compania, char operando)
        {
            Codigo = codigo;
            Origem = origem;
            Destino = destino;
            Horario = horario;
            Compania = compania;
            Operando = operando;
        }

        public override string ToString()
        {
            return $"Voo {Codigo}: {Origem} -> {Destino} às {Horario.ToString("dd/MM/yyyy - HH:mm")}, Companhia: {Compania}, Operando: {Operando}";
        }
    }
}
