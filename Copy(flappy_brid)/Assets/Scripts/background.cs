using UnityEngine;

public class background : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * 5 * Time.deltaTime);
        if(transform.position.x < -30)
        {
            transform.position = new Vector3(30, 0, transform.position.z);
        }
       
    }
   
}
