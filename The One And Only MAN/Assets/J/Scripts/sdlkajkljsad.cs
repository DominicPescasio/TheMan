using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sdlkajkljsad : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        string otherTag = collision.gameObject.tag;
            if(otherTag == "Player")
        {

        }
    }
}
