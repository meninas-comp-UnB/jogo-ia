using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody2D playerAme;
    Vector2 movimento;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movimento.x = Input.GetAxisRaw("Horizontal");
        movimento.y = Input.GetAxisRaw("Vertical");
    }
    private void fixedUpdate(){
        playerAme.MovePosition(playerAme.position + movimento * speed * Time.fixedDeltaTime);
    }
}
