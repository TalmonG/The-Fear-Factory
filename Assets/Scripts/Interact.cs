using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    // Referencing
    public KeyCards KeyCards;

    public Accessibility IsNarratorEnabled;
    public Accessibility IsSubtitlesEnabled;

    // Red Key Card
    public GameObject RedInteractEImage;
    public GameObject RedE;
    public bool RedKeyCardCollectable;
    public GameObject RedKeyCard;
    public GameObject RedKeyCardCollected;

    //KeyCards
    public GameObject RedKeyCardGameObject;



    // Start is called before the first frame update
    void Start()
    {
        RedInteractEImage.SetActive(false);
        RedKeyCardCollected.SetActive(false);
        RedE.SetActive(false);
        RedKeyCardCollectable = false;
    }

    void Update()
    {
        
    }

    void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            RedInteractEImage.SetActive(true);
            RedE.SetActive(true);
            RedKeyCardCollectable = true;
        }
    }

    void OnTriggerStay(Collider player)
    {
        if (Input.GetKeyDown(KeyCode.E) && RedKeyCardCollectable == true)
        {
            FindObjectOfType<AudioManager>().Play("Click");
            RedKeyCardCollected.SetActive(true);
            KeyCards.redKeyCard = true;
            RedKeyCardGameObject.SetActive(false);

        }

    }

    void OnTriggerExit(Collider player)
    {
        
        RedInteractEImage.SetActive(false);
        RedE.SetActive(false);
        RedKeyCardCollectable = false;
        
    }

}
