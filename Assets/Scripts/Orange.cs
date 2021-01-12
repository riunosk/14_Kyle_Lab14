using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Orange : MonoBehaviour
{
    public GameObject OrangeText;

    private int OrangeCounter;
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            OrangeCounter++;
            OrangeText.GetComponent<Text>().text = "Orange : " + OrangeCounter;
            audioSource.Play();
        }
    }
}
