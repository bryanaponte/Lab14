using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Lab14
{

        public class TodoItem
        {
            [PrimaryKey, AutoIncrement]
            public int ID { get; set; }
            public int Dni { get; set; }
            public string Nombre { get; set; }
            public string Apellidos { get; set; }
            public DateTime Fecha { get; set; }
            public bool Done { get; set; }
        }

    
}
