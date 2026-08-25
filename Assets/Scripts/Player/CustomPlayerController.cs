using Sketch.FPS;
using Sketch.VN;
using UnityEngine.InputSystem;

namespace BrackeysJam.Player
{
    public class CustomPlayerController : PlayerController
    {
        public override float GetSpeed(float baseSpeed)
        {
            return VNManager.Instance.IsStoryOngoing ? 0f : base.GetSpeed(baseSpeed);
        }

        public void OnMovementOverrides(InputAction.CallbackContext value)
        {
            OnMovement(value);
        }

        public void OnLookOverrides(InputAction.CallbackContext value)
        {
            if (!VNManager.Instance.IsStoryOngoing)
            {
                OnLook(value);
            }
        }

        public void OnInteractOverrides(InputAction.CallbackContext value)
        {
            if (VNManager.Instance.IsStoryOngoing)
            {
                VNManager.Instance.OnNextDialogue(value);
            }
            else
            {
                OnInteract(value);
            }
        }
    }
}
