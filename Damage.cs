using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{

    public BoxCollider2D box;


    // Start is called before the first frame update
    void Start()
    {
        box = GetComponent<BoxCollider2D>();
        box.isTrigger = true;
    }

    // Update is called once per frame
    void Update()
    {

    }

    







    }
