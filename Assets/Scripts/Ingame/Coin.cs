using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
           StartCoroutine(Collected(collision.gameObject));

        }
    }

    IEnumerator Collected(GameObject gameObj)
    {
        
            gameObject.GetComponent<AudioSource>().Play();

            Debug.Log("Collected!!");
            Gamecontroller player = gameObj.GetComponent<Gamecontroller>();
            gameObject.GetComponent<CircleCollider2D>().enabled = false;

            player.addScore();

            while( gameObject.GetComponent<AudioSource>().isPlaying)
            {
                yield return new WaitForSeconds(0.1f);
            }
             gameObject.SetActive(false);
            

            yield return null;
    }
}
