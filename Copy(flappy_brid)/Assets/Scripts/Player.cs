using UnityEngine;
using TMPro;


public class Player : MonoBehaviour
{

    public bool Gameover;
    private Rigidbody2D playerrb;
    [SerializeField] private float speed;
    private int Points = 0;
    [SerializeField] private TMP_Text text;
    [SerializeField] private GameObject gameoverscence;
    private float screenwidth;
    private float screenheight = Screen.height;
    private float horizontalMin;
    private float horizontalMax;
    // Start is called before the first frame update
    void Start()
    {
         Camera camera = Camera.main;
        float halfHeight = camera.orthographicSize;
        float halfWidth = camera.aspect * halfHeight;

        horizontalMin = -halfWidth;
        horizontalMax = halfWidth;
        //this.gameObject.transform.position = new Vector3(transform.position.x,screenheight/2, transform.position.z);
        playerrb = gameObject.GetComponent<Rigidbody2D>();
    }
    
    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.Space))
       {
            Debug.Log(Input.GetKeyDown(KeyCode.Space));
            playerrb.velocity = Vector3.up * speed;
            
        }
        if(transform.position.x-0.420795>)
      
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Walls")
        {
            Debug.Log("gameover");
            Gameover = true;
            gameoverscence.SetActive(true);
            Time.timeScale = 0f;
        }

        if(collision.tag == "points")
        {
            Points++;
            text.text = "score :" + Points;
        }
    }

    
}
