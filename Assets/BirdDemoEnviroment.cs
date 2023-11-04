using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BirdDemoEnviroment : MonoBehaviour
{
    public AppearCanva ACanva;
    public float sendTimer = 0;
    public float frequency = 9.93f;
    public GameObject floor;
    public AppearCanva ACanvaGO;
    private GameObject a;
    // Start is called before the first frame update
    void Start()
    {
        //valorizzo in real time (come se trascinassi l'oggetto nell'ispector dello script)
        //insieme a questo script 1234!!!
        ACanvaGO = GameObject.Find("Panel").transform.GetComponent<AppearCanva>();
        
    }
    
    // Update is called once per frame
    void Update()
    {
        sendTimer -= Time.deltaTime;
        if(sendTimer <= 0 && ACanva.activatesasso == false)
        {
            a = Instantiate( floor, new Vector3(0f, 0f, -20f), transform.rotation );

            //script docente per creare e trasformare il floor in gameobject
            //insieme a questo script 1234!!!
            a.transform.GetComponent<BirdDemoMovement>().ACanva = ACanvaGO;
            sendTimer = frequency;
            
        }
    }
}
