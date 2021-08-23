using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class propeller_spin : MonoBehaviour
{
    public float rotation_speed = 30f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, rotation_speed * Time.deltaTime);
    }
}
