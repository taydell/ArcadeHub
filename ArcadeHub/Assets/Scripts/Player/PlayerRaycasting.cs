using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerRaycasting : MonoBehaviour
{
    [SerializeField]
    private float _distanceToSee;
    [SerializeField]
    private LayerMask _layerMask;
    [SerializeField]
    private GameObject _interactionText;
    RaycastHit _raycastHit;
    
    void Update()
    {
        Debug.DrawRay(this.transform.position, this.transform.forward * _distanceToSee, Color.magenta);

        if(Physics.Raycast(this.transform.position, this.transform.forward, out _raycastHit, _distanceToSee, _layerMask))
        {
            _interactionText.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                _raycastHit.collider.gameObject.GetComponent<IInteraction>().Interaction();
            }
        }
        else
        {
            _interactionText.SetActive(false);
        }
    }
}
