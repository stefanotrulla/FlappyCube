using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class AppearCanva : MonoBehaviour
{
     public bool activatesasso = false;
    // Start is called before the first frame update
    void Start()
    {

    }
   





    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("m"))
        {

            this.transform.GetComponent<Animator>().SetTrigger("Testo in");
            //setta il trigger on e quindi fa partire l'animazione 

            Time.timeScale = 0f;
            print("Tempo: " + Time.timeScale);
            
            if (activatesasso == true)
            {
                Time.timeScale = 1f;
                activatesasso = false;
            }
            else
            {
                activatesasso = true;
            }
            
        }
        


    }


    void Myfunction()
    {

        print("Myfunction called!");

    }
}
