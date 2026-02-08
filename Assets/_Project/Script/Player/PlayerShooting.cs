using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform Firepoint;
    public GameObject arrowPrefab;
    public float arrowForce = 10f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }
    public void Shoot()
    {
        GameObject arrow = Instantiate(arrowPrefab, Firepoint.position, Firepoint.rotation);
        Rigidbody2D rb = arrow.GetComponent<Rigidbody2D>();
        rb.AddForce(Firepoint.position * arrowForce, ForceMode2D.Impulse);
    }
}
