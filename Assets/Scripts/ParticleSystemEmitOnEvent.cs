using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSystemEmitOnEvent : MonoBehaviour
{
    public GameObject particlePrefab;
    ParticleSystem ps;
    // Start is called before the first frame update
    void Start()
    {
        ps = GetComponent<ParticleSystem>();
        PianoKey.OnPianoKeyDown += Emit;
    }

    void Emit(int var) {
        var go = Instantiate(particlePrefab, transform.position, transform.rotation);
        ps = go.GetComponent<ParticleSystem>();
        ps.startColor = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        ps.Emit(100*var);


        Destroy(go, 1f);

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
