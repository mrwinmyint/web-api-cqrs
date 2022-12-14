using Assessment.Application.Interfaces.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment.Application.Users.Queries.GetUserList
{
    public class GetUsersListQuery
        : IGetUsersListQuery
    {
        private readonly IUserRepository _repository;

        public GetUsersListQuery(IUserRepository repository)
        {
            _repository = repository;
        }

        public List<UserModel> Execute()
        {
            var users = _repository.GetAll()
                .Select(p => new UserModel()
                {
                    Id = p.Id,
                    Name = p.Name,
                    Username = p.Username,
                    Address = new AddressModel() {
                        Street = p.Address.Street,
                        City = p.Address.City,  
                        Suite = p.Address.Suite,
                        Zipcode = p.Address.Zipcode,
                        Geo = new GeoModel()
                        {
                            Lat = p.Address.Geo.Lat,
                            Lng = p.Address.Geo.Lng,
                        }
                    },
                    Email = p.Email,
                    Phone = p.Phone,
                    Website = p.Website,
                    Company = new CompanyModel()
                    {
                        Name = p.Company.Name,
                        CatchPhrase = p.Company.CatchPhrase,
                        Bs = p.Company.Bs,
                    }
                });

            return users.ToList();
        }
    }
}
