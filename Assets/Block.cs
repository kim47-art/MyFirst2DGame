using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Block : MonoBehaviour
{
    public GameManager myManager;
    public int destruction_score = 100;

    // Start is called before the first frame update
    void Start()
    {
        if (Random.Range(0,2)==1)
        {
            Destroy(this.gameObject);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Ball")
        {
            myManager.AddScore(destruction_score);
            Destroy(this.gameObject);
        }
    }
}
