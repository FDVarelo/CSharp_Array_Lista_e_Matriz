using System;

namespace Curso_CSharp_Seção_6
{
    internal class Pensionato
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Room { get; set; }


        public override string ToString()
        {
            return Room 
                +": "
                +Name
                +", "
                +Email;
        }
    }
}
