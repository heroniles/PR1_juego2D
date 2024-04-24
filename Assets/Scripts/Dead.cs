using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dead : MonoBehaviour

{
    private GameObject personaje;
    private MovPersonaje movPersonaje;
    // Start is called before the first frame update
    void Start()
    {
        personaje = GameObject.Find("Personaje");
        movPersonaje= personaje.GetComponent<MovPersonaje>();
        //movPersonaje.Respawnear();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col){
        Debug.Log(col.name);

        if (col.name=="Personaje")
        {
           audioManager.Instance.SonarClipUnaVez( audioManager.Instance.fxDead);
            movPersonaje.Respawnear();
        }
    }
}
