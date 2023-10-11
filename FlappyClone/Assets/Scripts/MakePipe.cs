using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePipe : MonoBehaviour {

    public GameObject pipe;
    private float timer = 0;
    public float timeDiff = 1.5f;

    void Start() {
        
    }


    void Update() {
        timer += Time.deltaTime;
        if (timer > timeDiff) {
            GameObject newpipe = Instantiate(pipe);
            newpipe.transform.position = new Vector3(6, Random.Range(-1.5f, 4.5f), 0);
            timer = 0;
            Destroy(newpipe, 5.0f);
        }
    }
}
