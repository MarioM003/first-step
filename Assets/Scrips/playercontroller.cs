using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    bool canJump;
    void Start()
    {
    }

    void Update()
    {
        
        if (Input.GetKey("left"))
        {
            gameObject.transform.Translate(-10f * Time.deltaTime, 0, 0);
            
        }
        if (Input.GetKey("right"))
        {
            gameObject.transform.Translate(10f * Time.deltaTime, 0, 0);
            
        }

        // Llama a ManageJump en cada actualización
        ManageJump();
    }

    void ManageJump()
    {
        if (gameObject.transform.position.y <= 0)
        {
            canJump = true;
        }

        if (Input.GetKey("up") && canJump && gameObject.transform.position.y < 10)
        {
            gameObject.transform.Translate(0, 50f * Time.deltaTime, 0);
        }
        else
        {
            canJump = false;

            if (gameObject.transform.position.y > 0)
            {
                gameObject.transform.Translate(0, -5f * Time.deltaTime, 0);
            }
        }
    }
    
}
