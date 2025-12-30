using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovimentation : MonoBehaviour
{
    private Rigidbody2D rb;
    private int auxDirecaox, auxDirecaoy;
    private float moveSpeed;
    public Animator animator;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        moveSpeed = 1f;
    }

    void Update(){
        if(auxDirecaox != 0){
            transform.Translate(moveSpeed * Time.deltaTime * auxDirecaox, 0, 0);     
               }
        else if(auxDirecaoy != 0){
            transform.Translate(0, moveSpeed * Time.deltaTime * auxDirecaoy, 0);     
        }

       animator.SetFloat("Vertical", auxDirecaoy);
       animator.SetFloat("Horizontal", auxDirecaox);
       
       animator.SetFloat("Speed", moveSpeed);
        
    }

    public void TouchHorinzontal(int direcao){
        auxDirecaox = direcao;
    }

    public void TouchVertical(int direcao){
        auxDirecaoy = direcao;
    }


}
