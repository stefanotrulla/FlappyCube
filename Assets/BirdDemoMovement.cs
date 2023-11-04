using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BirdDemoMovement : MonoBehaviour
{

    //public float life = 20;
    // Start is called before the first frame update
    void Start()
    {
       //suggerito da google ACanva = GetComponent<AppearCanva>();
    }
    
    public AppearCanva ACanva;
    
    // Update is called once per frame
    void Update()
    {
        
        if (ACanva.activatesasso == false)
        {
            //life -= Time.deltaTime;
            // if (life <= 0) Destroy(gameObject);
            // else
            transform.Translate(0, 0, 1 * Time.deltaTime);
            
        }
    }
}
