using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGame : MonoBehaviour
{
    public Image image;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision hit)
    {
        image.CrossFadeAlpha(255f, 2f, false);

        //if (hit.transform.tag == "Player")
        //{
        //    SceneManager.LoadScene(main, LoadSceneMode.Single);
        //    //print("memes");
        //}
    }
}
