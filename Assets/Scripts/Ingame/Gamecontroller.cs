using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamecontroller : MonoBehaviour
{
    public float speed = 1.0f;
    public float f = 0.0f;
    public Animator animator;
    [SerializeField] private int Score = 0;
    public float horizontalMove = 0.0f;
    Vector3 characterScale;
    float characterScaleX;
    private Vector3 Velocity = Vector3.zero;
    private float m_MovementSmoothing = .05f;
    private bool FacingRight = true;
    

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
        // Move the Character

       transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0f, 0f);
       animator.SetFloat("speed", characterScaleX );

         // Flip the Character

        if (Input.GetAxis("Horizontal") < 0) 
        {
            characterScale.x = -characterScaleX;
            
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            characterScale.x = characterScaleX;
            
        }
        transform.localScale = characterScale;



        //Old Code------------------------------------------------------------------------------------

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

    public void Move(float move)
    {
         Vector3 targetVelocity = new Vector2(move * 10f, rigidbody.velocity.y);
		
			rigidbody.velocity = Vector3.SmoothDamp(rigidbody.velocity, targetVelocity, ref Velocity, m_MovementSmoothing);

          if (move > 0 && !FacingRight)
			{
				
				Flip();
			}
			
			else if (move < 0 && FacingRight)
			{
				
				Flip();
			}
    }
    private void Flip()
	{
		
		FacingRight = FacingRight;

		
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
    
    
    

}
