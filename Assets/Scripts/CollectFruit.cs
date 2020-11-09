using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectFruit : MonoBehaviour
{
    public GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) {

        if(tag == "Pina")
        {
            gameManager.sumarFrutas(6);
        }
        else if(tag == "Sandia" || tag == "Banano")
        {
            gameManager.sumarFrutas(4);
        }
        else
        {
            gameManager.sumarFrutas(2);
        }
        
        //Debug.Log(gameManager.getVidaTotal());
        Destroy(gameObject);
    }
}
