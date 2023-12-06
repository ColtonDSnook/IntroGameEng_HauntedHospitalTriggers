using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScreen : MonoBehaviour
{
    public GameObject player;
    public GameObject endScreen;
    public GameObject endCam;
    // Start is called before the first frame update
    public void End()
    {
        endScreen.SetActive(true);
        endCam.SetActive(true);
        player.SetActive(false);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
