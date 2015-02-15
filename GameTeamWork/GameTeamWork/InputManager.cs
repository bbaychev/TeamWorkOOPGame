using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework.Input;

namespace GameTeamWork
{
    public class InputManager
    {
        private KeyboardState currentKeyState, prevKeyState;

        private static InputManager instance;

        public static InputManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new InputManager();
                }

                return instance;
            }
        }

        public void Update()
        {
            prevKeyState = currentKeyState;
            if (!ScreenManager.Instance.IsTransitioning)
            {
                currentKeyState = Keyboard.GetState();
            }
        }

        public bool KeyPressed(params Keys[] keys)
        {
            foreach (Keys key in keys)
            {
                bool whatKeyState = currentKeyState.IsKeyDown(key) && prevKeyState.IsKeyUp(key);
                if (whatKeyState)
                {
                    return whatKeyState;
                }
            }

            return false;
        }

        public bool KeyReleased(params Keys[] keys)
        {
            foreach (Keys key in keys)
            {
                bool whatKeyState = currentKeyState.IsKeyUp(key) && prevKeyState.IsKeyDown(key);
                if (whatKeyState)
                {
                    return whatKeyState;
                }
            }

            return false;
        }

        public bool KeyDown(params Keys[] keys)
        {
            foreach (Keys key in keys)
            {
                bool whatKeyState = currentKeyState.IsKeyDown(key);
                if (whatKeyState)
                {
                    return whatKeyState;
                }
            }

            return false;
        }
    }
}
