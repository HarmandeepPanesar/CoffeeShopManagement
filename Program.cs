namespace CoffeeShopManagement
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles(); // Enables visual styles for the application  
            Application.SetCompatibleTextRenderingDefault(false); // Set text rendering to default

            // Uncomment the form you want to start with  
            // Application.Run(new OrderForm());
            Application.Run(new OrderForm()); // Start with the Order Form  

        }



    }
}