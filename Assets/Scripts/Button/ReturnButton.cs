using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnButton : MonoBehaviour
{
    public void OnPressReturnButton()
    {
        SceneManager.LoadScene("MainMenu");
        Debug.Log("Return to Main Menu");
    }
}
