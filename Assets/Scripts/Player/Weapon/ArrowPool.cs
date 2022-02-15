using System.Collections.Generic;
using UnityEngine;

public class ArrowPool : MonoBehaviour
{
    [SerializeField] private GameObject ArrowPrefab;
    [SerializeField] private Transform firePoint;
    private List<GameObject> poolArrow = new List<GameObject>();
    private int amountToPool = 5;

    private void Start()
    {
        for (int i = 0; i < amountToPool; i++)
        {
            GameObject arrow = Instantiate(ArrowPrefab, firePoint.position, firePoint.rotation);
            arrow.SetActive(false);
            poolArrow.Add(arrow);
        }

    }

    public GameObject GetPooledObject()
    {
        for (int i = 0; i < poolArrow.Count; i++)
        {
            if (!poolArrow[i].activeInHierarchy)
            {
                return poolArrow[i];
            }
        }

        return null;
    }
}
