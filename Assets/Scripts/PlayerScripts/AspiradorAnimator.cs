using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AspiradorAnimator : MonoBehaviour
{
    public Collider AreaDetectaoAsp;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {

            EnableCollider();
        }
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {

            DisableCollider();

        }
    }

    public void EnableCollider()
    {
        AreaDetectaoAsp.enabled = true;
    }
    public void DisableCollider()
    {
        AreaDetectaoAsp.enabled = false;
    }
}
