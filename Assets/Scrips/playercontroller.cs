using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    
    public float FuerzaSalto = 10f;
    public Transform Checker;
    public float RadioDeChecker = 0.2f;
    public LayerMask mascaraSuelo;
    public bool enSuelo;
    private Rigidbody2D rigidBody;
    
    void Start()
    {
        rigidBody= GetComponent<Rigidbody2D>();
        
    }

    void Update()
    {
        
        if (Input.GetKey("left"))
        {
            gameObject.transform.Translate(-08f * Time.deltaTime, 0, 0);
            
        }
        if (Input.GetKey("right"))
        {
            gameObject.transform.Translate(08f * Time.deltaTime, 0, 0);
            
        } 

        enSuelo =Physics2D.OverlapCircle(Checker.position,RadioDeChecker,mascaraSuelo);

        if(enSuelo==true && Input.GetKeyDown(KeyCode.Space)){
            ManageJump();
        }
        
    }
    void checkGrounded()
    {       
            
    }
    void ManageJump()
    {       
            rigidBody.velocity = new Vector2(rigidBody.velocity.x, 0f);
            rigidBody.AddForce(Vector2.up * FuerzaSalto,ForceMode2D.Impulse);
    }
    
}
