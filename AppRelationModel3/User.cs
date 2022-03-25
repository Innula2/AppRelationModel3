using System;
using System.Collections.Generic;
using System.Text;

namespace AppRelationModel3
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CompanyInfoKey { get; set; }
        public Company Company { get; set; }
    }

}
