using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SpikeDMG : MonoBehaviour
{
    public Text Gameover;
    public Button ResetBtn;
    void Start()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Untagged"))
        {

             Debug.Log("Take Damage");
             SceneManager.LoadScene("SampleScene");
            
            

        }
     

    }
 
}
