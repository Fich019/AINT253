using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public GameObject Lock1;
    public GameObject Lock2;
    public GameObject Door;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Lock1.activeSelf == false && Lock2.activeSelf == false)
        {
            Door.GetComponent<Rigidbody>().isKinematic = false;
        }
    }
}
