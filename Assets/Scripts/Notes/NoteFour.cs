using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteFour : MonoBehaviour
{
    public NoteButtonsFour noteButtonsFour;
    public MouseLook mouseLook;
    public Accessibility accessibility;

    public GameObject noteFourObject;
    public GameObject noteUIFourObject;
    public bool isNoteCollected;

    public GameObject e;
    public bool ableCollectNoteFour;

    void Awake()
    {
        noteUIFourObject.SetActive(false);
        isNoteCollected = false;
    }

    void Start()
    {
        e.SetActive(false);
        noteUIFourObject.SetActive(false);
        ableCollectNoteFour = true;


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
        if (Input.GetKeyDown(KeyCode.E) || (Input.GetKeyDown(KeyCode.U)))
        {
            if (ableCollectNoteFour == true)
            {
                noteUIFourObject.SetActive(true);
                FindObjectOfType<AudioManager>().Play("Click");
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                mouseLook.isMousePaused = true;
                ableCollectNoteFour = false;

                if (accessibility.IsNarratorEnabled == true)
                {
                    FindObjectOfType<AudioManager>().Play("Note 4");
                }
                isNoteCollected = true;
            }
        }

        if (noteButtonsFour.isCollectedNoteFour == true && ableCollectNoteFour == true)
        {
            noteFourObject.SetActive(false);
            ableCollectNoteFour = false;
        }
    }

    void OnTriggerExit(Collider player)
    {
        e.SetActive(false);

    }
}
