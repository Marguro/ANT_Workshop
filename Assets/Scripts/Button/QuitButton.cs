using UnityEngine;

public class QuitButton : MonoBehaviour
{
    public void OnPressQuitButton()
    {
        Application.Quit();
        Debug.Log("Quit Game");
    }
}
