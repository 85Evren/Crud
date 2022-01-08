using Crud;



    Console.WriteLine("Kullanıcı eklemek için I ya , Kullanıcı silmek için D ye, kullanıcı güncellemek için U ya basınız.");
    char operation = Convert.ToChar(Console.ReadLine());

if (operation == 'I')
{
    Console.WriteLine("Kullanıcı adı girişiniz.");
    string UserName = Console.ReadLine();

    Console.WriteLine("Şifre girişiniz.");
    string password = Console.ReadLine();

    User user = new User();
    user.UserName = UserName;
    user.Password = password;

    AppDbContext dbContext = new AppDbContext();
    dbContext.User.Add(user);///dbset e ekliyrz
    dbContext.SaveChanges();// veri tabanına yansıtmak için kullanılıyor.

}

if (operation == 'U')
{

    Console.WriteLine("Kullanıcı ID sini girişiniz.");
    int ID =Convert.ToInt32( Console.ReadLine());

    Console.WriteLine("Email alanını giriniz.");
    string email = Console.ReadLine();

    AppDbContext dbContext = new AppDbContext();

    User user = dbContext.User.Find(ID);// ıd üzerinden dönüş yapar. ıd yoksa null döner
    user.Email = email;
    user.ID = 1;

    dbContext.SaveChanges();
}



if (operation == 'D')
{

    Console.WriteLine("Kullanıcı ID sini girişiniz.");
    int ID = Convert.ToInt32(Console.ReadLine());

    AppDbContext dbContext = new AppDbContext();

    User user = dbContext.User.Find(ID);// ıd üzerinden dönüş yapar. ıd yoksa null döner
    dbContext.User.Remove(user);

    dbContext.SaveChanges();
}


if (operation == 'R')
{

    AppDbContext dbContext = new AppDbContext();

    List<User> users = dbContext.User.ToList();

foreach(var u in users)

    {

        Console.WriteLine($"{u.UserName}\t {u.Email}\t {u.CreDate}\t");

    }

}



// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
    Console.ReadKey();


