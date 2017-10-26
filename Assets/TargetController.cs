using UnityEngine;
using System.Collections;

public class TargetController : MonoBehaviour {

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
