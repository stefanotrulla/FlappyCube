using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveMainCharacterScript : MonoBehaviour
{
    float px;
    float py;
    float pz;
    public float InputY;
    public float InputX;
    //noi la creiamo qui
    private Vector3 JumpVector = new Vector3(0f, 2f, 0f);
    // Start is called before the first frame update

    public Rigidbody Rigidbody;
    public AppearCanva ACanva;
    
    void Start()
    {
        Rigidbody= GetComponent<Rigidbody>();
        px = -0.014f;
        py = 4.727f;
        pz = 6.96f;
        this.transform.position = new Vector3(px, py, pz);
        
    }

    // Update is called once per frame
    void Update()
    {
        this.Rigidbody.useGravity = true;
        if (ACanva.activatesasso == true)
        {
           
            this.Rigidbody.isKinematic= true;
            this.Rigidbody.useGravity = false;
        }
        else
        { 
            
            this.Rigidbody.isKinematic= false;
            this.Rigidbody.useGravity = true;
        

        }


        if (Input.GetButton("Jump") == true)
        {
            print("Tasto Jump premuto");

            //applichiamo forza a rigidbody (impulso) 
            this.transform.GetComponent<Rigidbody>().AddForce(JumpVector, ForceMode.Impulse);
            //"Rigidbody è il component che è stata aggiunta al cubo (manualmente)
            // in AddForze ( è | primo è il vettore | il secondo |tipo di forza|
        }

        if (Input.GetKeyDown("j") == true) //Come posso fare combinazioni? shift + j o renderlo cambiabile (programmazione tasti)
        {
            print("Tasto j premuto");

        }
    }
     void OnCollisionEnter(Collision collision)
    {   //questo print permette di capire con che cosa ho colpito
        print("Collisione!!! con: " + collision.gameObject.tag);



        if (collision.transform.tag == "Obstacle")
        {
            print("Questa è un Cube (1)");
            //ricarica la scena
            SceneManager.LoadScene("SampleScene");
            Punteggio.Score = 0;

        }
        /*if (collision.transform.name == "Cube (1)")
        {
            print("Questa è un Cube (1)");
            //ricarica la scena
            // SceneManager.LoadScene("nome scena");
            SceneManager.LoadScene("SampleScene");

        }
        */
        if (collision.transform.name == "Cube (3)")
        {
            print("Questa è un Cube (3)");
            //ricarica la scena
            // SceneManager.LoadScene("nome scena");
            //SceneManager.LoadScene("SampleScene");

        }
        
        if (collision.transform.tag == "ObstaclePoint")
        {
            print("Questa è un Cube(3)");
            

        }
    }
    /*
    private void OnTriggerEnter(Collider other)
    {
        MoveMainCharacterScript component = other.gameObject.GetComponent<MoveMainCharacterScript>();
        if(component != null)
        {
            print("Questo è il collider figo!!!");
        }
    }*/
}
