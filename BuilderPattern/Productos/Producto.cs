using System.Collections.Generic;

namespace BuilderPattern.Productos
{
    class Producto
    {
        private List<string> _partes = new List<string>();

        public void Add(string parte)
        {
            this._partes.Add(parte);
        }

        public string ListaDePartes()
        {
            var str = string.Empty;

            for (int i = 0; i < this._partes.Count; i++)
            {
                str += this._partes[i] + ", ";
            }

            str = str.Remove(str.Length - 2);

            return str;
        }
    }
}
