using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Input.GetAxisRaw("Horizontal");
        Input.GetAxisRaw("Vertical");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
