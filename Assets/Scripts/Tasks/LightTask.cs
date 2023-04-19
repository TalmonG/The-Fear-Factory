using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightTask : MonoBehaviour
{
    [Header("Card Swipers Unlocked?")]
    public bool lightSwitchStatus = false;

    public GameObject lights;

    public GameObject EPrompt;
    private void Awake()
    {
        EPrompt.SetActive(false);
        lightSwitchStatus = false;
        lights.SetActive(false);
    }

    void OnTriggerStay(Collider player)
    {
        if (Input.GetKeyDown(KeyCode.E) && lightSwitchStatus == false)
        {
            FindObjectOfType<AudioManager>().Play("Click");
            lightSwitchStatus = true;
            Debug.Log("It was Switched");
            EPrompt.SetActive(false);
            lights.SetActive(true);
            Debug.Log("Lights are turned on now!");
        }
    }

    IEnumerator RedKeyCardTextTimer()
    {
        yield return new WaitForSecondsRealtime(5);
    }

    void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player" && lightSwitchStatus == false)
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
}
