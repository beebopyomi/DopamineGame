using UnityEngine;

public class Spawnrer : MonoBehaviour
{
    public GameObject prefan;
    Vector2 muispositit = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Vector2 muispositit = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Instantiate(prefan, transform.position = muispositit, Quaternion.identity);
        }
    }
}
