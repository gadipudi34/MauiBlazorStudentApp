using StudentAppHybrid.Database;

namespace StudentAppHybrid
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            Database = new ApplicationDbContext();
            MainPage = new MainPage();
        }


        public static ApplicationDbContext Database { get; private set; }

    }
}
