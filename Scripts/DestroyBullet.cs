using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBullet : MonoBehaviour
{
    private float bulletRange = 90.0f;

    public static int score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DestroyBulletRange();
    }

    // Destroy bullet
    void DestroyBulletRange()
    {
        if(transform.position.z > bulletRange || transform.position.z < -bulletRange)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);

            score += score * 25;

            Debug.Log(score);
        }
    }
}
