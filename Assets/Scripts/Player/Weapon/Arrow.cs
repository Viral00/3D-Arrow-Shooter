using UnityEngine;

public class Arrow : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private float arrowforce = 600f;

    [SerializeField] private Score score;

    private Transform target;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "collider1" && collision.gameObject.tag == "collider2" && collision.gameObject.tag == "collider3")
        {
            score.IncreaseScore(20);
        }
        else if (collision.gameObject.tag == "collider2" && collision.gameObject.tag == "collider3")
        {
            score.IncreaseScore(10);
        }
        else if (collision.gameObject.tag == "collider3")
        {
            score.IncreaseScore(5);
        }
        else
        {
            score.IncreaseScore(0);
        }

    }

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        score = GameObject.Find("Canvas").GetComponent<Score>();
    }

    private void FixedUpdate()
    {
        if (Input.GetMouseButtonUp(0))
        {   
            rb.AddForce(transform.forward * arrowforce, ForceMode.Impulse);
        }
    }
}
