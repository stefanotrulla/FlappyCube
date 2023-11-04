using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdDemoObstacles : MonoBehaviour
{

    public float sendTimer = 1;
    public float frequency = 2;
    public float position;
    public GameObject myObstacle;
    public GameObject mainCharacter;
    private GameObject a;
    public GameObject planeGO;
    // Update is called once per frame
     void Start()
    {
        
    }

    public AppearCanva ACanva;

    void Update()
     
    {


        /*

        if (ACanva.activatesasso == true)
        {
            print("Active Sasso = true");
        }
        if(ACanva.activatesasso == false)
        { 
        
        Corpo codice
        
        
        }


        */

        //Time.unscaledDeltaTime --> ignora le istruzioni del delta time quindio se io imposto il tempo a 0 e uso questa funzione il blocco continua a girare 
        sendTimer -= Time.deltaTime;
            if (sendTimer <= 0f  && ACanva.activatesasso == false)
            {

                position = Random.Range(.68f, 2f);
                transform.position = new Vector3(0, position, -3.7f);

                a = Instantiate(myObstacle, transform.position, transform.rotation);
                a.transform.parent = planeGO.transform;
                sendTimer = frequency;


            }

            if (mainCharacter != null) Time.timeScale = 1;
            else Time.timeScale = 0;
        }
    }



