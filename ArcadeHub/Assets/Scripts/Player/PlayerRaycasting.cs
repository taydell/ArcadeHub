using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRaycasting : MonoBehaviour
{
    [SerializeField]
    private float _distanceToSee;
    RaycastHit raycastHit;
    GameObject gameManager;

    private void Awake()
    {
        gameManager = GameObject.Find("GameManager");
    }
    
    void Update()
    {
        Debug.DrawRay(this.transform.position, this.transform.forward * _distanceToSee, Color.magenta);

        if(Physics.Raycast(this.transform.position, this.transform.forward, out raycastHit, _distanceToSee))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                var gameObjectHit = raycastHit.collider.gameObject;
                var interactionManager = gameManager.GetComponent<InteractionManager>();
                interactionManager.InteractionDecider(gameObjectHit);
            }
        }
    }
}
