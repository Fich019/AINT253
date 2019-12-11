using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    [SerializeField] Sprite image;
    [SerializeField] float iwidth;
    [SerializeField] float iheight;
    private RectTransform rt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Player"){
            rt.sizeDelta = new Vector2(image.rect.width * iwidth, image.rect.height * iheight);
        }
    }
}
