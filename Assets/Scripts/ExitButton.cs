using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitButton : MonoBehaviour
{
    [SerializeField] private GameObject door;
    private Rigidbody2D rigidBody;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = door.GetComponent<Rigidbody2D>();
    }
    
    void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject.tag == "Vase")
        {
            rigidBody.bodyType = RigidbodyType2D.Dynamic;
            rigidBody.gravityScale = 0;
            rigidBody.AddForce(Vector2.up * 4, ForceMode2D.Impulse);
            
        }

        
        
    }


}
