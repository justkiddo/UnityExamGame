using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;


[RequireComponent(typeof(AudioSource))]
public class ButtonSound : MonoBehaviour
{
    [SerializeField] private AudioSource buttonSound;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            buttonSound.Play();
            
        }
    }

 

    IEnumerator Test()
    {
        yield return new WaitForSeconds(2);
    }
}
