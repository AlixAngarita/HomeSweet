using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarController : MonoBehaviour
{
    public float width = 140f;
    public GameManager manager;
    public int life;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        life = manager.getVidaTotal();
        var theBarRectTransform = transform as RectTransform;
        theBarRectTransform.sizeDelta = new Vector2 (life * 1, theBarRectTransform.sizeDelta.y);    
    }
}
