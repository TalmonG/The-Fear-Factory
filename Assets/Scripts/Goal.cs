using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Goal : MonoBehaviour
{
    public MouseLook mouseLook;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(3);
            Cursor.lockState = CursorLockMode.None;
            mouseLook.isMousePaused = false;
        }
    }
}
