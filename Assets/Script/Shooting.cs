using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private AudioSource bulletSound;

    [SerializeField] private float bulletSpeed;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject gameObject = Instantiate(bulletPrefab, transform.position, transform.rotation);
            //Новый gameObject(пуля/снаряд) 
            gameObject.GetComponent<Rigidbody>().velocity = transform.forward * bulletSpeed;
            bulletSound.Play();
            transform.root.GetComponent<Rigidbody>().AddRelativeForce(transform.forward * -bulletSpeed);
        }


    }
}
