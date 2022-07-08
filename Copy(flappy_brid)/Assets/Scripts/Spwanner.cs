using UnityEngine;
using UnityEngine.SceneManagement;


public class Spwanner : MonoBehaviour
{
    public static GameObject instance;
    [SerializeField] private GameObject Perfab;
    private Vector3 spwanpos;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        Instantiate(Perfab,Perfab.transform.position, Perfab.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(GetComponent<Camera>().scaledPixelWidth);
        Spwan();
    }
    void Spwan()
    {
       

       if(instance != null)
       {
            spwanpos = instance.transform.position;
            
            spwanpos.x = spwanpos.x + 7;
            spwanpos.y = Random.Range(2.5f,-3f);
            Instantiate(Perfab, spwanpos, Perfab.transform.rotation);
       }
       
    }

    public void restart()
    {
        SceneManager.LoadScene(1);
    }
    
    public void menu()
    {
        SceneManager.LoadScene(0);
       
    }
   
}
