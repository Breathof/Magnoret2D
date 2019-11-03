using UnityEngine;

namespace InputManager
{
    public class Keyboard: IInput
    {
        public Keyboard() { }

        public bool Up()
        {
            return Input.GetKey(KeyCode.UpArrow);
        }

        public bool Down()
        {
            return Input.GetKey(KeyCode.DownArrow);
        }

        public bool Left()
        {
            return Input.GetKey(KeyCode.LeftArrow);
        }

        public bool Right()
        {
            return Input.GetKey(KeyCode.RightArrow);
        }

        public bool Idle()
        {
            return !Input.anyKey;
        }
    }
}
