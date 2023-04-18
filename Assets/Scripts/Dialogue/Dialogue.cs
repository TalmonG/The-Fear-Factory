using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogue : MonoBehaviour
{
    public CardSwipers cardSwipers;

    public TextMeshProUGUI textComponent;
    public float textSpeed;
    public int timerBeforeDestroy;

    private int index;
    [TextArea(7, 10)]
    public string[] sentences;



    // Start is called before the first frame update
    void Start()
    {
        textComponent.text = string.Empty;
        StartDialogue();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (textComponent.text == sentences[index])
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                textComponent.text = sentences[index];
            }
        }
    }

    void StartDialogue()
    {
        index = 0;
        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine()
    {
        foreach (char c in sentences[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    void NextLine()
    {
        if (index < sentences.Length - 1)
        {
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            gameObject.SetActive(false);
        }
    }

    public void DestroyObjectDelayed()
    {
        // Kills the game object in 5 seconds after loading the object
        Destroy(gameObject, timerBeforeDestroy);
        Debug.Log("Destroying object in: " + timerBeforeDestroy);
    }

    public void SpawnRedKeyCardTextGameObject()
    {
        //GameObject newBullet = Instantiate(cardSwipers.redKeyCardTextGameObject, transform.position, transform.rotation);
        DestroyObjectDelayed();
    }
}
