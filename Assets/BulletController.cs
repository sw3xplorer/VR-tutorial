using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    [SerializeField]
    float force = 50;
    
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Destroy(this.gameObject);
        }
    }
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(transform.forward * force, ForceMode.Impulse);
    }

}
