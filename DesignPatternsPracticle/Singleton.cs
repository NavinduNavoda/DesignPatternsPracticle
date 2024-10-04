using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPracticle
{
    class DBConnection
    {
        private static DBConnection connection;
        private DBConnection()
        {
            Console.WriteLine("DB Connection Created");
        }

        public static DBConnection GetCurrInst() {
            if (connection == null) {
                connection = new DBConnection();
            }
            return connection;
        }
    }
}
