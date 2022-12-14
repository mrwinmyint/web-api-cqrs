using Assessment.Domain.Albums;
using Assessment.Domain.Posts;
using Assessment.Domain.Users;
using System;
using System.Data.Entity;
using System.Linq;

namespace Assessment.Persistence.Shared
{
    public class DatabaseInitializer 
        : CreateDatabaseIfNotExists<DatabaseContext>
    {
        protected override void Seed(DatabaseContext database)
        {
            base.Seed(database);

            CreateGeos(database);

            CreateAddresses(database);

            CreateCompanies(database);

            CreateUsers(database);

            CreateAlbums(database);

            CreatePosts(database);
        }

        private void CreateGeos(DatabaseContext database)
        {
            database.Geoes.Add(new Geo() {  Lat = -37.3159, Lng = 81.1496 });

            database.Geoes.Add(new Geo() {  Lat = -43.9509, Lng = -34.4618 });

            database.Geoes.Add(new Geo() {  Lat = -68.6102, Lng = -47.0653 });

            database.Geoes.Add(new Geo() {  Lat = 29.4572, Lng = -164.2990 });

            database.Geoes.Add(new Geo() {  Lat = -31.8129, Lng = 62.5342 });

            database.Geoes.Add(new Geo() {  Lat = -71.4197, Lng = 71.7478 });

            database.Geoes.Add(new Geo() {  Lat = 24.8918, Lng = 21.8984 });

            database.Geoes.Add(new Geo() {  Lat = -14.3990, Lng = -120.7677 });

            database.Geoes.Add(new Geo() {  Lat = 24.6463, Lng = -168.8889 });

            database.Geoes.Add(new Geo() {  Lat = -38.2386, Lng = 57.2232 });

            database.SaveChanges();
        }

        private void CreateAddresses(DatabaseContext database)
        {
            var geos = database.Geoes.ToList();
            database.Addresses.Add(new Address() { Street = "Kulas Light", Suite = "Apt. 556", City = "Gwenborough", Zipcode = "92998-3874", Geo = geos[0] });

            database.Addresses.Add(new Address() { Street = "Victor Plains", Suite = "Suite 879", City = "Wisokyburgh", Zipcode = "90566-7771", Geo = geos[1] });

            database.Addresses.Add(new Address() { Street = "Douglas Extension", Suite = "Suite 847", City = "McKenziehaven", Zipcode = "59590-4157", Geo = geos[2] });

            database.Addresses.Add(new Address() { Street = "Hoeger Mall", Suite = "Apt. 692", City = "South Elvis", Zipcode = "53919-4257", Geo = geos[3] });

            database.Addresses.Add(new Address() { Street = "Skiles Walks", Suite = "Suite 351", City = "Roscoeview", Zipcode = "33263", Geo = geos[4] });

            database.Addresses.Add(new Address() { Street = "Norberto Crossing", Suite = "Apt. 950", City = "South Christy", Zipcode = "23505-1337", Geo = geos[5] });

            database.Addresses.Add(new Address() { Street = "Rex Trail", Suite = "Suite 280", City = "Howemouth", Zipcode = "58804-1099", Geo = geos[6] });

            database.Addresses.Add(new Address() { Street = "Ellsworth Summit", Suite = "Suite 729", City = "Aliyaview", Zipcode = "45169", Geo = geos[7] });

            database.Addresses.Add(new Address() { Street = "Dayna Park", Suite = "Suite 449", City = "Bartholomebury", Zipcode = "76495-3109", Geo = geos[8] });

            database.Addresses.Add(new Address() { Street = "Kattie Turnpike", Suite = "Suite 198", City = "Lebsackbury", Zipcode = "31428-2261", Geo = geos[9] });

            database.SaveChanges();
        }

        private void CreateCompanies(DatabaseContext database)
        {
            database.Companies.Add(new Company() { Name = "Romaguera-Crona", CatchPhrase = "Multi-layered client-server neural-net", Bs = "harness real-time e-markets" });

            database.Companies.Add(new Company() { Name = "Deckow-Crist", CatchPhrase = "Proactive didactic contingency", Bs = "synergize scalable supply-chains" });

            database.Companies.Add(new Company() { Name = "Romaguera-Jacobson", CatchPhrase = "Face to face bifurcated interface", Bs = "e-enable strategic applications" });

            database.Companies.Add(new Company() { Name = "Robel-Corkery", CatchPhrase = "Multi-tiered zero tolerance productivity", Bs = "transition cutting-edge web services" });

            database.Companies.Add(new Company() { Name = "Keebler LLC", CatchPhrase = "User-centric fault-tolerant solution", Bs = "revolutionize end-to-end systems" });

            database.Companies.Add(new Company() { Name = "Considine-Lockman", CatchPhrase = "Synchronised bottom-line interface", Bs = "e-enable innovative applications" });

            database.Companies.Add(new Company() { Name = "Johns Group", CatchPhrase = "Configurable multimedia task-force", Bs = "generate enterprise e-tailers" });

            database.Companies.Add(new Company() { Name = "Abernathy Group", CatchPhrase = "Implemented secondary concept", Bs = "e-enable extensible e-tailers" });

            database.Companies.Add(new Company() { Name = "Yost and Sons", CatchPhrase = "Switchable contextually-based project", Bs = "aggregate real-time technologies" });

            database.Companies.Add(new Company() { Name = "Hoeger LLC", CatchPhrase = "Centralized empowering task-force", Bs = "target end-to-end models" });

            database.SaveChanges();
        }

        private void CreateUsers(DatabaseContext database)
        {
            var addresses = database.Addresses.ToList();
            var companies = database.Companies.ToList();
            database.Users.Add(new User() { Name = "Leanne Graham", Username = "Bret", Email = "Sincere@april.biz", Phone = "1-770-736-8031 x56442", Website = "hildegard.org", Company = companies[0], Address = addresses[0] });

            database.Users.Add(new User() { Name = "Ervin Howell", Username = "Antonette", Email = "Shanna@melissa.tv", Phone = "010-692-6593 x09125", Website = "anastasia.net", Company = companies[1], Address = addresses[1] });

            database.Users.Add(new User() { Name = "Clementine Bauch", Username = "Samantha", Email = "Nathan@yesenia.net", Phone = "1-463-123-4447", Website = "ramiro.info", Company = companies[2], Address = addresses[2] });

            database.Users.Add(new User() { Name = "Patricia Lebsack", Username = "Karianne", Email = "Julianne.OConner@kory.org", Phone = "493-170-9623 x156", Website = "kale.biz", Company = companies[3], Address = addresses[3] });

            database.Users.Add(new User() { Name = "Chelsey Dietrich", Username = "Kamren", Email = "Lucio_Hettinger@annie.ca", Phone = "(254)954-1289", Website = "demarco.info", Company = companies[4], Address = addresses[4] });

            database.Users.Add(new User() { Name = "Mrs. Dennis Schulist", Username = "Leopoldo_Corkery", Email = "Karley_Dach@jasper.info", Phone = "1-477-935-8478 x6430", Website = "ola.org", Company = companies[5], Address = addresses[5] });

            database.Users.Add(new User() { Name = "Kurtis Weissnat", Username = "Elwyn.Skiles", Email = "Telly.Hoeger@billy.biz", Phone = "210.067.6132", Website = "elvis.io", Company = companies[6], Address = addresses[6] });

            database.Users.Add(new User() { Name = "Nicholas Runolfsdottir V", Username = "Maxime_Nienow", Email = "Sherwood@rosamond.me", Phone = "586.493.6943 x140", Website = "jacynthe.com", Company = companies[7], Address = addresses[7] });

            database.Users.Add(new User() { Name = "Glenna Reichert", Username = "Delphine", Email = "Chaim_McDermott@dana.io", Phone = "(775)976-6794 x41206", Website = "conrad.com", Company = companies[8], Address = addresses[8] });

            database.Users.Add(new User() { Name = "Clementina DuBuque", Username = "Moriah.Stanton", Email = "Rey.Padberg@karina.biz", Phone = "024-648-3804", Website = "ambrose.net", Company = companies[9], Address = addresses[9] });            

            database.SaveChanges();
        }

        private void CreateAlbums(DatabaseContext database)
        {
            var users = database.Users.ToList();

            database.Albums.Add(new Album() { Title = "quidem molestiae enim", User = users[0] });
            database.Albums.Add(new Album() { Title = "sunt qui excepturi placeat culpa", User = users[0] });
            database.Albums.Add(new Album() { Title = "omnis laborum odio", User = users[0] });
            database.Albums.Add(new Album() { Title = "non esse culpa molestiae omnis sed optio", User = users[0] });
            database.Albums.Add(new Album() { Title = "eaque aut omnis a", User = users[0] });
            database.Albums.Add(new Album() { Title = "natus impedit quibusdam illo est", User = users[0] });
            database.Albums.Add(new Album() { Title = "quibusdam autem aliquid et et quia", User = users[0] });
            database.Albums.Add(new Album() { Title = "qui fuga est a eum", User = users[0] });
            database.Albums.Add(new Album() { Title = "saepe unde necessitatibus rem", User = users[0] });
            database.Albums.Add(new Album() { Title = "distinctio laborum qui", User = users[0] });

            database.Albums.Add(new Album() { Title = "quam nostrum impedit mollitia quod et dolor", User = users[1] });
            database.Albums.Add(new Album() { Title = "consequatur autem doloribus natus consectetur", User = users[1] });
            database.Albums.Add(new Album() { Title = "ab rerum non rerum consequatur ut ea unde", User = users[1] });
            database.Albums.Add(new Album() { Title = "ducimus molestias eos animi atque nihil", User = users[1] });
            database.Albums.Add(new Album() { Title = "ut pariatur rerum ipsum natus repellendus praesentium", User = users[1] });
            database.Albums.Add(new Album() { Title = "voluptatem aut maxime inventore autem magnam atque repellat", User = users[1] });
            database.Albums.Add(new Album() { Title = "aut minima voluptatem ut velit", User = users[1] });
            database.Albums.Add(new Album() { Title = "nesciunt quia et doloremque", User = users[1] });
            database.Albums.Add(new Album() { Title = "velit pariatur quaerat similique libero omnis quia", User = users[1] });
            database.Albums.Add(new Album() { Title = "voluptas rerum iure ut enim", User = users[1] });

            database.Albums.Add(new Album() { Title = "repudiandae voluptatem optio est consequatur rem in temporibus et", User = users[2] });
            database.Albums.Add(new Album() { Title = "et rem non provident vel ut", User = users[2] });
            database.Albums.Add(new Album() { Title = "incidunt quisquam hic adipisci sequi", User = users[2] });
            database.Albums.Add(new Album() { Title = "dolores ut et facere placeat", User = users[2] });
            database.Albums.Add(new Album() { Title = "vero maxime id possimus sunt neque et consequatur", User = users[2] });
            database.Albums.Add(new Album() { Title = "quibusdam saepe ipsa vel harum", User = users[2] });
            database.Albums.Add(new Album() { Title = "id non nostrum expedita", User = users[2] });
            database.Albums.Add(new Album() { Title = "omnis neque exercitationem sed dolor atque maxime aut cum", User = users[2] });
            database.Albums.Add(new Album() { Title = "inventore ut quasi magnam itaque est fugit", User = users[2] });
            database.Albums.Add(new Album() { Title = "tempora assumenda et similique odit distinctio error", User = users[2] });

            database.Albums.Add(new Album() { Title = "adipisci laborum fuga laboriosam", User = users[3] });
            database.Albums.Add(new Album() { Title = "reiciendis dolores a ut qui debitis non quo labore", User = users[3] });
            database.Albums.Add(new Album() { Title = "iste eos nostrum", User = users[3] });
            database.Albums.Add(new Album() { Title = "cumque voluptatibus rerum architecto blanditiis", User = users[3] });
            database.Albums.Add(new Album() { Title = "et impedit nisi quae magni necessitatibus sed aut pariatur", User = users[3] });
            database.Albums.Add(new Album() { Title = "nihil cupiditate voluptate neque", User = users[3] });
            database.Albums.Add(new Album() { Title = "est placeat dicta ut nisi rerum iste", User = users[3] });
            database.Albums.Add(new Album() { Title = "unde a sequi id", User = users[3] });
            database.Albums.Add(new Album() { Title = "ratione porro illum labore eum aperiam sed", User = users[3] });
            database.Albums.Add(new Album() { Title = "voluptas neque et sint aut quo odit", User = users[3] });

            database.Albums.Add(new Album() { Title = "ea voluptates maiores eos accusantium officiis tempore mollitia consequatur", User = users[4] });
            database.Albums.Add(new Album() { Title = "tenetur explicabo ea", User = users[4] });
            database.Albums.Add(new Album() { Title = "aperiam doloremque nihil", User = users[4] });
            database.Albums.Add(new Album() { Title = "sapiente cum numquam officia consequatur vel natus quos suscipit", User = users[4] });
            database.Albums.Add(new Album() { Title = "tenetur quos ea unde est enim corrupti qui", User = users[4] });
            database.Albums.Add(new Album() { Title = "molestiae voluptate non", User = users[4] });
            database.Albums.Add(new Album() { Title = "temporibus molestiae aut", User = users[4] });
            database.Albums.Add(new Album() { Title = "modi consequatur culpa aut quam soluta alias perspiciatis laudantium", User = users[4] });
            database.Albums.Add(new Album() { Title = "ut aut vero repudiandae voluptas ullam voluptas at consequatur", User = users[4] });
            database.Albums.Add(new Album() { Title = "sed qui sed quas sit ducimus dolor", User = users[4] });

            database.Albums.Add(new Album() { Title = "odit laboriosam sint quia cupiditate animi quis", User = users[5] });
            database.Albums.Add(new Album() { Title = "necessitatibus quas et sunt at voluptatem", User = users[5] });
            database.Albums.Add(new Album() { Title = "est vel sequi voluptatem nemo quam molestiae modi enim", User = users[5] });
            database.Albums.Add(new Album() { Title = "aut non illo amet perferendis", User = users[5] });
            database.Albums.Add(new Album() { Title = "qui culpa itaque omnis in nesciunt architecto error", User = users[5] });
            database.Albums.Add(new Album() { Title = "omnis qui maiores tempora officiis omnis rerum sed repellat", User = users[5] });
            database.Albums.Add(new Album() { Title = "libero excepturi voluptatem est architecto quae voluptatum officia tempora", User = users[5] });
            database.Albums.Add(new Album() { Title = "nulla illo consequatur aspernatur veritatis aut error delectus et", User = users[5] });
            database.Albums.Add(new Album() { Title = "eligendi similique provident nihil", User = users[5] });
            database.Albums.Add(new Album() { Title = "omnis mollitia sunt aliquid eum consequatur fugit minus laudantium", User = users[5] });

            database.Albums.Add(new Album() { Title = "delectus iusto et", User = users[6] });
            database.Albums.Add(new Album() { Title = "eos ea non recusandae iste ut quasi", User = users[6] });
            database.Albums.Add(new Album() { Title = "velit est quam", User = users[6] });
            database.Albums.Add(new Album() { Title = "autem voluptatem amet iure quae", User = users[6] });
            database.Albums.Add(new Album() { Title = "voluptates delectus iure iste qui", User = users[6] });
            database.Albums.Add(new Album() { Title = "velit sed quia dolor dolores delectus", User = users[6] });
            database.Albums.Add(new Album() { Title = "ad voluptas nostrum et nihil", User = users[6] });
            database.Albums.Add(new Album() { Title = "qui quasi nihil aut voluptatum sit dolore minima", User = users[6] });
            database.Albums.Add(new Album() { Title = "qui aut est", User = users[6] });
            database.Albums.Add(new Album() { Title = "et deleniti unde", User = users[6] });

            database.Albums.Add(new Album() { Title = "et vel corporis", User = users[7] });
            database.Albums.Add(new Album() { Title = "unde exercitationem ut", User = users[7] });
            database.Albums.Add(new Album() { Title = "quos omnis officia", User = users[7] });
            database.Albums.Add(new Album() { Title = "quia est eius vitae dolor", User = users[7] });
            database.Albums.Add(new Album() { Title = "aut quia expedita non", User = users[7] });
            database.Albums.Add(new Album() { Title = "dolorem magnam facere itaque ut reprehenderit tenetur corrupti", User = users[7] });
            database.Albums.Add(new Album() { Title = "cupiditate sapiente maiores iusto ducimus cum excepturi veritatis quia", User = users[7] });
            database.Albums.Add(new Album() { Title = "est minima eius possimus ea ratione velit et", User = users[7] });
            database.Albums.Add(new Album() { Title = "ipsa quae voluptas natus ut suscipit soluta quia quidem", User = users[7] });
            database.Albums.Add(new Album() { Title = "id nihil reprehenderit", User = users[7] });

            database.Albums.Add(new Album() { Title = "quibusdam sapiente et", User = users[8] });
            database.Albums.Add(new Album() { Title = "recusandae consequatur vel amet unde", User = users[8] });
            database.Albums.Add(new Album() { Title = "aperiam odio fugiat", User = users[8] });
            database.Albums.Add(new Album() { Title = "est et at eos expedita", User = users[8] });
            database.Albums.Add(new Album() { Title = "qui voluptatem consequatur aut ab quis temporibus praesentium", User = users[8] });
            database.Albums.Add(new Album() { Title = "eligendi mollitia alias aspernatur vel ut iusto", User = users[8] });
            database.Albums.Add(new Album() { Title = "aut aut architecto", User = users[8] });
            database.Albums.Add(new Album() { Title = "quas perspiciatis optio", User = users[8] });
            database.Albums.Add(new Album() { Title = "sit optio id voluptatem est eum et", User = users[8] });
            database.Albums.Add(new Album() { Title = "est vel dignissimos", User = users[8] });

            database.Albums.Add(new Album() { Title = "repellendus praesentium debitis officiis", User = users[9] });
            database.Albums.Add(new Album() { Title = "incidunt et et eligendi assumenda soluta quia recusandae", User = users[9] });
            database.Albums.Add(new Album() { Title = "nisi qui dolores perspiciatis", User = users[9] });
            database.Albums.Add(new Album() { Title = "quisquam a dolores et earum vitae", User = users[9] });
            database.Albums.Add(new Album() { Title = "consectetur vel rerum qui aperiam modi eos aspernatur ipsa", User = users[9] });
            database.Albums.Add(new Album() { Title = "unde et ut molestiae est molestias voluptatem sint", User = users[9] });
            database.Albums.Add(new Album() { Title = "est quod aut", User = users[9] });
            database.Albums.Add(new Album() { Title = "omnis quia possimus nesciunt deleniti assumenda sed autem", User = users[9] });
            database.Albums.Add(new Album() { Title = "consectetur ut id impedit dolores sit ad ex aut", User = users[9] });
            database.Albums.Add(new Album() { Title = "enim repellat iste", User = users[9] });

            database.SaveChanges();
        }

        private void CreatePosts(DatabaseContext database)
        {
            var users = database.Users.ToList();

            database.Posts.Add(new Post() { Title = "sunt aut facere repellat provident occaecati excepturi optio reprehenderit", Body = "quia et suscipit\nsuscipit recusandae consequuntur expedita et cum\nreprehenderit molestiae ut ut quas totam\nnostrum rerum est autem sunt rem eveniet architecto", User = users[0] });
            database.Posts.Add(new Post() { Title = "qui est esse", Body = "est rerum tempore vitae\nsequi sint nihil reprehenderit dolor beatae ea dolores neque\nfugiat blanditiis voluptate porro vel nihil molestiae ut reiciendis\nqui aperiam non debitis possimus qui neque nisi nulla", User = users[0] });
            database.Posts.Add(new Post() { Title = "ea molestias quasi exercitationem repellat qui ipsa sit aut", Body = "et iusto sed quo iure\nvoluptatem occaecati omnis eligendi aut ad\nvoluptatem doloribus vel accusantium quis pariatur\nmolestiae porro eius odio et labore et velit aut", User = users[0] });
            database.Posts.Add(new Post() { Title = "eum et est occaecati", Body = "ullam et saepe reiciendis voluptatem adipisci\nsit amet autem assumenda provident rerum culpa\nquis hic commodi nesciunt rem tenetur doloremque ipsam iure\nquis sunt voluptatem rerum illo velit", User = users[0] });
            database.Posts.Add(new Post() { Title = "nesciunt quas odio", Body = "repudiandae veniam quaerat sunt sed\nalias aut fugiat sit autem sed est\nvoluptatem omnis possimus esse voluptatibus quis\nest aut tenetur dolor neque", User = users[0] });
            database.Posts.Add(new Post() { Title = "dolorem eum magni eos aperiam quia", Body = "ut aspernatur corporis harum nihil quis provident sequi\nmollitia nobis aliquid molestiae\nperspiciatis et ea nemo ab reprehenderit accusantium quas\nvoluptate dolores velit et doloremque molestiae", User = users[0] });
            database.Posts.Add(new Post() { Title = "magnam facilis autem", Body = "dolore placeat quibusdam ea quo vitae\nmagni quis enim qui quis quo nemo aut saepe\nquidem repellat excepturi ut quia\nsunt ut sequi eos ea sed quas", User = users[0] });
            database.Posts.Add(new Post() { Title = "dolorem dolore est ipsam", Body = "dignissimos aperiam dolorem qui eum\nfacilis quibusdam animi sint suscipit qui sint possimus cum\nquaerat magni maiores excepturi\nipsam ut commodi dolor voluptatum modi aut vitae", User = users[0] });
            database.Posts.Add(new Post() { Title = "nesciunt iure omnis dolorem tempora et accusantium", Body = "consectetur animi nesciunt iure dolore\nenim quia ad\nveniam autem ut quam aut nobis\net est aut quod aut provident voluptas autem voluptas", User = users[0] });
            database.Posts.Add(new Post() { Title = "optio molestias id quia eum", Body = "quo et expedita modi cum officia vel magni\ndoloribus qui repudiandae\nvero nisi sit\nquos veniam quod sed accusamus veritatis error", User = users[0] });

            database.Posts.Add(new Post() { Title = "et ea vero quia laudantium autem", Body = "delectus reiciendis molestiae occaecati non minima eveniet qui voluptatibus\naccusamus in eum beatae sit\nvel qui neque voluptates ut commodi qui incidunt\nut animi commodi", User = users[1] });
            database.Posts.Add(new Post() { Title = "in quibusdam tempore odit est dolorem", Body = "itaque id aut magnam\npraesentium quia et ea odit et ea voluptas et\nsapiente quia nihil amet occaecati quia id voluptatem\nincidunt ea est distinctio odio", User = users[1] });
            database.Posts.Add(new Post() { Title = "dolorum ut in voluptas mollitia et saepe quo animi", Body = "aut dicta possimus sint mollitia voluptas commodi quo doloremque\niste corrupti reiciendis voluptatem eius rerum\nsit cumque quod eligendi laborum minima\nperferendis recusandae assumenda consectetur porro architecto ipsum ipsam", User = users[1] });
            database.Posts.Add(new Post() { Title = "voluptatem eligendi optio", Body = "fuga et accusamus dolorum perferendis illo voluptas\nnon doloremque neque facere\nad qui dolorum molestiae beatae\nsed aut voluptas totam sit illum", User = users[1] });
            database.Posts.Add(new Post() { Title = "eveniet quod temporibus", Body = "reprehenderit quos placeat\nvelit minima officia dolores impedit repudiandae molestiae nam\nvoluptas recusandae quis delectus\nofficiis harum fugiat vitae", User = users[1] });
            database.Posts.Add(new Post() { Title = "sint suscipit perspiciatis velit dolorum rerum ipsa laboriosam odio", Body = "suscipit nam nisi quo aperiam aut\nasperiores eos fugit maiores voluptatibus quia\nvoluptatem quis ullam qui in alias quia est\nconsequatur magni mollitia accusamus ea nisi voluptate dicta", User = users[1] });
            database.Posts.Add(new Post() { Title = "fugit voluptas sed molestias voluptatem provident", Body = "eos voluptas et aut odit natus earum\naspernatur fuga molestiae ullam\ndeserunt ratione qui eos\nqui nihil ratione nemo velit ut aut id quo", User = users[1] });
            database.Posts.Add(new Post() { Title = "voluptate et itaque vero tempora molestiae", Body = "eveniet quo quis\nlaborum totam consequatur non dolor\nut et est repudiandae\nest voluptatem vel debitis et magnam", User = users[1] });
            database.Posts.Add(new Post() { Title = "adipisci placeat illum aut reiciendis qui", Body = "illum quis cupiditate provident sit magnam\nea sed aut omnis\nveniam maiores ullam consequatur atque\nadipisci quo iste expedita sit quos voluptas", User = users[1] });
            database.Posts.Add(new Post() { Title = "doloribus ad provident suscipit at", Body = "qui consequuntur ducimus possimus quisquam amet similique\nsuscipit porro ipsam amet\neos veritatis officiis exercitationem vel fugit aut necessitatibus totam\nomnis rerum consequatur expedita quidem cumque explicabo", User = users[1] });

            database.Posts.Add(new Post() { Title = "asperiores ea ipsam voluptatibus modi minima quia sint", Body = "repellat aliquid praesentium dolorem quo\nsed totam minus non itaque\nnihil labore molestiae sunt dolor eveniet hic recusandae veniam\ntempora et tenetur expedita sunt", User = users[2] });
            database.Posts.Add(new Post() { Title = "dolor sint quo a velit explicabo quia nam", Body = "eos qui et ipsum ipsam suscipit aut\nsed omnis non odio\nexpedita earum mollitia molestiae aut atque rem suscipit\nnam impedit esse", User = users[2] });
            database.Posts.Add(new Post() { Title = "maxime id vitae nihil numquam", Body = "veritatis unde neque eligendi\nquae quod architecto quo neque vitae\nest illo sit tempora doloremque fugit quod\net et vel beatae sequi ullam sed tenetur perspiciatis", User = users[2] });
            database.Posts.Add(new Post() { Title = "autem hic labore sunt dolores incidunt", Body = "enim et ex nulla\nomnis voluptas quia qui\nvoluptatem consequatur numquam aliquam sunt\ntotam recusandae id dignissimos aut sed asperiores deserunt", User = users[2] });
            database.Posts.Add(new Post() { Title = "rem alias distinctio quo quis", Body = "ullam consequatur ut\nomnis quis sit vel consequuntur\nipsa eligendi ipsum molestiae et omnis error nostrum\nmolestiae illo tempore quia et distinctio", User = users[2] });
            database.Posts.Add(new Post() { Title = "est et quae odit qui non", Body = "similique esse doloribus nihil accusamus\nomnis dolorem fuga consequuntur reprehenderit fugit recusandae temporibus\nperspiciatis cum ut laudantium\nomnis aut molestiae vel vero", User = users[2] });
            database.Posts.Add(new Post() { Title = "quasi id et eos tenetur aut quo autem", Body = "eum sed dolores ipsam sint possimus debitis occaecati\ndebitis qui qui et\nut placeat enim earum aut odit facilis\nconsequatur suscipit necessitatibus rerum sed inventore temporibus consequatur", User = users[2] });
            database.Posts.Add(new Post() { Title = "delectus ullam et corporis nulla voluptas sequi", Body = "non et quaerat ex quae ad maiores\nmaiores recusandae totam aut blanditiis mollitia quas illo\nut voluptatibus voluptatem\nsimilique nostrum eum", User = users[2] });
            database.Posts.Add(new Post() { Title = "iusto eius quod necessitatibus culpa ea", Body = "odit magnam ut saepe sed non qui\ntempora atque nihil\naccusamus illum doloribus illo dolor\neligendi repudiandae odit magni similique sed cum maiores", User = users[2] });
            database.Posts.Add(new Post() { Title = "a quo magni similique perferendis", Body = "alias dolor cumque\nimpedit blanditiis non eveniet odio maxime\nblanditiis amet eius quis tempora quia autem rem\na provident perspiciatis quia", User = users[2] });

            database.Posts.Add(new Post() { Title = "ullam ut quidem id aut vel consequuntur", Body = "debitis eius sed quibusdam non quis consectetur vitae\nimpedit ut qui consequatur sed aut in\nquidem sit nostrum et maiores adipisci atque\nquaerat voluptatem adipisci repudiandae", User = users[3] });
            database.Posts.Add(new Post() { Title = "doloremque illum aliquid sunt", Body = "deserunt eos nobis asperiores et hic\nest debitis repellat molestiae optio\nnihil ratione ut eos beatae quibusdam distinctio maiores\nearum voluptates et aut adipisci ea maiores voluptas maxime", User = users[3] });
            database.Posts.Add(new Post() { Title = "qui explicabo molestiae dolorem", Body = "rerum ut et numquam laborum odit est sit\nid qui sint in\nquasi tenetur tempore aperiam et quaerat qui in\nrerum officiis sequi cumque quod", User = users[3] });
            database.Posts.Add(new Post() { Title = "magnam ut rerum iure", Body = "ea velit perferendis earum ut voluptatem voluptate itaque iusto\ntotam pariatur in\nnemo voluptatem voluptatem autem magni tempora minima in\nest distinctio qui assumenda accusamus dignissimos officia nesciunt nobis", User = users[3] });
            database.Posts.Add(new Post() { Title = "id nihil consequatur molestias animi provident", Body = "nisi error delectus possimus ut eligendi vitae\nplaceat eos harum cupiditate facilis reprehenderit voluptatem beatae\nmodi ducimus quo illum voluptas eligendi\net nobis quia fugit", User = users[3] });
            database.Posts.Add(new Post() { Title = "fuga nam accusamus voluptas reiciendis itaque", Body = "ad mollitia et omnis minus architecto odit\nvoluptas doloremque maxime aut non ipsa qui alias veniam\nblanditiis culpa aut quia nihil cumque facere et occaecati\nqui aspernatur quia eaque ut aperiam inventore", User = users[3] });
            database.Posts.Add(new Post() { Title = "provident vel ut sit ratione est", Body = "debitis et eaque non officia sed nesciunt pariatur vel\nvoluptatem iste vero et ea\nnumquam aut expedita ipsum nulla in\nvoluptates omnis consequatur aut enim officiis in quam qui", User = users[3] });
            database.Posts.Add(new Post() { Title = "explicabo et eos deleniti nostrum ab id repellendus", Body = "animi esse sit aut sit nesciunt assumenda eum voluptas\nquia voluptatibus provident quia necessitatibus ea\nrerum repudiandae quia voluptatem delectus fugit aut id quia\nratione optio eos iusto veniam iure", User = users[3] });
            database.Posts.Add(new Post() { Title = "eos dolorem iste accusantium est eaque quam", Body = "corporis rerum ducimus vel eum accusantium\nmaxime aspernatur a porro possimus iste omnis\nest in deleniti asperiores fuga aut\nvoluptas sapiente vel dolore minus voluptatem incidunt ex", User = users[3] });
            database.Posts.Add(new Post() { Title = "enim quo cumque", Body = "ut voluptatum aliquid illo tenetur nemo sequi quo facilis\nipsum rem optio mollitia quas\nvoluptatem eum voluptas qui\nunde omnis voluptatem iure quasi maxime voluptas nam", User = users[3] });

            database.Posts.Add(new Post() { Title = "non est facere", Body = "molestias id nostrum\nexcepturi molestiae dolore omnis repellendus quaerat saepe\nconsectetur iste quaerat tenetur asperiores accusamus ex ut\nnam quidem est ducimus sunt debitis saepe", User = users[4] });
            database.Posts.Add(new Post() { Title = "commodi ullam sint et excepturi error explicabo praesentium voluptas", Body = "odio fugit voluptatum ducimus earum autem est incidunt voluptatem\nodit reiciendis aliquam sunt sequi nulla dolorem\nnon facere repellendus voluptates quia\nratione harum vitae ut", User = users[4] });
            database.Posts.Add(new Post() { Title = "eligendi iste nostrum consequuntur adipisci praesentium sit beatae perferendis", Body = "similique fugit est\nillum et dolorum harum et voluptate eaque quidem\nexercitationem quos nam commodi possimus cum odio nihil nulla\ndolorum exercitationem magnam ex et a et distinctio debitis", User = users[4] });
            database.Posts.Add(new Post() { Title = "optio dolor molestias sit", Body = "temporibus est consectetur dolore\net libero debitis vel velit laboriosam quia\nipsum quibusdam qui itaque fuga rem aut\nea et iure quam sed maxime ut distinctio quae", User = users[4] });
            database.Posts.Add(new Post() { Title = "ut numquam possimus omnis eius suscipit laudantium iure", Body = "est natus reiciendis nihil possimus aut provident\nex et dolor\nrepellat pariatur est\nnobis rerum repellendus dolorem autem", User = users[4] });
            database.Posts.Add(new Post() { Title = "aut quo modi neque nostrum ducimus", Body = "voluptatem quisquam iste\nvoluptatibus natus officiis facilis dolorem\nquis quas ipsam\nvel et voluptatum in aliquid", User = users[4] });
            database.Posts.Add(new Post() { Title = "quibusdam cumque rem aut deserunt", Body = "voluptatem assumenda ut qui ut cupiditate aut impedit veniam\noccaecati nemo illum voluptatem laudantium\nmolestiae beatae rerum ea iure soluta nostrum\neligendi et voluptate", User = users[4] });
            database.Posts.Add(new Post() { Title = "ut voluptatem illum ea doloribus itaque eos", Body = "voluptates quo voluptatem facilis iure occaecati\nvel assumenda rerum officia et\nillum perspiciatis ab deleniti\nlaudantium repellat ad ut et autem reprehenderit", User = users[4] });
            database.Posts.Add(new Post() { Title = "laborum non sunt aut ut assumenda perspiciatis voluptas", Body = "inventore ab sint\nnatus fugit id nulla sequi architecto nihil quaerat\neos tenetur in in eum veritatis non\nquibusdam officiis aspernatur cumque aut commodi aut", User = users[4] });
            database.Posts.Add(new Post() { Title = "repellendus qui recusandae incidunt voluptates tenetur qui omnis exercitationem", Body = "error suscipit maxime adipisci consequuntur recusandae\nvoluptas eligendi et est et voluptates\nquia distinctio ab amet quaerat molestiae et vitae\nadipisci impedit sequi nesciunt quis consectetur", User = users[4] });

            database.Posts.Add(new Post() { Title = "soluta aliquam aperiam consequatur illo quis voluptas", Body = "sunt dolores aut doloribus\ndolore doloribus voluptates tempora et\ndoloremque et quo\ncum asperiores sit consectetur dolorem", User = users[5] });
            database.Posts.Add(new Post() { Title = "qui enim et consequuntur quia animi quis voluptate quibusdam", Body = "iusto est quibusdam fuga quas quaerat molestias\na enim ut sit accusamus enim\ntemporibus iusto accusantium provident architecto\nsoluta esse reprehenderit qui laborum", User = users[5] });
            database.Posts.Add(new Post() { Title = "ut quo aut ducimus alias", Body = "minima harum praesentium eum rerum illo dolore\nquasi exercitationem rerum nam\nporro quis neque quo\nconsequatur minus dolor quidem veritatis sunt non explicabo similique", User = users[5] });
            database.Posts.Add(new Post() { Title = "sit asperiores ipsam eveniet odio non quia", Body = "totam corporis dignissimos\nvitae dolorem ut occaecati accusamus\nex velit deserunt\net exercitationem vero incidunt corrupti mollitia", User = users[5] });
            database.Posts.Add(new Post() { Title = "sit vel voluptatem et non libero", Body = "debitis excepturi ea perferendis harum libero optio\neos accusamus cum fuga ut sapiente repudiandae\net ut incidunt omnis molestiae\nnihil ut eum odit", User = users[5] });
            database.Posts.Add(new Post() { Title = "qui et at rerum necessitatibus", Body = "aut est omnis dolores\nneque rerum quod ea rerum velit pariatur beatae excepturi\net provident voluptas corrupti\ncorporis harum reprehenderit dolores eligendi", User = users[5] });
            database.Posts.Add(new Post() { Title = "sed ab est est", Body = "at pariatur consequuntur earum quidem\nquo est laudantium soluta voluptatem\nqui ullam et est\net cum voluptas voluptatum repellat est", User = users[5] });
            database.Posts.Add(new Post() { Title = "voluptatum itaque dolores nisi et quasi", Body = "veniam voluptatum quae adipisci id\net id quia eos ad et dolorem\naliquam quo nisi sunt eos impedit error\nad similique veniam", User = users[5] });
            database.Posts.Add(new Post() { Title = "qui commodi dolor at maiores et quis id accusantium", Body = "perspiciatis et quam ea autem temporibus non voluptatibus qui\nbeatae a earum officia nesciunt dolores suscipit voluptas et\nanimi doloribus cum rerum quas et magni\net hic ut ut commodi expedita sunt", User = users[5] });
            database.Posts.Add(new Post() { Title = "consequatur placeat omnis quisquam quia reprehenderit fugit veritatis facere", Body = "asperiores sunt ab assumenda cumque modi velit\nqui esse omnis\nvoluptate et fuga perferendis voluptas\nillo ratione amet aut et omnis", User = users[5] });

            database.Posts.Add(new Post() { Title = "voluptatem doloribus consectetur est ut ducimus", Body = "ab nemo optio odio\ndelectus tenetur corporis similique nobis repellendus rerum omnis facilis\nvero blanditiis debitis in nesciunt doloribus dicta dolores\nmagnam minus velit", User = users[6] });
            database.Posts.Add(new Post() { Title = "beatae enim quia vel", Body = "enim aspernatur illo distinctio quae praesentium\nbeatae alias amet delectus qui voluptate distinctio\nodit sint accusantium autem omnis\nquo molestiae omnis ea eveniet optio", User = users[6] });
            database.Posts.Add(new Post() { Title = "voluptas blanditiis repellendus animi ducimus error sapiente et suscipit", Body = "enim adipisci aspernatur nemo\nnumquam omnis facere dolorem dolor ex quis temporibus incidunt\nab delectus culpa quo reprehenderit blanditiis asperiores\naccusantium ut quam in voluptatibus voluptas ipsam dicta", User = users[6] });
            database.Posts.Add(new Post() { Title = "et fugit quas eum in in aperiam quod", Body = "id velit blanditiis\neum ea voluptatem\nmolestiae sint occaecati est eos perspiciatis\nincidunt a error provident eaque aut aut qui", User = users[6] });
            database.Posts.Add(new Post() { Title = "consequatur id enim sunt et et", Body = "voluptatibus ex esse\nsint explicabo est aliquid cumque adipisci fuga repellat labore\nmolestiae corrupti ex saepe at asperiores et perferendis\nnatus id esse incidunt pariatur", User = users[6] });
            database.Posts.Add(new Post() { Title = "repudiandae ea animi iusto", Body = "officia veritatis tenetur vero qui itaque\nsint non ratione\nsed et ut asperiores iusto eos molestiae nostrum\nveritatis quibusdam et nemo iusto saepe", User = users[6] });
            database.Posts.Add(new Post() { Title = "aliquid eos sed fuga est maxime repellendus", Body = "reprehenderit id nostrum\nvoluptas doloremque pariatur sint et accusantium quia quod aspernatur\net fugiat amet\nnon sapiente et consequatur necessitatibus molestiae", User = users[6] });
            database.Posts.Add(new Post() { Title = "odio quis facere architecto reiciendis optio", Body = "magnam molestiae perferendis quisquam\nqui cum reiciendis\nquaerat animi amet hic inventore\nea quia deleniti quidem saepe porro velit", User = users[6] });
            database.Posts.Add(new Post() { Title = "fugiat quod pariatur odit minima", Body = "officiis error culpa consequatur modi asperiores et\ndolorum assumenda voluptas et vel qui aut vel rerum\nvoluptatum quisquam perspiciatis quia rerum consequatur totam quas\nsequi commodi repudiandae asperiores et saepe a", User = users[6] });
            database.Posts.Add(new Post() { Title = "voluptatem laborum magni", Body = "sunt repellendus quae\nest asperiores aut deleniti esse accusamus repellendus quia aut\nquia dolorem unde\neum tempora esse dolore", User = users[6] });

            database.Posts.Add(new Post() { Title = "et iusto veniam et illum aut fuga", Body = "occaecati a doloribus\niste saepe consectetur placeat eum voluptate dolorem et\nqui quo quia voluptas\nrerum ut id enim velit est perferendis", User = users[7] });
            database.Posts.Add(new Post() { Title = "sint hic doloribus consequatur eos non id", Body = "quam occaecati qui deleniti consectetur\nconsequatur aut facere quas exercitationem aliquam hic voluptas\nneque id sunt ut aut accusamus\nsunt consectetur expedita inventore velit", User = users[7] });
            database.Posts.Add(new Post() { Title = "consequuntur deleniti eos quia temporibus ab aliquid at", Body = "voluptatem cumque tenetur consequatur expedita ipsum nemo quia explicabo\naut eum minima consequatur\ntempore cumque quae est et\net in consequuntur voluptatem voluptates aut", User = users[7] });
            database.Posts.Add(new Post() { Title = "enim unde ratione doloribus quas enim ut sit sapiente", Body = "odit qui et et necessitatibus sint veniam\nmollitia amet doloremque molestiae commodi similique magnam et quam\nblanditiis est itaque\nquo et tenetur ratione occaecati molestiae tempora", User = users[7] });
            database.Posts.Add(new Post() { Title = "dignissimos eum dolor ut enim et delectus in", Body = "commodi non non omnis et voluptas sit\nautem aut nobis magnam et sapiente voluptatem\net laborum repellat qui delectus facilis temporibus\nrerum amet et nemo voluptate expedita adipisci error dolorem", User = users[7] });
            database.Posts.Add(new Post() { Title = "doloremque officiis ad et non perferendis", Body = "ut animi facere\ntotam iusto tempore\nmolestiae eum aut et dolorem aperiam\nquaerat recusandae totam odio", User = users[7] });
            database.Posts.Add(new Post() { Title = "necessitatibus quasi exercitationem odio", Body = "modi ut in nulla repudiandae dolorum nostrum eos\naut consequatur omnis\nut incidunt est omnis iste et quam\nvoluptates sapiente aliquam asperiores nobis amet corrupti repudiandae provident", User = users[7] });
            database.Posts.Add(new Post() { Title = "quam voluptatibus rerum veritatis", Body = "nobis facilis odit tempore cupiditate quia\nassumenda doloribus rerum qui ea\nillum et qui totam\naut veniam repellendus", User = users[7] });
            database.Posts.Add(new Post() { Title = "pariatur consequatur quia magnam autem omnis non amet", Body = "libero accusantium et et facere incidunt sit dolorem\nnon excepturi qui quia sed laudantium\nquisquam molestiae ducimus est\nofficiis esse molestiae iste et quos", User = users[7] });
            database.Posts.Add(new Post() { Title = "labore in ex et explicabo corporis aut quas", Body = "ex quod dolorem ea eum iure qui provident amet\nquia qui facere excepturi et repudiandae\nasperiores molestias provident\nminus incidunt vero fugit rerum sint sunt excepturi provident", User = users[7] });

            database.Posts.Add(new Post() { Title = "tempora rem veritatis voluptas quo dolores vero", Body = "facere qui nesciunt est voluptatum voluptatem nisi\nsequi eligendi necessitatibus ea at rerum itaque\nharum non ratione velit laboriosam quis consequuntur\nex officiis minima doloremque voluptas ut aut", User = users[8] });
            database.Posts.Add(new Post() { Title = "laudantium voluptate suscipit sunt enim enim", Body = "ut libero sit aut totam inventore sunt\nporro sint qui sunt molestiae\nconsequatur cupiditate qui iste ducimus adipisci\ndolor enim assumenda soluta laboriosam amet iste delectus hic", User = users[8] });
            database.Posts.Add(new Post() { Title = "odit et voluptates doloribus alias odio et", Body = "est molestiae facilis quis tempora numquam nihil qui\nvoluptate sapiente consequatur est qui\nnecessitatibus autem aut ipsa aperiam modi dolore numquam\nreprehenderit eius rem quibusdam", User = users[8] });
            database.Posts.Add(new Post() { Title = "optio ipsam molestias necessitatibus occaecati facilis veritatis dolores aut", Body = "sint molestiae magni a et quos\neaque et quasi\nut rerum debitis similique veniam\nrecusandae dignissimos dolor incidunt consequatur odio", User = users[8] });
            database.Posts.Add(new Post() { Title = "dolore veritatis porro provident adipisci blanditiis et sunt", Body = "", User = users[8] });
            database.Posts.Add(new Post() { Title = "placeat quia et porro iste", Body = "quasi excepturi consequatur iste autem temporibus sed molestiae beatae\net quaerat et esse ut\nvoluptatem occaecati et vel explicabo autem\nasperiores pariatur deserunt optio", User = users[8] });
            database.Posts.Add(new Post() { Title = "nostrum quis quasi placeat", Body = "eos et molestiae\nnesciunt ut a\ndolores perspiciatis repellendus repellat aliquid\nmagnam sint rem ipsum est", User = users[8] });
            database.Posts.Add(new Post() { Title = "sapiente omnis fugit eos", Body = "consequatur omnis est praesentium\nducimus non iste\nneque hic deserunt\nvoluptatibus veniam cum et rerum sed", User = users[8] });
            database.Posts.Add(new Post() { Title = "sint soluta et vel magnam aut ut sed qui", Body = "repellat aut aperiam totam temporibus autem et\narchitecto magnam ut\nconsequatur qui cupiditate rerum quia soluta dignissimos nihil iure\ntempore quas est", User = users[8] });
            database.Posts.Add(new Post() { Title = "ad iusto omnis odit dolor voluptatibus", Body = "minus omnis soluta quia\nqui sed adipisci voluptates illum ipsam voluptatem\neligendi officia ut in\neos soluta similique molestias praesentium blanditiis", User = users[8] });

            database.Posts.Add(new Post() { Title = "aut amet sed", Body = "libero voluptate eveniet aperiam sed\nsunt placeat suscipit molestias\nsimilique fugit nam natus\nexpedita consequatur consequatur dolores quia eos et placeat", User = users[9] });
            database.Posts.Add(new Post() { Title = "ratione ex tenetur perferendis", Body = "aut et excepturi dicta laudantium sint rerum nihil\nlaudantium et at\na neque minima officia et similique libero et\ncommodi voluptate qui", User = users[9] });
            database.Posts.Add(new Post() { Title = "beatae soluta recusandae", Body = "dolorem quibusdam ducimus consequuntur dicta aut quo laboriosam\nvoluptatem quis enim recusandae ut sed sunt\nnostrum est odit totam\nsit error sed sunt eveniet provident qui nulla", User = users[9] });
            database.Posts.Add(new Post() { Title = "qui qui voluptates illo iste minima", Body = "aspernatur expedita soluta quo ab ut similique\nexpedita dolores amet\nsed temporibus distinctio magnam saepe deleniti\nomnis facilis nam ipsum natus sint similique omnis", User = users[9] });
            database.Posts.Add(new Post() { Title = "id minus libero illum nam ad officiis", Body = "earum voluptatem facere provident blanditiis velit laboriosam\npariatur accusamus odio saepe\ncumque dolor qui a dicta ab doloribus consequatur omnis\ncorporis cupiditate eaque assumenda ad nesciunt", User = users[9] });
            database.Posts.Add(new Post() { Title = "quaerat velit veniam amet cupiditate aut numquam ut sequi", Body = "in non odio excepturi sint eum\nlabore voluptates vitae quia qui et\ninventore itaque rerum\nveniam non exercitationem delectus aut", User = users[9] });
            database.Posts.Add(new Post() { Title = "quas fugiat ut perspiciatis vero provident", Body = "eum non blanditiis soluta porro quibusdam voluptas\nvel voluptatem qui placeat dolores qui velit aut\nvel inventore aut cumque culpa explicabo aliquid at\nperspiciatis est et voluptatem dignissimos dolor itaque sit nam", User = users[9] });
            database.Posts.Add(new Post() { Title = "laboriosam dolor voluptates", Body = "doloremque ex facilis sit sint culpa\nsoluta assumenda eligendi non ut eius\nsequi ducimus vel quasi\nveritatis est dolores", User = users[9] });
            database.Posts.Add(new Post() { Title = "temporibus sit alias delectus eligendi possimus magni", Body = "quo deleniti praesentium dicta non quod\naut est molestias\nmolestias et officia quis nihil\nitaque dolorem quia", User = users[9] });
            database.Posts.Add(new Post() { Title = "at nam consequatur ea labore ea harum", Body = "cupiditate quo est a modi nesciunt soluta\nipsa voluptas error itaque dicta in\nautem qui minus magnam et distinctio eum\naccusamus ratione error aut", User = users[9] });

            database.SaveChanges();
        }

        
    }
}
