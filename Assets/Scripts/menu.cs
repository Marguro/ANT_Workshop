using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public void OnPressStartGame()
    {
        SceneManager.LoadScene("GamePlay");
    }
    public void OnPressExitGame()
    {
        Application.Quit();
        Debug.Log("Exit Game");
    }
}
