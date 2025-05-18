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
        }
        else
        {
            resultText.text = "You Lose!";
        }
    }
}