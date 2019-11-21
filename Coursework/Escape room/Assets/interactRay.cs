using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class interactRay : MonoBehaviour
{
    
    [SerializeField] float RayDistance;
    [SerializeField] float scale;
    [SerializeField] Image image;
    private float maxSize = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //RaycastHit TestRay;
        //if (Physics.Raycast(Camera.position, transform.TransformDirection(Camera.forward), out TestRay, RayDistance))
        //{
        //    Debug.DrawRay(Camera.position, transform.TransformDirection(Camera.forward) * TestRay.distance, Color.yellow);

        //}

        RaycastHit hit;
        Ray ray = new Ray(transform.position, transform.forward);
        //Debug.DrawRay(transform.position, transform.forward * 7, Color.yellow);

        if (Physics.Raycast(ray, out hit, RayDistance))
        {
            Debug.Log(hit.transform.gameObject.name);
            Debug.DrawRay(transform.position, transform.forward * 7, Color.yellow);
            if (hit.transform.name == "Cube")
            {
                if (image.transform.localScale.x < maxSize)
                {
                    image.transform.localScale = image.transform.localScale * scale;
                }
                
            }
        }

        if (image.transform.localScale.x >= -maxSize)
        {
            image.transform.localScale = image.transform.localScale / scale;
        }
    }
}
