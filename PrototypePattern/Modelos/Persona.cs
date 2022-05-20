using PrototypePattern.Interfaces;
using System;

namespace PrototypePattern.Modelos
{
    internal class Persona : IClonable<Persona>
    {

        //El modelo debe implementar sus métodos de clonación
        public int Age;
        public DateTime BirthDate;
        public string Name;
        public IdInfo IdInfo;

        public Persona ClonacionProfunda()
        {
            var newPersona = (Persona)this.MemberwiseClone();
            newPersona.IdInfo = new IdInfo(IdInfo.Idinfo);
            newPersona.Name = new string(Name);
            return newPersona;

        }

        public Persona ClonacionSuperficial()
        {
            return (Persona)this.MemberwiseClone();
        }
    }
}
