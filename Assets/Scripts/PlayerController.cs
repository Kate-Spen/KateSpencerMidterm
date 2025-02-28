using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject Claw_0;
    public GameObject Gummy_0;
    public float moveSpeed = 5.0f;
    Rigidbody2D body;
    public Vector2 newPosition;
    public Vector3 mousePosG;
    Camera cam;

    //gummy stuff
    public float minX = -5f, maxX = 5f;

    void Start(){
        Claw_0.SetActive(true);
        body = GetComponent<Rigidbody2D>();
        cam = Camera.main;
    }
    void Update()
    {
        float moveInput = Input.GetAxis("Horizontal");
        Claw_0.transform.Translate(Vector2.right * moveInput * moveSpeed * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.Space)){
            SpawnGummy();
            Gummy_0.GetComponent<Rigidbody2D>().gravityScale = 1;
        }
    }
    void SpawnGummy()
    {
        Vector2 spawnPosition = new Vector2(Random.Range(minX, maxX), transform.position.y);
        Instantiate(Gummy_0, spawnPosition, Quaternion.identity);
    }
}
