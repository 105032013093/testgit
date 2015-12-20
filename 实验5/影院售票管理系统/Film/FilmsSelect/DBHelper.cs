using System;
using System.Collections.Generic;
using System.Text;
using System.Data .SqlClient ;

namespace FilmsSelect
{
    class DBHelper
    {
        public static SqlConnection conn = new SqlConnection
            ("Data Source=.;Initial Catalog=Films;Integrated Security=true");
    }
}
