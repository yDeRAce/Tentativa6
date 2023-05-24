using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleNave : MonoBehaviour
{
    public float velocidadeNave;

    private Vector2 teclasApertadas;

    public Rigidbody2D oRigidBody2D;

    public GameObject tiroNave;

    public Transform localDeDisparo;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovimentarNave();
        Atirar();
    }

    private void MovimentarNave()
    {
        teclasApertadas = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical") );
        oRigidBody2D.velocity = teclasApertadas.normalized * velocidadeNave;
    }

    private void Atirar()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Instantiate(tiroNave, localDeDisparo.position, localDeDisparo.rotation);
        }
    }
}
