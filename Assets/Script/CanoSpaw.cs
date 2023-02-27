using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanoSpaw : MonoBehaviour
{
    // Start is called before the first frame update


    public float maxTime;
    private float time;
    public GameObject cano;
    GameObject canoClone;
    public float dist;


    void Start()
    {
        CanoSpawner();
    }

    // Update is called once per frame
    void Update()
    {
        if (time > maxTime)
        {
            CanoSpawner();
            time = 0;
        }
        time += Time.deltaTime;
    }
    void CanoSpawner()
    {
        canoClone = Instantiate(cano);

        canoClone.transform.position = transform.position + new Vector3(0, Random.Range(dist,-dist),0);

    }
}
