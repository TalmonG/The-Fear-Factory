using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteFive : MonoBehaviour
{
    public NoteButtonsFive noteButtonsFive;
    public MouseLook mouseLook;
    public Accessibility accessibility;

    public GameObject noteFiveObject;
    public GameObject noteUIFiveObject;

    public GameObject e;
    public bool ableCollectNoteFive;

    void Awake()
    {
        noteUIFiveObject.SetActive(false);
    }

    void Start()
    {
        e.SetActive(false);
        noteUIFiveObject.SetActive(false);
        ableCollectNoteFive = true;


    }

    void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            e.SetActive(true);
        }
    }

    void OnTriggerStay(Collider player)
    {
        if (Input.GetKeyDown(KeyCode.E) && ableCollectNoteFive == true)
        {
            noteUIFiveObject.SetActive(true);
            FindObjectOfType<AudioManager>().Play("Click");
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            mouseLook.isMousePaused = true;
            ableCollectNoteFive = false;

            if (accessibility.IsNarratorEnabled == true)
            {
                FindObjectOfType<AudioManager>().Play("Note 5");
            }

        }

        if (noteButtonsFive.isCollectedNoteFive == true && ableCollectNoteFive == true)
        {
            noteFiveObject.SetActive(false);
            ableCollectNoteFive = false;
        }
    }

    void OnTriggerExit(Collider player)
    {
        e.SetActive(false);

    }
}
