using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createprimitive : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.CreatePrimitive(PrimitiveType.Sphere).transform.position = new Vector3(-2.43f, 3.294f, 0.8168049f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
