using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    
    public float FuerzaSalto = 10f;
    public Transform Checker;
    public float TiempoEntreSaltos = 1f; // Tiempo en segundos entre saltos
    private float tiempoDesdeUltimoSalto = 0f;
    public float RadioDeChecker = 0.2f;
    public LayerMask mascaraSuelo;
    public bool enSuelo;
    private Rigidbody2D rigidBody;
    public float velocidad;
    
    void Start()
    {
        rigidBody= GetComponent<Rigidbody2D>();
        
    }

    void Update()
    {
        
        if (Input.GetKey("left"))
        {
            gameObject.transform.Translate(-velocidad * Time.deltaTime, 0, 0);
            
        }
        if (Input.GetKey("right"))
        {
            gameObject.transform.Translate(velocidad * Time.deltaTime, 0, 0);
            
        } 

        enSuelo =Physics2D.OverlapCircle(Checker.position,RadioDeChecker,mascaraSuelo);

        if(enSuelo==true && Input.GetKeyDown(KeyCode.Space) && Time.time - tiempoDesdeUltimoSalto >= TiempoEntreSaltos){
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
            tiempoDesdeUltimoSalto = Time.time;
    }
    
}