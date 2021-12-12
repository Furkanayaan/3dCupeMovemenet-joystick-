using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject boo = GameObject.FindGameObjectWithTag("Ground");
        PlayerMovement boo_ = boo.GetComponent<PlayerMovement>();
        Debug.Log(boo_);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
