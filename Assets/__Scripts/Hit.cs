using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Hit : MonoBehaviour
{

    TMP_Text hitsCounterText;
    public static int hitsCounter;

    // Use this for initialization
    void Start()
    {
        hitsCounter = 0;
        hitsCounterText = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        hitsCounterText.text = "Score: " + hitsCounter;
    }
}