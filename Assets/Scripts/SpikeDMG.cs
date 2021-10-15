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
        Gameover.gameObject.SetActive(false);
        ResetBtn.gameObject.SetActive(false);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Spike"))
        {

             Debug.Log("Take Damage");
            
            Gameover.gameObject.SetActive(true);
            ResetBtn.gameObject.SetActive(true); 

        }
     

    }
    public void Restartbutton()
    {
        SceneManager.LoadScene("SampleScene");
    }

}
