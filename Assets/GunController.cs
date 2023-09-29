using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    [SerializeField]
    GameObject bulletPrefab;

    // Start is called before the first frame update

    [SerializeField]
    Transform barrelEnd;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PullTrigger()
    {
        Instantiate(bulletPrefab, barrelEnd.position, barrelEnd.rotation);
    }
}
