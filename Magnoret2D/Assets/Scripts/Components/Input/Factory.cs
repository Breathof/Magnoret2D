namespace InputManager
{
    public class Factory
    {
        private readonly Keyboard Keyboard;

        private readonly TouchScreen TouchScreen;

        public Factory() { }

        public Keyboard GetKeyboard()
        {
            if (Keyboard != null)
            {
                return Keyboard;
            } else
            {
                return new Keyboard();
            }
        }

        public TouchScreen GetTouchScreen()
        {
            if (TouchScreen != null)
            {
                return TouchScreen;
            } else
            {
                return new TouchScreen();
            }
        }

    }
}