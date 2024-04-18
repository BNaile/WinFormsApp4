using Account = WinFormsApp4.Account;
namespace WinFormsApp4
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            ApplicationConfiguration.Initialize();
            User admin=new User();
            admin.Login = "Nailə";
            admin.Password = "261020";
            admin.Email = "gmail.com";
            DataBASE.Instance.Users.Add(admin);
            Application.Run(new Form1());
        }
    }
}