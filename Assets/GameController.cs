
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GamePauseMenu pauseMenu;

    public void OnPauseButton()
    {
        pauseMenu.Open();
    }

}
