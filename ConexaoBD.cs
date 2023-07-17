using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeTickets
{
    internal class ConexaoBD
    {
        public string dbconection()
        {
            string conn = "SERVER=localhost;USER=root;PASSWORD='';DATABASE =tickets";
            return conn;
        }
    }
}
