using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    public void OnPressRestartButton()
    {
        SceneManager.LoadScene("Gameplay");
        Debug.Log("Restart Game");
    }
}
