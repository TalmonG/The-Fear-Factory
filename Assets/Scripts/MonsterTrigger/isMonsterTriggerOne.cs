using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class isMonsterTriggerOne : MonoBehaviour
{

    public GettingCaughtVideoScript gettingCaughtVideoScript;
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
        }
    }

    void OnTriggerStay(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            gettingCaughtVideoScript.isplayercaught = true;
        }
    }
}
