using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleBehaviour : MonoBehaviour
{
    private float speed = 30f;
    private float ObsPosSl = 6f;
    private float DestoryPos = -1f;
    private Vector3 ObsPos;

    public int lvl = 1;

    public GameObject ExpParticle;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ObsPos = transform.position;
        transform.Translate(-Vector3.forward * Time.deltaTime * Val());
        DestoryAfterPos(DestoryPos);
    }

    float Val()
    {
        float lvlSpeed = 0f;        
        switch (lvl)
        {
            case 1:
                lvlSpeed = 3f;
                break;
            case 2:
                lvlSpeed = 4f;
                break;
            case 3:
                lvlSpeed = 5f;
                break;
        }
        return speed = ObsPos.z > ObsPosSl
        ? speed + 0.1f
        : lvlSpeed;
    }
    void DestoryAfterPos(float Pos)
    {
        if(ObsPos.z < Pos)
        {
            Instantiate(ExpParticle, ObsPos, Quaternion.identity);
            Destroy(gameObject);
        }
    } 
    
    
}
