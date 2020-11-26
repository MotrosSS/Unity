using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public GameObject explosion;
    public AudioSource explosionSound;
    private GameObject clone;
    // Start is called before the first frame update
    void Start()
    {
        explosionSound = GameObject.Find("ExplosionSound").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter(Collision collision)
    {
        explosionSound.Play();
        clone = Instantiate(explosion, transform.position, transform.rotation);
        Destroy(gameObject);
        Destroy(clone, 2f);
    }

}
