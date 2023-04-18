using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chickSkater : MonoBehaviour
{
    [SerializeField] public float moveSpeed = 5f;

     Rigidbody m_Rigidbody;
    [SerializeField] Animator mijAnimator;
    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>(); 
        //mijAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Moving();
        Boost();
    }

    void Moving()
    {
        m_Rigidbody.transform.position += new Vector3(moveSpeed, 0, 0) * Time.deltaTime;
    }

    void Boost()
    {
        if (Input.GetKey(KeyCode.D))
        {
            mijAnimator.SetBool("isboosting", true);
        }
        else
        {
            mijAnimator.SetBool("isboosting", false);
        }
    }
}
