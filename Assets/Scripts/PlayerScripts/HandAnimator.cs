using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandAnimator : MonoBehaviour
{
   
    public Animator animator;
    public GameObject glove;
    public static bool grabOn = false;
    public Collider AreaDetectao;


    void Start()
    {
        animator = GetComponent<Animator>();
    }

    
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {

            animator.SetBool("grabOn" ,true);

        }
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {

            animator.SetBool("grabOn", false);

        }    
               

    }
    public void EnableCollider()
    {
        AreaDetectao.enabled = true;
    }
    public void DisableCollider()
    {
        AreaDetectao.enabled = false;
    }
    public void DisableHand()
    {
      GameObject hand = GameObject.FindWithTag("Mao").gameObject;
      hand.transform.Translate(0, -10, 0);
      hand.SetActive(false);
    }
    public  void EnabledHand()
    {
        Debug.Log("MaoLuva");
        glove.SetActive(true);
        DisableHand();
    }
  


}
