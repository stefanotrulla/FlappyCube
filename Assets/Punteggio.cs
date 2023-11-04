using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Punteggio : MonoBehaviour
{
    public Text PunteggioCounter;
    //static importante e mi collego a Istrigger
    public static float Score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PunteggioCounter.text = Score.ToString();
    }
}
