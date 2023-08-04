using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salto : MonoBehaviour
{
    public Rigidbody2D rbd;
    public float fuerza;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            rbd.AddForce(Vector2.up * fuerza, ForceMode2D.Impulse);
        }
    }
}
