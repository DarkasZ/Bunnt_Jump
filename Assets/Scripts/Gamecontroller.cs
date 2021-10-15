using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamecontroller : MonoBehaviour
{
    public float speed = 1.0f;
    

    Rigidbody2D rigidbody;

    public void Start()
    {
          rigidbody = GetComponent<Rigidbody2D>();
    }

    public void Update()
    {
        Vector2 f = new Vector2(0,0);
        if(Input.GetKey(KeyCode.D))
        {
           f = new Vector2(speed,0);
        }
        else if(Input.GetKey(KeyCode.A))
        {
           f = new Vector2(-speed,0);
        }
        
       
       rigidbody.AddForce(f);
    }

}
