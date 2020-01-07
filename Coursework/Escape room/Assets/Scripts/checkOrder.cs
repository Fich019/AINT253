using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkOrder : MonoBehaviour
{
    public static string correctCode = "1213";
    public static string playerCode = "";
    public static int totalDigits = 0;

    public AudioClip audioOpen;
    public AudioClip audioLock;

    public GameObject main;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        AudioSource Audio = main.GetComponent<AudioSource>();

        Debug.Log(playerCode);
        if (totalDigits == 4)
        {
            if (playerCode == correctCode)
            {
                Debug.Log("Correct");
                playerCode = "";
                Audio.PlayOneShot(audioOpen);

            }
            else
            {
                Debug.Log("Incorrect");
                playerCode = "";
                Audio.PlayOneShot(audioLock);
            }
            totalDigits = 0;
        }
    }

    private void OnMouseDown()
    {
        playerCode += gameObject.name;
        totalDigits += 1;
    }
}
