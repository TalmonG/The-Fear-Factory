using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardSwipers : MonoBehaviour
{
    public KeyCards KeyCards;
    public Dialogue dialogue;
    //public GameObject redKeyCardTextGameObject;



    [Header("Card Swipers")]
    public GameObject redCardSwiper_StatusDenied;
    public GameObject redCardSwiper_StatusGranted;

    [Header("Card Swipers Unlocked")]
    public bool redCardSwiperUnlockStatus = false;

    public bool redCardSwiperUsable;

    public GameObject redCardSwiperE;

    public GameObject redKeyCardText;

    private void Awake()
    {
        redCardSwiperUsable = false;
        redCardSwiper_StatusDenied.SetActive(true);
        redCardSwiper_StatusGranted.SetActive(false);
        redCardSwiperE.SetActive(false);
        redKeyCardText.SetActive(false);



    }

    void Update()
    {
        if (Input.GetKey(KeyCode.E) && KeyCards.redKeyCard == true)
        {
        
        }
    }

    void OnTriggerStay(Collider player)
    {
        if (Input.GetKeyDown(KeyCode.E) && KeyCards.redKeyCard == true)
        {
            FindObjectOfType<AudioManager>().Play("Click");
            redCardSwiper_StatusDenied.SetActive(false);
            redCardSwiper_StatusGranted.SetActive(true);
            redCardSwiperUnlockStatus = true;
            Debug.Log("access granted");


        }

        if (Input.GetKeyDown(KeyCode.E) && KeyCards.redKeyCard == false)
        {
            redKeyCardText.SetActive(true);
            redKeyCardText.SetActive(true);
            FindObjectOfType<AudioManager>().Play("Red Key Card");
            Debug.Log("I think i need a red KeyCard. Should be around here somewhere.");
            StartCoroutine(RedKeyCardTextTimer());



        }
    }

    IEnumerator RedKeyCardTextTimer()
    {
        redKeyCardText.SetActive(true);
        yield return new WaitForSecondsRealtime(5);
        redKeyCardText.SetActive(false);
    }

    public void SpawnRedKeyCardTextGameObject()
    {
        //dialogue.DestroyObjectDelayed();
    }

    void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player" && redCardSwiperUnlockStatus == false)
        {
            redCardSwiperE.SetActive(true);
            redCardSwiperUsable = true;

            if (player.gameObject.tag == "Player" && KeyCards.redKeyCard == false)
            {
                Debug.Log("Find a red Keycard First!");
            }
        }
    }

    void OnTriggerExit(Collider player)
    {
        if (player.gameObject.tag == "Player" && redCardSwiperUnlockStatus == false)
        {
            redCardSwiperE.SetActive(false);
            redCardSwiperUsable = false;
        }
    }
}
