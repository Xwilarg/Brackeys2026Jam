using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace BrackeysJam.Manager
{
    public class GameManager : MonoBehaviour
    {
        private void Awake()
        {
            if (!SceneManager.GetAllScenes().Any(x => x.name == "Motel"))
            {
                SceneManager.LoadScene("Motel");
            }
        }
    }
}
