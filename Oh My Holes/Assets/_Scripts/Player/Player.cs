using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{


    public static Transform _transform;
    public static Player _player;
    //other 
    [SerializeField] float playerDistanceFromCamera;

    //defense
    [SerializeField] float moveSpeed, health, evasion, luck;
    
    //local references
    Rigidbody localRigidbody;
    [SerializeField] Camera viewCamera;
    [SerializeField] Transform moveReference;
    [SerializeField] Transform assetsRoot;
    [SerializeField] PlayerUI UiController;
    [SerializeField] Gun currentGun;
    [SerializeField] LayerMask floorLayer;
    [SerializeField] LayerMask interactiblesLayer;


    bool canMove = true;
    // Start is called before the first frame update
    void Start()
    {
        _transform = transform;
        _player = this;
        localRigidbody = GetComponent<Rigidbody>();
    }

    internal void PickGun(GunScriptableObject gunType)
    {
        currentGun.UpdateGun(gunType);
    }

    // Update is called once per frame
    void Update()
    {
        //move player
        if(canMove)
        MovePlayer();

        //Rotate with mouse
        RotatePlayer();

        //Dig
        if(Input.GetKeyDown(KeyCode.F))
            UiController.StartAction(2, Dig);
    }

    private void Dig()
    {
        //add timer to dig 
        

        //Spawn Hole
        SpawnerSystem.instance.InstantiateHole(transform.position);
    }

    private void RotatePlayer()
    {
        //get world position from mouse 

       
        RaycastHit hit;
        var worldPos = viewCamera.ScreenToWorldPoint(Input.mousePosition + viewCamera.transform.forward* playerDistanceFromCamera);
        var direction = worldPos - viewCamera.transform.position;
        Debug.DrawLine(viewCamera.transform.position, direction * 100);
        if (!Physics.Raycast(viewCamera.transform.position, direction, out hit,100, floorLayer.value,QueryTriggerInteraction.Collide)) return;

        var colPos = hit.point;
        assetsRoot.LookAt(hit.point);
        assetsRoot.eulerAngles = new Vector3(0, assetsRoot.eulerAngles.y, 0);

    }

    private void MovePlayer()
    {

        var movePower = (moveReference.transform.right * Input.GetAxis("Horizontal")) + (moveReference.transform.forward * Input.GetAxis("Vertical"));
        transform.Translate(movePower * moveSpeed * Time.deltaTime);
      
    }
}
