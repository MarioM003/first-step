using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    public float speed;
    public float dirX;
    public SpriteRenderer spr;

    void Start()
    {
        
    }

    void Update()
    {
        dirX = Input.GetAxis("Horizontal");

        transform.position += new Vector3(dirX * speed,0,0);

        if(dirX > 0){
            spr.flipX =false;
        }
        if(dirX < 0){
            spr.flipX=true;
        }
    }

}
