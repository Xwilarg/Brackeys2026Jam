using Ink.UnityIntegration;
using Sketch.FPS;
using Sketch.VN;
using Sketch.VN.InkleInk;
using UnityEngine;

namespace BrackeysJam.Prop
{
    public class Door : MonoBehaviour, IInteractable
    {
        [SerializeField]
        private InkFile _story;

        public GameObject GameObject => gameObject;

        public bool CanInteract(PlayerController pc)
        {
            return true;
        }

        public string DenySentence(PlayerController pc)
        {
            throw new System.NotImplementedException();
        }

        public void Interact(PlayerController pc)
        {
            VNManager.Instance.ShowStory(new InkStory(_story));
            Debug.Log("hello");
        }

        public string InteractionVerb(PlayerController pc)
        {
            return "speak";
        }
    }
}
