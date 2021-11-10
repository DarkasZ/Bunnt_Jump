using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamecontroller : MonoBehaviour
{
    public float speed = 1.0f;
    public Animator animator;
    [SerializeField] private int Score = 0;
    public float horizontalMove = 0.0f;
    Vector3 characterScale;
    float characterScaleX;
    

    Rigidbody2D rigidbody;


    public void addScore()
    {
       Score = Score +1 ;
    }

    public int Getscore()
    {
       return Score;
    }

    public void Start()
    {
         rigidbody = GetComponent<Rigidbody2D>();
         
         characterScale = transform.localScale;
         characterScaleX = characterScale.x;

    }

    public void Update()
    {
        // Move the Character:
       transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0f, 0f);
       animator.SetFloat("speed", characterScaleX );

         // Flip the Character:
        if (Input.GetAxis("Horizontal") < 0) 
        {
            characterScale.x = -characterScaleX;
            
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            characterScale.x = characterScaleX;
            
        }
        transform.localScale = characterScale;

        //Old Code
         /*Vector2 f = new Vector2(0,0);
        if(Input.GetKey(KeyCode.D))
        {
           f = new Vector2(speed,0);
        }
        else if(Input.GetKey(KeyCode.A))
        {
           f = new Vector2(-speed,0);
        }*/
        
        
        
       
      // rigidbody.AddForce(f);
    }
    
    
    

}
