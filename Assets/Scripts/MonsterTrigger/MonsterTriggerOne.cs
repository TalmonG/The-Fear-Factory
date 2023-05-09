using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterTriggerOne : MonoBehaviour
{
    [SerializeField] private Animator animator;
    public GameObject monster;
    public bool m_Play;
    AudioSource m_MyAudioSource;
    public GettingCaughtVideoScript gettingCaughtVideoScript;




    // Start is called before the first frame update
    void Awake()
    {
        monster.SetActive(false);
        m_MyAudioSource = GetComponent<AudioSource>();
        m_Play = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (m_Play == false && gettingCaughtVideoScript.isplayercaught == true)
        {
            //m_MyAudioSource.Stop();

        }
    }

    void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            monster.SetActive(true);
            animator.SetBool("MonsterCrawlOne", true);
            Debug.Log("Animation MonsterCrawlOne was played");
            FindObjectOfType<AudioManager>().Play("Chase2");
            m_Play = true;
        }

        if (gettingCaughtVideoScript.isplayercaught == true)
        {
            monster.SetActive(false);

            FindObjectOfType<AudioManager>().Stop("Chase");

        }


    }
}
