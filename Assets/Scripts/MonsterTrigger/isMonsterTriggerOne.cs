using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class isMonsterTriggerOne : MonoBehaviour
{

    public GettingCaughtVideoScript gettingCaughtVideoScript;
    public MonsterTriggerOne monsterTriggerOne;
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
            gettingCaughtVideoScript.isplayercaught = true;
            monsterTriggerOne.m_Play = false;
        }
    }

    void OnTriggerStay(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            gettingCaughtVideoScript.isplayercaught = true;
            monsterTriggerOne.m_Play = false;
        }
    }
}
