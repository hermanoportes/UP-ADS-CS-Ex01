using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Professor
    {
        private int iD;
        private string nome;

        public int ID { get => iD; set => iD = value; }
        public string Nome { get => nome; set => nome = value; }
    }
}
