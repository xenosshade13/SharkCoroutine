using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireControl : MonoBehaviour
{
    public float clip = 5;
    public GameObject bulletPrefab;
    public Transform emmiter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            clip = 5;
            Debug.Log("Reloaded");
        }

        if (clip == 0)
        {
            return;
        }
      
        if (Input.GetKeyDown(KeyCode.Space) && clip > 0)
        {
            GameObject newbullet = GameObject.Instantiate(bulletPrefab);
            newbullet.transform.position = emmiter.position;
            newbullet.transform.forward = this.transform.forward;
            clip --;
            Debug.Log("Chomp!");
        }
    }
}
