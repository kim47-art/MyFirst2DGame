using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D myRigidBody;

    public float speedX = 10;
    public float speedY = 10;
    public float ratioSusceptibility = 10;
    public GameManager myManager;

    // Start is called before the first frame update
    void Start()
    {
        myRigidBody = this.gameObject.GetComponent<Rigidbody2D>();

        Vector2 force = new Vector2(speedX, speedY);

        myRigidBody.AddForce(force);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Finish")
        {
            Destroy(this.gameObject);
            myManager.GameOver();
        }

        //Playerの当たった位置に応じて進む方向を変える
        if (collision.gameObject.tag == "Player")
        {
            foreach (ContactPoint2D point in collision.contacts)
            {
                //衝突したときのプレイヤーの位置
                Vector3 pos = collision.gameObject.transform.position;
                //Debug.Log(point.point.x - pos.x);
                //衝突位置に応じて、力を加える
                myRigidBody.velocity = new Vector2((point.point.x - pos.x) * ratioSusceptibility, myRigidBody.velocity.y);
                Debug.Log(myRigidBody.velocity.y);
            }
        }
    }
}
