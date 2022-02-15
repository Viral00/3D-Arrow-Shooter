using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowController : MonoBehaviour
{
    [SerializeField] private ArrowPool arrowPool;
    [SerializeField] private GameObject shootPoint;
    [SerializeField] private Transform BowString;
    [SerializeField] private Transform target;
    [SerializeField] private Animator animator;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            animator.SetBool("Aim", true);
            animator.SetBool("Shoot", false);      
        }
        else if (Input.GetMouseButtonUp(0))
        {
            animator.SetBool("Aim", false);
            animator.SetBool("Shoot", true);
            Shoot();
        }
        else
        {
            animator.SetBool("Aim", false);
            animator.SetBool("Shoot", false);
        }
    }
    private void Shoot()
    {
        GameObject arrow = arrowPool.GetPooledObject();

        if (arrow != null)
        {
            arrow.transform.position = shootPoint.transform.position;
            arrow.transform.rotation = shootPoint.transform.rotation;
            arrow.SetActive(true);
        }
    }
}
