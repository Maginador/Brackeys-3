using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunPickeable : MonoBehaviour
{

    [SerializeField] GunScriptableObject gunType;
    [SerializeField] Transform assetPivot;
    // Start is called before the first frame update
    void Start()
    {
        //Run animation

        //Instantiate Gun //TODO Add Pool
        var gun = Instantiate(gunType.gunAsset, transform.position, transform.rotation);
        gun.transform.parent = assetPivot;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            other.GetComponent<Player>().PickGun(gunType);
            //TODO : Add Pool
            Destroy(this.gameObject);
        }
    }
}
