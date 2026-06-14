using UnityEngine;

public class Movement : MonoBehaviour
{
    private bool dragging;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 muispositit = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            Collider2D hit = Physics2D.OverlapPoint(muispositit);

            if (hit != null && hit.gameObject == gameObject)
            {
                dragging = true;
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            dragging = false;
        }

        if (dragging)
        {
            Vector3 muispositit = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            muispositit.z = 0;

            transform.position = muispositit;
        }
    }
}
