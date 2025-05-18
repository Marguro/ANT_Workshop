using Cinemachine;
using UnityEngine;

public class CinemachineBrainController : MonoBehaviour
{

    public void Enable()
    {
        GetComponent<CinemachineBrain>().enabled = true;
    }
    
    public void Disable()
    {
        GetComponent<CinemachineBrain>().enabled = false;
    }
}