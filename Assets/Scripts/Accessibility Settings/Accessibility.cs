using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accessibility : MonoBehaviour
{

    public bool IsNarratorEnabled;
    public bool IsSubtitlesEnabled;

    // Start is called before the first frame update
    void Start()
    {
        IsNarratorEnabled = true;
        IsSubtitlesEnabled = true;
    }

    // Update is called once per frame
    void Update()
    {

        if (IsNarratorEnabled == true)
        {

        }
    }

    public void CheckNarrator (bool on)
    {
        if (on)
        {
            Debug.Log("ON");
        }
        else
        {
            Debug.Log("OFF");
        }

    }
}
