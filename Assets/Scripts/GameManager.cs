using TMPro;
using UnityEngine;
using UnityEngine.Rendering.Universal.Internal;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject GameplayCanvas;
    public GameObject GameResultCanvas;
    public GameObject MainCamara;
    public static GameManager instance;

    public float timeCounter = 30f;
    public ItemData targetItem;
    public int targetAmout = 5;

    public TMP_Text timeCounterText;
    public Image targetItemIcon;
    public TMP_Text targetCurrentAmountText;

    public bool isPlayerWin = false;
    
    public InventoryPanel inventoryPanel;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }


    public void OpenInventoryPanel()
    {
        inventoryPanel.gameObject.SetActive(true);
        inventoryPanel.OnOpen();
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        MainCamara.GetComponent<CinemachineBrainController>().Disable();
        Time.timeScale = 0f;
    }

    public void CloseInventoryPanel()
    {
        inventoryPanel.gameObject.SetActive(false);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        MainCamara.GetComponent<CinemachineBrainController>().Enable();
        Time.timeScale = 1f;
    }
    

    private void Start()
    {
        targetItemIcon.sprite = targetItem.itemIcon;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1f;
    }

    private void Update()
    {
        if (isPlayerWin)
        {
            GameplayCanvas.SetActive(false);
            GameResultCanvas.SetActive(true);
            GameResultCanvas.GetComponent<GameResultUI>().ShowResult(true);
            MainCamara.GetComponent<CinemachineBrainController>().Disable();
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            Time.timeScale = 0f;
            return;
        }

        if (timeCounter > 0f)
        {
            timeCounter -= Time.deltaTime;
            timeCounterText.text = timeCounter.ToString();
            targetCurrentAmountText.text = "x " + (targetAmout - InventoryManager.instance.GetItemAmount(targetItem)).ToString();

            if (InventoryManager.instance.GetItemAmount(targetItem) >= targetAmout)//player win
            {
                Debug.Log("Player Win");
                isPlayerWin = true;
            }
        }
        else // player lose
        {
            GameplayCanvas.SetActive(false);
            GameResultCanvas.SetActive(true);
            GameResultCanvas.GetComponent<GameResultUI>().ShowResult(false);
            MainCamara.GetComponent<CinemachineBrainController>().Disable();
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            Time.timeScale = 0f;
        }
        
    }
}
