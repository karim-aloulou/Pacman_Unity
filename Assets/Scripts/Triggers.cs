using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggers : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float del = 3f; 

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("toEat"))
        {
            Destroy(other.gameObject);
            Invoke("AfficherObject", del);
        }
    }

    private void AfficherObject()
    {
        gameObject.SetActive(true);
    }
}
