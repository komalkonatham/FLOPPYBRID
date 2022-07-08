using UnityEngine;

public class walls : MonoBehaviour
{
    [SerializeField] private float speed;
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    private void Awake()
    {
        
      if (transform.position.x < 60)
      {
          Spwanner.instance = this.gameObject;
      }
      else
      {
          Destroy(this.gameObject);
      }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
        Destroy(); 
    }
    void Destroy()
    {
        if (transform.position.x > 60 || transform.position.x < -30)
        {
            Destroy(this.gameObject);
        }
    }
}
