using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public Image image;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        image.CrossFadeAlpha(0f, 0f, true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //private void OnCollisionEnter(Collision other)
    //{
    //    image.CrossFadeAlpha(255f, 2f, false);
    //    print("memes");

    //    if (hit.transform.tag == "Player")
    //    {
    //        SceneManager.LoadScene(main, LoadSceneMode.Single);
    //        print("memes");
    //    }
    //}

    private void OnTriggerEnter(Collider other)
    {

       // print("dreams");

        image.CrossFadeAlpha(1f, 2f, false);



    }
}
