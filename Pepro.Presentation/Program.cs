namespace Pepro.Presentation;

static class Program
{
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();

        while (true)
        {
            string? accountName = null;
            using (FormLogin loginForm = new())
            {
                if (loginForm.ShowDialog() != DialogResult.OK)
                {
                    break;
                }
                accountName = loginForm.AccountName;
            }

            using FormMenu menuForm = new()
            {
                UserId = accountName
            };
            if (menuForm.ShowDialog() != DialogResult.Retry)
            {
                break;
            }
        }
    }
}
