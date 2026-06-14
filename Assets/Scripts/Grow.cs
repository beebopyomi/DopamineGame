using UnityEngine;

public class Grow : MonoBehaviour
{
     public float groeigrote = 0.2f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Ik ben poep unity en ik doe het nogsteeds fucking nietttt");
        if (other.CompareTag("Food"))
        {
            Debug.Log("Ik ben poep unity en ik doe het fucking niet");
            transform.localScale += Vector3.one * groeigrote;

            Destroy(other.gameObject);
        }
    }
}
