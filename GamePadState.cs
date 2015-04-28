using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SlimDX;
using SlimDX.XInput;

namespace CGLauncher
{
    public class GamepadState
    {
        uint lastPacket;
        State lastState;
        bool lastLTrigger, lastRTrigger;
        public GamepadState(UserIndex userIndex)
        {
            UserIndex = userIndex;
            Controller = new Controller(userIndex);
            if (Controller.IsConnected)
            {
                lastState = Controller.GetState();
                lastLTrigger = LeftTrigger;
                lastRTrigger = RightTrigger;
            }

        }

        public readonly UserIndex UserIndex;
        public readonly Controller Controller;

        public DPadState DPad { get; private set; }
        public ThumbstickState LeftStick { get; private set; }
        public ThumbstickState RightStick { get; private set; }

        public bool A { get; private set; }
        public bool B { get; private set; }
        public bool X { get; private set; }
        public bool Y { get; private set; }

        public bool RightShoulder { get; private set; }
        public bool LeftShoulder { get; private set; }

        public bool Start { get; private set; }
        public bool Back { get; private set; }

        public bool RightTrigger { get; private set; }
        public bool LeftTrigger { get; private set; }

        public bool Connected
        {
            get { return Controller.IsConnected; }
        }

        private bool isSameState(State state)
        {
            var gamepadState = state.Gamepad;
            if ((LeftShoulder == ((gamepadState.Buttons & GamepadButtonFlags.LeftShoulder) != 0)) &&
                (RightShoulder == ((gamepadState.Buttons & GamepadButtonFlags.RightShoulder) != 0)) &&
                (LeftTrigger == ((gamepadState.LeftTrigger / (float)byte.MaxValue) > 0.1)) &&
                (RightTrigger == ((gamepadState.RightTrigger / (float)byte.MaxValue) > 0.1)) &&
                (Start == ((gamepadState.Buttons & GamepadButtonFlags.Start) != 0)) &&
                (Back == ((gamepadState.Buttons & GamepadButtonFlags.Back) != 0)) &&
                (A == ((gamepadState.Buttons & GamepadButtonFlags.A) != 0)) &&
                (B == ((gamepadState.Buttons & GamepadButtonFlags.B) != 0)) &&
                (X == ((gamepadState.Buttons & GamepadButtonFlags.X) != 0)) &&
                (Y == ((gamepadState.Buttons & GamepadButtonFlags.Y) != 0)) &&
                (DPad.Up == ((gamepadState.Buttons & GamepadButtonFlags.DPadUp) != 0)) &&
                (DPad.Down == ((gamepadState.Buttons & GamepadButtonFlags.DPadDown) != 0)) &&
                (DPad.Left == ((gamepadState.Buttons & GamepadButtonFlags.DPadLeft) != 0)) &&
                (DPad.Right == ((gamepadState.Buttons & GamepadButtonFlags.DPadRight) != 0)) &&
                (LeftStick.Clicked == ((gamepadState.Buttons & GamepadButtonFlags.LeftThumb) != 0)) &&
                (RightStick.Clicked == ((gamepadState.Buttons & GamepadButtonFlags.RightThumb) != 0))
                )
                return true;


            return false;
        }

        public bool Update()
        {
            // If not connected, nothing to update
            if (!Connected) return false;

            // If same packet, nothing to update
            State state = Controller.GetState();
            
            if (lastPacket == state.PacketNumber) return false;
            lastPacket = state.PacketNumber;

            if (isSameState(state))
            {
                return false;
            }

            var gamepadState = state.Gamepad;

            // Shoulders
            LeftShoulder = (gamepadState.Buttons & GamepadButtonFlags.LeftShoulder) != 0;
            RightShoulder = (gamepadState.Buttons & GamepadButtonFlags.RightShoulder) != 0;

            // Triggers
            LeftTrigger = (gamepadState.LeftTrigger / (float) byte.MaxValue) > 0.1;
            RightTrigger = (gamepadState.RightTrigger / (float) byte.MaxValue) > 0.1;

            // Buttons
            Start = (gamepadState.Buttons & GamepadButtonFlags.Start) != 0;
            Back = (gamepadState.Buttons & GamepadButtonFlags.Back) != 0;

            A = (gamepadState.Buttons & GamepadButtonFlags.A) != 0;
            B = (gamepadState.Buttons & GamepadButtonFlags.B) != 0;
            X = (gamepadState.Buttons & GamepadButtonFlags.X) != 0;
            Y = (gamepadState.Buttons & GamepadButtonFlags.Y) != 0;

            // D-Pad
            DPad = new DPadState((gamepadState.Buttons & GamepadButtonFlags.DPadUp) != 0,
                                 (gamepadState.Buttons & GamepadButtonFlags.DPadDown) != 0,
                                 (gamepadState.Buttons & GamepadButtonFlags.DPadLeft) != 0,
                                 (gamepadState.Buttons & GamepadButtonFlags.DPadRight) != 0);

            // Thumbsticks
            LeftStick = new ThumbstickState(
                Normalize(gamepadState.LeftThumbX, gamepadState.LeftThumbY, Gamepad.GamepadLeftThumbDeadZone),
                (gamepadState.Buttons & GamepadButtonFlags.LeftThumb) != 0);
            RightStick = new ThumbstickState(
                Normalize(gamepadState.RightThumbX, gamepadState.RightThumbY, Gamepad.GamepadRightThumbDeadZone),
                (gamepadState.Buttons & GamepadButtonFlags.RightThumb) != 0);
            
            
            return true;
        }

        static Vector2 Normalize(short rawX, short rawY, short threshold)
        {
            var value = new Vector2(rawX, rawY);
            var magnitude = value.Length();
            var direction = value / (magnitude == 0 ? 1 : magnitude);

            var normalizedMagnitude = 0.0f;
            if (magnitude - threshold > 0)
                normalizedMagnitude = Math.Min((magnitude - threshold) / (short.MaxValue - threshold), 1);

            return direction * normalizedMagnitude;
        }

        public struct DPadState
        {
            public readonly bool Up, Down, Left, Right;

            public DPadState(bool up, bool down, bool left, bool right)
            {
                Up = up; Down = down; Left = left; Right = right;
            }
        }

        public struct ThumbstickState
        {
            public readonly Vector2 Position;
            public readonly bool Clicked;

            public ThumbstickState(Vector2 position, bool clicked)
            {
                Clicked = clicked;
                Position = position;
            }
        }
    }

    public static class MathHelper
    {
        public static float Saturate(float value)
        {
            return value < 0 ? 0 : value > 1 ? 1 : value;
        }
    }
}
