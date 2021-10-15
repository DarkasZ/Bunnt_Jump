using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumpable : MonoBehaviour
{
      public float jumpforce = 1.0f;

    public void OnTriggerEnter2D(Collider2D collision) 
    {
        if(collision.CompareTag("Platform"))
        {
            Debug.Log("jump");

            Rigidbody2D rigidbody = gameObject.GetComponentInParent<Rigidbody2D>();
            rigidbody.AddForce(new Vector2(0, jumpforce),ForceMode2D.Impulse);
        }
        
    }
}    
