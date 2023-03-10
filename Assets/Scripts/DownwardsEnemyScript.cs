using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownwardsEnemyScript : MonoBehaviour
{
    public float moveSpeed = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * moveSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Boundary") 
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);



            moveSpeed *= -1;
        }
    }
}
