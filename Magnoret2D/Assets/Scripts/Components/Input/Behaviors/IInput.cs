namespace InputManager
{
    public interface IInput
    {
        bool Right();

        bool Left();

        bool Up();

        bool Down();

        bool Idle();
    }
}