using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitArea : MonoBehaviour
{

    public Rigidbody2D rig;
    

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {



            rig.constraints &= ~RigidbodyConstraints2D.FreezePositionY;
            
        }
    }
}
