using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment.Application.Users.Queries.GetUserList
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public AddressModel Address { get; set; }
        public string Phone { get; set; }
        public string Website { get; set; }
        public CompanyModel Company { get; set; }
    }

    public class AddressModel
    {
        public string Street { get; set; }
        public string Suite { get; set; }
        public string City { get; set; }
        public string Zipcode { get; set; }
        public GeoModel Geo;
    }

    public class GeoModel
    {
        public double Lat { get; set; }
        public double Lng { get; set; }
    }

    public class CompanyModel
    {
        public string Name { get; set; }
        public string CatchPhrase { get; set; }
        public string Bs { get; set; }
    }
}
