using Domain;
using Pattern.Prototype.Modelos;
using System;

namespace Pattern
{
    public class PrototypePattern : IPattern
    {
        public void Main()
        {
            var persona1 = new Persona()
            {
                Name = "Andy",
                Age = 29,
                BirthDate = DateTime.Now,
                IdInfo = new IdInfo(1000)
            };

            var persona2 = persona1.ClonacionSuperficial();
            var persona3 = persona1.ClonacionProfunda();

            Console.WriteLine("Persona1 => Name: {0} , Edad: {1} , Cumple: {2} , IdInfo: {3}", persona1.Name, persona1.Age, persona1.BirthDate, persona1.IdInfo.Idinfo);
            Console.WriteLine("Persona2 => Name: {0} , Edad: {1} , Cumple: {2} , IdInfo: {3}", persona2.Name, persona2.Age, persona2.BirthDate, persona2.IdInfo.Idinfo);
            Console.WriteLine("Persona3 => Name: {0} , Edad: {1} , Cumple: {2} , IdInfo: {3}", persona3.Name, persona3.Age, persona3.BirthDate, persona3.IdInfo.Idinfo);

            persona1.Name = "Carlos";
            persona1.Age = 30;
            persona1.BirthDate = DateTime.Now;
            persona1.IdInfo.Idinfo = 10001;

            Console.WriteLine("Persona1 => Name: {0} , Edad: {1} , Cumple: {2} , IdInfo: {3}", persona1.Name, persona1.Age, persona1.BirthDate, persona1.IdInfo.Idinfo);
            Console.WriteLine("Persona2 => Name: {0} , Edad: {1} , Cumple: {2} , IdInfo: {3}", persona2.Name, persona2.Age, persona2.BirthDate, persona2.IdInfo.Idinfo);
            Console.WriteLine("Persona3 => Name: {0} , Edad: {1} , Cumple: {2} , IdInfo: {3}", persona3.Name, persona3.Age, persona3.BirthDate, persona3.IdInfo.Idinfo);

        }
    }
}
