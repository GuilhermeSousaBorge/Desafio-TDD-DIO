using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Class
{
    public class CalculadoraImp
    {
        private List<string> _historico;
        public CalculadoraImp()
        {
            _historico = new List<string>();
        }
        public int Somar(int value_1, int value_2)
        {
            _historico.Insert(0, $"{value_1} + {value_2} = {value_1 + value_2}");
            return value_1 + value_2;
        }
        public int Subtrair(int value_1, int value_2)
        {
            _historico.Insert(0, $"{value_1} - {value_2} = {value_1 - value_2}");
            return value_1 - value_2;
        }
        public int Multiplicar(int value_1, int value_2)
        {
            _historico.Insert(0, $"{value_1} * {value_2} = {value_1 * value_2}");
            return value_1 * value_2;
        }
        public int dividir(int value_1, int value_2)
        {
            _historico.Insert(0, $"{value_1} / {value_2} = {value_1 / value_2}");
            return value_1 / value_2;
        }
        public List<string> Historico()
        {
            _historico.RemoveRange(3, _historico.Count - 3);
            return _historico;
        }
    }
}