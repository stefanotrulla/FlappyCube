using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Istrigger : MonoBehaviour
{
    
    //public GameObject MainCube;
    private void OnTriggerEnter(Collider other)
    {
        //print("Trigger enter " + other.gameObject.name);
        
        MoveMainCharacterScript component = other.gameObject.GetComponent<MoveMainCharacterScript>();
        if (component != null)
        {
            Punteggio.Score += 1;
            

            print("Questo è il collider figo!!!");
        }
    }
}
