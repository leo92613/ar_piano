using UnityEngine;
using System.Collections;
using Leap;

public class SceneManager : MonoBehaviour {
    private CapsuleCollider collider_;
	// Use this for initialization
	void Start () {
        collider_ = GetComponent<CapsuleCollider>();
	}
	
	// Update is called once per frame
    void OnTriggerEnter (Collider other)
    {
        Debug.Log("Touching the box");
        if (other.gameObject.name == "Scene1")
            Application.LoadLevel("Snow");
        
    }
	void Update () {
	
	}
}
