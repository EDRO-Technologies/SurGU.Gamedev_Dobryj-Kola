using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Drone
{
    [RequireComponent(typeof(PlayerInput))]
    public class DroneInputs : MonoBehaviour
    {
        private float _pitch;
        private float _yaw;
        private float _roll;
        private float _throttle;
        private bool _enbleVisual = false;
        public float Pitch { get => _pitch; set => _pitch = value; }
        public float Yaw { get => _yaw; set => _yaw = value; }
        public float Roll { get => _roll; set => _roll = value; }
        public float Throttle { get => _throttle; set => _throttle = value; }
        public bool EnbleVisual { get => _enbleVisual; set => _enbleVisual = value; }

        public System.Action onReset;
        public System.Action requestPause;
        public bool savePower = false;

        public void OnPitch(InputValue value)
        {
            _pitch = value.Get<float>();
        }
        public void OnYaw(InputValue value)
        {
            _yaw = value.Get<float>();
        }
        public void OnRoll(InputValue value)
        {
            _roll = value.Get<float>();
        }
        public void OnThrottle(InputValue value)
        {
            _throttle = value.Get<float>();
        }
        public void OnResetDrone()
        {
            onReset?.Invoke();
        }
        public void OnToggleVisualization()
        {
            _enbleVisual = !_enbleVisual;
        }
    }
}
