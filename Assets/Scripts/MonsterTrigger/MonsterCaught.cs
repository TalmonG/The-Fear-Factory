using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterCaught : MonoBehaviour
{
    public GameObject caughtCutScene;

    public GettingCaughtVideoScript gettingCaughtVideoScript;
    // Start is called before the first frame update
    void Start()
    {

        //caughtCutScene.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // trash script
    void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            gettingCaughtVideoScript.isplayercaught = true;
            gettingCaughtVideoScript.VideoScreen.SetActive(true);
            //caughtCutScene.SetActive(true);
        }
    }
}
