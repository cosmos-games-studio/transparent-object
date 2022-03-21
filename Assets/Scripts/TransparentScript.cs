using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


[HelpURL("https://cosmosgames.me")]
[DisallowMultipleComponent]

public class TransparentScript : MonoBehaviour
{

    public Material transparentColor;
    public Material defaultColor;

    void Start()
    {
        BoxCollider hiddenBoxCollider = this.gameObject.AddComponent<BoxCollider>();
        hiddenBoxCollider.isTrigger = true;
        hiddenBoxCollider.center = new Vector3(0.0f, 0.3f, 0.0f);
        // hiddenBoxCollider.size = new Vector3(0.8f, 1, 1);               // Gizli Collider'ı sağdan solda temas payı bırakmak için kullanılabilir

    }

    private void OnTriggerStay(Collider other)
    {

        if (other.transform.tag == "Player")
        {
            this.GetComponent<MeshRenderer>().material = transparentColor;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            Invoke("TransColor", 0.5f);
        }
    }


    void TransColor()
    {
        this.GetComponent<MeshRenderer>().material = defaultColor;
    }



}
