using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class interactRay : MonoBehaviour
{
    
    [SerializeField] float RayDistance;
    [SerializeField] float scale;
    [SerializeField] Image image;
    private float maxSize = 1f;
    private float minSize = 0f;
    private Vector3 imageStart;
    

    // Start is called before the first frame update
    void Start()
    {
         Vector3 imageStart = image.transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        //RaycastHit TestRay;
        //if (Physics.Raycast(Camera.position, transform.TransformDirection(Camera.forward), out TestRay, RayDistance))
        //{
        //    Debug.DrawRay(Camera.position, transform.TransformDirection(Camera.forward) * TestRay.distance, Color.yellow);

        //}
        if (image.transform.localScale.x >= minSize)
        {
            image.transform.localScale = new Vector3(image.transform.localScale.x - 0.1f * Time.deltaTime * 50, image.transform.localScale.y - 0.1f * Time.deltaTime * 50, 0);
        }


        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);//new Ray(transform.position, transform.forward);
        //Debug.DrawRay(transform.position, transform.rotation.y, Color.yellow);

        if (Physics.Raycast(ray, out hit, RayDistance))
        {
            //Debug.Log(hit.transform.gameObject.tag);
            //Debug.DrawRay(transform.position, transform.forward * 7, Color.yellow);
            if (hit.transform.gameObject.tag == "Interactable")
            {
                if (image.transform.localScale.x < maxSize)
                {
                    image.transform.localScale = new Vector3(image.transform.localScale.x + 0.2f * Time.deltaTime * 50, image.transform.localScale.y + 0.2f * Time.deltaTime * 50, 0);
                }
                //for (int i = 0; i < 150; i++)
                //{


                //}

            }
        }

    }
}
