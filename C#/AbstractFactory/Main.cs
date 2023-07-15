namespace C_.AbstractFactory
{
    public class Main
    {
        public static void AbstractFactoryDesign()
        {
            DarkThemeFactory df = new DarkThemeFactory();
            df.CreateButton();
            IButton darkBUtton = df.MyButton;
        }
    }
}