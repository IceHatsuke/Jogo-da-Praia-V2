using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GloveAnimator : MonoBehaviour
{
    public Animator animator;
    public GameObject glove;
    public static bool grabOn = false;
    public Collider AreaDetectaoGlove;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            animator.SetBool("grabOn", true);

        }
        //if (Input.GetMouseButtonUp(0))
        else
        {

            animator.SetBool("grabOn", false);

        }
    }

    public void EnableCollider()
    {
        AreaDetectaoGlove.enabled = true;
    }
    public void DisableCollider()
    {
        AreaDetectaoGlove.enabled = false;
    }
}
