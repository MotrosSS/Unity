using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject prefabBullet;
    public GameObject clonePosition;
    public AudioSource audioSource;

    public float force;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            audioSource.Play();
            GameObject clone = Instantiate(prefabBullet);
            clone.transform.position = clonePosition.transform.position;
            clone.GetComponent<Rigidbody>().AddForce(clonePosition.transform.forward * force, ForceMode.Impulse);
        }
    }
}
