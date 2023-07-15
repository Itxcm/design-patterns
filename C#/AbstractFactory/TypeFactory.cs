namespace C_.AbstractFactory
{
    internal interface IThemeFactory
    {
        IButton CreateButton();

        ITextBox CreateTextBox();
    }

    internal class DarkThemeFactory : IThemeFactory
    {
        private IButton _myButton;

        public IButton MyButton
        {
            get => _myButton;
            private set => _myButton = value;
        }

        public IButton CreateButton()
        {
            return new DarkButton();
        }

        public ITextBox CreateTextBox()
        {
            return new DarkTextBox();
        }
    }

    internal class LightThemeFactory : IThemeFactory
    {
        public IButton CreateButton()
        {
            return new LightButton();
        }

        public ITextBox CreateTextBox()
        {
            return new LightTextBox();
        }
    }
}