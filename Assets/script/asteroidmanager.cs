using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroidmanager : MonoBehaviour
{
    public GameObject asteroid;
    public float limit_x =10;
    public float limit_y =6;
    public int max = 2;

    public int asteroid_counter =0;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < max; i++)
        {
            Vector3 pos = new Vector3(Random.Range(-limit_x, limit_x), Random.Range(-limit_x, limit_x));
            while(Vector3.Distance(pos,Vector3.zero)< 4f)
            {
                pos = new Vector3(Random.Range(-limit_x, limit_x), Random.Range(-limit_x, limit_x));
            }
            GameObject temp= Instantiate(asteroid, pos, Quaternion.identity);
            temp.GetComponent<asteroidcontroler>().manager = this;
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        if(asteroid_counter <=0)
            for (int i = 0; i < max; i++)
            {
                Vector3 pos = new Vector3(Random.Range(-limit_x, limit_x), Random.Range(-limit_x, limit_x));
                GameObject temp = Instantiate(asteroid, pos, Quaternion.identity);
                temp.GetComponent<asteroidcontroler>().manager = this;
            }
    }
}
