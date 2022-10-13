using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate512Cubes : MonoBehaviour
{
    public GameObject sampleCubePrefab;

    GameObject[] sampleCube = new GameObject[512];
    public float masScale;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i <512; i++)
        {
            GameObject instSampleCube = (GameObject)Instantiate(sampleCubePrefab);
            instSampleCube.transform.position = this.transform.position;
            instSampleCube.transform.parent = this.transform;
            instSampleCube.name = "SampleCube" + i;
            this.transform.eulerAngles = new Vector3(0, -(360 / 512f) * i, 0);
            instSampleCube.transform.position = Vector3.forward * 100;
            sampleCube[i] = instSampleCube;
        }
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < 512; i++)
        {
            if(sampleCube != null)
            {
                //sampleCube[i].transform.localScale = new Vector3(1, (AudioPeer.samples[i] * masScale) + 2, 1);
            }
        }
    }
}
