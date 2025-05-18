using TMPro;
using UnityEngine;

public class GameResultUI : MonoBehaviour
{
    public TMP_Text resultText; 

    public void ShowResult(bool isWin)
    {
        if (isWin)
        {
            resultText.text = "You Win!";
            resultText.color = Color.green;
        }
        else
        {
            resultText.text = "You Lose!";
            resultText.color = Color.red;
        }
    }
}