using UnityEngine;
using System.Collections;

public class Manager : MonoBehaviour
{
    public GameObject left,right;
    public GameObject[] RTSObject;
     Renderer renderer;
    Transform MusicSheet;
    int state;
    // Use this for initialization
    void Start()
    {
        state = 0;
        MusicSheet = RTSObject[0].GetComponent<Transform>();
        for (int i = 1; i < RTSObject.Length; i++)
        {
            RTSObject[i].GetComponent<Transform>().position = MusicSheet.position;
            RTSObject[i].GetComponent<Transform>().localRotation = MusicSheet.localRotation;
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Touching the box");
        if (other.gameObject == left || other.gameObject == right)
        {   if (state < RTSObject.Length - 1)
            RTSObject[state].SetActive(false);
            state++;
            if (state <RTSObject.Length)
            RTSObject[state].SetActive(true);
        }
            

    }
}
