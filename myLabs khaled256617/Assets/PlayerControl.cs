using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour

{
    // Start is called before the first frame update
    public float moveSpeed;
     public float jumpHeight;
     public KeyCode SpaceBar;
     public KeyCode L;
     public KeyCode R ;

     public Transfom groundCheck; 
     public float groundCheckRadius;
     public LayerMask whatIsGround;
     private bool grounded ;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(SpaceBar))
        {
            jump();
        }
         if (Input.GetKey(L))
         {
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
            if (GetComponent<SpriteRenderer>()!=null)
            {
                GetComponent<SpriteRenderer>().flipX = true ;
            }
         }

          if (Input.GetKey(R))
         {
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
         if (GetComponent<SpriteRenderer>()!=null)
            {
                GetComponent<SpriteRenderer>().flipX = false  ;
            }
         }
    }
    void jump()
 {
            GetComponent<Rigidbody2D>().velocity = new Vector2( GetComponent<Rigidbody2D>().velocity.x, jumpHeight);

} 

}

