using System;
using System.Collections.Generic;
using System.Text;

namespace Aula71
{
    class Estudante
    {
        //atributos
        public string Nome { get; set; }
        public string Email { get; set; }

        //construtor
        public Estudante(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        //to string
        public override string ToString()
        {
            return Nome + ", " + Email;
        }


    }
}
