using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckOrderPuzzle2 : MonoBehaviour
{
    public static string correctCode = "549687";
    public static string playerCode = "";
    public static int totalDigits = 0;

    public AudioClip audioPlugin;
    public AudioClip audioOpen;
    public AudioClip audioFail;

    public GameObject main;
    public GameObject Lock;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        AudioSource Audio = main.GetComponent<AudioSource>();

        Debug.Log(playerCode);
        if (totalDigits == 6)
        {
            if (playerCode == correctCode)
            {
                // Debug.Log("Correct");
                playerCode = "";

                Audio.Stop();
                Audio.PlayOneShot(audioOpen);
                Lock.SetActive(false);

            }
            else
            {
               // Debug.Log("Incorrect");
                playerCode = "";
                Audio.PlayOneShot(audioFail);
            }
            totalDigits = 0;
        }
    }

    private void OnMouseDown()
    {
        AudioSource Audio = main.GetComponent<AudioSource>();

        Audio.PlayOneShot(audioPlugin);
        playerCode += gameObject.name;
        totalDigits += 1;
    }
}
