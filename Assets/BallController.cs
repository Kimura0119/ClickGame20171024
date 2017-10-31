using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour {

  public void Shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }
    private void OnCollisionEnter(Collision collision)
    {
        //Destroy(gameObject);
    }
    

    // Update is called once per frame
    void Update () {
        

	}
}
