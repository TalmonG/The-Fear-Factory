using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class KeyPad : MonoBehaviour
{
    public GameObject keypad;
    public MouseLook mouseLook;
    public GameObject EPrompt;
    public FinalDoor finalDoor;

    string Code = "73079";
    string Nr = null;
    int NrIndex = 0;
    string alpha;
    public Text UiText = null;

    public bool isAbleToOpenFinalDoor;

    private void Awake()
    {
        EPrompt.SetActive(false);
        keypad.SetActive(false);
    }

    public void Start()
    {
        keypad.SetActive(false);
    }

    void OnTriggerStay(Collider player)
    {
        if (Input.GetKeyDown(KeyCode.E) || (Input.GetKeyDown(KeyCode.U)))
        {
            if (finalDoor.isFinalDoorOpen == false)
            {
                FindObjectOfType<AudioManager>().Play("Click");
                EPrompt.SetActive(false);
                keypad.SetActive(true);
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                mouseLook.isMousePaused = true;
            }
        }
    }

    void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player" && finalDoor.isFinalDoorOpen == false)
        {
            EPrompt.SetActive(true);
        }
    }

    void OnTriggerExit(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            EPrompt.SetActive(false);
        }
    }


    public void CodeFunction(string Numbers)
    {
        NrIndex++;
        Nr = Nr + Numbers;
        UiText.text = Nr;

    }
    public void Enter()
    {
        if (Nr == Code)
        {
            Debug.Log("Door Opened, Quickly Run!(final door animations plays here)");
            finalDoor.isFinalDoorOpen = true;

            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            mouseLook.isMousePaused = false;

            keypad.SetActive(false);

        }
    }
    public void Delete()
    {
        NrIndex++;
        Nr = null;
        UiText.text = Nr;
    }
}